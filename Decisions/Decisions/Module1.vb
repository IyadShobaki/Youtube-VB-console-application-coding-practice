Module Module1
    ''' <summary>
    ''' In this program I want to demonstarte decisions:
    ''' (1) Comments
    ''' (2) If statements, selection statements
    ''' (3) Demo
    ''' (4) Nested if statements 
    ''' (5) Set tasks
    ''' </summary>
    Sub Main()
        'Welcome to my programming videos
        'If statement
        'Condition: yes or no (true or false)

        '   Console.Write("Please enter a number: ")
        'Dim num As Integer = Console.ReadLine
        'Binary Decision
        'If num > 0 Then
        'Console.WriteLine("Your number is positive")
        'ElseIf num < 0 Then
        'Console.WriteLine("Your number is negative")
        'End If
        '-----------------
        'Multiway Decision
        'If num > 0 Then
        '        Console.WriteLine("Your number is positive")
        'ElseIf num < 0 Then
        '        Console.WriteLine("Your number is negative")
        'Else
        '       Console.WriteLine("Your number is zero")
        'End If

        ' Get a mark frim the teacher
        '  Console.Write("Please enter a mark: ")
        ' Dim mark As Integer = Console.ReadLine
        'check the mark
        '0-49 = Fail
        '50-64 = Pass
        '65-74 = Credit
        '75-84 = Distinction
        ' 85-100 = High Distinction
        'Anything else = Invalid mark
        '  If mark >= 0 And mark <= 49 Then
        '  Console.WriteLine("Fall")
        ' ElseIf mark >= 50 And mark <= 64 Then
        '  Console.WriteLine("Pass")
        '  ElseIf mark >= 65 And mark <= 74 Then
        ' Console.WriteLine("Credit")
        ' ElseIf mark >= 75 And mark <= 84 Then
        ' Console.WriteLine("Distinction")
        ' ElseIf mark >= 85 And mark <= 100 Then
        ' Console.WriteLine("High Distinction")
        '  Else
        '  Console.WriteLine("Invalid mark")
        '   End If

        '------------------
        ' Selection Statement
        'Select Case <var>
        ' Case <value>
        'Instructions
        ' Case <value>
        ' Instructions
        ' End Select
        ' Get a menu from the user, check what the selected
        'Console.WriteLine("Select from the following")
        'Console.WriteLine(" (a) Apples")
        'Console.WriteLine(" (b) Bananas")
        'Console.WriteLine(" (c) Carrots")
        'Console.Write("Choice: ")
        'Get the user choice
        'Dim selection As Char = Console.ReadKey.KeyChar
        'Console.WriteLine()

        ' check what the selected
        'Select Case selection
        '    Case "a"
        '    Case "A"
        '        Console.WriteLine("You love apples!")
        '    Case "b"
        '    Case "B"
        '        Console.WriteLine("You love bananas!")
        '    Case "c"
        '    Case "C"
        '        Console.WriteLine("You love carrots!")
        '    Case Else
        '        Console.WriteLine("You love nothing!")
        'End Select

        '-------------

        'Nested if statement
        Console.Write("Please enter a number: ")
        Dim num As Integer = Console.ReadLine
        If num > 0 Then
            Console.WriteLine("Your number is positive")
            'check if even or odd
            If num Mod 2 = 0 Then
                Console.WriteLine("Your number is even")
            ElseIf num Mod 2 = 1 Then
                Console.WriteLine("Your number is odd")
            End If
        ElseIf num < 0 Then
            Console.WriteLine("Your number is negative")
        Else
            Console.WriteLine("Your number is zero")
        End If

    End Sub

End Module
