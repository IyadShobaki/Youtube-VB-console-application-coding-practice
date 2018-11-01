Module Module1

    Sub Main()
        Dim months(11) As String

        months(0) = "Jan"
        months(1) = "Feb"
        months(2) = "Mar"
        months(3) = "Apr"
        months(4) = "May"
        months(5) = "Jun"
        months(6) = "Jul"
        months(7) = "Aug"
        months(8) = "Sep"
        months(9) = "Oct"
        months(10) = "Nov"
        months(11) = "Dec"


        For i As Integer = 0 To 11
            Console.WriteLine("   (" & i + 1 & ") " & months(i))
        Next
        Console.ReadLine()

    End Sub

End Module
