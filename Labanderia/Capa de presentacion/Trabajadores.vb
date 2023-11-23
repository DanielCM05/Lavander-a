Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Trabajadores
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexion.Open()
            Dim incert As String = "INSERT INTO TRABAJADORES(NOMBRE, A_P, A_M, CALLE, NUMERO_DOMICILIO, PAIS, ESTADO,USUSARIO, CONTRASENA, ID_TRBAJADOR)VALUES('" & TextBox_nom.Text & "','" &
                   TextBox_ap.Text & "','" & TextBox_am.Text & "','" & TextBox_calle.Text & "','" & TextBox_numd.Text & "','" & TextBox_pais.Text & "','" & TextBox_edo.Text & "','" & TextBox_usu.Text & "','" &
                  TextBox_contra.Text & "','" & TextBox_id.Text & "')"
            comando = New SqlCommand(incert, conexion)
            comando.ExecuteNonQuery()
            MsgBox("Los datos fueron ingresados")
            conexion.Close()
        Catch ex As Exception
            MsgBox("No se pudo ingresar ERROR EN LA PRESENTACION")
        End Try

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub Trabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection("Data Source=DESKTOP-MT5EURH;Initial Catalog=LABANDERIA2;Integrated Security=True")
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        Usuario.Show()
    End Sub

    Private Sub IngresoDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeGastosToolStripMenuItem.Click
        Me.Hide()
        Gastos.Show()
    End Sub
    Private Sub SistemaDeCobroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SistemaDeCobroToolStripMenuItem.Click
        Me.Hide()
        Cobro.Show()
    End Sub

    Private Sub IngresarPrecionNormalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPrecionNormalesToolStripMenuItem.Click
        Me.Hide()
        Precios.Show()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        Me.Hide()
        Ganancia.Show()
    End Sub

    Private Sub TicketsGeneradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketsGeneradosToolStripMenuItem.Click
        Me.Hide()
        Ticket.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox_nom.Text = ""
        TextBox_ap.Text = ""
        TextBox_am.Text = ""
        TextBox_calle.Text = ""
        TextBox_numd.Text = ""
        TextBox_pais.Text = ""
        TextBox_edo.Text = ""
        TextBox_usu.Text = ""
        TextBox_contra.Text = ""
        TextBox_id.Text = ""
    End Sub
End Class