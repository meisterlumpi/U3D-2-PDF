<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_MAIN
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_MAIN))
        Me.Button_FileOpen = New System.Windows.Forms.Button()
        Me.Button_FileSave = New System.Windows.Forms.Button()
        Me.TextBox_FileOpen = New System.Windows.Forms.TextBox()
        Me.TextBox_FileSave = New System.Windows.Forms.TextBox()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_OpenPDF = New System.Windows.Forms.Button()
        Me.PictureBox_meshlab = New System.Windows.Forms.PictureBox()
        Me.PictureBox_miktex = New System.Windows.Forms.PictureBox()
        Me.PictureBox_About = New System.Windows.Forms.PictureBox()
        Me.ToolTip_FileOpen = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip_FileSave = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip_PictureBox_miktex = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip_PictureBox_meshlab = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox_Update = New System.Windows.Forms.PictureBox()
        Me.ToolTip_PictureBox_Update = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button_SaveTeX = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RB_Portrait = New System.Windows.Forms.RadioButton()
        Me.RB_Landscape = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RB_A5 = New System.Windows.Forms.RadioButton()
        Me.RB_A4 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_top = New System.Windows.Forms.TextBox()
        Me.TB_right = New System.Windows.Forms.TextBox()
        Me.TB_left = New System.Windows.Forms.TextBox()
        Me.TB_bottom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_height = New System.Windows.Forms.TextBox()
        Me.TB_width = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button_Reset3DOptions = New System.Windows.Forms.Button()
        Me.TB_coo_3 = New System.Windows.Forms.TextBox()
        Me.TB_coo_2 = New System.Windows.Forms.TextBox()
        Me.TB_coo_1 = New System.Windows.Forms.TextBox()
        Me.TB_lights = New System.Windows.Forms.TextBox()
        Me.TB_roo = New System.Windows.Forms.TextBox()
        Me.TB_c2c_3 = New System.Windows.Forms.TextBox()
        Me.TB_c2c_2 = New System.Windows.Forms.TextBox()
        Me.TB_c2c_1 = New System.Windows.Forms.TextBox()
        Me.TB_roll = New System.Windows.Forms.TextBox()
        Me.TB_aac = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Link_OpenConfig = New System.Windows.Forms.LinkLabel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TB_AR = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TB_MeshLab = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TB_pdfLaTeX = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button_AppPathsSave = New System.Windows.Forms.Button()
        Me.Button_ResetOptions = New System.Windows.Forms.Button()
        Me.PictureBox_AR = New System.Windows.Forms.PictureBox()
        Me.ToolTip_PictureBox_AR = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip_TB_pdfLaTeX = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip_TB_MeshLab = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip_TB_AR = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton_FolderMode = New System.Windows.Forms.RadioButton()
        Me.RadioButton_SingleFileMode = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox_meshlab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_miktex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_About, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox_AR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_FileOpen
        '
        Me.Button_FileOpen.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_FileOpen.Location = New System.Drawing.Point(5, 32)
        Me.Button_FileOpen.Name = "Button_FileOpen"
        Me.Button_FileOpen.Size = New System.Drawing.Size(81, 23)
        Me.Button_FileOpen.TabIndex = 0
        Me.Button_FileOpen.Text = "Source File"
        Me.Button_FileOpen.UseVisualStyleBackColor = False
        '
        'Button_FileSave
        '
        Me.Button_FileSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_FileSave.Location = New System.Drawing.Point(5, 61)
        Me.Button_FileSave.Name = "Button_FileSave"
        Me.Button_FileSave.Size = New System.Drawing.Size(81, 23)
        Me.Button_FileSave.TabIndex = 0
        Me.Button_FileSave.Text = "Target File"
        Me.Button_FileSave.UseVisualStyleBackColor = False
        '
        'TextBox_FileOpen
        '
        Me.TextBox_FileOpen.Location = New System.Drawing.Point(92, 34)
        Me.TextBox_FileOpen.Name = "TextBox_FileOpen"
        Me.TextBox_FileOpen.ReadOnly = True
        Me.TextBox_FileOpen.Size = New System.Drawing.Size(350, 20)
        Me.TextBox_FileOpen.TabIndex = 1
        '
        'TextBox_FileSave
        '
        Me.TextBox_FileSave.Location = New System.Drawing.Point(92, 63)
        Me.TextBox_FileSave.Name = "TextBox_FileSave"
        Me.TextBox_FileSave.ReadOnly = True
        Me.TextBox_FileSave.Size = New System.Drawing.Size(350, 20)
        Me.TextBox_FileSave.TabIndex = 1
        '
        'Button_Start
        '
        Me.Button_Start.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Start.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button_Start.Location = New System.Drawing.Point(367, 89)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(75, 23)
        Me.Button_Start.TabIndex = 2
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = False
        '
        'Button_OpenPDF
        '
        Me.Button_OpenPDF.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_OpenPDF.Location = New System.Drawing.Point(367, 292)
        Me.Button_OpenPDF.Name = "Button_OpenPDF"
        Me.Button_OpenPDF.Size = New System.Drawing.Size(75, 23)
        Me.Button_OpenPDF.TabIndex = 3
        Me.Button_OpenPDF.Text = "Open PDF"
        Me.Button_OpenPDF.UseVisualStyleBackColor = False
        '
        'PictureBox_meshlab
        '
        Me.PictureBox_meshlab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_meshlab.Image = Global.U3D_2_PDF.My.Resources.Resources.LOGO_meshlab
        Me.PictureBox_meshlab.Location = New System.Drawing.Point(166, 275)
        Me.PictureBox_meshlab.Name = "PictureBox_meshlab"
        Me.PictureBox_meshlab.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox_meshlab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_meshlab.TabIndex = 6
        Me.PictureBox_meshlab.TabStop = False
        '
        'PictureBox_miktex
        '
        Me.PictureBox_miktex.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_miktex.Image = Global.U3D_2_PDF.My.Resources.Resources.LOGO_miktex
        Me.PictureBox_miktex.Location = New System.Drawing.Point(5, 275)
        Me.PictureBox_miktex.Name = "PictureBox_miktex"
        Me.PictureBox_miktex.Size = New System.Drawing.Size(155, 40)
        Me.PictureBox_miktex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_miktex.TabIndex = 5
        Me.PictureBox_miktex.TabStop = False
        '
        'PictureBox_About
        '
        Me.PictureBox_About.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_About.Image = Global.U3D_2_PDF.My.Resources.Resources.about_128
        Me.PictureBox_About.Location = New System.Drawing.Point(319, 273)
        Me.PictureBox_About.Name = "PictureBox_About"
        Me.PictureBox_About.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox_About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_About.TabIndex = 8
        Me.PictureBox_About.TabStop = False
        '
        'PictureBox_Update
        '
        Me.PictureBox_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_Update.Image = Global.U3D_2_PDF.My.Resources.Resources.alert_128
        Me.PictureBox_Update.Location = New System.Drawing.Point(271, 273)
        Me.PictureBox_Update.Name = "PictureBox_Update"
        Me.PictureBox_Update.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Update.TabIndex = 9
        Me.PictureBox_Update.TabStop = False
        Me.PictureBox_Update.Visible = False
        '
        'Button_SaveTeX
        '
        Me.Button_SaveTeX.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_SaveTeX.Location = New System.Drawing.Point(367, 161)
        Me.Button_SaveTeX.Name = "Button_SaveTeX"
        Me.Button_SaveTeX.Size = New System.Drawing.Size(75, 37)
        Me.Button_SaveTeX.TabIndex = 11
        Me.Button_SaveTeX.Text = "Save .tex file"
        Me.Button_SaveTeX.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "aac"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(5, 90)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(356, 169)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TB_top)
        Me.TabPage1.Controls.Add(Me.TB_right)
        Me.TabPage1.Controls.Add(Me.TB_left)
        Me.TabPage1.Controls.Add(Me.TB_bottom)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TB_height)
        Me.TabPage1.Controls.Add(Me.TB_width)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(348, 143)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Page Layout"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Height"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Width"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RB_Portrait)
        Me.Panel2.Controls.Add(Me.RB_Landscape)
        Me.Panel2.Location = New System.Drawing.Point(63, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(82, 48)
        Me.Panel2.TabIndex = 36
        '
        'RB_Portrait
        '
        Me.RB_Portrait.AutoSize = True
        Me.RB_Portrait.Location = New System.Drawing.Point(3, 26)
        Me.RB_Portrait.Name = "RB_Portrait"
        Me.RB_Portrait.Size = New System.Drawing.Size(58, 17)
        Me.RB_Portrait.TabIndex = 1
        Me.RB_Portrait.Text = "Portrait"
        Me.RB_Portrait.UseVisualStyleBackColor = True
        '
        'RB_Landscape
        '
        Me.RB_Landscape.AutoSize = True
        Me.RB_Landscape.Checked = True
        Me.RB_Landscape.Location = New System.Drawing.Point(3, 3)
        Me.RB_Landscape.Name = "RB_Landscape"
        Me.RB_Landscape.Size = New System.Drawing.Size(78, 17)
        Me.RB_Landscape.TabIndex = 0
        Me.RB_Landscape.TabStop = True
        Me.RB_Landscape.Text = "Landscape"
        Me.RB_Landscape.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RB_A5)
        Me.Panel1.Controls.Add(Me.RB_A4)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(45, 48)
        Me.Panel1.TabIndex = 35
        '
        'RB_A5
        '
        Me.RB_A5.AutoSize = True
        Me.RB_A5.Location = New System.Drawing.Point(3, 26)
        Me.RB_A5.Name = "RB_A5"
        Me.RB_A5.Size = New System.Drawing.Size(38, 17)
        Me.RB_A5.TabIndex = 1
        Me.RB_A5.Text = "A5"
        Me.RB_A5.UseVisualStyleBackColor = True
        '
        'RB_A4
        '
        Me.RB_A4.AutoSize = True
        Me.RB_A4.Checked = True
        Me.RB_A4.Location = New System.Drawing.Point(3, 3)
        Me.RB_A4.Name = "RB_A4"
        Me.RB_A4.Size = New System.Drawing.Size(38, 17)
        Me.RB_A4.TabIndex = 0
        Me.RB_A4.TabStop = True
        Me.RB_A4.Text = "A4"
        Me.RB_A4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Orientation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(193, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "[mm]"
        '
        'TB_top
        '
        Me.TB_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_top.Location = New System.Drawing.Point(252, 9)
        Me.TB_top.MaxLength = 3
        Me.TB_top.Name = "TB_top"
        Me.TB_top.Size = New System.Drawing.Size(35, 20)
        Me.TB_top.TabIndex = 27
        '
        'TB_right
        '
        Me.TB_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_right.Location = New System.Drawing.Point(302, 65)
        Me.TB_right.MaxLength = 3
        Me.TB_right.Name = "TB_right"
        Me.TB_right.Size = New System.Drawing.Size(35, 20)
        Me.TB_right.TabIndex = 26
        '
        'TB_left
        '
        Me.TB_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_left.Location = New System.Drawing.Point(209, 65)
        Me.TB_left.MaxLength = 3
        Me.TB_left.Name = "TB_left"
        Me.TB_left.Size = New System.Drawing.Size(35, 20)
        Me.TB_left.TabIndex = 25
        '
        'TB_bottom
        '
        Me.TB_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_bottom.Location = New System.Drawing.Point(252, 115)
        Me.TB_bottom.MaxLength = 3
        Me.TB_bottom.Name = "TB_bottom"
        Me.TB_bottom.Size = New System.Drawing.Size(35, 20)
        Me.TB_bottom.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(186, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Margins"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.U3D_2_PDF.My.Resources.Resources.pageicon
        Me.PictureBox1.Location = New System.Drawing.Point(222, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "[mm]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "[mm]"
        '
        'TB_height
        '
        Me.TB_height.Enabled = False
        Me.TB_height.Location = New System.Drawing.Point(50, 105)
        Me.TB_height.MaxLength = 5
        Me.TB_height.Name = "TB_height"
        Me.TB_height.Size = New System.Drawing.Size(42, 20)
        Me.TB_height.TabIndex = 18
        '
        'TB_width
        '
        Me.TB_width.Enabled = False
        Me.TB_width.Location = New System.Drawing.Point(50, 79)
        Me.TB_width.MaxLength = 5
        Me.TB_width.Name = "TB_width"
        Me.TB_width.Size = New System.Drawing.Size(42, 20)
        Me.TB_width.TabIndex = 14
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button_Reset3DOptions)
        Me.TabPage2.Controls.Add(Me.TB_coo_3)
        Me.TabPage2.Controls.Add(Me.TB_coo_2)
        Me.TabPage2.Controls.Add(Me.TB_coo_1)
        Me.TabPage2.Controls.Add(Me.TB_lights)
        Me.TabPage2.Controls.Add(Me.TB_roo)
        Me.TabPage2.Controls.Add(Me.TB_c2c_3)
        Me.TabPage2.Controls.Add(Me.TB_c2c_2)
        Me.TabPage2.Controls.Add(Me.TB_c2c_1)
        Me.TabPage2.Controls.Add(Me.TB_roll)
        Me.TabPage2.Controls.Add(Me.TB_aac)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(348, 143)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "3D Options"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button_Reset3DOptions
        '
        Me.Button_Reset3DOptions.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Reset3DOptions.Location = New System.Drawing.Point(267, 6)
        Me.Button_Reset3DOptions.Name = "Button_Reset3DOptions"
        Me.Button_Reset3DOptions.Size = New System.Drawing.Size(75, 37)
        Me.Button_Reset3DOptions.TabIndex = 18
        Me.Button_Reset3DOptions.Text = "Reset 3D Options"
        Me.Button_Reset3DOptions.UseVisualStyleBackColor = False
        '
        'TB_coo_3
        '
        Me.TB_coo_3.Location = New System.Drawing.Point(167, 117)
        Me.TB_coo_3.Name = "TB_coo_3"
        Me.TB_coo_3.Size = New System.Drawing.Size(80, 20)
        Me.TB_coo_3.TabIndex = 17
        '
        'TB_coo_2
        '
        Me.TB_coo_2.Location = New System.Drawing.Point(167, 91)
        Me.TB_coo_2.Name = "TB_coo_2"
        Me.TB_coo_2.Size = New System.Drawing.Size(80, 20)
        Me.TB_coo_2.TabIndex = 16
        '
        'TB_coo_1
        '
        Me.TB_coo_1.Location = New System.Drawing.Point(167, 65)
        Me.TB_coo_1.Name = "TB_coo_1"
        Me.TB_coo_1.Size = New System.Drawing.Size(80, 20)
        Me.TB_coo_1.TabIndex = 15
        '
        'TB_lights
        '
        Me.TB_lights.Location = New System.Drawing.Point(167, 32)
        Me.TB_lights.Name = "TB_lights"
        Me.TB_lights.Size = New System.Drawing.Size(80, 20)
        Me.TB_lights.TabIndex = 14
        '
        'TB_roo
        '
        Me.TB_roo.Location = New System.Drawing.Point(167, 6)
        Me.TB_roo.Name = "TB_roo"
        Me.TB_roo.Size = New System.Drawing.Size(80, 20)
        Me.TB_roo.TabIndex = 13
        '
        'TB_c2c_3
        '
        Me.TB_c2c_3.Location = New System.Drawing.Point(37, 117)
        Me.TB_c2c_3.Name = "TB_c2c_3"
        Me.TB_c2c_3.Size = New System.Drawing.Size(80, 20)
        Me.TB_c2c_3.TabIndex = 12
        '
        'TB_c2c_2
        '
        Me.TB_c2c_2.Location = New System.Drawing.Point(37, 91)
        Me.TB_c2c_2.Name = "TB_c2c_2"
        Me.TB_c2c_2.Size = New System.Drawing.Size(80, 20)
        Me.TB_c2c_2.TabIndex = 11
        '
        'TB_c2c_1
        '
        Me.TB_c2c_1.Location = New System.Drawing.Point(37, 65)
        Me.TB_c2c_1.Name = "TB_c2c_1"
        Me.TB_c2c_1.Size = New System.Drawing.Size(80, 20)
        Me.TB_c2c_1.TabIndex = 10
        '
        'TB_roll
        '
        Me.TB_roll.Location = New System.Drawing.Point(37, 32)
        Me.TB_roll.Name = "TB_roll"
        Me.TB_roll.Size = New System.Drawing.Size(80, 20)
        Me.TB_roll.TabIndex = 9
        '
        'TB_aac
        '
        Me.TB_aac.Location = New System.Drawing.Point(37, 6)
        Me.TB_aac.Name = "TB_aac"
        Me.TB_aac.Size = New System.Drawing.Size(80, 20)
        Me.TB_aac.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(130, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "lights"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(136, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "coo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(139, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "roo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "c2c"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "roll"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Link_OpenConfig)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.RichTextBox1)
        Me.TabPage3.Controls.Add(Me.TB_AR)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.TB_MeshLab)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.TB_pdfLaTeX)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Button_AppPathsSave)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(348, 143)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "App Paths"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(83, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "in text editor"
        '
        'Link_OpenConfig
        '
        Me.Link_OpenConfig.AutoSize = True
        Me.Link_OpenConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link_OpenConfig.Location = New System.Drawing.Point(34, 99)
        Me.Link_OpenConfig.Name = "Link_OpenConfig"
        Me.Link_OpenConfig.Size = New System.Drawing.Size(52, 13)
        Me.Link_OpenConfig.TabIndex = 9
        Me.Link_OpenConfig.TabStop = True
        Me.Link_OpenConfig.Text = "config file"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "open"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 85)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(249, 21)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = "double-click on a textbox to change a file path"
        '
        'TB_AR
        '
        Me.TB_AR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_AR.Location = New System.Drawing.Point(94, 59)
        Me.TB_AR.Name = "TB_AR"
        Me.TB_AR.ReadOnly = True
        Me.TB_AR.Size = New System.Drawing.Size(249, 20)
        Me.TB_AR.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Acrobat Reader"
        '
        'TB_MeshLab
        '
        Me.TB_MeshLab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_MeshLab.Location = New System.Drawing.Point(94, 33)
        Me.TB_MeshLab.Name = "TB_MeshLab"
        Me.TB_MeshLab.ReadOnly = True
        Me.TB_MeshLab.Size = New System.Drawing.Size(249, 20)
        Me.TB_MeshLab.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "MeshLab"
        '
        'TB_pdfLaTeX
        '
        Me.TB_pdfLaTeX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_pdfLaTeX.Location = New System.Drawing.Point(94, 7)
        Me.TB_pdfLaTeX.Name = "TB_pdfLaTeX"
        Me.TB_pdfLaTeX.ReadOnly = True
        Me.TB_pdfLaTeX.Size = New System.Drawing.Size(249, 20)
        Me.TB_pdfLaTeX.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "pdfLaTeX"
        '
        'Button_AppPathsSave
        '
        Me.Button_AppPathsSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_AppPathsSave.Enabled = False
        Me.Button_AppPathsSave.Location = New System.Drawing.Point(270, 117)
        Me.Button_AppPathsSave.Name = "Button_AppPathsSave"
        Me.Button_AppPathsSave.Size = New System.Drawing.Size(75, 23)
        Me.Button_AppPathsSave.TabIndex = 0
        Me.Button_AppPathsSave.Text = "Save"
        Me.Button_AppPathsSave.UseVisualStyleBackColor = False
        '
        'Button_ResetOptions
        '
        Me.Button_ResetOptions.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_ResetOptions.Location = New System.Drawing.Point(367, 118)
        Me.Button_ResetOptions.Name = "Button_ResetOptions"
        Me.Button_ResetOptions.Size = New System.Drawing.Size(75, 37)
        Me.Button_ResetOptions.TabIndex = 13
        Me.Button_ResetOptions.Text = "Reset all Options"
        Me.Button_ResetOptions.UseVisualStyleBackColor = False
        '
        'PictureBox_AR
        '
        Me.PictureBox_AR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_AR.Enabled = False
        Me.PictureBox_AR.Image = Global.U3D_2_PDF.My.Resources.Resources.Adobe_Reader_icon
        Me.PictureBox_AR.InitialImage = Global.U3D_2_PDF.My.Resources.Resources.Adobe_Reader_icon_disabled_1
        Me.PictureBox_AR.Location = New System.Drawing.Point(367, 211)
        Me.PictureBox_AR.Name = "PictureBox_AR"
        Me.PictureBox_AR.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox_AR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_AR.TabIndex = 14
        Me.PictureBox_AR.TabStop = False
        Me.PictureBox_AR.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadioButton_FolderMode)
        Me.Panel3.Controls.Add(Me.RadioButton_SingleFileMode)
        Me.Panel3.Location = New System.Drawing.Point(2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 23)
        Me.Panel3.TabIndex = 0
        '
        'RadioButton_FolderMode
        '
        Me.RadioButton_FolderMode.AutoSize = True
        Me.RadioButton_FolderMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_FolderMode.Location = New System.Drawing.Point(112, 3)
        Me.RadioButton_FolderMode.Name = "RadioButton_FolderMode"
        Me.RadioButton_FolderMode.Size = New System.Drawing.Size(117, 17)
        Me.RadioButton_FolderMode.TabIndex = 1
        Me.RadioButton_FolderMode.Text = "Batch/Folder Mode"
        Me.RadioButton_FolderMode.UseVisualStyleBackColor = True
        '
        'RadioButton_SingleFileMode
        '
        Me.RadioButton_SingleFileMode.AutoSize = True
        Me.RadioButton_SingleFileMode.Checked = True
        Me.RadioButton_SingleFileMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_SingleFileMode.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton_SingleFileMode.Name = "RadioButton_SingleFileMode"
        Me.RadioButton_SingleFileMode.Size = New System.Drawing.Size(103, 17)
        Me.RadioButton_SingleFileMode.TabIndex = 0
        Me.RadioButton_SingleFileMode.TabStop = True
        Me.RadioButton_SingleFileMode.Text = "Single File Mode"
        Me.RadioButton_SingleFileMode.UseVisualStyleBackColor = True
        '
        'F_MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 321)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox_AR)
        Me.Controls.Add(Me.Button_ResetOptions)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button_SaveTeX)
        Me.Controls.Add(Me.PictureBox_Update)
        Me.Controls.Add(Me.PictureBox_meshlab)
        Me.Controls.Add(Me.PictureBox_About)
        Me.Controls.Add(Me.PictureBox_miktex)
        Me.Controls.Add(Me.Button_OpenPDF)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.TextBox_FileSave)
        Me.Controls.Add(Me.TextBox_FileOpen)
        Me.Controls.Add(Me.Button_FileSave)
        Me.Controls.Add(Me.Button_FileOpen)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "F_MAIN"
        Me.Text = "U3D-2-PDF"
        CType(Me.PictureBox_meshlab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_miktex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_About, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Update, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox_AR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_FileOpen As System.Windows.Forms.Button
    Friend WithEvents Button_FileSave As System.Windows.Forms.Button
    Friend WithEvents TextBox_FileOpen As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_FileSave As System.Windows.Forms.TextBox
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents Button_OpenPDF As System.Windows.Forms.Button
    Friend WithEvents PictureBox_miktex As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_meshlab As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_About As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip_FileOpen As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip_FileSave As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip_PictureBox_miktex As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip_PictureBox_meshlab As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox_Update As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip_PictureBox_Update As System.Windows.Forms.ToolTip
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button_SaveTeX As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TB_top As System.Windows.Forms.TextBox
    Friend WithEvents TB_right As System.Windows.Forms.TextBox
    Friend WithEvents TB_left As System.Windows.Forms.TextBox
    Friend WithEvents TB_bottom As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_height As System.Windows.Forms.TextBox
    Friend WithEvents TB_width As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TB_aac As System.Windows.Forms.TextBox
    Friend WithEvents TB_roll As System.Windows.Forms.TextBox
    Friend WithEvents TB_c2c_3 As System.Windows.Forms.TextBox
    Friend WithEvents TB_c2c_2 As System.Windows.Forms.TextBox
    Friend WithEvents TB_c2c_1 As System.Windows.Forms.TextBox
    Friend WithEvents TB_coo_3 As System.Windows.Forms.TextBox
    Friend WithEvents TB_coo_2 As System.Windows.Forms.TextBox
    Friend WithEvents TB_coo_1 As System.Windows.Forms.TextBox
    Friend WithEvents TB_lights As System.Windows.Forms.TextBox
    Friend WithEvents TB_roo As System.Windows.Forms.TextBox
    Friend WithEvents Button_ResetOptions As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RB_A5 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_A4 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RB_Portrait As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Landscape As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button_Reset3DOptions As System.Windows.Forms.Button
    Friend WithEvents PictureBox_AR As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button_AppPathsSave As System.Windows.Forms.Button
    Friend WithEvents TB_AR As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TB_MeshLab As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TB_pdfLaTeX As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolTip_PictureBox_AR As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip_TB_pdfLaTeX As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip_TB_MeshLab As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip_TB_AR As System.Windows.Forms.ToolTip
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Link_OpenConfig As System.Windows.Forms.LinkLabel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton_FolderMode As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_SingleFileMode As System.Windows.Forms.RadioButton

End Class
