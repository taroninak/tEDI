; tEDI.nsi - this file is part of tEDI, a fast and lightweight IDE
;
; Custom License
;
; tEDI is based on ScintillaNET component by Garrett Serack wich is based on the ;
; Scintilla component by Neil Hodgson.
;
; tEDI is released on this same license.
;
; Copyright 2014-2015 by Taron Petrosyan <tgtaron@gmail.com>
;
; All Rights Reserved 
;
; Permission to use, copy, modify, and distribute this software and its ;
; documentation for any purpose and without fee is hereby granted, provided that ;
; the above copyright notice appear in all copies and that both that copyright ; 
; notice and this permission notice appear in supporting documentation. 
;
; Taron Petrosyan AND ALL EMPLOYERS PAST AND PRESENT DISCLAIM ALL WARRANTIES ;
; WITH REGARD TO THIS SOFTWARE, INCLUDING ALL IMPLIED WARRANTIES OF ;
; MERCHANTABILITY AND FITNESS, IN NO EVENT SHALL GARRETT SERACK AND ALL ;
; EMPLOYERS PAST AND PRESENT BE LIABLE FOR ANY SPECIAL, INDIRECT OR ;
;	CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, ;
;	DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER ;
;	TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE ;
;	OF THIS SOFTWARE. 
;
;
;	The license for ScintillaNET is as follows:
;	-----------------------------------------------------------------------
;	Copyright 2002-2006 by Garrett Serack <gserack@gmail.com>
;
;	All Rights Reserved 
;
;	Permission to use, copy, modify, and distribute this software and its ;
;	documentation for any purpose and without fee is hereby granted, provided that ;
;	the above copyright notice appear in all copies and that both that copyright ;
;	notice and this permission notice appear in supporting documentation. 
;
;	GARRETT SERACK AND ALL EMPLOYERS PAST AND PRESENT DISCLAIM ALL WARRANTIES WITH ;
;	REGARD TO THIS SOFTWARE, INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY ;
;	AND FITNESS, IN NO EVENT SHALL GARRETT SERACK AND ALL EMPLOYERS PAST AND ;
;	PRESENT BE LIABLE FOR ANY SPECIAL, INDIRECT OR CONSEQUENTIAL DAMAGES OR ANY ;
;	DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ;
;	ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN ;
;	CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE. 
;
;	The license for Scintilla is as follows:
;	-----------------------------------------------------------------------
;	Copyright 1998-2006 by Neil Hodgson <neilh@scintilla.org>
;
;	All Rights Reserved 
;
;	Permission to use, copy, modify, and distribute this software and its ;
;	documentation for any purpose and without fee is hereby granted, provided that ;
;	the above copyright notice appear in all copies and that both that copyright ;
;	notice and this permission notice appear in supporting documentation. 
;
;	NEIL HODGSON DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOFTWARE, INCLUDING ;
;	ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS, IN NO EVENT SHALL NEIL ;
;	HODGSON BE LIABLE FOR ANY SPECIAL, INDIRECT OR CONSEQUENTIAL DAMAGES OR ANY ;
;	DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ;
;	ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN ;
;	CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
;
; 
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;	end of license


; Installer script for tEDI (Windows Installer)
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

; Define your application name
!define APPNAME "tEDI"
!define APPNAMEANDVERSION "tEDI 1.0"

; Main Install settings
Name "${APPNAMEANDVERSION}"
InstallDir "$PROGRAMFILES\tEDI"
InstallDirRegKey HKLM "Software\${APPNAME}" ""
OutFile "tEDI Installer.exe"

VIProductVersion                 "1.0.0.0"
VIAddVersionKey ProductName      "tEDI"
VIAddVersionKey Comments         "tEDI is a fast and lightweight IDE"
VIAddVersionKey CompanyName      "TGCorp"
VIAddVersionKey LegalCopyright   "TGCorp"
VIAddVersionKey FileDescription  "tEDI Installer"
VIAddVersionKey FileVersion      1
VIAddVersionKey ProductVersion   1
VIAddVersionKey InternalName     "tEDI"
VIAddVersionKey LegalTrademarks  "TGCorp"
VIAddVersionKey OriginalFilename "tEDI.exe"

; Modern interface settings
!include "MUI.nsh"

!define MUI_ABORTWARNING
!define MUI_FINISHPAGE_RUN "$INSTDIR\tEDI.exe"

!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_LICENSE "license.txt"
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
	SectionIn RO 1 2
	SetOverwrite on

	; Set Section Files and Shortcuts
	SetOutPath "$INSTDIR\"
	File "..\Files\SciLexer.dll"
	File "..\Files\SciLexer64.dll"
	File "..\Files\ScintillaNET.dll"
	File "..\Files\tEDI.exe"
	SetOutPath "$APPDATA\${APPNAME}"
	File "..\Files\Build.xml"
	CreateDirectory "$SMPROGRAMS\tEDI"
	CreateDirectory "$APPDATA\${APPNAME}"
	CreateShortCut "$SMPROGRAMS\tEDI\tEDI.lnk" "$INSTDIR\tEDI.exe"
	CreateShortCut "$SMPROGRAMS\tEDI\Uninstall.lnk" "$INSTDIR\uninstall.exe"

SectionEnd

Section "Desktop Shortcuts" Section2
	; Set Section properties
	SectionIn 1
	SetOverwrite on
	
	CreateShortCut "$DESKTOP\tEDI.lnk" "$INSTDIR\tEDI.exe"
	
SectionEnd
	
Section "Context Menus" Section3
	SectionIn 1
	
	WriteRegStr HKCR "*\shell\OpenWithtEDI" "" "Open with tEDI"
	WriteRegStr HKCR "*\shell\OpenWithtEDI" "Icon" "$INSTDIR\tEDI.exe"
	WriteRegStr HKCR "*\shell\OpenWithtEDI\command" "" '"$INSTDIR\tEDI.exe" "%1"'
SectionEnd

Section -FinishSection

	WriteRegStr HKLM "Software\${APPNAME}" "" "$INSTDIR"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "DisplayName" "${APPNAME}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "UninstallString" "$INSTDIR\uninstall.exe"
	WriteUninstaller "$INSTDIR\uninstall.exe"

SectionEnd

; Modern install component descriptions
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
	!insertmacro MUI_DESCRIPTION_TEXT ${Section1} "Main application and required program files. You cannot skip these files."
	!insertmacro MUI_DESCRIPTION_TEXT ${Section2} "Create shortcuts for tEDI on the desktop"
	!insertmacro MUI_DESCRIPTION_TEXT ${Section3} "Add context menu item 'Open With tEDI'"
!insertmacro MUI_FUNCTION_DESCRIPTION_END

;Uninstall section
Section Uninstall

	;Remove from registry...
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}"
	DeleteRegKey HKLM "SOFTWARE\${APPNAME}"
	
	;Remove Context Menu
	DeleteRegKey HKCR "*\shell\OpenWithtEDI\command" ""
	DeleteRegKey HKCR "*\shell\OpenWithtEDI\Icon" ""
	DeleteRegKey HKCR "*\shell\OpenWithtEDI" ""
	
	; Clean up tEDI
	Delete "$INSTDIR\SciLexer.dll"
	Delete "$INSTDIR\SciLexer64.dll"
	Delete "$INSTDIR\ScintillaNET.dll"
	Delete "$INSTDIR\tEDI.exe"
	Delete "$APPDATA\${APPNAME}\Build.xml"
	; Delete Shortcuts
	Delete "$DESKTOP\tEDI.lnk"
	Delete "$SMPROGRAMS\tEDI\tEDI.lnk"
	Delete "$SMPROGRAMS\tEDI\Uninstall.lnk"
	
	; Delete self
	Delete "$INSTDIR\uninstall.exe"
	
	; Remove remaining directories
	RMDir "$SMPROGRAMS\tEDI"
	RMDir "$INSTDIR\"
	RMDir "$APPDATA\${APPNAME}"
	
SectionEnd

; eof