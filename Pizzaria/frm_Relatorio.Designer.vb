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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Relatorio))
        Me.tb_frm_pedido_registroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pizzariaDataSet1 = New Pizzaria.pizzariaDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tb_frm_pedido_registroTableAdapter = New Pizzaria.pizzariaDataSet1TableAdapters.tb_frm_pedido_registroTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 90)
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
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(614, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Limpar Registro"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 67)
        Me.Label1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft PhagsPa", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(168, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(361, 49)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Detalhes do pedido"
        '
        'frm_Relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_Relatorio"
        Me.Text = "Detalhes"
        CType(Me.tb_frm_pedido_registroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pizzariaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_frm_pedido_registroBindingSource As BindingSource
    Friend WithEvents pizzariaDataSet1 As pizzariaDataSet1
    Friend WithEvents tb_frm_pedido_registroTableAdapter As pizzariaDataSet1TableAdapters.tb_frm_pedido_registroTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
End Class
