Public Class ProveedoresGrilla
    Dim proveedor As New Proveedores
    
    Private Sub ProveedoresGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            proveedor.Consultar(DataGridView1)

        Catch ex As Exception
            MessageBox.Show(ex.InnerException.ToString)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProveedoresForm.GuardarTipoP = "Agregar"
        ProveedoresForm.ShowDialog()
    End Sub
    Public Sub Modificar()
        proveedor.IdProveedorP = DataGridView1.Item("IdProveedor", DataGridView1.CurrentRow.Index).Value
        proveedor.NombreP = DataGridView1.Item("Nombre", DataGridView1.CurrentRow.Index).Value
        proveedor.DireccionP = DataGridView1.Item("Direccion", DataGridView1.CurrentRow.Index).Value
        proveedor.TelefonoP = DataGridView1.Item("Telefono", DataGridView1.CurrentRow.Index).Value
        proveedor.PaginaWebP = DataGridView1.Item("PaginaWeb", DataGridView1.CurrentRow.Index).Value
        ProveedoresForm.proveedorP = proveedor
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Modificar()
        ProveedoresForm.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        proveedor.IdProveedorP = DataGridView1.Item("IdProveedor", DataGridView1.CurrentRow.Index).Value
        proveedor.Eliminar(proveedor.IdProveedorP)
        proveedor.Consultar(DataGridView1)

    End Sub
End Class