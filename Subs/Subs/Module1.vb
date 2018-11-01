Module Module1
    Sub Add()
        'stub
        Dim num As Integer
        Dim num2 As Integer

        Console.WriteLine("Please enter your first number:  ")
        num = Console.ReadLine

        Console.WriteLine("Please enter your second number:  ")
        num2 = Console.ReadLine

        Console.WriteLine("Your two numbers added are: " & num + num2)
        Console.ReadLine()

    End Sub
    Sub Subtract()
        Dim num As Integer
        Dim num2 As Integer
        Console.WriteLine("Please enter your first number:  ")
        num = Console.ReadLine

        Console.WriteLine("Please enter your second number:  ")
        num2 = Console.ReadLine

        Console.WriteLine("Your two numbers subtracted are: " & num - num2)
        Console.ReadLine()
    End Sub
    Sub Times()
        Dim num As Integer
        Dim num2 As Integer
        Console.WriteLine("Please enter your first number:  ")
        num = Console.ReadLine

        Console.WriteLine("Please enter your second number:  ")
        num2 = Console.ReadLine

        Console.WriteLine("Your two numbers multipled are: " & num * num2)
        Console.ReadLine()
    End Sub
    Sub Divide()
        Dim num As Integer
        Dim num2 As Integer
        Console.WriteLine("Please enter your first number:  ")
        num = Console.ReadLine

        Console.WriteLine("Please enter your second number:  ")
        num2 = Console.ReadLine

        Console.WriteLine("Your two numbers divided are: " & num / num2)
        Console.ReadLine()
    End Sub
    Sub Modulus()
        Dim num As Integer
        Dim num2 As Integer
        Console.WriteLine("Please enter your first number:  ")
        num = Console.ReadLine

        Console.WriteLine("Please enter your second number:  ")
        num2 = Console.ReadLine

        Console.WriteLine("Your two numbers mod are: " & num Mod num2)
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
        If selection = "a" Or selection = "A" Then
            Add()
        ElseIf selection = "b" Or selection = "B" Then
            Subtract()
        ElseIf selection = "c" Or selection = "C" Then
            Times()

        ElseIf selection = "d" Or selection = "D" Then
            Divide()

        ElseIf selection = "e" Or selection = "E" Then



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
