Module Module1
    Function CalculateAverageAndTotal(num1 As Single,
                                      num2 As Single,
                                      Optional num3 As Single = -1,
                                      Optional ByRef total As Single = 0)

        If num3 <> -1 Then
            total = num1 + num2 + num3
            Return total / 3
        Else
            total = num1 + num2
            Return total / 2
        End If



    End Function
    Sub Main()
        Console.Write("Please enter a number: ")
        Dim num1 As Single = Console.ReadLine

        Console.Write("Please enter another number: ")
        Dim num2 As Single = Console.ReadLine

        Console.Write("Please enter another number: ")
        Dim num3 As Single = Console.ReadLine

        Dim total As Single = 0


        Dim average As Single = CalculateAverageAndTotal(num1, num2, num3, total)
        Console.WriteLine("The average is " & average & " and the total is " & total)
        Console.ReadLine()


    End Sub

End Module
