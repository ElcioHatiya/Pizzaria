Module Modulo
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer


    Public sql, sqx, ativar, Status, aux, aux_nome, resp As String

    'CONECTAR COM SQL-SERVER
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.connection")
            db.Open("Provider = SQLOLEDB;Data Source= LAPTOP-F9R7ORS0; Initial Catalog = pizzaria; trusted_connection=yes;")
            '  MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar com o banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    'DATA-GRID-VIEW tela_admin
    Sub carregar_dados()
        With tela_admin.dgv_usuarios
            sql = "select * from tb_usuario order by nome asc "
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

    'COMBO-BOX DE BUSCA tela_admin
    Sub carregar_parametro()
        With tela_admin.cmb_parametro.Items
            .Add("Nome")
            .Add("Email")
        End With
        tela_admin.cmb_parametro.SelectedIndex = 0
    End Sub

    'EXIBIR USUARIO NA LABEL (CARREGA TODAS LABELS NA TROCA DE TELA)
    Sub mostrar_usuario()
        tela_pedidos.lbl_login.Text = frm_login.txt_usuario.Text
        tela_admin.lbl_usuario.Text = tela_pedidos.lbl_login.Text
        'frm_pedido.lbl_cliente.Text = tela_pedidos.dgv_clientes.CurrentRow.Cells(1).Value
        'frm_pedido.lbl_telefone.Text = tela_pedidos.dgv_clientes.CurrentRow.Cells(0).Value
    End Sub

    'DATA-GRID-VIEW tela_pedidos
    Sub carregar_clientes()
        With tela_pedidos.dgv_clientes
            sql = "select * from tb_clientes order by nome asc "
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

    'COMBO BOX frm_usuario
    Sub carregar_tipo()
        With frm_usuario.txt_perfil.Items
            .Add("ADMINISTRADOR")
            .Add("USUARIO")
        End With
        frm_usuario.txt_perfil.SelectedIndex = 1

        With frm_usuario.txt_status.Items
            .Add("ATIVA")
            .Add("BLOQUEADA")
        End With
        frm_usuario.txt_status.SelectedIndex = 0
    End Sub

    'COMBO-BOX frm_pedido
    Sub carregar_pizzas()
        With frm_pedido.cmb_pizzas.Items
            sql = "select sabor from tb_pizza"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Add(rs.Fields(0).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub
    'COMBO-BOX: QUANTIDADE DE PIZZAS DO FORMULÁRIO DE PEDIDOS)
    Sub carregar_qtd()
        With frm_pedido.cmb_qtd.Items
            .Add("1/2")
            .Add("1")
            .Add("2")
            .Add("3")
            .Add("4")
            .Add("5")
            .Add("6")
            .Add("7")
            .Add("8")
            .Add("9")
            .Add("10")
            frm_pedido.cmb_qtd.SelectedIndex = 1
        End With
    End Sub

    'DATA-GRID-VIEW DO FORMULÁRIO DE PEDIDOS
    Sub carregar_pedidos()
        With frm_pedido.dgv_pedido
            .Rows.Clear()
            sql = "select * from tb_frm_pedido order by qtd asc "
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value,
                          rs.Fields(0).Value,
                           Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    'VERIFICAR SENHA ADMIN NO FORMULÁRIO DE LOGIN
    Sub verificar_senha()
        With frm_login
            ativar = "ativa"
            Status = "administrador"
            sql = " select * from tb_usuario where nome = '" & .txt_usuario.Text & "'
                                            and senha = '" & .txt_senha.Text & "'
                                            and status = '" & ativar & "'
                                            and perfil = '" & Status & "' "
            rs = db.Execute(sql)
            If rs.EOF = False Then
                .btn_adminstrador.Show()
                .btn_adminstrador.Select()
            Else
                .btn_adminstrador.Visible = False
            End If
        End With
    End Sub
End Module