Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Usuario
    Dim usuario As String
    Dim contrasena As String
    Dim conexion_usu As SqlConnection
    Dim comando_usu As SqlDataAdapter
    Dim comando2_usu As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion_usu = New SqlConnection("Data Source=DESKTOP-MT5EURH;Initial Catalog=LABANDERIA2;Integrated Security=True")
        Dim salida As String = "Conectado"
    End Sub

    Private Sub ButtonU_2_Click(sender As Object, e As EventArgs) Handles ButtonU_2.Click
        End
    End Sub

    Private Sub ButtonU_1_Click(sender As Object, e As EventArgs) Handles ButtonU_1.Click
        Dim RESULTADO As Boolean = False
        Try
            conexion_usu.Open()
            cmd = New SqlCommand("SELECT CONTRASENA FROM TRABAJADORES where USUSARIO='" & TextBox1.Text & "'", conexion_usu)
            dr = cmd.ExecuteReader
            If dr.Read Then
                contrasena = dr.Item("Contrasena").ToString
                Me.Hide()
                Cobro.Show()
            End If
            dr.Close()
            conexion_usu.Close()

        Catch ex As Exception
            MsgBox("El usuario o la contraseña no son correctas")
        End Try
    End Sub


End Class


