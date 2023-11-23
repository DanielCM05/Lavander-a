Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class D_TRABAJADORES
    Inherits Conexion

    Private NOMBRE As String
    Private A_P As String
    Private A_M As String
    Private CALLE As String
    Private NUMERO_DOMICILIO As String
    Private PAIS As String
    Private ESTADO As String
    Private USUSARIO As String
    Private CONTRASENA As String
    Private ID_TRBAJADOR As String

    Private cmd As SqlCommand

    Public Sub New(ap As String, am As String, nom As String, ca As String, nd As String, pa As String, edo As String, usu As String, contra As String, idt As String)
        NOMBRE = nom
        A_P = ap
        A_M = am
        CALLE = ca
        NUMERO_DOMICILIO = nd
        PAIS = pa
        ESTADO = edo
        USUSARIO = usu
        CONTRASENA = contra
        ID_TRBAJADOR = idt
    End Sub

    Public Sub New()


    End Sub
    Public Property Nombretrabajador As String
        Get
            Return NOMBRE
        End Get
        Set(value As String)
            NOMBRE = value
        End Set

    End Property
    Public Property ApellidoPtrabajador As String
        Get
            Return A_P
        End Get
        Set(value As String)
            A_P = value
        End Set

    End Property
    Public Property ApellidoMtrabajador As String
        Get
            Return A_M
        End Get
        Set(value As String)
            A_M = value
        End Set

    End Property
    Public Property Calletrabajador As String
        Get
            Return CALLE
        End Get
        Set(value As String)
            CALLE = value
        End Set

    End Property
    Public Property Numerodtrabajador As String
        Get
            Return NUMERO_DOMICILIO
        End Get
        Set(value As String)
            NUMERO_DOMICILIO = value
        End Set

    End Property
    Public Property Paistrabajador As String
        Get
            Return PAIS
        End Get
        Set(value As String)
            PAIS = value
        End Set

    End Property
    Public Property Estadotrabajador As String
        Get
            Return ESTADO
        End Get
        Set(value As String)
            ESTADO = value
        End Set

    End Property
    Public Property Usuariotrabajador As String
        Get
            Return USUSARIO
        End Get
        Set(value As String)
            USUSARIO = value
        End Set

    End Property
    Public Property Contrasenatrabajador As String
        Get
            Return CONTRASENA
        End Get
        Set(value As String)
            CONTRASENA = value
        End Set

    End Property
    Public Property IDtrabajador As String
        Get
            Return ID_TRBAJADOR
        End Get
        Set(value As String)
            ID_TRBAJADOR = value
        End Set

    End Property
    Public Function insertartrabajadores(dt As D_TRABAJADORES) As Boolean
        Try
            conectar()

            Dim sql As String = "INSERT INTO TRABAJADORES(NOMBRE, A_P, A_M, CALLE, NUMERO_DOMICILIO, PAIS, ESTADO,USUSARIO, CONTRASENA, ID_TRBAJADOR)VALUES('" & dt.NOMBRE & "','" &
                dt.A_P & "','" & dt.A_M & "','" & dt.CALLE & "','" & dt.NUMERO_DOMICILIO & "','" & dt.PAIS & "','" & dt.ESTADO & "','" & dt.USUSARIO & "','" &
                dt.CONTRASENA & "','" & dt.ID_TRBAJADOR & ")"



            cmd = New SqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("No se ingreso en la base")
            Return False
        Finally
            desconectar()
        End Try

    End Function
End Class
