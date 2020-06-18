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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_excluir_pizza = New System.Windows.Forms.Button()
        Me.btn_nova_pizza = New System.Windows.Forms.Button()
        Me.txt_nova_pizza = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 161)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(453, 298)
        Me.DataGridView1.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOME"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "EXCLUIR"
        Me.Column2.Image = CType(resources.GetObject("Column2.Image"), System.Drawing.Image)
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'btn_excluir_pizza
        '
        Me.btn_excluir_pizza.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir_pizza.Location = New System.Drawing.Point(173, 101)
        Me.btn_excluir_pizza.Name = "btn_excluir_pizza"
        Me.btn_excluir_pizza.Size = New System.Drawing.Size(133, 37)
        Me.btn_excluir_pizza.TabIndex = 8
        Me.btn_excluir_pizza.Text = "EXCLUIR"
        Me.btn_excluir_pizza.UseVisualStyleBackColor = True
        '
        'btn_nova_pizza
        '
        Me.btn_nova_pizza.AutoSize = True
        Me.btn_nova_pizza.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nova_pizza.Location = New System.Drawing.Point(12, 101)
        Me.btn_nova_pizza.Name = "btn_nova_pizza"
        Me.btn_nova_pizza.Size = New System.Drawing.Size(142, 37)
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
        'frm_pizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 487)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_excluir_pizza)
        Me.Controls.Add(Me.btn_nova_pizza)
        Me.Controls.Add(Me.txt_nova_pizza)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_pizza"
        Me.Text = "frm_pizza"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents btn_excluir_pizza As Button
    Friend WithEvents btn_nova_pizza As Button
    Friend WithEvents txt_nova_pizza As TextBox
    Friend WithEvents Label1 As Label
End Class
