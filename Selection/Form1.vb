Public Class Form1
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click

        Dim stCountry As String
        stCountry = txtCountry.Text


        If stCountry.ToUpper = "USA" Then
            MessageBox.Show("Hello")
        ElseIf stCountry.ToUpper = "ISRAEL" Then
            MessageBox.Show("Shalom")
        Else
            MessageBox.Show("Different Country Selection")
        End If

        MessageBox.Show("How do you like " & stCountry & "?")

    End Sub
End Class
