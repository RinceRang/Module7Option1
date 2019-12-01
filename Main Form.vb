' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim intNum As Integer
        Dim intCounter As Integer = 1
        Dim intResult As Integer

        Integer.TryParse(txtNumber.Text, intNum)

        Do While intCounter <= 10
            intResult = intNum * intCounter
            lblTable.Text = lblTable.Text & intNum.ToString & "*" & intCounter.ToString & "=" & intResult.ToString & ControlChars.NewLine
            intCounter += 1
        Loop

    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        Dim intNum As Integer
        Dim intResult As Integer

        Integer.TryParse(txtNumber.Text, intNum)

        For intCounter As Integer = 1 To 10
            intResult = intNum * intCounter
            lblTable.Text = lblTable.Text & intNum.ToString & "*" & intCounter.ToString & "=" & intResult.ToString & ControlChars.NewLine

        Next intCounter

    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lblTable.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
