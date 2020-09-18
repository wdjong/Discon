Option Strict Off
Option Explicit On
Public Class Move
    'For storing moves
    Private iPPID1 As Short 'Player Piece ID
    'Private iPPiece As PPiece 'ref to player piece being moved
    Private iDirection1 As Short '1 = 5 o'clock, 2 = 4 o'clock 3 = 2 o'clock 4 = 1 o'clock etc
    'Private iXPos As Short 'horizontal position from 1 Left to Max (10) Right
    'Private iYPos As Short 'horizontal position from 1 Bottom to Max (10) Top
    Private iPPID2 As Short 'Player Piece ID
    'Private iPPiece As PPiece 'ref to player piece being moved
    Private iDirection2 As Short '1 = 5 o'clock, 2 = 4 o'clock 3 = 2 o'clock 4 = 1 o'clock etc

    Public Property Direction1() As Short
        Get
            Direction1 = iDirection1
        End Get
        Set(ByVal Value As Short)
            iDirection1 = Value
        End Set
    End Property

    Public Property Direction2() As Short
        Get
            Direction2 = iDirection2
        End Get
        Set(ByVal Value As Short)
            iDirection2 = Value
        End Set
    End Property

    'Public Property PPiece() As PPiece
    '    Get
    '        PPiece = iPPiece
    '    End Get
    '    Set(ByVal Value As PPiece)
    '        iPPiece = Value
    '    End Set
    'End Property

    'Public Property XPos() As Short
    '    Get
    '        XPos = iXPos
    '    End Get
    '    Set(ByVal Value As Short)
    '        iXPos = Value
    '    End Set
    'End Property

    'Public Property YPos() As Short
    '    Get
    '        YPos = iYPos
    '    End Get
    '    Set(ByVal Value As Short)
    '        iYPos = Value
    '    End Set
    'End Property

    Public Property PPID1() As Short
        Get
            PPID1 = iPPID1
        End Get
        Set(ByVal Value As Short)
            iPPID1 = Value
        End Set
    End Property

    Public Property PPID2() As Short
        Get
            PPID2 = iPPID2
        End Get
        Set(ByVal Value As Short)
            iPPID2 = Value
        End Set
    End Property

End Class