Module Module1

    Sub Main()

        Dim rect1 As New cRectangle(10, 50)
        Dim rect2 As New cRectangle(10, 50)


        Dim cube1 As New cCube(10, 20, 5)

        If (rect1 = rect2) Then
            Console.WriteLine("Rect 1 and rect 2 are the same!")
        Else
            Console.WriteLine("Rect 1 and rect 2 are NOT the same!")
        End If
        Console.WriteLine(rect1.ToString)
        Console.WriteLine(rect2.ToString)

        Console.WriteLine("The area of rect1 is " & rect1.GetArea())
        Console.WriteLine("The area of rect2 is " & rect2.GetArea())
        Console.WriteLine("The area of cube1 is " & cube1.GetArea())
        Console.WriteLine("Numberof Shapes are " & cRectangle.ShapeCount)
        Console.ReadLine()


    End Sub

End Module
