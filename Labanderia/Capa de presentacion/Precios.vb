Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Precios
    Dim conexion_pre As SqlConnection
    Dim ingresa_precio As String
    Dim insert As SqlCommand
    Dim dinero As Char = "$"
    Private Sub bt_Borrar_Click(sender As Object, e As EventArgs) Handles bt_Borrar.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion_pre = New SqlConnection("Data Source=DESKTOP-MT5EURH;Initial Catalog=LABANDERIA2;Integrated Security=True")
    End Sub

    Private Sub bt_Ingresar_Click(sender As Object, e As EventArgs) Handles bt_Ingresar.Click
        Try
            conexion_pre.Open()
            ingresa_precio = "INSERT INTO productos(DESCRIPCION,PRECIO)VALUES('" & TextBox1.Text & "'," & TextBox2.Text & ")"
            insert = New SqlCommand(ingresa_precio, conexion_pre)
            insert.ExecuteNonQuery()
            MsgBox("Los datos se subieron a la base de datos ")
            conexion_pre.Close()
        Catch ex As Exception
            MsgBox("No se pudo ingresar nada ")
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        Usuario.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub IngresoDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeGastosToolStripMenuItem.Click
        Me.Hide()
        Gastos.Show()
    End Sub

    Private Sub SistemaDeCobroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SistemaDeCobroToolStripMenuItem.Click
        Me.Hide()
        Cobro.Show()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        Me.Hide()
        Ganancia.Show()
    End Sub

    Private Sub TicketsGeneradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketsGeneradosToolStripMenuItem.Click
        Me.Hide()
        Ticket.Show()
    End Sub

    Private Sub IngrsaNuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngrsaNuevoTrabajadorToolStripMenuItem.Click
        Me.Hide()
        Trabajadores.Show()
    End Sub
End Class