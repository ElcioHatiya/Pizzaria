Public Class tela_admin
    Private Sub tela_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
        carregar_parametro()
        txt_busca.Select()
        lbl_usuario.Text = login
    End Sub

    'MOSTRAR frm_usuario
    Private Sub btn_criar_conta_Click(sender As Object, e As EventArgs) Handles btn_criar_conta.Click
        With frm_usuario
            .Show()
            .txt_nome.Text = ""
            .txt_repetir.Text = ""
            .txt_senha.Text = ""
            .txt_email.Text = ""
        End With
    End Sub

    Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
        With dgv_usuarios
            aux = .CurrentRow.Cells(0).Value

            ' BLOQUEAR CONTA 
            If .CurrentRow.Cells(5).Selected = True Then
                resp = MsgBox("Deseja realmente BLOQUEAR" + vbNewLine &
                                  "a conta de: " & aux & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                If resp = MsgBoxResult.Yes Then
                    sql = " select * from tb_usuario where nome = '" & aux & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        ativar = "bloqueada"
                        sql = " update tb_usuario set status = '" & ativar & "' 
                                        where nome = '" & aux & "'"
                        rs = db.Execute(UCase(sql))
                        ' MsgBox("Conta BLOQUEADA", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
                        carregar_dados()
                    End If
                End If

                ' ATIVAR CONTA
            ElseIf .CurrentRow.Cells(6).Selected = True Then
                resp = MsgBox("Deseja realmente ATIVAR" + vbNewLine &
                                  "a conta de: " & aux & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                If resp = MsgBoxResult.Yes Then
                    sql = " select * from tb_usuario where nome = '" & aux & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        ativar = "ativa"
                        sql = " update tb_usuario set status = '" & ativar & "' 
                                        where nome = '" & aux & "'"
                        rs = db.Execute(UCase(sql))
                        '  MsgBox("Conta ATIVA", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
                        carregar_dados()
                    End If
                End If

                ' EDITAR CONTA
            ElseIf .CurrentRow.Cells(7).Selected = True Then
                sql = "select * from tb_usuario where nome= '" & aux & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    frm_usuario.Show()
                    'carrega frm_usuario com dados
                    With frm_usuario
                        .txt_nome.Text = rs.Fields(0).Value
                        .txt_email.Text = rs.Fields(4).Value
                        .txt_perfil.Text = rs.Fields(2).Value
                        .txt_repetir.Text = rs.Fields(1).Value
                        .txt_senha.Text = rs.Fields(1).Value
                        .txt_status.Text = rs.Fields(3).Value
                    End With
                End If

                ' EXCLUIR CONTA
            ElseIf .CurrentRow.Cells(8).Selected = True Then
                resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                              "a conta de: " & aux & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_usuario where nome = '" & aux & "'"
                    rs = db.Execute(sql)
                    ' MsgBox("Conta excluída com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
                    carregar_dados()
                End If
            End If
        End With
    End Sub

    'BUSCA POR cmb_parametro 
    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        With dgv_usuarios
            sql = "select * from tb_usuario where " & cmb_parametro.Text & " like '" & txt_busca.Text & "%' "
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value,
                          rs.Fields(4).Value,
                          rs.Fields(1).Value,
                          rs.Fields(2).Value,
                          rs.Fields(3).Value,
                          Nothing, Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    'EXIBE frm_login AO FECHAR FORMULÁRIO
    Private Sub tela_admin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        With frm_login
            .Show()
            .txt_senha.Text = ""
            .txt_usuario.Text = ""
            .txt_usuario.Select()
            .CheckBox1.Checked = False
        End With
    End Sub

    Private Sub btn_pizza_Click(sender As Object, e As EventArgs) Handles btn_pizza.Click
        frm_pizza.Show()
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        tela_pedidos.Show()
        Me.Hide()
    End Sub
End Class