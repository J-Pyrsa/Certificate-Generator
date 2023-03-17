;#define use_iis
#define use_msi31

#define use_dotnetfx40
#define use_wic

#define use_vc2008

#define MyAppSetupName 'Certificate Generator'
#define MyAppVersion '1.6'

[Setup]
AppName={#MyAppSetupName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppSetupName} {#MyAppVersion}
AppCopyright=Copyright © HOB GmbH & Co. KG (2011)
VersionInfoVersion={#MyAppVersion}
VersionInfoCompany=HOB GmbH & Co. KG
AppPublisher=HOB GmbH & Co. KG
AppPublisherURL=http://www.hob.com.mx
AppSupportURL=http://www.hob.com.mx/soporte/CertificateGenerator.html
;AppUpdatesURL=http://...
OutputBaseFilename={#MyAppSetupName}-{#MyAppVersion}
DefaultGroupName={#MyAppSetupName}
DefaultDirName={pf}\{#MyAppSetupName}
UninstallDisplayIcon={app}\Certificate Generator.exe
OutputDir=bin
SourceDir=.
AllowNoIcons=yes
;SetupIconFile=MyProgramIcon
SolidCompression=yes

;MinVersion default value: "0,5.0 (Windows 2000+) if Unicode Inno Setup, else 4.0,4.0 (Windows 95+)"
;MinVersion=0,5.0
PrivilegesRequired=admin
ArchitecturesAllowed=x86 x64 ia64
ArchitecturesInstallIn64BitMode=x64 ia64

[Types]
Name: full; Description: Instalación Completa
Name: custom; Description: Instalación personalizada; Flags: iscustom

[Components]
Name: program; Description: Archivos del programa; Types: full custom; Flags: fixed
Name: openssl; Description: Instalación de OpenSSL; Types: full
Name: samples; Description: Instalación de datos de demo; Types: full

[Languages]
Name: en; MessagesFile: compiler:Default.isl
Name: de; MessagesFile: compiler:Languages\German.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Files]
Source: C:\CertificateGenerator\contrib\OpenSSL\ubsec.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\bftest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\bntest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\casttest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\destest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\dhtest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\dsatest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\ecdhtest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\ecdsatest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\ectest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\enginetest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\evp_test.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\exptest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\hmactest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\ideatest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\md4test.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\md5test.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\mdc2test.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\openssl.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\randtest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\rc2test.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\rc4test.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\rmdtest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\rsa_test.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\sha1test.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\sha256t.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\sha512t.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\shatest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\ssltest.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\wp_test.exe; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\openssl.cfg; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\CA.pl; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\4758cca.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\aep.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\atalla.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\capi.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\chil.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\cswift.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\gmp.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\gost.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\libeay32.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\nuron.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\padlock.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\ssleay32.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\contrib\OpenSSL\sureware.dll; DestDir: {app}\OpenSSL; Components: openssl
Source: C:\CertificateGenerator\samples & sources\config.xml; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\bd1.mdb; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\demo_rootcacert.b64; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\hclient.cdb; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\hserver.cdb; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\config.conf; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\hclient.cfg; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\hserver.cfg; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\Usuarios_demo.csv; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\demo_rootcacert.rsapriv.pem; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\hclient.pwd; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\hserver.pwd; DestDir: {app}\samples; Components: samples
Source: C:\CertificateGenerator\samples & sources\config.conf; DestDir: {app}\pki; Components: samples
Source: C:\CertificateGenerator\samples & sources\demo_rootcacert.rsapriv.pem; Components: program; DestDir: {app}\pki; 
Source: C:\CertificateGenerator\samples & sources\demo_rootcacert.b64; DestDir: {app}\pki; Components: program
Source: C:\CertificateGenerator\Debug\Certificate Generator.vshost.exe.config; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\Certificate Generator.exe; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\Certificate Generator.vshost.exe; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\bd1.mdb; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\Certificate Generator.application; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\Certificate Generator.vshost.application; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\Certificate Generator.exe.manifest; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\Certificate Generator.vshost.exe.manifest; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\Certificate Generator.xml; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\config.xml; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\Copia de config.xml; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\hobtools.xml; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\ChilkatDotNet4.dll; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\hobtools.dll; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\history.rtf; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\splash.gif; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\accept.jpg; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\remove.jpg; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\warning.jpg; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\Certificate Generator.pdb; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\hobtools.pdb; DestDir: {app}\bin; Components: program
Source: C:\CertificateGenerator\Debug\Certificate Generator.exe.config; DestDir: {app}\bin; Components: program

[Icons]
Name: {group}\Certificate Generator; Filename: {app}\bin\Certificate Generator.exe
Name: {group}\{cm:UninstallProgram,MyProgram}; Filename: {uninstallexe}
Name: {commondesktop}\MyProgram; Filename: {app}\bin\Certificate Generator.exe; Tasks: desktopicon
Name: {userappdata}\Microsoft\Internet Explorer\Quick Launch\MyProgram; Filename: {app}\bin\Certificate Generator.exe; Tasks: quicklaunchicon

[Run]
Filename: {app}\Certificate Generator.exe; Description: {cm:LaunchProgram,MyProgram}; Flags: nowait postinstall skipifsilent

#include "scripts\products.iss"

#include "scripts\products\stringversion.iss"
#include "scripts\products\winversion.iss"
#include "scripts\products\fileversion.iss"
#include "scripts\products\dotnetfxversion.iss"

#ifdef use_msi31
#include "scripts\products\msi31.iss"
#endif

#ifdef use_dotnetfx40
#include "scripts\products\dotnetfx40client.iss"
#include "scripts\products\dotnetfx40full.iss"
#endif

#ifdef use_wic
#include "scripts\products\wic.iss"
#endif

#ifdef use_vc2008
#include "scripts\products\vcredist2008.iss"
#endif

[CustomMessages]
win_sp_title=Windows %1 Service Pack %2


[Code]
function InitializeSetup(): boolean;
begin
	//init windows version
	initwinversion();

  #ifdef use_wic
	wic();
#endif



	// if no .netfx 4.0 is found, install the client (smallest)
#ifdef use_dotnetfx40
	if (not netfxinstalled(NetFx40Client, '') and not netfxinstalled(NetFx40Full, '')) then
		// dotnetfx40client();
    dotnetfx40full();
#endif

#ifdef use_vc2008
	vcredist2008();
#endif
	Result := true;
end;
[Dirs]
Name: {app}\bin
Name: {app}\OpenSSL; Tasks: ; Languages: 
Name: {app}\samples
Name: {app}\pki
Name: {app}\certificates
[Registry]
Root: HKLM; Subkey: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment; ValueType: string; ValueName: OPENSSL_CONF; ValueData: {app}\OpenSSL\openssl.cfg; Flags: uninsdeletekey
Root: HKLM; Subkey: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment; ValueType: string; ValueName: RANDFILE; ValueData: .rnd; Flags: uninsdeletekey
