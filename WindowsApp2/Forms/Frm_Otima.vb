Imports System.Data.OleDb
Imports Npgsql

Public Class Frm_Otima
    Private carregarGrid As New Conexao
    Dim limparGrid, filtrar As Boolean
    Dim drPG As NpgsqlDataReader
    Dim sqlInsertPG As String
    Dim sqlRecebe As String
    Dim data1, data2, hora1, hora2 As String
    Dim sqlInsert As String

    Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Qnt_portas.mdb;Persist Security Info=False;Jet OLEDB:Database Password=;")
    Dim myConnectionPG As New NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=OTIMA_DADOS;UserId=postgres;Password=knop123;")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectionPG.Open()
        Me.CenterToParent()
        btn_conectar.Enabled = False
        btn_conectar.BringToFront()
        btn_desconectar.Enabled = False
        btn_desconectar.SendToBack()
        cmb_baud.Text = "115200"
    End Sub

    Private Sub btn_scan_Click(sender As Object, e As EventArgs) Handles btn_scan.Click
        cmb_scan.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        cmb_scan.Items.AddRange(myPort)
        i = cmb_scan.Items.Count
        i = i - i
        Try
            cmb_scan.SelectedIndex = i
        Catch ex As Exception
            Dim result As DialogResult
            result = MessageBox.Show("COM Port não detectada!", "Atenção", MessageBoxButtons.OK)
            cmb_scan.Text = ""
            cmb_scan.Items.Clear()
            Exit Sub
        End Try
        btn_conectar.Enabled = True
        btn_conectar.BringToFront()
        cmb_scan.DroppedDown = True
    End Sub

    Private Sub btn_conectar_Click(sender As Object, e As EventArgs) Handles btn_conectar.Click
        If cmb_scan.SelectedIndex < 0 Then Exit Sub
        btn_conectar.Enabled = False
        btn_conectar.SendToBack()
        SerialPort1.BaudRate = cmb_baud.SelectedItem
        SerialPort1.PortName = cmb_scan.SelectedItem
        btn_desconectar.Enabled = True
        btn_desconectar.BringToFront()
        SerialPort1.Open()
        Timer1.Start()
    End Sub

    Private Sub btn_desconectar_Click(sender As Object, e As EventArgs) Handles btn_desconectar.Click
        btn_desconectar.Enabled = False
        btn_desconectar.SendToBack()
        cmb_scan.Items.Clear()
        cmb_scan.Text = ""
        btn_conectar.BringToFront()
        Timer1.Stop()
        SerialPort1.Close()

    End Sub

    Private Sub Frm_SerialScan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        myConnectionPG.Dispose()
        myConnectionPG.Close()

    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            System.Threading.Thread.Sleep(250)
            Dim mac As String = SerialPort1.ReadExisting
            If Not mac = String.Empty Then
                sqlInsertPG = "INSERT INTO stk_dados_sensor_esteira(cod_mac_adress) VALUES ('" & mac.ToString.Replace(",", ".").Trim & "');"
                Dim commandPG As New NpgsqlCommand(sqlInsertPG, myConnectionPG)
                commandPG.ExecuteNonQuery()
                commandPG.Dispose()
                lbl_medida.Invoke(Sub() lbl_medida.Text = Format(Now, "dd/MM/yyyy HH:mm:ss"))

                '---------gravar access
                'myConnection.Open()
                'sqlInsert = "INSERT INTO portas_otima([mac]) VALUES ('" & mac.ToString.Replace(",", ".").Trim & "')"
                'Dim command As New OleDbCommand(sqlInsert, myConnection)
                'command.ExecuteNonQuery()
                'command.Dispose()
                'myConnection.Close()
                '---------------------

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub filtrarGrid()

        If tab_control_lora_receiver.SelectedTab Is tb_page_serial_scan Then
            Dim dt As New DataTable
            If Not limparGrid Then
                sqlInsertPG = "SELECT *,(extract(hour from c_hora) :: Text|| ':' || extract(Minute from c_hora) :: Text|| ':' || split_part(extract(seconds from c_hora) :: Text,'.',1) ) :: time AS hora FROM stk_dados_sensor_esteira ORDER BY c_data DESC;"
                Dim da As New NpgsqlDataAdapter(sqlInsertPG, myConnectionPG)
                da.Fill(dt)
            End If
            dg_portas.AutoGenerateColumns = False
            dg_portas.DataSource = dt
        End If

        If tab_control_lora_receiver.SelectedTab Is tb_page_dados_coletados Then
            Dim auxData As String = ""
            Dim auxHora As String = ""
            Dim validaHorario As String = ""

            If IsDate(msk_data1.Text) Then
                If IsDate(msk_data2.Text) Then
                    auxData += "c_data >= '" & Format(CDate(msk_data1.Text), "yyyy-MM-dd") & "' AND c_data <= '" & Format(CDate(msk_data2.Text), "yyyy-MM-dd") & "' "
                    data1 = Format(CDate(msk_data1.Text), "yyyy-MM-dd")
                    data2 = Format(CDate(msk_data2.Text), "yyyy-MM-dd")
                Else
                    auxData += "c_data = '" & Format(CDate(msk_data1.Text), "yyyy-MM-dd") & "' "
                    data1 = Format(CDate(msk_data1.Text), "yyyy-MM-dd")
                End If
            End If

            If Not IsDate(msk_data1.Text) And IsDate(msk_data2.Text) Then
                MsgBox("Informe uma data inicial para filtrar!", vbOKOnly + vbInformation, "Atenção")
                msk_data1.Focus()
                Exit Sub
            End If

            If IsDate(msk_hora1.Text) Then
                If IsDate(msk_hora2.Text) Then
                    If auxData <> "" Then
                        auxData += " AND "
                    End If
                    auxHora += "hora >= '" & msk_hora1.Text & "' AND hora <= '" & msk_hora2.Text & "' "
                    hora1 = msk_hora1.Text
                    hora2 = msk_hora2.Text
                Else
                    auxData += "hora = '" & msk_hora1.Text & "' "
                    hora1 = msk_hora1.Text
                End If

                If Not IsDate(msk_hora1.Text) And IsDate(msk_hora2.Text) Then
                    MsgBox("Informe uma hora inicial para filtrar!", vbOKOnly + vbInformation, "Atenção")
                    msk_hora1.Focus()
                    Exit Sub
                End If

            End If
            If auxHora = "" And auxData = "" Then Exit Sub

            'sqlRecebe = auxData + auxHora
            Dim sql = "SELECT * FROM stk_dados_sensor_esteira WHERE " + auxData + auxHora + "ORDER BY c_data DESC;"
            sqlRecebe = sql

            Dim dt As New DataTable
            Dim da As New NpgsqlDataAdapter(sql, myConnectionPG)
            da.Fill(dt)
            dg_dados_coletados.AutoGenerateColumns = False
            dg_dados_coletados.DataSource = dt

        End If

    End Sub

    Private Sub cmd_filtrar_Click(sender As Object, e As EventArgs) Handles cmd_filtrar.Click
        limparGrid = False
        filtrarGrid()
    End Sub

    Private Sub cmd_limpar_Click(sender As Object, e As EventArgs) Handles cmd_limpar.Click
        limparGrid = True
        filtrarGrid()
    End Sub

    Private Sub cmd_filtrar_dg_dados_coletados_Click(sender As Object, e As EventArgs) Handles cmd_filtrar_dg_dados_coletados.Click
        filtrarGrid()
    End Sub

    Private Sub cmd_imprimir_Click(sender As Object, e As EventArgs) Handles cmd_imprimir.Click
        If dg_dados_coletados.Rows.Count < 0 Then Exit Sub
        'Dim data As New DataTable
        'Dim da As New NpgsqlDataAdapter(sqlRecebe, myConnectionPG)
        'da.Fill(data)

        Using dlg As New Frm_Relatorio_Otima
            dlg.dt = GerarDadosRelatorio()
            dlg.ShowDialog()
        End Using

        'If chk_filtrar_tudo.Checked Then
        '    filtrar = True
        '    Using dlg As New Frm_Relatorio_Otima
        '        dlg.filtrarTudo = filtrar
        '        dlg.ShowDialog()
        '    End Using
        'Else
        '    filtrar = False
        '    Using dlg As New Frm_Relatorio_Otima
        '        dlg.dt1 = msk_data1.Text
        '        dlg.dt2 = msk_data1.Text
        '        dlg.hr1 = hora1
        '        dlg.hr2 = hora2
        '        dlg.filtrarTudo = filtrar
        '        dlg.ShowDialog()
        '    End Using
        'End If

    End Sub

    Private Function GerarDadosRelatorio() As DataTable
        Dim dt As New DataTable
        'Dim lista As New List(Of Dados)()

        dt.Columns.Add("mac")
        dt.Columns.Add("data")
        dt.Columns.Add("hora")

        For Each linhas As DataGridViewRow In dg_dados_coletados.Rows
            dt.Rows.Add(linhas.Cells("dg_dados_coletados_mac").Value.ToString,
                        linhas.Cells("dg_dados_coletados_data").Value.ToString,
                        linhas.Cells("dg_dados_coletados_hora").Value.ToString)
        Next
        Return dt
    End Function


End Class

