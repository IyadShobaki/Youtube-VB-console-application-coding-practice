Module Module1

    Sub Main()
        'If you feel you are repeating yourself ,you are
        'Use loops
        'write hello world 100 times
        'While loop (pre-test loop)

        'Dim i As Integer = 0
        '
        '
        'While i < 100
        '    Console.WriteLine(i & " Hello World")
        '    i += 1
        'End While

        ' Do... Loop Until (post-test loop)
        'Dim j As Integer = 0
        '
        'Do
        '    Console.WriteLine(j & " Hello World")
        '    j += 1
        'Loop Until j = 100

        'For Loop (interative/counter loop)

        'For k As Integer = 0 To 99 Step 5
        '    Console.WriteLine(k & " Hello World")
        'Next
        Dim selection As Char
        While selection.ToString.ToUpper <> "D"

            Console.WriteLine("Select from the following")
        Console.WriteLine("(A) Apple")
        Console.WriteLine("(B) Banana")
        Console.WriteLine("(C) Carrot")
        Console.WriteLine("(D) Quit")
        Console.WriteLine("Chice: ")
            selection = Console.ReadKey.KeyChar
            Console.WriteLine()
        ' check what they selected
        Select Case selection.ToString.ToUpper
            Case "A"
                Console.WriteLine("You love apples!")
            Case "B"
                Console.WriteLine("You love bananas!")
            Case "C"
                Console.WriteLine("You love Carrots!")
            Case Is <> "D"
                Console.WriteLine("You don't like food")
        End Select
        End While



    End Sub

End Module
