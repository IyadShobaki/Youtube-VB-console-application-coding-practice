Module Module1

    Sub Main()
        Dim x As Integer
        Dim y As Integer

        x = 70
        y = 50

        Console.WriteLine("Addition: " & x + y)
        Console.WriteLine("Substraction: " & x - y)
        Console.WriteLine("Multiplication: " & x * y)
        Console.WriteLine("Division: " & x / y)
        Console.WriteLine("Modulus: " & x Mod y)
        Console.WriteLine("Power of: " & x ^ y)

        Console.ReadLine()

        Console.WriteLine("Less than: " & (x < y))
        Console.WriteLine("Greater than: " & (x > y))
        Console.WriteLine("Less than or equal to: " & (x <= y))
        Console.WriteLine("Greater than or equal to: " & (x >= y))
        Console.WriteLine("Equal to: " & (x = y))
        Console.WriteLine("Not equal to: " & (x <> y))
        Console.ReadLine()
        Console.WriteLine((10 > 2) And (5 > 2))
        Console.WriteLine((10 < 2) Or (5 > 2))
        Console.WriteLine((10 < 2) Xor (5 > 2))
        Console.WriteLine(Not (5 > 2))
        Console.ReadLine()

        Console.Clear()
        Dim numOffCows As UInteger = 10
        Dim temperature As Single = 21.7
        Dim sentence As String = "Hello World"
        Dim hasPaid As Boolean = False
        Dim c As Char = "P"
        Dim d As Char = "p"
        Console.WriteLine((c <> d))
        Console.WriteLine(numOffCows)
        Console.WriteLine(temperature)
        Console.WriteLine(sentence)
        Console.WriteLine(hasPaid)


    End Sub

End Module
