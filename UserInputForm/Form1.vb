Public Class Form1

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        Dim stFirst As String
        Dim stLast As String
        Dim stGender As String
        Dim stOccupation As String


        stFirst = txtFirstName.Text
        stLast = txtLastName.Text
        stGender = txtGender.Text
        stOccupation = lstOccupation.SelectedItem

        MessageBox.Show("First Name: " & stFirst & vbNewLine _
                        & "Last Name: " & stLast & vbNewLine _
                        & "Gender: " & stGender & vbNewLine _
                        & "Your occupation is: " & stOccupation)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstOccupation.Items.Add("Traveler")
        lstOccupation.Items.Add("Foodie")
        lstOccupation.Items.Add("Snow Boarder")
        lstOccupation.Items.Add("Rock Climber")

    End Sub
End Class
