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
    Public cTower As New Tower 'a tower under this piece?
    Dim oBoard As Board 'the board (for dimensions, positional & info)

    Public Sub New(maxTowerHeight As Short)
        MyBase.New()
        Init(maxTowerHeight)
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

    Public Property Owner() As Short
        Get
            Owner = iOwner
        End Get
        Set(ByVal Value As Short)
            iOwner = Value
        End Set
    End Property

    Public Property XPos() As Short
        Get
            XPos = iXPos
        End Get
        Set(ByVal Value As Short)
            iXPos = Value
            cTower.Move(iXPos, iYPos)
            Draw()
        End Set
    End Property

    Public Property YPos() As Short
        Get
            YPos = iYPos
        End Get
        Set(ByVal Value As Short)
            iYPos = Value
            cTower.Move(iXPos, iYPos)
            Draw()
        End Set
    End Property

    Public Property PPID() As Short
        Get
            PPID = iPPID
        End Get
        Set(ByVal Value As Short)
            iPPID = Value
        End Set
    End Property

    Public Property Message() As String

    'Public Property MaxTowerHeight() As Short 'This is something the player needs to know
    '    Get
    '        MaxTowerHeight = cTower.MaxHeight
    '    End Get
    '    Set(ByVal Value As Short)
    '        cTower.MaxHeight = Value
    '    End Set
    'End Property

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
        cTower.CheckColours() 'Updates description used in Tooltip
        Draw() 'need to draw it again even if it was dropped illegally
    End Function

    Function Add(ByRef aSegment As Segment) As Boolean
        Add = False
        If (cTower.Add(aSegment)) Then 'Note this recalculates score and updates segment vertical position
            Add = True
        Else
            Message = cTower.Message 'Pass back error
        End If
    End Function

    Sub CopyTo(ByRef DestPlayerPiece As PPiece)
        'copy from this ppiece to the passed ppiece
        Try
            DestPlayerPiece.Init(cTower.MaxHeight) 'otherwise specifying new iXPos moves (and draws) tower
            DestPlayerPiece.Score = iScore
            DestPlayerPiece.Owner = iOwner
            DestPlayerPiece.XPos = iXPos
            DestPlayerPiece.YPos = iYPos
            DestPlayerPiece.PPID = iPPID
            DestPlayerPiece.Displayed = bDisplayed
            cTower.CopyTo(DestPlayerPiece.GetTower)
            DestPlayerPiece.GetTower.MaxHeight = cTower.MaxHeight
            DestPlayerPiece.GetTower.Move((DestPlayerPiece.XPos), (DestPlayerPiece.YPos))
        Catch ex As Exception
            MsgBox("PPiece.copyTo: " & ex.Message) 'e.g. fails if passed player piece is null / nothing
        End Try
    End Sub
    Sub DisplayTower()
        Const xdiv As Byte = 5 'make this less to spread it out to the left more
        Const ydiv As Byte = 10 'make this less to spread it out more upwards

        cTower.Display() 'displaying the tower calls segment.drawoffset with similar settings
        frmDiscon.DefInstance.ppiece(iPPID).Left = VB6.TwipsToPixelsX(iXPos * oBoard.positionWidth - cTower.Height * oBoard.positionWidth / xdiv)
        frmDiscon.DefInstance.ppiece(iPPID).Top = VB6.TwipsToPixelsY(((oBoard.maxY + 1) - iYPos) * oBoard.positionHeight - cTower.Height * oBoard.positionHeight / ydiv)
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
        'I often wonder what the point of encapsulating this is...
        GetTower = cTower
    End Function

    Function InForeignHome() As Boolean
        Dim aHome As Short 'current home

        aHome = oBoard.inHome(iXPos, iYPos)
        InForeignHome = (aHome > 0 And aHome <> iOwner)
    End Function

    Sub Init(maxTowerHeight As Short)
        iScore = 0
        iOwner = 0
        iXPos = 0
        iYPos = 0
        iPPID = 0
        bDisplayed = False
        RemoveAll() 'from tower
        cTower.MaxHeight = maxTowerHeight
    End Sub

    Function LegalMove(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
        LegalMove = (System.Math.Abs(iXPos - aXDest) = 1 And System.Math.Abs(iYPos - aYDest) = 2) Or (System.Math.Abs(iXPos - aXDest) = 2 And System.Math.Abs(iYPos - aYDest) = 1)
    End Function

    Function Move(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
        'Checks position legality and updates Player Piece position and draws piece in new position
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
        'Called from PPieces when reinitializing and when Abandoning segments
        Dim i As Short

        For i = 1 To cTower.Height
            cTower.Remove()
        Next i
        cTower.CheckColours() 'Also updates Description
        cTower.UpdateScore()
        'UpdateTooltip() because this is ultimately called by something in a New routine starting with the New for frmDiscon it you can't do the tooltip thing here.
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
            Dim aControl As Control = frmDiscon.DefInstance.ppiece(iPPID) 'Player piece as determined by iPPID
            Dim aCaption As String = Owner & "-" & PPID & ": " 'show owner and player piece id
            aCaption += cTower.Description 'as determined in cTower.CheckColor()
            aCaption += "(" & cTower.Height & ")"
            frmDiscon.DefInstance.ToolTip1.SetToolTip(aControl, aCaption)
        Catch ex As Exception
            'MsgBox("PPiece.updateTooltip: " & ex.Message)
        End Try
    End Sub

End Class