Public Class FacturaGrilla
    Public Factura As New Factura


    Private Sub FacturaGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Factura.Consultar(DataGridView1)

    End Sub

   

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
      
    End Sub

    Private Sub ButtonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModificar.Click



    End Sub
    Public Sub Modificar()
     

    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
       
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click

    End Sub
End Class