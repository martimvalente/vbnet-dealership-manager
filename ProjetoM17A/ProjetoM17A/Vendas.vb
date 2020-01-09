Public Class Vendas
    'variaveis vendas
    Dim idCar_tmp, idCl_tmp As Integer
    Dim precoCar_tmp As Decimal
    Dim data_tmp As Date

    'botões enabled/disabled
    Private Sub botoes(ByVal estado As Integer)
        If estado = 1 Then
            bt_primeiro.Visible = False
            bt_anterior.Visible = False
            bt_seguinte.Visible = False
            bt_ultimo.Visible = False
            bt_delete.Visible = False
        ElseIf estado = 0 Then
            bt_primeiro.Visible = True
            bt_anterior.Visible = True
            bt_seguinte.Visible = True
            bt_ultimo.Visible = True
            bt_delete.Visible = True
        End If
    End Sub



    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ComprasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdprojetoDataSet)

    End Sub

    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdprojetoDataSet.Compras' table. You can move, or remove it, as needed.
        Me.ComprasTableAdapter.Fill(Me.BdprojetoDataSet.Compras)

        'inibir botoes
        bt_gravar.Visible = False
        bt_gravar.Enabled = False

        bt_gravar2.Visible = False
        bt_gravar2.Enabled = False
    End Sub

    Private Sub bt_primeiro_Click(sender As Object, e As EventArgs) Handles bt_primeiro.Click
        ComprasBindingSource.MoveFirst() 'move para o primeiro
    End Sub

    Private Sub bt_anterior_Click(sender As Object, e As EventArgs) Handles bt_anterior.Click
        ComprasBindingSource.MovePrevious() 'move para o anterior
    End Sub

    Private Sub bt_seguinte_Click(sender As Object, e As EventArgs) Handles bt_seguinte.Click
        ComprasBindingSource.MoveNext() 'move para o seguinte
    End Sub

    Private Sub bt_ultimo_Click(sender As Object, e As EventArgs) Handles bt_ultimo.Click
        ComprasBindingSource.MoveLast() 'move para o ultimo
    End Sub

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click, Button1.Click
        'vai tentar eliminar o registo atraves de um TRY
        Dim Adapter_tmp As New bdprojetoDataSetTableAdapters.ComprasTableAdapter
        Try
            Adapter_tmp.Delete(Id_carroTextBox.Text, Id_clienteTextBox.Text, PrecoTextBox.Text, DataDateTimePicker.MaxDate)
            MsgBox("Registo eliminado com sucesso", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message) 'detetar se tem erros
        End Try

        Me.ComprasTableAdapter.Fill(Me.BdprojetoDataSet.Compras)

        botoes(0)
    End Sub

    Private Sub bt_novo_Click(sender As Object, e As EventArgs) Handles bt_novo.Click, Button2.Click
        'preparar os campos
        Id_carroTextBox.Text = ""
        Id_clienteTextBox.Text = ""
        PrecoTextBox.Text = ""
        DataDateTimePicker.Text = ""

        bt_gravar.Visible = True
        bt_gravar.Enabled = True

        'inibir botoes
        botoes(1)

        bt_novo.Text = "Limpar"
    End Sub

    Private Sub bt_atualizar_Click(sender As Object, e As EventArgs) Handles bt_atualizar.Click, Button3.Click
        idCar_tmp = Id_carroTextBox.Text
        idCl_tmp = Id_clienteTextBox.Text
        precoCar_tmp = PrecoTextBox.Text
        data_tmp = DataDateTimePicker.Text


        'inibir botoes
        botoes(1)
        bt_novo.Visible = False
        bt_gravar2.Visible = True
        bt_gravar2.Enabled = True
    End Sub

    Private Sub bt_gravar_Click(sender As Object, e As EventArgs) Handles bt_gravar.Click
        'registos de dados na tabela
        Dim Adapter_tmp As New bdprojetoDataSetTableAdapters.ComprasTableAdapter
        Try
            Adapter_tmp.Insert(Id_carroTextBox.Text, Id_clienteTextBox.Text, PrecoTextBox.Text, DataDateTimePicker.Text)
            MsgBox("Registo inserido com sucesso", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message) 'detetar se tem erros
        End Try

        Me.ComprasTableAdapter.Fill(Me.BdprojetoDataSet.Compras)

        bt_gravar.Visible = False
        bt_gravar.Enabled = False

        'inibir botoes
        botoes(0)

        bt_novo.Text = "Novo"
    End Sub

    Private Sub bt_tras_Click(sender As Object, e As EventArgs) Handles bt_tras.Click
        Index.Show() 'abre o form do menu
        Me.Hide() 'fecha o form inicial
    End Sub

    Private Sub bt_gravar2_Click(sender As Object, e As EventArgs) Handles bt_gravar2.Click
        'registos atualizar dados na tabela
        Dim Adapter_tmp As New bdprojetoDataSetTableAdapters.ComprasTableAdapter
        Try
            Adapter_tmp.Update(PrecoTextBox.Text, DataDateTimePicker.Text, idCar_tmp, idCl_tmp, precoCar_tmp, data_tmp)
            MsgBox("Registo inserido com sucesso", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message) 'detetar se tem erros
        End Try

        'inibir botoes
        botoes(0)
        bt_novo.Visible = True
        bt_gravar2.Visible = False
        bt_gravar2.Enabled = False
    End Sub
End Class