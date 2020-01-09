<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Dim Nome_clienteLabel As System.Windows.Forms.Label
        Dim Cod_postalLabel As System.Windows.Forms.Label
        Dim NacionalidadeLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim N_contribuinteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.bt_gravar2cl = New System.Windows.Forms.Button()
        Me.bt_atualizarcl = New System.Windows.Forms.Button()
        Me.bt_gravarcl = New System.Windows.Forms.Button()
        Me.bt_novocl = New System.Windows.Forms.Button()
        Me.bt_deletecl = New System.Windows.Forms.Button()
        Me.bt_ultimocl = New System.Windows.Forms.Button()
        Me.bt_seguintecl = New System.Windows.Forms.Button()
        Me.bt_anteriorcl = New System.Windows.Forms.Button()
        Me.bt_primeirocl = New System.Windows.Forms.Button()
        Me.l_carro = New System.Windows.Forms.Label()
        Me.BdprojetoDataSet = New ProjetoM17A.bdprojetoDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ProjetoM17A.bdprojetoDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New ProjetoM17A.bdprojetoDataSetTableAdapters.TableAdapterManager()
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_postalTextBox = New System.Windows.Forms.TextBox()
        Me.NacionalidadeTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.N_contribuinteTextBox = New System.Windows.Forms.TextBox()
        Me.bt_tras = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Id_clienteLabel = New System.Windows.Forms.Label()
        Nome_clienteLabel = New System.Windows.Forms.Label()
        Cod_postalLabel = New System.Windows.Forms.Label()
        NacionalidadeLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        N_contribuinteLabel = New System.Windows.Forms.Label()
        CType(Me.BdprojetoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.BackColor = System.Drawing.Color.Gray
        Id_clienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_clienteLabel.ForeColor = System.Drawing.SystemColors.Window
        Id_clienteLabel.Location = New System.Drawing.Point(11, 91)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(66, 16)
        Id_clienteLabel.TabIndex = 64
        Id_clienteLabel.Text = "Id Cliente:"
        '
        'Nome_clienteLabel
        '
        Nome_clienteLabel.AutoSize = True
        Nome_clienteLabel.BackColor = System.Drawing.Color.Gray
        Nome_clienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_clienteLabel.ForeColor = System.Drawing.SystemColors.Window
        Nome_clienteLabel.Location = New System.Drawing.Point(11, 117)
        Nome_clienteLabel.Name = "Nome_clienteLabel"
        Nome_clienteLabel.Size = New System.Drawing.Size(48, 16)
        Nome_clienteLabel.TabIndex = 66
        Nome_clienteLabel.Text = "Nome:"
        '
        'Cod_postalLabel
        '
        Cod_postalLabel.AutoSize = True
        Cod_postalLabel.BackColor = System.Drawing.Color.Gray
        Cod_postalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_postalLabel.ForeColor = System.Drawing.SystemColors.Window
        Cod_postalLabel.Location = New System.Drawing.Point(11, 143)
        Cod_postalLabel.Name = "Cod_postalLabel"
        Cod_postalLabel.Size = New System.Drawing.Size(96, 16)
        Cod_postalLabel.TabIndex = 68
        Cod_postalLabel.Text = "Código Postal:"
        '
        'NacionalidadeLabel
        '
        NacionalidadeLabel.AutoSize = True
        NacionalidadeLabel.BackColor = System.Drawing.Color.Gray
        NacionalidadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NacionalidadeLabel.ForeColor = System.Drawing.SystemColors.Window
        NacionalidadeLabel.Location = New System.Drawing.Point(11, 169)
        NacionalidadeLabel.Name = "NacionalidadeLabel"
        NacionalidadeLabel.Size = New System.Drawing.Size(100, 16)
        NacionalidadeLabel.TabIndex = 70
        NacionalidadeLabel.Text = "Nacionalidade:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.BackColor = System.Drawing.Color.Gray
        TelefoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.ForeColor = System.Drawing.SystemColors.Window
        TelefoneLabel.Location = New System.Drawing.Point(11, 195)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(65, 16)
        TelefoneLabel.TabIndex = 72
        TelefoneLabel.Text = "Telefone:"
        '
        'N_contribuinteLabel
        '
        N_contribuinteLabel.AutoSize = True
        N_contribuinteLabel.BackColor = System.Drawing.Color.Gray
        N_contribuinteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_contribuinteLabel.ForeColor = System.Drawing.SystemColors.Window
        N_contribuinteLabel.Location = New System.Drawing.Point(11, 221)
        N_contribuinteLabel.Name = "N_contribuinteLabel"
        N_contribuinteLabel.Size = New System.Drawing.Size(99, 16)
        N_contribuinteLabel.TabIndex = 74
        N_contribuinteLabel.Text = "Nº Contribuinte:"
        '
        'bt_gravar2cl
        '
        Me.bt_gravar2cl.BackColor = System.Drawing.Color.Gray
        Me.bt_gravar2cl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_gravar2cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_gravar2cl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gravar2cl.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_gravar2cl.Location = New System.Drawing.Point(12, 406)
        Me.bt_gravar2cl.Name = "bt_gravar2cl"
        Me.bt_gravar2cl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_gravar2cl.Size = New System.Drawing.Size(238, 32)
        Me.bt_gravar2cl.TabIndex = 62
        Me.bt_gravar2cl.Text = "Gravar"
        Me.bt_gravar2cl.UseVisualStyleBackColor = False
        '
        'bt_atualizarcl
        '
        Me.bt_atualizarcl.BackColor = System.Drawing.Color.Gray
        Me.bt_atualizarcl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_atualizarcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_atualizarcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_atualizarcl.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_atualizarcl.Location = New System.Drawing.Point(12, 330)
        Me.bt_atualizarcl.Name = "bt_atualizarcl"
        Me.bt_atualizarcl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_atualizarcl.Size = New System.Drawing.Size(238, 32)
        Me.bt_atualizarcl.TabIndex = 61
        Me.bt_atualizarcl.Text = "Atualizar"
        Me.bt_atualizarcl.UseVisualStyleBackColor = False
        '
        'bt_gravarcl
        '
        Me.bt_gravarcl.BackColor = System.Drawing.Color.Gray
        Me.bt_gravarcl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_gravarcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_gravarcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gravarcl.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_gravarcl.Location = New System.Drawing.Point(12, 368)
        Me.bt_gravarcl.Name = "bt_gravarcl"
        Me.bt_gravarcl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_gravarcl.Size = New System.Drawing.Size(238, 32)
        Me.bt_gravarcl.TabIndex = 60
        Me.bt_gravarcl.Text = "Gravar"
        Me.bt_gravarcl.UseVisualStyleBackColor = False
        '
        'bt_novocl
        '
        Me.bt_novocl.BackColor = System.Drawing.Color.Gray
        Me.bt_novocl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_novocl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_novocl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_novocl.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_novocl.Location = New System.Drawing.Point(12, 292)
        Me.bt_novocl.Name = "bt_novocl"
        Me.bt_novocl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_novocl.Size = New System.Drawing.Size(238, 32)
        Me.bt_novocl.TabIndex = 59
        Me.bt_novocl.Text = "Novo"
        Me.bt_novocl.UseVisualStyleBackColor = False
        '
        'bt_deletecl
        '
        Me.bt_deletecl.BackColor = System.Drawing.Color.Gray
        Me.bt_deletecl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_deletecl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_deletecl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_deletecl.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_deletecl.Location = New System.Drawing.Point(11, 254)
        Me.bt_deletecl.Name = "bt_deletecl"
        Me.bt_deletecl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_deletecl.Size = New System.Drawing.Size(238, 32)
        Me.bt_deletecl.TabIndex = 58
        Me.bt_deletecl.Text = "Delete"
        Me.bt_deletecl.UseVisualStyleBackColor = False
        '
        'bt_ultimocl
        '
        Me.bt_ultimocl.BackColor = System.Drawing.Color.Gray
        Me.bt_ultimocl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_ultimocl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ultimocl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ultimocl.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_ultimocl.Location = New System.Drawing.Point(920, 442)
        Me.bt_ultimocl.Name = "bt_ultimocl"
        Me.bt_ultimocl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_ultimocl.Size = New System.Drawing.Size(75, 32)
        Me.bt_ultimocl.TabIndex = 57
        Me.bt_ultimocl.Text = ">>"
        Me.bt_ultimocl.UseVisualStyleBackColor = False
        '
        'bt_seguintecl
        '
        Me.bt_seguintecl.BackColor = System.Drawing.Color.Gray
        Me.bt_seguintecl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_seguintecl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_seguintecl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_seguintecl.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_seguintecl.Location = New System.Drawing.Point(839, 442)
        Me.bt_seguintecl.Name = "bt_seguintecl"
        Me.bt_seguintecl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_seguintecl.Size = New System.Drawing.Size(75, 32)
        Me.bt_seguintecl.TabIndex = 56
        Me.bt_seguintecl.Text = ">"
        Me.bt_seguintecl.UseVisualStyleBackColor = False
        '
        'bt_anteriorcl
        '
        Me.bt_anteriorcl.BackColor = System.Drawing.Color.Gray
        Me.bt_anteriorcl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_anteriorcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_anteriorcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_anteriorcl.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_anteriorcl.Location = New System.Drawing.Point(354, 444)
        Me.bt_anteriorcl.Name = "bt_anteriorcl"
        Me.bt_anteriorcl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_anteriorcl.Size = New System.Drawing.Size(75, 32)
        Me.bt_anteriorcl.TabIndex = 55
        Me.bt_anteriorcl.Text = "<"
        Me.bt_anteriorcl.UseVisualStyleBackColor = False
        '
        'bt_primeirocl
        '
        Me.bt_primeirocl.BackColor = System.Drawing.Color.Gray
        Me.bt_primeirocl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_primeirocl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_primeirocl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_primeirocl.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_primeirocl.Location = New System.Drawing.Point(273, 444)
        Me.bt_primeirocl.Name = "bt_primeirocl"
        Me.bt_primeirocl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_primeirocl.Size = New System.Drawing.Size(75, 32)
        Me.bt_primeirocl.TabIndex = 54
        Me.bt_primeirocl.Text = "<<"
        Me.bt_primeirocl.UseVisualStyleBackColor = False
        '
        'l_carro
        '
        Me.l_carro.AutoSize = True
        Me.l_carro.BackColor = System.Drawing.Color.Gray
        Me.l_carro.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_carro.ForeColor = System.Drawing.SystemColors.Window
        Me.l_carro.Location = New System.Drawing.Point(6, 37)
        Me.l_carro.Name = "l_carro"
        Me.l_carro.Size = New System.Drawing.Size(101, 29)
        Me.l_carro.TabIndex = 53
        Me.l_carro.Text = "Clientes"
        '
        'BdprojetoDataSet
        '
        Me.BdprojetoDataSet.DataSetName = "bdprojetoDataSet"
        Me.BdprojetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BdprojetoDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarrosTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjetoM17A.bdprojetoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(967, 25)
        Me.ClientesBindingNavigator.TabIndex = 64
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
        Me.ClientesBindingNavigator.Visible = False
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
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(274, 12)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(719, 426)
        Me.ClientesDataGridView.TabIndex = 64
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nome_cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nome_cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cod_postal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cod_postal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nacionalidade"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nacionalidade"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "telefone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "telefone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "n_contribuinte"
        Me.DataGridViewTextBoxColumn6.HeaderText = "n_contribuinte"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Id_clienteTextBox
        '
        Me.Id_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Id_cliente", True))
        Me.Id_clienteTextBox.Location = New System.Drawing.Point(128, 89)
        Me.Id_clienteTextBox.Name = "Id_clienteTextBox"
        Me.Id_clienteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Id_clienteTextBox.TabIndex = 65
        '
        'Nome_clienteTextBox
        '
        Me.Nome_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nome_cliente", True))
        Me.Nome_clienteTextBox.Location = New System.Drawing.Point(128, 115)
        Me.Nome_clienteTextBox.Name = "Nome_clienteTextBox"
        Me.Nome_clienteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Nome_clienteTextBox.TabIndex = 67
        '
        'Cod_postalTextBox
        '
        Me.Cod_postalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cod_postal", True))
        Me.Cod_postalTextBox.Location = New System.Drawing.Point(128, 141)
        Me.Cod_postalTextBox.Name = "Cod_postalTextBox"
        Me.Cod_postalTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Cod_postalTextBox.TabIndex = 69
        '
        'NacionalidadeTextBox
        '
        Me.NacionalidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nacionalidade", True))
        Me.NacionalidadeTextBox.Location = New System.Drawing.Point(128, 167)
        Me.NacionalidadeTextBox.Name = "NacionalidadeTextBox"
        Me.NacionalidadeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NacionalidadeTextBox.TabIndex = 71
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefone", True))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(128, 193)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(121, 20)
        Me.TelefoneTextBox.TabIndex = 73
        '
        'N_contribuinteTextBox
        '
        Me.N_contribuinteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "n_contribuinte", True))
        Me.N_contribuinteTextBox.Location = New System.Drawing.Point(128, 219)
        Me.N_contribuinteTextBox.Name = "N_contribuinteTextBox"
        Me.N_contribuinteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.N_contribuinteTextBox.TabIndex = 75
        '
        'bt_tras
        '
        Me.bt_tras.BackColor = System.Drawing.Color.Gray
        Me.bt_tras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_tras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_tras.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tras.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_tras.Location = New System.Drawing.Point(1, 2)
        Me.bt_tras.Name = "bt_tras"
        Me.bt_tras.Size = New System.Drawing.Size(35, 32)
        Me.bt_tras.TabIndex = 76
        Me.bt_tras.Text = "<"
        Me.bt_tras.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gray
        Me.PictureBox2.Location = New System.Drawing.Point(-22, -82)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(289, 589)
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1007, 486)
        Me.Controls.Add(Me.bt_tras)
        Me.Controls.Add(Id_clienteLabel)
        Me.Controls.Add(Me.Id_clienteTextBox)
        Me.Controls.Add(Nome_clienteLabel)
        Me.Controls.Add(Me.Nome_clienteTextBox)
        Me.Controls.Add(Cod_postalLabel)
        Me.Controls.Add(Me.Cod_postalTextBox)
        Me.Controls.Add(NacionalidadeLabel)
        Me.Controls.Add(Me.NacionalidadeTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneTextBox)
        Me.Controls.Add(N_contribuinteLabel)
        Me.Controls.Add(Me.N_contribuinteTextBox)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Controls.Add(Me.bt_gravar2cl)
        Me.Controls.Add(Me.bt_atualizarcl)
        Me.Controls.Add(Me.bt_gravarcl)
        Me.Controls.Add(Me.bt_novocl)
        Me.Controls.Add(Me.bt_deletecl)
        Me.Controls.Add(Me.bt_ultimocl)
        Me.Controls.Add(Me.bt_seguintecl)
        Me.Controls.Add(Me.bt_anteriorcl)
        Me.Controls.Add(Me.bt_primeirocl)
        Me.Controls.Add(Me.l_carro)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.BdprojetoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_gravar2cl As Button
    Friend WithEvents bt_atualizarcl As Button
    Friend WithEvents bt_gravarcl As Button
    Friend WithEvents bt_novocl As Button
    Friend WithEvents bt_deletecl As Button
    Friend WithEvents bt_ultimocl As Button
    Friend WithEvents bt_seguintecl As Button
    Friend WithEvents bt_anteriorcl As Button
    Friend WithEvents bt_primeirocl As Button
    Friend WithEvents l_carro As Label
    Friend WithEvents BdprojetoDataSet As bdprojetoDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As bdprojetoDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As bdprojetoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As BindingNavigator
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
    Friend WithEvents ClientesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Id_clienteTextBox As TextBox
    Friend WithEvents Nome_clienteTextBox As TextBox
    Friend WithEvents Cod_postalTextBox As TextBox
    Friend WithEvents NacionalidadeTextBox As TextBox
    Friend WithEvents TelefoneTextBox As TextBox
    Friend WithEvents N_contribuinteTextBox As TextBox
    Friend WithEvents bt_tras As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
