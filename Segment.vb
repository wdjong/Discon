'Option Strict Off
'Option Explicit On
Imports System.Xml.Serialization 'http://www.vb-helper.com/howto_net_serialize.html

<Serializable()> _ '// https: //msdn.microsoft.com/en-us/library/et91as27(v=vs.110).aspx
Public Class Segment
    'a Segment is a disc that can become part of a tower when captured by a piece
    Private iColour As Short '1 White, 2 Pink, 3 Blue, 4 Purple
    Private iSID As Short 'ID of piece should match array index of piece objects and controls on the form
    'Private mbooOnBoard As Boolean 'If the piece is currently in play
    'Private mbytValue As Short 'value of piece
    Private mXPos As Short 'position on board
    Private mYPos As Short 'position on 
    Private oBoard As Board 'This is just a reference to the one board for easy access to dimensions etc.

    Public Sub New()
        MyBase.New()
    End Sub

    Public Property Claimed() As Boolean

    Public Property VerticalPos() As Short 'When towers are left without a piece you need a way to add them back in the right order 1 is lowers (on the board), 2 is on top of that etc 


    Public Property Colour() As Short
        Get
            Colour = iColour
        End Get
        Set(ByVal Value As Short)
            iColour = Value
        End Set
    End Property

    Public Property SID() As Short
        Get
            SID = iSID
        End Get
        Set(ByVal Value As Short)
            iSID = Value
        End Set
    End Property

    Public ReadOnly Property OnBoard() As Boolean
        Get
            OnBoard = oBoard.OnBoard(XPos, YPos) 'See oBoard.onBoard(mbytXPos, mbytYPos)
        End Get
    End Property

    'Public Property Value() As Short
    '    Get
    '        Value = mbytValue
    '    End Get
    '    Set(ByVal aValue As Short)
    '        mbytValue = aValue
    '    End Set
    'End Property

    Public Property XPos() As Short
        Get
            XPos = mXPos
        End Get
        Set(ByVal Value As Short)
            mXPos = Value
        End Set
    End Property

    Public Property YPos() As Short
        Get
            YPos = mYPos
        End Get
        Set(ByVal Value As Short)
            mYPos = Value
        End Set
    End Property

    'Methods
    Friend Sub CopyTo(DestSegment As Segment)
        DestSegment.Colour = Colour
        DestSegment.SID = SID
        DestSegment.XPos = XPos
        DestSegment.YPos = YPos
        DestSegment.SetBoardRef(oBoard)
    End Sub

    Public Sub Move(ByRef x As Short, ByRef y As Short)
        mXPos = x 'set new SEG xpos
        mYPos = y 'set new SEG ypos
    End Sub

    Public Sub Remove()
        mXPos = 0
        mYPos = 0
    End Sub

    Sub UpdateControlPosition()
        'Draw a segment
        Dim x As Short
        Dim y As Short

        'If iSID = 12 And mXPos = 1 And mYPos = 1 Then Stop
        'Debug.Print(iSID & " " & mXPos & ", " & mYPos)
        If Not oBoard Is Nothing Then
            x = mXPos * (oBoard.PositionWidth + 5)
            y = (oBoard.MaxY + 1 - mYPos) * (oBoard.PositionHeight + 5)
            FrmDiscon.DefInstance.Segment(iSID).Left = VB6.TwipsToPixelsX(x) + 1
            FrmDiscon.DefInstance.Segment(iSID).Top = VB6.TwipsToPixelsY(y) + 1
        End If
    End Sub

    Sub Resize()
        'Allow the segments to shrink and grow
        Dim d As Short 'dimension of piece width and height in twips

        If Not oBoard Is Nothing Then
            d = oBoard.PositionWidth - 5
            FrmDiscon.DefInstance.Segment(iSID).Width = VB6.TwipsToPixelsX(d)
            FrmDiscon.DefInstance.Segment(iSID).Height = VB6.TwipsToPixelsY(d)
        End If
    End Sub

    Sub DrawOffset(ByRef i As Short)
        Const xdiv As Short = 5 'make this less to spread it out to the left more
        Const ydiv As Short = 10 'make this less to spread it out more upwards

        FrmDiscon.DefInstance.Segment(iSID).Left = VB6.TwipsToPixelsX(mXPos * oBoard.PositionWidth - i * oBoard.PositionWidth / xdiv)
        FrmDiscon.DefInstance.Segment(iSID).Top = VB6.TwipsToPixelsY((oBoard.MaxY + 1 - mYPos) * oBoard.PositionHeight - i * oBoard.PositionHeight / ydiv)
        FrmDiscon.DefInstance.Segment(iSID).SendToBack() 'send to back
    End Sub

    Sub SetBoardRef(ByRef aBoard As Board) 'Normally we copy the object but here we just store a reference...? it's a bit inconsistent
        oBoard = aBoard
    End Sub
End Class