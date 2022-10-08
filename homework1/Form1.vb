Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TextBox1.Text = "SELECT A RADIO BUTTON"
        Me.Button1.Text = "PRESS"
        If Me.RadioButton1.Checked = True Then
            Me.TextBox1.Text = "SELECTED RADIO BUTTON 1"
            Me.ProgressBar2.Value = 0
            Me.ProgressBar1.Value = 30
        End If
        If Me.RadioButton2.Checked = True Then
            Me.TextBox1.Text = "SELECTED RADIO BUTTON 2"
            Me.ProgressBar1.Value = 0
            Me.ProgressBar2.Value = 70
        End If
    End Sub
End Class
