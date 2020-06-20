<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btn_adminstrador = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(442, 255)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(73, 23)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Exibir"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btn_adminstrador
        '
        Me.btn_adminstrador.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adminstrador.Location = New System.Drawing.Point(355, 304)
        Me.btn_adminstrador.Name = "btn_adminstrador"
        Me.btn_adminstrador.Size = New System.Drawing.Size(247, 69)
        Me.btn_adminstrador.TabIndex = 20
        Me.btn_adminstrador.Text = "Administrador"
        Me.btn_adminstrador.UseVisualStyleBackColor = True
        Me.btn_adminstrador.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 54)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "BELLA PIZZA"
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(626, 304)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(147, 69)
        Me.btn_login.TabIndex = 18
        Me.btn_login.Text = "Log in"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(442, 214)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.txt_senha.Size = New System.Drawing.Size(331, 34)
        Me.txt_senha.TabIndex = 17
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(441, 111)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(331, 34)
        Me.txt_usuario.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(436, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 31)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(436, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 31)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Usuário"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 391)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btn_adminstrador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btn_adminstrador As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
