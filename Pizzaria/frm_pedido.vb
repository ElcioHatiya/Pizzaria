Public Class frm_pedido
    Private Sub frm_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_pizzas()
        carregar_qtd()
        carregar_pedidos()
        lbl_usuario_pedido.Text = login
        lbl_cliente.Text = aux_nome
        lbl_telefone.Text = aux
        lbl_dia.Text = System.DateTime.Now
        lbl_total.Visible = False
        lbl_subtotal.Visible = False
        btn_cancel.Hide()
        btn_emitir_pedido.Visible = False
        lbl_Pedido.Text = pedido
    End Sub

    'ADICIONAR PIZZA AO PEDIDO
    Private Sub btn_add_pizza_Click(sender As Object, e As EventArgs) Handles btn_add_pizza.Click
        Try
            sql = "insert into tb_frm_pedido  values ( '" & lbl_telefone.Text & "', " &
                                                    "'" & lbl_cliente.Text & "' , " &
                                                    "'" & cmb_pizzas.Text & "' ," &
                                                    "'" & cmb_qtd.Text & "' ," &
                                                    "'" & lbl_subtotal.Text & "' ," &
                                                    "'" & lbl_dia.Text & "' ," &
                                                    "'" & lbl_usuario_pedido.Text & "'  )"
            db.Execute(UCase(sql))
            ' MsgBox("Item Adicionado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso!")
            carregar_pedidos()
            lbl_total.Text = total
            cmb_pizzas.Select()
            btn_add_pizza.Visible = False
            lbl_subtotal.Hide()
            lbl_total.Show()
            btn_cancel.Hide()
            btn_emitir_pedido.Visible = True
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    'EMITIR PEDIDO
    Private Sub btn_emitir_pedido_Click(sender As Object, e As EventArgs) Handles btn_emitir_pedido.Click
        Try
            sql = "insert into tb_andamento values ( '" & lbl_telefone.Text & "', " &
                                                 "'" & lbl_cliente.Text & "' , " &
                                                 "'" & lbl_total.Text & "' ," &
                                                 "'" & lbl_dia.Text & "' ," &
                                                 "'" & lbl_usuario_pedido.Text & "'," &
                                                 "'" & lbl_Pedido.Text & "')"
            db.Execute(sql)
            With dgv_pedido
                sql = "select * from tb_frm_pedido where telefone = '" & lbl_telefone.Text & "'"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    saborAux = rs.Fields(2).Value
                    qtdAux = rs.Fields(3).Value
                    valorAux = rs.Fields(4).Value
                    rs.MoveNext()
                    sqy = "insert into tb_frm_pedido_registro values ( '" & lbl_Pedido.Text & "', " &
                                                                        "'" & lbl_telefone.Text & "'," &
                                                                        "'" & lbl_cliente.Text & "'," &
                                                                        "'" & saborAux & "'," &
                                                                        "'" & qtdAux & "', " &
                                                                        "'" & valorAux & "', " &
                                                                        "'" & lbl_dia.Text & "', " &
                                                                        "'" & lbl_usuario_pedido.Text & "')"
                    db.Execute(sqy)
                Loop
            End With
            sqx = "truncate table tb_frm_pedido " 'apaga tb_frm_pedido
            db.Execute(sqx)
            MsgBox("Pedido realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
            carregar_andamento()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    'EXCLUIR PIZZA DO PEDIDO
    Private Sub dgv_pedido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedido.CellContentClick
        Try
            With dgv_pedido
                aux = .CurrentRow.Cells(5).Value 'carrega dia
                If .CurrentRow.Cells(7).Selected = True Then
                    'resp = MsgBox("Deseja realmente excluir ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                    'If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_frm_pedido where dia = '" & aux & "'"
                    rs = db.Execute(sql)
                    'MsgBox("Pizza excluída", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
                    carregar_pedidos()
                    lbl_total.Text = total
                    'End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    'ESCONDE BOTÃO DE ADICIONAR 
    Private Sub cmb_pizzas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_pizzas.SelectedIndexChanged
        btn_add_pizza.Select()
        btn_add_pizza.Visible = False
        btn_cancel.Visible = False
        lbl_subtotal.Text = ""
    End Sub

    Private Sub cmb_qtd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_qtd.SelectedIndexChanged
        btn_add_pizza.Select()
        btn_add_pizza.Visible = False
        btn_cancel.Visible = False
        lbl_subtotal.Text = ""
    End Sub

    'CALCULA SUBTOTAL PARA lbl_subtotal
    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        calcular_subtotal_pizza()
        carregar_pedidos()
        lbl_subtotal.Text = subTotal
        btn_add_pizza.Show()
        lbl_dia.Text = System.DateTime.Now
        lbl_total.Text = total
        lbl_subtotal.Show()
        btn_cancel.Show()
        btn_emitir_pedido.Visible = False
        lbl_total.Visible = True

    End Sub

    'BOTÃO DE CANCELAR CÁLCULO
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        btn_calc.Show()
        btn_add_pizza.Visible = False
        btn_cancel.Visible = False
        lbl_subtotal.Text = ""
    End Sub
End Class