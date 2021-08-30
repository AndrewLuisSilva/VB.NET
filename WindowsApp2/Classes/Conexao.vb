Imports System.Data.OleDb

Public Class Conexao
    Private ConectarDB As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Qnt_portas.mdb;Persist Security Info=False;Jet OLEDB:Database Password=;")
    Private ComandoDB As OleDbCommand
    Private DataAdapterDB As OleDbDataAdapter
    Public DataTableDB As DataTable
    Public DataReader As OleDbDataReader

    Public Sub ExecuteQuery(ByVal Query As String)
        Try
            ConectarDB.Open()
            ComandoDB = New OleDbCommand(Query, ConectarDB)
            DataTableDB = New DataTable
            DataAdapterDB = New OleDbDataAdapter(ComandoDB)
            DataAdapterDB.Fill(DataTableDB)
            ConectarDB.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
