Public Class FacturaForm
    Dim cliente As New Clientes
    Public factura As New Factura
    Public detalle As New Detalle
    Public Operacion As String



    Public Sub Modificar()
        TextBox1.Text = FacturaGrilla.Factura.IdFacturaP
        ComboBox1.SelectedValue = FacturaGrilla.Factura.IdClienteP
        ComboBox2.SelectedItem = FacturaGrilla.Factura.TipoP
    End Sub
    Private Sub FacturaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cliente.CargarComboClientes(ComboBox1)
        If Operacion = "Modificar" Then
            Modificar()
            detalle.Consultar(DataGridView1, TextBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click


        If TextBox1.Text = Nothing Then
            Me.Close()
        Else

            Dim result As DialogResult = MessageBox.Show("¿Deseas Eliminar la Factura?", "Advertencia !!", MessageBoxButtons.YesNo)

            If (result = Windows.Forms.DialogResult.Yes) Then
                factura.Eliminar(TextBox1.Text)
                detalle.EliminarDetalle(TextBox1.Text)

                Me.Close()
            Else

            End If


        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim iddetalle As Integer = DataGridView1.Item("IdDetalle", DataGridView1.CurrentRow.Index).Value
            detalle.Eliminar2(iddetalle)
            detalle.Consultar(DataGridView1, TextBox1.Text)
            detalle.TotalFactura(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("No se pudo Eliminar")
        End Try

    End Sub
   
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            factura.IdClienteP = ComboBox1.SelectedValue
            factura.TipoP = ComboBox2.SelectedItem
            factura.FechaP = CStr(My.Computer.Clock.LocalTime)

            factura.Insertar(factura)
            Dim ultimafactura As Integer = factura.Ultima
            DetalleForm.Ultima = ultimafactura
            TextBox1.Text = ultimafactura


            DetalleForm.ShowDialog()
        Else
            If Operacion = "Modificar" Then
                DetalleForm.Ultima = TextBox1.Text
            End If

            DetalleForm.ShowDialog()

        End If
    End Sub
End Class