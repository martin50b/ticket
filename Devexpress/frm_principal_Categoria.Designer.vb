<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal_Categoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_principal_Categoria))
        Me.BarManager1 = New Devexpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New Devexpress.XtraBars.Bar()
        Me.BarButtonItem1 = New Devexpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New Devexpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New Devexpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New Devexpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New Devexpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New Devexpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New Devexpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New Devexpress.XtraBars.BarDockControl()
        Me.grd_Categoria = New Devexpress.XtraGrid.GridControl()
        Me.GridView1 = New Devexpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New Devexpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New Devexpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New Devexpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New Devexpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New Devexpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New Devexpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New Devexpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.BarManager1.MaxItemId = 4
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = Devexpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New Devexpress.XtraBars.LinkPersistInfo() {New Devexpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New Devexpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New Devexpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New Devexpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.Bar1.Text = "Herramientas"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&Nuevo"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.PaintStyle = Devexpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "&Editar"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.PaintStyle = Devexpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "&Eliminar"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.PaintStyle = Devexpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Regresar"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.PaintStyle = Devexpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(879, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 623)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(879, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 583)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(879, 40)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 583)
        '
        'grd_Categoria
        '
        Me.grd_Categoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd_Categoria.Location = New System.Drawing.Point(0, 40)
        Me.grd_Categoria.MainView = Me.GridView1
        Me.grd_Categoria.MenuManager = Me.BarManager1
        Me.grd_Categoria.Name = "grd_Categoria"
        Me.grd_Categoria.Size = New System.Drawing.Size(879, 583)
        Me.grd_Categoria.TabIndex = 4
        Me.grd_Categoria.ViewCollection.AddRange(New Devexpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New Devexpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.grd_Categoria
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindPanelLocation = Devexpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "idcategoria"
        Me.GridColumn1.ImageOptions.Image = CType(resources.GetObject("GridColumn1.ImageOptions.Image"), System.Drawing.Image)
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New Devexpress.XtraGrid.GridSummaryItem() {New Devexpress.XtraGrid.GridColumnSummaryItem(Devexpress.Data.SummaryItemType.Count, "idcategoria", "{0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 58
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Categoria"
        Me.GridColumn2.FieldName = "nombre"
        Me.GridColumn2.ImageOptions.Image = CType(resources.GetObject("GridColumn2.ImageOptions.Image"), System.Drawing.Image)
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 264
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Descripción"
        Me.GridColumn3.FieldName = "descripcion"
        Me.GridColumn3.ImageOptions.Image = CType(resources.GetObject("GridColumn3.ImageOptions.Image"), System.Drawing.Image)
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 264
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Estado"
        Me.GridColumn4.FieldName = "estado"
        Me.GridColumn4.ImageOptions.Image = CType(resources.GetObject("GridColumn4.ImageOptions.Image"), System.Drawing.Image)
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 268
        '
        'GridColumn5
        '
        Me.GridColumn5.Name = "GridColumn5"
        '
        'frm_principal_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 623)
        Me.Controls.Add(Me.grd_Categoria)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_principal_Categoria"
        Me.Text = "Categorias"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As XtraBars.BarManager
    Friend WithEvents Bar1 As XtraBars.Bar
    Friend WithEvents BarButtonItem1 As XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As XtraBars.BarDockControl
    Friend WithEvents grd_Categoria As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As XtraGrid.Columns.GridColumn
End Class
