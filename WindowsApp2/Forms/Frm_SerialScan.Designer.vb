<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_SerialScan
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_serial = New System.Windows.Forms.TextBox()
        Me.btn_desconectar = New System.Windows.Forms.Button()
        Me.cmb_baud = New System.Windows.Forms.ComboBox()
        Me.btn_conectar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.cmb_scan = New System.Windows.Forms.ComboBox()
        Me.lbl_txt = New System.Windows.Forms.Label()
        Me.lbl_medida = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dg_portas = New System.Windows.Forms.DataGridView()
        Me.dg_portas_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_portas_mac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_portas_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmd_filtrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmd_limpar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dg_portas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'txt_serial
        '
        Me.txt_serial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_serial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_serial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_serial.Location = New System.Drawing.Point(3, 78)
        Me.txt_serial.Multiline = True
        Me.txt_serial.Name = "txt_serial"
        Me.txt_serial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_serial.Size = New System.Drawing.Size(438, 383)
        Me.txt_serial.TabIndex = 7
        Me.txt_serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'btn_conectar
        '
        Me.btn_conectar.Location = New System.Drawing.Point(336, 12)
        Me.btn_conectar.Name = "btn_conectar"
        Me.btn_conectar.Size = New System.Drawing.Size(87, 23)
        Me.btn_conectar.TabIndex = 4
        Me.btn_conectar.Text = "Conectar"
        Me.btn_conectar.UseVisualStyleBackColor = True
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
        'btn_scan
        '
        Me.btn_scan.Location = New System.Drawing.Point(5, 10)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(87, 23)
        Me.btn_scan.TabIndex = 0
        Me.btn_scan.Text = "Scan"
        Me.btn_scan.UseVisualStyleBackColor = True
        '
        'cmb_scan
        '
        Me.cmb_scan.FormattingEnabled = True
        Me.cmb_scan.Location = New System.Drawing.Point(98, 12)
        Me.cmb_scan.Name = "cmb_scan"
        Me.cmb_scan.Size = New System.Drawing.Size(87, 21)
        Me.cmb_scan.TabIndex = 1
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
        'lbl_medida
        '
        Me.lbl_medida.AutoSize = True
        Me.lbl_medida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_medida.Location = New System.Drawing.Point(192, 46)
        Me.lbl_medida.Name = "lbl_medida"
        Me.lbl_medida.Size = New System.Drawing.Size(0, 15)
        Me.lbl_medida.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_medida)
        Me.Panel1.Controls.Add(Me.lbl_txt)
        Me.Panel1.Controls.Add(Me.cmb_scan)
        Me.Panel1.Controls.Add(Me.btn_scan)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_conectar)
        Me.Panel1.Controls.Add(Me.cmb_baud)
        Me.Panel1.Controls.Add(Me.btn_desconectar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 75)
        Me.Panel1.TabIndex = 9
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
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(452, 490)
        Me.TabControl2.TabIndex = 10
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt_serial)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(444, 464)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Serial Scanner"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dg_portas)
        Me.TabPage4.Controls.Add(Me.ToolStrip1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(444, 464)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Dados Coletados"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dg_portas
        '
        Me.dg_portas.AllowUserToAddRows = False
        Me.dg_portas.AllowUserToDeleteRows = False
        Me.dg_portas.AllowUserToResizeRows = False
        Me.dg_portas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_portas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dg_portas_codigo, Me.dg_portas_mac, Me.dg_portas_data})
        Me.dg_portas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_portas.Location = New System.Drawing.Point(3, 28)
        Me.dg_portas.Name = "dg_portas"
        Me.dg_portas.ReadOnly = True
        Me.dg_portas.RowHeadersVisible = False
        Me.dg_portas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_portas.Size = New System.Drawing.Size(438, 433)
        Me.dg_portas.TabIndex = 11
        '
        'dg_portas_codigo
        '
        Me.dg_portas_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dg_portas_codigo.DataPropertyName = "codigo"
        Me.dg_portas_codigo.HeaderText = "Código"
        Me.dg_portas_codigo.Name = "dg_portas_codigo"
        Me.dg_portas_codigo.ReadOnly = True
        '
        'dg_portas_mac
        '
        Me.dg_portas_mac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dg_portas_mac.DataPropertyName = "mac"
        Me.dg_portas_mac.HeaderText = "Endereço MAC"
        Me.dg_portas_mac.Name = "dg_portas_mac"
        Me.dg_portas_mac.ReadOnly = True
        '
        'dg_portas_data
        '
        Me.dg_portas_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dg_portas_data.DataPropertyName = "data"
        Me.dg_portas_data.HeaderText = "Data"
        Me.dg_portas_data.Name = "dg_portas_data"
        Me.dg_portas_data.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_filtrar, Me.ToolStripSeparator1, Me.cmd_limpar})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(438, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmd_filtrar
        '
        Me.cmd_filtrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmd_filtrar.Name = "cmd_filtrar"
        Me.cmd_filtrar.Size = New System.Drawing.Size(81, 22)
        Me.cmd_filtrar.Text = "Carregar Grid"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmd_limpar
        '
        Me.cmd_limpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmd_limpar.Name = "cmd_limpar"
        Me.cmd_limpar.Size = New System.Drawing.Size(73, 22)
        Me.cmd_limpar.Text = "Limpar Grid"
        '
        'Frm_SerialScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 490)
        Me.Controls.Add(Me.TabControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_SerialScan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serial"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dg_portas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_serial As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_medida As Label
    Friend WithEvents lbl_txt As Label
    Friend WithEvents cmb_scan As ComboBox
    Friend WithEvents btn_scan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_conectar As Button
    Friend WithEvents cmb_baud As ComboBox
    Friend WithEvents btn_desconectar As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dg_portas As DataGridView
    Friend WithEvents dg_portas_codigo As DataGridViewTextBoxColumn
    Friend WithEvents dg_portas_mac As DataGridViewTextBoxColumn
    Friend WithEvents dg_portas_data As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmd_filtrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmd_limpar As ToolStripButton
    Friend WithEvents Label2 As Label
End Class
