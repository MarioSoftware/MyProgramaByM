Public Class StockGrilla
    Dim Stock As New Stock

    Private Sub StockGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ByMIndumentaria.Enabled = False
        Stock.Consultar(DataGridView1)

    End Sub

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        StockForm.GuardarTipoP = "AgregarStock"
        StockForm.Show()
    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click
        StockForm.GuardarTipoP = "ModificarStock"
        Modificar()
        StockForm.Show()

    End Sub

    Public Sub Modificar()
        Stock.IdStockP = DataGridView1.Item("IdStock", DataGridView1.CurrentRow.Index).Value
        Stock.IdProveedorP = DataGridView1.Item("IdProveedor", DataGridView1.CurrentRow.Index).Value
        Stock.ArticuloP = DataGridView1.Item("ARticulo", DataGridView1.CurrentRow.Index).Value
        Stock.SeccionP = DataGridView1.Item("Seccion", DataGridView1.CurrentRow.Index).Value
        Stock.Talle_MedidaP = DataGridView1.Item("Talle_Medida", DataGridView1.CurrentRow.Index).Value
        Stock.CatidadP = DataGridView1.Item("Cantidad", DataGridView1.CurrentRow.Index).Value
        Stock.PrecioUnitarioP = DataGridView1.Item("PrecioUnitario", DataGridView1.CurrentRow.Index).Value
        'Stock.ImagenP = DataGridView1.Item("Imagen", DataGridView1.CurrentRow.Index).Value
        Stock.MinimoP = DataGridView1.Item("Minimo", DataGridView1.CurrentRow.Index).Value
        Stock.aPedirP = DataGridView1.Item("aPedir", DataGridView1.CurrentRow.Index).Value
        StockForm.StockP = Stock

    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Dim IdStock As Integer = DataGridView1.Item("IdStock", DataGridView1.CurrentRow.Index).Value

        Stock.Eliminar(IdStock)
        Stock.Consultar(DataGridView1)

    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub


    Private Sub StockGrilla_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ByMIndumentaria.Enabled = True

    End Sub
End Class