Public Module M_CONFIG

    ' URLs for miktex, meshlab, adobe reader
    Public Const URL_miktex As String = "http://miktex.org"
    Public Const URL_meshlab As String = "http://meshlab.sourceforge.net"
    Public Const URL_AR As String = "http://get.adobe.com/reader"

    Public Const URL_U3D2PDF As String = "http://nj.riotdowntown.com/2011/04/u3d-2-pdf"
    Public Const URL_gettyicons As String = "http://www.gettyicons.com/free-icon/124/web-dev-icon-set"
    Public Const URL_deviantart As String = "http://saviourmachine.deviantart.com"

    ' CurReleaseIndex
    Public Const CRI As Integer = 4 '3 '2
    Public Const URL_UIFile As String = "http://nj.riotdowntown.com/UpdateIndex.ini" '' & "_TEST_ERROR"
    Public Const URL_FileUpdate As String = "http://nj.riotdowntown.com/get/U3D-2-PDF.zip"

    Public Const FileName As String = "U3D-2-PDF.zip"

    ' 
    Public Const ConfigININame As String = "config.ini"
    Public Const ConfigINI_sampleName As String = "config_sample.ini"
    Public Const pdflatexName As String = "pdflatex.exe"
    Public Const meshlabserverName As String = "meshlabserver.exe"
    Public Const ARName As String = "AcroRd32.exe"

    ' Tempfiles Names
    Public Const TF_U3DName As String = "stlTOu3dTMP.u3d"
    Public Const TF_U3DTEXName As String = "stlTOu3dTMP.tex"
    Public Const TF_TexName As String = "U3D_TO_PDF.tex"
    Public Const TF_PDFName As String = "U3D_TO_PDF.pdf"
    Public Const TF_LOGName As String = "U3D_TO_PDF.log"
    Public Const TF_AUXName As String = "U3D_TO_PDF.aux"
    Public Const TF_OUTName As String = "U3D_TO_PDF.out"

    ' Parameters/Options
    Public Const A4_standard_width As String = "210"
    Public Const A4_standard_height As String = "297"
    Public Const A5_standard_width As String = "148"
    Public Const A5_standard_height As String = "210"

    Public Const U3D_standard_FileName As String = "stlTOu3dTMP.u3d"
    Public Const Param_standard_width As String = "297"
    Public Const Param_standard_height As String = "210"
    Public Const Param_standard_margin_top As String = "0"
    Public Const Param_standard_margin_bottom As String = "0"
    Public Const Param_standard_margin_left As String = "0"
    Public Const Param_standard_margin_right As String = "0"
    Public Const Param_standard_acc As String = "60.000000"
    Public Const Param_standard_roll As String = "0.000000"
    Public Const Param_standard_c2c_1 As String = "0.004411"
    Public Const Param_standard_c2c_2 As String = "-0.158060"
    Public Const Param_standard_c2c_3 As String = "0.000000"
    Public Const Param_standard_roo As String = "0.158122"
    Public Const Param_standard_coo_1 As String = "0.004411"
    Public Const Param_standard_coo_2 As String = "0.010763"
    Public Const Param_standard_coo_3 As String = "0.000000"
    Public Const Param_standard_lights As String = "CAD"

    ' INI File
    Public Const Param_Section_ApplicationPaths As String = "ApplicationPaths"
    Public Const Param_Key_PATH_miktex As String = "PATH_miktex"
    Public Const Param_Key_PATH_meshlab As String = "PATH_meshlab"
    Public Const Param_Key_PATH_AR As String = "PATH_AR"
End Module
