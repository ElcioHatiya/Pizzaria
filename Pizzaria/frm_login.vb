﻿Public Class frm_login

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        txt_usuario.Select()
    End Sub

    ' BOTÃO ADMIN
    Private Sub btn_adminstrador_Click(sender As Object, e As EventArgs) Handles btn_adminstrador.Click
        login = txt_usuario.Text
        tela_admin.Show()
        Me.Hide()
    End Sub

    ' BOTÃO LOGIN NÃO-ADMIN
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ativar = "ativa"
        login = txt_usuario.Text 'carrega nome p prox label
        'CONFERE NOME, SENHA E STATUS
        sql = " select * from tb_usuario where nome = '" & txt_usuario.Text & "'
                                            And senha = '" & txt_senha.Text & "'
                                            and status = '" & ativar & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            tela_pedidos.Show()
            Me.Hide()
        Else
            MsgBox("Dados inválidos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso!")
            txt_senha.Clear()
            txt_usuario.Clear()
            txt_usuario.Select()
        End If
    End Sub

    'SENHA ADMIN
    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged
        verificar_senha()
    End Sub

    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged
        verificar_senha()
    End Sub

    'CHECK BOX
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "x"
        End If
    End Sub
End Class
