Public Class HlSet
    Function m_decrypt_password(UserID As String, PasswordToDecript As String) As String

        If UserID.Length = 0 Then
            Return UserID
        End If
        Dim cs(1)() As Char
        cs(0) = Nothing

        If AUrps2(UserID.ToCharArray(), PasswordToDecript.ToCharArray(), cs) Then

        End If



        Throw New Exception
        MsgBox("")
    End Function

    Function AUrps2(arg0() As Char, arg1() As Char, arg2()() As Char) As Boolean
        If (arg0 Is Nothing) Or (arg1 = Nothing) Or (arg2 Is Nothing) Then
            Return Nothing
        End If
        If (arg0.Length <= 0) Or (arg1.Length <= 0) Or (arg2.Length <= 0) Then
            Return Nothing
        End If
        Dim i As Integer = arg0.Length
        Dim _is(i) As Byte

        For i_21_ As Integer = 0 To i - 1
            _is(i_21_) = AscW(arg0(i_21_))
        Next
        Dim is_22_(1)() As Byte
        is_22_(0) = Nothing
        Dim is_23_(1) As Integer
        is_23_(0) = 0

        Dim chm As New CHM
        chm.ConBTHe(_is, i, is_22_, is_23_)

        Return Nothing
    End Function


    

End Class
