Imports FieldMax2DLLServer

Public Class cFM2Notify

    Implements FieldMax2DLLServer.IFM2DeviceEvents

    Private m_CallbackEvent As String
    Private m_CallbackMessage As String
    Private m_DeviceIndex As Short
    Private m_SerialNumber As String
    Private m_ZeroDeviceTimeoutCounter As Short

    Public Property CallbackEvent() As String Implements FieldMax2DLLServer.IFM2DeviceEvents.CallbackEvent
        Get
            CallbackEvent = m_CallbackEvent
        End Get
        Set(ByVal value As String)
            m_CallbackEvent = value
        End Set
    End Property

    Public Property CallbackMessage() As String Implements FieldMax2DLLServer.IFM2DeviceEvents.CallbackMessage
        Get
            CallbackMessage = m_CallbackMessage
        End Get
        Set(ByVal value As String)
            m_CallbackMessage = value
        End Set
    End Property

    Public Property DeviceIndex() As Short Implements FieldMax2DLLServer.IFM2DeviceEvents.DeviceIndex
        Get
            DeviceIndex = m_DeviceIndex
        End Get
        Set(ByVal value As Short)
            m_DeviceIndex = value
        End Set
    End Property

    Public Sub DisplayErrorToClient() Implements FieldMax2DLLServer.IFM2DeviceEvents.DisplayErrorToClient
        Form1.DisplayErrorMessage(m_CallbackMessage)
    End Sub

    Public Sub DisplayZeroDeviceProgressToClient() Implements FieldMax2DLLServer.IFM2DeviceEvents.DisplayZeroDeviceProgressToClient
        Form1.DisplayZeroDeviceProgress(m_CallbackMessage, m_ZeroDeviceTimeoutCounter)
    End Sub

    Public Sub NotifyData(CallbackData As FieldMax2DLLServer.IFM2DeviceEvents) Implements FieldMax2DLLServer.IFM2DeviceEvents.NotifyData
        Form1.NotifyData(CallbackData)
    End Sub

    Public Sub NotifyDeviceStatus(CallbackData As FieldMax2DLLServer.IFM2DeviceEvents, DevicesList As FieldMax2DLLServer.cFM2Devices) Implements FieldMax2DLLServer.IFM2DeviceEvents.NotifyDeviceStatus
        Form1.NotifyDeviceStatus(CallbackData, DevicesList)
    End Sub

    Public Property SerialNumber() As String Implements FieldMax2DLLServer.IFM2DeviceEvents.SerialNumber
        Get
            SerialNumber = m_SerialNumber
        End Get
        Set(ByVal value As String)
            m_SerialNumber = value
        End Set
    End Property

    Public WriteOnly Property ZeroDeviceTimeoutCounter() As Short Implements FieldMax2DLLServer.IFM2DeviceEvents.ZeroDeviceTimeoutCounter
        Set(ByVal value As Short)
            m_ZeroDeviceTimeoutCounter = value
        End Set
    End Property
End Class