Module Module1

    Sub Main()

        Dim rect1 As New cRectangle(10, 50)
        Dim rect2 As New cRectangle(20, 15)
        Dim rect3 As New cRectangle(10, 50)
        Dim rect4 As New cRectangle(20, 15)
        Dim rect5 As New cRectangle(10, 50)
        Dim rect6 As New cRectangle(20, 15)



        Console.WriteLine("The area of rect1 is " & rect1.GetArea())
        Console.WriteLine("The area of rect2 is " & rect2.GetArea())
        Console.WriteLine("Numberof rectangles are " & cRectangle.ShapeCount)
        Console.ReadLine()


    End Sub

End Module
