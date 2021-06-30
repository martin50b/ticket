<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal_Mdi
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal_Mdi))
        Me.RibbonControl = New Devexpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New Devexpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New Devexpress.XtraBars.BarButtonItem()
        Me.btn_Categoria = New Devexpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New Devexpress.XtraBars.BarButtonItem()
        Me.Btn_imprimir = New Devexpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New Devexpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New Devexpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New Devexpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New Devexpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New Devexpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGrupoImpresion = New Devexpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New Devexpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New Devexpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New Devexpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager1 = New Devexpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New Devexpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.btn_Categoria, Me.BarButtonItem3, Me.Btn_imprimir})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New Devexpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4})
        Me.RibbonControl.Size = New System.Drawing.Size(887, 161)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'btn_Categoria
        '
        Me.btn_Categoria.Caption = "Categoria"
        Me.btn_Categoria.Id = 3
        Me.btn_Categoria.ImageOptions.Image = CType(resources.GetObject("btn_Categoria.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Categoria.ImageOptions.LargeImage = CType(resources.GetObject("btn_Categoria.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Categoria.Name = "btn_Categoria"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Articulo"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'Btn_imprimir
        '
        Me.Btn_imprimir.Caption = "Iniciar impresión"
        Me.Btn_imprimir.Id = 5
        Me.Btn_imprimir.ImageOptions.Image = CType(resources.GetObject("Btn_imprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_imprimir.ImageOptions.LargeImage = CType(resources.GetObject("Btn_imprimir.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_imprimir.Name = "Btn_imprimir"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New Devexpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.ImageOptions.Image = CType(resources.GetObject("RibbonPage1.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Configurar"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New Devexpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage2.ImageOptions.Image = CType(resources.GetObject("RibbonPage2.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Catalogo"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_Categoria)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Catalogo"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New Devexpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGrupoImpresion})
        Me.RibbonPage3.ImageOptions.Image = CType(resources.GetObject("RibbonPage3.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Impresión Tickets"
        '
        'RibbonPageGrupoImpresion
        '
        Me.RibbonPageGrupoImpresion.CaptionButtonVisible = Devexpress.Utils.DefaultBoolean.[True]
        Me.RibbonPageGrupoImpresion.ItemLinks.Add(Me.Btn_imprimir)
        Me.RibbonPageGrupoImpresion.Name = "RibbonPageGrupoImpresion"
        Me.RibbonPageGrupoImpresion.Text = "RibbonPageGroup3"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New Devexpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "RibbonPage4"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "RibbonPageGroup4"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 816)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(887, 24)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'Principal_Mdi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 840)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "Principal_Mdi"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButtonItem1 As XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As XtraBars.BarButtonItem
    Friend WithEvents btn_Categoria As XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage3 As XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGrupoImpresion As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage4 As XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraTabbedMdiManager1 As XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents BarButtonItem3 As XtraBars.BarButtonItem
    Friend WithEvents Btn_imprimir As XtraBars.BarButtonItem
End Class
