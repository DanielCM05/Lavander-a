Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Cobro
    Dim conexion_cobro As SqlConnection
    Dim comando_cobro As SqlCommand
    Dim suma As Double = 0
    Dim art1 As Double = 20
    Dim art2 As Double = 40
    Dim art3 As Double = 20
    Dim art4 As Double = 20
    Dim art5 As Double = 5
    Dim art6 As Double = 23
    Dim art7 As Double = 40
    Dim art8 As Double = 10
    Dim art9 As Double = 20
    Dim fechaActual As DateTime = DateTime.Now
    Dim mesActual As Integer = fechaActual.Month.ToString()
    Dim añoActual As Integer = fechaActual.Year.ToString()
    Dim DiaActual As Integer = fechaActual.Day.ToString()

    Dim hora As DateTime = DateTime.Now
    Dim hora2 As Integer = hora.Hour.ToString()
    Dim min As Integer = hora.Minute.ToString()
    Dim ID As String = hora2 & min & mesActual & DiaActual & añoActual




    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        ListBox1.Items.Clear()
        suma = 0
        TextBox1.Text = suma
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add("Labadora y secadora    $40/h")
        suma = suma + art2
        TextBox1.Text = suma
    End Sub


    Private Sub ListBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Control.MousePosition)
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add("Secadora     $20/h")
        suma = suma + art3
        TextBox1.Text = suma
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add("Centrifugadora     $20/h")
        suma = suma + art4
        TextBox1.Text = suma
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Add("Planchado    $5/pza")
        suma = suma + art5
        TextBox1.Text = suma
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Items.Add("Detergente       $23/1k")
        suma = suma + art6
        TextBox1.Text = suma
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Add("Suavisante    $40/1pz")
        suma = suma + art7
        TextBox1.Text = suma
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListBox1.Items.Add("Ganchos de plastico   $10/1pz")
        suma = suma + art8
        TextBox1.Text = suma
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ListBox1.Items.Add("Gancho de metal       $20/1pz")
        suma = suma + art9
        TextBox1.Text = suma
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub IngresarPrecionNormalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPrecionNormalesToolStripMenuItem.Click
        Me.Hide()
        Precios.Show()
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

    Private Sub Cobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        Button1.Text = "Labadora                                           $20/h"
        Button2.Text = "Labadora y secadora                           $40/h"
        Button3.Text = "Secadora                                             $20/h"
        Button4.Text = "Centrifugadora                                       $20/h"
        Button5.Text = "Planchado                                           $5/pza"
        Button6.Text = "Detergente                                          $23/1k"
        Button7.Text = "Suavisante                                         $40/1pz"
        Button8.Text = "Ganchos de plastico                                 $10/pz"
        Button9.Text = "Gancho de metal                                     $20/pz"
        conexion_cobro = New SqlConnection("Data Source=DESKTOP-MT5EURH;Initial Catalog=LABANDERIA2;Integrated Security=True")
        TextBox2.Text = ID
    End Sub

    Private Sub TextBox1_EnabledChanged(sender As Object, e As EventArgs) Handles TextBox1.EnabledChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("Labadora    $20/h")
        suma = suma + art1
        TextBox1.Text = suma
    End Sub


    Private Sub Pagar_Click(sender As Object, e As EventArgs) Handles Pagar.Click
      Try
            For i As Integer = 0 To ListBox1.Items.Count - 1
                conexion_cobro.Open()
                Dim elemento As String = ListBox1.Items(i).ToString()
                Dim elemento2 As String = elemento
                Dim incert As String = "INSERT INTO TICKET (ID_TICKET,PRODUCTOS,TOTAL,FECHA_HORA,TRABAJADOR,ID_TRABAJADOR) VALUES (" & ID &
                  ",'" & elemento & "'," & TextBox1.Text & ",'" & añoActual & "-" & mesActual & "-" & DiaActual & "','L','L');"

                comando_cobro = New SqlCommand(incert, conexion_cobro)
                comando_cobro.ExecuteNonQuery()
                conexion_cobro.Close()
            Next
            MsgBox("EXITOSO")
        Catch ex As Exception
            MsgBox("Transacción no exitosa: " & ex.Message)
            conexion_cobro.Close()
        End Try
    End Sub
End Class