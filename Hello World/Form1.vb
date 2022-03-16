Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTopic.Click

    End Sub

    Private Sub bthShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        MessageBox.Show("Hello World")
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtShow.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtShow.TextChanged

    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click
        MessageBox.Show("Hello " + txtName.Text)

    End Sub

    Private Sub btnText_Click(sender As Object, e As EventArgs) Handles btnText.Click
        txtShow.Text = "Hello " + txtName.Text

    End Sub
End Class
