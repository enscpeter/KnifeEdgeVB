
Public Class Form2
    Private wave As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        wave = TextBox1.Text
        Me.Hide()
    End Sub

    Public Property WV As String
        Get
            Return wave
        End Get
        Set(value As String)
        End Set
    End Property

End Class