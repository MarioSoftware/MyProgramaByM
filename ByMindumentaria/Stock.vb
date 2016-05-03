﻿Imports System.Data
Imports System.Data.SqlClient

Public Class Stock

    Inherits Conexion
    Private IdStock As Integer
    Private IdProveedor As Integer
    Private Articulo As Integer
    Private Seccion As Integer
    Private Talle_Medida As String
    Private Cantidad As Integer
    Private PrecioUnitario As Decimal
    Private Imagen As PictureBox
    Private Minimo As Integer
    Private aPedir As Integer

    Public Property IdStockP() As Integer
        Get
            Return IdStock

        End Get
        Set(ByVal value As Integer)

            IdStock = value

        End Set
    End Property

    Public Property IdProveedorP() As Integer
        Get
            Return IdProveedor

        End Get
        Set(ByVal value As Integer)
            IdProveedor = value

        End Set
    End Property

    Public Property ArticuloP() As Integer
        Get
            Return Articulo

        End Get
        Set(ByVal value As Integer)
            Articulo = value

        End Set
    End Property

    Public Property SeccionP() As Integer
        Get
            Return Seccion

        End Get
        Set(ByVal value As Integer)
            Seccion = value

        End Set
    End Property

    Public Property Talle_MedidaP() As String
        Get
            Return Talle_Medida

        End Get
        Set(ByVal value As String)
            Talle_Medida = value

        End Set
    End Property

    Public Property CatidadP() As Integer
        Get
            Return Cantidad

        End Get
        Set(ByVal value As Integer)
            Cantidad = value

        End Set
    End Property

    Public Property PrecioUnitarioP() As Decimal
        Get
            Return PrecioUnitario

        End Get
        Set(ByVal value As Decimal)
            PrecioUnitario = value

        End Set
    End Property

    Public Property ImagenP() As PictureBox
        Get
            Return Imagen
        End Get
        Set(ByVal value As PictureBox)
            Imagen = value

        End Set
    End Property

    Public Property MinimoP() As Integer
        Get
            Return Minimo

        End Get
        Set(ByVal value As Integer)
            Minimo = value

        End Set
    End Property

    Public Property aPedirP() As Integer
        Get
            Return aPedir

        End Get
        Set(ByVal value As Integer)
            aPedir = value

        End Set
    End Property

    Public Sub Consultar(ByVal Tabla As DataGridView)
        Abrir()
        Dim sentencia As String = "Select * from Stock"
        Dim Comando As New SqlCommand(sentencia, ConexionP)

        Dim DataAdatper As New SqlDataAdapter(Comando)
        Dim DataTable As New DataTable
        DataAdatper.Fill(DataTable)
        Tabla.DataSource = DataTable
        Cerrar()

    End Sub

    Public Sub Insertar(ByVal Stock As Stock)
        Abrir()

        Dim Comando As New SqlCommand("InsertarStock", ConexionP)
        Comando.CommandType = CommandType.StoredProcedure


        Comando.Parameters.AddWithValue("IdProveedor", Stock.IdProveedorP)
        Comando.Parameters.AddWithValue("Articulo", Stock.ArticuloP)
        Comando.Parameters.AddWithValue("Seccion", Stock.SeccionP)
        Comando.Parameters.AddWithValue("Talle_Medida", Stock.Talle_MedidaP)
        Comando.Parameters.AddWithValue("Cantidad", Stock.CatidadP)
        Comando.Parameters.AddWithValue("PrecioUnitario", Stock.PrecioUnitarioP)
        'Comando.Parameters.AddWithValue("Imagen", Stock.ImagenP)
        Comando.Parameters.AddWithValue("Minimo", Stock.MinimoP)
        Comando.Parameters.AddWithValue("aPedir", Stock.aPedirP)

        Comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Modificar(ByVal Stock As Stock)
        Abrir()

        Dim Comando As New SqlCommand("ModificarStock", ConexionP)
        Comando.CommandType = CommandType.StoredProcedure

        Comando.Parameters.AddWithValue("IdStock", Stock.IdStockP)
        Comando.Parameters.AddWithValue("IdProveedor", Stock.IdProveedorP)
        Comando.Parameters.AddWithValue("Articulo", Stock.ArticuloP)
        Comando.Parameters.AddWithValue("Seccion", Stock.SeccionP)
        Comando.Parameters.AddWithValue("Talle_Medida", Stock.Talle_MedidaP)
        Comando.Parameters.AddWithValue("Cantidad", Stock.CatidadP)
        Comando.Parameters.AddWithValue("PrecioUnitario", Stock.PrecioUnitarioP)
        'Comando.Parameters.AddWithValue("Imagen", Stock.ImagenP)
        Comando.Parameters.AddWithValue("Minimo", Stock.MinimoP)
        Comando.Parameters.AddWithValue("aPedir", Stock.aPedirP)

        Comando.ExecuteNonQuery()
        Cerrar()

    End Sub

    Public Sub Eliminar(ByVal IdStock As Integer)
        Abrir()

        Dim Comando As New SqlCommand("EliminarStock", ConexionP)
        Comando.CommandType = CommandType.StoredProcedure
        Comando.Parameters.AddWithValue("IdStock", IdStock)

        Comando.ExecuteNonQuery()
        Cerrar()

    End Sub
End Class