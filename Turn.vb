Option Strict Off
Option Explicit On
Imports System.Security.Cryptography

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
        For i = 1 To MaxPlayer
            oPlayer(i) = New Player()
        Next
        Init()
    End Sub

    Public ReadOnly Property MaxPlayer() As Short
        'The maximum number of players
        Get
            MaxPlayer = cMAXPLAYER
        End Get
    End Property

    Public Property Move() As Short

    Public Property PlayerCount() As Short 'Active players

    Public ReadOnly Property MaxHeight() As Short
        'This is the master MaxHeight for a game. It is also stored for convenience the the tower objects to prevent exceeding MaxHeight
        Get
            MaxHeight = 12
            Select Case PlayerCount
                Case 3
                    MaxHeight = 10
                Case 4
                    MaxHeight = 8
            End Select
        End Get
    End Property

    Public Property Player() As Short
        'The current player number
        Get
            Player = iPlayer
        End Get
        Set(ByVal Value As Short)
            iPlayer = Value
        End Set
    End Property

    Public ReadOnly Property Score(ByVal aPlayer As Short) As Short
        Get
            Score = oPlayer(aPlayer).Score()
        End Get
    End Property

    Public ReadOnly Property Status(ByVal aPlayer As Short) As Short
        Get
            Status = oPlayer(aPlayer).Status()
        End Get
    End Property

    Public Function GetPlayer() As Player
        'return the current player's object
        GetPlayer = oPlayer(iPlayer)
    End Function

    Public Function GetPlayer(ByVal p As Short) As Player
        'return any player's object
        GetPlayer = oPlayer(p)
    End Function

    Public Sub IncMove()
        'Increment the move counter
        'If it's the 2nd move, then check for either piece being in foreign home. If they are, indicate error and undo both moves.

        If Move = 2 Then
            If (oPPieceTo(1).InForeignHome Or oPPieceTo(2).InForeignHome) Then
                MsgBox("You can't end leave your pieces in someone else's home. ")
                Undo()
                Exit Sub
            End If
        End If
        Move += 1
        If Move > MAXMOVE Then 'Next Player
            IncPlayer()
            Move = 1
        End If
    End Sub

    Public Sub IncPlayer()
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

    Public Sub Init()
        'Called from new, after preferences have been updated e.g. on new game
        Dim i As Short

        Move = 1 'of the 
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
        RndPlayer() 'pick starter
    End Sub

    Public Sub RndPlayer()
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

    Public Sub SaveSource(ByRef aPPiece As PPiece)
        'Copy the piece as it was before being moved
        'oPieceTo is a reference to the piece/s involved in the move updated in incMove (after the move) for use in checking legality of final position i.e. if move 1 still in opposition home
        If Move = 1 Then
            oPPiece(2).Init(12) 'clear the 2nd piece info in the turn history
            oPPieceTo(2) = Nothing
        End If
        aPPiece.CopyTo(oPPiece(Move)) 'copy of piece being moved
        oPPieceTo(Move) = aPPiece 'in case incMove Doesn't happen we still need to know this for undo
    End Sub

    Public Sub Undo()

        Dim oldValue As Short 'each move, find change in score and add it to player score
        Dim newValue As Short 'scoring

        iPlayer = oPPiece(1).Owner 'ctrl-z can happen after incPlayer() (in incMove())

        'Undo Turn i.e. possibly 2 moves            
        If oPPiece(2).XPos <> 0 And Not oPPieceTo(2) Is Nothing Then 'there is a second move to undo
            oldValue = oPPieceTo(2).Score 'remember the current score
            oPPiece(2).CopyTo(oPPieceTo(2)) 'copy the old information back to the piece that moved.
            oPPieceTo(2).Draw() 'Opposite of player piece move method which includes draw so this should include draw since player piece object position has been updated
            newValue = oPPieceTo(2).Score
            oPPieceTo(2).UpdateTooltip() 'to display colour and height
            oPlayer(iPlayer).Score = oPlayer(iPlayer).Score - oldValue + newValue

        End If

        If oPPiece(1).XPos <> 0 Then 'there is a first move to undo
            oldValue = oPPieceTo(1).Score 'remember the current score
            oPPiece(1).CopyTo(oPPieceTo(1)) '
            oPPieceTo(1).Draw() 'aPPieces.getPiece(oPPiece(1).pPID).draw
            newValue = oPPieceTo(1).Score
            oPPieceTo(1).UpdateTooltip() 'to display colour and height
            oPlayer(iPlayer).Score = oPlayer(iPlayer).Score - oldValue + newValue 'aPlayer.GetScore could just sum all piece scores
        End If
        Move = 1
    End Sub

    Public Function LeadingPlayer() As String
        Dim aPlayer As Player
        Dim LeadingScore = 0
        Dim iLeadingID(MaxPlayer)
        Dim iLeaderCount = 0

        For Each aPlayer In oPlayer
            If Not aPlayer Is Nothing Then
                If aPlayer.Score > LeadingScore Then

                    iLeaderCount = 1 'a leader found
                    iLeadingID(1) = aPlayer.ID 'store id
                    LeadingScore = aPlayer.Score 'remember best score
                ElseIf aPlayer.Score = LeadingScore Then
                    iLeaderCount += 1 'another leader found
                    iLeadingID(iLeaderCount) = aPlayer.ID
                End If
            End If
        Next

        Dim p As Short
        LeadingPlayer = ""
        For p = 1 To iLeaderCount
            If p > 1 Then
                LeadingPlayer += " and "
            End If
            LeadingPlayer += "Player " & iLeadingID(1)
        Next
        LeadingPlayer += " on " & LeadingScore
    End Function

End Class