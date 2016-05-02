Public Class DetallePedidoGrilla
    Dim DetallePedido As New DetallePedido
    Private Sub DetallePedidoGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ByMIndumentaria.Enabled = False
        DetallePedido.Consultar(DataGridView1)

    End Sub

    Private Sub DetallePedidoGrilla_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ByMIndumentaria.Enabled = True
    End Sub

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click

        DetallePedidoForm.GuardarTipoP = "AgregarDetalle"
        DetallePedidoForm.Show()
        DetallePedidoForm.Text = "AgregarDetalle de Pedido"

    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click

        DetallePedidoForm.GuardarTipoP = "ModificarDetalle"
        Modificar()
        DetallePedidoForm.Show()
    End Sub
    Public Sub Modificar()
        DetallePedido.IdDetalleP = DataGridView1.Item("IdDetalle", DataGridView1.CurrentRow.Index).Value
        DetallePedido.IdPedidoP = DataGridView1.Item("IdPedido", DataGridView1.CurrentRow.Index).Value
        DetallePedido.IdStockP = DataGridView1.Item("IdStock", DataGridView1.CurrentRow.Index).Value
        DetallePedido.CantidadP = DataGridView1.Item("Cantidad", DataGridView1.CurrentRow.Index).Value
        DetallePedido.PrecioUnitarioP = DataGridView1.Item("PrecioUnitario", DataGridView1.CurrentRow.Index).Value
        DetallePedido.PrecioTotalP = DataGridView1.Item("PrecioTotal", DataGridView1.CurrentRow.Index).Value
        DetallePedidoForm.DetallePedidoP = DetallePedido
    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Dim IdDetalle As Integer = DataGridView1.Item("IdDetalle", DataGridView1.CurrentRow.Index).Value
        DetallePedido.Eliminar(IdDetalle)
        DetallePedido.Consultar(DataGridView1)
    End Sub
End Class