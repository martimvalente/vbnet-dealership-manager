Public Class Index
    Private Sub bt_car_Click(sender As Object, e As EventArgs) Handles bt_car.Click
        Carros.Show() 'abre o form dos carros
        Me.Hide() 'fecha o form inicial
    End Sub

    Private Sub bt_cli_Click(sender As Object, e As EventArgs) Handles bt_cli.Click
        Clientes.Show() 'abre o form dos clientes
        Me.Hide() 'fecha o form inicial
    End Sub

    Private Sub bt_vendas_Click(sender As Object, e As EventArgs) Handles bt_vendas.Click
        Vendas.Show() 'abre o form das vendas
        Me.Hide() 'fecha o form inicial
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdprojetoDataSet1.TopCompras' table. You can move, or remove it, as needed.
        Me.TopComprasTableAdapter1.Fill(Me.BdprojetoDataSet1.TopCompras)

    End Sub
End Class
