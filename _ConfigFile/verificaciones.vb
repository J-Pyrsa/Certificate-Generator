Imports System.IO

Public Class verificaciones

    ''' <summary>
    ''' Verifica si existe un archivo o directorio
    ''' </summary>
    ''' <param name="ruta">Por ejemplo; C:\test, o bien C:\test.txt</param>
    ''' <param name="tipo">Valores aceptados son Dir, Archivo.</param>
    ''' <returns></returns>
    ''' <remarks>Otros valores regresarán "FALSe"</remarks>
    Function VerificaRuta(ruta As String, tipo As String) As Boolean
        tipo = tipo.ToUpper
       

        If tipo = "DIR" Then
            If Directory.Exists(ruta) Then
                Return True
            End If
            Return False
        End If
        If tipo = "ARCHIVO" Then
            If File.Exists(ruta) Then
                Return True
            End If
            Return False
        End If
        Return False
    End Function




End Class
