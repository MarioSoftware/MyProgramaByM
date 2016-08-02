<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ByMIndumentaria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarPorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarPorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SeccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarPorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.NombreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarPorToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevaFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarPorToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetalleDePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarPorToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoDetalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.StockToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.PedidosToolStripMenuItem, Me.DetalleDePedidoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(895, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.BuscarPorToolStripMenuItem, Me.AgregearToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'BuscarPorToolStripMenuItem
        '
        Me.BuscarPorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NombreToolStripMenuItem, Me.DToolStripMenuItem})
        Me.BuscarPorToolStripMenuItem.Name = "BuscarPorToolStripMenuItem"
        Me.BuscarPorToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.BuscarPorToolStripMenuItem.Text = "Buscar Por"
        '
        'NombreToolStripMenuItem
        '
        Me.NombreToolStripMenuItem.Name = "NombreToolStripMenuItem"
        Me.NombreToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.NombreToolStripMenuItem.Text = "Nombre"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.DToolStripMenuItem.Text = "Dni"
        '
        'AgregearToolStripMenuItem
        '
        Me.AgregearToolStripMenuItem.Name = "AgregearToolStripMenuItem"
        Me.AgregearToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.AgregearToolStripMenuItem.Text = "Agregear Cliente"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem1, Me.BuscarPorToolStripMenuItem1, Me.AgregarToolStripMenuItem})
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'VerToolStripMenuItem1
        '
        Me.VerToolStripMenuItem1.Name = "VerToolStripMenuItem1"
        Me.VerToolStripMenuItem1.Size = New System.Drawing.Size(172, 24)
        Me.VerToolStripMenuItem1.Text = "Ver"
        '
        'BuscarPorToolStripMenuItem1
        '
        Me.BuscarPorToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticuloToolStripMenuItem, Me.SeccionToolStripMenuItem})
        Me.BuscarPorToolStripMenuItem1.Name = "BuscarPorToolStripMenuItem1"
        Me.BuscarPorToolStripMenuItem1.Size = New System.Drawing.Size(172, 24)
        Me.BuscarPorToolStripMenuItem1.Text = "Buscar Por"
        '
        'ArticuloToolStripMenuItem
        '
        Me.ArticuloToolStripMenuItem.Name = "ArticuloToolStripMenuItem"
        Me.ArticuloToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.ArticuloToolStripMenuItem.Text = "Articulo"
        '
        'SeccionToolStripMenuItem
        '
        Me.SeccionToolStripMenuItem.Name = "SeccionToolStripMenuItem"
        Me.SeccionToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.SeccionToolStripMenuItem.Text = "Seccion"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.AgregarToolStripMenuItem.Text = "Agregar Stock"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem2, Me.BuscarPorToolStripMenuItem2, Me.AgregarProveedorToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'VerToolStripMenuItem2
        '
        Me.VerToolStripMenuItem2.Name = "VerToolStripMenuItem2"
        Me.VerToolStripMenuItem2.Size = New System.Drawing.Size(207, 24)
        Me.VerToolStripMenuItem2.Text = "Ver"
        '
        'BuscarPorToolStripMenuItem2
        '
        Me.BuscarPorToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NombreToolStripMenuItem1})
        Me.BuscarPorToolStripMenuItem2.Name = "BuscarPorToolStripMenuItem2"
        Me.BuscarPorToolStripMenuItem2.Size = New System.Drawing.Size(207, 24)
        Me.BuscarPorToolStripMenuItem2.Text = "Buscar por Nombre"
        '
        'NombreToolStripMenuItem1
        '
        Me.NombreToolStripMenuItem1.Name = "NombreToolStripMenuItem1"
        Me.NombreToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.NombreToolStripMenuItem1.Text = "Nombre"
        '
        'AgregarProveedorToolStripMenuItem
        '
        Me.AgregarProveedorToolStripMenuItem.Name = "AgregarProveedorToolStripMenuItem"
        Me.AgregarProveedorToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.AgregarProveedorToolStripMenuItem.Text = "Agregar Proveedor"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem3, Me.BuscarPorToolStripMenuItem3, Me.NuevaFacturaToolStripMenuItem})
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'VerToolStripMenuItem3
        '
        Me.VerToolStripMenuItem3.Name = "VerToolStripMenuItem3"
        Me.VerToolStripMenuItem3.Size = New System.Drawing.Size(172, 24)
        Me.VerToolStripMenuItem3.Text = "Nueva Factura"
        '
        'BuscarPorToolStripMenuItem3
        '
        Me.BuscarPorToolStripMenuItem3.Name = "BuscarPorToolStripMenuItem3"
        Me.BuscarPorToolStripMenuItem3.Size = New System.Drawing.Size(172, 24)
        Me.BuscarPorToolStripMenuItem3.Text = "Ver"
        '
        'NuevaFacturaToolStripMenuItem
        '
        Me.NuevaFacturaToolStripMenuItem.Name = "NuevaFacturaToolStripMenuItem"
        Me.NuevaFacturaToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.NuevaFacturaToolStripMenuItem.Text = "Buscar"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem4, Me.BuscarPorToolStripMenuItem4, Me.NuevoPedidoToolStripMenuItem})
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'VerToolStripMenuItem4
        '
        Me.VerToolStripMenuItem4.Name = "VerToolStripMenuItem4"
        Me.VerToolStripMenuItem4.Size = New System.Drawing.Size(172, 24)
        Me.VerToolStripMenuItem4.Text = "Ver"
        '
        'BuscarPorToolStripMenuItem4
        '
        Me.BuscarPorToolStripMenuItem4.Name = "BuscarPorToolStripMenuItem4"
        Me.BuscarPorToolStripMenuItem4.Size = New System.Drawing.Size(172, 24)
        Me.BuscarPorToolStripMenuItem4.Text = "Buscar por"
        '
        'NuevoPedidoToolStripMenuItem
        '
        Me.NuevoPedidoToolStripMenuItem.Name = "NuevoPedidoToolStripMenuItem"
        Me.NuevoPedidoToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.NuevoPedidoToolStripMenuItem.Text = "Nuevo Pedido"
        '
        'DetalleDePedidoToolStripMenuItem
        '
        Me.DetalleDePedidoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem5, Me.BuscarPorToolStripMenuItem5, Me.NuevoDetalleToolStripMenuItem})
        Me.DetalleDePedidoToolStripMenuItem.Name = "DetalleDePedidoToolStripMenuItem"
        Me.DetalleDePedidoToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.DetalleDePedidoToolStripMenuItem.Text = "Detalle de Pedido"
        '
        'VerToolStripMenuItem5
        '
        Me.VerToolStripMenuItem5.Name = "VerToolStripMenuItem5"
        Me.VerToolStripMenuItem5.Size = New System.Drawing.Size(171, 24)
        Me.VerToolStripMenuItem5.Text = "Ver"
        '
        'BuscarPorToolStripMenuItem5
        '
        Me.BuscarPorToolStripMenuItem5.Name = "BuscarPorToolStripMenuItem5"
        Me.BuscarPorToolStripMenuItem5.Size = New System.Drawing.Size(171, 24)
        Me.BuscarPorToolStripMenuItem5.Text = "Buscar por"
        '
        'NuevoDetalleToolStripMenuItem
        '
        Me.NuevoDetalleToolStripMenuItem.Name = "NuevoDetalleToolStripMenuItem"
        Me.NuevoDetalleToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.NuevoDetalleToolStripMenuItem.Text = "Nuevo detalle"
        '
        'ByMIndumentaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 460)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ByMIndumentaria"
        Me.Text = "B y M Indumentaria"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeccionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombreToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetalleDePedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoDetalleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
