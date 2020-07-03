Public Class frm_Relatorio
    Private Sub frm_Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'pizzariaDataSet1.tb_frm_pedido_registro'. Você pode movê-la ou removê-la conforme necessário.
        Me.tb_frm_pedido_registroTableAdapter.FillBy(Me.pizzariaDataSet1.tb_frm_pedido_registro, AuxPedido)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resp = MsgBox("Deseja excluir todos os dados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")
        If resp = MsgBoxResult.Yes Then
            sql = "truncate table tb_frm_pedido_registro"
            db.Execute(sql)
            MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
            carregar_andamento()
            Me.Hide()
        End If
    End Sub
End Class