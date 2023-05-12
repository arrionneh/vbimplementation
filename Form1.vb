'Programmer: ArRionne Hickson
'Date: 8 May 2023
'Program: Personal Shopper App
'Purpose: This program will allow the user to select a shoe from the three options shown,
' pick between in store pickup or home delivery,
' and type their name, number, and shoe size to confirm their order.

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load initial images for shoes
        picShoe.Image = My.Resources.red
        picShoe.Image = My.Resources.black
        picShoe.Image = My.Resources.brown1
    End Sub

    Private Sub radRed_CheckedChanged(sender As Object, e As EventArgs) Handles radRed.CheckedChanged
        ' Red sneakers selected
        picShoe.Image = My.Resources.red
    End Sub

    Private Sub radBlack_CheckedChanged(sender As Object, e As EventArgs) Handles radBlack.CheckedChanged
        ' Black loafers selected
        picShoe.Image = My.Resources.black
    End Sub

    Private Sub radBrown_CheckedChanged(sender As Object, e As EventArgs) Handles radBrown.CheckedChanged
        ' Brown boots selected
        picShoe.Image = My.Resources.brown1
    End Sub

    Private Sub radPickup_CheckedChanged(sender As Object, e As EventArgs) Handles radPickup.CheckedChanged
        ' Pick up in store selected
        lblResult.Text = "You selected Pick up in store."
    End Sub

    Private Sub radDeliver_CheckedChanged(sender As Object, e As EventArgs) Handles radDelivery.CheckedChanged
        ' Home delivery selected
        lblResult.Text = "You selected Home delivery."
    End Sub

    Private Function GetSelectedShoe() As String
        ' Return selected shoe type
        If radRed.Checked Then
            Return "Red sneakers"
        ElseIf radBlack.Checked Then
            Return "Black loafers"
        ElseIf radBrown.Checked Then
            Return "Brown boots"
        Else
            Return ""
        End If
    End Function

    Private Function GetSelectedDelivery() As String
        ' Return selected delivery option
        If radPickup.Checked Then
            Return "picked up at the store"
        ElseIf radDelivery.Checked Then
            Return "delivered to your home"
        Else
            Return ""
        End If
    End Function
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Submit button clicked
        Dim size As String = txtSize.Text.Trim()
        Dim phone As String = txtNumber.Text.Trim()
        If Not IsNumeric(size) Then
            MsgBox("Please enter a valid shoe size.")
        ElseIf Not IsNumeric(phone) Or phone.Length <> 10 Then
            MsgBox("Please enter a valid phone number.")
        Else
            lblResult.Text = "Thank you for your order! Your " & GetSelectedShoe() & " shoes in size " & size & " will be " & GetSelectedDelivery() & "."
            ' Clear input fields for next order
            txtName.Text = ""
            txtSize.Text = ""
            txtNumber.Text = ""
        End If
    End Sub

    Private Sub btnLoop_Click(sender As Object, e As EventArgs) Handles btnLoop.Click
        ' Loop button clicked
        ' Clear input fields for next order
        txtName.Text = ""
        txtNumber.Text = ""
        radRed.Checked = True
        radPickup.Checked = True
        lblResult.Text = ""
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit button clicked
        Me.Close()
    End Sub
End Class