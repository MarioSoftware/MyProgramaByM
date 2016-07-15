Public Class FacturaGrilla
    Dim Factura As New Factura

    Private Sub FacturaGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Factura.Consultar(DataGridView1)

    End Sub

   

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        FacturaForm.ShowDialog()

    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
  

    End Sub
    Public Sub Modificar()

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