Imports MySql.Data.MySqlClient
Public Class Cliente

    Public Shared Function GetVentaClientePrint() As DataTable
        Dim dt As New DataTable

        Dim string_comand = "SELECT			
						v_c.id_venta,
						v_c.id_cliente,
						c.cliente,
						v_c.id_status,
						v_c.consec
					FROM
						ventas_cliente v_c 
					LEFT JOIN clientes c ON v_c.id_cliente = c.id_cliente
					WHERE
						v_c.id_status = '10'limit 1"


        Try
            Dim conexion As New MySqlConnection(Rutinas.CadenaConexionMySQL())
            Dim cmd As New MySqlDataAdapter(string_comand, conexion)
            cmd.SelectCommand.CommandType = CommandType.Text
            cmd.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Function GetPedidosCliente() As DataTable
        Dim dt As New DataTable

        Try
            Dim conexion As New MySqlConnection(Rutinas.CadenaConexionMySQL())
            Dim cmd As New MySqlDataAdapter("GetPedidosCliente", conexion)
            cmd.SelectCommand.CommandType = CommandType.StoredProcedure
            cmd.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
    End Function
    Public Shared Function GetVentaClienteProductosPrint(VentaID As Integer) As DataTable
        Dim dt As New DataTable

        Dim string_comand = "SELECT v_p.*, cli.cliente as cliente ,v.vendedor as vendedor, p.producto,e.empaque,t.termino,v_c.comentarios,v_c.consec,v_c.fecha_pedido	fecha
						FROM ventas_producto v_p
						LEFT JOIN ventas_cliente v_c ON v_p.id_venta=v_c.id_venta
						LEFT JOIN clientes cli on v_c.id_cliente=cli.id_cliente
						LEFT JOIN vendedores v on v_c.id_vend=v.id_vend
						LEFT JOIN productos p ON v_p.id_producto=p.id_producto
						LEFT JOIN empaque e on v_p.id_empaque=e.id_empaque
						LEFT JOIN termino t on v_p.id_termino=t.id_termino
						WHERE v_p.id_venta= '" & VentaID.ToString & "' ORDER BY  p.id_categoria"



        Try
            Dim conexion As New MySqlConnection(Rutinas.CadenaConexionMySQL())
            Dim cmd As New MySqlDataAdapter(string_comand, conexion)
            cmd.SelectCommand.CommandType = CommandType.Text
            cmd.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Function UpdateVentaClienteProductosPrint(VentaID As Int32, Id_status As Int32)
        Dim dt As New DataTable

        Dim strin_comand = " Update ventas_cliente set id_status=" & Id_status & " where id_venta=" & VentaID


        Try
            Dim conexion As New MySqlConnection(Rutinas.CadenaConexionMySQL())
            Dim cmd As New MySqlDataAdapter(strin_comand, conexion)
            cmd.SelectCommand.CommandType = CommandType.Text

            'cmd.SelectCommand.Parameters.Add("Id_status", MySqlDbType.Int32)
            'cmd.SelectCommand.Parameters("Id_status").Value = Id_status

            'cmd.SelectCommand.Parameters.Add("id_venta", MySqlDbType.Int32)
            'cmd.SelectCommand.Parameters("id_venta").Value = VentaID

            conexion.Open()
            cmd.SelectCommand.ExecuteNonQuery()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
    End Function

End Class
