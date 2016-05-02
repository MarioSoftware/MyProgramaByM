Public Class FacturaGrilla
    Dim Factura As New Factura

    Private Sub FacturaGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ByMIndumentaria.Enabled = False
        Factura.Consultar(DataGridView1)

    End Sub

    Private Sub FacturaGrilla_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ByMIndumentaria.Enabled = True
    End Sub

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        FacturaForm.GuardarTipoP = "AgregarFactura"
        FacturaForm.Show()


    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        FacturaForm.GuardarTipoP = "ModificarFactura"
        Modificar()
        FacturaForm.Show()

    End Sub
    Public Sub Modificar()
        Factura.IdFacturaP = DataGridView1.Item("IdFactura", DataGridView1.CurrentRow.Index).Value
        Factura.IdClienteP = DataGridView1.Item("IdCliente", DataGridView1.CurrentRow.Index).Value
        Factura.TipoP = DataGridView1.Item("Tipo", DataGridView1.CurrentRow.Index).Value
        Factura.FechaP = DataGridView1.Item("Fecha", DataGridView1.CurrentRow.Index).Value
        FacturaForm.FacturaP = Factura

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