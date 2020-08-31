Option Strict Off
Option Explicit On
Friend Class Turn
	'a collection of Player objects
	Const cMAXPLAYER As Short = 4 '4 players
	Const MAXMOVE As Short = 2 '2 moves per turn
	
	'Dim iTurn As Integer 'Each player has a turn
	Dim iMoveNum As Short 'Each turn consists of 2 moves
	Dim iPlayer As Short 'Current player number
    Dim oPPiece(MAXMOVE) As PPiece 'New PPiece 'copy the piece before moving it: for undo
	Dim oPPieceTo(MAXMOVE) As PPiece 'pointers to actual pieces
    Dim oPlayer(cMAXPLAYER) As player 'New Player
	
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
        'There are 2 moves in a turn
        Get
            Return iMoveNum
        End Get
        Set(ByVal Value As Short)
            iMoveNum = Value
        End Set
    End Property

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
            score = oPlayer(aPlayer).score()
        End Get
    End Property

    Public ReadOnly Property status(ByVal aPlayer As Short) As Short
        Get
            status = oPlayer(aPlayer).status()
        End Get
    End Property

    Sub decMove()
        'A move has been undone
        iMoveNum = iMoveNum - 1
        If iMoveNum = 0 Then 'it's the end of a turn
            iMoveNum = MAXMOVE
            decPlayer()
        End If
        'showStatus()
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
            If oPlayer(iPlayer).status > 0 Then 'active
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

    Function getPlayer() As player
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
        If iMoveNum = 1 Then
            oPPieceTo(2) = Nothing
        End If
        oPPieceTo(iMoveNum) = aPPiece
        If iMoveNum = 2 Then
            If (oPPieceTo(1).inForeignHome Or oPPieceTo(2).inForeignHome) Then
                MsgBox("You can't end leave your pieces in someone else's home. ")
                undo()
                Exit Sub
            End If
        End If
        iMoveNum = iMoveNum + 1
        If iMoveNum > MAXMOVE Then
            iMoveNum = 1
            incPlayer()
        End If
        'showStatus()
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
            If oPlayer(iPlayer).status > 0 Then
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

        iMoveNum = 1
        iPlayer = 0
        For i = 1 To MAXMOVE
            oPPiece(i) = New PPiece
            'oPPieceTo(i) = New PPiece
        Next i
        For i = 1 To cMAXPLAYER
            oPlayer(i) = New Player
            oPlayer(i).ID = i
            oPlayer(i).score = 0
            'oPlayer(i).status = 0 'inactive
            Select Case i
                Case 1
                    If My.Settings.Player1Human Then oPlayer(i).status = 1 Else oPlayer(i).status = 0
                Case 2
                    If My.Settings.Player2Human Then oPlayer(i).status = 1 Else oPlayer(i).status = 0
                Case 3
                    If My.Settings.Player3Human Then oPlayer(i).status = 1 Else oPlayer(i).status = 0
                Case 4
                    If My.Settings.Player4Human Then oPlayer(i).status = 1 Else oPlayer(i).status = 0
            End Select
            oPlayer(i).name = "Player " & i
        Next i
        'showStatus()
    End Sub

    Sub rndPlayer()
        'Choose someone to start
        Randomize(Now.Ticks)
        iPlayer = Int(Rnd() * cMAXPLAYER) + 1
        incPlayer()
    End Sub

    Sub saveSource(ByRef aPPiece As PPiece)
        'Copy the piece as it was before being moved
        If iMoveNum = 1 Then
            oPPiece(2).init() 'clear the 2nd piece info in the turn history
        End If
        aPPiece.copyTo(oPPiece(iMoveNum))
    End Sub

    Sub undo()
        'Undo Turn
        If oPPiece(2).xPos <> 0 Then 'there is a second move to undo
            If Not oPPieceTo(2) Is Nothing Then 'there is a second piece to move: this was to fix
                'error 3/2/2009 where 1st move was illegal due to maximum height and therefore had to be undone
                oPPiece(2).copyTo(oPPieceTo(2)) 'copy the old information back to the piece that moved. aPPieces.getPiece(oPPiece(2).pPID)
                oPPieceTo(2).draw() 'aPPieces.getPiece(oPPiece(2).pPID).draw
            End If
        End If
        If oPPiece(1).xPos <> 0 Then 'there is a first move to undo
            oPPiece(1).copyTo(oPPieceTo(1)) 'aPPieces.getPiece(oPPiece(1).pPID)
            oPPieceTo(1).draw() 'aPPieces.getPiece(oPPiece(1).pPID).draw
        End If
        iPlayer = oPPiece(1).owner
        iMoveNum = 1
    End Sub


End Class