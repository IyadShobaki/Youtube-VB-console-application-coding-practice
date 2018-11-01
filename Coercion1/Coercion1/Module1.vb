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
        Dim s As String
        Dim strings As New List(Of String)
        Do
            Console.Write("Please enter a sentence (just press enter to exit): ")
            s = Console.ReadLine
            If s <> "" Then strings.Add(s)

        Loop Until s = ""




        Console.WriteLine(JoinStrings(strings.ToArray))
        Console.ReadLine()

    End Sub

End Module
