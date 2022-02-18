Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MessageBox.Show("This message is message box.")
    End Sub

    Private Sub btnVar_Click(sender As Object, e As EventArgs) Handles btnVar.Click
        Dim stFirstName As String
        Dim stLastName As String
        stFirstName = "Sawyer"
        stLastName = "McBrayer"
        MessageBox.Show("Visual Basic is pretty cool isnt it, " & stFirstName & " " & stLastName & "?")
    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineDisplacement As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date
        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColor = "Red"
        bTaxed = True
        iEngineDisplacement = 3200
        decPrice = 5000.0
        dtDateRegistered = #2/17/2020#

        MessageBox.Show("The vehicle is a " _
            & stMake _
            & " " _
            & stModel _
            & vbNewLine & "It has " _
            & iDoors _
            & " doors and is " _
            & stColor _
            & vbNewLine & "Is it taxed? " _
            & bTaxed _
            & vbNewLine & "Engine size is: " _
            & iEngineDisplacement _
            & vbNewLine & "Price is: " _
            & decPrice _
            & vbNewLine & "It was registered on: " _
            & dtDateRegistered)

    End Sub
End Class
