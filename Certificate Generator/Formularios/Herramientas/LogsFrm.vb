Imports System.IO
Imports hobtools

Public Class LogsFrm
    Private chm_file As String
    Private _DirDelLog As String
    Private _rastreo As rastreo

    Sub New(DirDelLog As String, _chm_file As String)
        chm_file = _chm_file
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _rastreo = New rastreo
        _DirDelLog = DirDelLog
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        cerrar()
    End Sub

    Private Sub LimpiarVistaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarVistaToolStripMenuItem.Click
        Me.DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        cerrar()
    End Sub
    Sub cerrar()
        Try
            Me.DataGridView1.DataSource = Nothing
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            _rastreo.ErrorLog(_DirDelLog, "Error al tratar de cerrar la ventana " & Me.Text & ". Mensaje: " & ex.Message, "error", True)
        End Try
    End Sub

    Private Sub LogsFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            dt = ListadoArchivos()

            Dim logfile As String = String.Empty
            Dim TextLine As String = ""
            Dim SplitLine() As String
            Dim f As Date
            Dim g As String
            Dim h As String

            For dd As Integer = 0 To dt.Rows.Count - 1
                'MsgBox(dt.Rows(dd).Item("name"))
                Try
                    logfile = dt.Rows(dd).Item("fullpath")
                    If File.Exists(logfile) = True Then
                        'Dim s As Integer = DataGridView1.Rows.Count
                        'If s >= 2 Then
                        '    DataGridView1.Rows.Clear()
                        'End If
                        Dim objReader As New StreamReader(logfile, System.Text.Encoding.UTF8)
                        Try
                            Do While objReader.Peek() <> -1
                                TextLine = objReader.ReadLine()
                                SplitLine = Split(TextLine, ",")
                                f = SplitLine(0) ' fecha / hora
                                g = SplitLine(1) ' Accion
                                h = SplitLine(2) ' Comentario

                                Me.DataGridView1.Rows.Add(SplitLine)
                                'Habilitamos los complementos
                                Me.DataGridView1.Visible = True
                            Loop
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            objReader.Close()
                        End Try
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            _rastreo.ErrorLog(_DirDelLog, "Error al cargar la ventana " & Me.Text & ". Mensaje: " & ex.Message, "error", True)
        End Try
    End Sub

    Function ListadoArchivos() As DataTable
        Dim dt As New DataTable

        dt.Columns.Add("name")
        dt.Columns.Add("fullpath")

        Try
            ' recorrer los ficheros en la colección   
            Dim r As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\HOB\Certificate Generator\Logs"
            Dim a() As String = Directory.GetFiles(r, "*.txt", SearchOption.TopDirectoryOnly)

            For Each sFichero As String In Directory.GetFiles(r, "*.txt", SearchOption.TopDirectoryOnly)

                ' Crear nuevo objeto FileInfo   
                Dim Archivo As New FileInfo(sFichero)
                ' Crear nuevo objeto ListViewItem   
                Dim reg As DataRow = dt.NewRow()
                reg("name") = Archivo.Name.ToString
                reg("fullpath") = Archivo.FullName
                ' cargar los datos y las propiedades   
                dt.Rows.Add(reg)
                dt.AcceptChanges()
            Next
            dt.Select("", "name ASC")
            Return dt
            ' errores   
        Catch ex As Exception
            'Debug.Print(ex.Message.ToString)
            _rastreo.ErrorLog(_DirDelLog, "Error al Listar el log " & Me.Text & ". Mensaje: " & ex.Message, "error", True)
            Beep()
        End Try


        Return Nothing
    End Function

    Private Sub AyudaBtn_Click(sender As System.Object, e As System.EventArgs) Handles AyudaBtn.Click
        Try
            Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "31")
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & " desde " & Me.Text & " el elemento " & AyudaBtn.Text & ". Mensaje: " & ex.Message, "error", True)
        End Try
    End Sub
End Class