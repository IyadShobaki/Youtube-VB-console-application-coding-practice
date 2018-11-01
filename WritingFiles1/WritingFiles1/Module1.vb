Module Module1

    Sub Main()
        'the process of working with files
        '1) Open the file
        '2) Do your stuff
        '3) Close the file

        FileOpen(1, "hello.txt", OpenMode.Append)
        'Loop until user enters stop
        Dim input As String = ""
        While input.ToUpper <> "STOP"
            Console.Write("Enter a sentence (STOP to stop): ")
            input = Console.ReadLine
            If input.ToUpper <> "STOP" Then
                PrintLine(1, input)
            End If
        End While
        FileClose(1)

    End Sub

End Module