Imports System.Data
Imports System.Data.SqlClient
Public Class Detalle
    Private IdDetalle As Integer
    Private IdFactura As Integer
    Private IdArticulo As Integer
    Private PrecioUnitario As Decimal
    Private Cantidad As Decimal
    Private Total As Decimal
    Public Property IdDetalleP() As Integer
        Get
            Return IdDetalle
        End Get
        Set(ByVal value As Integer)
            IdDetalle = value
        End Set
    End Property
    Public Property IdFacturaP() As Integer
        Get
            Return IdFactura
        End Get
        Set(ByVal value As Integer)
            IdFactura = value
        End Set
    End Property
    Public Property IdArticuloP() As Integer
        Get
            Return IdArticulo
        End Get
        Set(ByVal value As Integer)
            IdArticulo = value
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
    Public Property CantidadP() As Integer
        Get
            Return Cantidad
        End Get
        Set(ByVal value As Integer)
            Cantidad = value
        End Set
    End Property
    Public Property TotalP() As Decimal
        Get
            Return Total
        End Get
        Set(ByVal value As Decimal)
            Total = value
        End Set
    End Property







End Class
