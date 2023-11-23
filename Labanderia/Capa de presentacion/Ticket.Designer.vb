<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket
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
        Me.TextBox_fecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_to = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_trabajador = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_idtrabajador = New System.Windows.Forms.TextBox()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_fecha
        '
        Me.TextBox_fecha.Location = New System.Drawing.Point(437, 85)
        Me.TextBox_fecha.Name = "TextBox_fecha"
        Me.TextBox_fecha.Size = New System.Drawing.Size(207, 20)
        Me.TextBox_fecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hora y Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(434, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Productos y subtotal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(434, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total"
        '
        'TextBox_to
        '
        Me.TextBox_to.Location = New System.Drawing.Point(437, 316)
        Me.TextBox_to.Name = "TextBox_to"
        Me.TextBox_to.Size = New System.Drawing.Size(207, 20)
        Me.TextBox_to.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ID"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Location = New System.Drawing.Point(437, 364)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(207, 20)
        Me.TextBox_ID.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(434, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Atendida por"
        '
        'TextBox_trabajador
        '
        Me.TextBox_trabajador.Location = New System.Drawing.Point(437, 412)
        Me.TextBox_trabajador.Name = "TextBox_trabajador"
        Me.TextBox_trabajador.Size = New System.Drawing.Size(207, 20)
        Me.TextBox_trabajador.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(434, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "ID del personal que atendio"
        '
        'TextBox_idtrabajador
        '
        Me.TextBox_idtrabajador.Location = New System.Drawing.Point(437, 448)
        Me.TextBox_idtrabajador.Name = "TextBox_idtrabajador"
        Me.TextBox_idtrabajador.Size = New System.Drawing.Size(207, 20)
        Me.TextBox_idtrabajador.TabIndex = 18
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionToolStripMenuItem, Me.SalirToolStripMenuItem, Me.GastosToolStripMenuItem, Me.CobroToolStripMenuItem, Me.PrecionsToolStripMenuItem, Me.GananciasToolStripMenuItem, Me.TicketToolStripMenuItem, Me.TrabajadoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1115, 24)
        Me.MenuStrip1.TabIndex = 20
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
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
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
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Coloca aqui el id del ticket"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(437, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(197, 174)
        Me.DataGridView1.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 193)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 24
        '
        'Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 499)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_idtrabajador)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_trabajador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_to)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_fecha)
        Me.Name = "Ticket"
        Me.Text = "Ticket"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_to As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_trabajador As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_idtrabajador As System.Windows.Forms.TextBox
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
