Imports System.Data
Imports System.Data.SqlClient

Public Class DetallePedido
    Inherits Conexion
    Private IdDetalle As Integer
    Private IdPedido As Integer
    Private IdStock As Integer
    Private Cantidad As Integer
    Private PrecioUnitario As Decimal
    Private PrecioTotal As Decimal
    Public Property IdDetalleP() As Integer
        Get
            Return IdDetalle
        End Get
        Set(ByVal value As Integer)
            IdDetalle = value
        End Set
    End Property
    Public Property IdPedidoP() As Integer
        Get
            Return IdPedido
        End Get
        Set(ByVal value As Integer)
            IdPedido = value
        End Set
    End Property
    Public Property IdStockP() As Integer
        Get
            Return IdStock
        End Get
        Set(ByVal value As Integer)
            IdStock = value
        End Set
    End Property
    Public Property CantidadP() As Integer
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
    Public Property PrecioTotalP() As Decimal
        Get
            Return PrecioTotal
        End Get
        Set(ByVal value As Decimal)
            PrecioTotal = value
        End Set
    End Property
    Public Sub Consultar(ByVal tabla As DataGridView)
        Abrir()
        Dim comando As New SqlCommand("Select * from DetallePedido", ConexionP)
        Dim DataAdapter As New SqlDataAdapter(comando)
        Dim DataTable As New DataTable
        DataAdapter.Fill(DataTable)
        tabla.DataSource = DataTable
        Cerrar()
    End Sub
    Public Sub Insertar(ByVal DetallePedido As DetallePedido)
        Abrir()
        Dim comando As New SqlCommand("InsertarDetallePedido", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdPedido", DetallePedido.IdPedidoP)
        comando.Parameters.AddWithValue("IdStock", DetallePedido.IdStockP)
        comando.Parameters.AddWithValue("Cantidad", DetallePedido.CantidadP)
        comando.Parameters.AddWithValue("PrecioUnitario", DetallePedido.PrecioUnitarioP)
        comando.Parameters.AddWithValue("PrecioTotal", DetallePedido.PrecioTotal)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub
    Public Sub Modificar(ByVal DetallePedido As DetallePedido)
        Abrir()
        Dim comando As New SqlCommand("ModificarDetallePedido", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdDetalle", DetallePedido.IdDetalleP)
        comando.Parameters.AddWithValue("IdPedido", DetallePedido.IdPedidoP)
        comando.Parameters.AddWithValue("IdStock", DetallePedido.IdStockP)
        comando.Parameters.AddWithValue("Cantidad", DetallePedido.CantidadP)
        comando.Parameters.AddWithValue("PrecioUnitario", DetallePedido.PrecioUnitarioP)
        comando.Parameters.AddWithValue("PrecioTotal", DetallePedido.PrecioTotalP)
        comando.ExecuteNonQuery()
        Cerrar()

    End Sub
    Public Sub Eliminar(ByVal IdDetalle As Integer)
        Abrir()
        Dim comando As New SqlCommand("EliminarDetallePedido", ConexionP)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("IdDetalle", IdDetalle)
        comando.ExecuteNonQuery()
        Cerrar()
    End Sub

End Class
