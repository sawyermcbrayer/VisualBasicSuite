Public Class Form1
    Private Sub btnTemp_Click(sender As Object, e As EventArgs) Handles btnTemp.Click

        Dim iTemp As Integer
        If IsNumeric(txtTemp.Text) Then
            iTemp = CInt(txtTemp.Text)
        Else
            MessageBox.Show("Enter an integer, no characters allow!")
            Exit Sub
        End If

        Select Case iTemp
            Case Is = 0
                MessageBox.Show("Very cold!")
            Case Is < 0
                MessageBox.Show("Hypothermia Risk: Extreme")
            Case 1 To 32
                MessageBox.Show("Hypothermia Risk: Exists")
            Case 33 To 50
                MessageBox.Show("Hypothermia Risk: Minimal")
            Case 51 To 150
                MessageBox.Show("Hypothermia Risk: Negligible")
        End Select


    End Sub
End Class
