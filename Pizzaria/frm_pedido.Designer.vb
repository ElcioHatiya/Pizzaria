<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pedido
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedido))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.dgv_pedido = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_emitir_pedido = New System.Windows.Forms.Button()
        Me.cmb_qtd = New System.Windows.Forms.ComboBox()
        Me.btn_add_pizza = New System.Windows.Forms.Button()
        Me.cmb_pizzas = New System.Windows.Forms.ComboBox()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_usuario_pedido = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_dia = New System.Windows.Forms.Label()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Pedido = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgv_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(12, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Telefone:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(23, 446)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Cliente:"
        '
        'lbl_telefone
        '
        Me.lbl_telefone.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(83, 424)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(169, 22)
        Me.lbl_telefone.TabIndex = 18
        Me.lbl_telefone.Text = "Telefone"
        '
        'dgv_pedido
        '
        Me.dgv_pedido.AllowUserToAddRows = False
        Me.dgv_pedido.AllowUserToDeleteRows = False
        Me.dgv_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pedido.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column9, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8})
        Me.dgv_pedido.Location = New System.Drawing.Point(1, 84)
        Me.dgv_pedido.Name = "dgv_pedido"
        Me.dgv_pedido.ReadOnly = True
        Me.dgv_pedido.RowHeadersWidth = 51
        Me.dgv_pedido.RowTemplate.Height = 24
        Me.dgv_pedido.Size = New System.Drawing.Size(841, 337)
        Me.dgv_pedido.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "TELEFONE"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 88
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 68
        '
        'Column9
        '
        Me.Column9.HeaderText = "PIZZA"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 66
        '
        'Column3
        '
        Me.Column3.HeaderText = "QUANTIDADE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 111
        '
        'Column4
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "VALOR"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 72
        '
        'Column5
        '
        Me.Column5.HeaderText = "DATA"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 65
        '
        'Column7
        '
        Me.Column7.HeaderText = "USUÁRIO"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 87
        '
        'Column8
        '
        Me.Column8.HeaderText = "EXCLUIR"
        Me.Column8.Image = CType(resources.GetObject("Column8.Image"), System.Drawing.Image)
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 62
        '
        'btn_emitir_pedido
        '
        Me.btn_emitir_pedido.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_emitir_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_emitir_pedido.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emitir_pedido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_emitir_pedido.Location = New System.Drawing.Point(742, 430)
        Me.btn_emitir_pedido.Name = "btn_emitir_pedido"
        Me.btn_emitir_pedido.Size = New System.Drawing.Size(88, 59)
        Me.btn_emitir_pedido.TabIndex = 16
        Me.btn_emitir_pedido.Text = "EMITIR PEDIDO"
        Me.btn_emitir_pedido.UseVisualStyleBackColor = False
        '
        'cmb_qtd
        '
        Me.cmb_qtd.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_qtd.FormattingEnabled = True
        Me.cmb_qtd.Location = New System.Drawing.Point(523, 462)
        Me.cmb_qtd.Name = "cmb_qtd"
        Me.cmb_qtd.Size = New System.Drawing.Size(78, 27)
        Me.cmb_qtd.TabIndex = 15
        '
        'btn_add_pizza
        '
        Me.btn_add_pizza.AutoSize = True
        Me.btn_add_pizza.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_add_pizza.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_pizza.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_add_pizza.Location = New System.Drawing.Point(607, 430)
        Me.btn_add_pizza.Name = "btn_add_pizza"
        Me.btn_add_pizza.Size = New System.Drawing.Size(129, 59)
        Me.btn_add_pizza.TabIndex = 14
        Me.btn_add_pizza.Text = "ADICIONAR "
        Me.btn_add_pizza.UseVisualStyleBackColor = False
        Me.btn_add_pizza.Visible = False
        '
        'cmb_pizzas
        '
        Me.cmb_pizzas.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pizzas.FormattingEnabled = True
        Me.cmb_pizzas.Location = New System.Drawing.Point(360, 430)
        Me.cmb_pizzas.Name = "cmb_pizzas"
        Me.cmb_pizzas.Size = New System.Drawing.Size(241, 27)
        Me.cmb_pizzas.TabIndex = 13
        '
        'lbl_cliente
        '
        Me.lbl_cliente.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.Location = New System.Drawing.Point(83, 446)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(169, 22)
        Me.lbl_cliente.TabIndex = 12
        Me.lbl_cliente.Text = "Nome"
        '
        'lbl_usuario_pedido
        '
        Me.lbl_usuario_pedido.AutoSize = True
        Me.lbl_usuario_pedido.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario_pedido.Location = New System.Drawing.Point(663, 309)
        Me.lbl_usuario_pedido.Name = "lbl_usuario_pedido"
        Me.lbl_usuario_pedido.Size = New System.Drawing.Size(125, 19)
        Me.lbl_usuario_pedido.TabIndex = 24
        Me.lbl_usuario_pedido.Text = "Login não visível"
        Me.lbl_usuario_pedido.Visible = False
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_subtotal.Location = New System.Drawing.Point(356, 467)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(85, 22)
        Me.lbl_subtotal.TabIndex = 27
        Me.lbl_subtotal.Text = "Sub total"
        '
        'lbl_dia
        '
        Me.lbl_dia.AutoSize = True
        Me.lbl_dia.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dia.Location = New System.Drawing.Point(554, 241)
        Me.lbl_dia.Name = "lbl_dia"
        Me.lbl_dia.Size = New System.Drawing.Size(164, 22)
        Me.lbl_dia.TabIndex = 28
        Me.lbl_dia.Text = "lbl_data não visível"
        Me.lbl_dia.Visible = False
        '
        'btn_calc
        '
        Me.btn_calc.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_calc.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calc.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_calc.Location = New System.Drawing.Point(607, 430)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(129, 59)
        Me.btn_calc.TabIndex = 29
        Me.btn_calc.Text = "CALCULAR ITEM"
        Me.btn_calc.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(763, 497)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(52, 22)
        Me.lbl_total.TabIndex = 31
        Me.lbl_total.Text = "Total"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(742, 430)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(59, 59)
        Me.btn_cancel.TabIndex = 32
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(679, 497)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 22)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Total R$"
        '
        'lbl_Pedido
        '
        Me.lbl_Pedido.AutoSize = True
        Me.lbl_Pedido.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_Pedido.Location = New System.Drawing.Point(102, 468)
        Me.lbl_Pedido.Name = "lbl_Pedido"
        Me.lbl_Pedido.Size = New System.Drawing.Size(45, 16)
        Me.lbl_Pedido.TabIndex = 33
        Me.lbl_Pedido.Text = "pedido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(8, 468)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Pedido número"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(475, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "UNID."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(321, 467)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "R$"
        '
        'Label5
        '
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 68)
        Me.Label5.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft PhagsPa", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(372, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 49)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Pedido"
        '
        'frm_pedido
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(842, 531)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_Pedido)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_dia)
        Me.Controls.Add(Me.lbl_subtotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_usuario_pedido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_telefone)
        Me.Controls.Add(Me.dgv_pedido)
        Me.Controls.Add(Me.cmb_qtd)
        Me.Controls.Add(Me.cmb_pizzas)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.btn_emitir_pedido)
        Me.Controls.Add(Me.btn_add_pizza)
        Me.Controls.Add(Me.btn_calc)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOVO PEDIDO"
        CType(Me.dgv_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents dgv_pedido As DataGridView
    Friend WithEvents btn_emitir_pedido As Button
    Friend WithEvents cmb_qtd As ComboBox
    Friend WithEvents btn_add_pizza As Button
    Friend WithEvents cmb_pizzas As ComboBox
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_usuario_pedido As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents lbl_dia As Label
    Friend WithEvents btn_calc As Button
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Pedido As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
End Class
