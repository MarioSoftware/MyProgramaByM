Public Class DetalleForm
    Dim detalle As New Detalle
    Dim stock As New Stock
    Dim cantidadDisponible As Integer
    Private NumeroFactura As Integer
    Public Property NumeroFacturaP() As Integer
        Get
            Return NumeroFactura
        End Get
        Set(ByVal value As Integer)
            NumeroFactura = value
        End Set
    End Property
   
    
    Private Sub DetalleForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        stock.CargarComboStock(ComboBox3)
        stock.ConsultarDetalle(DataGridView1)
        detalle.Consultar(DataGridView2)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        stock.ArticuloP = DataGridView1.Item("Articulo", DataGridView1.CurrentRow.Index).Value
    End Sub
    Public Sub MotrarValores()
        Dim cantidad As Integer
        Dim PrecioUnitario As Decimal
        Dim IdStock As Integer
        Dim articulo As String
        ' Dim imgagen As Image
        Try
            cantidadDisponible = DataGridView1.Item("Cantidad", DataGridView1.CurrentRow.Index).Value
            PrecioUnitario = DataGridView1.Item("PrecioUnitario", DataGridView1.CurrentRow.Index).Value
            IdStock = DataGridView1.Item("IdStock", DataGridView1.CurrentRow.Index).Value
            GroupBox2.Text = articulo
            ComboBox3.SelectedValue = IdStock
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        MotrarValores()
    End Sub
End Class