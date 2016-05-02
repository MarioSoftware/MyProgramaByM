Public Class PedidosGrilla
    Dim Pedido As New Pedidos

    
    Private Sub PedidosGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ByMIndumentaria.Enabled = False
        Pedido.Consultar(DataGridView1)
    End Sub

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        PedidosForm.GuardarTipoP = "AgregarPedido"
        PedidosForm.Show()
    End Sub

    Private Sub PedidosGrilla_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ByMIndumentaria.Enabled = True
    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        PedidosForm.GuardarTipoP = "ModificarPedido"
        Modificar()
        PedidosForm.Show()
    End Sub
    Public Sub Modificar()
        Pedido.IdPedidoP = DataGridView1.Item("IdPedido", DataGridView1.CurrentRow.Index).Value
        Pedido.IdProveedorP = DataGridView1.Item("IdProveedor", DataGridView1.CurrentRow.Index).Value
        Pedido.FechaP = DataGridView1.Item("Fecha", DataGridView1.CurrentRow.Index).Value
        PedidosForm.PedidoP = Pedido
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Dim IdPedido As Integer = DataGridView1.Item("IdPedido", DataGridView1.CurrentRow.Index).Value
        Pedido.Eliminar(IdPedido)
        Pedido.Consultar(DataGridView1)
    End Sub
End Class