Imports System.Data
Imports System.Data.SqlClient

Public Class Pedidos
    Inherits Conexion
    Private IdPedido As Integer
    Private IdProveedor As Integer
    Private Fecha As Date
    Public Property IdPedidoP() As Integer
        Get
            Return IdPedido
        End Get
        Set(ByVal value As Integer)
            IdPedido = value
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
        Dim comando As New SqlCommand("Select * from Pedidos", ConexionP)
        Dim DataAdapter As New SqlDataAdapter(comando)
        Dim DataTable As New DataTable
        DataAdapter.Fill(DataTable)
        tabla.DataSource = DataTable
        Cerrar()
    End Sub
    Public Sub Insertar(ByVal Pedido As Pedidos)
        Abrir()
        Dim comando As New SqlCommand("InsertarPedido", ConexionP)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("IdProveedor", Pedido.IdProveedorP)
        comando.Parameters.AddWithValue("Fecha", Pedido.FechaP)
        comando.ExecuteNonQuery()
        Cerrar()


    End Sub
    Public Sub Modificar(ByVal Pedido As Pedidos)
        Abrir()
        Dim comando As New SqlCommand("ModificarPedido", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdPedido", Pedido.IdPedidoP)
        comando.Parameters.AddWithValue("IdProveedor", Pedido.IdProveedorP)
        comando.Parameters.AddWithValue("Fecha", Pedido.FechaP)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
    Public Sub Eliminar(ByVal IdPedido As Integer)
        Abrir()
        Dim comando As New SqlCommand("EliminarPedido", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdPedido", IdPedido)
        comando.ExecuteNonQuery()
        Cerrar()

    End Sub

End Class
