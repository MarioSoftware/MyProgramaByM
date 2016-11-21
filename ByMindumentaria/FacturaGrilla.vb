Public Class FacturaGrilla
    Public Factura As New Factura
    Public Detalle As New Detalle


    Private Sub FacturaGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Factura.Consultar(DataGridView1)

    End Sub

   

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        FacturaForm.ShowDialog()
    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        Try
            Factura.IdFacturaP = DataGridView1.Item("IdFactura", DataGridView1.CurrentRow.Index).Value
            Factura.IdClienteP = DataGridView1.Item("IdCliente", DataGridView1.CurrentRow.Index).Value
            Factura.TipoP = DataGridView1.Item("Tipo", DataGridView1.CurrentRow.Index).Value
            ' FacturaForm.factura = Me.Factura
            FacturaForm.Operacion = "Modificar"
            FacturaForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Selecciona una celda")
        End Try
        



    End Sub
    Public Sub Modificar()
     

    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Dim IdFactura As Integer
        IdFactura = DataGridView1.Item("IdFactura", DataGridView1.CurrentRow.Index).Value
        Factura.Eliminar(IdFactura)
        Detalle.EliminarDetalle(IdFactura)
        Factura.Consultar(DataGridView1)
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()

    End Sub
End Class