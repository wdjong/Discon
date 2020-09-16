'Option Strict Off
'Option Explicit On
Imports System.Xml.Serialization 'http://www.vb-helper.com/howto_net_serialize.html

<Serializable()> _ '// https: //msdn.microsoft.com/en-us/library/et91as27(v=vs.110).aspx
Public Class Board
    'Bottom left of board is x=1, y=1
    Dim iBoardTop As Short 'see init
    Dim iBoardLeft As Short
    Dim iPositionWidth As Short
    Dim iPositionHeight As Short
    Const IMAXX As Short = 10
    Const IMAXY As Short = 10
    Const IDEFAULTWIDTH As Short = 520
    Const IDEFAULTHEIGHT As Short = 520
    Dim iBoardBottom As Short
    Const PIECEID As Short = 0
    Const PIECETEAM As Short = 1
    'Private ReadOnly gBoard(IMAXX, IMAXY, 2) As Short 'original:
    'Private ReadOnly gBoard2(IMAXX, IMAXY, 2) As Short 'copy:

    'Constructor

    Public Sub New()
        MyBase.New()
        Init()
    End Sub

    'Properties
    Public Property BoardBottom As Short
        Get
            BoardBottom = iBoardBottom
        End Get
        Set(ByVal value As Short)
            iBoardBottom = value
        End Set
    End Property

    Public Property BoardLeft As Short
        Get
            BoardBottom = iBoardBottom
        End Get
        Set(ByVal value As Short)
            iBoardBottom = value
        End Set
    End Property

    Public Property BoardTop As Short
        Get
            BoardTop = iBoardTop
        End Get
        Set(ByVal value As Short)
            iBoardTop = value
        End Set
    End Property

    Public ReadOnly Property MaxX() As Object
        Get
            MaxX = IMAXX
        End Get
    End Property

    Public ReadOnly Property MaxY() As Object
        Get
            MaxY = IMAXY
        End Get
    End Property

    Public Property PositionWidth() As Object
        Get
            PositionWidth = iPositionWidth
        End Get
        Set(ByVal Value As Object)
            iPositionWidth = Value
        End Set
    End Property

    Public Property PositionHeight() As Object
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object positionHeight. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            PositionHeight = iPositionHeight
        End Get
        Set(ByVal Value As Object)
            'UPGRADE_WARNING: Couldn't resolve default property of object vNewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            iPositionHeight = Value
        End Set
    End Property

    'Methods
    Friend Sub CopyTo(DestBoard As Board)
        'Copy piece objects to Destination PPiece collection
        DestBoard.BoardTop = BoardTop
        DestBoard.BoardLeft = BoardLeft
        DestBoard.PositionWidth = PositionWidth 'both piece and square
        DestBoard.PositionHeight = PositionHeight
        DestBoard.BoardBottom = BoardBottom
    End Sub

    Sub Draw(ByVal e As System.Drawing.Graphics)
        Dim myBrush As New SolidBrush(Color.Gray)
        Dim myPen As New Pen(Color.AntiqueWhite, 1)
        Dim PWidth As Integer
        Dim PHeight As Integer
        Dim HomeSquares As Short = 3
        Dim x As Short
        Dim y As Short

        PWidth = VB6.TwipsToPixelsX(iPositionWidth)
        PHeight = VB6.TwipsToPixelsY(iPositionHeight)

        myBrush.Color = Color.DarkGray 'Main board
        e.FillRectangle(myBrush, PHeight, PWidth, PHeight * MaxY, PWidth * MaxX)
        myBrush.Color = Color.LightSlateGray
        e.FillRectangle(myBrush, PHeight, PWidth, PHeight * HomeSquares, PWidth * HomeSquares) 'Home 2
        e.FillRectangle(myBrush, PHeight * (MaxY + 1 - HomeSquares), PWidth, PHeight * HomeSquares, PWidth * HomeSquares) 'Home 3
        e.FillRectangle(myBrush, PHeight, PWidth * (MaxX + 1 - HomeSquares), PHeight * HomeSquares, PWidth * HomeSquares) 'Home 1
        e.FillRectangle(myBrush, PHeight * (MaxY + 1 - HomeSquares), PWidth * (MaxX + 1 - HomeSquares), PHeight * HomeSquares, PWidth * HomeSquares) 'Home 4
        For x = 1 To MaxX
            For y = 1 To MaxY
                e.DrawRectangle(myPen, x * PWidth, y * PHeight, PWidth, PHeight)
            Next
        Next
    End Sub

    Public Function GetXPosFromMouse(ByVal x As Integer) As Shortcut
        'Determine the board position give a mouse X position
        'Left of board is 1
        GetXPosFromMouse = (VB6.PixelsToTwipsX(x) / iPositionWidth)
    End Function

    Public Function GetYPosFromMouse(ByVal y As Integer) As Shortcut
        'Determine the board position give a mouse Y position
        GetYPosFromMouse = 11 - (VB6.PixelsToTwipsY(y) / iPositionWidth)
    End Function

    Private Sub Init()
        'Dim x As Short
        'Dim y As Short

        iBoardTop = 0
        iBoardLeft = 0
        iPositionWidth = IDEFAULTWIDTH
        'both piece and square
        iPositionHeight = IDEFAULTHEIGHT
        iBoardBottom = (IMAXY + 1) * iPositionHeight
        'For x = 1 To IMAXX
        '    For y = 1 To IMAXY
        '        gBoard(x, y, PIECEID) = 0
        '        gBoard(x, y, PIECETEAM) = 0
        '    Next y
        'Next x
    End Sub

    Function InHome(ByRef x As Short, ByRef y As Short) As Short
        'If in home, returns the number of the home's owner
        'Else returns 0
        InHome = 0
        If x < 4 And y < 4 Then InHome = 1
        If x < 4 And y > 7 Then InHome = 2
        If x > 7 And y > 7 Then InHome = 3
        If x > 7 And y < 4 Then InHome = 4
    End Function

    Function OnBoard(ByRef x As Short, ByRef y As Short) As Boolean
        OnBoard = (x >= 1 And x <= IMAXX And y >= 1 And y <= IMAXY)
    End Function

    Function XFromCoOrd(ByRef x As Short) As Short
        'Return board X position from mouse x coordinate
        XFromCoOrd = Int(x / iPositionWidth)
    End Function

    Function YFromCoOrd(ByRef y As Short) As Short
        'y = 1 is the bottom of the board
        YFromCoOrd = IMAXY + 1 - Int(y / iPositionHeight)
    End Function

    Friend Sub Draw()
        Throw New NotImplementedException()
    End Sub

    'Public Sub setGBoard(ByRef x As Short, ByRef y As Short, ByRef OID As Short, ByRef d As Short)
    '    'the unique ID of each piece on is stored in an array
    '    'to indicate the position on the board
    '    gBoard(x, y, PIECEID) = OID 'object identifier
    '    gBoard(x, y, PIECETEAM) = d 'direction
    'End Sub

    'Public Sub copy()
    '    Dim x As Short
    '    Dim y As Short

    '    For x = 1 To IMAXX
    '        For y = 1 To IMAXY
    '            gBoard2(x, y, PIECEID) = gBoard(x, y, PIECEID)
    '            gBoard2(x, y, PIECETEAM) = gBoard(x, y, PIECETEAM)
    '        Next y
    '    Next x
    'End Sub

    'Public Sub restore()
    '    Dim x As Short
    '    Dim y As Short

    '    For x = 1 To IMAXX
    '        For y = 1 To IMAXY
    '            gBoard(x, y, PIECEID) = gBoard2(x, y, PIECEID)
    '            gBoard(x, y, PIECETEAM) = gBoard2(x, y, PIECETEAM)
    '        Next y
    '    Next x
    'End Sub

    'Public Function getGBoardID(ByRef x As Short, ByRef y As Short) As Short
    '    getGBoardID = gBoard(x, y, PIECEID) 'id of piece
    'End Function

    'Public Sub setGBoardID(ByRef x As Short, ByRef y As Short, ByRef i As Short)
    '    gBoard(x, y, PIECEID) = i 'id of piece
    'End Sub

    'Public Function getGBoardDir(ByRef x As Short, ByRef y As Short) As Short
    '    getGBoardDir = gBoard(x, y, PIECETEAM) 'direction of piece
    'End Function

    'Public Sub setGBoardDir(ByRef x As Short, ByRef y As Short, ByRef d As Short)
    '    gBoard(x, y, PIECETEAM) = d 'direction
    'End Sub

    'Sub debugPrint()
    '    Dim x As Short
    '    Dim y As Short
    '    Dim i As Short

    '    For y = 1 To IMAXY
    '        For x = 1 To IMAXX
    '            i = gBoard(x, IMAXY + 1 - y, PIECEID) 'draw starting at top left
    '            If i > 0 Then
    '                If gBoard(x, IMAXY + 1 - y, PIECETEAM) = -1 Then
    '                    Debug.Write("-")
    '                Else
    '                    Debug.Write(" ")
    '                End If
    '                Debug.Write(VB6.Format(i, "00 "))
    '            End If
    '        Next x
    '        Debug.WriteLine("")
    '    Next y
    'End Sub
End Class