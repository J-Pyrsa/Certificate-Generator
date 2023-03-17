Public Class CHM

    Dim BDT As String = "\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff>\u00ff\u00ff\u00ff?456789:;<=\u00ff\u00ff\u00ff\u00fe\u00ff\u00ff\u00ff\0\001\002\003\004\005\006\007\010\t\n\013\014\r\016\017\020\021\022\023\024\025\026\027\030\031\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\032\033\034\035\036\037 !""#$%&'()*+,-./0123\u00ff\u00ff\u00ff\u00ff\u00ff"
    Dim BDT2 As String = "\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff>\u00ff\u00ff456789:;<=\u00ff\u00ff\u00ff\u00fe\u00ff\u00ff\u00ff\0\001\002\003\004\005\006\007\010\t\n\013\014\r\016\017\020\021\022\023\024\025\026\027\030\031\u00ff\u00ff\u00ff\u00ff?\u00ff\032\033\034\035\036\037 !""#$%&'()*+,-./0123\u00ff\u00ff\u00ff\u00ff\u00ff"
    Dim STRR_BDTS() As String = {"\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff>\u00ff\u00ff\u00ff?456789:;<=\u00ff\u00ff\u00ff\u00fe\u00ff\u00ff\u00ff\0\001\002\003\004\005\006\007\010\t\n\013\014\r\016\017\020\021\022\023\024\025\026\027\030\031\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\032\033\034\035\036\037 !""#$%&'()*+,-./0123\u00ff\u00ff\u00ff\u00ff\u00ff", _
     "\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff\u00ff>\u00ff\u00ff456789:;<=\u00ff\u00ff\u00ff\u00fe\u00ff\u00ff\u00ff\0\001\002\003\004\005\006\007\010\t\n\013\014\r\016\017\020\021\022\023\024\025\026\027\030\031\u00ff\u00ff\u00ff\u00ff?\u00ff\032\033\034\035\036\037 !""#$%&'()*+,-./0123\u00ff\u00ff\u00ff\u00ff\u00ff"}
    Dim BET As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"
    Dim BET2 As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_"
    Dim STRR_BETS() As String = {"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/", _
     "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_"}

    Function ConBTHe( _
                    _is() As Byte, _
                    i As Integer, _
                    is_200_()() As Byte, _
                    is_201_() As Integer) As Integer

        Return ConBTHe(_is, i, is_200_, is_201_, 0)
    End Function

    '  public static int ConBTHe(byte[] is, int i, byte[][] is_200_,
    '		      int[] is_201_) {
    'return ConBTHe(is, i, is_200_, is_201_, 0);
    '   }
    Function ConBTHe( _
                     _is() As Byte, _
                     i As Integer, _
                     is_202_()() As Byte, _
                     is_203_() As Integer, _
                     i_204_ As Integer) As Integer
        Dim i_205_ As Integer = 0
        Dim i_206_ As Integer = 0
        Dim is_207_(4) As Byte

        If (_is Is Nothing) Or (1 = 0) Then
            Return 0
        End If
        If (is_202_ Is Nothing) Or (is_203_ Is Nothing) Then
            Return -912
        End If
        'if not (i & 0x3) = 0

        '    Return -913
        'fixed by Erwin Palma

        Dim a As Integer = Int((i + 7) / 4)
        Dim i_208_ As Integer = a * 3
        Dim is_209_(i_208_) As Byte
        Dim _String As String = STRR_BDTS(i_204_)
        i_208_ = 0

        Do
            Dim i_210_ As Integer = _is(i_205_ + 1)



        Loop While i <> 0



    End Function


End Class
