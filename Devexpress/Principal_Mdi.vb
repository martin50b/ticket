Public Class Principal_Mdi
    Private Sub btn_Categoria_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles btn_Categoria.ItemClick
        My.Forms.frm_principal_Categoria.MdiParent = Me
        My.Forms.frm_principal_Categoria.Show()
        My.Forms.frm_principal_Categoria.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        My.Forms.frm_articulo.MdiParent = Me
        My.Forms.frm_articulo.Show()
        My.Forms.frm_articulo.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles Btn_imprimir.ItemClick
        My.Forms.frm_print.MdiParent = Me
        My.Forms.frm_print.Show()
        My.Forms.frm_print.WindowState = FormWindowState.Maximized
    End Sub


End Class