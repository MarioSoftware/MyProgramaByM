Public Class ByMIndumentaria

    Private Sub VerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerToolStripMenuItem.Click

        ClienteGrilla.Show()



    End Sub

    Private Sub AgregearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregearToolStripMenuItem.Click
        ClienteForm.GuardarTipoP = "AgregarCliente"
        ClienteForm.ShowDialog()

    End Sub

   

    Private Sub ByMIndumentaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    

    Private Sub VerToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerToolStripMenuItem4.Click
        PedidosGrilla.Show()
    End Sub

    Private Sub VerToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerToolStripMenuItem5.Click
        DetallePedidoGrilla.Show()

    End Sub

    Private Sub VerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerToolStripMenuItem1.Click
        StockGrilla.Show()

    End Sub

    Private Sub VerToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerToolStripMenuItem2.Click
        ProveedoresGrilla.ShowDialog()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click

        StockForm.GuardarTipoP = "AgregarStock"
        StockForm.ShowDialog()
    End Sub

    Private Sub AgregarProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarProveedorToolStripMenuItem.Click
        ProveedoresForm.GuardarTipoP = "Agregar"
        ProveedoresForm.ShowDialog()
    End Sub

    Private Sub VerToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerToolStripMenuItem3.Click



        FacturaForm.detalle.ConsultarVacio(FacturaForm.DataGridView1)
        FacturaForm.ComboBox2.SelectedItem = "A"
        FacturaForm.ComboBox1.SelectedValue = 0
        FacturaForm.TextBox1.Text = ""
        FacturaForm.ShowDialog()
    End Sub

    Private Sub BuscarPorToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarPorToolStripMenuItem3.Click
        FacturaGrilla.ShowDialog()
    End Sub
End Class
