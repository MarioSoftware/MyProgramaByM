Imports System.Data
Imports System.Data.SqlClient

Public Class Stock

    Inherits Conexion
    Private IdStock As Integer
    Private IdProveedor As Integer
    Private Articulo As String
    Private Seccion As String
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

    Public Property ArticuloP() As String
        Get
            Return Articulo

        End Get
        Set(ByVal value As String)
            Articulo = value

        End Set
    End Property

    Public Property SeccionP() As String
        Get
            Return Seccion

        End Get
        Set(ByVal value As String)
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

        Dim Comando As New SqlCommand("ConsultarStock", ConexionP)
        Comando.CommandType = CommandType.StoredProcedure
        Dim DataAdatper As New SqlDataAdapter(Comando)
        Dim DataTable As New DataTable
        DataAdatper.Fill(DataTable)
        Tabla.DataSource = DataTable
        Tabla.Columns("IdProveedor").Visible = False
        Tabla.Columns("Articulo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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
    Public Sub ConsultarDetalle(ByVal Tabla As DataGridView)
        Abrir()

        Dim Comando As New SqlCommand("ConsultarStock", ConexionP)
        Comando.CommandType = CommandType.StoredProcedure
        Dim DataAdatper As New SqlDataAdapter(Comando)
        Dim DataTable As New DataTable
        DataAdatper.Fill(DataTable)
        Tabla.DataSource = DataTable
        Tabla.Columns("IdProveedor").Visible = False
        Tabla.Columns("Proveedor").Visible = False
        Tabla.Columns("IdStock").Visible = False
        Tabla.Columns("Minimo").Visible = False
        Tabla.Columns("aPedir").Visible = False
        'Tabla.Columns("Imagen").Visible = False


        Cerrar()

    End Sub
    Public Sub Buscar(ByVal tabla As DataGridView, ByVal Busqueda As String)
        Abrir()
        Dim comando As New SqlCommand("Buscar", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        Dim DataAdapter As New SqlDataAdapter(comando)
        Dim DataTable As New Data.DataTable
        DataAdapter.Fill(DataTable)
        tabla.DataSource = DataTable
        tabla.Columns("IdProveedor").Visible = False
        tabla.Columns("Proveedor").Visible = False
        tabla.Columns("IdStock").Visible = False
        tabla.Columns("Minimo").Visible = False
        tabla.Columns("aPedir").Visible = False
        'Tabla.Columns("Imagen").Visible = False
        tabla.Columns("Articulo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Sub
    Public Sub CargarComboStock(ByVal combo As ComboBox)
        Abrir()
        Dim comando As New SqlCommand("CargarComboStock", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        Dim DataTable As New Data.DataTable
        Dim DataAdapter As New SqlDataAdapter(comando)
        DataAdapter.Fill(DataTable)
        combo.DataSource = DataTable
        combo.ValueMember = "IdStock"
        combo.DisplayMember = "Articulo"
        Cerrar()
    End Sub
End Class
