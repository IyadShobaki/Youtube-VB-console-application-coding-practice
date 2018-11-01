Module Module1
    Function CalculateAverageAndTotal(nums() As Single,
                                      Optional ByRef total As Single = 0)


        For i = 0 To nums.Length - 1
            total += nums(i)
        Next
        Return total / nums.Length
    End Function
    Sub Main()
        Dim nums As New List(Of Single)
        Dim num As Single
        Do
            Console.Write("Please enter a number (or -1 to stop) : ")
            num = Console.ReadLine
            If num <> -1 Then nums.Add(num)
        Loop Until num = -1

        Dim total As Single = 0

        Dim average As Single = CalculateAverageAndTotal(nums.ToArray, total)
        Console.WriteLine("The average is " & average & " and the total is " & total)
        Console.ReadLine()


    End Sub

End Module
