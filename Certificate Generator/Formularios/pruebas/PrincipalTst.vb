
Public Class PrincipalTst
    

End Class


'public static String m_decrypt_password
'	(String UserID, String PasswordToDecript) throws Exception {
'	if (UserID.length() == 0)
'	    return UserID;
'	char[][] cs = new char[1][];
'	cs[0] = null;
'	if (AUrps2(UserID.toCharArray(), PasswordToDecript.toCharArray(), cs))
'	    return new String(cs[0]);
'	throw new Exception("Wrong password decrypt for: " + PasswordToDecript);
'    }