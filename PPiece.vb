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
        Init()
    End Sub

    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub

    'properties
    Public Property Displayed() As Boolean
        Get
            Displayed = bDisplayed
        End Get
        Set(ByVal Value As Boolean)
            bDisplayed = Value
        End Set
    End Property

    Public Property Score() As Short
        Get
            iScore = cTower.Value
            Score = iScore
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
            cTower.Move(iXPos, iYPos)
            Draw()
        End Set
    End Property

    Public Property yPos() As Short
        Get
            yPos = iYPos
        End Get
        Set(ByVal Value As Short)
            iYPos = Value
            cTower.Move(iXPos, iYPos)
            Draw()
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

    'methods (Alpha)
    Function Abandon(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
        Abandon = False ' may fail
        If oBoard.onBoard(aXDest, aYDest) Then
            If LegalMove(aXDest, aYDest) Then
                iXPos = aXDest
                iYPos = aYDest
                RemoveAll() 'leave tower behind
                Abandon = True
            End If
        End If
        Draw() 'need to draw it again even if it was dropped illegally
    End Function

    Function Add(ByRef aSegment As Segment) As Boolean
        Add = cTower.Add(aSegment)
    End Function

    Sub CopyTo(ByRef aPPiece As PPiece)
        'copy from this ppiece to the passed ppiece
        Try
            aPPiece.Init() 'otherwise specifying new iXPos moves (and draws) tower
            aPPiece.xPos = iXPos
            aPPiece.yPos = iYPos
            aPPiece.owner = iOwner
            aPPiece.Score = iScore
            aPPiece.pPID = iPPID
            aPPiece.Displayed = bDisplayed
            cTower.CopyTo(aPPiece.GetTower)
            aPPiece.GetTower.Move((aPPiece.xPos), (aPPiece.yPos))
        Catch ex As Exception
            MsgBox("PPiece.copyTo: " & ex.Message) 'e.g. fails if passed player piece is null / nothing
        End Try
    End Sub

    Sub DisplayTower()
        Const xdiv As Byte = 5 'make this less to spread it out to the left more
        Const ydiv As Byte = 10 'make this less to spread it out more upwards

        cTower.Display() 'displaying the tower calls segment.drawoffset with similar settings
        frmDiscon.DefInstance.ppiece(iPPID).Left = VB6.TwipsToPixelsX(iXPos * oBoard.positionWidth - cTower.height * oBoard.positionWidth / xdiv)
        frmDiscon.DefInstance.ppiece(iPPID).Top = VB6.TwipsToPixelsY(((oBoard.maxY + 1) - iYPos) * oBoard.positionHeight - cTower.height * oBoard.positionHeight / ydiv)
        frmDiscon.DefInstance.ppiece(iPPID).BringToFront() 'bring to front
    End Sub

    Sub Draw()
        'represent player piece and it's tower...
        If iPPID <> 0 Then 'ippid = 0 when copying to ppiece object in turn
            cTower.Draw()
            frmDiscon.DefInstance.ppiece(iPPID).Left = VB6.TwipsToPixelsX(iXPos * oBoard.positionWidth)
            frmDiscon.DefInstance.ppiece(iPPID).Top = VB6.TwipsToPixelsY(((oBoard.maxY + 1) - iYPos) * oBoard.positionHeight)
            frmDiscon.DefInstance.ppiece(iPPID).BringToFront() 'bring to front
        End If
    End Sub

    Public Function GetTower() As Tower
        GetTower = cTower
    End Function

    Function InForeignHome() As Boolean
        Dim aHome As Short 'current home

        aHome = oBoard.inHome(iXPos, iYPos)
        InForeignHome = (aHome > 0 And aHome <> iOwner)
    End Function

    Sub Init()
        RemoveAll() 'from tower
        iXPos = 0
        iYPos = 0
        iOwner = 0
        iPPID = 0
        bDisplayed = False
    End Sub

    Function LegalMove(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
        LegalMove = (System.Math.Abs(iXPos - aXDest) = 1 And System.Math.Abs(iYPos - aYDest) = 2) Or (System.Math.Abs(iXPos - aXDest) = 2 And System.Math.Abs(iYPos - aYDest) = 1)
    End Function

    Function Move(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
        Move = False ' may fail
        If oBoard.onBoard(aXDest, aYDest) Then
            If LegalMove(aXDest, aYDest) Then
                iXPos = aXDest
                iYPos = aYDest
                cTower.Move(iXPos, iYPos)
                Move = True
            End If
        End If
        Draw() 'need to draw it again even if it was dropped illegally
    End Function

    Sub Remove()
        'Remove a piece from the tower
        cTower.Remove()
    End Sub

    Sub RemoveAll()
        'Called from PPieces when reinitializing.
        Dim i As Short

        For i = 1 To cTower.height
            cTower.Remove()
        Next i
    End Sub

    Sub Resize()
        'Skip errors relating to resize
        Try
            frmDiscon.DefInstance.ppiece(iPPID).Width = VB6.TwipsToPixelsX(oBoard.positionWidth - 5)
            frmDiscon.DefInstance.ppiece(iPPID).Height = VB6.TwipsToPixelsY(oBoard.positionHeight - 5)
        Catch ex As Exception
        End Try
    End Sub

    Sub SetBoard(ByRef aBoard As Board)
        oBoard = aBoard
    End Sub

    Public Sub SetTower(ByRef aTower As Tower)
        cTower = aTower
    End Sub

    Sub UpdateTooltip()
        Try
            frmDiscon.DefInstance.ToolTip1.SetToolTip(frmDiscon.DefInstance.ppiece(iPPID), cTower.height.ToString & " " & cTower.colour)
        Catch ex As Exception
            MsgBox("PPiece.updateTooltip: " & ex.Message)
        End Try
    End Sub

End Class