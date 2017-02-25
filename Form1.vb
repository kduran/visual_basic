'Ahmet K Duran

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        lblOutput.Text = String.Empty
        txtInput.Focus()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intParameter As Integer
        If Integer.TryParse(txtInput.Text, intParameter) And intParameter >= 1 And intParameter <= 10 Then
            If intParameter = 1 Then
                lblOutput.Text = "I"
            ElseIf intParameter = 2 Then
                lblOutput.Text = "II"
            ElseIf intParameter = 3 Then
                lblOutput.Text = "III"
            ElseIf intParameter = 4 Then
                lblOutput.Text = "IV"
            ElseIf intParameter = 5 Then
                lblOutput.Text = "V"
            ElseIf intParameter = 6 Then
                lblOutput.Text = "VI"
            ElseIf intParameter = 7 Then
                lblOutput.Text = "VII"
            ElseIf intParameter = 8 Then
                lblOutput.Text = "VIII"
            ElseIf intParameter = 9 Then
                lblOutput.Text = "IX"
            ElseIf intParameter = 10 Then
                lblOutput.Text = "X"
            End If
        Else
            lblOutput.Text = "Not in range 1-10"
        End If
    End Sub
End Class
