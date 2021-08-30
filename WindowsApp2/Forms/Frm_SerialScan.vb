Imports System.Data.OleDb

Public Class Frm_SerialScan
    Private carregarGrid As New Conexao
    Dim dr As OleDbDataReader
    Dim totalUnity As Integer = 0
    Dim sqlInsert As String
    Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Qnt_portas.mdb;Persist Security Info=False;Jet OLEDB:Database Password=;")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnection.Open()
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
            'Call Form1_Load(Me, e)
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
        'btn_conectar.Enabled = True
        cmb_scan.Items.Clear()
        cmb_scan.Text = ""
        btn_conectar.BringToFront()
        Timer1.Stop()
        SerialPort1.Close()

    End Sub

    Private Sub Frm_SerialScan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        myConnection.Dispose()
        myConnection.Close()
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Try
            'Dim i As Integer = SerialPort1.ReadExisting
            'Dim result As Double = i / 1000
            System.Threading.Thread.Sleep(250)
            Dim mac As String = SerialPort1.ReadExisting

            If Not mac = String.Empty Then
                'sqlInsert = "INSERT INTO toras([tora_medida], [tora_qnt], [data_hora]) VALUES (" & result.ToString.Replace(",", ".").Trim & " , " & totalUnity & " , '" & Format(Now, "dd/MM/yyyy HH:mm:ss") & "')" & Environment.NewLine
                'Dim sql = "SELECT *,(extract(hour from c_hora) :: Text || ':' || extract(Minute from c_hora) :: Text) :: time AS hora FROM stk_dados_sensor_esteira WHERE " + auxData + auxHora + " ORDER BY c_data DESC;"
                sqlInsert = "INSERT INTO porta2([mac]) VALUES ('" & mac.ToString.Replace(",", ".").Trim & "')"
                Dim command As New OleDbCommand(sqlInsert, myConnection)
                command.ExecuteNonQuery()
                command.Dispose()
                txt_serial.Invoke(Sub() txt_serial.Text = mac & txt_serial.Text)
                lbl_medida.Invoke(Sub() lbl_medida.Text = Format(Now, "dd/MM/yyyy HH:mm:ss"))
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmd_filtrar_Click(sender As Object, e As EventArgs) Handles cmd_filtrar.Click
        Dim contador As Integer

        sqlInsert = "SELECT codigo, mac, data FROM porta2 ORDER BY codigo DESC;"
        Dim command As New OleDbCommand(sqlInsert, myConnection)
        dr = command.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                dg_portas.Rows.Insert(contador, 1)
                dg_portas.Rows(contador).Cells(dg_portas_codigo.Name).Value = If(IsDBNull(dr("codigo")), 0, dr("codigo"))
                dg_portas.Rows(contador).Cells(dg_portas_mac.Name).Value = If(IsDBNull(dr("mac")), 0, dr("mac"))
                dg_portas.Rows(contador).Cells(dg_portas_data.Name).Value = If(IsDBNull(dr("data")), 0, dr("data"))
                contador += 1
            End While

        End If
    End Sub

    Private Sub cmd_limpar_Click(sender As Object, e As EventArgs) Handles cmd_limpar.Click
        dg_portas.Rows.Clear()
    End Sub
End Class
