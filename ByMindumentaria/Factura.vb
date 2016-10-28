Imports System.Data
Imports System.Data.SqlClient

Public Class Factura
    Inherits Conexion
    Private IdFactura As Integer
    Private IdCliente As Integer
    Private Tipo As String
    Private Fecha As Date
    Public Property IdFacturaP() As Integer
        Get
            Return IdFactura
        End Get
        Set(ByVal value As Integer)
            IdFactura = value
        End Set
    End Property
    Public Property IdClienteP() As Integer
        Get
            Return IdCliente
        End Get
        Set(ByVal value As Integer)
            IdCliente = value
        End Set
    End Property
    Public Property TipoP() As String
        Get
            Return Tipo
        End Get
        Set(ByVal value As String)
            Tipo = value
        End Set
    End Property
    Public Property FechaP() As Date
        Get
            Return Fecha
        End Get
        Set(ByVal value As Date)
            Fecha = value
        End Set
    End Property

    Public Sub Consultar(ByVal tabla As DataGridView)
        Abrir()

        Dim comando As New SqlCommand("ConsultarFactura", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        Dim DataAdapter As New SqlDataAdapter(comando)
        Dim DataTable As New DataTable
        DataAdapter.Fill(DataTable)
        tabla.DataSource = DataTable
        tabla.Columns("IdCliente").Visible = False

        Cerrar()

    End Sub
    Public Sub Insertar(ByVal Factura As Factura)
        Abrir()
        Dim comando As New SqlCommand("InsertarFactura", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdCliente", Factura.IdClienteP)
        comando.Parameters.AddWithValue("Tipo", Factura.TipoP)
        comando.Parameters.AddWithValue("Fecha", Factura.FechaP)
        comando.ExecuteNonQuery()
        Cerrar()

    End Sub
    Public Sub Modificar(ByVal Factura As Factura)
        Abrir()
        Dim comando As New SqlCommand("ModificarFactura", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdFactura", Factura.IdFacturaP)
        comando.Parameters.AddWithValue("IdCliente", Factura.IdClienteP)
        comando.Parameters.AddWithValue("Tipo", Factura.TipoP)

        comando.ExecuteNonQuery()

        Cerrar()

    End Sub
    Public Sub Eliminar(ByVal IdFactura As Integer)
        Abrir()
        Dim comando As New SqlCommand("EliminarFactura", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdFactura", IdFactura)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
    Public Function Ultima()
        Abrir()
        Dim comando As New SqlCommand("UltimaFactura", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        Ultima = comando.ExecuteScalar
        Cerrar()
    End Function

    


End Class
