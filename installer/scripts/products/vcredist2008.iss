// requires Windows 7, Windows 7 Service Pack 1, Windows Server 2003 Service Pack 2, Windows Server 2008, Windows Server 2008 R2, Windows Server 2008 R2 SP1, Windows Vista Service Pack 1, Windows XP Service Pack 3
// requires Windows Installer 3.1 or later
// requires Internet Explorer 5.01 or later
// http://www.microsoft.com/downloads/en/details.aspx?FamilyID=9cfb2d51-5ff4-4491-b0e5-b386f32c0992

[CustomMessages]
vcredist2008_title=Visual C++ 2008 Redistributable

en.vcredist2008_size=1.7 MB
de.vcredist2008_size=1.7 MB

en.vcredist2008_size_x64=2.3 MB
de.vcredist2008_size_x64=2.3 MB

en.vcredist2008_size_ia64=4.0 MB
de.vcredist2008_size_ia64=4.2 MB

;http://www.microsoft.com/globaldev/reference/lcid-all.mspx
en.vcredist2008_lcid=''
de.vcredist2008_lcid='/lcid 1031 '


[Code]
const
	vcredist2008_url = 'http://download.microsoft.com/download/9/d/2/9d22adff-f0b4-4415-a48d-8c04be241c22/vcredist_x86.exe';
	vcredist2008_url_x64 = 'http://download.microsoft.com/download/d/2/4/d242c3fb-da5a-4542-ad66-f9661d0a8d19/vcredist_x64.exe';
	vcredist2008_url_ia64 = 'http://download.microsoft.com/download/a/1/a/a1a4996b-ed78-4c2b-9589-8edd81b8df39/vcredist_IA64.exe';
procedure vcredist2008();
var
	version: cardinal;
begin
	//RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\VisualStudio\10.0\VC\VCRedist\' + GetString('x86', 'x64', 'ia64'), 'Install', version);
	  //RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\DevDiv\VC\Servicing\9.0\RED\1033\','Version', version);

	  if RegValueExists(HKEY_LOCAL_MACHINE, 'SOFTWARE\Microsoft\DevDiv\VC\Servicing\9.0\RED\1033\', 'Install') = False then
  begin
    	AddProduct('vcredist2008' + GetArchitectureString() + '.exe',
			CustomMessage('vcredist2008_lcid') + '/passive /norestart',
			CustomMessage('vcredist2008_title'),
			CustomMessage('vcredist2008_size' + GetArchitectureString()),
			GetString(vcredist2008_url, vcredist2008_url_x64, vcredist2008_url_ia64),
			false, false);
  end;
end;