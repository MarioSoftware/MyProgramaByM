Public Class StockForm
    Dim GuardarTipo As String
    Dim Stock As New Stock

    Public Property GuardarTipoP() As String
        Get
            Return GuardarTipo

        End Get
        Set(ByVal value As String)
            GuardarTipo = value

        End Set
    End Property

    Public Property StockP() As Stock
        Get
            Return Stock

        End Get
        Set(ByVal value As Stock)
            Stock = value

        End Set
    End Property


    Private Sub StockForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ByMIndumentaria.Enabled = False
        StockGrilla.Enabled = False

        If GuardarTipo = "AgregarStock" Then
            Me.Text = "Nuevo Stock"
        Else
            Me.Text = "Modificar Stock"
            TextBox1.Text = Stock.IdStockP
            TextBox2.Text = Stock.IdProveedorP
            TextBox3.Text = Stock.ArticuloP
            TextBox4.Text = Stock.SeccionP
            TextBox5.Text = Stock.Talle_MedidaP
            TextBox6.Text = Stock.CatidadP
            TextBox7.Text = Stock.PrecioUnitarioP
            TextBox8.Text = Stock.MinimoP
            TextBox9.Text = Stock.aPedirP

        End If
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.Close()

    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        Stock.IdProveedorP = TextBox2.Text
        Stock.ArticuloP = TextBox3.Text
        Stock.SeccionP = TextBox4.Text
        Stock.Talle_MedidaP = TextBox5.Text
        Stock.CatidadP = TextBox6.Text
        Stock.PrecioUnitarioP = TextBox7.Text
        Stock.MinimoP = TextBox8.Text
        Stock.aPedirP = TextBox9.Text

        If GuardarTipoP = "AgregarStock" Then
            Stock.IdProveedorP = TextBox2.Text
            StockP.ArticuloP = TextBox3.Text
            StockP.SeccionP = TextBox4.Text
            StockP.Talle_MedidaP = TextBox5.Text
            StockP.CatidadP = TextBox6.Text
            StockP.PrecioUnitarioP = TextBox7.Text
            StockP.MinimoP = TextBox8.Text
            StockP.aPedirP = TextBox9.Text
            StockP.Insertar(StockP)
            Me.Close()
        Else
            Stock.Modificar(StockP)
            Me.Close()
        End If
        Stock.Consultar(StockGrilla.DataGridView1)
    End Sub


    Private Sub StockForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        StockGrilla.Enabled = True
    End Sub
End Class