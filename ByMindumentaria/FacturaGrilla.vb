Public Class FacturaGrilla
    Public Factura As New Factura


    Private Sub FacturaGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Factura.Consultar(DataGridView1)

    End Sub

   

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        FacturaForm.detalle.ConsultarVacio(FacturaForm.DataGridView1)
        FacturaForm.ComboBox1.SelectedValue = 1
        FacturaForm.ComboBox2.SelectedItem = "A"
        FacturaForm.TextBox1.Text = ""


        FacturaForm.ShowDialog()

    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        Modificar()


    End Sub
    Public Sub Modificar()
        Factura.IdFacturaP = DataGridView1.Item("IdFactura", DataGridView1.CurrentRow.Index).Value
        Factura.IdClienteP = DataGridView1.Item("IdCliente", DataGridView1.CurrentRow.Index).Value
        Factura.TipoP = DataGridView1.Item("Tipo", DataGridView1.CurrentRow.Index).Value
        Factura.FechaP = DataGridView1.Item("Fecha", DataGridView1.CurrentRow.Index).Value

       
        FacturaForm.Modificar = True
        FacturaForm.factura = Factura
        FacturaForm.detalle.Consultar(FacturaForm.DataGridView1, Factura.IdFacturaP)
        FacturaForm.ShowDialog()

    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Dim IdFactura As Integer = DataGridView1.Item("IdFactura", DataGridView1.CurrentRow.Index).Value
        Factura.Eliminar(IdFactura)
        Factura.Consultar(DataGridView1)
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class