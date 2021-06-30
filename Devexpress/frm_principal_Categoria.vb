Imports System.Data.SqlClient

Public Class frm_principal_Categoria
    Private Sub frm_principal_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Sub cargar()
        Me.grd_Categoria.DataSource = Rutinas.obtener_datos("GetCategoria")
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        My.Forms.frm_IU_Categoria.Dispose()
        My.Forms.frm_IU_Categoria.accion = "New"
        My.Forms.frm_IU_Categoria.StartPosition = FormStartPosition.CenterScreen
        My.Forms.frm_IU_Categoria.ShowDialog() ' fornulario para ser mostrado en primer plano
        cargar()

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        My.Forms.frm_IU_Categoria.Dispose()
        My.Forms.frm_IU_Categoria.id = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "idcategoria")
        My.Forms.frm_IU_Categoria.accion = "Edit"
        My.Forms.frm_IU_Categoria.StartPosition = FormStartPosition.CenterScreen
        My.Forms.frm_IU_Categoria.ShowDialog()
        cargar()

    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If MessageBox.Show(" Desea Eliminar " & Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "nombre"), "Aviso Importe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim conexion As New SqlConnection(Rutinas.CadenaConexion())
        Dim comando As New SqlCommand("Categoria_IU", conexion)
        comando.CommandType = CommandType.StoredProcedure
        Try
            comando.Parameters.Add("ID", SqlDbType.Int)
            comando.Parameters("ID").Value = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "idcategoria")

            comando.Parameters.Add("Categoria", SqlDbType.NVarChar)
            comando.Parameters("Categoria").Value = String.Empty

            comando.Parameters.Add("descripcion", SqlDbType.NVarChar)
            comando.Parameters("descripcion").Value = String.Empty

            comando.Parameters.Add("estado", SqlDbType.Bit)
            comando.Parameters("estado").Value = 0

            comando.Parameters.Add("accion", SqlDbType.NVarChar)
            comando.Parameters("accion").Value = "Del"

            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()

            cargar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class