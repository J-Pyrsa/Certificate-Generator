Imports System.IO

Public Class tools

    '______________________________________________[ header ]__
    ' Cerro Scripts:   OctetString.vbs
    '
    ' Copyright (c) 2007 Philipp Föckeler (www.selfadsi.de)
    '
    ' Collection of useful vbscript functions to handle LDAP
    ' attributes of typ "Octet-String"

    ''' <summary>
    ''' Function to convert OctetString (byte array) to a hexadecimal string
    ''' </summary>
    ''' <param name="var_octet"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Function OctetToHexStr(var_octet)
        Dim n

        OctetToHexStr = ""

        For n = 1 To Len(var_octet)
            OctetToHexStr = OctetToHexStr & Right("0" & Hex(Asc(Mid(var_octet, n, 1))), 2)
        Next
    End Function

    ''' <summary>
    ''' Function to convert hex string to an OctetString (byte array).
    ''' </summary>
    ''' <param name="var_hex"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function HexStrToOctet(var_hex As String)
        Dim fso, stream, temp, ts, n

        fso = CreateObject("Scripting.Filesystemobject")
        stream = CreateObject("ADOdb.Stream")

        temp = fso.gettempname()
        ts = fso.createtextfile(temp)

        For n = 1 To (Len(var_hex) - 1) Step 2
            ts.write(Chr("&H" & Mid(var_hex, n, 2)))
        Next

        ts.close()

        stream.type = 1
        stream.open()
        stream.loadfromfile(temp)

        HexStrToOctet = stream.read

        stream.close()
        fso.deletefile(temp)
        stream = Nothing
        fso = Nothing
    End Function

    ''' <summary>
    ''' Function to convert hex string to ascii string.
    ''' If "format" is TRUE, then tabs and crlfs will be inserted
    ''' </summary>
    ''' <param name="var_hex"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function HexStrToAscii(var_hex, format)
        Dim k, v

        HexStrToAscii = ""

        For k = 1 To Len(var_hex) Step 2

            v = CInt("&H" & Mid(var_hex, k, 2))

            If ((v > 31) And (v < 128)) Then
                HexStrToAscii = HexStrToAscii & (Chr(v))
            Else
                If (format) Then
                    Select Case v
                        Case 8
                            HexStrToAscii = HexStrToAscii & vbTab
                        Case 10
                            HexStrToAscii = HexStrToAscii & vbCrLf
                        Case 13
                        Case Else
                            HexStrToAscii = HexStrToAscii & "."
                    End Select
                Else
                    HexStrToAscii = HexStrToAscii & "."
                End If
            End If
        Next
    End Function


    ''' <summary>
    ''' Function to convert an ascii to a string to hex string.
    ''' </summary>
    ''' <param name="var_string"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function AsciiToHexStr(var_string)
        Dim k

        AsciiToHexStr = ""
        For k = 1 To Len(var_string)
            AsciiToHexStr = AsciiToHexStr + Hex(Asc(Mid(var_string, k, 1)))
        Next
    End Function

    ''' <summary>
    ''' Returns an formatted print out of a hex string. Hex + Dec are displayed.
    ''' The width parameter determines how many bytes are displayed per line.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    

    Function LeeArchivo(archivo As String) As String
        Try
            Dim SPath As String = archivo
            Dim sContent As String = vbNullString

            With My.Computer.FileSystem
                ' verifica si existe el path   
                If .FileExists(SPath) Then
                    ' lee todo el contenido   
                    sContent = .ReadAllText(SPath)
                    MsgBox(sContent.ToString, MsgBoxStyle.Information, "Datos")
                    Return sContent
                Else
                    MsgBox("ruta inválida", MsgBoxStyle.Critical, "error")
                    Return "error"
                End If
            End With
            ' errores   
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function

    Function ReadBinaryFile(ByVal fileName As String) As Byte()

        ' Si no existe el archivo, abandono la función.
        '
        If Not System.IO.File.Exists(fileName) Then Return Nothing

        Try
            ' Creamos un objeto Stream para poder leer el archivo especificado.
            '
            Dim fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)
            ' Creamos un array de bytes, cuyo límite superior se corresponderá
            ' con la longitud en bytes de la secuencia.
            Dim data() As Byte = New Byte(Convert.ToInt32(fs.Length)) {}
            ' Al leer la secuencia, se rellenará la matriz.
            fs.Read(data, 0, Convert.ToInt32(fs.Length))
            ' Cerramos la secuencia.
            fs.Close()
            ' Devolvemos el array de bytes.
            Return data
        Catch ex As Exception
            ' Cualquier excepción producida, hace que la
            ' función devuelva el valor Nothing.
            Return Nothing
        End Try
    End Function
End Class
