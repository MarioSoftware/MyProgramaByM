Public Class FacturaForm
    Private GuardarTipo As String
    Private Factura As New Factura
    Public Property GuardarTipoP() As String
        Get
            Return GuardarTipo
        End Get
        Set(ByVal value As String)
            GuardarTipo = value
        End Set
    End Property
    Public Property FacturaP() As Factura
        Get
            Return Factura
        End Get
        Set(ByVal value As Factura)
            Factura = value
        End Set
    End Property


   
    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        Factura.IdClienteP = TextBox2.Text
        Factura.TipoP = TextBox3.Text


        If GuardarTipoP = "AgregarFactura" Then
            Factura.IdClienteP = TextBox2.Text
            Factura.TipoP = TextBox3.Text
            Factura.FechaP = DateTimePicker1.Text
            Factura.Insertar(FacturaP)
            Me.Close()
        Else
            Factura.Modificar(FacturaP)
            Me.Close()

        End If
        Factura.Consultar(FacturaGrilla.DataGridView1)

    End Sub

    Private Sub FacturaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ByMIndumentaria.Enabled = False
        FacturaGrilla.Enabled = False
        If GuardarTipoP = "AgregarFactura" Then
            Me.Text = " Nueva Factura"
        Else
            Me.Text = "Modificar Factura"
            TextBox1.Text = Factura.IdFacturaP
            TextBox2.Text = Factura.IdClienteP
            TextBox3.Text = Factura.TipoP

        End If
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub FacturaForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FacturaGrilla.Enabled = True
    End Sub
End Class