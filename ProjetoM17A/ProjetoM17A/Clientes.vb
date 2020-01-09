Public Class Clientes
    'variaveis clientes
    Dim idCl_tmp, cpostal_tmp, telefone_tmp, ncontri_tmp As Integer
    Dim nomecl_tmp, nacionalidade_tmp As String


    'botões enabled/disabled
    Private Sub botoes(ByVal estado As Integer)
        If estado = 1 Then
            bt_primeirocl.Visible = False
            bt_anteriorcl.Visible = False
            bt_seguintecl.Visible = False
            bt_ultimocl.Visible = False
            bt_deletecl.Visible = False
        ElseIf estado = 0 Then
            bt_primeirocl.Visible = True
            bt_anteriorcl.Visible = True
            bt_seguintecl.Visible = True
            bt_ultimocl.Visible = True
            bt_deletecl.Visible = True
        End If
    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdprojetoDataSet)

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdprojetoDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.BdprojetoDataSet.Clientes)

        'inibir botoes
        bt_gravarcl.Visible = False
        bt_gravarcl.Enabled = False

        bt_gravar2cl.Visible = False
        bt_gravar2cl.Enabled = False

    End Sub

    Private Sub bt_primeirocl_Click(sender As Object, e As EventArgs) Handles bt_primeirocl.Click
        ClientesBindingSource.MoveFirst() 'move para o primeiro
    End Sub

    Private Sub bt_anteriorcl_Click(sender As Object, e As EventArgs) Handles bt_anteriorcl.Click
        ClientesBindingSource.MovePrevious() 'move para o anterior
    End Sub

    Private Sub bt_seguintecl_Click(sender As Object, e As EventArgs) Handles bt_seguintecl.Click
        ClientesBindingSource.MoveNext() 'move para o seguinte
    End Sub

    Private Sub bt_ultimocl_Click(sender As Object, e As EventArgs) Handles bt_ultimocl.Click
        ClientesBindingSource.MoveLast() 'move para o ultimo
    End Sub

    Private Sub bt_deletecl_Click(sender As Object, e As EventArgs) Handles bt_deletecl.Click
        'vai tentar eliminar o registo atraves de um TRY
        Dim Adapter_tmp As New bdprojetoDataSetTableAdapters.ClientesTableAdapter
        Try
            Adapter_tmp.Delete(Id_clienteTextBox.Text, Nome_clienteTextBox.Text, Cod_postalTextBox.Text, NacionalidadeTextBox.Text, TelefoneTextBox.Text, N_contribuinteTextBox.Text)
            MsgBox("Registo eliminado com sucesso", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message) 'detetar se tem erros
        End Try

        Me.ClientesTableAdapter.Fill(Me.BdprojetoDataSet.Clientes)

        botoes(0)
    End Sub

    Private Sub bt_tras_Click(sender As Object, e As EventArgs) Handles bt_tras.Click
        Index.Show() 'abre o form do menu
        Me.Hide() 'fecha o form inicial
    End Sub



    Private Sub bt_novocl_Click(sender As Object, e As EventArgs) Handles bt_novocl.Click
        'Preparar campos
        Id_clienteTextBox.Text = ""
        Nome_clienteTextBox.Text = ""
        Cod_postalTextBox.Text = ""
        NacionalidadeTextBox.Text = ""
        TelefoneTextBox.Text = ""
        N_contribuinteTextBox.Text = ""

        bt_gravarcl.Visible = True
        bt_gravarcl.Enabled = True

        'inibir botoes
        botoes(1)

        bt_novocl.Text = "Limpar"
    End Sub

    Private Sub bt_atualizarcl_Click(sender As Object, e As EventArgs) Handles bt_atualizarcl.Click
        idCl_tmp = Id_clienteTextBox.Text
        nomecl_tmp = Nome_clienteTextBox.Text
        cpostal_tmp = Cod_postalTextBox.Text
        nacionalidade_tmp = NacionalidadeTextBox.Text
        telefone_tmp = TelefoneTextBox.Text
        ncontri_tmp = N_contribuinteTextBox.Text

        'inibir botoes
        botoes(1)
        bt_novocl.Visible = False
        bt_gravar2cl.Visible = True
        bt_gravar2cl.Enabled = True
    End Sub

    Private Sub bt_gravarcl_Click(sender As Object, e As EventArgs) Handles bt_gravarcl.Click
        'registos de dados na tabela
        Dim Adapter_tmp As New bdprojetoDataSetTableAdapters.ClientesTableAdapter
        Try
            Adapter_tmp.Insert(Nome_clienteTextBox.Text, Cod_postalTextBox.Text, NacionalidadeTextBox.Text, TelefoneTextBox.Text, N_contribuinteTextBox.Text)
            MsgBox("Registo inserido com sucesso", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message) 'detetar se tem erros
        End Try

        Me.ClientesTableAdapter.Fill(Me.BdprojetoDataSet.Clientes)

        bt_gravarcl.Visible = False
        bt_gravarcl.Enabled = False

        'inibir botoes
        botoes(0)

        bt_novocl.Text = "Novo"
    End Sub

    Private Sub bt_gravar2cl_Click(sender As Object, e As EventArgs) Handles bt_gravar2cl.Click
        'registos atualizar dados na tabela
        Dim Adapter_tmp As New bdprojetoDataSetTableAdapters.ClientesTableAdapter
        Try
            Adapter_tmp.Update(Nome_clienteTextBox.Text, Cod_postalTextBox.Text, NacionalidadeTextBox.Text, TelefoneTextBox.Text, N_contribuinteTextBox.Text, idCl_tmp, nomecl_tmp, cpostal_tmp, nacionalidade_tmp, telefone_tmp, ncontri_tmp)
            MsgBox("Registo inserido com sucesso", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message) 'detetar se tem erros
        End Try

        'inibir botoes
        botoes(0)
        bt_novocl.Visible = True
        bt_gravar2cl.Visible = False
        bt_gravar2cl.Enabled = False
    End Sub
End Class