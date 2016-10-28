Public Class AgregarArticulos
    Dim detalle As New Detalle
    Dim stock As New Stock
    Dim cantidadDisponible As Integer
    Private NumeroFactura As Integer
    Dim PrecioUnitario As Decimal
    Public Property NumeroFacturaP() As Integer
        Get
            Return NumeroFactura
        End Get
        Set(ByVal value As Integer)
            NumeroFactura = value
        End Set
    End Property


    Private Sub DetalleForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = 1
        stock.CargarComboStock(ComboBox3)
        stock.ConsultarDetalle(DataGridView1)





    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DetalleValores()
        detalle.Insertar(detalle)
        FacturaForm.Button4.Enabled = True
        FacturaForm.detalle.Consultar(FacturaForm.DataGridView1, NumeroFacturaP)
        Close()

    End Sub
    Public Sub DetalleValores()
        detalle.IdArticuloP = ComboBox3.SelectedValue
        detalle.PrecioUnitarioP = DataGridView1.Item("PrecioUnitario", DataGridView1.CurrentRow.Index).Value
        detalle.IdFacturaP = NumeroFacturaP
        detalle.CantidadP = CInt(TextBox2.Text)
        detalle.TotalP = (detalle.CantidadP * detalle.PrecioUnitarioP)


    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ComboBox3.SelectedValue = DataGridView1.Item("IdStock", DataGridView1.CurrentRow.Index).Value
        DetalleValores()
        GroupBox2.Text = DataGridView1.Item("Articulo", DataGridView1.CurrentRow.Index).Value
    End Sub



    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

End Class