Module Module1

    Sub Main()
        Dim x As Integer
        Dim y As Integer

        Try
            Console.Write("Please enter a number: ")
            x = Console.ReadLine
            Console.Write("Please enter another number: ")
            y = Console.ReadLine
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try




        Console.WriteLine("Addition: " & x + y)
        Console.WriteLine("Substraction: " & x - y)
        Console.WriteLine("Multiplication: " & x * y)
        Try
            Console.WriteLine("Division: " & x / y)
            Console.WriteLine("Modulus: " & x Mod y)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.WriteLine("Power of: " & x ^ y)

        Console.ReadLine()
    End Sub

End Module
