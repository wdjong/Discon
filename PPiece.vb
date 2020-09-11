Option Strict Off
Option Explicit On
Friend Class PPiece

    Private iXPos As Short 'horizontal position from 1 to Max (10)
    Private iYPos As Short 'horizontal position from 1 to Max (10)
    Private iOwner As Short 'player ID
    Private iScore As Short 'value of tower it's on
    Private iPPID As Short 'Player Piece ID
    Private bDisplayed As Boolean
    Private Const PPIECEWIDTH As Short = 480
    Private Const PPIECEHEIGHT As Short = 480
    Private cTower As New Tower 'a tower under this piece?
    Private oBoard As New Board 'the board (for dimensions, positional & info)

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
            'Draw()
        End Set
    End Property

    Public Property YPos() As Short
        Get
            YPos = iYPos
        End Get
        Set(ByVal Value As Short)
            iYPos = Value
            cTower.Move(iXPos, iYPos)
            'Draw()
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

    Public Function Abandon(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
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

    Public Function Add(ByRef aSegment As Segment) As Boolean
        Add = False
        If (cTower.Add(aSegment)) Then 'Note this recalculates score and updates segment vertical position
            Add = True
        Else
            Message = cTower.Message 'Pass back error
            Debug.Print(Message)
        End If
    End Function

    Public Sub CopyTo(ByRef DestPlayerPiece As PPiece)
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
            Message = ex.Message
            Debug.Print(Message) 'MsgBox("PPiece.copyTo: " & ex.Message) 'e.g. fails if passed player piece is null / nothing
        End Try
    End Sub

    Public Sub DisplayTower()
        Const xdiv As Byte = 5 'make this less to spread it out to the left more
        Const ydiv As Byte = 10 'make this less to spread it out more upwards

        cTower.Display() 'displaying the tower calls segment.drawoffset with similar settings
        FrmDiscon.DefInstance.ppiece(iPPID).Left = VB6.TwipsToPixelsX(iXPos * oBoard.positionWidth - cTower.Height * oBoard.positionWidth / xdiv)
        FrmDiscon.DefInstance.ppiece(iPPID).Top = VB6.TwipsToPixelsY(((oBoard.maxY + 1) - iYPos) * oBoard.positionHeight - cTower.Height * oBoard.positionHeight / ydiv)
        FrmDiscon.DefInstance.ppiece(iPPID).BringToFront() 'bring to front
    End Sub

    Public Sub Draw()
        'represent player piece and it's tower...
        If iPPID <> 0 Then 'ippid = 0 when copying to ppiece object in turn
            cTower.Draw()
            FrmDiscon.DefInstance.ppiece(iPPID).Left = VB6.TwipsToPixelsX(iXPos * oBoard.positionWidth)
            FrmDiscon.DefInstance.ppiece(iPPID).Top = VB6.TwipsToPixelsY(((oBoard.maxY + 1) - iYPos) * oBoard.positionHeight)
            FrmDiscon.DefInstance.ppiece(iPPID).BringToFront() 'bring to front
        End If
        Application.DoEvents()
    End Sub

    Public Function GetTower() As Tower
        'I often wonder what the point of encapsulating this is...
        GetTower = cTower
    End Function

    Public Function InForeignHome() As Boolean
        Dim aHome As Short 'current home

        aHome = oBoard.inHome(iXPos, iYPos)
        InForeignHome = (aHome > 0 And aHome <> iOwner)
    End Function

    Public Sub Init(maxTowerHeight As Short)
        iScore = 0
        iOwner = 0
        iXPos = 0
        iYPos = 0
        iPPID = 0
        bDisplayed = False
        RemoveAll() 'from tower
        cTower.MaxHeight = maxTowerHeight
    End Sub

    Public Function LegalMove(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
        LegalMove = True
        If Not (System.Math.Abs(iXPos - aXDest) = 1 And System.Math.Abs(iYPos - aYDest) = 2) Or (System.Math.Abs(iXPos - aXDest) = 2 And System.Math.Abs(iYPos - aYDest) = 1) Then
            LegalMove = True
        End If
    End Function

    Public Function Move(ByRef aXDest As Short, ByRef aYDest As Short) As Boolean
        'Checks position legality and updates Player Piece position and draws piece in new position
        Try
            Move = False ' may fail
            If oBoard.onBoard(aXDest, aYDest) Then
                If LegalMove(aXDest, aYDest) Then
                    iXPos = aXDest
                    iYPos = aYDest
                    cTower.Move(iXPos, iYPos)
                    Move = True
                End If
            End If
            'Draw() 'need to draw it again even if it was dropped illegally
        Catch ex As Exception
            Message = ex.Message
            Debug.Print(Message)
            Stop
        End Try
    End Function

    Friend Function Move(direction As Short) As Boolean
        'determine destination square from origin + direction
        '1, 1 is the bottom left and 10, 10 is the top right,
        'if routine fails, position is unchanged
        Dim aXDest As Short = iXPos
        Dim aYDest As Short = iYPos

        Move = False ' may fail
        Select Case direction
            Case 1
                aXDest += 1 'right 1 '5 o'clock
                aYDest -= 2 'down 2
            Case 2
                aXDest += 2 'right 2 '4 o'clock
                aYDest -= 1 'down 1
            Case 3
                aXDest += 2 'right 2 '2 o'clock
                aYDest += 1 'up 1
            Case 4
                aXDest += 1 'right 1 '1 o'clock
                aYDest += 2 'up 2
            Case 5
                aXDest -= 1 'left 1 '11 o'clock
                aYDest += 2 'up 2
            Case 6
                aXDest -= 2 'left 2 '10 o'clock
                aYDest += 1 'up 1
            Case 7
                aXDest -= 2 'left 2 '8 o'clock
                aYDest -= 1 'down 1 
            Case 8
                aXDest -= 1 'left 1 '7 o'clock
                aYDest -= 2 'down 2
        End Select
        If oBoard.onBoard(aXDest, aYDest) Then
            If LegalMove(aXDest, aYDest) Then
                iXPos = aXDest
                iYPos = aYDest
                cTower.Move(iXPos, iYPos)
                Move = True
            End If
        End If
        'Draw()
    End Function

    Friend Sub MoveUndo(direction As Short)
        'determine origin square from destination - direction
        '1, 1 is the bottom left and 10, 10 is the top right, 
        Dim aXOrig As Short = iXPos
        Dim aYOrig As Short = iYPos

        Select Case direction
            Case 1
                aXOrig -= 1 'back from right 1 '5 o'clock = '11 o'clock
                aYOrig += 2 'down 2
            Case 2
                aXOrig -= 2 'back from right 2 '4 o'clock = '10 o'clock
                aYOrig += 1 'down 1
            Case 3
                aXOrig -= 2 'back from right 2 '2 o'clock = '8 o'clock
                aYOrig -= 1 'up 1
            Case 4
                aXOrig -= 1 'back from right 1 '1 o'clock = '7 o'clock
                aYOrig -= 2 'up 2
            Case 5
                aXOrig += 1 'back from left 1 '11 o'clock = '5 o'clock
                aYOrig -= 2 'up 2
            Case 6
                aXOrig += 2 'back from left 2 '10 o'clock = '4 o'clock
                aYOrig -= 1 'up 1
            Case 7
                aXOrig += 2 'back from left 2 '8 o'clock = '2 o'clock
                aYOrig += 1 'down 1 
            Case 8
                aXOrig += 1 'back from left 1 '7 o'clock = '1 o'clock
                aYOrig += 2 'down 2
        End Select
        If oBoard.onBoard(aXOrig, aYOrig) Then
            iXPos = aXOrig
            iYPos = aYOrig
            cTower.Move(iXPos, iYPos) 'Move tower with player piece
        Else
            MsgBox("MoveUndo: off board")
        End If
    End Sub

    Public Sub Remove(n As Short)
        'Remove n pieces from the tower
        Dim i As Short

        For i = 1 To n
            cTower.Remove()
        Next i
        cTower.CheckColours() 'Also updates Description
        cTower.UpdateScore()
    End Sub

    Public Sub RemoveAll()
        'Called from PPieces when reinitializing and when Abandoning segments
        Dim i As Short

        For i = 1 To cTower.Height
            cTower.Remove()
        Next i
        cTower.CheckColours() 'Also updates Description
        cTower.UpdateScore()
        'UpdateTooltip() because this is ultimately called by something in a New routine starting with the New for frmDiscon it you can't do the tooltip thing here.
    End Sub

    Public Sub Resize()
        'Skip errors relating to resize
        Try
            FrmDiscon.DefInstance.ppiece(iPPID).Width = VB6.TwipsToPixelsX(oBoard.positionWidth - 5)
            FrmDiscon.DefInstance.ppiece(iPPID).Height = VB6.TwipsToPixelsY(oBoard.positionHeight - 5)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetBoard(ByRef aBoard As Board)
        oBoard = aBoard
    End Sub

    Public Sub SetTower(ByRef aTower As Tower)
        cTower = aTower
    End Sub

    Public Sub UpdateTooltip()
        Try
            Dim aControl As Control = FrmDiscon.DefInstance.ppiece(iPPID) 'Player piece as determined by iPPID
            Dim aCaption As String = Owner & "-" & PPID & ": " 'show owner and player piece id
            aCaption += cTower.Description 'as determined in cTower.CheckColor()
            aCaption += "(" & cTower.Height & ")"
            FrmDiscon.DefInstance.ToolTip1.SetToolTip(aControl, aCaption)
        Catch ex As Exception
            Message = ex.Message
            Debug.Print(Message)
        End Try
    End Sub

End Class