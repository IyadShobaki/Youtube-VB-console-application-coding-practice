Public Class Form1




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub txtMultiline_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMultiline.Validating
        Dim num As Integer
        If Integer.TryParse(txtMultiline.Text, num) Then
            If num < 1 Or num > 20 Then
                e.Cancel = True
                MessageBox.Show("Enter from 1 to 20")

            End If
        Else
            e.Cancel = True
            MessageBox.Show("You need an integer")
        End If
    End Sub

    Private Sub txtMultiline_Validated(sender As Object, e As EventArgs) Handles txtMultiline.Validated
        MessageBox.Show("Good job You did it")
    End Sub
End Class
