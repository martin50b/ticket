<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_print
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As Devexpress.XtraGrid.GridLevelNode = New Devexpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule1 As Devexpress.XtraGrid.GridFormatRule = New Devexpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As Devexpress.XtraEditors.FormatConditionRuleValue = New Devexpress.XtraEditors.FormatConditionRuleValue()
        Dim TableColumnDefinition1 As Devexpress.XtraEditors.TableLayout.TableColumnDefinition = New Devexpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableRowDefinition1 As Devexpress.XtraEditors.TableLayout.TableRowDefinition = New Devexpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition2 As Devexpress.XtraEditors.TableLayout.TableRowDefinition = New Devexpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition3 As Devexpress.XtraEditors.TableLayout.TableRowDefinition = New Devexpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition4 As Devexpress.XtraEditors.TableLayout.TableRowDefinition = New Devexpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TileViewItemElement1 As Devexpress.XtraGrid.Views.Tile.TileViewItemElement = New Devexpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As Devexpress.XtraGrid.Views.Tile.TileViewItemElement = New Devexpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As Devexpress.XtraGrid.Views.Tile.TileViewItemElement = New Devexpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As Devexpress.XtraGrid.Views.Tile.TileViewItemElement = New Devexpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.Estado = New Devexpress.XtraGrid.Columns.TileViewColumn()
        Me.Fecha = New Devexpress.XtraGrid.Columns.TileViewColumn()
        Me.Clientes = New Devexpress.XtraGrid.Columns.TileViewColumn()
        Me.Comentarios = New Devexpress.XtraGrid.Columns.TileViewColumn()
        Me.BarManager1 = New Devexpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New Devexpress.XtraBars.Bar()
        Me.BarButtonItem1 = New Devexpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New Devexpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New Devexpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New Devexpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New Devexpress.XtraBars.BarDockControl()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.grd_Cliente = New Devexpress.XtraGrid.GridControl()
        Me.TileView1 = New Devexpress.XtraGrid.Views.Tile.TileView()
        Me.StatusID = New Devexpress.XtraGrid.Columns.TileViewColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Estado
        '
        Me.Estado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estado.AppearanceCell.Options.UseFont = True
        Me.Estado.Caption = "Estatus"
        Me.Estado.FieldName = "status"
        Me.Estado.Name = "Estado"
        Me.Estado.Visible = True
        Me.Estado.VisibleIndex = 2
        Me.Estado.Width = 452
        '
        'Fecha
        '
        Me.Fecha.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.AppearanceCell.Options.UseFont = True
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "fecha_pedido"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Visible = True
        Me.Fecha.VisibleIndex = 0
        Me.Fecha.Width = 202
        '
        'Clientes
        '
        Me.Clientes.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clientes.AppearanceCell.Options.UseFont = True
        Me.Clientes.Caption = "Cliente"
        Me.Clientes.FieldName = "clientes"
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Visible = True
        Me.Clientes.VisibleIndex = 1
        Me.Clientes.Width = 288
        '
        'Comentarios
        '
        Me.Comentarios.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comentarios.AppearanceCell.Options.UseFont = True
        Me.Comentarios.Caption = "Comentario"
        Me.Comentarios.FieldName = "comentarios"
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Visible = True
        Me.Comentarios.VisibleIndex = 3
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New Devexpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New Devexpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 1
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = Devexpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New Devexpress.XtraBars.LinkPersistInfo() {New Devexpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar1.Text = "Herramientas"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1158, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 668)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1158, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 648)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1158, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 648)
        '
        'Tiempo
        '
        Me.Tiempo.Interval = 5000
        '
        'grd_Cliente
        '
        Me.grd_Cliente.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.grd_Cliente.LevelTree.Nodes.AddRange(New Devexpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grd_Cliente.Location = New System.Drawing.Point(0, 20)
        Me.grd_Cliente.MainView = Me.TileView1
        Me.grd_Cliente.MenuManager = Me.BarManager1
        Me.grd_Cliente.Name = "grd_Cliente"
        Me.grd_Cliente.Size = New System.Drawing.Size(1158, 648)
        Me.grd_Cliente.TabIndex = 9
        Me.grd_Cliente.ViewCollection.AddRange(New Devexpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
        '
        'TileView1
        '
        Me.TileView1.Columns.AddRange(New Devexpress.XtraGrid.Columns.GridColumn() {Me.Fecha, Me.Clientes, Me.Estado, Me.Comentarios, Me.StatusID})
        Me.TileView1.ColumnSet.GroupColumn = Me.Estado
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.Estado
        GridFormatRule1.Name = "Impreso"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.DarkCyan
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = Devexpress.XtraEditors.FormatCondition.NotEqual
        FormatConditionRuleValue1.Value1 = "Impreso"
        FormatConditionRuleValue1.Value2 = "Impreso"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.TileView1.FormatRules.Add(GridFormatRule1)
        Me.TileView1.GridControl = Me.grd_Cliente
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsBehavior.ReadOnly = True
        Me.TileView1.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(0, -1, -1, -1)
        Me.TileView1.OptionsTiles.ItemSize = New System.Drawing.Size(260, 164)
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsTiles.RowCount = 0
        Me.TileView1.SortInfo.AddRange(New Devexpress.XtraGrid.Columns.GridColumnSortInfo() {New Devexpress.XtraGrid.Columns.GridColumnSortInfo(Me.Estado, Devexpress.Data.ColumnSortOrder.Ascending)})
        TableColumnDefinition1.Length.Value = 64.0R
        Me.TileView1.TileColumns.Add(TableColumnDefinition1)
        Me.TileView1.TileRows.Add(TableRowDefinition1)
        Me.TileView1.TileRows.Add(TableRowDefinition2)
        Me.TileView1.TileRows.Add(TableRowDefinition3)
        Me.TileView1.TileRows.Add(TableRowDefinition4)
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement1.Appearance.Normal.Options.UseFont = True
        TileViewItemElement1.Column = Me.Fecha
        TileViewItemElement1.ImageOptions.ImageAlignment = Devexpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement1.ImageOptions.ImageScaleMode = Devexpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement1.Text = "Fecha"
        TileViewItemElement1.TextAlignment = Devexpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Column = Me.Clientes
        TileViewItemElement2.ImageOptions.ImageAlignment = Devexpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.ImageOptions.ImageScaleMode = Devexpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement2.RowIndex = 1
        TileViewItemElement2.Text = "Clientes"
        TileViewItemElement2.TextAlignment = Devexpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement3.Appearance.Normal.BackColor = System.Drawing.Color.Teal
        TileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement3.Appearance.Normal.Options.UseBackColor = True
        TileViewItemElement3.Appearance.Normal.Options.UseFont = True
        TileViewItemElement3.Column = Me.Estado
        TileViewItemElement3.ImageOptions.ImageAlignment = Devexpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement3.ImageOptions.ImageScaleMode = Devexpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement3.RowIndex = 3
        TileViewItemElement3.Text = "Estado"
        TileViewItemElement3.TextAlignment = Devexpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement4.Appearance.Normal.Options.UseFont = True
        TileViewItemElement4.Column = Me.Comentarios
        TileViewItemElement4.ImageOptions.ImageAlignment = Devexpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement4.ImageOptions.ImageScaleMode = Devexpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement4.RowIndex = 2
        TileViewItemElement4.Text = "Comentarios"
        TileViewItemElement4.TextAlignment = Devexpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.TileView1.TileTemplate.Add(TileViewItemElement1)
        Me.TileView1.TileTemplate.Add(TileViewItemElement2)
        Me.TileView1.TileTemplate.Add(TileViewItemElement3)
        Me.TileView1.TileTemplate.Add(TileViewItemElement4)
        '
        'StatusID
        '
        Me.StatusID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusID.AppearanceCell.Options.UseFont = True
        Me.StatusID.Caption = "id_status"
        Me.StatusID.FieldName = "id_status"
        Me.StatusID.Name = "StatusID"
        Me.StatusID.Visible = True
        Me.StatusID.VisibleIndex = 4
        '
        'frm_print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 668)
        Me.Controls.Add(Me.grd_Cliente)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_print"
        Me.Text = "Impresión Tickets"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As XtraBars.BarManager
    Friend WithEvents Bar1 As XtraBars.Bar
    Friend WithEvents barDockControlTop As XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As XtraBars.BarButtonItem
    Public WithEvents Tiempo As Timer
    Friend WithEvents grd_Cliente As XtraGrid.GridControl
    Friend WithEvents TileView1 As XtraGrid.Views.Tile.TileView
    Friend WithEvents Fecha As XtraGrid.Columns.TileViewColumn
    Friend WithEvents Clientes As XtraGrid.Columns.TileViewColumn
    Friend WithEvents Estado As XtraGrid.Columns.TileViewColumn
    Friend WithEvents Comentarios As XtraGrid.Columns.TileViewColumn
    Friend WithEvents StatusID As XtraGrid.Columns.TileViewColumn
End Class
