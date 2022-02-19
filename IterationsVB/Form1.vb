Public Class Form1
    Private Sub btnLooper_Click(sender As Object, e As EventArgs) Handles btnLooper.Click

        Dim iCount As Integer
        Dim stOut As String

        For iCount = 0 To 50 Step 10
            'Threading.Thread.Sleep(50)

            MessageBox.Show("Loop Iteration: " & iCount)
            stOut += iCount
        Next
        Beep()
        MessageBox.Show("Sum of iteration controller (simple example): " & stOut)
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click

        Dim iUserNum As Integer
        Dim stUserEO As String
        Dim iCount As Integer

        iUserNum = CInt(InputBox("Enter A Number: ", "Count Limit"))
        stUserEO = CStr(InputBox("Enter Odd or Even: ", "Count by Odd or Even"))

        If stUserEO.ToUpper = "ODD" Then
            For iCount = 1 To iUserNum Step 2
                MessageBox.Show("Odd Numbers: " & iCount)
            Next
            Beep()
        ElseIf stUserEO.ToUpper = "EVEN" Then
            For iCount = 2 To iUserNum Step 2
                MessageBox.Show("Even Numbers: " & iCount)
            Next
            Beep()
        End If
    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        Dim iCount As Integer
        iCount = 0
        Do While iCount <= 5
            MessageBox.Show("Iteration Count: " & iCount)
            iCount += 1
        Loop
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        Dim iCount As Integer
        iCount = 0
        Do
            MessageBox.Show("Iteration Count: " & iCount)
            iCount += 1
        Loop Until iCount > 5
    End Sub

    Private Sub btnConditional_Click(sender As Object, e As EventArgs) Handles btnConditional.Click

        Dim stName As String
        Dim stAge As String
        Dim iAge As Integer

        Do While stName <> "SAWYER"
            stName = InputBox("Please enter your name in CAPS.")
        Loop

        Do While IsNumeric(stAge) = False
            stAge = InputBox("Enter your age here: ")
        Loop

        iAge = CInt(stAge)

        MessageBox.Show(stName & " is " & iAge & ".")


    End Sub
End Class
