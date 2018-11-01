Module Module1

    Sub Main()
        Dim nums(9) As Integer

        For i = 0 To 9
            Console.WriteLine("Please enter a number: ")
            nums(i) = Console.ReadLine

        Next

        Array.Sort(nums)
        Console.WriteLine("Numbers sorted")
        For Each element As Integer In nums
            Console.WriteLine(element)
        Next

        Console.ReadLine()


    End Sub

End Module
