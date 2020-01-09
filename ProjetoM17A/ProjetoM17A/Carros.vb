Public Class Carros
    'variaveis carros
    Dim idCar_tmp, quilometrosCar_tmp, potenciaCar_tmp As Integer
    Dim marcaCar_tmp, modeloCar_tmp, corCar_tmp, combustivelCar_tmp, localCar_tmp, fotoCar_tmp As String
    Dim precoCar_tmp As Decimal

    'botões enabled/disabled
    Private Sub botoes(ByVal estado As Integer)
        If estado = 1 Then
            bt_primeirocar.Visible = False
            bt_anteriorcar.Visible = False
            bt_seguintecar.Visible = False
            bt_ultimocar.Visible = False
            bt_deletecar.Visible = False
        ElseIf estado = 0 Then
            bt_primeirocar.Visible = True
            bt_anteriorcar.Visible = True
            bt_seguintecar.Visible = True
            bt_ultimocar.Visible = True
            bt_deletecar.Visible = True
        End If
    End Sub
    Private Sub CarrosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CarrosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CarrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdprojetoDataSet)

    End Sub

    Private Sub Carros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdprojetoDataSet.Carros' table. You can move, or remove it, as needed.
        Me.CarrosTableAdapter.Fill(Me.BdprojetoDataSet.Carros)
        PictureBox1.ImageLocation = "...\Imagem\" + FotoTextBox.Text + ".png"
        'inibir botoes
        bt_gravarcar.Visible = False
        bt_gravarcar.Enabled = False

        bt_gravar2car.Visible = False
        bt_gravar2car.Enabled = False

    End Sub

    Private Sub bt_primeirocar_Click(sender As Object, e As EventArgs) Handles bt_primeirocar.Click

        CarrosBindingSource.MoveFirst() 'move para o primeiro
        PictureBox1.ImageLocation = "...\Imagem\" + FotoTextBox.Text + ".png"
    End Sub

    Private Sub bt_anteriorcar_Click(sender As Object, e As EventArgs) Handles bt_anteriorcar.Click

        CarrosBindingSource.MovePrevious() 'move para o anterior
        PictureBox1.ImageLocation = "...\Imagem\" + FotoTextBox.Text + ".png"
    End Sub

    Private Sub bt_tras_Click(sender As Object, e As EventArgs) Handles bt_tras.Click
        Index.Show() 'abre o form do menu
        Me.Hide() 'fecha o form inicial
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub bt_seguintecar_Click(sender As Object, e As EventArgs) Handles bt_seguintecar.Click

        CarrosBindingSource.MoveNext() 'move para o seguinte
        PictureBox1.ImageLocation = "...\Imagem\" + FotoTextBox.Text + ".png"
    End Sub

    Private Sub bt_ultimocar_Click(sender As Object, e As EventArgs) Handles bt_ultimocar.Click

        CarrosBindingSource.MoveLast() 'move para o ultimo
        PictureBox1.ImageLocation = "...\Imagem\" + FotoTextBox.Text + ".png"
    End Sub

    Private Sub bt_deletecar_Click(sender As Object, e As EventArgs) Handles bt_deletecar.Click
        PictureBox1.ImageLocation = ""
        'vai tentar eliminar o registo atraves de um TRY
        Dim Adapter_tmp As New bdprojetoDataSetTableAdapters.CarrosTableAdapter
        Try
            Adapter_tmp.Delete(Id_carroTextBox.Text, Marca_carroTextBox.Text, Modelo_carroTextBox.Text, Cor_carroTextBox.Text, PrecoTextBox.Text, QuilometrosTextBox.Text, PotenciaTextBox.Text, CombustivelTextBox.Text, LocalTextBox.Text)
            MsgBox("Registo eliminado com sucesso", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message) 'detetar se tem erros
        End Try

        Me.CarrosTableAdapter.Fill(Me.BdprojetoDataSet.Carros)

        botoes(0)
    End Sub

    Private Sub bt_novocar_Click(sender As Object, e As EventArgs) Handles bt_novocar.Click
        'preparar os campos
        Id_carroTextBox.Text = ""
        Marca_carroTextBox.Text = ""
        Modelo_carroTextBox.Text = ""
        Cor_carroTextBox.Text = ""
        PrecoTextBox.Text = ""
        QuilometrosTextBox.Text = ""
        PotenciaTextBox.Text = ""
        CombustivelTextBox.Text = ""
        LocalTextBox.Text = ""
        FotoTextBox.Text = ""

        bt_gravarcar.Visible = True
        bt_gravarcar.Enabled = True

        'inibir botoes
        botoes(1)

        bt_novocar.Text = "Limpar"
    End Sub

    Private Sub bt_gravarcar_Click(sender As Object, e As EventArgs) Handles bt_gravarcar.Click
        PictureBox1.ImageLocation = "...\Imagem\" + FotoTextBox.Text + ".png"
        'registos de dados na tabela
        Dim Adapter_tmp As New bdprojetoDataSetTableAdapters.CarrosTableAdapter
        Try
            Adapter_tmp.Insert(Marca_carroTextBox.Text, Modelo_carroTextBox.Text, Cor_carroTextBox.Text, PrecoTextBox.Text, QuilometrosTextBox.Text, PotenciaTextBox.Text, CombustivelTextBox.Text, LocalTextBox.Text, FotoTextBox.Text)
            MsgBox("Registo inserido com sucesso", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message) 'detetar se tem erros
        End Try

        Me.CarrosTableAdapter.Fill(Me.BdprojetoDataSet.Carros)

        bt_gravarcar.Visible = False
        bt_gravarcar.Enabled = False

        'inibir botoes
        botoes(0)

        bt_novocar.Text = "Novo"
    End Sub

    Private Sub bt_atualizarcar_Click(sender As Object, e As EventArgs) Handles bt_atualizarcar.Click
        idCar_tmp = Id_carroTextBox.Text
        marcaCar_tmp = Marca_carroTextBox.Text
        modeloCar_tmp = Modelo_carroTextBox.Text
        corCar_tmp = Cor_carroTextBox.Text
        precoCar_tmp = PrecoTextBox.Text
        quilometrosCar_tmp = QuilometrosTextBox.Text
        potenciaCar_tmp = PotenciaTextBox.Text
        combustivelCar_tmp = CombustivelTextBox.Text
        localCar_tmp = LocalTextBox.Text
        fotoCar_tmp = FotoTextBox.Text

        'inibir botoes
        botoes(1)
        bt_novocar.Visible = False
        bt_gravar2car.Visible = True
        bt_gravar2car.Enabled = True

    End Sub

    Private Sub bt_gravar2car_Click(sender As Object, e As EventArgs) Handles bt_gravar2car.Click
        PictureBox1.ImageLocation = "...\Imagem\" + FotoTextBox.Text + ".png"
        'registos atualizar dados na tabela
        Dim Adapter_tmp As New bdprojetoDataSetTableAdapters.CarrosTableAdapter
        Try
            Adapter_tmp.Update(Marca_carroTextBox.Text, Modelo_carroTextBox.Text, Cor_carroTextBox.Text, PrecoTextBox.Text, QuilometrosTextBox.Text, PotenciaTextBox.Text, CombustivelTextBox.Text, LocalTextBox.Text, FotoTextBox.Text, idCar_tmp, marcaCar_tmp, modeloCar_tmp, corCar_tmp, precoCar_tmp, quilometrosCar_tmp, potenciaCar_tmp, combustivelCar_tmp, localCar_tmp)
            MsgBox("Registo inserido com sucesso", MsgBoxStyle.Information, Text)
        Catch ex As Exception
            MsgBox(ex.Message) 'detetar se tem erros
        End Try

        'inibir botoes
        botoes(0)
        bt_novocar.Visible = True
        bt_gravar2car.Visible = False
        bt_gravar2car.Enabled = False
    End Sub
End Class