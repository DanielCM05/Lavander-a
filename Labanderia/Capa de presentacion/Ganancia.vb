Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Ganancia
    Dim CONEXION_GANANCIA As SqlConnection
    Dim COMANDO As SqlCommand

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            CONEXION_GANANCIA.Open()
            Dim INSERT As String = "SELECT(SELECT SUM(suma_ticket) FROM (SELECT SUM(DISTINCT TICKET.TOTAL) AS suma_ticket FROM TICKET  WHERE YEAR(TICKET.Fecha_HORA) =" & año2.Text & " AND MONTH(TICKET.Fecha_HORA) = " & mes.Text & " GROUP BY ID_TICKET) AS subquery)-(SELECT SUM(suma_gastos) FROM (SELECT SUM(GASTOS.AGUA) + SUM(GASTOS.LUZ) + SUM(GASTOS.RENTA) + SUM(GASTOS.OTROS) AS suma_gastos FROM GASTOS WHERE YEAR(GASTOS.FECHA) = " & año2.Text & "AND MONTH(GASTOS.FECHA) = " & mes.Text & ") AS SUBQUERY2)   AS Resta;"

            Dim COMANDO2 As New SqlCommand(INSERT, CONEXION_GANANCIA)
            Dim RESULTADO As Object = COMANDO2.ExecuteScalar()
            Dim resultado2 As String = RESULTADO.ToString()

            TextBox1.Text = resultado2
    


            CONEXION_GANANCIA.Close()
        Catch ex As Exception
            MsgBox("ERROR " & ex.Message)
            CONEXION_GANANCIA.Close()
        End Try
    End Sub

    Private Sub Ganancia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONEXION_GANANCIA = New SqlConnection("Data Source=DESKTOP-MT5EURH;Initial Catalog=LABANDERIA2;Integrated Security=True")
    End Sub

    Private Sub IngrsaNuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngrsaNuevoTrabajadorToolStripMenuItem.Click
        Me.Hide()
        Trabajadores.Show()
    End Sub

    Private Sub TicketsGeneradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketsGeneradosToolStripMenuItem.Click
        Me.Hide()
        Ticket.Show()
    End Sub

    Private Sub IngresarPrecionNormalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPrecionNormalesToolStripMenuItem.Click
        Me.Hide()
        Precios.Show()
    End Sub

    Private Sub SistemaDeCobroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SistemaDeCobroToolStripMenuItem.Click
        Me.Hide()
        Cobro.Show()
    End Sub

    Private Sub IngresoDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeGastosToolStripMenuItem.Click
        Me.Hide()
        Gastos.Show()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        Usuario.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub
End Class