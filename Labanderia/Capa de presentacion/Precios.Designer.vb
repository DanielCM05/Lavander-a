<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Precios
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_Borrar = New System.Windows.Forms.Button()
        Me.bt_Ingresar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaDeCobroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrecionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarPrecionNormalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GananciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketsGeneradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngrsaNuevoTrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 166)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(443, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(361, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agrega un nuevo producto para vender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(158, 233)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(209, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "$"
        '
        'bt_Borrar
        '
        Me.bt_Borrar.Location = New System.Drawing.Point(198, 296)
        Me.bt_Borrar.Name = "bt_Borrar"
        Me.bt_Borrar.Size = New System.Drawing.Size(137, 108)
        Me.bt_Borrar.TabIndex = 6
        Me.bt_Borrar.Text = "Borrar"
        Me.bt_Borrar.UseVisualStyleBackColor = True
        '
        'bt_Ingresar
        '
        Me.bt_Ingresar.Location = New System.Drawing.Point(539, 296)
        Me.bt_Ingresar.Name = "bt_Ingresar"
        Me.bt_Ingresar.Size = New System.Drawing.Size(137, 108)
        Me.bt_Ingresar.TabIndex = 7
        Me.bt_Ingresar.Text = "Ingresar"
        Me.bt_Ingresar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionToolStripMenuItem, Me.SalirToolStripMenuItem, Me.GastosToolStripMenuItem, Me.CobroToolStripMenuItem, Me.PrecionsToolStripMenuItem, Me.GananciasToolStripMenuItem, Me.TicketToolStripMenuItem, Me.TrabajadoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1080, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem, Me.CreadorToolStripMenuItem})
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.InformacionToolStripMenuItem.Text = "Informacion"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.VersionToolStripMenuItem.Text = "version"
        '
        'CreadorToolStripMenuItem
        '
        Me.CreadorToolStripMenuItem.Name = "CreadorToolStripMenuItem"
        Me.CreadorToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.CreadorToolStripMenuItem.Text = "creador"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeGastosToolStripMenuItem})
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'IngresoDeGastosToolStripMenuItem
        '
        Me.IngresoDeGastosToolStripMenuItem.Name = "IngresoDeGastosToolStripMenuItem"
        Me.IngresoDeGastosToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.IngresoDeGastosToolStripMenuItem.Text = "Ingreso de gastos"
        '
        'CobroToolStripMenuItem
        '
        Me.CobroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaDeCobroToolStripMenuItem})
        Me.CobroToolStripMenuItem.Name = "CobroToolStripMenuItem"
        Me.CobroToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.CobroToolStripMenuItem.Text = "Cobro"
        '
        'SistemaDeCobroToolStripMenuItem
        '
        Me.SistemaDeCobroToolStripMenuItem.Name = "SistemaDeCobroToolStripMenuItem"
        Me.SistemaDeCobroToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SistemaDeCobroToolStripMenuItem.Text = "Sistema de cobro"
        '
        'PrecionsToolStripMenuItem
        '
        Me.PrecionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarPrecionNormalesToolStripMenuItem})
        Me.PrecionsToolStripMenuItem.Name = "PrecionsToolStripMenuItem"
        Me.PrecionsToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.PrecionsToolStripMenuItem.Text = "Precios "
        '
        'IngresarPrecionNormalesToolStripMenuItem
        '
        Me.IngresarPrecionNormalesToolStripMenuItem.Name = "IngresarPrecionNormalesToolStripMenuItem"
        Me.IngresarPrecionNormalesToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.IngresarPrecionNormalesToolStripMenuItem.Text = "Ingresar precion normales"
        '
        'GananciasToolStripMenuItem
        '
        Me.GananciasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem})
        Me.GananciasToolStripMenuItem.Name = "GananciasToolStripMenuItem"
        Me.GananciasToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.GananciasToolStripMenuItem.Text = "Ganancias"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'TicketToolStripMenuItem
        '
        Me.TicketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketsGeneradosToolStripMenuItem})
        Me.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem"
        Me.TicketToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.TicketToolStripMenuItem.Text = "Ticket"
        '
        'TicketsGeneradosToolStripMenuItem
        '
        Me.TicketsGeneradosToolStripMenuItem.Name = "TicketsGeneradosToolStripMenuItem"
        Me.TicketsGeneradosToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TicketsGeneradosToolStripMenuItem.Text = "Tickets generados"
        '
        'TrabajadoresToolStripMenuItem
        '
        Me.TrabajadoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngrsaNuevoTrabajadorToolStripMenuItem})
        Me.TrabajadoresToolStripMenuItem.Name = "TrabajadoresToolStripMenuItem"
        Me.TrabajadoresToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.TrabajadoresToolStripMenuItem.Text = "Trabajadores"
        '
        'IngrsaNuevoTrabajadorToolStripMenuItem
        '
        Me.IngrsaNuevoTrabajadorToolStripMenuItem.Name = "IngrsaNuevoTrabajadorToolStripMenuItem"
        Me.IngrsaNuevoTrabajadorToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.IngrsaNuevoTrabajadorToolStripMenuItem.Text = "Ingrsa nuevo trabajador"
        '
        'Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 457)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.bt_Ingresar)
        Me.Controls.Add(Me.bt_Borrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Precios"
        Me.Text = "Precios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_Borrar As System.Windows.Forms.Button
    Friend WithEvents bt_Ingresar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InformacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoDeGastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CobroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SistemaDeCobroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrecionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarPrecionNormalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GananciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicketsGeneradosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrabajadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngrsaNuevoTrabajadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
