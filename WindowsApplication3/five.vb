Public Class five

    Private Sub five_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged, txtUserName.TextChanged
        Dim tb As TextBox = CType(sender, TextBox)

        If (String.IsNullOrEmpty(tb.Text)) Then
            tb.BackColor = Color.MistyRose
        Else
            tb.BackColor = Color.White
        End If
    End Sub

    Private Sub btenter_Click(sender As Object, e As EventArgs) Handles btenter.Click

        If txtUserName.Text = "login" Then
            If txtPassword.Text = "abc123" Then
                MessageBox.Show("帳號密碼輸入正確！")
            Else
                MessageBox.Show("帳號密碼錯誤或未輸入完成!")
            End If
        Else
            MessageBox.Show("帳號密碼錯誤或未輸入完成!")

        End If
        Close()

    End Sub

    Private Sub btesc_Click(sender As Object, e As EventArgs) Handles btesc.Click
        Application.Exit()

    End Sub
End Class
