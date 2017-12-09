<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnBacklight = New System.Windows.Forms.Button()
        Me.btnPowerOn = New System.Windows.Forms.Button()
        Me.btnPowerOff = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.lstMeterArray = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDataStream = New System.Windows.Forms.TextBox()
        Me.radStreamOn = New System.Windows.Forms.RadioButton()
        Me.radStreamOff = New System.Windows.Forms.RadioButton()
        Me.grpStream = New System.Windows.Forms.GroupBox()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.txtPowerState = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.AxMG17Motor1 = New AxMG17MotorLib.AxMG17Motor()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.grpStream.SuspendLayout()
        Me.grpControls.SuspendLayout()
        CType(Me.AxMG17Motor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBacklight
        '
        Me.btnBacklight.Location = New System.Drawing.Point(9, 87)
        Me.btnBacklight.Name = "btnBacklight"
        Me.btnBacklight.Size = New System.Drawing.Size(64, 23)
        Me.btnBacklight.TabIndex = 8
        Me.btnBacklight.Text = "Backlight"
        Me.btnBacklight.UseVisualStyleBackColor = True
        '
        'btnPowerOn
        '
        Me.btnPowerOn.Location = New System.Drawing.Point(9, 49)
        Me.btnPowerOn.Name = "btnPowerOn"
        Me.btnPowerOn.Size = New System.Drawing.Size(64, 23)
        Me.btnPowerOn.TabIndex = 9
        Me.btnPowerOn.Text = "Power On"
        Me.btnPowerOn.UseVisualStyleBackColor = True
        '
        'btnPowerOff
        '
        Me.btnPowerOff.Location = New System.Drawing.Point(79, 49)
        Me.btnPowerOff.Name = "btnPowerOff"
        Me.btnPowerOff.Size = New System.Drawing.Size(64, 23)
        Me.btnPowerOff.TabIndex = 10
        Me.btnPowerOff.Text = "Power Off"
        Me.btnPowerOff.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.Location = New System.Drawing.Point(79, 87)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(64, 23)
        Me.btnZero.TabIndex = 11
        Me.btnZero.Text = "Zero"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'lstMeterArray
        '
        Me.lstMeterArray.FormattingEnabled = True
        Me.lstMeterArray.Location = New System.Drawing.Point(23, 60)
        Me.lstMeterArray.Name = "lstMeterArray"
        Me.lstMeterArray.Size = New System.Drawing.Size(91, 43)
        Me.lstMeterArray.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Connected Meters"
        '
        'txtDataStream
        '
        Me.txtDataStream.Location = New System.Drawing.Point(6, 44)
        Me.txtDataStream.Name = "txtDataStream"
        Me.txtDataStream.Size = New System.Drawing.Size(100, 20)
        Me.txtDataStream.TabIndex = 21
        '
        'radStreamOn
        '
        Me.radStreamOn.AutoSize = True
        Me.radStreamOn.Location = New System.Drawing.Point(6, 21)
        Me.radStreamOn.Name = "radStreamOn"
        Me.radStreamOn.Size = New System.Drawing.Size(39, 17)
        Me.radStreamOn.TabIndex = 23
        Me.radStreamOn.TabStop = True
        Me.radStreamOn.Text = "On"
        Me.radStreamOn.UseVisualStyleBackColor = True
        '
        'radStreamOff
        '
        Me.radStreamOff.AutoSize = True
        Me.radStreamOff.Location = New System.Drawing.Point(51, 21)
        Me.radStreamOff.Name = "radStreamOff"
        Me.radStreamOff.Size = New System.Drawing.Size(39, 17)
        Me.radStreamOff.TabIndex = 24
        Me.radStreamOff.TabStop = True
        Me.radStreamOff.Text = "Off"
        Me.radStreamOff.UseVisualStyleBackColor = True
        '
        'grpStream
        '
        Me.grpStream.Controls.Add(Me.radStreamOff)
        Me.grpStream.Controls.Add(Me.radStreamOn)
        Me.grpStream.Controls.Add(Me.txtDataStream)
        Me.grpStream.Location = New System.Drawing.Point(125, 40)
        Me.grpStream.Name = "grpStream"
        Me.grpStream.Size = New System.Drawing.Size(112, 72)
        Me.grpStream.TabIndex = 25
        Me.grpStream.TabStop = False
        Me.grpStream.Text = "Streaming Data"
        '
        'grpControls
        '
        Me.grpControls.Controls.Add(Me.txtPowerState)
        Me.grpControls.Controls.Add(Me.Label1)
        Me.grpControls.Controls.Add(Me.txtSerialNumber)
        Me.grpControls.Controls.Add(Me.btnPowerOn)
        Me.grpControls.Controls.Add(Me.btnPowerOff)
        Me.grpControls.Controls.Add(Me.btnZero)
        Me.grpControls.Controls.Add(Me.btnBacklight)
        Me.grpControls.Location = New System.Drawing.Point(257, 40)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(198, 118)
        Me.grpControls.TabIndex = 27
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "Meter Controls"
        '
        'txtPowerState
        '
        Me.txtPowerState.Location = New System.Drawing.Point(149, 52)
        Me.txtPowerState.Name = "txtPowerState"
        Me.txtPowerState.Size = New System.Drawing.Size(42, 20)
        Me.txtPowerState.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selected Meter"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(91, 20)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtSerialNumber.TabIndex = 0
        '
        'AxMG17Motor1
        '
        Me.AxMG17Motor1.Enabled = True
        Me.AxMG17Motor1.Location = New System.Drawing.Point(23, 246)
        Me.AxMG17Motor1.Name = "AxMG17Motor1"
        Me.AxMG17Motor1.OcxState = CType(resources.GetObject("AxMG17Motor1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMG17Motor1.Size = New System.Drawing.Size(432, 306)
        Me.AxMG17Motor1.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(565, 507)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 45)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Execute Experiment"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(588, 41)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(57, 20)
        Me.NumericUpDown1.TabIndex = 30
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(588, 95)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(57, 20)
        Me.TextBox1.TabIndex = 32
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"20", "60"})
        Me.ComboBox1.Location = New System.Drawing.Point(588, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(57, 21)
        Me.ComboBox1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(473, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Travel Distance (mm)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(473, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Number of Steps"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(473, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Current Jog Size (mm)"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(475, 192)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(84, 255)
        Me.TextBox2.TabIndex = 36
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(565, 192)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(80, 255)
        Me.TextBox3.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(473, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Distance (mm)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(562, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Power"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(23, 561)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(622, 10)
        Me.ProgressBar1.TabIndex = 40
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(23, 192)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(319, 20)
        Me.TextBox4.TabIndex = 41
        '
        'Browse
        '
        Me.Browse.Location = New System.Drawing.Point(348, 191)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(58, 20)
        Me.Browse.TabIndex = 42
        Me.Browse.Text = "Browse"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox5.Location = New System.Drawing.Point(659, 0)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(1, 1)
        Me.TextBox5.TabIndex = 43
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(184, 120)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(47, 20)
        Me.TextBox6.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Wavelength Compensation (nm)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "(Must be between 400 and 1065)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Save File"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(472, 457)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Minimum Power"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(472, 484)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Maximum Power"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(565, 454)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(80, 20)
        Me.TextBox8.TabIndex = 52
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(565, 478)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(80, 20)
        Me.TextBox10.TabIndex = 54
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(476, 507)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 45)
        Me.Button4.TabIndex = 57
        Me.Button4.Text = "Cancel Experiment"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(669, 24)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Location = New System.Drawing.Point(23, 218)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(242, 13)
        Me.TextBox7.TabIndex = 60
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(473, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Motor Direction"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Forward", "Reverse"})
        Me.ComboBox2.Location = New System.Drawing.Point(565, 121)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox2.TabIndex = 62
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(473, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Serial Number"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"83814884", "80861744", "80861727"})
        Me.ComboBox3.Location = New System.Drawing.Point(565, 148)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox3.TabIndex = 65
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(669, 592)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AxMG17Motor1)
        Me.Controls.Add(Me.grpControls)
        Me.Controls.Add(Me.grpStream)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstMeterArray)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpStream.ResumeLayout(False)
        Me.grpStream.PerformLayout()
        Me.grpControls.ResumeLayout(False)
        Me.grpControls.PerformLayout()
        CType(Me.AxMG17Motor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBacklight As System.Windows.Forms.Button
    Friend WithEvents btnPowerOn As System.Windows.Forms.Button
    Friend WithEvents btnPowerOff As System.Windows.Forms.Button
    Friend WithEvents btnZero As System.Windows.Forms.Button
    Friend WithEvents lstMeterArray As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDataStream As System.Windows.Forms.TextBox
    Friend WithEvents radStreamOn As System.Windows.Forms.RadioButton
    Friend WithEvents radStreamOff As System.Windows.Forms.RadioButton
    Friend WithEvents grpStream As System.Windows.Forms.GroupBox
    Friend WithEvents grpControls As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPowerState As System.Windows.Forms.TextBox
    Friend WithEvents AxMG17Motor1 As AxMG17MotorLib.AxMG17Motor
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Browse As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox3 As ComboBox
End Class
