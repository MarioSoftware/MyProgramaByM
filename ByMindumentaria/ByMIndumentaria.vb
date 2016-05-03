Public Class ByMIndumentaria

    Private Sub VerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerToolStripMenuItem.Click

        ClienteGrilla.Show()



    End Sub

    Private Sub AgregearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregearToolStripMenuItem.Click
        ClienteForm.GuardarTipoP = "AgregarCliente"
        ClienteForm.Show()
    End Sub

   

    Private Sub ByMIndumentaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VerToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerToolStripMenuItem3.Click

        FacturaGrilla.Show()
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
End Class
