Option Strict Off
Option Explicit On
Friend Class Position
    'Any piece or segment may have a position on the board

    Dim iXPos As Short 'the horizontal co-ordinate locating a board square
    Dim iYPos As Short 'the vertical co-ordinate locating a board square

    Public Property XPos() As Short
        Get
            XPos = iXPos
        End Get
        Set(ByVal Value As Short)
            iXPos = Value
        End Set
    End Property

    Public Property YPos() As Short
        Get
            YPos = iYPos
        End Get
        Set(ByVal Value As Short)
            iYPos = Value
        End Set
    End Property

    Private Sub Class_Initialize_Renamed()
        iXPos = 0
        iYPos = 0
    End Sub

    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub
End Class