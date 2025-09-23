; Hello_W0rld installer script for Inno Setup (per-user install)
[Setup]
AppName=Hello_W0rld
AppVersion=1.1.0
DefaultDirName={userappdata}\Hello_W0rld
DefaultGroupName=Hello_W0rld
OutputBaseFilename=Hello_W0rld_Installer
Compression=lzma
SolidCompression=yes
PrivilegesRequired=lowest
WizardStyle=modern
SetupIconFile=C:\Users\Barac0da\source\repos\Hello_W0rld\Icons\Hello_W0rld.ico

[Files]
Source: "C:\Users\Barac0da\source\repos\Hello_W0rld\Publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\Barac0da\source\repos\Hello_W0rld\Icons\Hello_W0rld.ico"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\Hello_W0rld"; Filename: "{app}\Hello_W0rld.exe"; IconFilename: "{app}\Hello_W0rld.ico"
Name: "{userdesktop}\Hello_W0rld"; Filename: "{app}\Hello_W0rld.exe"; IconFilename: "{app}\Hello_W0rld.ico"

[Run]
Filename: "{app}\Hello_W0rld.exe"; Description: "Launch Hello_W0rld"; Flags: nowait postinstall skipifsilent
