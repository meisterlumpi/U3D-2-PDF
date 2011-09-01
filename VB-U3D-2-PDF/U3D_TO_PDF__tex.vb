Module U3D_TO_PDF__tex
    Function texStr() As String
        texStr = "\documentclass[" & F_MAIN.Param_papersize & "paper]{article}" & vbCrLf & _
                 "\newcommand{\layout}{0}" & vbCrLf & _
                 "\newcommand{\pname}{" & F_MAIN.U3D_FileName & "}" & vbCrLf & _
                 "\newcommand{\moviewidth}{" & F_MAIN.Param_width & "mm}" & vbCrLf & _
                 "\newcommand{\movieheight}{" & F_MAIN.Param_height & "mm}" & vbCrLf & _
                 "\usepackage[" & F_MAIN.Param_papersize & "paper," & F_MAIN.Param_orienation & "," & _
                    "top=" & F_MAIN.Param_margin_top & "mm, " & _
                    "bottom=" & F_MAIN.Param_margin_bottom & "mm, " & _
                    "left=" & F_MAIN.Param_margin_left & "mm, " & _
                    "right=" & F_MAIN.Param_margin_right & "mm]{geometry}" & vbCrLf & _
                 "\usepackage[3D]{movie15}" & vbCrLf & _
                 "\usepackage{hyperref}" & vbCrLf & _
                 "\usepackage[UKenglish]{babel}" & vbCrLf & _
                 "\begin{document}" & vbCrLf & _
                 "\centering" & vbCrLf & _
                 "\includemovie[" & vbCrLf & _
                 "poster," & vbCrLf & _
                 "toolbar," & vbCrLf & _
                 "label=\pname," & vbCrLf & _
                 "text=(\pname)," & vbCrLf & _
                 "3Daac=" & F_MAIN.Param_acc & ", " & _
                 "3Droll=" & F_MAIN.Param_roll & ", " & _
                 "3Dc2c=" & F_MAIN.Param_c2c_1 & " " & F_MAIN.Param_c2c_2 & " " & F_MAIN.Param_c2c_3 & ", " & _
                 "3Droo=" & F_MAIN.Param_roo & ", " & _
                 "3Dcoo=" & F_MAIN.Param_coo_1 & " " & F_MAIN.Param_coo_2 & " " & F_MAIN.Param_coo_3 & "," & vbCrLf & _
                 "3Dlights=" & F_MAIN.Param_lights & "," & vbCrLf & _
                 "]{\moviewidth}{\movieheight}{\pname}" & vbCrLf & _
                 "\end{document}"
    End Function
End Module
