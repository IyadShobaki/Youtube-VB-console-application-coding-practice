Module Module1

    Function Add(a As Integer, b As Integer)
        'stub

        Return a + b

    End Function
    Function Subtract(a As Integer, b As Integer)


        Return a - b
    End Function
    Function Times(a As Integer, b As Integer)

        Return a * b
    End Function
    Function Divide(a As Integer, b As Integer)
        Return a / b
    End Function
    Function Modulus(a As Integer, b As Integer)

        Return a Mod b
    End Function
    Sub CollectTwoNumbers(operation As String)
        Dim num As Integer
        Dim num2 As Integer
        Console.WriteLine("Please enter your first number:  ")
        num = Console.ReadLine

        Console.WriteLine("Please enter your second number:  ")
        num2 = Console.ReadLine

        If operation = "add" Then
            Console.WriteLine("Addition of two numbers is :" & Add(num, num2))
        ElseIf operation = "subtract" Then
            Console.WriteLine("Subtraction of two numbers is : " & Subtract(num, num2))
        ElseIf operation = "times" Then
            Console.WriteLine("Multiplication of two numbers is : " & Times(num, num2))
        ElseIf operation = "divide" Then
            Console.WriteLine("Division of two numbers is : " & Divide(num, num2))
        ElseIf operation = "modulus" Then
            Console.WriteLine("Modulus of two numbers is : " & Modulus(num, num2))


        End If
        Console.ReadLine()

    End Sub
    Sub Menu()

        Dim selection As Char
        While selection <> "q" And selection <> "Q"
            Console.Clear()

            Console.WriteLine("Welcome to Maths fun!")
            Console.WriteLine()
            Console.WriteLine("(A) Add")
            Console.WriteLine("(B) Subtract")
            Console.WriteLine("(C) Times")
            Console.WriteLine("(D) Divide")
            Console.WriteLine("(E) Modulus")
            Console.WriteLine()

            Console.WriteLine("(Q) Quit")

            selection = Console.ReadLine

            'what operation did they select
            If selection = "a" Or selection = "A" Then
                CollectTwoNumbers("add")
            ElseIf selection = "b" Or selection = "B" Then
                CollectTwoNumbers("subtract")
            ElseIf selection = "c" Or selection = "C" Then
                CollectTwoNumbers("times")

            ElseIf selection = "d" Or selection = "D" Then
                CollectTwoNumbers("divide")

            ElseIf selection = "e" Or selection = "E" Then
                CollectTwoNumbers("modulus")


            End If
        End While
    End Sub
    Sub Main()
        'Subs (Sub Routine)
        'Parameters
        'Functions

        'Menu
        '-Select what type of maths operation
        '--Collect two numbers
        '--Perform the maths operation
        Menu()

    End Sub

End Module
