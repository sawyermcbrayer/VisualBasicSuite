Public Class Form1
    Private Sub btnLinSearch_Click(sender As Object, e As EventArgs) Handles btnLinSearch.Click

        Dim stTarget As String
        Dim astItems(9) As String

        astItems(0) = "Disc"
        astItems(1) = "Flange"
        astItems(2) = "Wheel"
        astItems(3) = "Bit"
        astItems(4) = "Bolt"
        astItems(5) = "Nut"
        astItems(6) = "Hose"
        astItems(7) = "Valve"
        astItems(8) = "Chuck"
        astItems(9) = "Compressor"

        stTarget = InputBox("Enter item to search inventory: ")

        Dim i As Integer
        For i = 0 To 9
            If UCase(astItems(i)) = UCase(stTarget) Then
                MessageBox.Show("Item: " & """" & astItems(i) & """" & " is in stock." & vbNewLine _
                                & "Item is in store rack #: " & i)
                Exit For
            End If
        Next
    End Sub

    Private Sub btn2DArray_Click(sender As Object, e As EventArgs) Handles btn2DArray.Click

        Dim astDescriptions(3, 3) As String
        Dim i As Integer
        astDescriptions(0, 0) = "Software"
        astDescriptions(1, 0) = "Developer"
        astDescriptions(2, 0) = "Me"

        astDescriptions(0, 1) = "Program"
        astDescriptions(1, 1) = "Writer"
        astDescriptions(2, 1) = "You"

        astDescriptions(0, 2) = "Computer"
        astDescriptions(1, 2) = "Friends"
        astDescriptions(2, 2) = "Us"

        For i = 0 To 2
            MessageBox.Show(astDescriptions(i, 1))
        Next

    End Sub

    Private Sub btnRow_Click(sender As Object, e As EventArgs) Handles btnRow.Click

        Dim astDescriptions(3, 3) As String

        astDescriptions(0, 0) = "Software"
        astDescriptions(1, 0) = "Developer"
        astDescriptions(2, 0) = "Me"

        astDescriptions(0, 1) = "Program"
        astDescriptions(1, 1) = "Writer"
        astDescriptions(2, 1) = "You"

        astDescriptions(0, 2) = "Computer"
        astDescriptions(1, 2) = "Friends"
        astDescriptions(2, 2) = "Us"

        Dim x As Integer
        Dim y As Integer

        For y = 0 To 2
            For x = 0 To 2
                MessageBox.Show(astDescriptions(x, y))
            Next
        Next
    End Sub

    Private Sub btnColumn_Click(sender As Object, e As EventArgs) Handles btnColumn.Click
        Dim astDescriptions(3, 3) As String

        astDescriptions(0, 0) = "Software"
        astDescriptions(1, 0) = "Developer"
        astDescriptions(2, 0) = "Me"

        astDescriptions(0, 1) = "Program"
        astDescriptions(1, 1) = "Writer"
        astDescriptions(2, 1) = "You"

        astDescriptions(0, 2) = "Computer"
        astDescriptions(1, 2) = "Friends"
        astDescriptions(2, 2) = "Us"

        Dim x As Integer
        Dim y As Integer

        For x = 0 To 2
            For y = 0 To 2
                MessageBox.Show(astDescriptions(x, y))
            Next
        Next
    End Sub

    Private Sub btnFullArray_Click(sender As Object, e As EventArgs) Handles btnFullArray.Click
        Dim astDescriptions(3, 3) As String

        astDescriptions(0, 0) = "Software"
        astDescriptions(1, 0) = "Developer"
        astDescriptions(2, 0) = "Me"

        astDescriptions(0, 1) = "Program"
        astDescriptions(1, 1) = "Writer"
        astDescriptions(2, 1) = "You"

        astDescriptions(0, 2) = "Computer"
        astDescriptions(1, 2) = "Friends"
        astDescriptions(2, 2) = "Us"

        Dim x As Integer
        Dim y As Integer
        Dim stOut As String

        For y = 0 To 2
            For x = 0 To 2
                stOut = stOut & " " & astDescriptions(x, y)
            Next
            stOut = stOut & vbNewLine
        Next
        MessageBox.Show(stOut)
    End Sub

    Private Sub btnSearch2D_Click(sender As Object, e As EventArgs) Handles btnSearch2D.Click
        Dim astDescriptions(3, 3) As String

        astDescriptions(0, 0) = "Software"
        astDescriptions(1, 0) = "Developer"
        astDescriptions(2, 0) = "Me"

        astDescriptions(0, 1) = "Program"
        astDescriptions(1, 1) = "Writer"
        astDescriptions(2, 1) = "You"

        astDescriptions(0, 2) = "Computer"
        astDescriptions(1, 2) = "Friends"
        astDescriptions(2, 2) = "Us"

        Dim x As Integer
        Dim y As Integer
        Dim bIsFound As Boolean
        Dim stTarget As String
        Dim stOut As String

        bIsFound = False

        stTarget = InputBox("Enter your search target: ")

        For y = 0 To 2
            If astDescriptions(0, y) = stTarget Then
                bIsFound = True
                Exit For

            End If
        Next

        If bIsFound = True Then
            For x = 0 To 2
                stOut = stOut & astDescriptions(x, y) & " "
            Next
        Else
            MessageBox.Show("Not found...")
        End If
        MessageBox.Show(stOut)
    End Sub
End Class
