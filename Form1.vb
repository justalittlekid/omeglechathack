Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Based on https://github.com/indrajeetb 
        Dim chars2use As String = "abcdef"

        Dim sb As New StringBuilder()
        Dim rand1 As New Random()
        For i As Integer = 1 To 1
            Dim idx As Integer = rand1.Next(0, chars2use.Length)
            Dim randomChar As Char = chars2use(idx)
            sb.Append(randomChar)

            Dim rand As New Random()
    Dim number = rand.Next(1111, 9999) & randomChar & ".png"  'You could use 1111 to 99999 also, but much pics with 5 numbers are not available

            My.Computer.Network.DownloadFile(
        "http://l.omegle.com/" & number,
        "!!YOUR PATH!!" & number & randomChar & ".png")

        Next i


        Dim randomString = sb.ToString()

    End Sub

End Class
