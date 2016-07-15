Public Class FacturaForm
    Dim cliente As New Clientes

    Private Sub FacturaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cliente.CargarComboClientes(ComboBox1)
    End Sub
End Class