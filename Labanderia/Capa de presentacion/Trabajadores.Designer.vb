<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trabajadores
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_nom = New System.Windows.Forms.TextBox()
        Me.TextBox_pais = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_numd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_calle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_am = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_ap = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox_edo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_usu = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_contra = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_id = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(386, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresa nuevos ususarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(442, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'TextBox_nom
        '
        Me.TextBox_nom.Location = New System.Drawing.Point(534, 132)
        Me.TextBox_nom.Name = "TextBox_nom"
        Me.TextBox_nom.Size = New System.Drawing.Size(331, 20)
        Me.TextBox_nom.TabIndex = 2
        '
        'TextBox_pais
        '
        Me.TextBox_pais.Location = New System.Drawing.Point(534, 337)
        Me.TextBox_pais.Name = "TextBox_pais"
        Me.TextBox_pais.Size = New System.Drawing.Size(331, 20)
        Me.TextBox_pais.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pais:"
        '
        'TextBox_numd
        '
        Me.TextBox_numd.Location = New System.Drawing.Point(534, 291)
        Me.TextBox_numd.Name = "TextBox_numd"
        Me.TextBox_numd.Size = New System.Drawing.Size(331, 20)
        Me.TextBox_numd.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(421, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Numero del domicilio:"
        '
        'TextBox_calle
        '
        Me.TextBox_calle.Location = New System.Drawing.Point(534, 253)
        Me.TextBox_calle.Name = "TextBox_calle"
        Me.TextBox_calle.Size = New System.Drawing.Size(331, 20)
        Me.TextBox_calle.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(442, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Calle:"
        '
        'TextBox_am
        '
        Me.TextBox_am.Location = New System.Drawing.Point(534, 210)
        Me.TextBox_am.Name = "TextBox_am"
        Me.TextBox_am.Size = New System.Drawing.Size(331, 20)
        Me.TextBox_am.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(442, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Apellido Materno:"
        '
        'TextBox_ap
        '
        Me.TextBox_ap.Location = New System.Drawing.Point(534, 167)
        Me.TextBox_ap.Name = "TextBox_ap"
        Me.TextBox_ap.Size = New System.Drawing.Size(331, 20)
        Me.TextBox_ap.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Apellido Paterno:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Labanderia.My.Resources.Resources._1467646262_522853_1467646344_noticia_normal
        Me.PictureBox1.Location = New System.Drawing.Point(156, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'TextBox_edo
        '
        Me.TextBox_edo.Location = New System.Drawing.Point(534, 376)
        Me.TextBox_edo.Name = "TextBox_edo"
        Me.TextBox_edo.Size = New System.Drawing.Size(331, 20)
        Me.TextBox_edo.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(442, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Estado:"
        '
        'TextBox_usu
        '
        Me.TextBox_usu.Location = New System.Drawing.Point(534, 422)
        Me.TextBox_usu.Name = "TextBox_usu"
        Me.TextBox_usu.Size = New System.Drawing.Size(331, 20)
        Me.TextBox_usu.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(442, 429)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Usuario:"
        '
        'TextBox_contra
        '
        Me.TextBox_contra.Location = New System.Drawing.Point(534, 469)
        Me.TextBox_contra.Name = "TextBox_contra"
        Me.TextBox_contra.Size = New System.Drawing.Size(331, 20)
        Me.TextBox_contra.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(442, 476)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Contraseña:"
        '
        'TextBox_id
        '
        Me.TextBox_id.Location = New System.Drawing.Point(534, 94)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.Size = New System.Drawing.Size(331, 20)
        Me.TextBox_id.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(442, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionToolStripMenuItem, Me.SalirToolStripMenuItem, Me.GastosToolStripMenuItem, Me.CobroToolStripMenuItem, Me.PrecionsToolStripMenuItem, Me.GananciasToolStripMenuItem, Me.TicketToolStripMenuItem, Me.TrabajadoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1210, 24)
        Me.MenuStrip1.TabIndex = 23
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(914, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Ingresar este trrabajador"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(914, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Trabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 627)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox_id)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox_contra)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox_edo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox_usu)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox_ap)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_am)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_calle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_numd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_pais)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Trabajadores"
        Me.Text = "Trabajadores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_nom As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_pais As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_numd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_calle As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_am As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_ap As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_edo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox_usu As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox_contra As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox_id As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
