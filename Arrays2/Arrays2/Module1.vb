Module Module1



    Class STUDENT
        Public firstname As String
        Public lastname As String
        Public dob As Date

    End Class
    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0

    Sub Main()
        'Aloctae memory for each student

        For i = 0 To 9
            students(i) = New STUDENT
        Next
        Dim selection As Char
        While selection <> "C"
            Console.WriteLine("Welcome to student database")
            Console.WriteLine("Numbers of students: " & studentCount)
            Console.WriteLine(" (A) Add a student")
            Console.WriteLine(" (B) View a student")
            Console.WriteLine(" (C) Quit")
            selection = Console.ReadLine.ToUpper
            If selection = "A" Then
                Console.WriteLine("Please enter a firstname: ")
                students(studentCount).firstname = Console.ReadLine

                Console.WriteLine("Please enter a lastname: ")
                students(studentCount).lastname = Console.ReadLine

                Console.WriteLine("Please enter a DOB: ")
                students(studentCount).dob = Console.ReadLine
                'Increment
                studentCount += 1
                Console.WriteLine("Student entered!")
                Console.ReadLine()
                Console.Clear()
            ElseIf selection = "B" Then
                For i = 0 To studentCount - 1

                    Console.WriteLine("Student's firstname: " & students(i).firstname)
                    Console.WriteLine("Student's lastname: " & students(i).lastname)
                    Console.WriteLine("Student's DOB: " & students(i).dob)
                Next

                Console.ReadLine()
                Console.Clear()

            End If
        End While

    End Sub
End Module