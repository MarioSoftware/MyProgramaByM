Public Class ClienteForm
    Private GuardarTipo As String
    Private Cliente As New Clientes
    Public Property GuardarTipoP() As String
        Get
            Return GuardarTipo
        End Get
        Set(ByVal value As String)
            GuardarTipo = value
        End Set
    End Property
    Public Property ClienteP() As Clientes
        Get
            Return Cliente
        End Get
        Set(ByVal value As Clientes)
            Cliente = value
        End Set
    End Property
    Private Sub ClienteForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ByMIndumentaria.Enabled = False
        ClienteGrilla.Enabled = False
        If GuardarTipo = "AgregarCliente" Then
            Me.Text = "Nuevo Cliente"
        Else
            Me.Text = "Modificar Cliente"
            TextBox1.Text = Cliente.IdClienteP
            TextBox2.Text = Cliente.NombreP
            TextBox3.Text = Cliente.TelefonoP
            TextBox4.Text = Cliente.LocalidadP
            TextBox5.Text = Cliente.DireccionP
            TextBox6.Text = Cliente.DniP
           
        End If
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        Cliente.NombreP = TextBox2.Text
        Cliente.TelefonoP = TextBox3.Text
        Cliente.LocalidadP = TextBox4.Text
        Cliente.DireccionP = TextBox5.Text
        Cliente.DniP = TextBox6.Text

        If GuardarTipoP = "AgregarCliente" Then
            ClienteP.NombreP = TextBox2.Text
            ClienteP.TelefonoP = TextBox3.Text
            ClienteP.LocalidadP = TextBox4.Text
            ClienteP.DireccionP = TextBox5.Text
            ClienteP.DniP = TextBox6.Text
            ClienteP.RegistradoP = DateTimePicker1.Text
            ClienteP.Insertar(ClienteP)
            Me.Close()
        Else

            Cliente.Modificar(ClienteP)
            Me.Close()
        End If
        Cliente.Consultar(ClienteGrilla.DataGridView1)
    End Sub

    Private Sub ClienteForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ClienteGrilla.Enabled = True

    End Sub
End Class