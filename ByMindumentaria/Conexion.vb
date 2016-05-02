Imports System.Data
Imports System.Data.SqlClient
Public Class Conexion
    Private Ruta As String
    Private Conexion As SqlConnection

    Public Property RutaP() As String
        Get
            Return Ruta
        End Get
        Set(ByVal value As String)
            Ruta = value
        End Set
    End Property
    Public Property ConexionP() As SqlConnection
        Get
            Return Conexion
        End Get
        Set(ByVal value As SqlConnection)
            Conexion = value
        End Set
    End Property

    Public Sub Abrir()
        Ruta = "Server=CI7427EA91CFC8\SQLEXPRESS;Database=bymindumentaria;Trusted_Connection=True;"
        Conexion = New SqlConnection(Ruta)
        Conexion.Open()
    End Sub
    Public Sub Cerrar()
        Conexion.Close()
    End Sub



End Class
