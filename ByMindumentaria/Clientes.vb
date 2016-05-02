Imports System.Data
Imports System.Data.SqlClient
Public Class Clientes
    Inherits Conexion
    Private IdCliente As Integer
    Private Nombre As String
    Private Telefono As String
    Private Localidad As String
    Private Direccion As String
    Private Dni As String
    Private Registrado As Date
    Public Property IdClienteP() As Integer
        Get
            Return IdCliente
        End Get
        Set(ByVal value As Integer)
            IdCliente = value
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
    Public Property LocalidadP() As String
        Get
            Return Localidad
        End Get
        Set(ByVal value As String)
            Localidad = value
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
    Public Property DniP() As String
        Get
            Return Dni
        End Get
        Set(ByVal value As String)
            Dni = value
        End Set
    End Property
    Public Property RegistradoP() As Date
        Get
            Return Registrado
        End Get
        Set(ByVal value As Date)
            Registrado = value
        End Set
    End Property

    Public Sub Consultar(ByVal Tabla As DataGridView)
        Abrir()
        Dim sentencia As String = "Select * from clientes"
        Dim Comando As New SqlCommand(sentencia, ConexionP)

        Dim DataAdatper As New SqlDataAdapter(Comando)
        Dim DataTable As New DataTable
        DataAdatper.Fill(DataTable)
        Tabla.DataSource = DataTable
        Cerrar()

    End Sub
    Public Sub Insertar(ByVal Cliente As Clientes)
        Abrir()

        Dim comando As New SqlCommand("InsertarCliente", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("Nombre", Cliente.NombreP)
        comando.Parameters.AddWithValue("Telefono", Cliente.TelefonoP)
        comando.Parameters.AddWithValue("Localidad", Cliente.LocalidadP)
        comando.Parameters.AddWithValue("Direccion", Cliente.DireccionP)
        comando.Parameters.AddWithValue("Dni", Cliente.DniP)
        comando.Parameters.AddWithValue("Registrado", Cliente.RegistradoP)


        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
    Public Sub Modificar(ByVal cliente As Clientes)
        Abrir()

        Dim comando As New SqlCommand("ModificarCliente", ConexionP)
        comando.CommandType = CommandType.StoredProcedure

       
        comando.Parameters.AddWithValue("IdCliente", cliente.IdClienteP)
        comando.Parameters.AddWithValue("Nombre", cliente.NombreP)
        comando.Parameters.AddWithValue("Dni", cliente.DniP)
        comando.Parameters.AddWithValue("Telefono", cliente.TelefonoP)
        comando.Parameters.AddWithValue("Localidad", cliente.LocalidadP)
        comando.Parameters.AddWithValue("Direccion", cliente.DireccionP)
        comando.Parameters.AddWithValue("Registrado", cliente.RegistradoP)

        comando.ExecuteNonQuery()
        Cerrar()

    End Sub
    Public Sub Eliminar(ByVal IdCliente As Integer)
        Abrir()

        Dim comando As New SqlCommand("EliminarCliente", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdCliente", IdCliente)

        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
