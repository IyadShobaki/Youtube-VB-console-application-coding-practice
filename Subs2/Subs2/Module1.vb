Module Module1

    Sub Add(a As Integer, b As Integer)
        'stub


        Console.WriteLine("Your two numbers added are: " & a + b)
        Console.ReadLine()

    End Sub
    Sub Subtract(a As Integer, b As Integer)


        Console.WriteLine("Your two numbers subtracted are: " & a - b)
        Console.ReadLine()
    End Sub
    Sub Times(a As Integer, b As Integer)


        Console.WriteLine("Your two numbers multipled are: " & a * b)
        Console.ReadLine()
    End Sub
    Sub Divide(a As Integer, b As Integer)

        Console.WriteLine("Your two numbers divided are: " & a / b)
        Console.ReadLine()
    End Sub
    Sub Modulus(a As Integer, b As Integer)

        Console.WriteLine("Your two numbers mod are: " & a Mod b)
        Console.ReadLine()
    End Sub
    Sub CollectTwoNumbers(operation As String)
        Dim num As Integer
        Dim num2 As Integer
        Console.WriteLine("Please enter your first number:  ")
        num = Console.ReadLine

        Console.WriteLine("Please enter your second number:  ")
        num2 = Console.ReadLine

        If operation = "add" Then
            Add(num, num2)
        ElseIf operation = "subtract" Then
            Subtract(num, num2)
        ElseIf operation = "times" Then
            Times(num, num2)
        ElseIf operation = "divide" Then
            Divide(num, num2)
        ElseIf operation = "modulus" Then
            Modulus(num, num2)


        End If
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
