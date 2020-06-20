Public Class frm_pizza
    Private Sub btn_nova_pizza_Click(sender As Object, e As EventArgs) Handles btn_nova_pizza.Click
        Try
            If txt_nova_pizza.Text = "" Or
                    txt_valor.Text = "" Then
                MsgBox("Preencha todos os campos!")
            Else
                sql = "insert into tb_pizza values ( '" & txt_nova_pizza.Text & "',                                                        
                                                       '" & txt_valor.Text & "' )"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro realizado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
                txt_nova_pizza.Focus()
                txt_nova_pizza.Clear()
                carregar_pizza()
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pizzas.CellContentClick
        Try
            aux_nome = dgv_pizzas.CurrentRow.Cells(0).Value
            If dgv_pizzas.CurrentRow.Cells(2).Selected = True Then
                resp = MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_pizza where sabor = '" & aux_nome & "'"
                    rs = db.Execute(sql)
                    'MsgBox("Conta excluída com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
                    carregar_pizza()
                End If

            End If

        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    Private Sub frm_pizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_pizza()
    End Sub
End Class