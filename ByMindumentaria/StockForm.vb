Public Class StockForm
    Dim GuardarTipo As String
    Dim Stock As New Stock
    Dim proveedor As New Proveedores

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
        Try
            proveedor.CargarComboProveedores(ComboBox1)
        Catch ex As Exception
            MessageBox.Show(ex.InnerException.ToString)
        End Try

        If GuardarTipo = "AgregarStock" Then
            Me.Text = "Agregar Stock"
            ComboBox1.SelectedValue = 0
            TextBox3.Text = ""
            ComboBox2.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""


        Else
            Me.Text = "Modificar Stock"
            TextBox1.Text = Stock.IdStockP
            ComboBox1.SelectedValue = Stock.IdProveedorP
            TextBox3.Text = Stock.ArticuloP
            ComboBox2.Text = Stock.SeccionP
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
       
        Stock.IdProveedorP = ComboBox1.SelectedValue
        Stock.ArticuloP = TextBox3.Text
        Stock.SeccionP = ComboBox2.Text
        Stock.Talle_MedidaP = TextBox5.Text
        Stock.CatidadP = TextBox6.Text
        Stock.PrecioUnitarioP = TextBox7.Text
        Stock.MinimoP = TextBox8.Text
        Stock.aPedirP = TextBox9.Text

        If GuardarTipoP = "AgregarStock" Then
            Stock.Insertar(Stock)
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