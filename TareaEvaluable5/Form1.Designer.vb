<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IDGeneralLabel As System.Windows.Forms.Label
        Dim IDUsuarioLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim NombreUsuarioLabel As System.Windows.Forms.Label
        Dim NombreRealLabel As System.Windows.Forms.Label
        Dim TipoUsuarioLabel As System.Windows.Forms.Label
        Dim IngresoLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataTable1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DataTable1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New TareaEvaluable5.DataSet1()
        Me.DataTable1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGeneralTextBox = New System.Windows.Forms.TextBox()
        Me.IDUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NombreRealTextBox = New System.Windows.Forms.TextBox()
        Me.TipoUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.IngresoMonthCalendar = New System.Windows.Forms.MonthCalendar()
        IDGeneralLabel = New System.Windows.Forms.Label()
        IDUsuarioLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        NombreUsuarioLabel = New System.Windows.Forms.Label()
        NombreRealLabel = New System.Windows.Forms.Label()
        TipoUsuarioLabel = New System.Windows.Forms.Label()
        IngresoLabel = New System.Windows.Forms.Label()
        CType(Me.DataTable1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataTable1BindingNavigator.SuspendLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Añadir administradores "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(399, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Agrega a otros usuarios como administradores del sitio "
        '
        'DataTable1BindingNavigator
        '
        Me.DataTable1BindingNavigator.AddNewItem = Nothing
        Me.DataTable1BindingNavigator.BindingSource = Me.DataTable1BindingSource
        Me.DataTable1BindingNavigator.CountItem = Nothing
        Me.DataTable1BindingNavigator.DeleteItem = Nothing
        Me.DataTable1BindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataTable1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DataTable1BindingNavigatorSaveItem})
        Me.DataTable1BindingNavigator.Location = New System.Drawing.Point(0, 456)
        Me.DataTable1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DataTable1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DataTable1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DataTable1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DataTable1BindingNavigator.Name = "DataTable1BindingNavigator"
        Me.DataTable1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DataTable1BindingNavigator.Size = New System.Drawing.Size(1142, 25)
        Me.DataTable1BindingNavigator.TabIndex = 19
        Me.DataTable1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'DataTable1BindingNavigatorSaveItem
        '
        Me.DataTable1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DataTable1BindingNavigatorSaveItem.Image = CType(resources.GetObject("DataTable1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DataTable1BindingNavigatorSaveItem.Name = "DataTable1BindingNavigatorSaveItem"
        Me.DataTable1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DataTable1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1DataGridView
        '
        Me.DataTable1DataGridView.AutoGenerateColumns = False
        Me.DataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DataTable1DataGridView.DataSource = Me.DataTable1BindingSource
        Me.DataTable1DataGridView.Location = New System.Drawing.Point(346, 92)
        Me.DataTable1DataGridView.Name = "DataTable1DataGridView"
        Me.DataTable1DataGridView.Size = New System.Drawing.Size(776, 263)
        Me.DataTable1DataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDGeneral"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDGeneral"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDUsuario"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDUsuario"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Contraseña"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NombreUsuario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NombreUsuario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NombreReal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NombreReal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TipoUsuario"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TipoUsuario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Ingreso"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ingreso"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'IDGeneralLabel
        '
        IDGeneralLabel.AutoSize = True
        IDGeneralLabel.Location = New System.Drawing.Point(37, 81)
        IDGeneralLabel.Name = "IDGeneralLabel"
        IDGeneralLabel.Size = New System.Drawing.Size(58, 13)
        IDGeneralLabel.TabIndex = 19
        IDGeneralLabel.Text = "IDGeneral:"
        '
        'IDGeneralTextBox
        '
        Me.IDGeneralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "IDGeneral", True))
        Me.IDGeneralTextBox.Location = New System.Drawing.Point(129, 78)
        Me.IDGeneralTextBox.Name = "IDGeneralTextBox"
        Me.IDGeneralTextBox.Size = New System.Drawing.Size(178, 20)
        Me.IDGeneralTextBox.TabIndex = 20
        '
        'IDUsuarioLabel
        '
        IDUsuarioLabel.AutoSize = True
        IDUsuarioLabel.Location = New System.Drawing.Point(37, 107)
        IDUsuarioLabel.Name = "IDUsuarioLabel"
        IDUsuarioLabel.Size = New System.Drawing.Size(57, 13)
        IDUsuarioLabel.TabIndex = 21
        IDUsuarioLabel.Text = "IDUsuario:"
        '
        'IDUsuarioTextBox
        '
        Me.IDUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "IDUsuario", True))
        Me.IDUsuarioTextBox.Location = New System.Drawing.Point(129, 104)
        Me.IDUsuarioTextBox.Name = "IDUsuarioTextBox"
        Me.IDUsuarioTextBox.Size = New System.Drawing.Size(178, 20)
        Me.IDUsuarioTextBox.TabIndex = 22
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(37, 133)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(64, 13)
        ContraseñaLabel.TabIndex = 23
        ContraseñaLabel.Text = "Contraseña:"
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Contraseña", True))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(129, 130)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(178, 20)
        Me.ContraseñaTextBox.TabIndex = 24
        '
        'NombreUsuarioLabel
        '
        NombreUsuarioLabel.AutoSize = True
        NombreUsuarioLabel.Location = New System.Drawing.Point(37, 159)
        NombreUsuarioLabel.Name = "NombreUsuarioLabel"
        NombreUsuarioLabel.Size = New System.Drawing.Size(86, 13)
        NombreUsuarioLabel.TabIndex = 25
        NombreUsuarioLabel.Text = "Nombre Usuario:"
        '
        'NombreUsuarioTextBox
        '
        Me.NombreUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "NombreUsuario", True))
        Me.NombreUsuarioTextBox.Location = New System.Drawing.Point(129, 156)
        Me.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox"
        Me.NombreUsuarioTextBox.Size = New System.Drawing.Size(178, 20)
        Me.NombreUsuarioTextBox.TabIndex = 26
        '
        'NombreRealLabel
        '
        NombreRealLabel.AutoSize = True
        NombreRealLabel.Location = New System.Drawing.Point(37, 185)
        NombreRealLabel.Name = "NombreRealLabel"
        NombreRealLabel.Size = New System.Drawing.Size(72, 13)
        NombreRealLabel.TabIndex = 27
        NombreRealLabel.Text = "Nombre Real:"
        '
        'NombreRealTextBox
        '
        Me.NombreRealTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "NombreReal", True))
        Me.NombreRealTextBox.Location = New System.Drawing.Point(129, 182)
        Me.NombreRealTextBox.Name = "NombreRealTextBox"
        Me.NombreRealTextBox.Size = New System.Drawing.Size(178, 20)
        Me.NombreRealTextBox.TabIndex = 28
        '
        'TipoUsuarioLabel
        '
        TipoUsuarioLabel.AutoSize = True
        TipoUsuarioLabel.Location = New System.Drawing.Point(37, 211)
        TipoUsuarioLabel.Name = "TipoUsuarioLabel"
        TipoUsuarioLabel.Size = New System.Drawing.Size(70, 13)
        TipoUsuarioLabel.TabIndex = 29
        TipoUsuarioLabel.Text = "Tipo Usuario:"
        '
        'TipoUsuarioTextBox
        '
        Me.TipoUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "TipoUsuario", True))
        Me.TipoUsuarioTextBox.Location = New System.Drawing.Point(129, 208)
        Me.TipoUsuarioTextBox.Name = "TipoUsuarioTextBox"
        Me.TipoUsuarioTextBox.Size = New System.Drawing.Size(178, 20)
        Me.TipoUsuarioTextBox.TabIndex = 30
        '
        'IngresoLabel
        '
        IngresoLabel.AutoSize = True
        IngresoLabel.Location = New System.Drawing.Point(37, 240)
        IngresoLabel.Name = "IngresoLabel"
        IngresoLabel.Size = New System.Drawing.Size(45, 13)
        IngresoLabel.TabIndex = 31
        IngresoLabel.Text = "Ingreso:"
        '
        'IngresoMonthCalendar
        '
        Me.IngresoMonthCalendar.DataBindings.Add(New System.Windows.Forms.Binding("SelectionRange", Me.DataTable1BindingSource, "Ingreso", True))
        Me.IngresoMonthCalendar.Location = New System.Drawing.Point(129, 240)
        Me.IngresoMonthCalendar.Name = "IngresoMonthCalendar"
        Me.IngresoMonthCalendar.TabIndex = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 481)
        Me.Controls.Add(IDGeneralLabel)
        Me.Controls.Add(Me.IDGeneralTextBox)
        Me.Controls.Add(IDUsuarioLabel)
        Me.Controls.Add(Me.IDUsuarioTextBox)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(NombreUsuarioLabel)
        Me.Controls.Add(Me.NombreUsuarioTextBox)
        Me.Controls.Add(NombreRealLabel)
        Me.Controls.Add(Me.NombreRealTextBox)
        Me.Controls.Add(TipoUsuarioLabel)
        Me.Controls.Add(Me.TipoUsuarioTextBox)
        Me.Controls.Add(IngresoLabel)
        Me.Controls.Add(Me.IngresoMonthCalendar)
        Me.Controls.Add(Me.DataTable1DataGridView)
        Me.Controls.Add(Me.DataTable1BindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataTable1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataTable1BindingNavigator.ResumeLayout(False)
        Me.DataTable1BindingNavigator.PerformLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1BindingNavigator As BindingNavigator
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
    Friend WithEvents DataTable1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataTable1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IDGeneralTextBox As TextBox
    Friend WithEvents IDUsuarioTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents NombreUsuarioTextBox As TextBox
    Friend WithEvents NombreRealTextBox As TextBox
    Friend WithEvents TipoUsuarioTextBox As TextBox
    Friend WithEvents IngresoMonthCalendar As MonthCalendar
End Class
