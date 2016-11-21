Public Class DetalleForm
    Public detalle As New Detalle
    Public stock As New Stock
    Public Ultima, Disminuir As Integer

    Private Sub DetalleForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        stock.Consultar(DataGridView1)


    End Sub
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim stockCantidad As Integer = DataGridView1.Item("Cantidad", DataGridView1.CurrentRow.Index).Value
        detalle.CantidadP = TextBox1.Text
        detalle.IdFacturaP = Ultima
        detalle.IdArticuloP = DataGridView1.Item("IdStock", DataGridView1.CurrentRow.Index).Value
        detalle.PrecioUnitarioP = DataGridView1.Item("PrecioUnitario", DataGridView1.CurrentRow.Index).Value
        detalle.TotalP = detalle.CantidadP * detalle.PrecioUnitarioP
        If detalle.CantidadP > stockCantidad Then
            MessageBox.Show("No Dispones de esa cantidad de " + (DataGridView1.Item("Articulo", DataGridView1.CurrentRow.Index).Value))
        Else
            detalle.Insertar(detalle)
            Disminuir = stockCantidad - detalle.CantidadP
            If Disminuir = 0 Then
                stock.RestarCantidad(detalle.IdArticuloP, Disminuir)

            Else
                stock.RestarCantidad(detalle.IdArticuloP, Disminuir)

            End If
            Me.Close()

        End If
        FacturaForm.detalle.Consultar(FacturaForm.DataGridView1, Ultima)
        FacturaForm.TextBox2.Text = FacturaForm.detalle.TotalFactura(FacturaForm.TextBox1.Text)
   


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class