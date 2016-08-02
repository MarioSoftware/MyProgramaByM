Public Class FacturaForm
    Dim cliente As New Clientes
    Dim factura As New Factura

    Private Sub FacturaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cliente.CargarComboClientes(ComboBox1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        factura.IdClienteP = ComboBox1.SelectedValue
        factura.FechaP = CStr(My.Computer.Clock.LocalTime)
        factura.TipoP = ComboBox2.Text
        factura.Insertar(factura)
        DetalleForm.NumeroFacturaP = factura.Ultima
        DetalleForm.ShowDialog()


    End Sub
End Class