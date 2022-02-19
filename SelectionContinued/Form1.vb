Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim iScore As Integer
        If IsNumeric(txtUserNum.Text) = True Then
            iScore = CInt(txtUserNum.Text)

            If iScore < 0 Or iScore > 100 Then
                MessageBox.Show("Invalid score. Enter # 1-100.")
                Exit Sub
            End If
            If iScore <= 100 And iScore >= 90 Then
                MessageBox.Show("Your letter grade is: A")
            ElseIf iScore <= 89 And iScore >= 80 Then
                MessageBox.Show("Your letter grade is: B")
            ElseIf iScore <= 79 And iScore >= 70 Then
                MessageBox.Show("Your letter grade is: C")
            ElseIf iScore <= 69 And iScore >= 60 Then
                MessageBox.Show("Your letter grade is: D")
            Else
                MessageBox.Show("Your letter grade is: F")
            End If

            If iScore >= 60 Then
                MessageBox.Show("Congratulations, you passed the course!")
            Else MessageBox.Show("Sorry, you will have to retake the course...")
            End If
        Else
            MessageBox.Show("Value entered must be of type integer.")
        End If

    End Sub
End Class
