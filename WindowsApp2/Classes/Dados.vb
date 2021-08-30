Public Class Dados
    Public mac As String
    Public data As DateTime
    Public hora As DateTime

    Public Sub New(ByVal _mac As String, ByVal _data As DateTime, ByVal _hora As DateTime)
        Me.mac = _mac
        Me.data = _data
        Me.hora = _hora
    End Sub
End Class

