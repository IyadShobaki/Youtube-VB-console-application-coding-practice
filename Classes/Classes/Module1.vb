Module Module1

    'Class
    'Heterogeneous - they contain different types of data
    '    String, Tnteger, Boolean, Single

    'Student
    '     FirstName
    '     LastName
    '      DOB

    Class STUDENT
        Public firstname As String
        Public lastname As String
        Public dob As Date

    End Class
    Dim student1 As New STUDENT
    Sub main()
        Dim selection As Char
        While selection <> "C"
            Console.WriteLine("Welcome to student database")
            Console.WriteLine()
            Console.WriteLine(" (A) Add a student")
            Console.WriteLine(" (B) View a student")
            Console.WriteLine(" (C) Quit")
            selection = Console.ReadLine.ToUpper
            If selection = "A" Then
                Console.WriteLine("Please enter a firstname: ")
                student1.firstname = Console.ReadLine

                Console.WriteLine("Please enter a lastname: ")
                student1.lastname = Console.ReadLine

                Console.WriteLine("Please enter a DOB: ")
                student1.dob = Console.ReadLine
                Console.WriteLine("Student entered!")
                Console.ReadLine()
                Console.Clear()
            ElseIf selection = "B" Then
                Console.WriteLine("Student's firstname: " & student1.firstname)
                Console.WriteLine("Student's lastname: " & student1.lastname)
                Console.WriteLine("Student's DOB: " & student1.dob)
                Console.ReadLine()
                Console.Clear()

            End If
        End While

    End Sub
End Module
