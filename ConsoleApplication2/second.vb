Module second

    Sub Main()
        Dim mlb, nba, sum As Integer
        Console.WriteLine("請輸入整體個數:")
        nba = Val(Console.ReadLine())
        Dim us(nba - 1) As Integer
        For mlb = 0 To us.GetUpperBound(0)
            Console.WriteLine("請輸入你想要給的第{0}個數字:", (mlb + 1).ToString)
            us(mlb) = Val(Console.ReadLine())
        Next
        For Each height As Integer In us
            sum += height
        Next
        Console.WriteLine("你得到最大數是{0}", GetMax(us).ToString())
        Console.WriteLine("你得到最小數是{0}", GetMin(us).ToString())
        Console.WriteLine("你得到的平均值是{0}", CInt((sum / nba)).ToString)


        Console.ReadLine()
    End Sub
    Function GetMax(ByVal ParamArray us() As Integer) As Integer
        Dim max As Integer
        max = us(0)
        For mlb As Integer = 1 To us.Length - 1
            If us(mlb) > max Then
                max = us(mlb)
            End If
        Next
        Return max
    End Function
    Function GetMin(ByVal ParamArray us() As Integer) As Integer
        Dim min As Integer
        min = us(0)
        For mlb As Integer = 1 To us.Length - 1
            If us(mlb) < min Then
                min = us(mlb)
            End If
        Next
        Return min
    End Function
End Module

