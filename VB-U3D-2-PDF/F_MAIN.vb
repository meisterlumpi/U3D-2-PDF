Imports System.IO
Imports System.Text
Imports System.Threading
Imports VB = Microsoft.VisualBasic

Public Class F_MAIN
    Declare Function ShellExecute Lib "shell32.dll" _
        Alias "ShellExecuteA" ( _
        ByVal hwnd As Long, _
        ByVal lpOperation As String, _
        ByVal lpFile As String, _
        ByVal lpParameters As String, _
        ByVal lpDirectory As String, _
        ByVal nShowCmd As Long) As Long

    Public path_miktex As String
    Public path_meshlab As String
    Public path_AR As String

    Public input_file As String
    Public output_file As String
    Public output_file_name As String
    Public output_folder As String

    Public input_folder_BATCH As String
    Public output_folder_BATCH As String
    Public ModelFileNames_BATCH As New Collection

    Public ConfigFile As String
    Public ConfigFile_sample As String
    Public DIR_TEMP As String

    Public miktex_installed As Boolean = False
    Public meshlab_installed As Boolean = False
    Public AR_installed As Boolean = False

    Public AR_enabled_image As Image
    Public AR_disabled_image As Image

    Public Param_papersize As String
    Public Param_orienation As String

    Public U3D_FileName As String
    Public Param_width As String
    Public Param_height As String
    Public Param_margin_top As String
    Public Param_margin_bottom As String
    Public Param_margin_left As String
    Public Param_margin_right As String
    Public Param_acc As String
    Public Param_roll As String
    Public Param_c2c_1 As String
    Public Param_c2c_2 As String
    Public Param_c2c_3 As String
    Public Param_roo As String
    Public Param_coo_1 As String
    Public Param_coo_2 As String
    Public Param_coo_3 As String
    Public Param_lights As String


    '===============================================================================
    ' USERFORM
    '----------------------------------------------------------
    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    End Sub

    Private Sub UserForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '===============================================================================
        ' UPDATES
        '----------------------------------------------------------
        ' check for updates when program is started and _
        ' start update process in different thread
        Dim Thread_Update As New Thread(New ThreadStart(AddressOf CheckForUpdate))
        Thread_Update.SetApartmentState(ApartmentState.STA)
        Thread_Update.Start()
        '----------------------------------------------------------

        ' Variablen
        Dim i As Integer

        DIR_TEMP = System.Environment.GetEnvironmentVariable("TEMP")

        ' if TEMP folder not found use output-folder, _
        ' check if temp folder is writable
        If Not IsFolderWritable(DIR_TEMP) Then
            ' use output-folder
            ' ...
        End If

        ' create the ToolTip and associate with the Form container
        Dim ToolTip_FileOpen As New ToolTip, _
            ToolTip_FileSave As New ToolTip, _
            ToolTip_PictureBox_miktex As New ToolTip, _
            ToolTip_PictureBox_meshlab As New ToolTip, _
            ToolTip_PictureBox_Update As New ToolTip, _
            ToolTip_PictureBox_AR As New ToolTip, _
            ToolTip_TB_pdfLaTeX As New ToolTip, _
            ToolTip_TB_MeshLab As New ToolTip, _
            ToolTip_TB_AR As New ToolTip


        With ToolTip_FileOpen
            .AutoPopDelay = 20000 : .InitialDelay = 100 : .ReshowDelay = 50 : .ShowAlways = True
        End With
        With ToolTip_FileSave
            .AutoPopDelay = 20000 : .InitialDelay = 100 : .ReshowDelay = 50 : .ShowAlways = True
        End With
        With ToolTip_PictureBox_miktex
            .AutoPopDelay = 20000 : .InitialDelay = 100 : .ReshowDelay = 50 : .ShowAlways = True
            .SetToolTip(PictureBox_miktex, URL_miktex)
        End With
        With ToolTip_PictureBox_miktex
            .AutoPopDelay = 20000 : .InitialDelay = 100 : .ReshowDelay = 50 : .ShowAlways = True
            .SetToolTip(PictureBox_meshlab, URL_meshlab)
        End With
        With ToolTip_PictureBox_Update
            .AutoPopDelay = 20000 : .InitialDelay = 100 : .ReshowDelay = 50 : .ShowAlways = True
        End With
        With ToolTip_PictureBox_AR
            .AutoPopDelay = 20000 : .InitialDelay = 100 : .ReshowDelay = 50 : .ShowAlways = True
            .SetToolTip(PictureBox_AR, "Open PDF in Acrobat Reader")
        End With

        With ToolTip_TB_pdfLaTeX
            .AutoPopDelay = 20000 : .InitialDelay = 100 : .ReshowDelay = 50 : .ShowAlways = True
        End With
        With ToolTip_TB_MeshLab
            .AutoPopDelay = 20000 : .InitialDelay = 100 : .ReshowDelay = 50 : .ShowAlways = True
        End With
        With ToolTip_TB_AR
            .AutoPopDelay = 20000 : .InitialDelay = 100 : .ReshowDelay = 50 : .ShowAlways = True
        End With

        ' Überprüfen ob config.ini existiert
        ConfigFile = Application.StartupPath & "\" & ConfigININame
        ConfigFile_sample = Application.StartupPath & "\" & ConfigINI_sampleName
        If Not File.Exists(ConfigFile) Then
            If File.Exists(ConfigFile_sample) Then
                Try
                    File.Move(ConfigFile_sample, ConfigFile)
                Catch ex As Exception
                    ' configfile sample couldn't not be moved
                End Try
            End If
            If Not File.Exists(ConfigFile) Then
                If MsgBox("'" & ConfigFile & "' was not found. " & _
                          "A new file will be created.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel) _
                   = MsgBoxResult.Cancel Then
                    End
                End If

                '' create new 'config.ini'
                ''Dim INIFile As FileStream = File.Create(ConfigFile)
                'Dim INIFile As System.IO.StreamWriter
                'Dim enc As Encoding = New UTF8Encoding(True, True)
                'INIFile = New System.IO.StreamWriter(ConfigFile, False, enc)
                ''INIFile.WriteLine(vbNullChar)
                'INIFile.WriteLine("")
                'INIFile.Flush()
                'INIFile.Close()
                'INIFile = Nothing
            End If
        End If

        '#####################################
        If File.Exists(ConfigFile) Then
            Dim path_miktex_INI As String
            path_miktex_INI = ReadValue(Param_Section_ApplicationPaths, Param_Key_PATH_miktex, ConfigFile)

            If path_miktex_INI <> "" And _
               File.Exists(path_miktex_INI) Then
                path_miktex = path_miktex_INI
                miktex_installed = True
            End If
        End If
        '###############
        If Not miktex_installed Then
            ' Überprüfen ob pdflatex installiert ist
            Dim arrPath() As String

            ' Auslesen der "Path" Umgebungsvariablen
            arrPath = Split(Environ("Path"), ";")

            ' "Path" durchsuchen nach "miktex" und ggf. _
            ' den Pfad in path_miktex abspeichern
            For i = LBound(arrPath) To UBound(arrPath)
                If InStr(arrPath(i), "miktex") <> 0 Then
                    path_miktex = arrPath(i)
                    path_miktex = path_miktex & "\" & pdflatexName
                    ' Überprüfen ob pdflatex.exe im MikTeX Pfad vorhanden ist
                    If My.Computer.FileSystem.FileExists(path_miktex) Then
                        WriteValue(Param_Section_ApplicationPaths, Param_Key_PATH_miktex, path_miktex, ConfigFile)
                        miktex_installed = True
                        Exit For
                    End If
                End If
            Next
        End If
        ' Userselection
        If Not miktex_installed Then
            ' MiKTeX was not found
            MsgBox("'MiKTeX' was not found. Please specify the path to " & pdflatexName & ".")
            path_miktex = OFD("pdfLaTeX (" & pdflatexName & ")|" & pdflatexName, False, "Path to " & pdflatexName)
            ''path_miktex = OFD("pdfLaTeX (*.*)| *.*", False, "Path to " & pdflatexName)
            If File.Exists(path_miktex) Then
                WriteValue(Param_Section_ApplicationPaths, Param_Key_PATH_miktex, path_miktex, ConfigFile)
                miktex_installed = True
            End If
        End If

        '#####################################
        If File.Exists(ConfigFile) Then
            Dim path_meshlab_INI As String
            path_meshlab_INI = ReadValue(Param_Section_ApplicationPaths, Param_Key_PATH_meshlab, ConfigFile)

            If path_meshlab_INI <> "" And _
               File.Exists(path_meshlab_INI) Then
                path_meshlab = path_meshlab_INI
                meshlab_installed = True
            End If
        End If
        '###############
        If Not meshlab_installed Then
            ' Überprüfen ob MeshLab installiert ist
            If My.Computer.FileSystem.FileExists(Environ("ProgramFiles") & "\VCG\MeshLab\" & meshlabserverName) Then
                ' Windows x86
                path_meshlab = Environ("ProgramFiles") & "\VCG\MeshLab\" & meshlabserverName
                WriteValue(Param_Section_ApplicationPaths, Param_Key_PATH_meshlab, path_meshlab, ConfigFile)
                meshlab_installed = True
            ElseIf My.Computer.FileSystem.FileExists(Environ("ProgramFiles(x86)") & "\VCG\MeshLab\" & meshlabserverName) Then
                ' Windows x64
                path_meshlab = Environ("ProgramFiles(x86)") & "\VCG\MeshLab\" & meshlabserverName
                WriteValue(Param_Section_ApplicationPaths, Param_Key_PATH_meshlab, path_meshlab, ConfigFile)
                meshlab_installed = True
            End If
        End If
        ' Userselection
        If Not meshlab_installed Then
            ' MeshLab was not found
            MsgBox("'MeshLab' was not found. Please specify the path to " & meshlabserverName & ".")
            path_meshlab = OFD("MeshLab-Server (" & meshlabserverName & ")|" & meshlabserverName, False, "Path to " & meshlabserverName)
            ''path_meshlab = OFD("MeshLab-Server (*.*)| *.*", False, "Path to " & meshlabserverName)
            If File.Exists(path_meshlab) Then
                WriteValue(Param_Section_ApplicationPaths, Param_Key_PATH_meshlab, path_meshlab, ConfigFile)
                meshlab_installed = True
            End If
        End If

        '##
        If File.Exists(ConfigFile) Then
            Dim path_AR_INI As String
            path_AR_INI = ReadValue(Param_Section_ApplicationPaths, Param_Key_PATH_AR, ConfigFile)

            If path_AR_INI <> "" And _
                File.Exists(path_AR_INI) Then
                path_AR = path_AR_INI
                AR_installed = True
            End If
        End If

        'C:\Program Files (x86)\Adobe\Reader 10.0\Reader\AcroRd32.exe
        ' Windows x86
        If Not AR_installed Then
            For i = 20 To 7 Step -1
                path_AR = Environ("ProgramFiles") & "\Adobe\Reader " & i & ".0\Reader\" & ARName
                If File.Exists(path_AR) Then
                    WriteValue(Param_Section_ApplicationPaths, Param_Key_PATH_AR, path_AR, ConfigFile)
                    AR_installed = True
                    Exit For
                End If
            Next
        End If
        ' Windows x64
        If Not AR_installed Then
            For i = 20 To 7 Step -1
                path_AR = Environ("ProgramFiles(x86)") & "\Adobe\Reader " & i & ".0\Reader\" & ARName
                If File.Exists(path_AR) Then
                    WriteValue(Param_Section_ApplicationPaths, Param_Key_PATH_AR, path_AR, ConfigFile)
                    AR_installed = True
                    Exit For
                End If
            Next
        End If

        If miktex_installed Then
            TB_pdfLaTeX.Text = path_miktex
        End If
        If meshlab_installed Then
            TB_MeshLab.Text = path_meshlab
        End If
        If AR_installed Then
            TB_AR.Text = path_AR
        End If
    End Sub

    Private Sub UserForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        AR_enabled_image = PictureBox_AR.Image
        AR_disabled_image = PictureBox_AR.InitialImage

        With ToolTip_TB_pdfLaTeX
            .SetToolTip(TB_pdfLaTeX, TB_pdfLaTeX.Text)
        End With
        With ToolTip_TB_MeshLab
            .SetToolTip(TB_MeshLab, TB_MeshLab.Text)
        End With
        With ToolTip_TB_AR
            .SetToolTip(TB_AR, TB_AR.Text)
        End With

        ' reset UserForm
        Form_Reset()
        FillInStandardSettings()
    End Sub

    Private Sub UserForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If output_file <> vbNullString _
            And File.Exists(output_file) Then

            Dim MyFile As New FileInfo(output_file)
            Dim FileSize As Long = MyFile.Length

            ' if output-file was created but user quit _
            ' the program
            If MyFile.Exists And FileSize = 0 Then _
                MyFile.Delete()
        End If
    End Sub

    Private Sub UserForm_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        If Not newUpdate Then
            PictureBox_Update.Visible = False
        ElseIf newUpdate And Not PictureBox_Update.Visible Then
            PictureBox_Update.Visible = True
            ToolTip_PictureBox_Update.SetToolTip(PictureBox_Update, "Update available")
        End If
        If AR_installed And Not PictureBox_AR.Visible Then
            PictureBox_AR.Visible = True
        ElseIf Not AR_installed And PictureBox_AR.Visible Then
            PictureBox_AR.Visible = False
        End If
    End Sub


    '===============================================================================
    ' EVENTS - BUTTONS
    '----------------------------------------------------------
    Private Sub Button_FileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_FileOpen.Click
        ' UserForm zurücksetzten
        Form_Reset()

        If RadioButton_SingleFileMode.Checked Then
            ' single file mode
            input_file = OFD("All supported files (*.stl;*.wrl)|*.stl;*.wrl|" & _
                             "STL-files (*.stl)|*.stl|VRML-files (*.wrl)|*.wrl", _
                             False, "Select a model file")
            If input_file <> vbNullString Then
                TextBox_FileOpen.Text = input_file
                output_file_name = VB.Right(input_file, Len(input_file) - InStrRev(input_file, "\"))
                output_folder = VB.Left(input_file, InStrRev(input_file, "\") - 1)
                ' FileSave Button aktivieren
                Button_FileSave.Enabled = True
                Button_SaveTeX.Enabled = True
                ToolTip_FileOpen.SetToolTip(TextBox_FileOpen, input_file)
            End If
        Else
            ' folder mode
            input_folder_BATCH = OFolderD()

            If Not input_folder_BATCH = vbNullString _
                And Directory.Exists(input_folder_BATCH) Then

                Dim FileName As String
                Dim FileNames As System.Collections.IEnumerable = Directory.EnumerateFiles(input_folder_BATCH)

                Dim FileNameExt As String
                For Each FileName In FileNames
                    If VB.InStr(FileName, ".") <> 0 Then

                        FileNameExt = FileExt(FileName)
                        If StrConv(FileNameExt, vbLowerCase) = "stl" _
                            Or StrConv(FileNameExt, vbLowerCase) = "wrl" Then
                            ModelFileNames_BATCH.Add(FileName)
                        End If
                    End If
                Next

                Dim ModelsCount As Integer = ModelFileNames_BATCH.Count
                If ModelsCount <> 0 Then
                    TextBox_FileOpen.Text = input_folder_BATCH

                    MsgBox(ModelsCount & " File(s) found.")
                    ' FileSave Button aktivieren
                    Button_FileSave.Enabled = True
                    Button_SaveTeX.Enabled = True
                    ToolTip_FileOpen.SetToolTip(TextBox_FileOpen, input_folder_BATCH)
                Else
                    MsgBox("No .stl or .wrl files were found.")
                End If


            End If
        End If
    End Sub

    Private Sub Button_FileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_FileSave.Click
        output_file = SFD("PDF-file (*.pdf)|*.pdf")
        If output_file <> vbNullString Then
            If VB.Left(output_file, 1) = "\" Then
                If File.Exists(output_file) Then File.Delete(output_file)
                MsgBox("Network drives are not supported yet. Please use a local drive.", vbExclamation)
            Else
                output_file_name = VB.Right(output_file, Len(output_file) - InStrRev(output_file, "\"))
                output_folder = VB.Left(output_file, InStrRev(output_file, "\") - 1)
                TextBox_FileSave.Text = output_file
                ' Start Button aktivieren
                Button_Start.Enabled = True
                ToolTip_FileSave.SetToolTip(TextBox_FileSave, output_file)
            End If
        End If
    End Sub

    Private Sub Button_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Start.Click
        ' Start Button deaktivieren
        Button_Start.Enabled = False
        ' FileSave Button deaktivieren
        Button_FileSave.Enabled = False

        If RadioButton_SingleFileMode.Checked Then
            ' single file mode


            If output_file <> vbNullString And output_file <> "" Then
                Dim myFile As New FileInfo(output_file)
                Dim myFileSize As Long = myFile.Length
                If myFileSize <> 0 Then
                    If MsgBox("Do you want to overwrite the exsisting file?" & Chr(10) & _
                              output_file, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        ' reenable buttons
                        Button_Start.Enabled = True
                        Button_FileSave.Enabled = True
                        Exit Sub
                    End If
                End If
            End If

            ' if temp-folder not writable use output-folder
            If Not IsFolderWritable(DIR_TEMP) Then
                DIR_TEMP = output_folder
            End If

            Dim u3d_tempfile As String = DIR_TEMP & "\" & TF_U3DName

            If input_file = "" Or output_file = "" Then
                ' Falls Input oder Output nicht definiert wurden
                MsgBox("Please define a source- and target file first.", MsgBoxStyle.Exclamation)
            Else
                ' Falls Input und Output definiert sind

                ' MeshLab aufrufen
                If Not RunMeshLab(u3d_tempfile) Then Exit Sub

                Dim texFilePath As String = DIR_TEMP & "\" & TF_TexName
                If Not GenerateTeXFile(texFilePath) Then Exit Sub

                ' PDFLatex aufrufen
                If Not RunMiKTeX(DIR_TEMP, TF_TexName) Then Exit Sub

                With My.Computer.FileSystem
                    ' PDF umbenennen/verschieben
                    Try
                        .MoveFile(DIR_TEMP & "\" & TF_PDFName, output_folder & "\" & output_file_name, True)
                    Catch ex As Exception
                        ' File was not created or couldn't be moved
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try

                    Try
                        ' TEMP-Dateien löschen
                        ' in den Papierkorb
                        .DeleteFile(DIR_TEMP & "\" & TF_LOGName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                        .DeleteFile(DIR_TEMP & "\" & TF_TexName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                        .DeleteFile(DIR_TEMP & "\" & TF_U3DName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)

                        ' löschen
                        .DeleteFile(DIR_TEMP & "\" & TF_AUXName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                        .DeleteFile(DIR_TEMP & "\" & TF_OUTName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                        .DeleteFile(DIR_TEMP & "\" & TF_U3DTEXName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                    Catch ex As Exception
                        ' temp files couldn't be deleted
                    End Try
                End With

                ' OpenPDF Button aktivieren
                Button_OpenPDF.Enabled = True
                With PictureBox_AR
                    .Enabled = True
                    .Image = AR_enabled_image
                End With
            End If

            MsgBox("PDF created successfully." & Chr(10) & _
                   output_file, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Else
            For Each f1 In ModelFileNames_BATCH
                MsgBox(f1)
            Next

        End If


        ' reenable buttons
        Button_Start.Enabled = True
        Button_FileSave.Enabled = True
    End Sub

    Private Sub Button_OpenPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OpenPDF.Click
        ' open the pdf file
        If File.Exists(output_folder & "\" & output_file_name) Then
            System.Diagnostics.Process.Start(output_folder & "\" & output_file_name)
        End If
    End Sub

    Private Sub Button_ResetOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ResetOptions.Click
        FillInStandardSettings()
    End Sub

    Private Sub Button_Reset3DOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Reset3DOptions.Click
        FillInStandard3DSettings()
    End Sub

    Private Sub Button_SaveTeX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SaveTeX.Click
        Dim texFilePath As String = SFD("TeX-file (*.tex)|*.tex")
        If texFilePath <> vbNullString And texFilePath <> "" Then
            Dim FilePath As String = VB.Left(texFilePath, (VB.InStrRev(texFilePath, "\") - 1))
            'Dim FileName As String = RemFileExt(output_file_name)
            Dim FileName As String = RemFileExt(VB.Right(texFilePath, (VB.Len(texFilePath) - InStrRev(texFilePath, "\"))))

            Dim U3D_FileName_tex As String = FileName & ".tex"
            Dim U3D_FileName_u3d As String = FileName & ".u3d"

            If RunMeshLab(FilePath & "\" & U3D_FileName_u3d) Then
                ' Remove .tex that was automaticlly created by MeshLab
                If File.Exists(U3D_FileName_tex) Then File.Delete(U3D_FileName_tex)

                Dim U3D_FileName_BAK As String = U3D_FileName
                U3D_FileName = U3D_FileName_u3d
                GenerateTeXFile(texFilePath)
                U3D_FileName = U3D_FileName_BAK

                MsgBox("TeX file successfully written." & Chr(10) & _
                       texFilePath, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Else
                MsgBox("An error occurred writting the TeX file." & Chr(10) & _
                       texFilePath, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    Private Sub Button_AppPathsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AppPathsSave.Click
        If File.Exists(ConfigFile) Then
            Dim DataWasWritten As Boolean = True
            Try
                If File.Exists(path_miktex) _
                    And path_miktex <> ReadValue(Param_Section_ApplicationPaths, Param_Key_PATH_miktex, ConfigFile) Then
                    WriteValue(Param_Section_ApplicationPaths, Param_Key_PATH_miktex, path_miktex, ConfigFile)
                    miktex_installed = True
                    '' check if data was written
                    If path_miktex <> ReadValue(Param_Section_ApplicationPaths, Param_Key_PATH_miktex, ConfigFile) Then
                        DataWasWritten = False
                    End If
                End If

                If File.Exists(path_meshlab) _
                    And path_meshlab <> ReadValue(Param_Section_ApplicationPaths, Param_Key_PATH_meshlab, ConfigFile) Then
                    WriteValue(Param_Section_ApplicationPaths, Param_Key_PATH_meshlab, path_meshlab, ConfigFile)
                    meshlab_installed = True
                    If path_meshlab <> ReadValue(Param_Section_ApplicationPaths, Param_Key_PATH_meshlab, ConfigFile) Then
                        DataWasWritten = False
                    End If
                End If

                If File.Exists(path_AR) _
                    And path_AR <> ReadValue(Param_Section_ApplicationPaths, Param_Key_PATH_AR, ConfigFile) Then
                    WriteValue(Param_Section_ApplicationPaths, Param_Key_PATH_AR, path_AR, ConfigFile)
                    AR_installed = True
                    If path_AR <> ReadValue(Param_Section_ApplicationPaths, Param_Key_PATH_AR, ConfigFile) Then
                        DataWasWritten = False
                    End If
                End If

                If DataWasWritten Then
                    Button_AppPathsSave.Enabled = False
                Else
                    MsgBox("There was an error updating the config file. " & _
                           "The file might be write-protected or locked by an other application.", _
                           MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    Button_AppPathsSave.Enabled = True
                End If

            Catch ex As Exception
                MsgBox("There was an error updating the config file. " & _
                       "The file might be locked by an other application.", _
                       MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Button_AppPathsSave.Enabled = True
            End Try
        Else
            MsgBox("The config file was not found. Please restart U3D-2-PDF to create a new one.", MsgBoxStyle.Critical)
            Button_AppPathsSave.Enabled = True
        End If
    End Sub


    '===============================================================================
    ' EVENTS - PICTUREBOXES
    '----------------------------------------------------------
    Private Sub PictureBox_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_About.Click
        F_About.Show()
    End Sub

    Private Sub PictureBox_miktex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_miktex.Click
        System.Diagnostics.Process.Start(URL_miktex)
    End Sub

    Private Sub PictureBox_meshlab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_meshlab.Click
        System.Diagnostics.Process.Start(URL_meshlab)
    End Sub

    Private Sub PictureBox_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Update.Click
        DownloadUpdate()
    End Sub

    Private Sub PictureBox_AR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_AR.Click
        If File.Exists(path_AR) Then
            Try
                Dim p As New Process()
                p.StartInfo.FileName = path_AR
                p.StartInfo.Arguments = output_file
                p.StartInfo.UseShellExecute = False
                p.StartInfo.RedirectStandardOutput = True
                p.StartInfo.CreateNoWindow = True
                p.Start()
                ''Dim sOutput As String
                ''sOutput = p.StandardOutput.ReadToEnd()
                ''p.WaitForExit()
                ''p.Close()
                ''MessageBox.Show(sOutput)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub


    '===============================================================================
    ' EVENTS - RADIOBOXES
    '----------------------------------------------------------
    Private Sub RB_A4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_A4.CheckedChanged
        UpdatePaperLayout()
    End Sub

    Private Sub RB_Landscape_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Landscape.CheckedChanged
        UpdatePaperLayout()
    End Sub

    Private Sub RadioButton_SingleFileMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_SingleFileMode.CheckedChanged
        Mode_Update()
    End Sub

    'Private Sub RadioButton_FolderMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_FolderMode.CheckedChanged
    '    Mode_Update()
    'End Sub

    Private Sub Mode_Update()
        If RadioButton_SingleFileMode.Checked Then
            If Not Button_FileOpen.Text = "Source File" Then _
                Button_FileOpen.Text = "Source File"
            If Not Button_FileSave.Text = "Target File" Then _
                Button_FileSave.Text = "Target File"
        Else
            If Not Button_FileOpen.Text = "Source Folder" Then _
                Button_FileOpen.Text = "Source Folder"
            If Not Button_FileSave.Text = "Target Folder" Then _
                Button_FileSave.Text = "Target Folder"

        End If
    End Sub

    '===============================================================================
    ' EVENTS - TEXTBOXES
    '----------------------------------------------------------
    Private Sub TB_top_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TB_top.Leave
        Dim curText As String = TB_top.Text
        curText = RemNaNFromString(curText)
        If VB.Len(curText) <> 0 Then
            Dim LengthToCompare As Integer = CInt(TB_height.Text) - CInt(TB_bottom.Text)
            If VB.Left(curText, 1) = "-" Then
                curText = VB.Right(curText, (VB.Len(curText) - 1))
            ElseIf VB.Len(curText) > 1 And VB.Left(curText, 1) = "0" Then
                curText = VB.Right(curText, (VB.Len(curText) - 1))
            End If

            If CInt(curText) > LengthToCompare Then
                curText = CStr(LengthToCompare)
            End If
        End If
        TB_top.Text = curText
    End Sub

    Private Sub TB_bottom_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TB_bottom.Leave
        Dim curText As String = TB_bottom.Text
        curText = RemNaNFromString(curText)
        If VB.Len(curText) <> 0 Then
            Dim LengthToCompare As Integer = CInt(TB_height.Text) - CInt(TB_top.Text)
            If VB.Left(curText, 1) = "-" Then
                curText = VB.Right(curText, (VB.Len(curText) - 1))
            ElseIf VB.Len(curText) > 1 And VB.Left(curText, 1) = "0" Then
                curText = VB.Right(curText, (VB.Len(curText) - 1))
            End If

            If CInt(curText) > LengthToCompare Then
                curText = CStr(LengthToCompare)
            End If
        End If
        TB_bottom.Text = curText
    End Sub

    Private Sub TB_right_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TB_right.Leave
        Dim curText As String = TB_right.Text
        curText = RemNaNFromString(curText)
        If VB.Len(curText) <> 0 Then
            Dim LengthToCompare As Integer = CInt(TB_width.Text) - CInt(TB_left.Text)
            If VB.Left(curText, 1) = "-" Then
                curText = VB.Right(curText, (VB.Len(curText) - 1))
            ElseIf VB.Len(curText) > 1 And VB.Left(curText, 1) = "0" Then
                curText = VB.Right(curText, (VB.Len(curText) - 1))
            End If

            If CInt(curText) > LengthToCompare Then
                curText = CStr(LengthToCompare)
            End If
        End If
        TB_right.Text = curText
    End Sub

    Private Sub TB_left_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TB_left.Leave
        Dim curText As String = TB_left.Text
        curText = RemNaNFromString(curText)
        If VB.Len(curText) <> 0 Then
            Dim LengthToCompare As Integer = CInt(TB_width.Text) - CInt(TB_right.Text)
            If VB.Left(curText, 1) = "-" Then
                curText = VB.Right(curText, (VB.Len(curText) - 1))
            ElseIf VB.Len(curText) > 1 And VB.Left(curText, 1) = "0" Then
                curText = VB.Right(curText, (VB.Len(curText) - 1))
            End If

            If CInt(curText) > LengthToCompare Then
                curText = CStr(LengthToCompare)
            End If
        End If
        TB_left.Text = curText
    End Sub

    Private Sub TB_width_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_width.TextChanged
        TB_WH_update()
    End Sub

    Private Sub TB_height_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_height.TextChanged
        TB_WH_update()
    End Sub

    Private Sub TB_pdfLaTeX_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TB_pdfLaTeX.DoubleClick
        Dim newPath_miktex As String = OFD(pdflatexName & " (" & pdflatexName & ")|" & pdflatexName, _
                                            False, "Select " & pdflatexName)

        If File.Exists(newPath_miktex) And Not newPath_miktex = vbNullString Then
            If newPath_miktex <> TB_pdfLaTeX.Text Then
                Button_AppPathsSave.Enabled = True
                TB_pdfLaTeX.Text = newPath_miktex
                path_miktex = newPath_miktex
                miktex_installed = True
                With ToolTip_TB_pdfLaTeX
                    .SetToolTip(TB_pdfLaTeX, newPath_miktex)
                End With
            End If
        End If
    End Sub

    Private Sub TB_MeshLab_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TB_MeshLab.DoubleClick
        Dim newPath_meshlab As String = OFD(meshlabserverName & " (" & meshlabserverName & ")|" & meshlabserverName, _
                                            False, "Select " & meshlabserverName)

        If File.Exists(newPath_meshlab) And Not newPath_meshlab = vbNullString Then
            If newPath_meshlab <> TB_MeshLab.Text Then
                Button_AppPathsSave.Enabled = True
                TB_MeshLab.Text = newPath_meshlab
                path_meshlab = newPath_meshlab
                meshlab_installed = True
                With ToolTip_TB_MeshLab
                    .SetToolTip(TB_MeshLab, newPath_meshlab)
                End With
            End If
        End If
    End Sub

    Private Sub TB_AR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TB_AR.DoubleClick
        Dim newPath_AR As String = OFD(ARName & " (" & ARName & ")|" & ARName, _
                                       False, "Select " & ARName)

        If File.Exists(newPath_AR) And Not newPath_AR = vbNullString Then
            If newPath_AR <> TB_AR.Text Then
                Button_AppPathsSave.Enabled = True
                TB_AR.Text = newPath_AR
                path_AR = newPath_AR
                AR_installed = True
                With ToolTip_TB_AR
                    .SetToolTip(TB_AR, newPath_AR)
                End With
            End If

            With PictureBox_AR
                If output_file = "" Then
                    .Enabled = False
                    .Image = AR_disabled_image
                Else
                    .Enabled = True
                    .Image = AR_enabled_image
                End If
            End With
        End If
    End Sub


    '===============================================================================
    ' EVENTS - LABELS
    '----------------------------------------------------------
    Private Sub Link_OpenConfig_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_OpenConfig.LinkClicked
        Try
            System.Diagnostics.Process.Start(ConfigFile)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub


    '===============================================================================
    ' USERFORM FUNCTIONS
    '----------------------------------------------------------
    Private Sub Form_Reset()
        ' Variablen
        input_file = ""
        output_file = ""
        output_file_name = ""
        output_folder = ""

        ' UserForm initializieren
        Button_FileSave.Enabled = False
        Button_Start.Enabled = False
        Button_OpenPDF.Enabled = False
        With PictureBox_AR
            .Enabled = False
            .Image = AR_disabled_image
        End With

        Button_SaveTeX.Enabled = False

        TextBox_FileOpen.Text = ""
        TextBox_FileSave.Text = ""
        ToolTip_FileOpen.SetToolTip(TextBox_FileOpen, "")
        ToolTip_FileSave.SetToolTip(TextBox_FileSave, "")


        '###
        ' for testing
        'miktex_installed = False
        'meshlab_installed = False

        If Not miktex_installed Or Not meshlab_installed Then
            MsgBox("MiKTeX found: " & miktex_installed & Chr(10) & _
                   "MeshLab found: " & meshlab_installed & Chr(10) & Chr(10) & _
                   "MiKTeX (" & URL_miktex & ") and MeshLab (" & URL_meshlab & ") have to be installed. " & _
                   Chr(10) & Chr(10) & "(You can manually update paths in the '" & ConfigININame & "' file)", _
                   MsgBoxStyle.Exclamation)
            Button_FileOpen.Enabled = False
        End If
    End Sub

    Private Sub UpdatePaperLayout()
        If RB_A4.Checked And RB_Landscape.Checked Then
            TB_width.Text = A4_standard_height
            TB_height.Text = A4_standard_width
        ElseIf RB_A4.Checked And Not RB_Landscape.Checked Then
            TB_width.Text = A4_standard_width
            TB_height.Text = A4_standard_height
        ElseIf RB_A5.Checked And RB_Landscape.Checked Then
            TB_width.Text = A5_standard_height
            TB_height.Text = A5_standard_width
        ElseIf RB_A5.Checked And Not RB_Landscape.Checked Then
            TB_width.Text = A5_standard_width
            TB_height.Text = A5_standard_height
        End If
    End Sub

    Private Sub FillInStandardSettings()
        U3D_FileName = U3D_standard_FileName
        TB_height.Text = Param_standard_height
        TB_width.Text = Param_standard_width
        TB_top.Text = Param_standard_margin_top
        TB_right.Text = Param_standard_margin_right
        TB_bottom.Text = Param_standard_margin_bottom
        TB_left.Text = Param_standard_margin_left
        FillInStandard3DSettings()

        RB_A4.Checked = True
        RB_Landscape.Checked = True
    End Sub

    Private Sub FillInStandard3DSettings()
        TB_aac.Text = Param_standard_acc
        TB_roll.Text = Param_standard_roll
        TB_c2c_1.Text = Param_standard_c2c_1
        TB_c2c_2.Text = Param_standard_c2c_2
        TB_c2c_3.Text = Param_standard_c2c_3
        TB_roo.Text = Param_standard_roo
        TB_lights.Text = Param_standard_lights
        TB_coo_1.Text = Param_standard_coo_1
        TB_coo_2.Text = Param_standard_coo_2
        TB_coo_3.Text = Param_standard_coo_3
    End Sub

    Private Sub TB_WH_update()
        Try
            ' adjust bottom and right
            Dim difWidth As Integer = CInt(TB_width.Text) - CInt(TB_left.Text)
            If CInt(TB_right.Text) > difWidth Then
                If difWidth < 0 Then
                    TB_right.Text = "0"
                    TB_left.Text = CStr(CInt(TB_left.Text) + difWidth)
                Else
                    TB_right.Text = CStr(difWidth)
                End If
            End If

            Dim difHeight As Integer = CInt(TB_height.Text) - CInt(TB_top.Text)
            If CInt(TB_bottom.Text) > difHeight Then
                If difHeight < 0 Then
                    TB_bottom.Text = "0"
                    TB_top.Text = CStr(CInt(TB_top.Text) + difHeight)
                Else
                    TB_bottom.Text = CStr(difHeight)
                End If
            End If
        Catch ex As Exception
            TB_top.Text = "0"
            TB_bottom.Text = "0"
            TB_left.Text = "0"
            TB_right.Text = "0"
        End Try
    End Sub


    '===============================================================================
    ' EXECUTE MESHLAB & MIKTEX
    '----------------------------------------------------------
    Private Function RunMeshLab(ByVal u3d_file As String) As Boolean
        RunMeshLab = True
        Try
            Shell(Chr(34) & path_meshlab & Chr(34) & " -i " & Chr(34) & input_file & Chr(34) & " -o " & _
                  Chr(34) & u3d_file & Chr(34), AppWinStyle.NormalFocus, True)
        Catch ex As Exception
            MsgBox("There was a problem running MeshLab. Please check the path in the " & ConfigININame & ".")
            RunMeshLab = False
        End Try
    End Function

    Private Function RunMiKTeX(ByVal iDirectory As String, ByVal iTeXName As String) As Boolean
        RunMiKTeX = True
        Try
            Shell(Chr(34) & path_miktex & Chr(34) & " " & _
                  Chr(34) & iDirectory & "\" & iTeXName & Chr(34) & " -output-directory " & _
                  Chr(34) & iDirectory & Chr(34), AppWinStyle.NormalFocus, True)
        Catch ex As Exception
            MsgBox("There was a problem running MiKTeX. Please check the path in the " & ConfigININame & ".")
            RunMiKTeX = False
        End Try
    End Function

    Private Function GenerateTeXFile(ByVal iTeXFilePath) As Boolean
        GenerateTeXFile = True

        If RB_A4.Checked And RB_Landscape.Checked Then
            Param_width = A4_standard_height
            Param_height = A4_standard_width
            Param_papersize = "a4"
            Param_orienation = "landscape"
        ElseIf RB_A4.Checked And Not RB_Landscape.Checked Then
            Param_width = A4_standard_width
            Param_height = A4_standard_height
            Param_papersize = "a4"
            Param_orienation = "portrait"
        ElseIf RB_A5.Checked And RB_Landscape.Checked Then
            Param_width = A5_standard_height
            Param_height = A5_standard_width
            Param_papersize = "a5"
            Param_orienation = "landscape"
        ElseIf RB_A5.Checked And Not RB_Landscape.Checked Then
            Param_width = A5_standard_width
            Param_height = A5_standard_height
            Param_papersize = "a5"
            Param_orienation = "portrait"
        End If

        ' just margin top is positive
        Param_margin_top = TB_top.Text

        If TB_bottom.Text <> "0" Then
            Param_margin_bottom = "-" & TB_bottom.Text
        Else
            Param_margin_bottom = TB_bottom.Text
        End If

        If TB_left.Text <> "0" Then
            Param_margin_right = "-" & TB_left.Text
        Else
            Param_margin_right = TB_left.Text
        End If

        If TB_right.Text <> "0" Then
            Param_margin_left = "-" & TB_right.Text
        Else
            Param_margin_left = TB_right.Text
        End If

        Param_width = CStr(CInt(Param_width) + CInt(Param_margin_left) + CInt(Param_margin_right))
        Param_height = CStr(CInt(Param_height) - CInt(Param_margin_top) + CInt(Param_margin_bottom))

        Param_acc = TB_aac.Text
        Param_roll = TB_roll.Text
        Param_c2c_1 = TB_c2c_1.Text
        Param_c2c_2 = TB_c2c_2.Text
        Param_c2c_3 = TB_c2c_3.Text
        Param_roo = TB_roo.Text
        Param_coo_1 = TB_coo_1.Text
        Param_coo_2 = TB_coo_2.Text
        Param_coo_3 = TB_coo_3.Text
        Param_lights = TB_lights.Text

        Try
            Dim texFile As System.IO.StreamWriter
            Dim ANSIEncoding As Encoding

            ANSIEncoding = System.Text.Encoding.GetEncoding(1252)
            texFile = New System.IO.StreamWriter(iTeXFilePath, False, ANSIEncoding)
            texFile.WriteLine(U3D_TO_PDF__tex.texStr)
            texFile.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            GenerateTeXFile = False
        End Try
    End Function

End Class

