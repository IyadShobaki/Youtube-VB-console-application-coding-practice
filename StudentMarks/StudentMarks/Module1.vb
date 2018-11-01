Module Module1
    'Maintain the active DBMS connection
    Dim connection As OleDb.OleDbConnection
    Sub ConnectToDatabase()
        ' Buil a connection string
        connection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0; " &
                                               "Data Source=Student Marks.accdb;")

        'Open the connection
        connection.Open()

    End Sub
    Sub DisconnectFromDatabase()

        'Stop the connection
        connection.Close()

    End Sub

    Sub Menu()
        'Stores the selection from the menu
        Dim selection As Char
        Do
            'Draw the menu
            Console.Clear()
            Console.WriteLine("Please select from the following options: ")
            Console.WriteLine("")
            Console.WriteLine(" (A) View all students")
            Console.WriteLine(" (B) Add student")
            Console.WriteLine(" (C) View student's marks")
            Console.WriteLine(" (D) Add a student mark")
            Console.WriteLine(" (E) Delete student")
            Console.WriteLine(" (F) Delete a student mark")
            Console.WriteLine("")
            Console.WriteLine(" (X) Exit")
            Console.WriteLine("Selection: ")
            selection = Console.ReadLine.ToUpper
            'What did the select
            If selection = "A" Then
                ViewStudents()
                Console.ReadLine()

            ElseIf selection = "B" Then
                AddStudent()
            ElseIf selection = "C" Then
                ViewStudentMarks()
            ElseIf selection = "D" Then
                AddStudentMark()
            ElseIf selection = "E" Then
                DeleteStudent()
            ElseIf selection = "F" Then
                DeleteStudentMark()


            End If
        Loop Until selection = "X"
    End Sub

    Sub ViewStudents()

        'Build the query
        Dim q As String = "SELECT * FROM Students"
        'Execute the query
        Dim cmd As New OleDb.OleDbCommand(q, connection)
        Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader

        ' Draw a label for the colums
        Console.Clear()
        Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20}", "ID", "Firstname", "Lastname", "DOB")

        'Draw each student
        While reader.Read
            Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20}",
                              reader("ID"),
                              reader("Firstname"),
                              reader("Lastname"),
                              reader("DOB"))

        End While
        'Close the reader object
        reader.Close()

    End Sub

    Sub AddStudent()

        'Gather the student info
        Dim firstname As String
        Dim lastname As String
        Dim dob As Date
        'Ask the user
        Console.Clear()
        Console.WriteLine("Enter the details for the new student below")
        Console.Write("Firstname: ")
        firstname = Console.ReadLine

        Console.Write("Lastname: ")
        lastname = Console.ReadLine

        Console.Write("DOB: ")
        dob = Console.ReadLine

        'Build the query
        Dim q As String = "INSERT INTO Students(Firstname,Lastname,DOB) VALUES ('" & firstname & "','" & lastname & "','" & dob & "')"

        'Execute the query
        Dim cmd As New OleDb.OleDbCommand(q, connection)
        cmd.ExecuteNonQuery()

    End Sub

    Sub ViewStudentMarks()

        'Show list of the students
        ViewStudents()

        'Get ID from the user
        Console.WriteLine("Enter the ID of the student to select: ")
        Dim id As Integer = Console.ReadLine

        If id > 0 Then

            'Build query string
            'SELECT Colums FROM Table1 INNER JOIN Table2 ON Field1 = Field2 WHERE Field= id
            Dim q As String = "SELECT Students.Firstname, Students.Lastname, Marks.`Assessment Name`, Marks.Mark " &
                              "FROM Students INNER JOIN Marks ON Students.ID = Marks.Student_ID WHERE Students.ID = " & id
            'Execute and read
            Dim cmd As New OleDb.OleDbCommand(q, connection)
            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader

            'Get the first record
            reader.Read()

            'Write the heading
            Console.WriteLine()
            Console.WriteLine("Marks for the student " & reader("Firstname") & " " & reader("Lastname"))
            Console.WriteLine("{0,-5} {1,-20} {2,-4}", "", reader("Assessment Name"), reader("Mark"))

            'Read the next record
            While reader.Read
                Console.WriteLine("{0,-5} {1,-20} {2,-4}", "", reader("Assessment Name"), reader("Mark"))

            End While
            'Close our reader
            reader.Close()
            Console.ReadLine()

        End If



    End Sub

    Sub AddStudentMark()
        'Show list of the students
        ViewStudents()

        'Get ID from the user
        Console.WriteLine("Enter the ID of the student to select: ")
        Dim id As Integer = Console.ReadLine

        If id > 0 Then
            'Storage space
            Dim name As String
            Dim mark As Integer

            Console.WriteLine()
            Console.WriteLine("Enter the new mark details")

            'ask for the details
            Console.Write("Assessment Name: ")
            name = Console.ReadLine

            Console.WriteLine("Mark: ")
            mark = Console.ReadLine

            'Build query
            Dim q As String = "INSERT INTO Marks(Student_ID,`Assessment Name`,Mark) VALUES(" & id & ",'" & name & "'," & mark & ")"
            'Execute a query
            Dim cmd As New OleDb.OleDbCommand(q, connection)
            cmd.ExecuteNonQuery()

            'Done
        End If
    End Sub

    Sub DeleteStudent()

        'Show list of the students
        ViewStudents()

        'Get ID from the user
        Console.WriteLine("Enter the ID of the student to select: ")
        Dim id As Integer = Console.ReadLine

        If id > 0 Then
            'First delete their marks
            Dim q As String = "DELETE FROM Marks WHERE Student_ID = " & id
            Dim cmd As New OleDb.OleDbCommand(q, connection)
            cmd.ExecuteNonQuery()

            'Second delete the student themself
            q = "DELETE FROM Students WHERE ID = " & id
            cmd = New OleDb.OleDbCommand(q, connection)
            cmd.ExecuteNonQuery()


        End If

    End Sub
    Sub DeleteStudentMark()
        'Show list of the students
        ViewStudentMarks()
        'Get ID from the user


        Console.WriteLine()
        Console.WriteLine("Enter Assessment name to select: ")

        Dim name As String = Console.ReadLine
        If name <> "" Then
            Dim q As String = "DELETE FROM Marks WHERE `Assessment Name` = " & name
            Dim cmd As New OleDb.OleDbCommand(q, connection)
            cmd.ExecuteNonQuery()
        End If



    End Sub
    Sub Main()

        'Connect to the database
        ConnectToDatabase()

        'Show the menu
        Menu()

        'Disconnect from the database

        DisconnectFromDatabase()


    End Sub

End Module
