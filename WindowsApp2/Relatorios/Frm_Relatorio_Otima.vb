Imports System.Configuration
Imports System.Data.OleDb

Public Class Frm_Relatorio_Otima
    Public sql, dt1, dt2, hr1, hr2 As String
    Public filtrarTudo As Boolean
    Public dt As DataTable

    Private Sub Frm_Relatorio_Otima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.stk_dados_sensor_esteira'. Você pode movê-la ou removê-la conforme necessário.
        'Me.stk_dados_sensor_esteiraTableAdapter.Fill(Me.DataSet1.stk_dados_sensor_esteira)
        'If filtrarTudo Then
        '    Me.stk_dados_sensor_esteiraTableAdapter.Fill(Me.DataSet1.stk_dados_sensor_esteira)
        'Else
        '    Me.stk_dados_sensor_esteiraTableAdapter.FiltraRelatorio(Me.DataSet1.stk_dados_sensor_esteira, sql)
        'End If

        'Dim dataInicial = Convert.ToDateTime(dt1).ToString("MM/dd/yyyy")
        'Dim dataFinal = Convert.ToDateTime(dt2).ToString("MM/dd/yyyy")

        'sql = "SELECT * FROM porta2 WHERE data BETWEEN #" & dataInicial & "# AND #" & dataFinal & "# ORDER BY codigo DESC;"

        'Try
        '    Using cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Qnt_portas.mdb;Persist Security Info=False;Jet OLEDB:Database Password=;")
        '        cn.Open()
        '        Using da = New OleDbDataAdapter(sql, cn)
        '            da.Fill(Me.DataSet1.stk_dados_sensor_esteira)
        '        End Using
        '        cn.Close()
        '    End Using
        'Catch ex As Exception

        'End Try

        'Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("7C9EBDFC1C60", "Sensor Empacotadeira"))
        'Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("7C9EBDFC1B90", "Sensor Lixadeira"))




        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados_Sensor_Esteira", dt))
        'Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Sensor1", "Empacotadeira"))
        'Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Sensor2", "Lixadeira"))

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class