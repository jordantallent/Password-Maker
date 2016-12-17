Public Class Form1
    Public Function GenerateCode()
        Dim intChar As Integer = txtChar.Text
        Dim strInputString = "ABCDEFGHIJKLMNOPQRSTUVXWYZ1234567890abcdefghijklmnopqrstuvwxyz" 'these are the characters which will be in the password
        Dim strUpperCase = "ABCDEFGHIJKLMNOPQRSTUVXWYZ"
        Dim strLowerCase = "abcdefghijklmnopqrstuvwxyz"
        Dim strNumbers
        Dim strSpecial
        Dim intLength = Len(strInputString)
        Dim intNameLength = intChar 'edit this according to how long u want ur password to be
        Randomize() ' jus to make it random :D
        Dim strName = ""
        For intStep = 1 To intNameLength
            Dim intRnd = Int((intLength * Rnd()) + 1)
            strName = strName & Mid(strInputString, intRnd, 1)
        Next
        GenerateCode = strName
    End Function
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If txtChar.Text = "" Then
            TextBox1.Text = "Please enter a valid number"
            txtChar.Focus()
        Else
            TextBox1.Text = GenerateCode()
        End If
    End Sub
End Class
