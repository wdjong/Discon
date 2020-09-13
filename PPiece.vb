'Option Strict Off
'Option Explicit On
Imports System.Xml.Serialization 'http://www.vb-helper.com/howto_net_serialize.html

<Serializable()> _ '// https: //msdn.microsoft.com/en-us/library/et91as27(v=vs.110).aspx
Public Class PPiece

    'Private Const PPIECEWIDTH As Short = 480 'You'd think you'd work this out from the board.
    'Private Const PPIECEHEIGHT As Short = 480
    Private iPPID As Short 'Player Piece ID
    Private iOwner As Short 'player ID
    Private iXPos As Short 'horizontal position from 1 to Max (10)
    Private iYPos As Short 'horizontal position from 1 to Max (10)
    Private ReadOnly cTower As New Tower 'The tower under this piece
    Private oBoard As Board 'reference to the board for dimensions, positional & info
    'Private bDisplayed As Boolean 

    Public Sub New(aPPID As Short, maxTowerHeight As Short)
        MyBase.New()
        Init(aPPID, maxTowerHeight)
    End Sub

    'properties
    'Public Property Displayed() As Boolean
    '    Get
    '        Displayed = bDisplayed
    '    End Get
    '    Set(ByVal Value As Boolean)
    '        bDisplayed = Value
    '    End Set
    'End Property

    Public Property Score() As Short
        Get
            Score = cTower.Value
        End Get
        Set(ByVal Value As Short)
            'Won't be used normally
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
        If oBoard.OnBoard(aXDest, aYDest) Then
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

    Friend Function GetBoardRef() As Board
        GetBoardRef = oBoard
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
            DestPlayerPiece.Init(iPPID, cTower.MaxHeight) 'otherwise specifying new iXPos moves (and draws) tower
            'DestPlayerPiece.Score = iScore
            DestPlayerPiece.Owner = iOwner
            DestPlayerPiece.XPos = iXPos
            DestPlayerPiece.YPos = iYPos
            DestPlayerPiece.PPID = iPPID
            'DestPlayerPiece.Displayed = bDisplayed
            cTower.CopyTo(DestPlayerPiece.GetTowerRef)
            'DestPlayerPiece.GetTower.MaxHeight = cTower.MaxHeight' part of cTower.copyTo
            DestPlayerPiece.GetTowerRef.Move((DestPlayerPiece.XPos), (DestPlayerPiece.YPos)) ' part of cTower.copyTo
        Catch ex As Exception
            Message = ex.Message
            Debug.Print(Message) 'MsgBox("PPiece.copyTo: " & ex.Message) 'e.g. fails if passed player piece is null / nothing
        End Try
    End Sub

    Public Sub DisplayTower()
        Const xdiv As Byte = 5 'make this less to spread it out to the left more
        Const ydiv As Byte = 10 'make this less to spread it out more upwards

        cTower.Display() 'displaying the tower calls segment.drawoffset with similar settings
        FrmDiscon.DefInstance.PPiece(iPPID).Left = VB6.TwipsToPixelsX(iXPos * oBoard.PositionWidth - cTower.Height * oBoard.PositionWidth / xdiv)
        FrmDiscon.DefInstance.PPiece(iPPID).Top = VB6.TwipsToPixelsY(((oBoard.MaxY + 1) - iYPos) * oBoard.PositionHeight - cTower.Height * oBoard.PositionHeight / ydiv)
        FrmDiscon.DefInstance.PPiece(iPPID).BringToFront() 'bring to front
    End Sub

    Public Sub Draw()
        'represent player piece and it's tower...
        If iPPID <> 0 Then 'ippid = 0 when copying to ppiece object in turn
            cTower.Draw()
            FrmDiscon.DefInstance.PPiece(iPPID).Left = VB6.TwipsToPixelsX(iXPos * oBoard.PositionWidth)
            FrmDiscon.DefInstance.PPiece(iPPID).Top = VB6.TwipsToPixelsY(((oBoard.MaxY + 1) - iYPos) * oBoard.PositionHeight)
            FrmDiscon.DefInstance.PPiece(iPPID).BringToFront() 'bring to front
        End If
        Application.DoEvents()
    End Sub

    Public Function GetTowerRef() As Tower
        'I often wonder what the point of encapsulating this is...
        GetTowerRef = cTower
    End Function

    Public Function InForeignHome() As Boolean
        Dim aHome As Short 'current home

        aHome = oBoard.InHome(iXPos, iYPos)
        InForeignHome = (aHome > 0 And aHome <> iOwner)
    End Function

    Public Sub Init(aPPID As Short, maxTowerHeight As Short)
        PPID = aPPID
        Owner = Int((aPPID - 1) / 6) + 1
        Select Case Owner
            Case 1
                XPos = 1
                YPos = 1
            Case 2
                XPos = 1
                YPos = 10
            Case 3
                XPos = 10
                YPos = 10
            Case 4
                XPos = 10
                YPos = 1
            Case Else 'Something went wrong
                Message = "aPieces(" & aPPID & ").Owner = " & Owner
                XPos = 5
                YPos = 5
        End Select

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
            If oBoard.OnBoard(aXDest, aYDest) Then
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
        If oBoard.OnBoard(aXDest, aYDest) Then
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
        If oBoard.OnBoard(aXOrig, aYOrig) Then
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
            FrmDiscon.DefInstance.PPiece(iPPID).Width = VB6.TwipsToPixelsX(oBoard.PositionWidth - 5)
            FrmDiscon.DefInstance.PPiece(iPPID).Height = VB6.TwipsToPixelsY(oBoard.PositionHeight - 5)
        Catch ex As Exception
            Message = ex.Message
            Debug.Print(Message)
        End Try
    End Sub

    Public Sub SetBoardRef(ByRef aBoard As Board)
        'Just used to get dimensions
        oBoard = aBoard
    End Sub

    Public Sub UpdateTooltip()
        Try
            Dim aControl As Control = FrmDiscon.DefInstance.PPiece(iPPID) 'Player piece as determined by iPPID
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