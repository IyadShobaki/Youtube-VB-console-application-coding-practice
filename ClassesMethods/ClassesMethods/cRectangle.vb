Public Class cRectangle

    Private _width As Integer
    Private _height As Integer
    Public Shared ShapeCount As Integer = 0
    Function GetArea() As Integer

        Return _width * _height

    End Function

    Public Property Width As Integer
        Set(value As Integer)

            If value >= 0 Then
                _width = value
            End If

        End Set
        Get
            Return _width
        End Get
    End Property
    Public Property Height As Integer
        Set(value As Integer)

            If value >= 0 Then
                _height = value
            End If

        End Set
        Get
            Return _height
        End Get
    End Property

    Public Sub New()
        'Initialising the variable contents
        _width = 0
        _height = 0
        ShapeCount += 1
    End Sub
    Public Sub New(width As Integer, height As Integer)
        'Initialising the variable contents
        _width = width
        _height = height
        ShapeCount += 1
    End Sub
End Class
