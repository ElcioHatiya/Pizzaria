<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Relatorio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tb_frm_pedido_registroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pizzariaDataSet1 = New Pizzaria.pizzariaDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tb_frm_pedido_registroTableAdapter = New Pizzaria.pizzariaDataSet1TableAdapters.tb_frm_pedido_registroTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.tb_frm_pedido_registroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pizzariaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_frm_pedido_registroBindingSource
        '
        Me.tb_frm_pedido_registroBindingSource.DataMember = "tb_frm_pedido_registro"
        Me.tb_frm_pedido_registroBindingSource.DataSource = Me.pizzariaDataSet1
        '
        'pizzariaDataSet1
        '
        Me.pizzariaDataSet1.DataSetName = "pizzariaDataSet1"
        Me.pizzariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DadosPizzaria"
        ReportDataSource1.Value = Me.tb_frm_pedido_registroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pizzaria.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 29)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 369)
        Me.ReportViewer1.TabIndex = 0
        '
        'tb_frm_pedido_registroTableAdapter
        '
        Me.tb_frm_pedido_registroTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(575, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Limpar Registro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_Relatorio"
        Me.Text = "frm_Relatorio"
        CType(Me.tb_frm_pedido_registroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pizzariaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_frm_pedido_registroBindingSource As BindingSource
    Friend WithEvents pizzariaDataSet1 As pizzariaDataSet1
    Friend WithEvents tb_frm_pedido_registroTableAdapter As pizzariaDataSet1TableAdapters.tb_frm_pedido_registroTableAdapter
    Friend WithEvents Button1 As Button
End Class
