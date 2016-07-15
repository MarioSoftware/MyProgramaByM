Public Class ProveedoresForm
    Private GuardarTipo As String
    Private proveedor As New Proveedores
    Public Property proveedorP() As Proveedores
        Get
            Return proveedor
        End Get
        Set(ByVal value As Proveedores)
            proveedor = value
        End Set
    End Property
    Public WriteOnly Property GuardarTipoP() As String

        Set(ByVal value As String)
            GuardarTipo = value
        End Set
    End Property

    Private Sub ProveedoresForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GuardarTipo = "Agregar" Then
        Else
            TextBox1.Text = proveedor.IdProveedorP
            TextBox2.Text = proveedor.NombreP
            TextBox3.Text = proveedor.TelefonoP
            TextBox4.Text = proveedor.DireccionP
            TextBox5.Text = proveedor.PaginaWebP
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        proveedor.NombreP = TextBox2.Text
        proveedor.TelefonoP = TextBox3.Text
        proveedor.DireccionP = TextBox4.Text
        proveedor.PaginaWebP = TextBox5.Text
        If GuardarTipo = "Agregar" Then
            proveedor.Insertar(proveedor)
            proveedor.Consultar(ProveedoresGrilla.DataGridView1)
            Close()
        Else
            proveedor.Modificar(proveedor)
            proveedor.Consultar(ProveedoresGrilla.DataGridView1)
            Close()
        End If
    End Sub
End Class