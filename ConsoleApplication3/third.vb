Module third

    Sub Main()
        Dim ahq, fnc, fw, min, max As Integer
        fw = 0
        min = 0
        max = 1000
        Dim c9 As New Random()
        fnc = c9.Next(1, 1000)
        Console.WriteLine("~~~~~~來跟你玩玩一個遊戲~~~~~~~~")
        Console.WriteLine("~~~~~~猜猜我心裡在想甚麼數字~~~~~~")
        Console.WriteLine("~~~~~1到1000~~~~~")
        Console.WriteLine()
        Do
            Console.WriteLine("猜數字的範圍{0}<?<{1}:", min, max)
            ahq = Val(Console.ReadLine())
            fw += 1
            If ahq >= 1 And ahq < 1000 Then

                If ahq = fnc Then
                    Console.WriteLine("真棒!你猜到我在想甚麼了,答案是{0}", fw)
                    Exit Do
                ElseIf ahq > fw Then
                    max = ahq
                    Console.WriteLine("可惜~還要在小一點!")
                ElseIf ahq < fw Then
                    min = ahq
                    Console.WriteLine("殘念~在大一點!")
                End If
                Console.WriteLine("您猜了{0}次", fnc)
                Console.WriteLine()
            Else
                Console.WriteLine("請輸入提示範圍內的數字!")
            End If


        Loop While True
        Console.Read()
    End Sub

End Module
