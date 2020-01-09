<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_carroLabel As System.Windows.Forms.Label
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Dim PrecoLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendas))
        Me.bt_gravar2 = New System.Windows.Forms.Button()
        Me.bt_atualizar = New System.Windows.Forms.Button()
        Me.bt_gravar = New System.Windows.Forms.Button()
        Me.bt_novo = New System.Windows.Forms.Button()
        Me.bt_delete = New System.Windows.Forms.Button()
        Me.bt_ultimo = New System.Windows.Forms.Button()
        Me.bt_seguinte = New System.Windows.Forms.Button()
        Me.bt_anterior = New System.Windows.Forms.Button()
        Me.bt_primeiro = New System.Windows.Forms.Button()
        Me.l_carro = New System.Windows.Forms.Label()
        Me.BdprojetoDataSet = New ProjetoM17A.bdprojetoDataSet()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New ProjetoM17A.bdprojetoDataSetTableAdapters.ComprasTableAdapter()
        Me.TableAdapterManager = New ProjetoM17A.bdprojetoDataSetTableAdapters.TableAdapterManager()
        Me.ComprasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComprasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ComprasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_carroTextBox = New System.Windows.Forms.TextBox()
        Me.Id_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.PrecoTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.bt_tras = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Id_carroLabel = New System.Windows.Forms.Label()
        Id_clienteLabel = New System.Windows.Forms.Label()
        PrecoLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        CType(Me.BdprojetoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComprasBindingNavigator.SuspendLayout()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_carroLabel
        '
        Id_carroLabel.AutoSize = True
        Id_carroLabel.BackColor = System.Drawing.Color.Gray
        Id_carroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_carroLabel.ForeColor = System.Drawing.SystemColors.Window
        Id_carroLabel.Location = New System.Drawing.Point(20, 103)
        Id_carroLabel.Name = "Id_carroLabel"
        Id_carroLabel.Size = New System.Drawing.Size(58, 16)
        Id_carroLabel.TabIndex = 88
        Id_carroLabel.Text = "Id Carro:"
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.BackColor = System.Drawing.Color.Gray
        Id_clienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_clienteLabel.ForeColor = System.Drawing.SystemColors.Window
        Id_clienteLabel.Location = New System.Drawing.Point(20, 129)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(66, 16)
        Id_clienteLabel.TabIndex = 90
        Id_clienteLabel.Text = "Id Cliente:"
        '
        'PrecoLabel
        '
        PrecoLabel.AutoSize = True
        PrecoLabel.BackColor = System.Drawing.Color.Gray
        PrecoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecoLabel.ForeColor = System.Drawing.SystemColors.Window
        PrecoLabel.Location = New System.Drawing.Point(20, 155)
        PrecoLabel.Name = "PrecoLabel"
        PrecoLabel.Size = New System.Drawing.Size(47, 16)
        PrecoLabel.TabIndex = 92
        PrecoLabel.Text = "Preço:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.BackColor = System.Drawing.Color.Gray
        DataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.ForeColor = System.Drawing.SystemColors.Window
        DataLabel.Location = New System.Drawing.Point(20, 182)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(40, 16)
        DataLabel.TabIndex = 94
        DataLabel.Text = "Data:"
        '
        'bt_gravar2
        '
        Me.bt_gravar2.BackColor = System.Drawing.Color.Gray
        Me.bt_gravar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_gravar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_gravar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gravar2.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_gravar2.Location = New System.Drawing.Point(11, 389)
        Me.bt_gravar2.Name = "bt_gravar2"
        Me.bt_gravar2.Size = New System.Drawing.Size(281, 32)
        Me.bt_gravar2.TabIndex = 86
        Me.bt_gravar2.Text = "Gravar"
        Me.bt_gravar2.UseVisualStyleBackColor = False
        '
        'bt_atualizar
        '
        Me.bt_atualizar.BackColor = System.Drawing.Color.Black
        Me.bt_atualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_atualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_atualizar.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_atualizar.Location = New System.Drawing.Point(12, 313)
        Me.bt_atualizar.Name = "bt_atualizar"
        Me.bt_atualizar.Size = New System.Drawing.Size(75, 32)
        Me.bt_atualizar.TabIndex = 85
        Me.bt_atualizar.Text = "Atualizar"
        Me.bt_atualizar.UseVisualStyleBackColor = False
        '
        'bt_gravar
        '
        Me.bt_gravar.BackColor = System.Drawing.Color.Gray
        Me.bt_gravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_gravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gravar.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_gravar.Location = New System.Drawing.Point(12, 351)
        Me.bt_gravar.Name = "bt_gravar"
        Me.bt_gravar.Size = New System.Drawing.Size(281, 32)
        Me.bt_gravar.TabIndex = 84
        Me.bt_gravar.Text = "Gravar"
        Me.bt_gravar.UseVisualStyleBackColor = False
        '
        'bt_novo
        '
        Me.bt_novo.BackColor = System.Drawing.Color.Black
        Me.bt_novo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_novo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_novo.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_novo.Location = New System.Drawing.Point(12, 274)
        Me.bt_novo.Name = "bt_novo"
        Me.bt_novo.Size = New System.Drawing.Size(75, 32)
        Me.bt_novo.TabIndex = 83
        Me.bt_novo.Text = "Novo"
        Me.bt_novo.UseVisualStyleBackColor = False
        '
        'bt_delete
        '
        Me.bt_delete.BackColor = System.Drawing.Color.Black
        Me.bt_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_delete.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_delete.Location = New System.Drawing.Point(12, 236)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(75, 32)
        Me.bt_delete.TabIndex = 82
        Me.bt_delete.Text = "Delete"
        Me.bt_delete.UseVisualStyleBackColor = False
        '
        'bt_ultimo
        '
        Me.bt_ultimo.BackColor = System.Drawing.Color.Gray
        Me.bt_ultimo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ultimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ultimo.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_ultimo.Location = New System.Drawing.Point(678, 388)
        Me.bt_ultimo.Name = "bt_ultimo"
        Me.bt_ultimo.Size = New System.Drawing.Size(75, 32)
        Me.bt_ultimo.TabIndex = 81
        Me.bt_ultimo.Text = ">>"
        Me.bt_ultimo.UseVisualStyleBackColor = False
        '
        'bt_seguinte
        '
        Me.bt_seguinte.BackColor = System.Drawing.Color.Gray
        Me.bt_seguinte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_seguinte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_seguinte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_seguinte.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_seguinte.Location = New System.Drawing.Point(588, 388)
        Me.bt_seguinte.Name = "bt_seguinte"
        Me.bt_seguinte.Size = New System.Drawing.Size(75, 32)
        Me.bt_seguinte.TabIndex = 80
        Me.bt_seguinte.Text = ">"
        Me.bt_seguinte.UseVisualStyleBackColor = False
        '
        'bt_anterior
        '
        Me.bt_anterior.BackColor = System.Drawing.Color.Gray
        Me.bt_anterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_anterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_anterior.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_anterior.Location = New System.Drawing.Point(392, 388)
        Me.bt_anterior.Name = "bt_anterior"
        Me.bt_anterior.Size = New System.Drawing.Size(75, 32)
        Me.bt_anterior.TabIndex = 79
        Me.bt_anterior.Text = "<"
        Me.bt_anterior.UseVisualStyleBackColor = False
        '
        'bt_primeiro
        '
        Me.bt_primeiro.BackColor = System.Drawing.Color.Gray
        Me.bt_primeiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_primeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_primeiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_primeiro.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_primeiro.Location = New System.Drawing.Point(311, 389)
        Me.bt_primeiro.Name = "bt_primeiro"
        Me.bt_primeiro.Size = New System.Drawing.Size(75, 32)
        Me.bt_primeiro.TabIndex = 78
        Me.bt_primeiro.Text = "<<"
        Me.bt_primeiro.UseVisualStyleBackColor = False
        '
        'l_carro
        '
        Me.l_carro.AutoSize = True
        Me.l_carro.BackColor = System.Drawing.Color.Gray
        Me.l_carro.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_carro.ForeColor = System.Drawing.SystemColors.Window
        Me.l_carro.Location = New System.Drawing.Point(12, 41)
        Me.l_carro.Name = "l_carro"
        Me.l_carro.Size = New System.Drawing.Size(94, 29)
        Me.l_carro.TabIndex = 77
        Me.l_carro.Text = "Vendas"
        '
        'BdprojetoDataSet
        '
        Me.BdprojetoDataSet.DataSetName = "bdprojetoDataSet"
        Me.BdprojetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.BdprojetoDataSet
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarrosTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Me.ComprasTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjetoM17A.bdprojetoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComprasBindingNavigator
        '
        Me.ComprasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ComprasBindingNavigator.BindingSource = Me.ComprasBindingSource
        Me.ComprasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ComprasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ComprasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ComprasBindingNavigatorSaveItem})
        Me.ComprasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ComprasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ComprasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ComprasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ComprasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ComprasBindingNavigator.Name = "ComprasBindingNavigator"
        Me.ComprasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ComprasBindingNavigator.Size = New System.Drawing.Size(967, 25)
        Me.ComprasBindingNavigator.TabIndex = 88
        Me.ComprasBindingNavigator.Text = "BindingNavigator1"
        Me.ComprasBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ComprasBindingNavigatorSaveItem
        '
        Me.ComprasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ComprasBindingNavigatorSaveItem.Image = CType(resources.GetObject("ComprasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ComprasBindingNavigatorSaveItem.Name = "ComprasBindingNavigatorSaveItem"
        Me.ComprasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ComprasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ComprasDataGridView
        '
        Me.ComprasDataGridView.AutoGenerateColumns = False
        Me.ComprasDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComprasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ComprasDataGridView.DataSource = Me.ComprasBindingSource
        Me.ComprasDataGridView.Location = New System.Drawing.Point(311, 12)
        Me.ComprasDataGridView.Name = "ComprasDataGridView"
        Me.ComprasDataGridView.Size = New System.Drawing.Size(442, 370)
        Me.ComprasDataGridView.TabIndex = 88
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_carro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_carro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "preco"
        Me.DataGridViewTextBoxColumn3.HeaderText = "preco"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn4.HeaderText = "data"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Id_carroTextBox
        '
        Me.Id_carroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "Id_carro", True))
        Me.Id_carroTextBox.Location = New System.Drawing.Point(92, 99)
        Me.Id_carroTextBox.Name = "Id_carroTextBox"
        Me.Id_carroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_carroTextBox.TabIndex = 89
        '
        'Id_clienteTextBox
        '
        Me.Id_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "Id_cliente", True))
        Me.Id_clienteTextBox.Location = New System.Drawing.Point(92, 125)
        Me.Id_clienteTextBox.Name = "Id_clienteTextBox"
        Me.Id_clienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_clienteTextBox.TabIndex = 91
        '
        'PrecoTextBox
        '
        Me.PrecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "preco", True))
        Me.PrecoTextBox.Location = New System.Drawing.Point(92, 151)
        Me.PrecoTextBox.Name = "PrecoTextBox"
        Me.PrecoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrecoTextBox.TabIndex = 93
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComprasBindingSource, "data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(92, 177)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 95
        '
        'bt_tras
        '
        Me.bt_tras.BackColor = System.Drawing.Color.Gray
        Me.bt_tras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_tras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_tras.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tras.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_tras.Location = New System.Drawing.Point(2, 2)
        Me.bt_tras.Name = "bt_tras"
        Me.bt_tras.Size = New System.Drawing.Size(35, 32)
        Me.bt_tras.TabIndex = 96
        Me.bt_tras.Text = "<"
        Me.bt_tras.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(11, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(281, 32)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(11, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(281, 32)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "Novo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Window
        Me.Button3.Location = New System.Drawing.Point(11, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(281, 32)
        Me.Button3.TabIndex = 85
        Me.Button3.Text = "Atualizar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gray
        Me.PictureBox2.Location = New System.Drawing.Point(-11, -7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(316, 589)
        Me.PictureBox2.TabIndex = 97
        Me.PictureBox2.TabStop = False
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(784, 432)
        Me.Controls.Add(Me.bt_tras)
        Me.Controls.Add(Id_carroLabel)
        Me.Controls.Add(Me.Id_carroTextBox)
        Me.Controls.Add(Id_clienteLabel)
        Me.Controls.Add(Me.Id_clienteTextBox)
        Me.Controls.Add(PrecoLabel)
        Me.Controls.Add(Me.PrecoTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(Me.ComprasDataGridView)
        Me.Controls.Add(Me.ComprasBindingNavigator)
        Me.Controls.Add(Me.bt_gravar2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bt_atualizar)
        Me.Controls.Add(Me.bt_gravar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bt_novo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt_delete)
        Me.Controls.Add(Me.bt_ultimo)
        Me.Controls.Add(Me.bt_seguinte)
        Me.Controls.Add(Me.bt_anterior)
        Me.Controls.Add(Me.bt_primeiro)
        Me.Controls.Add(Me.l_carro)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.Name = "Vendas"
        Me.Text = "Vendas"
        CType(Me.BdprojetoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComprasBindingNavigator.ResumeLayout(False)
        Me.ComprasBindingNavigator.PerformLayout()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_gravar2 As Button
    Friend WithEvents bt_atualizar As Button
    Friend WithEvents bt_gravar As Button
    Friend WithEvents bt_novo As Button
    Friend WithEvents bt_delete As Button
    Friend WithEvents bt_ultimo As Button
    Friend WithEvents bt_seguinte As Button
    Friend WithEvents bt_anterior As Button
    Friend WithEvents bt_primeiro As Button
    Friend WithEvents l_carro As Label
    Friend WithEvents BdprojetoDataSet As bdprojetoDataSet
    Friend WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents ComprasTableAdapter As bdprojetoDataSetTableAdapters.ComprasTableAdapter
    Friend WithEvents TableAdapterManager As bdprojetoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComprasBindingNavigator As BindingNavigator
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
    Friend WithEvents ComprasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ComprasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Id_carroTextBox As TextBox
    Friend WithEvents Id_clienteTextBox As TextBox
    Friend WithEvents PrecoTextBox As TextBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents bt_tras As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
