Imports System.Data.OleDb
Imports System.Configuration

Public Class db

    Function sql_insert(ByVal SQLstr As String) As Integer

        Dim Mycn As New OleDbConnection
        Dim Command As OleDbCommand
        Dim icount As Integer
        Try
            'Mycn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\TestInsertDataVB\DataBaseTestInsertVB.mdb;")

            Mycn = New OleDbConnection(ConfigurationManager.ConnectionStrings("CertificateGenerator.My.MySettings.bd1ConnectionString").ConnectionString)
            Mycn.Open()

            'SQLstr = "INSERT INTO Usr ('cn,sn,givenname,mail,Telefono,PassCert,CantidadAnos,FechaEmision,FechaVencimiento') VALUES('')"

            Command = New OleDbCommand(SQLstr, Mycn)
            icount = Command.ExecuteNonQuery
            MsgBox(icount)

        Catch ex As Exception


            MsgBox("could not insert record")
        Finally
            Mycn.Close()
        End Try
        Return 0
    End Function
    Function sqlstatement(ByVal SQLstr As String) As Integer

        Dim Mycn As New OleDbConnection
        Dim Command As OleDbCommand
        Dim icount As Integer
        Try
            Mycn = New OleDbConnection(ConfigurationManager.ConnectionStrings("CertificateGenerator.My.MySettings.bd1ConnectionString").ConnectionString)
            Mycn.Open()
            Command = New OleDbCommand(SQLstr, Mycn)
            icount = Command.ExecuteNonQuery
            MsgBox(icount)
        Catch ex As Exception
            MsgBox("could not insert record")
        Finally
            Mycn.Close()
        End Try
        Return 0
    End Function



End Class
