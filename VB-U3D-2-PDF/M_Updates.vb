Imports System.IO

Public Module M_Updates
    Public newUpdate As Boolean = False
    Public UpdateError As Boolean = False

    Public Function CheckForUpdate() As Boolean
        CheckForUpdate = False
        Dim rndNumber As Random = New Random
        Dim rndStr As Long = rndNumber.Next.ToString
        Dim UIFile As String = F_MAIN.DIR_TEMP & "\" & rndStr & "-" & "UpdateIndex.ini"

        M_Download.dwlByLink(URL_UIFile, UIFile)

        If Not UpdateError And File.Exists(UIFile) Then
            If CInt(ReadValue("U3D-2-PDF", "CurReleaseIndex", UIFile)) > CRI Then
                newUpdate = True
                CheckForUpdate = True '
            End If
            File.Delete(UIFile)
        End If
    End Function

    Public Sub DownloadUpdate()
        Dim DLPath As String
        Dim DLFile As String

        With F_MAIN.FolderBrowserDialog1
            .Description = "Select a folder to download the new file '" & FileName & "' to." & Chr(10) & _
                           "The program will quit after the download is done."
            .ShowDialog()
            DLPath = .SelectedPath
            .Reset()
        End With

        If DLPath <> "" Then
            If Not IsFolderWritable(DLPath) Then
                MsgBox("Selected Folder is not writable.", vbExclamation)
            Else
                DLFile = DLPath & "\" & FileName
                If File.Exists(DLFile) Then
                    If MsgBox("File '" & FileName & "' already exists, overwrite it?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) _
                        = vbNo Then Exit Sub
                End If
                M_Download.dwlByLink(URL_FileUpdate, DLFile)
                If File.Exists(DLFile) Then
                    System.Diagnostics.Process.Start(DLFile)
                    End
                Else
                    MsgBox("There was a problem downloading the file.", vbExclamation)
                End If
            End If
        End If
    End Sub

End Module
