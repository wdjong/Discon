Option Strict Off
Option Explicit On
Friend Class Turn
	'a collection of Player objects
	Const cMAXPLAYER As Short = 4 '4 players
	Const MAXMOVE As Short = 2 '2 moves per turn
    Dim iPlayer As Short 'Current player number
    Dim oPPiece(MAXMOVE) As PPiece 'New PPiece 'copy the piece before moving it: for undo
    Dim oPPieceTo(MAXMOVE) As PPiece 'pointers to actual pieces moved
    Dim oPlayer(cMAXPLAYER) As Player 'New Player

    Public Sub New()
        'On creation of the object
        MyBase.New()
        init()
    End Sub

    Public ReadOnly Property maxPlayer() As Short
        'The maximum number of players
        Get
            maxPlayer = cMAXPLAYER
        End Get
    End Property

    Public Property move() As Short

    Public Property player() As Short
        'The current player number
        Get
            player = iPlayer
        End Get
        Set(ByVal Value As Short)
            iPlayer = Value
        End Set
    End Property

    Public ReadOnly Property score(ByVal aPlayer As Short) As Short
        Get
            score = oPlayer(aPlayer).Score()
        End Get
    End Property

    Public ReadOnly Property status(ByVal aPlayer As Short) As Short
        Get
            status = oPlayer(aPlayer).Status()
        End Get
    End Property

    Sub decMove()
        'A move has been undone
        move = move - 1
        If move = 0 Then 'it's the end of a turn
            move = MAXMOVE
            decPlayer()
        End If
    End Sub

    Sub decPlayer()
        'It's the previous person's move (undoing)
        Dim bNotFound As Boolean 'just incase there are no active players
        Dim iCountInactive As Short

        bNotFound = True
        iCountInactive = 0
        Do While bNotFound And iCountInactive <= 3
            iPlayer = iPlayer - 1 'next player
            If iPlayer <= 0 Then
                iPlayer = cMAXPLAYER
            End If
            If oPlayer(iPlayer).Status > 0 Then 'active
                bNotFound = False
            Else
                iCountInactive = iCountInactive + 1
            End If
        Loop
        If iCountInactive >= 4 Then
            MsgBox("All the players are inactive!")
            End
        End If
    End Sub

    Function getPlayer() As Player
        'return the current player's object
        getPlayer = oPlayer(iPlayer)
    End Function

    Function getPlayer(ByVal p As Short) As Player
        'return any player's object
        getPlayer = oPlayer(p)
    End Function

    Sub incMove(ByRef aPPiece As PPiece)
        'Increment the move counter
        'If its the 2nd move then check for either piece being in foreign home if they are
        'indicate error and undo both pieces.
        If move = 1 Then
            oPPieceTo(2) = Nothing
        End If
        oPPieceTo(move) = aPPiece
        If move = 2 Then
            If (oPPieceTo(1).InForeignHome Or oPPieceTo(2).InForeignHome) Then
                MsgBox("You can't end leave your pieces in someone else's home. ")
                undo()
                Exit Sub
            End If
        End If
        move = move + 1
        If move > MAXMOVE Then
            move = 1
            incPlayer()
        End If
    End Sub

    Sub incPlayer()
        'It's the next person's turn
        Dim bNotFound As Boolean
        Dim iCountInactive As Short

        bNotFound = True
        iCountInactive = 0
        Do While bNotFound And iCountInactive <= 3
            iPlayer = iPlayer + 1
            If iPlayer > cMAXPLAYER Then
                iPlayer = 1
            End If
            If oPlayer(iPlayer).Status > 0 Then
                bNotFound = False
            Else
                iCountInactive = iCountInactive + 1
            End If
        Loop
        If iCountInactive >= 4 Then
            MsgBox("All the players are inactive!")
            End
        End If
    End Sub

    Sub init()
        'Class initialization called from new()
        Dim i As Short

        move = 1
        iPlayer = 0
        For i = 1 To MAXMOVE
            oPPiece(i) = New PPiece(12)
        Next i
        For i = 1 To cMAXPLAYER
            oPlayer(i) = New Player
            oPlayer(i).ID = i
            oPlayer(i).Score = 0
            Select Case i
                Case 1
                    If My.Settings.Player1Human Then oPlayer(i).Status = 1 Else oPlayer(i).Status = 0
                Case 2
                    If My.Settings.Player2Human Then oPlayer(i).Status = 1 Else oPlayer(i).Status = 0
                Case 3
                    If My.Settings.Player3Human Then oPlayer(i).Status = 1 Else oPlayer(i).Status = 0
                Case 4
                    If My.Settings.Player4Human Then oPlayer(i).Status = 1 Else oPlayer(i).Status = 0
            End Select
            oPlayer(i).Name = "Player " & i
        Next i

    End Sub

    Sub rndPlayer()
        'Choose someone to start
        Randomize(Now.Ticks)
        iPlayer = Int(Rnd() * cMAXPLAYER) + 1
        incPlayer()
    End Sub

    Sub saveSource(ByRef aPPiece As PPiece)
        'Copy the piece as it was before being moved
        If move = 1 Then
            oPPiece(2).Init(12) 'clear the 2nd piece info in the turn history
        End If
        aPPiece.CopyTo(oPPiece(move))
    End Sub

    Sub undo()
        Dim oldValue As Short 'each move, find change in score and add it to player score
        Dim newValue As Short 'scoring

        'Undo Turn i.e. possibly 2 moves            
        If oPPiece(2).XPos <> 0 And Not oPPieceTo(2) Is Nothing Then 'there is a second move to undo
            oldValue = oPPieceTo(2).Score 'remember the current score
            oPPiece(2).CopyTo(oPPieceTo(2)) 'copy the old information back to the piece that moved. aPPieces.getPiece(oPPiece(2).pPID)
            oPPieceTo(2).Draw() 'aPPieces.getPiece(oPPiece(2).pPID).draw
            newValue = oPPieceTo(2).Score
            oPPieceTo(2).UpdateTooltip() 'to display colour and height
            oPlayer(iPlayer).Score = oPlayer(iPlayer).Score - oldValue + newValue 'aPlayer.GetScore could just sum all piece scores
        End If
        If oPPiece(1).XPos <> 0 Then 'there is a first move to undo
            oldValue = oPPieceTo(1).Score 'remember the current score
            oPPiece(1).CopyTo(oPPieceTo(1)) 'aPPieces.getPiece(oPPiece(1).pPID)
            oPPieceTo(1).Draw() 'aPPieces.getPiece(oPPiece(1).pPID).draw
            newValue = oPPieceTo(1).Score
            oPPieceTo(1).UpdateTooltip() 'to display colour and height
            oPlayer(iPlayer).Score = oPlayer(iPlayer).Score - oldValue + newValue 'aPlayer.GetScore could just sum all piece scores
        End If
        move = 1
    End Sub


End Class