Imports System.IO
Imports VB = Microsoft.VisualBasic

Public Module M_SupportFunctions

    Public Function OFD(ByVal iFilter As String, ByVal iMultiSelect As Boolean, ByVal iTitle As String) As String
        OFD = vbNullString
        Dim InStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        With openFileDialog1
            '.InitialDirectory = Environ("HOMEDRIVE") & Environ("HOMEPATH") & "\Desktop" '"c:\"
            .Filter = iFilter '"STL Dateien (*.stl)|*.stl|VRML Dateien (*.wrl)|*.wrl" '"Alle Dateien (*.*)|*.*"
            .FilterIndex = 1
            .RestoreDirectory = True
            .Multiselect = iMultiSelect
            .Title = iTitle

            If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    InStream = .OpenFile()
                    If (InStream IsNot Nothing) Then
                        ' Insert code to read the stream here.
                        If My.Computer.FileSystem.FileExists(.FileName) Then
                            OFD = .FileName
                        End If
                    End If
                Catch ex As Exception
                    'MessageBox.Show("Vom Datenträger kann nicht gelesen werden. Fehlermeldung: " & ex.Message)
                    OFD = vbNullString
                Finally
                    ' Check this again, since we need to make sure we didn't throw an exception on open.
                    If (InStream IsNot Nothing) Then
                        InStream.Close()
                    End If
                End Try
            End If
        End With
    End Function

    Public Function SFD(ByVal iFilter As String) As String
        SFD = vbNullString

        Dim input_fnameWExt As String, input_fname As String

        Try
            input_fnameWExt = VB.Right(F_MAIN.input_file, (VB.Len(F_MAIN.input_file) - VB.InStrRev(F_MAIN.input_file, "\")))
            input_fname = VB.Left(input_fnameWExt, VB.InStrRev(input_fnameWExt, ".") - 1)
        Catch Ex1 As Exception
            input_fname = ""
        End Try

        Dim OutStream As Stream = Nothing
        Dim saveFileDialog1 As New SaveFileDialog()

        With saveFileDialog1
            .FileName = input_fname
            '.InitialDirectory = Environ("HOMEDRIVE") & Environ("HOMEPATH") & "\Desktop"
            .Filter = iFilter '"PDF Datei (*.pdf)|*.pdf"
            .FilterIndex = 1
            .RestoreDirectory = True

            If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    OutStream = .OpenFile()
                    If (OutStream IsNot Nothing) Then
                        ' Insert code to read the stream here.
                        If My.Computer.FileSystem.FileExists(.FileName) Then
                            SFD = .FileName
                        End If
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    SFD = vbNullString
                Finally
                    ' Check this again, since we need to make sure we didn't throw an exception on open.
                    If (OutStream IsNot Nothing) Then
                        OutStream.Close()
                    End If
                End Try
            End If
        End With
    End Function


    Public Function OFolderD() As String
        OFolderD = vbNullString
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        With FolderBrowserDialog1
            .ShowDialog()
            If Not .SelectedPath = "" Then
                OFolderD = .SelectedPath
            End If
            .Reset()
        End With
    End Function



    Public Function IsFolderWritable(ByVal iPath As String) As Boolean
        If iPath = "" Then ' IsNothing(iPath)
            Return False
        Else
            ''Dim info As New DirectoryInfo(iPath)
            ''Return (info.Attributes And FileAttributes.ReadOnly) <> FileAttributes.ReadOnly

            ' remove "\" at the end of the string
            If VB.Right(iPath, 1) = "\" Then _
                iPath = VB.Left(iPath, (VB.Len(iPath) - 1))

            Dim rndNumber As Random = New Random

            Dim TFileName As String = iPath & "\" & CStr(rndNumber.Next) & "-U3D-2-PDF.testfile"
            Dim TFile As StreamWriter

            Try
                TFile = File.CreateText(TFileName)
                TFile.Flush()
                TFile.Close()
            Catch ex As Exception
                ' file could not be created
                'MsgBox(ex.Message)
            Finally
                TFile = Nothing
            End Try

            If File.Exists(TFileName) Then
                Try
                    File.Delete(TFileName)
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function RemFileExt(ByVal iFileName As String) As String
        Dim DotPos As Integer = VB.InStrRev(iFileName, ".")
        If DotPos > 0 Then
            Return VB.Left(iFileName, (DotPos - 1))
        Else
            Return iFileName
        End If
    End Function

    Public Function FileExt(ByVal iFileName As String) As String
        Dim DotPos As Integer = VB.InStr(iFileName, ".")
        If DotPos > 0 Then
            Return VB.Right(iFileName, VB.Len(iFileName) - DotPos)
        Else
            Return iFileName
        End If
    End Function

    Public Function RemNaNFromString(ByVal iString As String) As String
        If VB.Len(iString) <> 0 Then
            Dim i As Integer
            Dim curChar As String
            Dim newString As String = ""

            For i = 1 To VB.Len(iString)
                curChar = VB.Right(VB.Left(iString, i), 1)
                If IsNumeric(curChar) Then
                    newString = newString & curChar
                End If
            Next
            If VB.Len(newString) <> 0 Then
                Return newString
            Else
                Return "0"
            End If
        Else
            Return "0"
        End If
    End Function

End Module
