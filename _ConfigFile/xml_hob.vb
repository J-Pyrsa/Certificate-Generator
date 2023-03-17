Imports System.Xml
Imports System.Data
Imports System.IO
Imports System.Text

Public Class xml_hob
    Dim tabla As DataTable

    Function GetUserSettings(rawdata() As Byte, ByVal tipo As String) As String
        Dim tt As New type_tools
        Dim xmlData = tt.Byte2XML(rawdata)
        Dim VALOR As String

        Try
            Dim xmldoc As New XmlDocument
            xmldoc.LoadXml(xmlData)
            Dim root As String = ""
            Dim m_nodelist As XmlNodeList = xmldoc.SelectNodes("/WSPUserSettings/start_page/site-after-auth")

            For Each m_node In m_nodelist
                'Obtenemos el Elemento nombre
                VALOR = m_node.ChildNodes.Item(0).InnerText
                Return VALOR
            Next
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Function jwt(rawdata() As Byte, procedencia As String) As DataTable
        Dim tt As New type_tools
        Dim xmlData = tt.Byte2XML(rawdata)

        Try
            Dim xmldoc As New XmlDocument
            xmldoc.LoadXml(xmlData)
            Dim root As String = ""
            Dim m_nodelist As XmlNodeList = xmldoc.SelectNodes("/root/Sessions/JWT/next")
            If m_nodelist.Count > 0 Then
                root = "root"
            Else
                m_nodelist = xmldoc.SelectNodes("/__./Sessions/JWT/next")
                If m_nodelist.Count > 0 Then
                    root = "__."
                Else
                    Return Nothing
                End If
            End If

            Dim VALOR As Integer = CInt(m_nodelist.Item(0).InnerXml)
            Dim JWT_Conn_id As Integer
            Dim JWT_Schemes_Conn_connType As Integer

            tabla = New DataTable()
            tabla.Columns.Add("JWT_schNm")
            tabla.Columns.Add("JWT_Schemes_Conn_stApp")
            tabla.Columns.Add("JWT_Schemes_Conn_connType_name")
            tabla.Columns.Add("JWT_Schemes_Conn_wspGateName")
            tabla.Columns.Add("JWT_Session_type")

            For a As Integer = 1 To VALOR
                Try
                    Dim reg As DataRow = tabla.NewRow()

                    If getValue("/" & root & "/Sessions/JWT/__" & a & "/schNm", xmldoc) <> "" Then
                        reg("JWT_schNm") = getValue("/" & root & "/Sessions/JWT/__" & a & "/schNm", xmldoc)
                        'JWT_schNm = getValue("/root/Sessions/JWT/__" & a & "/schNm", xmldoc)
                        JWT_Conn_id = CInt(getValue("/" & root & "/Sessions/JWT/__" & a & "/Conn", xmldoc))
                        reg("JWT_Schemes_Conn_stApp") = getValue("/" & root & "/Schemes/Conn/__" & JWT_Conn_id & "/stApp", xmldoc)
                        JWT_Schemes_Conn_connType = CDec(getValue("/" & root & "/Schemes/Conn/__" & JWT_Conn_id & "/connType", xmldoc))
                        Select Case JWT_Schemes_Conn_connType
                            Case 1
                                reg("JWT_Schemes_Conn_connType_name") = "Balanceo de cargas"
                            Case 2
                                reg("JWT_Schemes_Conn_connType_name") = "Conexión directa con WSP"
                                reg("JWT_Schemes_Conn_wspGateName") = getValue("/" & root & "/Schemes/Conn/__" & JWT_Conn_id & "/wspGateName", xmldoc)
                            Case 3
                                reg("JWT_Schemes_Conn_connType_name") = "Balanceo de cargas con WSP"
                                reg("JWT_Schemes_Conn_wspGateName") = getValue("/" & root & "/Schemes/Conn/__" & JWT_Conn_id & "/wspGateName", xmldoc)
                            Case 4
                                reg("JWT_Schemes_Conn_connType_name") = "WebSecureProxy modo Socks"
                                reg("JWT_Schemes_Conn_wspGateName") = getValue("/" & root & "/Schemes/Conn/__" & JWT_Conn_id & "/wspGateName", xmldoc)
                            Case Else
                                reg("JWT_Schemes_Conn_connType_name") = "Conexión directa"
                        End Select
                        reg("JWT_Session_type") = procedencia
                        tabla.Rows.Add(reg)
                        tabla.AcceptChanges()
                    End If
                Catch ex As Exception
                    'Dim ms As String = ex.Message
                End Try
            Next
            Return tabla
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Function jwt(ByRef xmlData As String, procedencia As String) As DataTable

        Try
            Dim xmldoc As New XmlDocument
            xmldoc.LoadXml(xmlData)
            Dim root As String = ""
            Dim m_nodelist As XmlNodeList = xmldoc.SelectNodes("/root/Sessions/JWT/next")
            If m_nodelist.Count > 0 Then
                root = "root"
            Else
                m_nodelist = xmldoc.SelectNodes("/__./Sessions/JWT/next")
                If m_nodelist.Count > 0 Then
                    root = "__."
                Else
                    Return Nothing
                End If
            End If

            Dim VALOR As Integer = CInt(m_nodelist.Item(0).InnerXml)
            Dim JWT_Conn_id As Integer
            Dim JWT_Schemes_Conn_connType As Integer

            tabla = New DataTable()
            tabla.Columns.Add("JWT_schNm")
            tabla.Columns.Add("JWT_Schemes_Conn_stApp")
            tabla.Columns.Add("JWT_Schemes_Conn_connType_name")
            tabla.Columns.Add("JWT_Schemes_Conn_wspGateName")
            tabla.Columns.Add("JWT_Session_type")

            For a As Integer = 1 To VALOR
                Try
                    Dim reg As DataRow = tabla.NewRow()

                    If getValue("/" & root & "/Sessions/JWT/__" & a & "/schNm", xmldoc) <> "" Then
                        reg("JWT_schNm") = getValue("/" & root & "/Sessions/JWT/__" & a & "/schNm", xmldoc)
                        'JWT_schNm = getValue("/root/Sessions/JWT/__" & a & "/schNm", xmldoc)
                        JWT_Conn_id = CInt(getValue("/" & root & "/Sessions/JWT/__" & a & "/Conn", xmldoc))
                        reg("JWT_Schemes_Conn_stApp") = getValue("/" & root & "/Schemes/Conn/__" & JWT_Conn_id & "/stApp", xmldoc)
                        JWT_Schemes_Conn_connType = CDec(getValue("/" & root & "/Schemes/Conn/__" & JWT_Conn_id & "/connType", xmldoc))
                        Select Case JWT_Schemes_Conn_connType
                            Case 1
                                reg("JWT_Schemes_Conn_connType_name") = "Balanceo de cargas"
                            Case 2
                                reg("JWT_Schemes_Conn_connType_name") = "Conexión directa con WSP"
                                reg("JWT_Schemes_Conn_wspGateName") = getValue("/" & root & "/Schemes/Conn/__" & JWT_Conn_id & "/wspGateName", xmldoc)
                            Case 3
                                reg("JWT_Schemes_Conn_connType_name") = "Balanceo de cargas con WSP"
                                reg("JWT_Schemes_Conn_wspGateName") = getValue("/" & root & "/Schemes/Conn/__" & JWT_Conn_id & "/wspGateName", xmldoc)
                            Case 4
                                reg("JWT_Schemes_Conn_connType_name") = "WebSecureProxy modo Socks"
                                reg("JWT_Schemes_Conn_wspGateName") = getValue("/" & root & "/Schemes/Conn/__" & JWT_Conn_id & "/wspGateName", xmldoc)
                            Case Else
                                reg("JWT_Schemes_Conn_connType_name") = "Conexión directa"
                        End Select
                        reg("JWT_Session_type") = procedencia

                        tabla.Rows.Add(reg)
                        tabla.AcceptChanges()
                    End If
                Catch ex As Exception
                    Dim x As String = ex.Message
                End Try
            Next
            Return tabla
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Function getValue(SchemaPath As String, xmldoc As XmlDocument) As String
        Dim m_nodelist As XmlNodeList
        m_nodelist = xmldoc.SelectNodes(SchemaPath)

        If m_nodelist.Count <> 0 Then
            Return m_nodelist.Item(0).InnerXml
        Else
            Return Nothing
        End If
    End Function

End Class