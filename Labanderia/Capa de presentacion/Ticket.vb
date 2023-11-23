Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Ticket
    Dim conexion_ticket As SqlConnection
    Dim comando As SqlDataAdapter
    Dim comando2 As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim leer As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexion_ticket.Open()
            Dim consulta As String = "select fecha_hora from TICKET where ID_TICKET=" & TextBox1.Text
            Dim comando As New SqlCommand(consulta, conexion_ticket)
            Dim resultado As Object = comando.ExecuteScalar()
            TextBox_fecha.Text = resultado.ToString()
            conexion_ticket.Close()




            conexion_ticket.Open()

            Dim consulta2 As String = "select ID_TICKET from TICKET where ID_TICKET=" & TextBox1.Text
            Dim comando2 As New SqlCommand(consulta2, conexion_ticket)
            Dim resultado2 As Object = comando2.ExecuteScalar()
            TextBox_ID.Text = resultado2.ToString()

            conexion_ticket.Close()
            conexion_ticket.Open()
            Dim consulta3 As String = "select TOTAL from TICKET where ID_TICKET=" & TextBox1.Text
            Dim comando3 As New SqlCommand(consulta3, conexion_ticket)
            Dim resultado3 As Object = comando3.ExecuteScalar()
            TextBox_to.Text = resultado3.ToString()
            conexion_ticket.Close()



            conexion_ticket.Open()
            Dim consulta4 As String = "select PRODUCTOS from TICKET where ID_TICKET=" & TextBox1.Text

            Using conexion_ticket As New SqlConnection("Data Source=DESKTOP-MT5EURH;Initial Catalog=LABANDERIA2;Integrated Security=True")
                Dim dataTable As New DataTable()

                Using adapter As New SqlDataAdapter(consulta4, conexion_ticket)
                    adapter.Fill(dataTable)
                End Using

                DataGridView1.DataSource = dataTable
            End Using


            conexion_ticket.Close()

            conexion_ticket.Open()
            Dim consulta5 As String = "select ID_TRABAJADOR from TICKET where ID_TICKET=" & TextBox1.Text
            Dim comando5 As New SqlCommand(consulta5, conexion_ticket)
            Dim resultado5 As Object = comando5.ExecuteScalar()
            TextBox_idtrabajador.Text = resultado5.ToString()

            conexion_ticket.Close()


            conexion_ticket.Close()

            conexion_ticket.Open()
            Dim consulta6 As String = "select TRABAJADOR from TICKET where ID_TICKET=" & TextBox1.Text
            Dim comando6 As New SqlCommand(consulta6, conexion_ticket)
            Dim resultado6 As Object = comando6.ExecuteScalar()
            TextBox_trabajador.Text = resultado6.ToString()

            conexion_ticket.Close()












        Catch ex As Exception
            MsgBox("Error o no encontrado" & ex.Message)
            conexion_ticket.Close()
        End Try



    End Sub

    Private Sub Ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_fecha.ReadOnly = True
        TextBox_ID.ReadOnly = True
        DataGridView1.ReadOnly = True
        TextBox_to.ReadOnly = True
        TextBox_trabajador.ReadOnly = True
        TextBox_idtrabajador.ReadOnly = True
        conexion_ticket = New SqlConnection("Data Source=DESKTOP-MT5EURH;Initial Catalog=LABANDERIA2;Integrated Security=True")
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

    Private Sub IngresarPrecionNormalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPrecionNormalesToolStripMenuItem.Click
        Me.Hide()
        Precios.Show()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        Me.Hide()
        Ganancia.Show()
    End Sub

    Private Sub IngrsaNuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngrsaNuevoTrabajadorToolStripMenuItem.Click
        Me.Hide()
        Trabajadores.Show()
    End Sub
End Class