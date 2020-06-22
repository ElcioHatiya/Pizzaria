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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_usuario_pedido = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_dia = New System.Windows.Forms.Label()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgv_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 27)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "TELEFONE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 27)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "CLIENTE:"
        '
        'lbl_telefone
        '
        Me.lbl_telefone.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(126, 8)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(214, 27)
        Me.lbl_telefone.TabIndex = 18
        Me.lbl_telefone.Text = "Telefone"
        '
        'dgv_pedido
        '
        Me.dgv_pedido.AllowUserToAddRows = False
        Me.dgv_pedido.AllowUserToDeleteRows = False
        Me.dgv_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column9, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8})
        Me.dgv_pedido.Location = New System.Drawing.Point(12, 43)
        Me.dgv_pedido.Name = "dgv_pedido"
        Me.dgv_pedido.ReadOnly = True
        Me.dgv_pedido.RowHeadersWidth = 51
        Me.dgv_pedido.RowTemplate.Height = 24
        Me.dgv_pedido.Size = New System.Drawing.Size(803, 191)
        Me.dgv_pedido.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "TELEFONE"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 110
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 83
        '
        'Column9
        '
        Me.Column9.HeaderText = "PIZZA"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 81
        '
        'Column3
        '
        Me.Column3.HeaderText = "QUANTIDADE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 138
        '
        'Column4
        '
        Me.Column4.HeaderText = "VALOR"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 88
        '
        'Column5
        '
        Me.Column5.HeaderText = "DATA"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "USUÁRIO"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 105
        '
        'Column8
        '
        Me.Column8.HeaderText = "EXCLUIR"
        Me.Column8.Image = CType(resources.GetObject("Column8.Image"), System.Drawing.Image)
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 76
        '
        'btn_emitir_pedido
        '
        Me.btn_emitir_pedido.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_emitir_pedido.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emitir_pedido.Location = New System.Drawing.Point(727, 240)
        Me.btn_emitir_pedido.Name = "btn_emitir_pedido"
        Me.btn_emitir_pedido.Size = New System.Drawing.Size(88, 70)
        Me.btn_emitir_pedido.TabIndex = 16
        Me.btn_emitir_pedido.Text = "EMITIR PEDIDO"
        Me.btn_emitir_pedido.UseVisualStyleBackColor = False
        '
        'cmb_qtd
        '
        Me.cmb_qtd.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_qtd.FormattingEnabled = True
        Me.cmb_qtd.Location = New System.Drawing.Point(443, 278)
        Me.cmb_qtd.Name = "cmb_qtd"
        Me.cmb_qtd.Size = New System.Drawing.Size(78, 32)
        Me.cmb_qtd.TabIndex = 15
        '
        'btn_add_pizza
        '
        Me.btn_add_pizza.AutoSize = True
        Me.btn_add_pizza.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_add_pizza.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_pizza.Location = New System.Drawing.Point(592, 240)
        Me.btn_add_pizza.Name = "btn_add_pizza"
        Me.btn_add_pizza.Size = New System.Drawing.Size(129, 70)
        Me.btn_add_pizza.TabIndex = 14
        Me.btn_add_pizza.Text = "ADICIONAR "
        Me.btn_add_pizza.UseVisualStyleBackColor = False
        Me.btn_add_pizza.Visible = False
        '
        'cmb_pizzas
        '
        Me.cmb_pizzas.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pizzas.FormattingEnabled = True
        Me.cmb_pizzas.Location = New System.Drawing.Point(280, 240)
        Me.cmb_pizzas.Name = "cmb_pizzas"
        Me.cmb_pizzas.Size = New System.Drawing.Size(241, 32)
        Me.cmb_pizzas.TabIndex = 13
        '
        'lbl_cliente
        '
        Me.lbl_cliente.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.Location = New System.Drawing.Point(448, 8)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(223, 32)
        Me.lbl_cliente.TabIndex = 12
        Me.lbl_cliente.Text = "Nome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(611, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Login:"
        '
        'lbl_usuario_pedido
        '
        Me.lbl_usuario_pedido.AutoSize = True
        Me.lbl_usuario_pedido.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario_pedido.Location = New System.Drawing.Point(677, 11)
        Me.lbl_usuario_pedido.Name = "lbl_usuario_pedido"
        Me.lbl_usuario_pedido.Size = New System.Drawing.Size(65, 24)
        Me.lbl_usuario_pedido.TabIndex = 24
        Me.lbl_usuario_pedido.Text = "Label6"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(334, 283)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(103, 27)
        Me.lbl_subtotal.TabIndex = 27
        Me.lbl_subtotal.Text = "Sub total"
        '
        'lbl_dia
        '
        Me.lbl_dia.AutoSize = True
        Me.lbl_dia.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dia.Location = New System.Drawing.Point(554, 156)
        Me.lbl_dia.Name = "lbl_dia"
        Me.lbl_dia.Size = New System.Drawing.Size(91, 27)
        Me.lbl_dia.TabIndex = 28
        Me.lbl_dia.Text = "lbl_data"
        Me.lbl_dia.Visible = False
        '
        'btn_calc
        '
        Me.btn_calc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_calc.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_calc.Location = New System.Drawing.Point(592, 240)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(129, 70)
        Me.btn_calc.TabIndex = 29
        Me.btn_calc.Text = "CALCULAR ITEM"
        Me.btn_calc.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(93, 272)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(64, 27)
        Me.lbl_total.TabIndex = 31
        Me.lbl_total.Text = "Total"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(527, 240)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(59, 70)
        Me.btn_cancel.TabIndex = 32
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(93, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 27)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 27)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Valor"
        '
        'frm_pedido
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(822, 314)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_add_pizza)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.lbl_dia)
        Me.Controls.Add(Me.lbl_subtotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_usuario_pedido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_telefone)
        Me.Controls.Add(Me.dgv_pedido)
        Me.Controls.Add(Me.btn_emitir_pedido)
        Me.Controls.Add(Me.cmb_qtd)
        Me.Controls.Add(Me.cmb_pizzas)
        Me.Controls.Add(Me.lbl_cliente)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_usuario_pedido As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents lbl_dia As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents btn_calc As Button
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
