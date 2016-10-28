Public Class FacturaForm
    Dim cliente As New Clientes
    Public factura As New Factura
    Public detalle As New Detalle
    Public Modificar As Boolean

    Private Sub FacturaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cliente.CargarComboClientes(ComboBox1)

        If Modificar = True Then
            Button4.Enabled = False
            ComboBox1.SelectedValue = factura.IdClienteP
            ComboBox2.SelectedItem = factura.TipoP
            TextBox1.Text = factura.IdFacturaP
          
         
        Else
            ComboBox2.SelectedItem = "A"
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        factura.IdClienteP = ComboBox1.SelectedValue
        factura.FechaP = CStr(My.Computer.Clock.LocalTime)
        factura.TipoP = ComboBox2.Text
        If TextBox1.Text = Nothing Then
            factura.Insertar(factura)
            AgregarArticulos.NumeroFacturaP = factura.Ultima
        End If

        TextBox1.Text = factura.Ultima
        Button3.Enabled = True
        AgregarArticulos.ShowDialog()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Modificar = True Then
            Modificar = False
           
            Me.Close()
        Else

            If TextBox1.Text = Nothing Then
                Close()
            Else
                Try
                    detalle.EliminarDetalle(factura.Ultima)
                    factura.Eliminar(factura.Ultima)

                    MessageBox.Show("La Factura ha sido ELIMINADA")
                    Close()
                Catch ex As Exception
                    MessageBox.Show("No se pudo Eliminar la Factura")
                End Try
            End If
        End If
      
       
    
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Modificar = True Then
            Modificar = False

            factura.IdClienteP = ComboBox1.SelectedValue
            factura.TipoP = ComboBox2.Text
            factura.IdFacturaP = TextBox1.Text
            factura.Modificar(factura)
            ComboBox1.SelectedValue = 1
            ComboBox2.SelectedItem = "A"
            TextBox1.Text = ""
            Me.Close()





        End If
        FacturaGrilla.Factura.Consultar(FacturaGrilla.DataGridView1)
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            detalle.IdDetalleP = DataGridView1.Item("IdDetalle", DataGridView1.CurrentRow.Index).Value
            detalle.Eliminar2(detalle.IdDetalleP)
            detalle.Consultar(DataGridView1, factura.Ultima)
        Catch ex As Exception
            MessageBox.Show("No se pudo elimiar el detalle ")
        End Try
      





    End Sub
   
End Class