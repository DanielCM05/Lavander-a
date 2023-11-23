Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Conexion
    Protected con As New SqlConnection("Data Source=DESKTOP-MT5EURH;Initial Catalog=LABANDERIA2;Integrated Security=True")

    Public Function conectar() As Boolean
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox("conexion no exitosa")
            Return False
        End Try
    End Function

    Public Sub desconectar()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("No hubo conexion")
        End Try
    End Sub
End Class
