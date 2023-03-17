Imports System.Text
Imports System.IO

Public Class type_tools
    ''' <summary>
    ''' Convertimos un arreglo Byte para pasarlo a Cadena en formato hexcadecimal
    ''' </summary>
    ''' <param name="ba"></param>
    ''' <returns>El texto formateado en formato hexadecimal</returns>

    Public Function ByteArrayToString(ByRef ba As Byte()) As String
        Dim hex As StringBuilder = New StringBuilder(ba.Length * 2)

        For Each b As Byte In ba
            hex.AppendFormat("{0:x2}", b)
        Next
        Return hex.ToString()
    End Function

    Function Byte2XML(ByRef hobjwt As Byte()) As String
        ' http://social.msdn.microsoft.com/Forums/en-US/Vsexpressvcs/thread/b8f7837b-e396-494e-88e1-30547fcf385f/
        Try
            hobjwt = Encoding.Convert(Encoding.GetEncoding("utf-8"), Encoding.Default, hobjwt)
            Dim tempString As String = Encoding.UTF8.GetString(hobjwt, 0, hobjwt.Length)
            Return tempString
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Convertimos de Extadecimal (texto) a caracteres Ascci, esto es para ver las
    ''' configuraciones de HOB que están en binario
    ''' </summary>
    ''' <param name="Data"></param>
    ''' <returns>El texto</returns>
    ''' <remarks>Bug: No respeta los acentos</remarks>
    Public Function Hexadecimal_Ascci(ByRef Data As String) As String

        Dim Data1 As String = ""
        Dim sData As String = ""

        While Data.Length > 0
            Data1 = System.Convert.ToChar(System.Convert.ToUInt32(Data.Substring(0, 2), 16)).ToString()
            sData = sData + Data1
            Data = Data.Substring(2, Data.Length - 2)
        End While
        Return sData
    End Function



End Class


