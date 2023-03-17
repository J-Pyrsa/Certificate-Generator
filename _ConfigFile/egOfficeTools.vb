Imports System.IO
Imports Microsoft.Office.Interop

Public Class egOfficeTools
    Private _DirDelLog As String
    Private _rastreo As rastreo
    Sub New(ByVal DirDelLog As String)
        _DirDelLog = DirDelLog
        _rastreo = New rastreo
    End Sub


    Public Sub DataTableToExcel(ByVal pDataTable As DataTable, excel_filename As String, auto As Boolean)
        Try
            Dim vFileName As String = Path.GetTempFileName()

            FileOpen(1, vFileName, OpenMode.Output)

            Dim sb As String = String.Empty
            Dim dc As DataColumn
            For Each dc In pDataTable.Columns
                sb &= dc.Caption & Microsoft.VisualBasic.ControlChars.Tab
            Next
            PrintLine(1, sb)

            Dim i As Integer = 0
            Dim dr As DataRow
            For Each dr In pDataTable.Rows
                i = 0 : sb = ""
                For Each dc In pDataTable.Columns
                    If Not IsDBNull(dr(i)) Then
                        sb &= CStr(dr(i)) & Microsoft.VisualBasic.ControlChars.Tab
                    Else
                        sb &= Microsoft.VisualBasic.ControlChars.Tab
                    End If
                    i += 1
                Next

                PrintLine(1, sb)
            Next

            FileClose(1)
            TextToExcel(vFileName, excel_filename, False)

        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, ex.Source, "error", True)
            _rastreo.ErrorLog(_DirDelLog, ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub TextToExcel(ByVal pFileName As String, ByVal excel_filename As String, auto As Boolean)
        Try
            Dim valor As Integer
            Dim vFormato As Excel.XlRangeAutoFormat

            Dim vCultura As System.Globalization.CultureInfo = _
            System.Threading.Thread.CurrentThread.CurrentCulture

            'Es importante definirle la cultura al sistema
            'ya que podria generar errores
            System.Threading.Thread.CurrentThread.CurrentCulture = _
            System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

            Dim Exc As Excel.Application = New Excel.Application
            Exc.Workbooks.OpenText(pFileName, , , , _
            Excel.XlTextQualifier.xlTextQualifierNone, , True)

            Dim Wb As Excel.Workbook = Exc.ActiveWorkbook
            Dim Ws As Excel.Worksheet = Wb.ActiveSheet


            vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatSimple
            'En el ejemplo vienen otros formatos posibles

            Ws.Range(Ws.Cells(1, 1), _
            Ws.Cells(Ws.UsedRange.Rows.Count, _
            Ws.UsedRange.Columns.Count)).AutoFormat(vFormato)

            pFileName = excel_filename
            File.Delete(pFileName)


            Exc.ActiveWorkbook.SaveAs(pFileName, _
            Excel.XlTextQualifier.xlTextQualifierNone - 1)

            Exc.Quit()

            Ws = Nothing
            Wb = Nothing
            Exc = Nothing

            GC.Collect()
            If auto = True Then
                If valor > -1 Then
                    Dim p As New System.Diagnostics.Process
                    p.EnableRaisingEvents = False
                    Process.Start("excel.exe", pFileName)
                End If
            Else

            End If
            System.Threading.Thread.CurrentThread.CurrentCulture = vCultura
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, ex.Source, "error", True)
            _rastreo.ErrorLog(_DirDelLog, ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
