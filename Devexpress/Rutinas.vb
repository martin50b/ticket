Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.DBNull
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class Rutinas
    Shared Function CadenaConexion() As String

        Dim conexion As String
        Dim ConnectionFile As StreamReader

        If Not File.Exists(Application.StartupPath & "\Configurar.ini") Then
            MessageBox.Show("Error, No se encuentra el Archivo de Configuración del S.G.C : Configurar.ini", "Aviso Importante, Configurar.ini Is Null", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MessageBox.Show("Pongase en Contacto con el Administrador del S.G.C", "Aviso Importante...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return "Nothing"
            Exit Function
        End If

        ConnectionFile = New StreamReader(Application.StartupPath & "\Configurar.ini")

        'Leer Lineas del Archivo Configurar
        Dim Pass As String
        Dim SERVERDB As String
        Dim CATALOG As String

        SERVERDB = ConnectionFile.ReadLine.ToString()
        CATALOG = ConnectionFile.ReadLine.ToString()


        conexion = "Data Source=" & SERVERDB & ";Initial Catalog=" & CATALOG & ";Persist Security Info=True;User ID=sa;Password=MSotoV19#"


        Return conexion

    End Function

    Shared Function obtener_datos(ByVal consulta_sql As String) As DataTable

        Dim DA As New SqlDataAdapter(consulta_sql, Rutinas.CadenaConexion())
        Dim DS As New DataTable
        DA.SelectCommand.CommandTimeout = 0
        DA.Fill(DS)
        Return DS

    End Function

    Shared Function CadenaConexionMySQL() As String

        Dim conexion As String
        Dim ConnectionFile As StreamReader

        If Not File.Exists(Application.StartupPath & "\Configurar.ini") Then
            MessageBox.Show("Error, No se encuentra el Archivo de Configuración del S.G.C : Configurar.ini", "Aviso Importante, Configurar.ini Is Null", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MessageBox.Show("Pongase en Contacto con el Administrador del S.G.C", "Aviso Importante...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return "Nothing"
            Exit Function
        End If

        ConnectionFile = New StreamReader(Application.StartupPath & "\Configurar.ini")

        conexion = "Server = 70.35.194.145;Database=ticket; Uid=ticket;Pwd=venta;"

        Return conexion

    End Function
End Class
