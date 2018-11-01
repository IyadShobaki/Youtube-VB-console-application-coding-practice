Module Module1

    Sub Main()
        'Reading from files process 
        '1) Open the file
        '2) Do your stuff
        '3) Close the file

        Dim filenum As Integer
        filenum = FreeFile()

        If IO.File.Exists("hello.txt") Then

            FileOpen(filenum, "hello.txt", OpenMode.Input)

            'Reading from the file
            While Not EOF(filenum)
                Console.WriteLine(LineInput(filenum))
            End While

            FileClose(filenum)
        Else
            Console.WriteLine("Could not find file hello.txt")
        End If

        Console.ReadLine()


    End Sub

End Module
