Public Class FacturaForm
    Dim cliente As New Clientes
    Dim factura As New Factura
    Public detalle As New Detalle

    Private Sub FacturaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cliente.CargarComboClientes(ComboBox1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        factura.IdClienteP = ComboBox1.SelectedValue
        factura.FechaP = CStr(My.Computer.Clock.LocalTime)
        factura.TipoP = ComboBox2.Text
        If TextBox1.Text = Nothing Then
            factura.Insertar(factura)
            DetalleForm.NumeroFacturaP = factura.Ultima
        End If
    
        TextBox1.Text = factura.Ultima
        DetalleForm.ShowDialog()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
    End Sub
End Class