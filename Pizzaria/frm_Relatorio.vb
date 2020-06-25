Public Class frm_Relatorio
    Private Sub frm_Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'pizzariaDataSet.tb_frm_pedido_registro'. Você pode movê-la ou removê-la conforme necessário.

    End Sub

    Private Sub btn_BuscaPedido_Click(sender As Object, e As EventArgs) Handles btn_BuscaPedido.Click
        Me.tb_frm_pedido_registroTableAdapter.FillBy(Me.pizzariaDataSet.tb_frm_pedido_registro, txtx_BuscaPedido.Text.ToString)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class