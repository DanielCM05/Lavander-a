<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelU_1 = New System.Windows.Forms.Label()
        Me.LabelU_2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonU_2 = New System.Windows.Forms.Button()
        Me.ButtonU_1 = New System.Windows.Forms.Button()
        Me.LinkLabelU_1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(379, 191)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(379, 306)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(360, 20)
        Me.TextBox2.TabIndex = 1
        '
        'LabelU_1
        '
        Me.LabelU_1.AutoSize = True
        Me.LabelU_1.Location = New System.Drawing.Point(379, 172)
        Me.LabelU_1.Name = "LabelU_1"
        Me.LabelU_1.Size = New System.Drawing.Size(43, 13)
        Me.LabelU_1.TabIndex = 2
        Me.LabelU_1.Text = "Usuario"
        '
        'LabelU_2
        '
        Me.LabelU_2.AutoSize = True
        Me.LabelU_2.Location = New System.Drawing.Point(379, 290)
        Me.LabelU_2.Name = "LabelU_2"
        Me.LabelU_2.Size = New System.Drawing.Size(61, 13)
        Me.LabelU_2.TabIndex = 3
        Me.LabelU_2.Text = "Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Labanderia.My.Resources.Resources.Captura_de_pantalla_2023_05_11_170829
        Me.PictureBox1.Location = New System.Drawing.Point(379, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ButtonU_2
        '
        Me.ButtonU_2.Location = New System.Drawing.Point(664, 362)
        Me.ButtonU_2.Name = "ButtonU_2"
        Me.ButtonU_2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonU_2.TabIndex = 5
        Me.ButtonU_2.Text = "Salir"
        Me.ButtonU_2.UseVisualStyleBackColor = True
        '
        'ButtonU_1
        '
        Me.ButtonU_1.Location = New System.Drawing.Point(379, 362)
        Me.ButtonU_1.Name = "ButtonU_1"
        Me.ButtonU_1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonU_1.TabIndex = 6
        Me.ButtonU_1.Text = "Ingresar"
        Me.ButtonU_1.UseVisualStyleBackColor = True
        '
        'LinkLabelU_1
        '
        Me.LinkLabelU_1.AutoSize = True
        Me.LinkLabelU_1.Location = New System.Drawing.Point(804, 313)
        Me.LinkLabelU_1.Name = "LinkLabelU_1"
        Me.LinkLabelU_1.Size = New System.Drawing.Size(134, 13)
        Me.LinkLabelU_1.TabIndex = 7
        Me.LinkLabelU_1.TabStop = True
        Me.LinkLabelU_1.Text = "Registrar un nuevo usuario"
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1105, 425)
        Me.Controls.Add(Me.LinkLabelU_1)
        Me.Controls.Add(Me.ButtonU_1)
        Me.Controls.Add(Me.ButtonU_2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelU_2)
        Me.Controls.Add(Me.LabelU_1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LabelU_1 As System.Windows.Forms.Label
    Friend WithEvents LabelU_2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonU_2 As System.Windows.Forms.Button
    Friend WithEvents ButtonU_1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabelU_1 As System.Windows.Forms.LinkLabel

End Class
