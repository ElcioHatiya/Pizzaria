<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedido))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.dgv_pedido = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_emitir_pedido = New System.Windows.Forms.Button()
        Me.cmb_qtd = New System.Windows.Forms.ComboBox()
        Me.btn_add_pizza = New System.Windows.Forms.Button()
        Me.cmb_pizzas = New System.Windows.Forms.ComboBox()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        CType(Me.dgv_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(521, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Quantidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(520, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 24)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Selecione a pizza"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(385, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 27)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "TELEFONE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 27)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "CLIENTE:"
        '
        'lbl_telefone
        '
        Me.lbl_telefone.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(514, 7)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(214, 23)
        Me.lbl_telefone.TabIndex = 18
        Me.lbl_telefone.Text = "Telefone"
        '
        'dgv_pedido
        '
        Me.dgv_pedido.AllowUserToAddRows = False
        Me.dgv_pedido.AllowUserToDeleteRows = False
        Me.dgv_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_pedido.Location = New System.Drawing.Point(12, 45)
        Me.dgv_pedido.Name = "dgv_pedido"
        Me.dgv_pedido.ReadOnly = True
        Me.dgv_pedido.RowHeadersWidth = 51
        Me.dgv_pedido.RowTemplate.Height = 24
        Me.dgv_pedido.Size = New System.Drawing.Size(501, 286)
        Me.dgv_pedido.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "QUANTIDADE"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 127
        '
        'Column2
        '
        Me.Column2.HeaderText = "PIZZA"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 76
        '
        'Column3
        '
        Me.Column3.HeaderText = "EXCLUIR"
        Me.Column3.Image = CType(resources.GetObject("Column3.Image"), System.Drawing.Image)
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 72
        '
        'btn_emitir_pedido
        '
        Me.btn_emitir_pedido.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emitir_pedido.Location = New System.Drawing.Point(519, 268)
        Me.btn_emitir_pedido.Name = "btn_emitir_pedido"
        Me.btn_emitir_pedido.Size = New System.Drawing.Size(256, 63)
        Me.btn_emitir_pedido.TabIndex = 16
        Me.btn_emitir_pedido.Text = "EMITIR PEDIDO"
        Me.btn_emitir_pedido.UseVisualStyleBackColor = True
        '
        'cmb_qtd
        '
        Me.cmb_qtd.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_qtd.FormattingEnabled = True
        Me.cmb_qtd.Location = New System.Drawing.Point(659, 117)
        Me.cmb_qtd.Name = "cmb_qtd"
        Me.cmb_qtd.Size = New System.Drawing.Size(116, 35)
        Me.cmb_qtd.TabIndex = 15
        '
        'btn_add_pizza
        '
        Me.btn_add_pizza.AutoSize = True
        Me.btn_add_pizza.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_pizza.Location = New System.Drawing.Point(519, 176)
        Me.btn_add_pizza.Name = "btn_add_pizza"
        Me.btn_add_pizza.Size = New System.Drawing.Size(256, 86)
        Me.btn_add_pizza.TabIndex = 14
        Me.btn_add_pizza.Text = "ADICIONAR"
        Me.btn_add_pizza.UseVisualStyleBackColor = True
        '
        'cmb_pizzas
        '
        Me.cmb_pizzas.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pizzas.FormattingEnabled = True
        Me.cmb_pizzas.Location = New System.Drawing.Point(518, 72)
        Me.cmb_pizzas.Name = "cmb_pizzas"
        Me.cmb_pizzas.Size = New System.Drawing.Size(256, 39)
        Me.cmb_pizzas.TabIndex = 13
        '
        'lbl_cliente
        '
        Me.lbl_cliente.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.Location = New System.Drawing.Point(129, 7)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(228, 27)
        Me.lbl_cliente.TabIndex = 12
        Me.lbl_cliente.Text = "Nome"
        '
        'frm_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 351)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_telefone)
        Me.Controls.Add(Me.dgv_pedido)
        Me.Controls.Add(Me.btn_emitir_pedido)
        Me.Controls.Add(Me.cmb_qtd)
        Me.Controls.Add(Me.btn_add_pizza)
        Me.Controls.Add(Me.cmb_pizzas)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Name = "frm_pedido"
        Me.Text = "NOVO PEDIDO"
        CType(Me.dgv_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents dgv_pedido As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents btn_emitir_pedido As Button
    Friend WithEvents cmb_qtd As ComboBox
    Friend WithEvents btn_add_pizza As Button
    Friend WithEvents cmb_pizzas As ComboBox
    Friend WithEvents lbl_cliente As Label
End Class
