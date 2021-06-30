Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class frm_IU_Categoria
    ' variables publicar 
    Public accion As String
    Public id As Integer
    Private Sub frm_IU_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If accion = "New" Then
            ' insertando
            Me.Text = "Nueva Categoria"

        Else
            ' editando
            Me.Text = "Editar Categoria"
            Dim dt As New DataTable
            dt = Rutinas.obtener_datos("GetCategoriaID '" & id.ToString & "'")
            If dt.Rows.Count > 0 Then
                Me.txt_Categoria.EditValue = dt.Rows(0).Item("nombre")
                Me.txt_descripcion.EditValue = dt.Rows(0).Item("descripcion")
                Me.txt_ID.EditValue = dt.Rows(0).Item("idcategoria")
                Me.chk_estado.EditValue = dt.Rows(0).Item("estado")
            End If
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If validar() Then
            If accion = "New" Then
                Dim conexion As New SqlConnection(Rutinas.CadenaConexion())
                Dim comando As New SqlCommand("Categoria_IU", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    comando.Parameters.Add("ID", SqlDbType.Int)
                    comando.Parameters("ID").Value = 0

                    comando.Parameters.Add("Categoria", SqlDbType.NVarChar)
                    comando.Parameters("Categoria").Value = Me.txt_Categoria.EditValue.ToString.Trim

                    comando.Parameters.Add("descripcion", SqlDbType.NVarChar)
                    comando.Parameters("descripcion").Value = Me.txt_descripcion.EditValue.ToString.Trim

                    comando.Parameters.Add("estado", SqlDbType.Bit)
                    comando.Parameters("estado").Value = Me.chk_estado.EditValue

                    comando.Parameters.Add("accion", SqlDbType.NVarChar)
                    comando.Parameters("accion").Value = accion

                    conexion.Open()
                    comando.ExecuteNonQuery()
                    conexion.Close()

                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else

                Dim conexion As New SqlConnection(Rutinas.CadenaConexion())
                Dim comando As New SqlCommand("Categoria_IU", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    comando.Parameters.Add("ID", SqlDbType.Int)
                    comando.Parameters("ID").Value = id

                    comando.Parameters.Add("Categoria", SqlDbType.NVarChar)
                    comando.Parameters("Categoria").Value = Me.txt_Categoria.EditValue.ToString.Trim

                    comando.Parameters.Add("descripcion", SqlDbType.NVarChar)
                    comando.Parameters("descripcion").Value = Me.txt_descripcion.EditValue.ToString.Trim

                    comando.Parameters.Add("estado", SqlDbType.Bit)
                    comando.Parameters("estado").Value = Me.chk_estado.EditValue

                    comando.Parameters.Add("accion", SqlDbType.NVarChar)
                    comando.Parameters("accion").Value = accion

                    conexion.Open()
                    comando.ExecuteNonQuery()
                    conexion.Close()

                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try



            End If
        End If
    End Sub

    Function validar()
        If String.IsNullOrWhiteSpace(Me.txt_Categoria.Text) Then
            MessageBox.Show("llenar categoria")
            Me.txt_Categoria.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(Me.txt_descripcion.Text) Then
            MessageBox.Show("llenar Descripcion")
            Me.txt_descripcion.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
End Class