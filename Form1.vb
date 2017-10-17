Imports FieldMax2DLLServer
Imports System.Math

''' <summary>
''' This example was created in Visual Basic 2010. This is a simple programming example that is set up to use the power measurement
''' feature on the FieldMaxII meters. The FieldMax2DLLServer has to be added to the project as a reference in order for this to work.
''' This DLL is installed as part of the standard FieldMaxII software installation. It can then be added to the project as a COM reference.
''' To add this to the project, select "Project > Add Reference" from the Visual Stud  io menu bar. Then select the COM tab from that menu.
''' Scroll down the list to find the "FieldMax2DLLServer". Select it and press the OK button.  This will add the DLL as a reference in
''' the program. The cFM2Notify class is used to handle status change events and data transmission between the meter and the program.
''' </summary>
''' <remarks></remarks>

Public Class Form1

    Private Declare Sub Sleep Lib "kernel32.dll" (ByVal dwMilliseconds As Long)
    ' This is the private instance of the cFM2Listener class
    Dim FieldMax2Listener As cFM2Listener
    ' This points to the cFM2Listener object's IFM2Listener interface
    Dim ThisListener As IFM2Listener
    ' This is the private instance of the cFM2Device class
    Dim FieldMax2 As cFM2Device
    ' Timer objects
    Dim ScanUSBForChange As cFM2ScanUSBForChange
    Dim ScanForData As cFM2ScanForData
    ' Callback sink (receives event notifications)
    Dim NotifyMe As cFM2Notify
    ' Devices collection returned from the DLL server
    Dim m_DevicesList As cFM2Devices
    ' This array stores serial numbers of the meters that are available to be connected to.
    Dim strHelpPath As String = System.IO.Path.Combine(Application.StartupPath, "KnifeEdge.chm")

    Dim MeterArray() As String
    Private TravelDist As Integer = 0
    Private StepSize As Integer = 1
    Private JogAmt As Double = 0.1
    Private TotDist As Double = 0
    Private ExportText As String = String.Empty
    Private Min As Double = 0
    Private Max As Double = 0
    Private State As Integer = 1
    Private WVdelta As Integer = 0
    Private Saved As Integer = 0
    Private WV As Integer
    Private WVset As String
    Private Switch As Integer = 1


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Calls the sub that initializes a connection with the meters.
        HelpProvider1.HelpNamespace = strHelpPath

        Call ClientSetup()
        ' Turns the streaming data mode on.
        radStreamOn.Checked = True

        AxMG17Motor1.StartCtrl()
        ' Start motor control

        Text = "Knife Edge Experiment"
    End Sub


    Private Sub ClientSetup()
        ' Create two object variables to inherit all base class functionality
        FieldMax2Listener = New cFM2Listener
        ThisListener = FieldMax2Listener

        ScanUSBForChange = New cFM2ScanUSBForChange
        ScanForData = New cFM2ScanForData

        NotifyMe = New cFM2Notify

        ' Initialize callback notifications for the listener
        FieldMax2Listener.DeviceEvents = NotifyMe

        ' Start the USB device timer and check for status change
        ScanUSBForChange.CheckTimer(ThisListener)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Calls the sub the releases connection with the meters.
        ClientTearDown()
    End Sub

    Private Sub ClientTearDown()
        ' Stops the program from looking for new connections and new data.
        ScanUSBForChange.StopTimer()
        ScanForData.StopTimer()

        ' Iterate through all devices in the collection and close any open device driver handles.
        If Not (m_DevicesList Is Nothing) Then
            If Not (m_DevicesList.Count = 0) Then
                Dim device As IFM2Device
                For Each device In m_DevicesList
                    device.CloseAllUSBDeviceDrivers(device.DeviceHandle)
                Next
            End If
        End If
    End Sub

    Friend Sub NotifyDeviceStatus(ByVal CallbackData As IFM2DeviceEvents, ByVal DevicesList As cFM2Devices)
        ' This sub keeps track of what meters are available to be connected to. Meters are added and removed from the program through this.
        Dim device As IFM2Device

        ' The SelectedMeter variable is used to keep track of what meter is currently selected while other meters are being added or removed.
        Dim SelectedMeter As String
        SelectedMeter = lstMeterArray.SelectedItem

        ' Set the private instance of the collection.
        m_DevicesList = DevicesList

        ' Determines actions to take depending on whether a meter was just added or removed from the collection.
        Select Case CallbackData.CallbackEvent
            Case "MeterAdded"
                ' Get the current device from the collection.
                device = m_DevicesList.Item(CallbackData.DeviceIndex)
                ' Initialize callback notifications for the device.
                device.DeviceEvents = NotifyMe
                ' Start the data check timer.
                ScanForData.CheckTimer(m_DevicesList)
                ' Resizes the array that keeps track of the meter serial numbers.
                ReDim Preserve MeterArray(DevicesList.Count - 1)
                ' Loads a meter serial number into the array based on the index of the device.
                MeterArray(device.DeviceIndex) = device.SerialNumber
                ' Loads the meter serial number from the array into the listbox.
                lstMeterArray.Items.Insert(device.DeviceIndex, MeterArray(device.DeviceIndex))
            Case "MeterRemoved"
                ' Removes the meter serial number from the array.
                MeterArray(CallbackData.DeviceIndex) = Nothing
                ' Removes the meter serial number from the listbox.
                lstMeterArray.Items.Remove(CallbackData.SerialNumber)
            Case Else
                MsgBox("UNHANDLED STATUS EVENT: " & CallbackData.CallbackEvent)
        End Select

        ' Determines which meter in the list will be selected after new devices are added or removed.
        If DevicesList.Count = 0 Then
            lstMeterArray.SelectedIndex = -1
        ElseIf SelectedMeter = CallbackData.SerialNumber Then
            lstMeterArray.SelectedIndex = 0
        ElseIf SelectedMeter = "" Then
            lstMeterArray.SelectedIndex = 0
        Else
            lstMeterArray.SelectedItem = SelectedMeter
        End If
        ' Runs the MeterStatus sub to update the power state and serial number of the meter.
        Try
            MeterStatus()
        Catch
            ' MeterStatus will not update correctly if the selected meter is disconnected.
        End Try

    End Sub

    Friend Sub NotifyData(ByVal CallbackData As IFM2DeviceEvents)
        ' This sub keeps track of any data or messages being sent from the connected meter (or meters) to the program.
        Dim device As IFM2Device
        device = m_DevicesList.Item(CallbackData.DeviceIndex)

        ' This narrows down the data being displayed in the program to only the data from the selected serial number.
        ' Without this line, data from all connected meters will dump into the program.
        If lstMeterArray.SelectedItem <> device.SerialNumber Then Exit Sub

        ' Handles the data and messages being sent from the meter.
        Select Case CallbackData.CallbackEvent
            Case "MeasurementData"
                If radStreamOn.Checked = True Then
                    txtDataStream.Text = NumFormat(device.LastData)
                    If WVdelta = 0 Then
                        TextBox6.Text = device.Wavelength
                    End If
                Else
                        txtDataStream.Text = ""
                End If
            Case "PacketIsOverrange"
                txtDataStream.Text = "Over Range"
            Case "OverTemperature"
                txtDataStream.Text = "Temperature Error!"
            Case "PowerOn"
                txtPowerState.Text = "On"
            Case "PowerOff"
                txtPowerState.Text = "Off"
        End Select
    End Sub

    Friend Sub DisplayErrorMessage(ByVal ErrorMessage As String)
        ' Displays any error messages returned from the device.
        MsgBox(ErrorMessage)
    End Sub

    Friend Sub DisplayZeroDeviceProgress(ByVal CallbackMessage As String, ByVal ZeroDeviceTimeoutCount As Integer)
        ' Returns the status of the zero process.
        If CallbackMessage = "Zero successful" Then
            btnZero.Text = "Zero"
        Else
            btnZero.Text = "Zero Failed"
        End If
    End Sub

    Private Sub btnBacklight_Click(sender As System.Object, e As System.EventArgs) Handles btnBacklight.Click
        ' Toggles the backlight state.
        Dim device As IFM2Device
        device = m_DevicesList.Item(Array.IndexOf(MeterArray, lstMeterArray.SelectedItem))
        If device.Backlight = True Then
            device.BacklightCommand(False)
        Else
            device.BacklightCommand(True)
        End If
    End Sub

    Private Sub btnPowerOn_Click(sender As System.Object, e As System.EventArgs) Handles btnPowerOn.Click
        ' Turns the meter on.
        Dim device As IFM2Device
        device = m_DevicesList.Item(Array.IndexOf(MeterArray, lstMeterArray.SelectedItem))
        device.PowerStateCommand(True)
    End Sub

    Private Sub btnPowerOff_Click(sender As System.Object, e As System.EventArgs) Handles btnPowerOff.Click
        ' Turns the meter off.
        Dim device As IFM2Device
        device = m_DevicesList.Item(Array.IndexOf(MeterArray, lstMeterArray.SelectedItem))
        device.PowerStateCommand(False)
    End Sub

    Private Sub btnZero_Click(sender As System.Object, e As System.EventArgs) Handles btnZero.Click
        ' Zeroes the meter.
        Dim device As IFM2Device
        device = m_DevicesList.Item(Array.IndexOf(MeterArray, lstMeterArray.SelectedItem))
        device.ZeroDevice()
    End Sub

    Private Sub MeterStatus()
        ' Checks the meter's power state and serial number. This can be used when a new meter is added, removed, or selected from the listbox.
        Dim device As IFM2Device
        device = m_DevicesList.Item(Array.IndexOf(MeterArray, lstMeterArray.SelectedItem))
        If device.PowerState = True Then
            txtPowerState.Text = "On"
        Else
            txtPowerState.Text = "Off"
        End If
        txtSerialNumber.Text = device.SerialNumber
    End Sub

    Private Sub lstMeterArray_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstMeterArray.SelectedIndexChanged
        ' Runs the MeterStatus sub each time a new device is selected from the listbox.
        Try
            MeterStatus()
        Catch
            ' MeterStatus will not update correctly if the selected meter is the one disconnected.
        End Try
    End Sub

    Private Function NumFormat(ByVal Num As Single)
        ' This function takes the power reading in scientific notation and splits it into a numeric value and the relevant units.
        Dim Numeric As Single
        Dim Unit As String
        Dim DigFormat As String = ""
        Dim NumSign As Short

        NumSign = Sign(Num) ' Determines the sign of the power reading.
        Num = Abs(Num) ' Takes the absolute value of the power reading to determine units.

        ' Determines the units for the power reading.
        If Num > 1000 Then
            Numeric = Num / 1000
            Unit = "kW"
        ElseIf Num > 1 Then
            Numeric = Num
            Unit = "W"
        ElseIf Num > 0.001 Then
            Numeric = Num * 1000
            Unit = "mW"
        ElseIf Num > 0.000001 Then
            Numeric = Num * 1000000
            Unit = "µW"
        ElseIf Num > 0.000000001 Then
            Numeric = Num * 1000000000.0
            Unit = "nW"
        Else
            Numeric = Num
            Unit = "W"
        End If

        ' Determines the decimal resolution to use.
        If Numeric < 10 Then
            DigFormat = "0.000"
        ElseIf Numeric < 100 Then
            DigFormat = "00.00"
        ElseIf Numeric < 1000 Then
            DigFormat = "000.0"
        Else
            DigFormat = "######.###"
        End If

        Numeric = Numeric * NumSign ' Adds the sign back into the power reading.
        Return Format(Numeric, DigFormat) & " " & Unit ' Returns the numeric value of the power reading and the associated units.
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Convert string to integer
        StepSize = Convert.ToInt32(ComboBox1.SelectedItem)
        ' Calculate jog distance based on travel distance and step size
        JogAmt = (TravelDist / StepSize)
        ' Display travel distance in textbox
        TextBox1.Text = JogAmt
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        ' Set minimum and maximum values for updown box
        NumericUpDown1.Minimum = 1
        NumericUpDown1.Maximum = 6
        ' Set total distance to travel to updown box value
        TravelDist = NumericUpDown1.Value
        ' Calculate jog distance based on travel distance and step size
        JogAmt = (TravelDist / StepSize)
        ' Display travel distance in textbox
        TextBox1.Text = JogAmt
    End Sub

    Private Sub ResetFields()
        ' Clear textboxes and restore values to initial states
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        TotDist = 0
        ProgressBar1.Value = 0
        State = 1
    End Sub

    Private Sub CheckEmpty()
        ' Subroutine checks to see if file is empty by seeing is size is above 3 bytes
        If FileLen(SaveFileDialog1.FileName) > 3 Then
            Saved = 2
            ' Sets Saved flag to indicate that the file is not empty and will be needed to be overwritten
        Else
            Saved = 1
            ' Sets Saved flag to indicate the file is empty and ready for writing
        End If

    End Sub

    Private Sub TrySave()
        Try
            My.Computer.FileSystem.WriteAllText _
(SaveFileDialog1.FileName, TextBox5.Text, False)
            MessageBox.Show("Results haved been saved to " & SaveFileDialog1.FileName,
"Experiment Complete!", MessageBoxButtons.OK)
            TextBox4.Text = SaveFileDialog1.FileName
            TextBox5.Text = ""
            TextBox7.Text = "The most recent experiment data has been saved"
        Catch
            MessageBox.Show("The file is being used by another process, please close it and save again using the browse button.",
"Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox7.Text = "The most recent experiment data is unsaved"
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim device As IFM2Device

        If StepSize = 1 Or TravelDist = 0 Then
            MessageBox.Show("Please make sure Travel Distance and Number of Steps have been set", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not Saved = 0 Then
            CheckEmpty()
        End If

        AxMG17Motor1.SetJogStepSize(0, JogAmt)
        ResetFields()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = StepSize
        TextBox5.Text = "Distance (mm),Power (W)" & Environment.NewLine

        For index As Integer = 0 To StepSize
            device = m_DevicesList.Item(Array.IndexOf(MeterArray, lstMeterArray.SelectedItem)) ' Uses selected power meter

            TextBox2.Text += Round(TotDist, 4) & Environment.NewLine
            TextBox3.Text += NumFormat(device.LastData) & Environment.NewLine
            TextBox5.Text += TotDist & "," & device.LastData & Environment.NewLine

            If State = 0 Then
                Exit For
            End If

            If index < StepSize Then
                AxMG17Motor1.MoveJog(0, Switch)
            End If

            ' Update min and max power values as experiment occurs
            If index = 0 Then
                Max = device.LastData
                Min = device.LastData
            Else
                If Max < device.LastData Then
                    Max = device.LastData
                End If
                If Min > device.LastData Then
                    Min = device.LastData
                End If
            End If

            TotDist += JogAmt ' Increment total distance traveled 
            TextBox8.Text = NumFormat(Min)
            TextBox10.Text = NumFormat(Max)

            ResponsiveSleep(3000) ' Allows data to still stream despite sleeping
            ProgressBar1.Increment(1)
        Next

        If ProgressBar1.Value = StepSize Then

            If Saved = 0 Then
                MessageBox.Show("The experiment is finished, please save results to a .csv file",
    "Experiment Complete!", MessageBoxButtons.OK)
                TextBox7.Text = "The most recent experiment data is unsaved"

            ElseIf Saved = 1 Then
                TrySave()

            ElseIf Saved = 2 Then

                Dim Result = MessageBox.Show("The experiment is finished, would you like to overwrite " & SaveFileDialog1.FileName & "?", "Overwrite File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Result = DialogResult.Yes Then
                    TrySave()

                ElseIf Result = DialogResult.No Then
                    TextBox7.Text = "The most recent experiment data is unsaved"
                    Exit Sub
                End If

            End If

        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.AcceptsReturn = True
        TextBox3.Multiline = True
        TextBox3.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.AcceptsReturn = True
        TextBox2.Multiline = True
        TextBox2.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
        Then
            Try
                My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, TextBox5.Text, False)
                TextBox4.Text = SaveFileDialog1.FileName
                CheckEmpty()
                If TextBox5.Text <> "" Then
                    TextBox7.Text = "The most recent experiment data has been saved"
                End If
                TextBox5.Text = ""

            Catch
                MessageBox.Show("The file Is being used by another process, please close it and try again.",
    "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If
    End Sub

    Private Sub ResponsiveSleep(ByRef iMilliSeconds As Integer)
        Dim i As Integer, iHalfSeconds As Integer = iMilliSeconds / 500
        For i = 1 To iHalfSeconds
            Threading.Thread.Sleep(500) : Application.DoEvents()
        Next i
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox5.Multiline = True
        TextBox5.Visible = False
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        WVdelta = 1
        Dim device As IFM2Device
        Dim WV As Integer
        device = m_DevicesList.Item(Array.IndexOf(MeterArray, lstMeterArray.SelectedItem))
        If IsNumeric(TextBox6.Text) Then
            WV = Convert.ToInt32(TextBox6.Text)
            If WV >= 400 And WV <= 1065 Then
                device.WavelengthCommand(WV)
                WVdelta = 0
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        State = 0
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.TableOfContents)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Developed by Peter Le" & Environment.NewLine & "School of Engineering Science" & Environment.NewLine & "Simon Fraser University 2017")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Reverse" Then
            Switch = 2
        Else
            Switch = 1
        End If
    End Sub

End Class
