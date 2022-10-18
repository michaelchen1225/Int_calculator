Public Class Form1

    Dim num1 As Double '數字1
    Dim num2 As Double '數字2
    Dim num3 As Double '數字3 
    Dim resault As Double '結果
    Dim stOpetaor As String '算符

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        lbDisplay.Text = btn1.Text
        num3 = Val(btn1.Text)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        lbDisplay.Text = btn2.Text
        num3 = Val(btn2.Text)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lbDisplay.Text = btn3.Text
        num3 = Val(btn3.Text)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lbDisplay.Text = btn4.Text
        num3 = Val(btn4.Text)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        lbDisplay.Text = btn5.Text
        num3 = Val(btn5.Text)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        lbDisplay.Text = btn6.Text
        num3 = Val(btn6.Text)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        lbDisplay.Text = btn7.Text
        num3 = Val(btn7.Text)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        lbDisplay.Text = btn8.Text
        num3 = Val(btn8.Text)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        lbDisplay.Text = btn9.Text
        num3 = Val(btn9.Text)
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        lbDisplay.Text = btn0.Text
        num3 = Val(btn0.Text)
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        num2 = Val(lbDisplay.Text)
        Select Case stOpetaor
            Case ""
                num1 = num2
            Case "+"
                num1 = num1 + num2
                lbDisplay.Text = CStr(num1)
            Case "-"
                num1 = num1 - num2
                lbDisplay.Text = CStr(num1)
            Case "*"
                num1 = num1 * num2
                lbDisplay.Text = CStr(num1)
            Case "/"
                num1 = num1 / num2
                lbDisplay.Text = CStr(num1)
        End Select
        stOpetaor = "+"
        num2 = 0
    End Sub

    Private Sub btnMunus_Click(sender As Object, e As EventArgs) Handles btnMunus.Click
        num2 = Val(lbDisplay.Text)
        Select Case stOpetaor
            Case ""
                num1 = num2
            Case "+"
                num1 = num1 + num2
                lbDisplay.Text = CStr(num1)
            Case "-"
                num1 = num1 - num2
                lbDisplay.Text = CStr(num1)
            Case "*"
                num1 = num1 * num2
                lbDisplay.Text = CStr(num1)
            Case "/"
                num1 = num1 / num2
                lbDisplay.Text = CStr(num1)
        End Select
        stOpetaor = "-"
        num2 = 0
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        num2 = Val(lbDisplay.Text)
        Select Case stOpetaor
            Case ""
                num1 = num2
            Case "+"
                num1 = num1 + num2
                lbDisplay.Text = CStr(num1)
            Case "-"
                num1 = num1 - num2
                lbDisplay.Text = CStr(num1)
            Case "*"
                num1 = num1 * num2
                lbDisplay.Text = CStr(num1)
            Case "/"
                num1 = num1 / num2
                lbDisplay.Text = CStr(num1)
        End Select
        stOpetaor = "*"
        num2 = 0
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        num2 = Val(lbDisplay.Text)
        Select Case stOpetaor
            Case ""
                num1 = num2
            Case "+"
                num1 = num1 + num2
                lbDisplay.Text = CStr(num1)
            Case "-"
                num1 = num1 - num2
                lbDisplay.Text = CStr(num1)
            Case "*"
                num1 = num1 * num2
                lbDisplay.Text = CStr(num1)
            Case "/"
                num1 = num1 / num2
                lbDisplay.Text = CStr(num1)
        End Select
        stOpetaor = "/"
        num2 = 0
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        lbDisplay.Text = btn0.Text
        num1 = 0
        num2 = 0
        stOpetaor = ""
        resault = 0
    End Sub

    Private Sub btnEql_Click(sender As Object, e As EventArgs) Handles btnEql.Click
        Select Case stOpetaor
            Case "+"
                resault = num1 + num3
                lbDisplay.Text = resault
            Case "-"
                resault = num1 - num3
                lbDisplay.Text = resault
            Case "*"
                resault = num1 * num3
                lbDisplay.Text = resault
            Case "/"
                resault = num1 / num3
                lbDisplay.Text = resault
        End Select
        num1 = resault

    End Sub
End Class
