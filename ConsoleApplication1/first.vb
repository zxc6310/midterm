Module first

    Sub Main()
        Dim n1, n2 As Integer
        Console.Write("1.請輸入您的體重(kg):")
        n1 = Integer.Parse(Console.ReadLine())
        Console.Write("2.請輸入您的身高(cm):")
        n2 = Integer.Parse(Console.ReadLine())
        Dim n3 = n2 / 100
        Dim n4 = n3 * n3
        Dim s = n1 / n4

        Console.WriteLine(vbNewLine & "您的BMI:{0}", s.ToString)
        Console.Read()
    End Sub

End Module
