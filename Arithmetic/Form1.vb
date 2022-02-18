Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim iNumber1 As Integer
        Dim iNumber2 As Integer
        Dim iResult As Integer

        iNumber1 = txtOne.Text
        iNumber2 = txtTwo.Text
        iResult = iNumber1 + iNumber2
        'Comments figured out!
        MessageBox.Show("Sum of Numbers: " & iResult)

    End Sub
End Class
