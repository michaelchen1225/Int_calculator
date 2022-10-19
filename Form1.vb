Public Class Form1

    Dim num1 As Double '紀錄初始數字
    Dim num2 As Double '紀錄螢幕上的數字
    Dim num3 As Double '記錄按鍵數字
    Dim oneTime As Integer '若等於0則可以按運算符, 若等於1就不行 
    Dim resault As Double '結果
    Dim stOpetaor As String '紀錄上一個運算的算符
    Dim eqlIf As Integer '紀錄有沒有按等號


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        lbDisplay.Text = btn1.Text
        num3 = Val(btn1.Text)
        oneTime = 0
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        lbDisplay.Text = btn2.Text
        num3 = Val(btn2.Text)
        oneTime = 0
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lbDisplay.Text = btn3.Text
        num3 = Val(btn3.Text)
        oneTime = 0
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lbDisplay.Text = btn4.Text
        num3 = Val(btn4.Text)
        oneTime = 0
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        lbDisplay.Text = btn5.Text
        num3 = Val(btn5.Text)
        oneTime = 0
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        lbDisplay.Text = btn6.Text
        num3 = Val(btn6.Text)
        oneTime = 0
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        lbDisplay.Text = btn7.Text
        num3 = Val(btn7.Text)
        oneTime = 0
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        lbDisplay.Text = btn8.Text
        num3 = Val(btn8.Text)
        oneTime = 0
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        lbDisplay.Text = btn9.Text
        num3 = Val(btn9.Text)
        oneTime = 0
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        lbDisplay.Text = btn0.Text
        num3 = Val(btn0.Text)
        oneTime = 0
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        num2 = Val(lbDisplay.Text)
        If eqlIf = 1 Then '按完等於後繼續運算
            stOpetaor = "+"
            num1 = num2
            eqlIf = 0
        Else
            If oneTime = 0 Then
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
            End If
        End If
        oneTime = 1
    End Sub

    Private Sub btnMunus_Click(sender As Object, e As EventArgs) Handles btnMunus.Click
        num2 = Val(lbDisplay.Text)
        If eqlIf = 1 Then
            stOpetaor = "-"
            num1 = num2
            eqlIf = 0
        Else
            If oneTime = 0 Then
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
            End If
        End If
        oneTime = 1
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        num2 = Val(lbDisplay.Text)
        If eqlIf = 1 Then
            stOpetaor = "*"
            num1 = num2
            eqlIf = 0
        Else
            If oneTime = 0 Then
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
            End If
        End If
        oneTime = 1
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        num2 = Val(lbDisplay.Text)
        If eqlIf = 1 Then
            stOpetaor = "/"
            num1 = num2
            eqlIf = 0
        Else
            If oneTime = 0 Then
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
            End If
        End If
        oneTime = 1
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
            Case ""
                lbDisplay.Text = CStr(num3)
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
        oneTime = 1
        eqlIf = 1
    End Sub
End Class
