<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Otima
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_medida = New System.Windows.Forms.Label()
        Me.lbl_txt = New System.Windows.Forms.Label()
        Me.cmb_scan = New System.Windows.Forms.ComboBox()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_conectar = New System.Windows.Forms.Button()
        Me.cmb_baud = New System.Windows.Forms.ComboBox()
        Me.btn_desconectar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmd_filtrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmd_limpar = New System.Windows.Forms.ToolStripButton()
        Me.dg_portas = New System.Windows.Forms.DataGridView()
        Me.dg_portas_mac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_portas_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_portas_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.tab_control_lora_receiver = New System.Windows.Forms.TabControl()
        Me.tb_page_serial_scan = New System.Windows.Forms.TabPage()
        Me.tb_page_dados_coletados = New System.Windows.Forms.TabPage()
        Me.dg_dados_coletados = New System.Windows.Forms.DataGridView()
        Me.dg_dados_coletados_mac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_dados_coletados_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_dados_coletados_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_filtrar_tudo = New System.Windows.Forms.CheckBox()
        Me.msk_hora2 = New System.Windows.Forms.MaskedTextBox()
        Me.msk_data2 = New System.Windows.Forms.MaskedTextBox()
        Me.msk_hora1 = New System.Windows.Forms.MaskedTextBox()
        Me.msk_data1 = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_imprimir = New System.Windows.Forms.Button()
        Me.cmd_filtrar_dg_dados_coletados = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dg_portas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control_lora_receiver.SuspendLayout()
        Me.tb_page_serial_scan.SuspendLayout()
        Me.tb_page_dados_coletados.SuspendLayout()
        CType(Me.dg_dados_coletados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lbl_medida)
        Me.Panel2.Controls.Add(Me.lbl_txt)
        Me.Panel2.Controls.Add(Me.cmb_scan)
        Me.Panel2.Controls.Add(Me.btn_scan)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_conectar)
        Me.Panel2.Controls.Add(Me.cmb_baud)
        Me.Panel2.Controls.Add(Me.btn_desconectar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 93)
        Me.Panel2.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Ultima mensagem recebida: "
        '
        'lbl_medida
        '
        Me.lbl_medida.AutoSize = True
        Me.lbl_medida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_medida.Location = New System.Drawing.Point(192, 46)
        Me.lbl_medida.Name = "lbl_medida"
        Me.lbl_medida.Size = New System.Drawing.Size(0, 15)
        Me.lbl_medida.TabIndex = 8
        '
        'lbl_txt
        '
        Me.lbl_txt.AutoSize = True
        Me.lbl_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_txt.Location = New System.Drawing.Point(0, 36)
        Me.lbl_txt.Name = "lbl_txt"
        Me.lbl_txt.Size = New System.Drawing.Size(0, 15)
        Me.lbl_txt.TabIndex = 7
        '
        'cmb_scan
        '
        Me.cmb_scan.FormattingEnabled = True
        Me.cmb_scan.Location = New System.Drawing.Point(98, 12)
        Me.cmb_scan.Name = "cmb_scan"
        Me.cmb_scan.Size = New System.Drawing.Size(87, 21)
        Me.cmb_scan.TabIndex = 1
        '
        'btn_scan
        '
        Me.btn_scan.Location = New System.Drawing.Point(5, 10)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(87, 23)
        Me.btn_scan.TabIndex = 0
        Me.btn_scan.Text = "Scan"
        Me.btn_scan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Baud"
        '
        'btn_conectar
        '
        Me.btn_conectar.Location = New System.Drawing.Point(336, 12)
        Me.btn_conectar.Name = "btn_conectar"
        Me.btn_conectar.Size = New System.Drawing.Size(87, 23)
        Me.btn_conectar.TabIndex = 4
        Me.btn_conectar.Text = "Conectar"
        Me.btn_conectar.UseVisualStyleBackColor = True
        '
        'cmb_baud
        '
        Me.cmb_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_baud.FormattingEnabled = True
        Me.cmb_baud.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200"})
        Me.cmb_baud.Location = New System.Drawing.Point(230, 12)
        Me.cmb_baud.Name = "cmb_baud"
        Me.cmb_baud.Size = New System.Drawing.Size(85, 21)
        Me.cmb_baud.TabIndex = 3
        '
        'btn_desconectar
        '
        Me.btn_desconectar.Location = New System.Drawing.Point(336, 12)
        Me.btn_desconectar.Name = "btn_desconectar"
        Me.btn_desconectar.Size = New System.Drawing.Size(87, 23)
        Me.btn_desconectar.TabIndex = 6
        Me.btn_desconectar.Text = "Desconectar"
        Me.btn_desconectar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_filtrar, Me.ToolStripSeparator1, Me.cmd_limpar})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 96)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(438, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmd_filtrar
        '
        Me.cmd_filtrar.Image = Global.WindowsApp2.My.Resources.Resources.redo
        Me.cmd_filtrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmd_filtrar.Name = "cmd_filtrar"
        Me.cmd_filtrar.Size = New System.Drawing.Size(97, 22)
        Me.cmd_filtrar.Text = "Carregar Grid"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmd_limpar
        '
        Me.cmd_limpar.Image = Global.WindowsApp2.My.Resources.Resources.fileclose
        Me.cmd_limpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmd_limpar.Name = "cmd_limpar"
        Me.cmd_limpar.Size = New System.Drawing.Size(89, 22)
        Me.cmd_limpar.Text = "Limpar Grid"
        '
        'dg_portas
        '
        Me.dg_portas.AllowUserToAddRows = False
        Me.dg_portas.AllowUserToDeleteRows = False
        Me.dg_portas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dg_portas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_portas.BackgroundColor = System.Drawing.Color.White
        Me.dg_portas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_portas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dg_portas_mac, Me.dg_portas_data, Me.dg_portas_hora})
        Me.dg_portas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_portas.Location = New System.Drawing.Point(3, 121)
        Me.dg_portas.Name = "dg_portas"
        Me.dg_portas.ReadOnly = True
        Me.dg_portas.RowHeadersVisible = False
        Me.dg_portas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_portas.Size = New System.Drawing.Size(438, 340)
        Me.dg_portas.TabIndex = 14
        '
        'dg_portas_mac
        '
        Me.dg_portas_mac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dg_portas_mac.DataPropertyName = "cod_mac_adress"
        Me.dg_portas_mac.HeaderText = "Endereço MAC"
        Me.dg_portas_mac.Name = "dg_portas_mac"
        Me.dg_portas_mac.ReadOnly = True
        '
        'dg_portas_data
        '
        Me.dg_portas_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dg_portas_data.DataPropertyName = "c_data"
        Me.dg_portas_data.HeaderText = "Data"
        Me.dg_portas_data.Name = "dg_portas_data"
        Me.dg_portas_data.ReadOnly = True
        '
        'dg_portas_hora
        '
        Me.dg_portas_hora.DataPropertyName = "hora"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dg_portas_hora.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_portas_hora.HeaderText = "Hora"
        Me.dg_portas_hora.Name = "dg_portas_hora"
        Me.dg_portas_hora.ReadOnly = True
        '
        'SerialPort1
        '
        '
        'tab_control_lora_receiver
        '
        Me.tab_control_lora_receiver.Controls.Add(Me.tb_page_serial_scan)
        Me.tab_control_lora_receiver.Controls.Add(Me.tb_page_dados_coletados)
        Me.tab_control_lora_receiver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_control_lora_receiver.Location = New System.Drawing.Point(0, 0)
        Me.tab_control_lora_receiver.Name = "tab_control_lora_receiver"
        Me.tab_control_lora_receiver.SelectedIndex = 0
        Me.tab_control_lora_receiver.Size = New System.Drawing.Size(452, 490)
        Me.tab_control_lora_receiver.TabIndex = 15
        '
        'tb_page_serial_scan
        '
        Me.tb_page_serial_scan.Controls.Add(Me.dg_portas)
        Me.tb_page_serial_scan.Controls.Add(Me.ToolStrip1)
        Me.tb_page_serial_scan.Controls.Add(Me.Panel2)
        Me.tb_page_serial_scan.Location = New System.Drawing.Point(4, 22)
        Me.tb_page_serial_scan.Name = "tb_page_serial_scan"
        Me.tb_page_serial_scan.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_page_serial_scan.Size = New System.Drawing.Size(444, 464)
        Me.tb_page_serial_scan.TabIndex = 0
        Me.tb_page_serial_scan.Text = "Serial Scan"
        Me.tb_page_serial_scan.UseVisualStyleBackColor = True
        '
        'tb_page_dados_coletados
        '
        Me.tb_page_dados_coletados.Controls.Add(Me.dg_dados_coletados)
        Me.tb_page_dados_coletados.Controls.Add(Me.GroupBox1)
        Me.tb_page_dados_coletados.Location = New System.Drawing.Point(4, 22)
        Me.tb_page_dados_coletados.Name = "tb_page_dados_coletados"
        Me.tb_page_dados_coletados.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_page_dados_coletados.Size = New System.Drawing.Size(444, 464)
        Me.tb_page_dados_coletados.TabIndex = 1
        Me.tb_page_dados_coletados.Text = "Dados Coletados"
        Me.tb_page_dados_coletados.UseVisualStyleBackColor = True
        '
        'dg_dados_coletados
        '
        Me.dg_dados_coletados.AllowUserToAddRows = False
        Me.dg_dados_coletados.AllowUserToDeleteRows = False
        Me.dg_dados_coletados.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue
        Me.dg_dados_coletados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_dados_coletados.BackgroundColor = System.Drawing.Color.White
        Me.dg_dados_coletados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_dados_coletados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dg_dados_coletados_mac, Me.dg_dados_coletados_data, Me.dg_dados_coletados_hora})
        Me.dg_dados_coletados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_dados_coletados.Location = New System.Drawing.Point(3, 104)
        Me.dg_dados_coletados.Name = "dg_dados_coletados"
        Me.dg_dados_coletados.ReadOnly = True
        Me.dg_dados_coletados.RowHeadersVisible = False
        Me.dg_dados_coletados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_dados_coletados.Size = New System.Drawing.Size(438, 357)
        Me.dg_dados_coletados.TabIndex = 15
        '
        'dg_dados_coletados_mac
        '
        Me.dg_dados_coletados_mac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dg_dados_coletados_mac.DataPropertyName = "cod_mac_adress"
        Me.dg_dados_coletados_mac.HeaderText = "Endereço MAC"
        Me.dg_dados_coletados_mac.Name = "dg_dados_coletados_mac"
        Me.dg_dados_coletados_mac.ReadOnly = True
        '
        'dg_dados_coletados_data
        '
        Me.dg_dados_coletados_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dg_dados_coletados_data.DataPropertyName = "c_data"
        Me.dg_dados_coletados_data.HeaderText = "Data"
        Me.dg_dados_coletados_data.Name = "dg_dados_coletados_data"
        Me.dg_dados_coletados_data.ReadOnly = True
        '
        'dg_dados_coletados_hora
        '
        Me.dg_dados_coletados_hora.DataPropertyName = "hora"
        DataGridViewCellStyle4.Format = "t"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.dg_dados_coletados_hora.DefaultCellStyle = DataGridViewCellStyle4
        Me.dg_dados_coletados_hora.HeaderText = "Hora"
        Me.dg_dados_coletados_hora.Name = "dg_dados_coletados_hora"
        Me.dg_dados_coletados_hora.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_filtrar_tudo)
        Me.GroupBox1.Controls.Add(Me.msk_hora2)
        Me.GroupBox1.Controls.Add(Me.msk_data2)
        Me.GroupBox1.Controls.Add(Me.msk_hora1)
        Me.GroupBox1.Controls.Add(Me.msk_data1)
        Me.GroupBox1.Controls.Add(Me.cmd_imprimir)
        Me.GroupBox1.Controls.Add(Me.cmd_filtrar_dg_dados_coletados)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 101)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por"
        '
        'chk_filtrar_tudo
        '
        Me.chk_filtrar_tudo.AutoSize = True
        Me.chk_filtrar_tudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_filtrar_tudo.Location = New System.Drawing.Point(194, 53)
        Me.chk_filtrar_tudo.Name = "chk_filtrar_tudo"
        Me.chk_filtrar_tudo.Size = New System.Drawing.Size(75, 17)
        Me.chk_filtrar_tudo.TabIndex = 14
        Me.chk_filtrar_tudo.Text = "Filtrar tudo"
        Me.chk_filtrar_tudo.UseVisualStyleBackColor = True
        '
        'msk_hora2
        '
        Me.msk_hora2.Location = New System.Drawing.Point(96, 73)
        Me.msk_hora2.Mask = "00:00"
        Me.msk_hora2.Name = "msk_hora2"
        Me.msk_hora2.Size = New System.Drawing.Size(65, 20)
        Me.msk_hora2.TabIndex = 13
        Me.msk_hora2.ValidatingType = GetType(Date)
        '
        'msk_data2
        '
        Me.msk_data2.Location = New System.Drawing.Point(96, 31)
        Me.msk_data2.Mask = "00/00/0000"
        Me.msk_data2.Name = "msk_data2"
        Me.msk_data2.Size = New System.Drawing.Size(65, 20)
        Me.msk_data2.TabIndex = 12
        Me.msk_data2.ValidatingType = GetType(Date)
        '
        'msk_hora1
        '
        Me.msk_hora1.Location = New System.Drawing.Point(6, 73)
        Me.msk_hora1.Mask = "00:00"
        Me.msk_hora1.Name = "msk_hora1"
        Me.msk_hora1.Size = New System.Drawing.Size(65, 20)
        Me.msk_hora1.TabIndex = 11
        Me.msk_hora1.ValidatingType = GetType(Date)
        '
        'msk_data1
        '
        Me.msk_data1.Location = New System.Drawing.Point(6, 32)
        Me.msk_data1.Mask = "00/00/0000"
        Me.msk_data1.Name = "msk_data1"
        Me.msk_data1.Size = New System.Drawing.Size(65, 20)
        Me.msk_data1.TabIndex = 10
        Me.msk_data1.ValidatingType = GetType(Date)
        '
        'cmd_imprimir
        '
        Me.cmd_imprimir.Location = New System.Drawing.Point(357, 50)
        Me.cmd_imprimir.Name = "cmd_imprimir"
        Me.cmd_imprimir.Size = New System.Drawing.Size(75, 23)
        Me.cmd_imprimir.TabIndex = 9
        Me.cmd_imprimir.Text = "Imprimir"
        Me.cmd_imprimir.UseVisualStyleBackColor = True
        '
        'cmd_filtrar_dg_dados_coletados
        '
        Me.cmd_filtrar_dg_dados_coletados.Location = New System.Drawing.Point(273, 50)
        Me.cmd_filtrar_dg_dados_coletados.Name = "cmd_filtrar_dg_dados_coletados"
        Me.cmd_filtrar_dg_dados_coletados.Size = New System.Drawing.Size(75, 23)
        Me.cmd_filtrar_dg_dados_coletados.TabIndex = 8
        Me.cmd_filtrar_dg_dados_coletados.Text = "Filtrar"
        Me.cmd_filtrar_dg_dados_coletados.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "e"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "e"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data"
        '
        'Frm_Otima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 490)
        Me.Controls.Add(Me.tab_control_lora_receiver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_Otima"
        Me.Text = "LoRa Receiver"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dg_portas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_control_lora_receiver.ResumeLayout(False)
        Me.tb_page_serial_scan.ResumeLayout(False)
        Me.tb_page_serial_scan.PerformLayout()
        Me.tb_page_dados_coletados.ResumeLayout(False)
        CType(Me.dg_dados_coletados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_medida As Label
    Friend WithEvents lbl_txt As Label
    Friend WithEvents cmb_scan As ComboBox
    Friend WithEvents btn_scan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_conectar As Button
    Friend WithEvents cmb_baud As ComboBox
    Friend WithEvents btn_desconectar As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmd_filtrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmd_limpar As ToolStripButton
    Friend WithEvents dg_portas As DataGridView
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents tab_control_lora_receiver As TabControl
    Friend WithEvents tb_page_serial_scan As TabPage
    Friend WithEvents tb_page_dados_coletados As TabPage
    Friend WithEvents dg_dados_coletados As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_filtrar_dg_dados_coletados As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents msk_hora2 As MaskedTextBox
    Friend WithEvents msk_data2 As MaskedTextBox
    Friend WithEvents msk_hora1 As MaskedTextBox
    Friend WithEvents msk_data1 As MaskedTextBox
    Friend WithEvents cmd_imprimir As Button
    Friend WithEvents dg_dados_coletados_mac As DataGridViewTextBoxColumn
    Friend WithEvents dg_dados_coletados_data As DataGridViewTextBoxColumn
    Friend WithEvents dg_dados_coletados_hora As DataGridViewTextBoxColumn
    Friend WithEvents dg_portas_mac As DataGridViewTextBoxColumn
    Friend WithEvents dg_portas_data As DataGridViewTextBoxColumn
    Friend WithEvents dg_portas_hora As DataGridViewTextBoxColumn
    Friend WithEvents chk_filtrar_tudo As CheckBox
    Friend WithEvents Timer1 As Timer
End Class
