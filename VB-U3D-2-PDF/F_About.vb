Imports System.Threading

'Public NotInheritable Class AboutBox1
Public Class F_About

    Public newUpdate2 As Boolean = False

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Legen Sie den Titel des Formulars fest.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("{0}", ApplicationTitle) & " " & String.Format("v. {0}", My.Application.Info.Version.ToString)
        ' Initialisieren Sie den gesamten Text, der im Infofeld angezeigt wird.
        ' TODO: Passen Sie die Assemblyinformationen der Anwendung im Bereich "Anwendung" des Dialogfelds für die 
        '    Projekteigenschaften (im Menü "Projekt") an.
        ''Me.LabelProductName.Text = My.Application.Info.ProductName
        ''Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        ''Me.LabelCopyright.Text = My.Application.Info.Copyright
        ''Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        ''Me.TextBoxDescription.Text = My.Application.Info.Description

        Dim tooltip_PB_GetAR As New ToolTip
        tooltip_PB_GetAR.SetToolTip(PB_GetAR, "Download Adobe Acrobat Reader")

    End Sub
    Private Sub AboutBox1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        newUpdate = newUpdate2
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
    Private Sub Link_U3D_HP_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_U3D_HP.LinkClicked
        System.Diagnostics.Process.Start(URL_U3D2PDF)
    End Sub
    Private Sub Link_miktex_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_miktex.LinkClicked
        System.Diagnostics.Process.Start(URL_miktex)
    End Sub
    Private Sub Link_meshlab_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_meshlab.LinkClicked
        System.Diagnostics.Process.Start(URL_meshlab)
    End Sub
    '################################################################################
    '################################################################################
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(URL_gettyicons)
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start(URL_deviantart)
    End Sub

    Private Sub Link_Updates_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_Updates.LinkClicked
        ' Start update process in different thread.
        Dim Thread_Update_Response As New Thread(New ThreadStart(AddressOf Updates_Response))
        Thread_Update_Response.SetApartmentState(ApartmentState.STA)
        Thread_Update_Response.Start()
    End Sub

    Sub Updates_Response()
        If CheckForUpdate() And Not UpdateError Then
            newUpdate2 = True
            If MsgBox("An update is available. Do you want to download it now?", _
                      vbInformation + vbYesNo) = vbYes Then
                DownloadUpdate()
            End If
        ElseIf Not CheckForUpdate() And Not UpdateError Then
            MsgBox("No updates available.", vbInformation)
        ElseIf UpdateError Then
            MsgBox("There was an error connecting to the update-server. Please try again later.", _
                   vbExclamation + vbOKOnly)
        End If
    End Sub

    Private Sub PB_GetAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_GetAR.Click
        System.Diagnostics.Process.Start(URL_AR)
    End Sub
End Class
