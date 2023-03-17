;#define use_iis
#define use_msi31

#define use_dotnetfx40
#define use_wic

#define use_vc2008

#define MyAppSetupName 'Certificate Generator'
#define MyAppVersion '1.6'

[Types]
Name: "full"; Description: "Instalación completa"
Name: "compact"; Description: "Instalación mínima"
Name: "custom"; Description: "Instalación personalizada"; Flags: iscustom


[Setup]
AppName={#MyAppSetupName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppSetupName} {#MyAppVersion}
AppCopyright=Copyright © stfx 2007-2011
VersionInfoVersion={#MyAppVersion}
VersionInfoCompany=stfx
AppPublisher=stfx
;AppPublisherURL=http://...
;AppSupportURL=http://...
;AppUpdatesURL=http://...
OutputBaseFilename={#MyAppSetupName}-{#MyAppVersion}
DefaultGroupName={#MyAppSetupName}
DefaultDirName={pf}\{#MyAppSetupName}
UninstallDisplayIcon={app}\MyProgram.exe
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

ChangesEnvironment=true

[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"
Name: "de"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: modifypath; Description: "{app}"; Flags: unchecked

[Files]
Source: "..\..\Debug\MyProgram.exe"; DestDir: "{app}"; Check: not Is64BitInstallMode

[Icons]
Name: "{group}\Certificate Generator"; Filename: "{app}\Certificate Generator.exe"
Name: "{group}\{cm:UninstallProgram,MyProgram}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\MyProgram"; Filename: "{app}\MyProgram.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\MyProgram"; Filename: "{app}\MyProgram.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\Certificate Generator.exe"; Description: "{cm:LaunchProgram,MyProgram}"; Flags: nowait postinstall skipifsilent

#include "scripts\products.iss"

#include "scripts\products\stringversion.iss"
#include "scripts\products\winversion.iss"
#include "scripts\products\fileversion.iss"
#include "scripts\products\dotnetfxversion.iss"

#ifdef use_iis
#include "scripts\products\iis.iss"
#endif

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

const
    ModPathName = 'modifypath';
    ModPathType = 'system';

function ModPathDir(): TArrayOfString;
begin
    setArrayLength(Result, 1)
    Result[0] := ExpandConstant('{app}');
end;
#include "modpath.iss"
