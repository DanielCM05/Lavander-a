Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Gastos
    Dim conexion_gastos As SqlConnection
    Dim insert_gastos As SqlCommand

    Private Sub Gastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion_gastos = New SqlConnection("Data Source=DESKTOP-MT5EURH;Initial Catalog=LABANDERIA2;Integrated Security=True")
        Otro.Visible = False
        Label4.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        Label5.Visible = False
        Button4.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If (TextBox4.Visible = True) Then
                conexion_gastos.Open()
                Dim insertar_gastos2_com As String = "INSERT INTO GASTOS(FECHA,AGUA,LUZ,RENTA,OTROS,DESCRIPCIO) VALUES ('" & TextBox_año.Text & "/" & TextBox_mes.Text & "/" & TextBox_dia.Text & "'," & TextBox1.Text & "," & TextBox2.Text & "," &
                              TextBox3.Text & "," & TextBox4.Text & ",'" & TextBox5.Text & "')"
                insert_gastos = New SqlCommand(insertar_gastos2_com, conexion_gastos)
                insert_gastos.ExecuteNonQuery()
                MsgBox("Los gastos se ingresaron1")
                conexion_gastos.Close()
            Else
                conexion_gastos.Open()
                Dim insertar_gastos_com As String = "INSERT INTO GASTOS(FECHA,AGUA,LUZ,RENTA) VALUES ('" & TextBox_año.Text & "/" & TextBox_mes.Text & "/" & TextBox_dia.Text & "'," & TextBox1.Text & "," & TextBox2.Text & "," &
                                   TextBox3.Text & ")"
                insert_gastos = New SqlCommand(insertar_gastos_com, conexion_gastos)
                insert_gastos.ExecuteNonQuery()
                MsgBox("Los gastos se ingresaron2")
                conexion_gastos.Close()


            End If
        Catch ex As Exception
            MsgBox("Los gastos no fueron ingresados")
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Otro.Visible = True
        Label4.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        Label5.Visible = True
        Button3.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Otro.Visible = False
        Label4.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        Label5.Visible = False
        Button3.Visible = True
        Button4.Visible = False
    End Sub

   
    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        Usuario.Show()
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

    Private Sub IngrsaNuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngrsaNuevoTrabajadorToolStripMenuItem.Click
        Me.Hide()
        Trabajadores.Show()
    End Sub
End Class