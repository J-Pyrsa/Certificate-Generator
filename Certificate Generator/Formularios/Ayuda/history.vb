Public Class history

    Private Sub history_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            RichTextBox1.LoadFile("history.rtf", RichTextBoxStreamType.RichText)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.RetryCancel, "title")
            If MsgBoxResult.Retry Then
                MsgBox("retry")
            End If
            If MsgBoxResult.Cancel Then
                Me.Close()
            End If

        End Try

    End Sub
End Class