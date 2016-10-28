Imports System.Data
Imports System.Data.SqlClient
Public Class Proveedores
    Inherits Conexion
    Private IdProveedor As Integer
    Private Nombre As String
    Private Telefono As String
    Private Direccion As String
    Private PaginaWeb As String
    Public Property IdProveedorP() As String
        Get
            Return IdProveedor
        End Get
        Set(ByVal value As String)
            IdProveedor = value
        End Set
    End Property
    Public Property NombreP() As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property
    Public Property TelefonoP() As String
        Get
            Return Telefono
        End Get
        Set(ByVal value As String)
            Telefono = value
        End Set
    End Property
    Public Property DireccionP() As String
        Get
            Return Direccion
        End Get
        Set(ByVal value As String)
            Direccion = value
        End Set
    End Property
    Public Property PaginaWebP() As String
        Get
            Return PaginaWeb
        End Get
        Set(ByVal value As String)
            PaginaWeb = value
        End Set
    End Property

    Public Sub Consultar(ByVal tabla As DataGridView)
        Abrir()
        Dim comando As New SqlCommand("ConsultarProveedores", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        Dim DataTable As New Data.DataTable
        Dim DataAdapter As New SqlDataAdapter(comando)
        DataAdapter.Fill(DataTable)
        tabla.DataSource = DataTable
        Cerrar()
    End Sub

    Public Sub Insertar(ByVal proveedor As Proveedores)
        Abrir()
        Dim comando As New SqlCommand("InsertarProveedor", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("Nombre", proveedor.Nombre)
        comando.Parameters.AddWithValue("Telefono", proveedor.Telefono)
        comando.Parameters.AddWithValue("Direccion", proveedor.Direccion)
        comando.Parameters.AddWithValue("PaginaWeb", proveedor.PaginaWeb)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Modificar(ByVal proveedor As Proveedores)
        Abrir()
        Dim comando As New SqlCommand("ModificarProveedor", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdProveedor", proveedor.IdProveedorP)
        comando.Parameters.AddWithValue("Nombre", proveedor.Nombre)
        comando.Parameters.AddWithValue("Telefono", proveedor.Telefono)
        comando.Parameters.AddWithValue("Direccion", proveedor.Direccion)
        comando.Parameters.AddWithValue("PaginaWeb", proveedor.PaginaWeb)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
    Public Sub Eliminar(ByVal IdProveedor As Integer)

        Abrir()
        Dim comando As New SqlCommand("EliminarProveedor", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdProveedor", IdProveedor)
        comando.ExecuteNonQuery()
        Cerrar()

    End Sub

    Public Sub CargarComboProveedores(ByVal combo As ComboBox)
        Abrir()
        Dim comando As New SqlCommand("CargarComboProveedores", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        Dim DataTable As New Data.DataTable
        Dim DataAdapter As New SqlDataAdapter(comando)
        DataAdapter.Fill(DataTable)
        combo.DataSource = DataTable
        combo.ValueMember = "IdProveedor"
        combo.DisplayMember = "Nombre"
        Cerrar()
    End Sub

End Class
