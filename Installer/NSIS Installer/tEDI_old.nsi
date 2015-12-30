; Script generated with the Venis Install Wizard

; Define your application name
!define APPNAME "tEDI"
!define APPNAMEANDVERSION "tEDI 1.0"

; Main Install settings
Name "${APPNAMEANDVERSION}"
InstallDir "$PROGRAMFILES\tEDI"
InstallDirRegKey HKLM "Software\${APPNAME}" ""
OutFile "..\..\tEDI\tEDI Installer.exe"

; Modern interface settings
!include "MUI.nsh"

!define MUI_ABORTWARNING
!define MUI_FINISHPAGE_RUN "$INSTDIR\tEDI.exe"

!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_LICENSE "..\..\tEDI\license.txt"
!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

; Set languages (first is default language)
!insertmacro MUI_LANGUAGE "English"
!insertmacro MUI_RESERVEFILE_LANGDLL

Section "tEDI" Section1

	; Set Section properties
	SetOverwrite on

	; Set Section Files and Shortcuts
	SetOutPath "$INSTDIR\"
	File "..\..\tEDI\bin\Release\SciLexer.dll"
	File "..\..\tEDI\bin\Release\SciLexer64.dll"
	File "..\..\tEDI\bin\Release\ScintillaNET.dll"
	File "..\..\tEDI\bin\Release\tEDI.exe"
	CreateShortCut "$DESKTOP\tEDI.lnk" "$INSTDIR\tEDI.exe"
	CreateDirectory "$SMPROGRAMS\tEDI"
	CreateShortCut "$SMPROGRAMS\tEDI\tEDI.lnk" "$INSTDIR\tEDI.exe"
	CreateShortCut "$SMPROGRAMS\tEDI\Uninstall.lnk" "$INSTDIR\uninstall.exe"

SectionEnd

Section -FinishSection

	WriteRegStr HKLM "Software\${APPNAME}" "" "$INSTDIR"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "DisplayName" "${APPNAME}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "UninstallString" "$INSTDIR\uninstall.exe"
	WriteUninstaller "$INSTDIR\uninstall.exe"

SectionEnd

; Modern install component descriptions
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
	!insertmacro MUI_DESCRIPTION_TEXT ${Section1} ""
!insertmacro MUI_FUNCTION_DESCRIPTION_END

;Uninstall section
Section Uninstall

	;Remove from registry...
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}"
	DeleteRegKey HKLM "SOFTWARE\${APPNAME}"

	; Delete self
	Delete "$INSTDIR\uninstall.exe"

	; Delete Shortcuts
	Delete "$DESKTOP\tEDI.lnk"
	Delete "$SMPROGRAMS\tEDI\tEDI.lnk"
	Delete "$SMPROGRAMS\tEDI\Uninstall.lnk"

	; Clean up tEDI
	Delete "$INSTDIR\SciLexer.dll"
	Delete "$INSTDIR\SciLexer64.dll"
	Delete "$INSTDIR\ScintillaNET.dll"
	Delete "$INSTDIR\tEDI.exe"

	; Remove remaining directories
	RMDir "$SMPROGRAMS\tEDI"
	RMDir "$INSTDIR\"

SectionEnd

; eof