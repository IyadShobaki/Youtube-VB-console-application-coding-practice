Module Module1

    Sub Main()
        'Lists
        Dim numbers As New List(Of Integer)
        Dim num As Integer = -1
        While num <> 0
            Console.WriteLine("Please enter a number: ")
            num = Console.ReadLine
            If num <> 0 Then
                numbers.Add(num)
            End If
        End While

        Console.WriteLine("Numbers of list elements: " & numbers.Count)
        Console.WriteLine("The first element: " & numbers(0))
        Console.WriteLine("The last element: " & numbers(numbers.Count - 1))
        Console.WriteLine("The smallest number: " & numbers.Min)
        Console.WriteLine("The largest number: " & numbers.Max)
        Console.WriteLine("The average: " & numbers.Average)

        Console.ReadLine()


    End Sub

End Module
