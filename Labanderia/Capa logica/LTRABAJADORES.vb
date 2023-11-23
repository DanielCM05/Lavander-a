Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class LTRABAJADORES
    Public Function insertartrabajadores(nom As String, ap As String, am As String, ca As String, nd As String, pa As String, edo As String, usu As String, contra As String, idt As String)
        Dim dc As New D_TRABAJADORES(nom, ap, am, ca, nd, pa, edo, usu, contra, idt)
        If dc.insertartrabajadores(dc) = True Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
