Option Strict Off
Option Explicit On
Friend Class PPiece
	
	Dim iXPos As Short 'horizontal position from 1 to Max (10)
	Dim iYPos As Short 'horizontal position from 1 to Max (10)
    Dim iOwner As Short 'player ID
	Dim iScore As Short 'value of tower it's on
	Dim iPPID As Short 'Player Piece ID
	Dim bDisplayed As Boolean
	Const PPIECEWIDTH As Short = 480
	Const PPIECEHEIGHT As Short = 480
    Dim cTower As New Tower 'a tower under this piece?
    Dim oBoard As Board 'the board (for dimensions, positional & info)

    Private Sub Class_Initialize_Renamed()
        init()
    End Sub

    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub

    'properties
    Public Property displayed() As Boolean
        Get
            displayed = bDisplayed
        End Get
        Set(ByVal Value As Boolean)
            bDisplayed = Value
        End Set
    End Property

    Public Property score() As Short
        Get
            iScore = cTower.Value
            score = iScore
        End Get
        Set(ByVal Value As Short)
            'Won't be used normally
            iScore = Value
            cTower.Value = Value
        End Set
    End Property

    Public Property owner() As Short
        Get
            owner = iOwner
        End Get
        Set(ByVal Value As Short)
            iOwner = Value
        End Set
    End Property

    Public Property xPos() As Short
        Get
            xPos = iXPos
        End Get
        Set(ByVal Value As Short)
            iXPos = Value
            cTower.move(iXPos, iYPos)
            draw()
        End Set
    End Property

    Public Property yPos() As Short
        Get
            yPos = iYPos
        End Get
        Set(ByVal Value As Short)
            iYPos = Value
            cTower.move(iXPos, iYPos)
            draw()
        End Set
    End Property

    Public Property pPID() As Short
        Get
            pPID = iPPID
        End Get
        Set(ByVal Value As Short)
            iPPID = Value
        End Set
    End Property

    'methods
    Function abandon(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
        abandon = False ' may fail
        If oBoard.onBoard(aXDest, aYDest) Then
            If legalMove(aXDest, aYDest) Then
                iXPos = aXDest
                iYPos = aYDest
                removeAll() 'leave tower behind
                abandon = True
            End If
        End If
        draw() 'need to draw it again even if it was dropped illegally
    End Function

    Function add(ByRef aSegment As Segment) As Boolean
        add = cTower.add(aSegment)
    End Function

    Sub copyTo(ByRef aPPiece As PPiece)
        'copy from this ppiece to the passed ppiece
        Try
            aPPiece.init() 'otherwise specifying new iXPos moves (and draws) tower
            aPPiece.xPos = iXPos
            aPPiece.yPos = iYPos
            aPPiece.owner = iOwner
            aPPiece.score = iScore
            aPPiece.pPID = iPPID
            aPPiece.displayed = bDisplayed
            cTower.copyTo(aPPiece.getTower)
            aPPiece.getTower.move((aPPiece.xPos), (aPPiece.yPos))
        Catch ex As Exception
            MsgBox("PPiece.copyTo: " & ex.Message) 'e.g. fails if passed player piece is null / nothing
        End Try
    End Sub

    Sub displayTower()
        Const xdiv As Byte = 5 'make this less to spread it out to the left more
        Const ydiv As Byte = 10 'make this less to spread it out more upwards

        cTower.display() 'displaying the tower calls segment.drawoffset with similar settings
        frmDiscon.DefInstance.ppiece(iPPID).Left = VB6.TwipsToPixelsX(iXPos * oBoard.positionWidth - cTower.height * oBoard.positionWidth / xdiv)
        frmDiscon.DefInstance.ppiece(iPPID).Top = VB6.TwipsToPixelsY(((oBoard.maxY + 1) - iYPos) * oBoard.positionHeight - cTower.height * oBoard.positionHeight / ydiv)
        frmDiscon.DefInstance.ppiece(iPPID).BringToFront() 'bring to front
    End Sub

    Sub draw()
        'represent player piece and it's tower...
        If iPPID <> 0 Then 'ippid = 0 when copying to ppiece object in turn
            cTower.draw()
            frmDiscon.DefInstance.ppiece(iPPID).Left = VB6.TwipsToPixelsX(iXPos * oBoard.positionWidth)
            frmDiscon.DefInstance.ppiece(iPPID).Top = VB6.TwipsToPixelsY(((oBoard.maxY + 1) - iYPos) * oBoard.positionHeight)
            frmDiscon.DefInstance.ppiece(iPPID).BringToFront() 'bring to front
        End If
    End Sub

    Sub updateTooltip()
        Try
            frmDiscon.DefInstance.ToolTip1.SetToolTip(frmDiscon.DefInstance.ppiece(iPPID), cTower.height.ToString & " " & cTower.colour)
        Catch ex As Exception
            MsgBox("PPiece.updateTooltip: " & ex.Message)
        End Try
    End Sub

    Sub resize()
        'Skip errors relating to resize
        Try
            frmDiscon.DefInstance.ppiece(iPPID).Width = VB6.TwipsToPixelsX(oBoard.positionWidth - 5)
            frmDiscon.DefInstance.ppiece(iPPID).Height = VB6.TwipsToPixelsY(oBoard.positionHeight - 5)
        Catch ex As Exception
        End Try
    End Sub

    Public Function getTower() As Tower
        getTower = cTower
    End Function

    Function inForeignHome() As Boolean
        Dim aHome As Short 'current home

        aHome = oBoard.inHome(iXPos, iYPos)
        inForeignHome = (aHome > 0 And aHome <> iOwner)
    End Function

    Sub init()
        removeAll() 'from tower
        iXPos = 0
        iYPos = 0
        iOwner = 0
        iPPID = 0
        bDisplayed = False
    End Sub

    Function legalMove(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
        legalMove = (System.Math.Abs(iXPos - aXDest) = 1 And System.Math.Abs(iYPos - aYDest) = 2) Or (System.Math.Abs(iXPos - aXDest) = 2 And System.Math.Abs(iYPos - aYDest) = 1)
    End Function

    Function move(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
        move = False ' may fail
        If oBoard.onBoard(aXDest, aYDest) Then
            If legalMove(aXDest, aYDest) Then
                iXPos = aXDest
                iYPos = aYDest
                cTower.move(iXPos, iYPos)
                move = True
            End If
        End If
        draw() 'need to draw it again even if it was dropped illegally
    End Function

    Sub remove()
        'Remove a piece from the tower
        cTower.remove()
    End Sub

    Sub removeAll()
        'Called from PPieces when reinitializing.
        Dim i As Short

        For i = 1 To cTower.height
            cTower.remove()
        Next i
    End Sub

    Sub setBoard(ByRef aBoard As Board)
        oBoard = aBoard
    End Sub

    Public Sub setTower(ByRef aTower As Tower)
        cTower = aTower
    End Sub
End Class