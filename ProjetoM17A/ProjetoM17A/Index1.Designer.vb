<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Index
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.bt_car = New System.Windows.Forms.Button()
        Me.bt_cli = New System.Windows.Forms.Button()
        Me.bt_vendas = New System.Windows.Forms.Button()
        Me.BdprojetoDataSet1 = New ProjetoM17A.bdprojetoDataSet()
        Me.TopComprasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopComprasTableAdapter1 = New ProjetoM17A.bdprojetoDataSetTableAdapters.TopComprasTableAdapter()
        Me.TableAdapterManager1 = New ProjetoM17A.bdprojetoDataSetTableAdapters.TableAdapterManager()
        CType(Me.BdprojetoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopComprasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_car
        '
        Me.bt_car.BackColor = System.Drawing.Color.Silver
        Me.bt_car.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_car.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_car.ForeColor = System.Drawing.Color.Black
        Me.bt_car.Location = New System.Drawing.Point(12, 10)
        Me.bt_car.Name = "bt_car"
        Me.bt_car.Size = New System.Drawing.Size(276, 70)
        Me.bt_car.TabIndex = 6
        Me.bt_car.Text = "Carros"
        Me.bt_car.UseVisualStyleBackColor = False
        '
        'bt_cli
        '
        Me.bt_cli.BackColor = System.Drawing.Color.Silver
        Me.bt_cli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cli.ForeColor = System.Drawing.Color.Black
        Me.bt_cli.Location = New System.Drawing.Point(12, 86)
        Me.bt_cli.Name = "bt_cli"
        Me.bt_cli.Size = New System.Drawing.Size(276, 70)
        Me.bt_cli.TabIndex = 7
        Me.bt_cli.Text = "Clientes"
        Me.bt_cli.UseVisualStyleBackColor = False
        '
        'bt_vendas
        '
        Me.bt_vendas.BackColor = System.Drawing.Color.Silver
        Me.bt_vendas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_vendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_vendas.ForeColor = System.Drawing.Color.Black
        Me.bt_vendas.Location = New System.Drawing.Point(12, 162)
        Me.bt_vendas.Name = "bt_vendas"
        Me.bt_vendas.Size = New System.Drawing.Size(276, 70)
        Me.bt_vendas.TabIndex = 8
        Me.bt_vendas.Text = "Vendas"
        Me.bt_vendas.UseVisualStyleBackColor = False
        '
        'BdprojetoDataSet1
        '
        Me.BdprojetoDataSet1.DataSetName = "bdprojetoDataSet"
        Me.BdprojetoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopComprasBindingSource1
        '
        Me.TopComprasBindingSource1.DataMember = "TopCompras"
        Me.TopComprasBindingSource1.DataSource = Me.BdprojetoDataSet1
        '
        'TopComprasTableAdapter1
        '
        Me.TopComprasTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CarrosTableAdapter = Nothing
        Me.TableAdapterManager1.ClientesTableAdapter = Nothing
        Me.TableAdapterManager1.ComprasTableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = ProjetoM17A.bdprojetoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Index
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(298, 244)
        Me.Controls.Add(Me.bt_vendas)
        Me.Controls.Add(Me.bt_cli)
        Me.Controls.Add(Me.bt_car)
        Me.MaximizeBox = False
        Me.Name = "Index"
        CType(Me.BdprojetoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopComprasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_clientes As Button
    Friend WithEvents bt_carros As Button
    Friend WithEvents BdprojetoDataSet As bdprojetoDataSet
    Friend WithEvents TopComprasBindingSource As BindingSource
    Friend WithEvents TopComprasTableAdapter As bdprojetoDataSetTableAdapters.TopComprasTableAdapter
    Friend WithEvents TableAdapterManager As bdprojetoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TopComprasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TopComprasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TopComprasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents bt_car As Button
    Friend WithEvents bt_cli As Button
    Friend WithEvents bt_vendas As Button
    Friend WithEvents BdprojetoDataSet1 As bdprojetoDataSet
    Friend WithEvents TopComprasBindingSource1 As BindingSource
    Friend WithEvents TopComprasTableAdapter1 As bdprojetoDataSetTableAdapters.TopComprasTableAdapter
    Friend WithEvents TableAdapterManager1 As bdprojetoDataSetTableAdapters.TableAdapterManager
End Class
