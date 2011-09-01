Imports System.IO
Imports System.Net

Public Module M_Download
    Public Sub dwlByLink(ByVal myLink As String, ByVal myFile As String)
        Try
            Dim myRequest As WebRequest = System.Net.WebRequest.Create(myLink) ' request
            Dim myResponse As WebResponse = myRequest.GetResponse() ' response
            Dim myStream As Stream = myResponse.GetResponseStream() ' stream
            Dim myReader As New BinaryReader(myStream) ' binary reader

            ' save file
            Dim myFileStream As New System.IO.FileStream(myFile, System.IO.FileMode.Create)

            Dim i As Long
            For i = 1 To myResponse.ContentLength ' byte-wise transfer
                myFileStream.WriteByte(myReader.ReadByte())
            Next i

            myFileStream.Flush() ' flush
            myFileStream.Close() ' close

            ' release
            myFileStream = Nothing
            myReader = Nothing
            myStream = Nothing
            myResponse = Nothing
            myRequest = Nothing
        Catch ex As Exception
            ' 
            UpdateError = True
        End Try
    End Sub
End Module
