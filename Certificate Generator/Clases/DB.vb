Imports System.Data.OleDb

Public Class DB

    Private _File_Access As String
    Private connDB As OleDbConnection
    Private conString As String
    Sub New(file_access As String, _conString As String)
        _File_Access = file_access
        conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _File_Access
    End Sub


    Dim cmd As OleDb.OleDbCommand
    Public DataSet1 As DataSet

    Public Sub conexion()
        Try

            connDB = New OleDb.OleDbConnection(conString)
            MsgBox("conextado corextamente")
        Catch ea As Exception
            MsgBox(ea.Message)
        End Try
    End Sub

    Public Function insertar(sqlstatement As String) As String
        Try
            connDB = New OleDb.OleDbConnection(conString)
            connDB.Open()
            cmd = New OleDb.OleDbCommand(sqlstatement, connDB)
            cmd.ExecuteNonQuery()
            Return "1"
        Catch ex As Exception
            Return ex.Message
        Finally
            connDB.Close()
        End Try
    End Function

    Public Function CuentaItems(ByRef Consulta As String) As Integer
        Dim Resultado As Integer = 0
        Dim Conexion As OleDbConnection = New OleDbConnection()
        Conexion.ConnectionString = conString
        Conexion.Open()
        REM Abrimos la Conexión/Consulta para obtener los datos del Cliente
        Dim Comando As New OleDbCommand(Consulta, Conexion)
        'Dim Registro As MySqlDataReader = Comando.ExecuteReader
        Dim Registro As OleDbDataReader = Comando.ExecuteReader
        If Registro.Read Then
            Resultado = CInt(Registro("res"))
        End If
        Conexion.Close()
        Return Resultado
    End Function
End Class
