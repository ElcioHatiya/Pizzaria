Public Class tela_pedidos
    Private Sub tela_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_clientes()
        carregar_andamento()
        txt_busca_telefone.Select()
        lbl_login.Text = login
    End Sub

    'BOTÃO NOVO CADASTRO
    Private Sub btn_novo_cadastro_Click(sender As Object, e As EventArgs) Handles btn_novo_cadastro.Click
        With frm_clientes
            .Show()
            .txt_nome_cliente.Text = ""
            .txt_bairro.Text = ""
            .txt_cep.Text = ""
            .txt_cidade.Text = ""
            .txt_comp.Text = ""
            .txt_telefone.Text = ""
            .txt_endereco.Text = ""
        End With
    End Sub

    'EXIBE frm_login AO FECHAR tela_pedidos
    Private Sub tela_pedidos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        With frm_login
            .Show()
            .txt_usuario.Select()
            .txt_senha.Text = ""
            .txt_usuario.Text = ""
            .CheckBox1.Checked = False
        End With
    End Sub

    'BOTÕES "EDITAR" E "EXCLUIR" DO DATA-GRID-VIEW tela_clientes
    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        With dgv_clientes
            aux = .CurrentRow.Cells(0).Value ' telefone
            aux_nome = .CurrentRow.Cells(1).Value ' nome
            If .CurrentRow.Cells(4).Selected = True Then  'frm_pedido
                frm_pedido.Show()
                carregar_pedidos()
            ElseIf .CurrentRow.Cells(5).Selected = True Then
                sql = "select * from tb_clientes where telefone = '" & aux & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    frm_clientes.Show()
                    With frm_clientes
                        .txt_telefone.Text = aux
                        .txt_nome_cliente.Text = rs.Fields(1).Value
                        .txt_bairro.Text = rs.Fields(5).Value
                        .txt_cep.Text = rs.Fields(2).Value
                        .txt_cidade.Text = rs.Fields(6).Value
                        .txt_comp.Text = rs.Fields(4).Value
                        .txt_endereco.Text = rs.Fields(3).Value
                    End With
                End If
            ElseIf .CurrentRow.Cells(6).Selected = True Then
                resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                              "a conta de: " & aux_nome & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_clientes where telefone = '" & aux & "'"
                    rs = db.Execute(sql)
                    'MsgBox("Conta excluída com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
                    carregar_clientes()
                End If
            End If
        End With
    End Sub

    'BUSCA NOME CLIENTE
    Private Sub txt_busca_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_cliente.TextChanged
        With dgv_clientes
            sql = "select * from tb_clientes where nome like '" & txt_busca_cliente.Text & "%' "
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value,
                          rs.Fields(1).Value,
                          rs.Fields(3).Value,
                          rs.Fields(4).Value,
                          Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    'BUSCA TELEFONE CLIENTE
    Private Sub txt_busca_telefone_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_telefone.TextChanged
        With dgv_clientes
            sql = "select * from tb_clientes where telefone like '" & txt_busca_telefone.Text & "%' "
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value,
                          rs.Fields(1).Value,
                          rs.Fields(3).Value,
                          rs.Fields(4).Value,
                          Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    'EXCLUI ITENS DO DGV-ANDAMENTO
    Private Sub dgv_pedidos_andamento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos_andamento.CellContentClick
        Try
            With dgv_pedidos_andamento
                aux = .CurrentRow.Cells(4).Value 'carrega dia
                If .CurrentRow.Cells(6).Selected = True Then
                    resp = MsgBox("Deseja realmente excluir ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from tb_andamento where dia = '" & aux & "'"
                        rs = db.Execute(sql)
                        carregar_andamento()
                        'MsgBox("Pedido excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
                    End If
                End If

                If .CurrentRow.Cells(7).Selected = True Then
                    AuxPedido = .CurrentRow.Cells(0).Value
                End If
            End With

        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With dgv_pedidos_andamento
            sql = "select * from tb_andamento where pedido like '" & txt_busca_pedido.Text & "%' "
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(5).Value,
                              rs.Fields(0).Value,
                              rs.Fields(1).Value,
                              rs.Fields(2).Value,
                              rs.Fields(3).Value,
                              rs.Fields(4).Value,
                              Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        carregar_andamento()
    End Sub
End Class