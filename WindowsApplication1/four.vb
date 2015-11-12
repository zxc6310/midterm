Public Class four

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        Dim n1, n2, n3, n4, ahq As Integer
        n1 = tb1.Text
        n2 = tb2.Text
        n3 = n1 / 100
        n4 = n3 * n3
        ahq = n2 / n4
        If ahq < 18.5 Then
            lb.Text = "過輕"
        ElseIf 18.5 <= ahq < 24 Then
            lb.Text = "正常喔"
        ElseIf 24 <= ahq < 27 Then
            lb.Text = "過重"
        ElseIf 27 <= ahq < 30 Then
            lb.Text = "輕度肥胖"
        ElseIf 30 <= ahq < 35 Then
            lb.Text = "中度肥胖"
        ElseIf ahq >= 35 Then
            lb.Text = "重度肥胖"


        End If


    End Sub
End Class
