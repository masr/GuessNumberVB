Public Class Form1

    Private current_num As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        current_num = Int(Rnd() * 100)
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If (Val(Me.NumberBox.Text) = current_num) Then
            MsgBox("You are right!!!")
            Me.NumberBox.Text = ""
            Me.HintLabel.Text = "无"
            current_num = Int(Rnd() * 100)
        ElseIf (Val(Me.NumberBox.Text) > current_num) Then
            Me.HintLabel.Text = "大了"
            Me.NumberBox.SelectAll()
        ElseIf (Val(Me.NumberBox.Text) < current_num) Then
            Me.HintLabel.Text = "小了"
            Me.NumberBox.SelectAll()

        End If
    End Sub
End Class
