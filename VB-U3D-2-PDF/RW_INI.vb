Option Explicit On

Public Module RW_INI
    '' DLL-Funktionen zum LESEN der INI deklarieren
    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" ( _
        ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, _
        ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    '' DLL-Funktion zum SCHREIBEN in die INI deklarieren
    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" ( _
        ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, _
        ByVal lpFileName As String) As Integer

    '' DLL-Funktion zum Löschen einer ganzen Sektion deklarieren
    Private Declare Ansi Function DeletePrivateProfileSection Lib "kernel32" Alias "WritePrivateProfileStringA" ( _
        ByVal Section As String, ByVal NoKey As Integer, ByVal NoSetting As Integer, _
        ByVal FileName As String) As Integer

    Public Function ReadValue(ByVal iSection As String, _
                              ByVal iKey As String, _
                              ByVal iPath As String, _
                              Optional ByVal iDefault As String = "", _
                              Optional ByVal iBufferSize As Integer = 1024) As String
        Dim sTemp As String = Space(iBufferSize)
        Dim Length As Integer = GetPrivateProfileString(iSection, iKey, iDefault, sTemp, iBufferSize, iPath)
        ReadValue = Left(sTemp, Length)
    End Function

    Public Sub WriteValue(ByVal iSection As String, ByVal iKey As String, ByVal iValue As String, ByVal iPath As String)
        ' Schreiben in die INI durchführen
        WritePrivateProfileString(iSection, iKey, iValue, iPath)
    End Sub

    Public Sub DeleteKey(ByVal iSection As String, ByVal iKey As String, ByVal iPath As String)
        ' Löschen des Schlüssels durch eine Schreiboperation durchführen
        WritePrivateProfileString(iSection, iKey, Nothing, iPath)
    End Sub

    Public Sub DeleteSection(ByVal iSection As String, ByVal iPath As String)
        DeletePrivateProfileSection(iSection, 0, 0, iPath)
    End Sub

    Public Sub MakeBackup(ByVal iTargetPath As String, ByVal iPath As String)
        'Als Zielpfad muss ein DATEIpfad angegeben werden, nicht nur der Ordner
        ' (also z.B. "D:\Test\MeinProgrammEinstellungen_Backup.ini"
        IO.File.Copy(iPath, iTargetPath)
    End Sub

    'Private Sub DeleteFile(ByVal iPath As String)
    '    ' Löschen durchführen
    '    IO.File.Delete(iPath)
    'End Sub
End Module
