Imports MySql.Data.MySqlClient

Public Class frm_print
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim conexion As New MySqlConnection(Rutinas.CadenaConexionMySQL())
        Dim comando As New MySqlDataAdapter("select * from clientes", conexion)
        Dim dt As New DataTable
        Try
            comando.Fill(dt)
            Me.grd_Cliente.DataSource = dt

            MessageBox.Show("OK")
        Catch ex As Exception
            MessageBox.Show("fallida")
        End Try

    End Sub

    Private Sub frm_print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.grd_Cliente.DataSource = Cliente.GetPedidosCliente()

        Me.Tiempo.Enabled = True
        Me.Tiempo.Interval = 5000
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick

        Me.grd_Cliente.DataSource = Cliente.GetPedidosCliente()


        Dim dt As New DataTable
        Dim VentaID As String
        dt = Cliente.GetVentaClientePrint()
        If dt.Rows.Count() > 0 Then

            Try

                VentaID = dt.Rows(0).Item("id_venta")
                Dim DT_datos As DataTable = Cliente.GetVentaClienteProductosPrint(VentaID)
                If DT_datos.Rows.Count() > 0 Then

                    Dim Ds As New DataSet
                    Ds.Tables.Add(DT_datos)

                    Ds.Tables(0).TableName = "VentaClienteProductos"

                    Ds.WriteXml(Application.StartupPath & "\xml\rpt_VentaClienteProductos.xml", XmlWriteMode.WriteSchema)


                    Dim rpt As New Ticket_VentaClienteProductos
                    Dim f As New mdi_reporte

                    f.Text = DT_datos.Rows(0).Item("cliente").ToString

                    f.PrintControl1.PrintingSystem = rpt.PrintingSystem
                    rpt.DataSource = Ds
                    rpt.XmlDataPath = Application.StartupPath & "\xml\rpt_VentaClienteProductos.xml"
                    rpt.CreateDocument()

                    f.MdiParent = Me.MdiParent
                    f.Show()

                    'rpt.Print()

                    f.WindowState = FormWindowState.Maximized
                    f = Nothing
                    rpt = Nothing

                    Cliente.UpdateVentaClienteProductosPrint(VentaID, 15)
                Else
                    Cliente.UpdateVentaClienteProductosPrint(VentaID, 5)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try



        End If
    End Sub

    Private Sub grd_Cliente_Click(sender As Object, e As EventArgs) Handles grd_Cliente.Click

    End Sub
End Class