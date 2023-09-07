Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCountry.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nameofcountry As String

        nameofcountry = txtCountry.Text
        If nameofcountry = "South Africa" Then
            MsgBox("Sawubona")

        ElseIf nameofcountry = "France" Then
            MsgBox("Bonjour")

        ElseIf nameofcountry = "Spain" Then
            MsgBox("OLA!")

        ElseIf nameofcountry = "China" Then
            MsgBox("Nihao")

        Else
            MsgBox("Hello")








        End If
    End Sub
End Class
