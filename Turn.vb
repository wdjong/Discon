Option Strict Off
Option Explicit On
Friend Class Turn
    'a collection of Player objects
    Private Const cMAXPLAYER As Short = 4 '4 players
    Private Const MAXMOVE As Short = 2 '2 moves per turn
    Private iPlayer As Short 'Current player number
    Private ReadOnly oPPiece(MAXMOVE) As PPiece 'copies of pieces before moving it: for undo
    Private ReadOnly oPPieceTo(MAXMOVE) As PPiece 'pointers to actual pieces that have moved updated in 
    Private ReadOnly oPlayer(cMAXPLAYER) As Player 'list of pointers to player objects
    Private ReadOnly random As New Random()

    Public Sub New()
        'On creation of the object
        MyBase.New()
        Dim i As Short
        For i = 1 To MAXMOVE
            oPPiece(i) = New PPiece(12)
        Next i
        For i = 1 To maxPlayer
            oPlayer(i) = New Player()
        Next
        init()
    End Sub

    Public ReadOnly Property maxPlayer() As Short
        'The maximum number of players
        Get
            maxPlayer = cMAXPLAYER
        End Get
    End Property

    Public Property move() As Short

    Public Property PlayerCount() As Short 'Active players

    Public ReadOnly Property MaxHeight() As Short
        Get
            MaxHeight = 4
            Select Case PlayerCount
                Case 3
                    MaxHeight = 10
                Case 4
                    MaxHeight = 8
            End Select
        End Get
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
        'If it's the 2nd move, then check for either piece being in foreign home. If they are, 
        'indicate error and undo both moves.
        'oPPieceTo() are references to the piece being moved. oPPiece() are copies
        If move = 1 Then
            oPPieceTo(2) = Nothing 'Clear record of what piece was moved 2nd
        End If
        oPPieceTo(move) = aPPiece 'for both move 1 and 2 store a reference to the actual piece moved in the oPPieceTo array
        If move = 2 Then
            If (oPPieceTo(1).InForeignHome Or oPPieceTo(2).InForeignHome) Then
                MsgBox("You can't end leave your pieces in someone else's home. ")
                undo()
                Exit Sub
            End If
        End If
        move += 1
        If move > MAXMOVE Then 'Next Player
            incPlayer()
            move = 1
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
        'Called from new, after preferences have been updated e.g. on new game
        Dim i As Short

        move = 1 'of the 
        PlayerCount = 0 'work out active players
        For i = 1 To cMAXPLAYER
            oPlayer(i).ID = i
            oPlayer(i).Score = 0
            Select Case i
                Case 1
                    If My.Settings.Player1Human Then
                        oPlayer(i).Status = 1
                        PlayerCount += 1
                    Else
                        oPlayer(i).Status = 0
                    End If
                Case 2
                    If My.Settings.Player2Human Then
                        oPlayer(i).Status = 1
                        PlayerCount += 1
                    Else
                        oPlayer(i).Status = 0
                    End If
                Case 3
                    If My.Settings.Player3Human Then
                        oPlayer(i).Status = 1
                        PlayerCount += 1
                    Else
                        oPlayer(i).Status = 0
                    End If
                Case 4
                    If My.Settings.Player4Human Then
                        oPlayer(i).Status = 1
                        PlayerCount += 1
                    Else
                        oPlayer(i).Status = 0
                    End If
            End Select
            oPlayer(i).Name = "Player " & i
        Next i
        rndPlayer() 'pick starter
    End Sub

    Sub rndPlayer()
        'Choose someone to start
        Dim i As Short = 0
        iPlayer = random.Next(1, 5)
        'Debug.Print(iPlayer)
        Do While oPlayer(iPlayer).Status = 0 And i < 100 'Keep going till you find a participating player.
            iPlayer = random.Next(1, 5) 'Int(Rnd() * PlayerCount) + 1 'Who'll go first
            'Debug.Print(iPlayer)
            i += 1
        Loop
    End Sub

    Sub saveSource(ByRef aPPiece As PPiece)
        'Copy the piece as it was before being moved
        'oPieceTo is a reference to the piece/s involved in the move updated in incMove (after the move) for use in checking legality of final position i.e. if move 1 still in opposition home
        If move = 1 Then
            oPPiece(2).Init(12) 'clear the 2nd piece info in the turn history
        End If
        aPPiece.CopyTo(oPPiece(move)) 'copy of piece being moved
    End Sub

    Sub undo()

        Dim oldValue As Short 'each move, find change in score and add it to player score
        Dim newValue As Short 'scoring

        iPlayer = oPPiece(1).Owner 'ctrl-z can happen after incPlayer() (in incMove())

        'Undo Turn i.e. possibly 2 moves            
        If oPPiece(2).XPos <> 0 And Not oPPieceTo(2) Is Nothing Then 'there is a second move to undo
            oldValue = oPPieceTo(2).Score 'remember the current score
            oPPiece(2).CopyTo(oPPieceTo(2)) 'copy the old information back to the piece that moved.
            oPPieceTo(2).Draw()
            newValue = oPPieceTo(2).Score
            oPPieceTo(2).UpdateTooltip() 'to display colour and height
            oPlayer(iPlayer).Score = oPlayer(iPlayer).Score - oldValue + newValue
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