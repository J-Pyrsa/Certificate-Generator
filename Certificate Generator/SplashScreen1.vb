Imports System.IO
Imports hobtools

Public NotInheritable Class SplashScreen1

    'TODO: Este formulario se puede establecer fácilmente como pantalla de presentación para la aplicación desde la ficha "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").
    Dim RutaCerts As String ' Lugar dónde se van a guardar los certificados.
    Dim cacert As String ' Certificado de la CA
    Dim cakey As String ' Llave de la CA
    Dim ConfigFile As String  ' Archivo de configuración para OpenSSL
    Dim access2003_path As String ' Archivo de base de datos
    Dim OpenSSL_path As String



    '<openssl_path>C:\OpenSSL-Win32\bin\openssl.exe</openssl_path>


    '<Usuario_LDAP>root</Usuario_LDAP>
    '<Pass_LDAP>adminpw</Pass_LDAP>
    '<Dominio>IGLOVAL</Dominio>
    ' <Direccion_LDAP>192.168.56.101</Direccion_LDAP>

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configure el texto del cuadro de diálogo en tiempo de ejecución según la información del ensamblado de la aplicación.  

        'TODO: Personalice la información del ensamblado de la aplicación en el panel "Aplicación" del cuadro de diálogo 
        '  propiedades del proyecto (bajo el menú "Proyecto").

        'Título de la aplicación
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Dé formato a la información de versión usando el texto establecido en el control de versiones en tiempo de diseño como
        '  cadena de formato. Esto le permite una localización efectiva si lo desea.
        '  Se pudo incluir la información de compilación y revisión usando el siguiente código y cambiando el 
        '  texto en tiempo de diseño del control de versiones a "Versión {0}.{1:00}.{2}.{3}" o algo parecido. Consulte
        '  String.Format() en la Ayuda para obtener más información.
        '
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Información de Copyright
        Copyright.Text = My.Application.Info.Copyright

        Dim ImagenName As String = "splash"
        If File.Exists("splash.png") Then
            Me.MainLayoutPanel.BackgroundImage = New Bitmap("splash.png")
        End If
        If File.Exists("splash.jpg") Then
            Me.MainLayoutPanel.BackgroundImage = New Bitmap("splash.jpg")
        End If
        If File.Exists("splash.gif") Then
            Me.MainLayoutPanel.BackgroundImage = New Bitmap("splash.gif")
        End If

        'Verificamos si existen las rutas de configuración, en caso de que no existan mandamos llamar
        'al formulario de configuración primero, resaltando las rutas que no están activas

    End Sub
End Class
