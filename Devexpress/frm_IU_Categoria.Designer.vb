<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_IU_Categoria
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
        Me.BarManager1 = New Devexpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New Devexpress.XtraBars.Bar()
        Me.BarButtonItem1 = New Devexpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New Devexpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New Devexpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New Devexpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New Devexpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New Devexpress.XtraBars.BarDockControl()
        Me.txt_Categoria = New Devexpress.XtraEditors.TextEdit()
        Me.txt_descripcion = New Devexpress.XtraEditors.TextEdit()
        Me.txt_ID = New Devexpress.XtraEditors.TextEdit()
        Me.chk_estado = New Devexpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New Devexpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New Devexpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New Devexpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Categoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_estado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New Devexpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 2
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = Devexpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New Devexpress.XtraBars.LinkPersistInfo() {New Devexpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New Devexpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.Bar1.Text = "Herramientas"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Guardar"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "regresar"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(529, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 389)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(529, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 369)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(529, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 369)
        '
        'txt_Categoria
        '
        Me.txt_Categoria.Location = New System.Drawing.Point(97, 128)
        Me.txt_Categoria.MenuManager = Me.BarManager1
        Me.txt_Categoria.Name = "txt_Categoria"
        Me.txt_Categoria.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Categoria.Properties.Appearance.Options.UseFont = True
        Me.txt_Categoria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Categoria.Properties.MaxLength = 50
        Me.txt_Categoria.Size = New System.Drawing.Size(361, 22)
        Me.txt_Categoria.TabIndex = 4
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(97, 165)
        Me.txt_descripcion.MenuManager = Me.BarManager1
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion.Properties.Appearance.Options.UseFont = True
        Me.txt_descripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_descripcion.Properties.MaxLength = 50
        Me.txt_descripcion.Size = New System.Drawing.Size(361, 22)
        Me.txt_descripcion.TabIndex = 5
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(97, 94)
        Me.txt_ID.MenuManager = Me.BarManager1
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Properties.Appearance.Options.UseFont = True
        Me.txt_ID.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_ID.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txt_ID.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_ID.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txt_ID.Properties.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(95, 22)
        Me.txt_ID.TabIndex = 6
        '
        'chk_estado
        '
        Me.chk_estado.Location = New System.Drawing.Point(97, 208)
        Me.chk_estado.MenuManager = Me.BarManager1
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_estado.Properties.Appearance.Options.UseFont = True
        Me.chk_estado.Properties.Caption = "Estado"
        Me.chk_estado.Size = New System.Drawing.Size(336, 20)
        Me.chk_estado.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(68, 99)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "ID"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 133)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Categoria"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(25, 170)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Descripcion"
        '
        'frm_IU_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 389)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.chk_estado)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_Categoria)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_IU_Categoria"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Categoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_estado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As XtraBars.BarManager
    Friend WithEvents Bar1 As XtraBars.Bar
    Friend WithEvents BarButtonItem1 As XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As XtraBars.BarDockControl
    Friend WithEvents chk_estado As XtraEditors.CheckEdit
    Friend WithEvents txt_ID As XtraEditors.TextEdit
    Friend WithEvents txt_descripcion As XtraEditors.TextEdit
    Friend WithEvents txt_Categoria As XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As XtraEditors.LabelControl
End Class
