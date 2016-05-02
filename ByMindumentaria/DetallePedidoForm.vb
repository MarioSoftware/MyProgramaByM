Public Class DetallePedidoForm
    Private GuardarTipo As String
    Private DetallePedido As New DetallePedido
    Public Property GuardarTipoP() As String
        Get
            Return GuardarTipo
        End Get
        Set(ByVal value As String)
            GuardarTipo = value
        End Set
    End Property
    Public Property DetallePedidoP() As DetallePedido
        Get
            Return DetallePedido
        End Get
        Set(ByVal value As DetallePedido)
            DetallePedido = value
        End Set
    End Property

    Private Sub DetallePedidoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DetallePedidoGrilla.Enabled = False
        If Me.GuardarTipoP = "AgregarDetalle" Then
            Me.Text = "Agregar Detalle de Pedido"
        Else
            Me.Text = "Modificar Detalle de Pedido"
            TextBox1.Text = DetallePedido.IdDetalleP
            TextBox2.Text = DetallePedido.IdPedidoP
            TextBox3.Text = DetallePedido.IdStockP
            TextBox4.Text = DetallePedido.CantidadP
            TextBox5.Text = DetallePedido.PrecioUnitarioP
            TextBox6.Text = DetallePedido.PrecioTotalP
        End If
    End Sub

    Private Sub DetallePedidoForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DetallePedidoGrilla.Enabled = True
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        DetallePedido.IdPedidoP = TextBox2.Text
        DetallePedido.IdStockP = TextBox3.Text
        DetallePedido.CantidadP = TextBox4.Text
        DetallePedido.PrecioUnitarioP = TextBox5.Text
        DetallePedido.PrecioTotalP = TextBox6.Text

        If GuardarTipoP = "AgregarDetalle" Then
            DetallePedido.IdPedidoP = TextBox2.Text
            DetallePedido.IdStockP = TextBox3.Text
            DetallePedido.CantidadP = TextBox4.Text
            DetallePedido.PrecioUnitarioP = TextBox5.Text
            DetallePedido.PrecioTotalP = TextBox6.Text
            DetallePedido.Insertar(DetallePedido)
            Me.Close()
        Else
            DetallePedido.Modificar(DetallePedidoP)
            Me.Close()
        End If
        DetallePedido.Consultar(DetallePedidoGrilla.DataGridView1)

    End Sub
End Class