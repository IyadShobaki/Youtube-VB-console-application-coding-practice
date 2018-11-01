Module Module1
    Function JoinStrings(strings() As String) As String
        'Join the array of strings and return
        Dim result As String = strings(0)
        'Add the rest of the strings
        For i = 1 To strings.Length - 1
            result &= " " & strings(i)
        Next

        Return result

    End Function
    Function JoinStrings(string1 As String,
                        string2 As String,
                         string3 As String) As String
        'Join three string together
        Return string1 & " " & string2 & " " & string3
    End Function
    Function JoinStrings(string1 As String,
                        string2 As String) As String
        'Join two string together
        Return string1 & " " & string2
    End Function

    Sub Main()

        Console.Write("Please enter a sentence: ")
        Dim s1 As String = Console.ReadLine

        Console.Write("Please enter another sentence: ")
        Dim s2 As String = Console.ReadLine

        Console.Write("Please enter another sentence agian: ")
        Dim s3 As String = Console.ReadLine

        Console.WriteLine(JoinStrings(s1, s2, s3))
        Console.ReadLine()

    End Sub

End Module
