<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Relatorio
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tb_frm_pedido_registroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pizzariaDataSet = New Pizzaria.pizzariaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tb_frm_pedido_registroTableAdapter = New Pizzaria.pizzariaDataSetTableAdapters.tb_frm_pedido_registroTableAdapter()
        Me.txtx_BuscaPedido = New System.Windows.Forms.TextBox()
        Me.btn_BuscaPedido = New System.Windows.Forms.Button()
        CType(Me.tb_frm_pedido_registroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pizzariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_frm_pedido_registroBindingSource
        '
        Me.tb_frm_pedido_registroBindingSource.DataMember = "tb_frm_pedido_registro"
        Me.tb_frm_pedido_registroBindingSource.DataSource = Me.pizzariaDataSet
        '
        'pizzariaDataSet
        '
        Me.pizzariaDataSet.DataSetName = "pizzariaDataSet"
        Me.pizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "BancoPizzaria"
        ReportDataSource1.Value = Me.tb_frm_pedido_registroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pizzaria.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1312, 736)
        Me.ReportViewer1.TabIndex = 0
        '
        'tb_frm_pedido_registroTableAdapter
        '
        Me.tb_frm_pedido_registroTableAdapter.ClearBeforeFill = True
        '
        'txtx_BuscaPedido
        '
        Me.txtx_BuscaPedido.Location = New System.Drawing.Point(895, 13)
        Me.txtx_BuscaPedido.Name = "txtx_BuscaPedido"
        Me.txtx_BuscaPedido.Size = New System.Drawing.Size(100, 22)
        Me.txtx_BuscaPedido.TabIndex = 1
        '
        'btn_BuscaPedido
        '
        Me.btn_BuscaPedido.Location = New System.Drawing.Point(1031, 11)
        Me.btn_BuscaPedido.Name = "btn_BuscaPedido"
        Me.btn_BuscaPedido.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscaPedido.TabIndex = 2
        Me.btn_BuscaPedido.Text = "btn_BuscaPedido"
        Me.btn_BuscaPedido.UseVisualStyleBackColor = True
        '
        'frm_Relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 736)
        Me.Controls.Add(Me.btn_BuscaPedido)
        Me.Controls.Add(Me.txtx_BuscaPedido)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_Relatorio"
        Me.Text = "frm_Relatorio"
        CType(Me.tb_frm_pedido_registroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pizzariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_frm_pedido_registroBindingSource As BindingSource
    Friend WithEvents pizzariaDataSet As pizzariaDataSet
    Friend WithEvents tb_frm_pedido_registroTableAdapter As pizzariaDataSetTableAdapters.tb_frm_pedido_registroTableAdapter
    Friend WithEvents txtx_BuscaPedido As TextBox
    Friend WithEvents btn_BuscaPedido As Button
End Class
