<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
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
        Me.btn_cadastrar_cliente = New System.Windows.Forms.Button()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_comp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome_cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_cadastrar_cliente
        '
        Me.btn_cadastrar_cliente.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_cliente.Location = New System.Drawing.Point(16, 419)
        Me.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente"
        Me.btn_cadastrar_cliente.Size = New System.Drawing.Size(294, 73)
        Me.btn_cadastrar_cliente.TabIndex = 29
        Me.btn_cadastrar_cliente.Text = "GRAVAR DADOS"
        Me.btn_cadastrar_cliente.UseVisualStyleBackColor = True
        '
        'txt_cidade
        '
        Me.txt_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.Location = New System.Drawing.Point(15, 362)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(295, 27)
        Me.txt_cidade.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 24)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "CIDADE"
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.Location = New System.Drawing.Point(14, 300)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(295, 27)
        Me.txt_bairro.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "BAIRRO"
        '
        'txt_comp
        '
        Me.txt_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comp.Location = New System.Drawing.Point(12, 234)
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(146, 27)
        Me.txt_comp.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(236, 24)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "NÚMERO/COMPLEMENTO"
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(13, 169)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(295, 27)
        Me.txt_endereco.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "RUA"
        '
        'txt_cep
        '
        Me.txt_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.Location = New System.Drawing.Point(208, 96)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(99, 27)
        Me.txt_cep.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CEP"
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(12, 96)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(165, 27)
        Me.txt_telefone.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "TELEFONE "
        '
        'txt_nome_cliente
        '
        Me.txt_nome_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_cliente.Location = New System.Drawing.Point(12, 32)
        Me.txt_nome_cliente.Name = "txt_nome_cliente"
        Me.txt_nome_cliente.Size = New System.Drawing.Size(295, 27)
        Me.txt_nome_cliente.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "NOME"
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 506)
        Me.Controls.Add(Me.btn_cadastrar_cliente)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_bairro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_comp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_clientes"
        Me.Text = "CADASTRAR CLIENTE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cadastrar_cliente As Button
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_comp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome_cliente As TextBox
    Friend WithEvents Label1 As Label
End Class
