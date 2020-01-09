<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Carros
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
        Dim Id_carroLabel As System.Windows.Forms.Label
        Dim Marca_carroLabel As System.Windows.Forms.Label
        Dim Modelo_carroLabel As System.Windows.Forms.Label
        Dim Cor_carroLabel As System.Windows.Forms.Label
        Dim PrecoLabel As System.Windows.Forms.Label
        Dim QuilometrosLabel As System.Windows.Forms.Label
        Dim PotenciaLabel As System.Windows.Forms.Label
        Dim CombustivelLabel As System.Windows.Forms.Label
        Dim LocalLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carros))
        Me.l_carro = New System.Windows.Forms.Label()
        Me.bt_primeirocar = New System.Windows.Forms.Button()
        Me.bt_anteriorcar = New System.Windows.Forms.Button()
        Me.bt_seguintecar = New System.Windows.Forms.Button()
        Me.bt_ultimocar = New System.Windows.Forms.Button()
        Me.bt_deletecar = New System.Windows.Forms.Button()
        Me.bt_novocar = New System.Windows.Forms.Button()
        Me.bt_gravarcar = New System.Windows.Forms.Button()
        Me.bt_atualizarcar = New System.Windows.Forms.Button()
        Me.bt_gravar2car = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BdprojetoDataSet = New ProjetoM17A.bdprojetoDataSet()
        Me.CarrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarrosTableAdapter = New ProjetoM17A.bdprojetoDataSetTableAdapters.CarrosTableAdapter()
        Me.TableAdapterManager = New ProjetoM17A.bdprojetoDataSetTableAdapters.TableAdapterManager()
        Me.CarrosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CarrosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_carroTextBox = New System.Windows.Forms.TextBox()
        Me.Marca_carroTextBox = New System.Windows.Forms.TextBox()
        Me.Modelo_carroTextBox = New System.Windows.Forms.TextBox()
        Me.Cor_carroTextBox = New System.Windows.Forms.TextBox()
        Me.PrecoTextBox = New System.Windows.Forms.TextBox()
        Me.QuilometrosTextBox = New System.Windows.Forms.TextBox()
        Me.PotenciaTextBox = New System.Windows.Forms.TextBox()
        Me.CombustivelTextBox = New System.Windows.Forms.TextBox()
        Me.LocalTextBox = New System.Windows.Forms.TextBox()
        Me.FotoTextBox = New System.Windows.Forms.TextBox()
        Me.bt_tras = New System.Windows.Forms.Button()
        Me.CarrosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Id_carroLabel = New System.Windows.Forms.Label()
        Marca_carroLabel = New System.Windows.Forms.Label()
        Modelo_carroLabel = New System.Windows.Forms.Label()
        Cor_carroLabel = New System.Windows.Forms.Label()
        PrecoLabel = New System.Windows.Forms.Label()
        QuilometrosLabel = New System.Windows.Forms.Label()
        PotenciaLabel = New System.Windows.Forms.Label()
        CombustivelLabel = New System.Windows.Forms.Label()
        LocalLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdprojetoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarrosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CarrosBindingNavigator.SuspendLayout()
        CType(Me.CarrosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_carroLabel
        '
        Id_carroLabel.AutoSize = True
        Id_carroLabel.BackColor = System.Drawing.Color.Gray
        Id_carroLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_carroLabel.ForeColor = System.Drawing.SystemColors.Menu
        Id_carroLabel.Location = New System.Drawing.Point(23, 79)
        Id_carroLabel.Name = "Id_carroLabel"
        Id_carroLabel.Size = New System.Drawing.Size(64, 15)
        Id_carroLabel.TabIndex = 32
        Id_carroLabel.Text = "Id Carro:"
        '
        'Marca_carroLabel
        '
        Marca_carroLabel.AutoSize = True
        Marca_carroLabel.BackColor = System.Drawing.Color.Gray
        Marca_carroLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Marca_carroLabel.ForeColor = System.Drawing.SystemColors.Menu
        Marca_carroLabel.Location = New System.Drawing.Point(23, 105)
        Marca_carroLabel.Name = "Marca_carroLabel"
        Marca_carroLabel.Size = New System.Drawing.Size(52, 15)
        Marca_carroLabel.TabIndex = 34
        Marca_carroLabel.Text = "Marca:"
        '
        'Modelo_carroLabel
        '
        Modelo_carroLabel.AutoSize = True
        Modelo_carroLabel.BackColor = System.Drawing.Color.Gray
        Modelo_carroLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Modelo_carroLabel.ForeColor = System.Drawing.SystemColors.Menu
        Modelo_carroLabel.Location = New System.Drawing.Point(23, 131)
        Modelo_carroLabel.Name = "Modelo_carroLabel"
        Modelo_carroLabel.Size = New System.Drawing.Size(58, 15)
        Modelo_carroLabel.TabIndex = 36
        Modelo_carroLabel.Text = "Modelo:"
        '
        'Cor_carroLabel
        '
        Cor_carroLabel.AutoSize = True
        Cor_carroLabel.BackColor = System.Drawing.Color.Gray
        Cor_carroLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cor_carroLabel.ForeColor = System.Drawing.SystemColors.Menu
        Cor_carroLabel.Location = New System.Drawing.Point(23, 157)
        Cor_carroLabel.Name = "Cor_carroLabel"
        Cor_carroLabel.Size = New System.Drawing.Size(35, 15)
        Cor_carroLabel.TabIndex = 38
        Cor_carroLabel.Text = "Cor:"
        '
        'PrecoLabel
        '
        PrecoLabel.AutoSize = True
        PrecoLabel.BackColor = System.Drawing.Color.Gray
        PrecoLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecoLabel.ForeColor = System.Drawing.SystemColors.Menu
        PrecoLabel.Location = New System.Drawing.Point(23, 183)
        PrecoLabel.Name = "PrecoLabel"
        PrecoLabel.Size = New System.Drawing.Size(50, 15)
        PrecoLabel.TabIndex = 40
        PrecoLabel.Text = "Preço:"
        '
        'QuilometrosLabel
        '
        QuilometrosLabel.AutoSize = True
        QuilometrosLabel.BackColor = System.Drawing.Color.Gray
        QuilometrosLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuilometrosLabel.ForeColor = System.Drawing.SystemColors.Menu
        QuilometrosLabel.Location = New System.Drawing.Point(23, 209)
        QuilometrosLabel.Name = "QuilometrosLabel"
        QuilometrosLabel.Size = New System.Drawing.Size(91, 15)
        QuilometrosLabel.TabIndex = 42
        QuilometrosLabel.Text = "Quilometros:"
        '
        'PotenciaLabel
        '
        PotenciaLabel.AutoSize = True
        PotenciaLabel.BackColor = System.Drawing.Color.Gray
        PotenciaLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PotenciaLabel.ForeColor = System.Drawing.SystemColors.Menu
        PotenciaLabel.Location = New System.Drawing.Point(23, 235)
        PotenciaLabel.Name = "PotenciaLabel"
        PotenciaLabel.Size = New System.Drawing.Size(69, 15)
        PotenciaLabel.TabIndex = 44
        PotenciaLabel.Text = "Potência:"
        '
        'CombustivelLabel
        '
        CombustivelLabel.AutoSize = True
        CombustivelLabel.BackColor = System.Drawing.Color.Gray
        CombustivelLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CombustivelLabel.ForeColor = System.Drawing.SystemColors.Menu
        CombustivelLabel.Location = New System.Drawing.Point(23, 261)
        CombustivelLabel.Name = "CombustivelLabel"
        CombustivelLabel.Size = New System.Drawing.Size(92, 15)
        CombustivelLabel.TabIndex = 46
        CombustivelLabel.Text = "Combustivel:"
        '
        'LocalLabel
        '
        LocalLabel.AutoSize = True
        LocalLabel.BackColor = System.Drawing.Color.Gray
        LocalLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalLabel.ForeColor = System.Drawing.SystemColors.Menu
        LocalLabel.Location = New System.Drawing.Point(23, 287)
        LocalLabel.Name = "LocalLabel"
        LocalLabel.Size = New System.Drawing.Size(47, 15)
        LocalLabel.TabIndex = 48
        LocalLabel.Text = "Local:"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.BackColor = System.Drawing.Color.Gray
        FotoLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FotoLabel.ForeColor = System.Drawing.SystemColors.Menu
        FotoLabel.Location = New System.Drawing.Point(23, 313)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(40, 15)
        FotoLabel.TabIndex = 50
        FotoLabel.Text = "Foto:"
        '
        'l_carro
        '
        Me.l_carro.AutoSize = True
        Me.l_carro.BackColor = System.Drawing.Color.Gray
        Me.l_carro.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_carro.ForeColor = System.Drawing.SystemColors.Window
        Me.l_carro.Location = New System.Drawing.Point(12, 38)
        Me.l_carro.Name = "l_carro"
        Me.l_carro.Size = New System.Drawing.Size(97, 31)
        Me.l_carro.TabIndex = 3
        Me.l_carro.Text = "Carros"
        '
        'bt_primeirocar
        '
        Me.bt_primeirocar.BackColor = System.Drawing.Color.Gray
        Me.bt_primeirocar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_primeirocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_primeirocar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_primeirocar.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_primeirocar.Location = New System.Drawing.Point(279, 492)
        Me.bt_primeirocar.Name = "bt_primeirocar"
        Me.bt_primeirocar.Size = New System.Drawing.Size(75, 32)
        Me.bt_primeirocar.TabIndex = 4
        Me.bt_primeirocar.Text = "<<"
        Me.bt_primeirocar.UseVisualStyleBackColor = False
        '
        'bt_anteriorcar
        '
        Me.bt_anteriorcar.BackColor = System.Drawing.Color.Gray
        Me.bt_anteriorcar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_anteriorcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_anteriorcar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_anteriorcar.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_anteriorcar.Location = New System.Drawing.Point(360, 492)
        Me.bt_anteriorcar.Name = "bt_anteriorcar"
        Me.bt_anteriorcar.Size = New System.Drawing.Size(75, 32)
        Me.bt_anteriorcar.TabIndex = 5
        Me.bt_anteriorcar.Text = "<"
        Me.bt_anteriorcar.UseVisualStyleBackColor = False
        '
        'bt_seguintecar
        '
        Me.bt_seguintecar.BackColor = System.Drawing.Color.Gray
        Me.bt_seguintecar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_seguintecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_seguintecar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_seguintecar.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_seguintecar.Location = New System.Drawing.Point(1066, 491)
        Me.bt_seguintecar.Name = "bt_seguintecar"
        Me.bt_seguintecar.Size = New System.Drawing.Size(75, 32)
        Me.bt_seguintecar.TabIndex = 6
        Me.bt_seguintecar.Text = ">"
        Me.bt_seguintecar.UseVisualStyleBackColor = False
        '
        'bt_ultimocar
        '
        Me.bt_ultimocar.BackColor = System.Drawing.Color.Gray
        Me.bt_ultimocar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_ultimocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ultimocar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ultimocar.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_ultimocar.Location = New System.Drawing.Point(1147, 491)
        Me.bt_ultimocar.Name = "bt_ultimocar"
        Me.bt_ultimocar.Size = New System.Drawing.Size(75, 32)
        Me.bt_ultimocar.TabIndex = 7
        Me.bt_ultimocar.Text = ">>"
        Me.bt_ultimocar.UseVisualStyleBackColor = False
        '
        'bt_deletecar
        '
        Me.bt_deletecar.BackColor = System.Drawing.Color.Gray
        Me.bt_deletecar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_deletecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_deletecar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_deletecar.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_deletecar.Location = New System.Drawing.Point(12, 343)
        Me.bt_deletecar.Name = "bt_deletecar"
        Me.bt_deletecar.Size = New System.Drawing.Size(237, 32)
        Me.bt_deletecar.TabIndex = 8
        Me.bt_deletecar.Text = "Delete"
        Me.bt_deletecar.UseVisualStyleBackColor = False
        '
        'bt_novocar
        '
        Me.bt_novocar.BackColor = System.Drawing.Color.Gray
        Me.bt_novocar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_novocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_novocar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_novocar.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_novocar.Location = New System.Drawing.Point(12, 381)
        Me.bt_novocar.Name = "bt_novocar"
        Me.bt_novocar.Size = New System.Drawing.Size(237, 32)
        Me.bt_novocar.TabIndex = 9
        Me.bt_novocar.Text = "Novo"
        Me.bt_novocar.UseVisualStyleBackColor = False
        '
        'bt_gravarcar
        '
        Me.bt_gravarcar.BackColor = System.Drawing.Color.Gray
        Me.bt_gravarcar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_gravarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_gravarcar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gravarcar.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_gravarcar.Location = New System.Drawing.Point(12, 454)
        Me.bt_gravarcar.Name = "bt_gravarcar"
        Me.bt_gravarcar.Size = New System.Drawing.Size(237, 32)
        Me.bt_gravarcar.TabIndex = 10
        Me.bt_gravarcar.Text = "Gravar"
        Me.bt_gravarcar.UseVisualStyleBackColor = False
        '
        'bt_atualizarcar
        '
        Me.bt_atualizarcar.BackColor = System.Drawing.Color.Gray
        Me.bt_atualizarcar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_atualizarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_atualizarcar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_atualizarcar.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_atualizarcar.Location = New System.Drawing.Point(12, 416)
        Me.bt_atualizarcar.Name = "bt_atualizarcar"
        Me.bt_atualizarcar.Size = New System.Drawing.Size(237, 32)
        Me.bt_atualizarcar.TabIndex = 11
        Me.bt_atualizarcar.Text = "Atualizar"
        Me.bt_atualizarcar.UseVisualStyleBackColor = False
        '
        'bt_gravar2car
        '
        Me.bt_gravar2car.BackColor = System.Drawing.Color.Gray
        Me.bt_gravar2car.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_gravar2car.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_gravar2car.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gravar2car.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_gravar2car.Location = New System.Drawing.Point(12, 492)
        Me.bt_gravar2car.Name = "bt_gravar2car"
        Me.bt_gravar2car.Size = New System.Drawing.Size(237, 32)
        Me.bt_gravar2car.TabIndex = 12
        Me.bt_gravar2car.Text = "Gravar"
        Me.bt_gravar2car.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(557, 254)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 269)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'BdprojetoDataSet
        '
        Me.BdprojetoDataSet.DataSetName = "bdprojetoDataSet"
        Me.BdprojetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarrosBindingSource
        '
        Me.CarrosBindingSource.DataMember = "Carros"
        Me.CarrosBindingSource.DataSource = Me.BdprojetoDataSet
        '
        'CarrosTableAdapter
        '
        Me.CarrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarrosTableAdapter = Me.CarrosTableAdapter
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjetoM17A.bdprojetoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CarrosBindingNavigator
        '
        Me.CarrosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CarrosBindingNavigator.BindingSource = Me.CarrosBindingSource
        Me.CarrosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CarrosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CarrosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CarrosBindingNavigatorSaveItem})
        Me.CarrosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CarrosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CarrosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CarrosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CarrosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CarrosBindingNavigator.Name = "CarrosBindingNavigator"
        Me.CarrosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CarrosBindingNavigator.Size = New System.Drawing.Size(967, 25)
        Me.CarrosBindingNavigator.TabIndex = 32
        Me.CarrosBindingNavigator.Text = "BindingNavigator1"
        Me.CarrosBindingNavigator.Visible = False
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
        'CarrosBindingNavigatorSaveItem
        '
        Me.CarrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CarrosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CarrosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CarrosBindingNavigatorSaveItem.Name = "CarrosBindingNavigatorSaveItem"
        Me.CarrosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CarrosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_carroTextBox
        '
        Me.Id_carroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrosBindingSource, "Id_carro", True))
        Me.Id_carroTextBox.Enabled = False
        Me.Id_carroTextBox.Location = New System.Drawing.Point(120, 77)
        Me.Id_carroTextBox.Name = "Id_carroTextBox"
        Me.Id_carroTextBox.Size = New System.Drawing.Size(129, 20)
        Me.Id_carroTextBox.TabIndex = 33
        '
        'Marca_carroTextBox
        '
        Me.Marca_carroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrosBindingSource, "marca_carro", True))
        Me.Marca_carroTextBox.Location = New System.Drawing.Point(120, 103)
        Me.Marca_carroTextBox.Name = "Marca_carroTextBox"
        Me.Marca_carroTextBox.Size = New System.Drawing.Size(129, 20)
        Me.Marca_carroTextBox.TabIndex = 35
        '
        'Modelo_carroTextBox
        '
        Me.Modelo_carroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrosBindingSource, "modelo_carro", True))
        Me.Modelo_carroTextBox.Location = New System.Drawing.Point(120, 129)
        Me.Modelo_carroTextBox.Name = "Modelo_carroTextBox"
        Me.Modelo_carroTextBox.Size = New System.Drawing.Size(129, 20)
        Me.Modelo_carroTextBox.TabIndex = 37
        '
        'Cor_carroTextBox
        '
        Me.Cor_carroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrosBindingSource, "cor_carro", True))
        Me.Cor_carroTextBox.Location = New System.Drawing.Point(120, 155)
        Me.Cor_carroTextBox.Name = "Cor_carroTextBox"
        Me.Cor_carroTextBox.Size = New System.Drawing.Size(129, 20)
        Me.Cor_carroTextBox.TabIndex = 39
        '
        'PrecoTextBox
        '
        Me.PrecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrosBindingSource, "preco", True))
        Me.PrecoTextBox.Location = New System.Drawing.Point(120, 181)
        Me.PrecoTextBox.Name = "PrecoTextBox"
        Me.PrecoTextBox.Size = New System.Drawing.Size(129, 20)
        Me.PrecoTextBox.TabIndex = 41
        '
        'QuilometrosTextBox
        '
        Me.QuilometrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrosBindingSource, "quilometros", True))
        Me.QuilometrosTextBox.Location = New System.Drawing.Point(120, 207)
        Me.QuilometrosTextBox.Name = "QuilometrosTextBox"
        Me.QuilometrosTextBox.Size = New System.Drawing.Size(129, 20)
        Me.QuilometrosTextBox.TabIndex = 43
        '
        'PotenciaTextBox
        '
        Me.PotenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrosBindingSource, "potencia", True))
        Me.PotenciaTextBox.Location = New System.Drawing.Point(120, 233)
        Me.PotenciaTextBox.Name = "PotenciaTextBox"
        Me.PotenciaTextBox.Size = New System.Drawing.Size(129, 20)
        Me.PotenciaTextBox.TabIndex = 45
        '
        'CombustivelTextBox
        '
        Me.CombustivelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrosBindingSource, "combustivel", True))
        Me.CombustivelTextBox.Location = New System.Drawing.Point(120, 259)
        Me.CombustivelTextBox.Name = "CombustivelTextBox"
        Me.CombustivelTextBox.Size = New System.Drawing.Size(129, 20)
        Me.CombustivelTextBox.TabIndex = 47
        '
        'LocalTextBox
        '
        Me.LocalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrosBindingSource, "local", True))
        Me.LocalTextBox.Location = New System.Drawing.Point(120, 285)
        Me.LocalTextBox.Name = "LocalTextBox"
        Me.LocalTextBox.Size = New System.Drawing.Size(129, 20)
        Me.LocalTextBox.TabIndex = 49
        '
        'FotoTextBox
        '
        Me.FotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrosBindingSource, "foto", True))
        Me.FotoTextBox.Location = New System.Drawing.Point(120, 311)
        Me.FotoTextBox.Name = "FotoTextBox"
        Me.FotoTextBox.Size = New System.Drawing.Size(129, 20)
        Me.FotoTextBox.TabIndex = 51
        '
        'bt_tras
        '
        Me.bt_tras.BackColor = System.Drawing.Color.Gray
        Me.bt_tras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_tras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_tras.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tras.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_tras.Location = New System.Drawing.Point(2, 1)
        Me.bt_tras.Name = "bt_tras"
        Me.bt_tras.Size = New System.Drawing.Size(35, 32)
        Me.bt_tras.TabIndex = 52
        Me.bt_tras.Text = "<"
        Me.bt_tras.UseVisualStyleBackColor = False
        '
        'CarrosDataGridView
        '
        Me.CarrosDataGridView.AutoGenerateColumns = False
        Me.CarrosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CarrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarrosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11})
        Me.CarrosDataGridView.Cursor = System.Windows.Forms.Cursors.Default
        Me.CarrosDataGridView.DataSource = Me.CarrosBindingSource
        Me.CarrosDataGridView.Location = New System.Drawing.Point(270, 12)
        Me.CarrosDataGridView.Name = "CarrosDataGridView"
        Me.CarrosDataGridView.Size = New System.Drawing.Size(943, 220)
        Me.CarrosDataGridView.TabIndex = 52
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_carro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_carro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "marca_carro"
        Me.DataGridViewTextBoxColumn2.HeaderText = "marca_carro"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "modelo_carro"
        Me.DataGridViewTextBoxColumn3.HeaderText = "modelo_carro"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cor_carro"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cor_carro"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "preco"
        Me.DataGridViewTextBoxColumn5.HeaderText = "preco"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "quilometros"
        Me.DataGridViewTextBoxColumn6.HeaderText = "quilometros"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "potencia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "potencia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "combustivel"
        Me.DataGridViewTextBoxColumn8.HeaderText = "combustivel"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "local"
        Me.DataGridViewTextBoxColumn9.HeaderText = "local"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "foto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "foto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gray
        Me.PictureBox2.Location = New System.Drawing.Point(-8, -15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(272, 589)
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'Carros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1251, 542)
        Me.Controls.Add(Me.CarrosDataGridView)
        Me.Controls.Add(Me.bt_tras)
        Me.Controls.Add(Id_carroLabel)
        Me.Controls.Add(Me.Id_carroTextBox)
        Me.Controls.Add(Marca_carroLabel)
        Me.Controls.Add(Me.Marca_carroTextBox)
        Me.Controls.Add(Modelo_carroLabel)
        Me.Controls.Add(Me.Modelo_carroTextBox)
        Me.Controls.Add(Cor_carroLabel)
        Me.Controls.Add(Me.Cor_carroTextBox)
        Me.Controls.Add(PrecoLabel)
        Me.Controls.Add(Me.PrecoTextBox)
        Me.Controls.Add(QuilometrosLabel)
        Me.Controls.Add(Me.QuilometrosTextBox)
        Me.Controls.Add(PotenciaLabel)
        Me.Controls.Add(Me.PotenciaTextBox)
        Me.Controls.Add(CombustivelLabel)
        Me.Controls.Add(Me.CombustivelTextBox)
        Me.Controls.Add(LocalLabel)
        Me.Controls.Add(Me.LocalTextBox)
        Me.Controls.Add(FotoLabel)
        Me.Controls.Add(Me.FotoTextBox)
        Me.Controls.Add(Me.CarrosBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bt_gravar2car)
        Me.Controls.Add(Me.bt_atualizarcar)
        Me.Controls.Add(Me.bt_gravarcar)
        Me.Controls.Add(Me.bt_novocar)
        Me.Controls.Add(Me.bt_deletecar)
        Me.Controls.Add(Me.bt_ultimocar)
        Me.Controls.Add(Me.bt_seguintecar)
        Me.Controls.Add(Me.bt_anteriorcar)
        Me.Controls.Add(Me.bt_primeirocar)
        Me.Controls.Add(Me.l_carro)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.Name = "Carros"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdprojetoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarrosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CarrosBindingNavigator.ResumeLayout(False)
        Me.CarrosBindingNavigator.PerformLayout()
        CType(Me.CarrosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l_carro As Label
    Friend WithEvents bt_primeirocar As Button
    Friend WithEvents bt_anteriorcar As Button
    Friend WithEvents bt_seguintecar As Button
    Friend WithEvents bt_ultimocar As Button
    Friend WithEvents bt_deletecar As Button
    Friend WithEvents bt_novocar As Button
    Friend WithEvents bt_gravarcar As Button
    Friend WithEvents bt_atualizarcar As Button
    Friend WithEvents bt_gravar2car As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents BdprojetoDataSet As bdprojetoDataSet
    Friend WithEvents CarrosBindingSource As BindingSource
    Friend WithEvents CarrosTableAdapter As bdprojetoDataSetTableAdapters.CarrosTableAdapter
    Friend WithEvents TableAdapterManager As bdprojetoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CarrosBindingNavigator As BindingNavigator
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
    Friend WithEvents CarrosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Id_carroTextBox As TextBox
    Friend WithEvents Marca_carroTextBox As TextBox
    Friend WithEvents Modelo_carroTextBox As TextBox
    Friend WithEvents Cor_carroTextBox As TextBox
    Friend WithEvents PrecoTextBox As TextBox
    Friend WithEvents QuilometrosTextBox As TextBox
    Friend WithEvents PotenciaTextBox As TextBox
    Friend WithEvents CombustivelTextBox As TextBox
    Friend WithEvents LocalTextBox As TextBox
    Friend WithEvents FotoTextBox As TextBox
    Friend WithEvents bt_tras As Button
    Friend WithEvents CarrosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
End Class
