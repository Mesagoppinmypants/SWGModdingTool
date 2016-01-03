;@author: Iosnowore

;Include Modern UI

  !include "MUI2.nsh"

;--------------------------------
;General

  ;Name and file
  Name "SWG Color Mod Tool"
  OutFile "SWGModToolInstaller.exe"

  ;Default installation folder
  InstallDir "$PROGRAMFILES\SWG Color Mod Tool"

  ;Request application privileges for Windows Vista
  RequestExecutionLevel admin

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING
  !define MUI_ICON "modicon.ico"

;--------------------------------
;Pages

  ;!insertmacro MUI_PAGE_LICENSE ""
  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
  
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  
;--------------------------------
;Languages
 
  !insertmacro MUI_LANGUAGE "English"

;--------------------------------
;Installer Sections

Section "SWG Color Mod Tool" MainProgram

  SetOutPath "$INSTDIR"
  
  ;ADD YOUR OWN FILES HERE...
  File "SWGColorModTool.exe"
  File "readme.txt"
  File /r "Resources"
  
  ;Create uninstaller
  WriteUninstaller "$INSTDIR\Uninstall.exe"
SectionEnd

Section "Desktop Shortcut" DeskShort
	CreateShortCut "$DESKTOP\SWG Color Mod Tool.lnk" "$INSTDIR\SWGColorModTool.exe"
SectionEnd

;--------------------------------
;Uninstaller Section

Section "Uninstall"

  ;ADD YOUR OWN FILES HERE...

  RMDir /r "$INSTDIR"
  Delete "$DESKTOP\SWG Color Mod Tool.lnk"


SectionEnd