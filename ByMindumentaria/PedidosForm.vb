Public Class PedidosForm
    Private GuardarTipo As String
    Private Pedido As New Pedidos
    Public Property GuardarTipoP() As String
        Get
            Return GuardarTipo
        End Get
        Set(ByVal value As String)
            GuardarTipo = value
        End Set
    End Property
    Public Property PedidoP() As Pedidos
        Get
            Return Pedido
        End Get
        Set(ByVal value As Pedidos)
            Pedido = value
        End Set
    End Property

    Private Sub PedidosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PedidosGrilla.Enabled = False

        If GuardarTipoP = "AgregarPedido" Then
            Me.Text = "Nuevo Pedido"
        Else
            Me.Text = "Modificar Pedido"
            TextBox1.Text = Pedido.IdPedidoP
            TextBox2.Text = Pedido.IdProveedorP


        End If
    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        Pedido.IdProveedorP = TextBox2.Text


        If GuardarTipoP = "AgregarPedido" Then
            Pedido.IdProveedorP = TextBox2.Text
            Pedido.FechaP = DateTimePicker1.Text
            Pedido.Insertar(PedidoP)
            Me.Close()
        Else

            Pedido.Modificar(PedidoP)
            Me.Close()
        End If
        Pedido.Consultar(PedidosGrilla.DataGridView1)
    End Sub

    Private Sub PedidosForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        PedidosGrilla.Enabled = True
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub
End Class