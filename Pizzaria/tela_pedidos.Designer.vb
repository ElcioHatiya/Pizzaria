<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tela_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tela_pedidos))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.btn_novo_cadastro = New System.Windows.Forms.Button()
        Me.txt_busca_cliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_busca_telefone = New System.Windows.Forms.TextBox()
        Me.dgv_pedidos_andamento = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_busca_pedido = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pedidos_andamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(659, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Log-in:"
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.Location = New System.Drawing.Point(744, 262)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(70, 22)
        Me.lbl_login.TabIndex = 17
        Me.lbl_login.Text = "usuario"
        '
        'btn_novo_cadastro
        '
        Me.btn_novo_cadastro.AutoSize = True
        Me.btn_novo_cadastro.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_novo_cadastro.Location = New System.Drawing.Point(481, 497)
        Me.btn_novo_cadastro.Name = "btn_novo_cadastro"
        Me.btn_novo_cadastro.Size = New System.Drawing.Size(245, 77)
        Me.btn_novo_cadastro.TabIndex = 15
        Me.btn_novo_cadastro.Text = "NOVO CADASTRO"
        Me.btn_novo_cadastro.UseVisualStyleBackColor = True
        '
        'txt_busca_cliente
        '
        Me.txt_busca_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busca_cliente.Location = New System.Drawing.Point(153, 544)
        Me.txt_busca_cliente.Name = "txt_busca_cliente"
        Me.txt_busca_cliente.Size = New System.Drawing.Size(295, 26)
        Me.txt_busca_cliente.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 497)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "TELEFONE: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 546)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "NOME: "
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column6})
        Me.dgv_clientes.Location = New System.Drawing.Point(33, 296)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersWidth = 51
        Me.dgv_clientes.RowTemplate.Height = 24
        Me.dgv_clientes.Size = New System.Drawing.Size(789, 182)
        Me.dgv_clientes.TabIndex = 11
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
        'Column3
        '
        Me.Column3.HeaderText = "ENDEREÇO"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 93
        '
        'Column4
        '
        Me.Column4.HeaderText = "COMP"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 67
        '
        'Column5
        '
        Me.Column5.HeaderText = "NOVO PEDIDO"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 96
        '
        'Column7
        '
        Me.Column7.HeaderText = "EDITAR"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 56
        '
        'Column6
        '
        Me.Column6.HeaderText = "EXCLUIR "
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 65
        '
        'txt_busca_telefone
        '
        Me.txt_busca_telefone.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busca_telefone.Location = New System.Drawing.Point(189, 494)
        Me.txt_busca_telefone.Name = "txt_busca_telefone"
        Me.txt_busca_telefone.Size = New System.Drawing.Size(260, 29)
        Me.txt_busca_telefone.TabIndex = 19
        '
        'dgv_pedidos_andamento
        '
        Me.dgv_pedidos_andamento.AllowUserToAddRows = False
        Me.dgv_pedidos_andamento.AllowUserToDeleteRows = False
        Me.dgv_pedidos_andamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pedidos_andamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos_andamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column9, Me.Column10, Me.Column12, Me.Column13, Me.Column15, Me.Column16, Me.Column11})
        Me.dgv_pedidos_andamento.Location = New System.Drawing.Point(33, 60)
        Me.dgv_pedidos_andamento.Name = "dgv_pedidos_andamento"
        Me.dgv_pedidos_andamento.ReadOnly = True
        Me.dgv_pedidos_andamento.RowHeadersWidth = 51
        Me.dgv_pedidos_andamento.RowTemplate.Height = 24
        Me.dgv_pedidos_andamento.Size = New System.Drawing.Size(789, 186)
        Me.dgv_pedidos_andamento.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "CLIENTES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 19)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "PEDIDOS EM ANDAMENTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(246, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Pedido número:"
        '
        'txt_busca_pedido
        '
        Me.txt_busca_pedido.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busca_pedido.Location = New System.Drawing.Point(382, 19)
        Me.txt_busca_pedido.Name = "txt_busca_pedido"
        Me.txt_busca_pedido.Size = New System.Drawing.Size(100, 27)
        Me.txt_busca_pedido.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(488, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 27)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(647, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 27)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "LIMPAR BUSCA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "PEDIDO"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 77
        '
        'Column9
        '
        Me.Column9.HeaderText = "TELEFONE"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 88
        '
        'Column10
        '
        Me.Column10.HeaderText = "CLIENTE"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 78
        '
        'Column12
        '
        Me.Column12.HeaderText = "VALOR"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 72
        '
        'Column13
        '
        Me.Column13.HeaderText = "DATA"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 65
        '
        'Column15
        '
        Me.Column15.HeaderText = "USUÁRIO"
        Me.Column15.MinimumWidth = 6
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 87
        '
        'Column16
        '
        Me.Column16.HeaderText = "EXCLUIR"
        Me.Column16.Image = CType(resources.GetObject("Column16.Image"), System.Drawing.Image)
        Me.Column16.MinimumWidth = 6
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 62
        '
        'Column11
        '
        Me.Column11.HeaderText = "Column11"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 70
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(424, 262)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Limpar registro de pedidos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tela_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(845, 580)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_busca_pedido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_pedidos_andamento)
        Me.Controls.Add(Me.txt_busca_telefone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.btn_novo_cadastro)
        Me.Controls.Add(Me.txt_busca_cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "tela_pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEDIDOS"
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pedidos_andamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents btn_novo_cadastro As Button
    Friend WithEvents txt_busca_cliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents txt_busca_telefone As TextBox
    Friend WithEvents dgv_pedidos_andamento As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_busca_pedido As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewImageColumn
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents Button3 As Button
End Class
