Option Strict Off
Option Explicit On
Friend Class Segment
    'a Segment is a disc that can become part of a tower when captured by a piece
	Private iColour As Short '1 White, 2 Pink, 3 Blue, 4 Purple
	Private iSID As Short 'ID of piece should match array index of piece objects and controls on the form
	Private mbooOnBoard As Boolean 'If the piece is currently in play
	Private mbytValue As Short 'value of piece
	Private mbytXPos As Short 'Current file 1 to 8 left to right convert to letters in algebraic notation section
	Private mbytYPos As Short 'Current rank 1 to 8 bottom to top
    Private oBoard As Board 'This is just a reference to the one board for easy access to dimensions etc.

    Public Sub New()
        MyBase.New()
        iColour = 0
        iSID = 0
        mbooOnBoard = False
        mbytValue = 0
        mbytXPos = 0
        mbytYPos = 0
        VerticalPos = 1
    End Sub

    Public Property VerticalPos() 'When towers are left without a piece you need a way to add them back in the right order 1 is lowers (on the board), 2 is on top of that etc 

    Public Property Colour() As Short
        Get
            Colour = iColour
        End Get
        Set(ByVal Value As Short)
            iColour = Value
        End Set
    End Property

    Public Property ID() As Short
        Get
            ID = iSID
        End Get
        Set(ByVal Value As Short)
            iSID = Value
        End Set
    End Property

    Public ReadOnly Property OnBoard() As Boolean
        Get
            OnBoard = mbooOnBoard
        End Get
    End Property

    Public Property Value() As Short
        Get
            Value = mbytValue
        End Get
        Set(ByVal Value As Short)
            mbytValue = Value
        End Set
    End Property

    Public Property XPos() As Short
        Get
            XPos = mbytXPos
        End Get
        Set(ByVal Value As Short)
            mbytXPos = Value
            mbooOnBoard = ((Value <= oBoard.maxX) And (Value >= 1)) And ((mbytYPos <= oBoard.maxY) And (mbytYPos >= 1))
        End Set
    End Property

    Public Property YPos() As Short
        Get
            YPos = mbytYPos
        End Get
        Set(ByVal Value As Short)
            mbytYPos = Value
            mbooOnBoard = ((mbytXPos <= oBoard.maxX) And (mbytXPos >= 1)) And ((Value <= oBoard.maxY) And (Value >= 1))
        End Set
    End Property

    Public Sub Move(ByRef x As Short, ByRef y As Short)
        mbytXPos = x 'set new SEG xpos
        mbytYPos = y 'set new SEG ypos
        mbooOnBoard = oBoard.onBoard(x, y)
        'Draw()
    End Sub

    Public Sub Remove()
        mbytXPos = 0
        mbytYPos = 0
        mbooOnBoard = False
    End Sub

    Sub Draw()
        'Draw a segment
        Dim x As Short
        Dim y As Short

        If Not oBoard Is Nothing Then
            x = mbytXPos * oBoard.positionWidth
            y = (oBoard.maxY + 1 - mbytYPos) * oBoard.positionHeight
            FrmDiscon.DefInstance.segment(iSID).Left = VB6.TwipsToPixelsX(x)
            FrmDiscon.DefInstance.segment(iSID).Top = VB6.TwipsToPixelsY(y)
        End If
    End Sub

    Sub Resize()
        'Allow the segments to shrink and grow
        Dim d As Short

        If Not oBoard Is Nothing Then
            d = oBoard.positionWidth - 5
            FrmDiscon.DefInstance.segment(iSID).Width = VB6.TwipsToPixelsX(d)
            FrmDiscon.DefInstance.segment(iSID).Height = VB6.TwipsToPixelsY(d)
        End If
    End Sub

    Sub DrawOffset(ByRef i As Short)
        Const xdiv As Short = 5 'make this less to spread it out to the left more
        Const ydiv As Short = 10 'make this less to spread it out more upwards

        FrmDiscon.DefInstance.segment(iSID).Left = VB6.TwipsToPixelsX(mbytXPos * oBoard.positionWidth - i * oBoard.positionWidth / xdiv)
        FrmDiscon.DefInstance.segment(iSID).Top = VB6.TwipsToPixelsY((oBoard.maxY + 1 - mbytYPos) * oBoard.positionHeight - i * oBoard.positionHeight / ydiv)
        FrmDiscon.DefInstance.segment(iSID).SendToBack() 'send to back
    End Sub

    Sub SetBoard(ByRef aBoard As Board)
        oBoard = aBoard
    End Sub
End Class