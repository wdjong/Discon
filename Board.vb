Option Strict Off
Option Explicit On
Friend Class Board
    'Bottom left of board is x=1, y=1
    Dim iBoardTop As Short '0
    Dim iBoardLeft As Short '0
    Dim iPositionWidth As Short '480 both piece and square
    Dim iPositionHeight As Short '480
    Const IMAXX As Short = 10
    Const IMAXY As Short = 10
    Dim iBoardBottom As Short 'BOARDBOTTOM = (MaxY + 1) * PIECEHEIGHT
    Const PIECEID As Short = 0
    Const PIECETEAM As Short = 1
    Dim gBoard(IMAXX, IMAXY, 2) As Short 'original:
    Dim gBoard2(IMAXX, IMAXY, 2) As Short 'copy:

    'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
    Private Sub Class_Initialize_Renamed()
        Dim x As Short
        Dim y As Short

        iBoardTop = 0
        iBoardLeft = 0
        iPositionWidth = 500 'both piece and square
        iPositionHeight = 500
        iBoardBottom = (IMAXY + 1) * iPositionHeight
        For x = 1 To IMAXX
            For y = 1 To IMAXY
                gBoard(x, y, PIECEID) = 0
                gBoard(x, y, PIECETEAM) = 0
            Next y
        Next x
        'draw()
    End Sub

    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub

    Public ReadOnly Property maxX() As Object
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object maxX. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            maxX = IMAXX
        End Get
    End Property

    Public ReadOnly Property maxY() As Object
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object maxY. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            maxY = IMAXY
        End Get
    End Property

    Public Property positionWidth() As Object
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object positionWidth. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            positionWidth = iPositionWidth
        End Get
        Set(ByVal Value As Object)
            'UPGRADE_WARNING: Couldn't resolve default property of object vNewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            iPositionWidth = Value
        End Set
    End Property

    Public Property positionHeight() As Object
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object positionHeight. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            positionHeight = iPositionHeight
        End Get
        Set(ByVal Value As Object)
            'UPGRADE_WARNING: Couldn't resolve default property of object vNewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            iPositionHeight = Value
        End Set
    End Property

    Public Sub setGBoard(ByRef x As Short, ByRef y As Short, ByRef OID As Short, ByRef d As Short)
        'the unique ID of each piece on is stored in an array
        'to indicate the position on the board
        gBoard(x, y, PIECEID) = OID 'object identifier
        gBoard(x, y, PIECETEAM) = d 'direction
    End Sub

    Public Sub copy()
        Dim x As Short
        Dim y As Short

        For x = 1 To IMAXX
            For y = 1 To IMAXY
                gBoard2(x, y, PIECEID) = gBoard(x, y, PIECEID)
                gBoard2(x, y, PIECETEAM) = gBoard(x, y, PIECETEAM)
            Next y
        Next x
    End Sub

    Public Sub restore()
        Dim x As Short
        Dim y As Short

        For x = 1 To IMAXX
            For y = 1 To IMAXY
                gBoard(x, y, PIECEID) = gBoard2(x, y, PIECEID)
                gBoard(x, y, PIECETEAM) = gBoard2(x, y, PIECETEAM)
            Next y
        Next x
    End Sub

    Public Function getGBoardID(ByRef x As Short, ByRef y As Short) As Short
        getGBoardID = gBoard(x, y, PIECEID) 'id of piece
    End Function

    Public Sub setGBoardID(ByRef x As Short, ByRef y As Short, ByRef i As Short)
        gBoard(x, y, PIECEID) = i 'id of piece
    End Sub

    Public Function getGBoardDir(ByRef x As Short, ByRef y As Short) As Short
        getGBoardDir = gBoard(x, y, PIECETEAM) 'direction of piece
    End Function

    Public Sub setGBoardDir(ByRef x As Short, ByRef y As Short, ByRef d As Short)
        gBoard(x, y, PIECETEAM) = d 'direction
    End Sub

    Public Function getXPosFromMouse(ByVal x As Integer) As Shortcut
        'Determine the board position give a mouse X position
        'Left of board is 1
        getXPosFromMouse = (VB6.PixelsToTwipsX(x) / iPositionWidth)
    End Function

    Public Function getYPosFromMouse(ByVal y As Integer) As Shortcut
        'Determine the board position give a mouse Y position
        getYPosFromMouse = 11 - (VB6.PixelsToTwipsY(y) / iPositionWidth)
    End Function

    Sub draw(ByVal e As System.Drawing.Graphics)
        Dim myBrush As New System.Drawing.SolidBrush(System.Drawing.Color.Gray)
        Dim PWidth As Integer
        Dim PHeight As Integer

        PWidth = VB6.TwipsToPixelsX(iPositionWidth)
        PHeight = VB6.TwipsToPixelsY(iPositionHeight)
        'frmDiscon.Cls()
        Debug.WriteLine(e.ClipBounds.Height)

        'the heights and widths seem mixed up but I'm staying with what was there...
        myBrush.Color = System.Drawing.Color.DarkGray
        e.FillRectangle(myBrush, PHeight, PWidth, PHeight * maxX, PWidth * maxY)
        'frmDiscon.Line (iPositionHeight, iPositionWidth) - (iPositionHeight * (maxX + 1), iPositionWidth * (IMAXY + 1)), colourMain, BF
        myBrush.Color = System.Drawing.Color.LightSlateGray
        e.FillRectangle(myBrush, PHeight, PWidth, PHeight * 3, PWidth * 3)
        'frmDiscon.Line (iPositionHeight, iPositionWidth) - (iPositionHeight * 4, iPositionWidth * 4), colourHome, BF
        myBrush.Color = System.Drawing.Color.LightSlateGray
        e.FillRectangle(myBrush, PHeight * 8, PWidth, PHeight * 3, PWidth * 3)
        'frmDiscon.Line (iPositionHeight * 8, iPositionWidth) - (iPositionHeight * 11, iPositionWidth * 4), colourHome, BF
        myBrush.Color = System.Drawing.Color.LightSlateGray
        e.FillRectangle(myBrush, PHeight, PWidth * 8, PHeight * 3, PWidth * 3)
        'frmDiscon.Line (iPositionHeight, iPositionWidth * 8) - (iPositionHeight * 4, iPositionWidth * 11), colourHome, BF
        myBrush.Color = System.Drawing.Color.LightSlateGray
        e.FillRectangle(myBrush, PHeight * 8, PWidth * 8, PHeight * 3, PWidth * 3)
        'frmDiscon.Line (iPositionHeight * 8, iPositionWidth * 8) - (iPositionHeight * 11, iPositionWidth * 11), colourHome, BF
    End Sub

    Sub debugPrint()
        Dim x As Short
        Dim y As Short
        Dim i As Short

        For y = 1 To IMAXY
            For x = 1 To IMAXX
                i = gBoard(x, IMAXY + 1 - y, PIECEID) 'draw starting at top left
                If i > 0 Then
                    If gBoard(x, IMAXY + 1 - y, PIECETEAM) = -1 Then
                        System.Diagnostics.Debug.Write("-")
                    Else
                        System.Diagnostics.Debug.Write(" ")
                    End If
                    System.Diagnostics.Debug.Write(VB6.Format(i, "00 "))
                End If
            Next x
            System.Diagnostics.Debug.WriteLine("")
        Next y
    End Sub

    Function inHome(ByRef x As Short, ByRef y As Short) As Short
        'If in home, returns the number of the home's owner
        'Else returns 0
        inHome = 0
        If x < 4 And y < 4 Then inHome = 1
        If x < 4 And y > 7 Then inHome = 2
        If x > 7 And y > 7 Then inHome = 3
        If x > 7 And y < 4 Then inHome = 4
    End Function

    Function onBoard(ByRef x As Short, ByRef y As Short) As Boolean
        onBoard = (x >= 1 And x <= IMAXX And y >= 1 And y <= IMAXY)
    End Function

    Function xFromCoord(ByRef x As Short) As Short
        'Return board X position from mouse x coordinate
        xFromCoord = Int(x / iPositionWidth)
    End Function

    Function yFromCoord(ByRef y As Short) As Short
        'y = 1 is the bottom of the board
        yFromCoord = IMAXY + 1 - Int(y / iPositionHeight)
    End Function
End Class