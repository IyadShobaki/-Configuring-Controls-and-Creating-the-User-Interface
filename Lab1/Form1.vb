Public Class Form1
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim aResult As DialogResult
        aResult = Form2.ShowDialog()
        If aResult = Windows.Forms.DialogResult.OK Then
            MsgBox("You name is " & Form2.TextBox1.Text & " " & Form2.TextBox2.Text)
            MsgBox("Your address is " & Form2.TextBox3.Text)
            MsgBox("Your phone number is " & Form2.MaskedTextBox1.Text)
        End If
        LinkLabel1.LinkVisited = True
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim aResult As DialogResult
        aResult = Form3.ShowDialog()
        If aResult = Windows.Forms.DialogResult.OK Then
            MsgBox("Your address is " & Form3.TextBox1.Text)
            MsgBox("Your phone number is " & Form3.MaskedTextBox1.Text)
        End If
        LinkLabel2.LinkVisited = True
    End Sub
End Class
