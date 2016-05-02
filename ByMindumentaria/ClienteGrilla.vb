Public Class ClienteGrilla
    Dim cliente As New Clientes
    Private Sub ClienteGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ByMIndumentaria.Enabled = False
        cliente.Consultar(DataGridView1)

    End Sub

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        ClienteForm.GuardarTipoP = "AgregarCliente"
        ClienteForm.Show()
    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        ClienteForm.GuardarTipoP = "ModificarCliente"
        Modificar()
        ClienteForm.Show()

    End Sub
    Public Sub Modificar()
        cliente.IdClienteP = DataGridView1.Item("IdCliente", DataGridView1.CurrentRow.Index).Value
        cliente.NombreP = DataGridView1.Item("Nombre", DataGridView1.CurrentRow.Index).Value
        cliente.TelefonoP = DataGridView1.Item("Telefono", DataGridView1.CurrentRow.Index).Value
        cliente.LocalidadP = DataGridView1.Item("Localidad", DataGridView1.CurrentRow.Index).Value
        cliente.DireccionP = DataGridView1.Item("Direccion", DataGridView1.CurrentRow.Index).Value
        cliente.DniP = DataGridView1.Item("Dni", DataGridView1.CurrentRow.Index).Value
        cliente.RegistradoP = DataGridView1.Item("Registrado", DataGridView1.CurrentRow.Index).Value
        ClienteForm.ClienteP = cliente

    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Dim IdCliente As Integer = DataGridView1.Item("IdCliente", DataGridView1.CurrentRow.Index).Value

        cliente.Eliminar(IdCliente)
        cliente.Consultar(DataGridView1)


    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()

    End Sub

    Private Sub ClienteGrilla_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ByMIndumentaria.Enabled = True
    End Sub
End Class