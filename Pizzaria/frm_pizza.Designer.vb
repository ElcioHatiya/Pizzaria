<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pizza))
        Me.dgv_pizzas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_nova_pizza = New System.Windows.Forms.Button()
        Me.txt_nova_pizza = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_pizzas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_pizzas
        '
        Me.dgv_pizzas.AllowUserToAddRows = False
        Me.dgv_pizzas.AllowUserToDeleteRows = False
        Me.dgv_pizzas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_pizzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pizzas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2})
        Me.dgv_pizzas.Location = New System.Drawing.Point(12, 170)
        Me.dgv_pizzas.Name = "dgv_pizzas"
        Me.dgv_pizzas.ReadOnly = True
        Me.dgv_pizzas.RowHeadersWidth = 51
        Me.dgv_pizzas.RowTemplate.Height = 24
        Me.dgv_pizzas.Size = New System.Drawing.Size(665, 298)
        Me.dgv_pizzas.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOME"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 78
        '
        'Column3
        '
        Me.Column3.HeaderText = "PREÇO"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 85
        '
        'Column2
        '
        Me.Column2.HeaderText = "EXCLUIR"
        Me.Column2.Image = CType(resources.GetObject("Column2.Image"), System.Drawing.Image)
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 72
        '
        'btn_nova_pizza
        '
        Me.btn_nova_pizza.AutoSize = True
        Me.btn_nova_pizza.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nova_pizza.Location = New System.Drawing.Point(182, 83)
        Me.btn_nova_pizza.Name = "btn_nova_pizza"
        Me.btn_nova_pizza.Size = New System.Drawing.Size(242, 64)
        Me.btn_nova_pizza.TabIndex = 7
        Me.btn_nova_pizza.Text = "ADICIONAR"
        Me.btn_nova_pizza.UseVisualStyleBackColor = True
        '
        'txt_nova_pizza
        '
        Me.txt_nova_pizza.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nova_pizza.Location = New System.Drawing.Point(12, 42)
        Me.txt_nova_pizza.Name = "txt_nova_pizza"
        Me.txt_nova_pizza.Size = New System.Drawing.Size(412, 34)
        Me.txt_nova_pizza.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOME"
        '
        'txt_valor
        '
        Me.txt_valor.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.Location = New System.Drawing.Point(12, 113)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(142, 34)
        Me.txt_valor.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 27)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "VALOR"
        '
        'frm_pizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(753, 528)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.dgv_pizzas)
        Me.Controls.Add(Me.btn_nova_pizza)
        Me.Controls.Add(Me.txt_nova_pizza)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_pizza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOVA PIZZA"
        CType(Me.dgv_pizzas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_pizzas As DataGridView
    Friend WithEvents btn_nova_pizza As Button
    Friend WithEvents txt_nova_pizza As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents Label2 As Label
End Class
