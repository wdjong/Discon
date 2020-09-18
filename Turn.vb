'Option Strict Off
'Option Explicit On
'Imports System.Security.Cryptography
Imports System.Xml.Serialization 'http://www.vb-helper.com/howto_net_serialize.html

<Serializable()> _ '// https: //msdn.microsoft.com/en-us/library/et91as27(v=vs.110).aspx
Public Class Turn
    'a collection of Player objects
    Private Const cMAXPLAYER As Short = 4 '4 players
    Private Const cMAXMOVE As Short = 2 '2 moves per turn
    Private Const cMAXPPIECE As Short = 6 '6 player pieces per player
    Private iPlayer As Short 'Current player number
    Private ReadOnly mPPieceCopies(cMAXMOVE) As PPiece 'copies of pieces before moving it: for undo
    Private ReadOnly mPPieceRefs(cMAXMOVE) As PPiece 'pointers to actual pieces that have moved updated in 
    Private ReadOnly mPlayers(cMAXPLAYER) As Player 'list of pointers to player objects
    Private ReadOnly random As New Random()

    'Constructor
    Public Sub New()
        'On creation of the object
        MyBase.New()
        Dim i As Short
        For i = 1 To cMAXMOVE
            mPPieceCopies(i) = New PPiece(i, 12)
        Next i
        For i = 1 To MaxPlayer
            mPlayers(i) = New Player()
        Next
        Init()
    End Sub

    'Properties
    Public ReadOnly Property MaxPlayer() As Short
        'The maximum number of players
        Get
            MaxPlayer = cMAXPLAYER
        End Get
    End Property

    Public Property Move() As Short

    Public Property PlayerCount() As Short 'Active players (determines MaxHeight)

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

    Public ReadOnly Property MaxMove() As Short
        'This is the number of moves each player has per turn
        Get
            MaxMove = cMAXMOVE
        End Get
    End Property

    Public ReadOnly Property MaxPPiece() As Short
        'This is the number of player pieces each player has
        Get
            MaxPPiece = cMAXPPIECE
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
            Score = mPlayers(aPlayer).Score()
        End Get
    End Property

    Public ReadOnly Property Status(ByVal aPlayer As Short) As Short
        Get
            Status = mPlayers(aPlayer).Status()
        End Get
    End Property

    Public Property Message() As String

    'Methods
    Public Sub CopyTo(ByRef DestTurn As Turn)
        'copy from this Turn to the passed Turn
        Dim p As Short 'player index
        Try
            DestTurn.Player = Player
            For p = 1 To MaxPlayer
                GetPlayer(p).CopyTo(DestTurn.GetPlayer(p))
            Next
        Catch ex As Exception
            Message = ex.Message
            Debug.Print(Message)
        End Try
    End Sub

    Public Sub DecMove()
        'Decrement the move counter
        Move -= 1
        If Move < 1 Then 'Last Player
            DecPlayer()
            Move = MaxMove
        End If
    End Sub

    Private Sub DecPlayer()
        'It's the last person's turn
        Dim bNotFound As Boolean
        Dim iCountInactive As Short

        bNotFound = True
        iCountInactive = 0
        Do While bNotFound And iCountInactive <= 3
            iPlayer -= 1
            If iPlayer < 1 Then
                iPlayer = MaxPlayer
            End If
            If mPlayers(iPlayer).Status > 0 Then
                bNotFound = False
            Else
                iCountInactive += 1
            End If
        Loop
        If iCountInactive >= 4 Then
            MsgBox("All the players are inactive!")
            End
        End If
    End Sub

    Public Function GetPPiece(ByVal p As Short) As PPiece
        'return a reference to the player piece object (which contains the state of a piece before it was moved)
        GetPPiece = mPPieceCopies(p)
    End Function

    Public Function GetPlayer(ByVal p As Short) As Player
        'return any player's object
        GetPlayer = mPlayers(p)
    End Function

    Public Function GetPlayer() As Player
        'return the current player's object
        GetPlayer = mPlayers(iPlayer)
    End Function

    Public Function IncMove() As Boolean
        'Increment the move counter
        'If it's the 2nd move, then check for either piece being in foreign home. If they are, indicate error and undo both moves.
        Try
            IncMove = True
            If Move = 2 Then
                If (mPPieceRefs(1).InForeignHome Or mPPieceRefs(2).InForeignHome) Then
                    Message = "You can't end leave your pieces in someone else's home. "
                    'Debug.Print(Message)
                    IncMove = False
                    Exit Function
                End If
            End If
            Move += 1
            If Move > cMAXMOVE Then 'Next Player
                IncPlayer()
                Move = 1
            End If

        Catch ex As Exception
            Message = ex.Message
            Debug.Print(Message)
        End Try
    End Function

    Public Sub IncPlayer()
        'It's the next person's turn
        Dim bNotFound As Boolean
        Dim iCountInactive As Short

        bNotFound = True
        iCountInactive = 0
        Do While bNotFound And iCountInactive <= 3
            iPlayer += 1
            If iPlayer > cMAXPLAYER Then
                iPlayer = 1
            End If
            If mPlayers(iPlayer).Status > 0 Then
                bNotFound = False
            Else
                iCountInactive += 1
            End If
        Loop
        If iCountInactive >= 4 Then
            MsgBox("All the players are inactive!")
            End
        End If
    End Sub

    Public Sub Init()
        'Called from File | New
        Dim i As Short

        Move = 1 'of the 
        PlayerCount = 0 'work out active players
        For i = 1 To cMAXPLAYER
            mPlayers(i).PID = i
            mPlayers(i).Score = 0
            Select Case i
                Case 1
                    mPlayers(i).Status = My.Settings.Player1Hum1Cmp2
                Case 2
                    mPlayers(i).Status = My.Settings.Player2Hum1Cmp2
                Case 3
                    mPlayers(i).Status = My.Settings.Player3Hum1Cmp2
                Case 4
                    mPlayers(i).Status = My.Settings.Player4Hum1Cmp2
            End Select
            If mPlayers(i).Status > 0 Then
                PlayerCount += 1
            End If
            mPlayers(i).Name = "Player " & i
        Next i
        RndPlayer() 'pick starter
    End Sub

    Public Function LeadingPlayer() As String
        Dim aPlayer As Player
        Dim LeadingScore As Short = 0
        Dim iLeadingID(MaxPlayer) As Short
        Dim iLeaderCount As Short = 0

        For Each aPlayer In mPlayers
            If Not aPlayer Is Nothing Then
                If aPlayer.Score > LeadingScore Then

                    iLeaderCount = 1 'a leader found
                    iLeadingID(1) = aPlayer.PID 'store id
                    LeadingScore = aPlayer.Score 'remember best score
                ElseIf aPlayer.Score = LeadingScore Then
                    iLeaderCount += 1 'another leader found
                    iLeadingID(iLeaderCount) = aPlayer.PID
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

    Public Sub RestoreSource(ByRef aPPiece As PPiece)
        'Restore the piece to its state before being moved
        'oPieceTo is a reference to the piece/s involved in the move updated in incMove (after the move) for use in checking legality of final position i.e. if move 1 still in opposition home
        If mPPieceCopies Is Nothing Or aPPiece.PPID <> mPPieceCopies(Move).PPID Then
            MsgBox("RestoreSource: Copy doesn't exist or Copy ID doesn't match")
        End If
        mPPieceCopies(Move).CopyTo(aPPiece) 'copy of piece being moved
    End Sub

    Public Sub RndPlayer()
        'Choose someone to start
        Dim i As Short = 0
        iPlayer = random.Next(1, 5)
        'Debug.Print(iPlayer)
        Do While mPlayers(iPlayer).Status = 0 And i < 100 'Keep going till you find a participating player.
            iPlayer = random.Next(1, 5) 'Int(Rnd() * PlayerCount) + 1 'Who'll go first
            'Debug.Print(iPlayer)
            i += 1
        Loop
    End Sub

    Public Sub SaveSource(ByRef aPPiece As PPiece)
        'Copy the piece as it was before being moved
        'oPieceTo is a reference to the piece/s involved in the move updated in incMove (after the move) for use in checking legality of final position i.e. if move 1 still in opposition home
        If Move = 1 Then
            mPPieceCopies(2).Init(0, 12) 'This is a copy. but the tower references real segments so don't do anything that changes segments here. i.e. Init changes the XPos and YPos of PPiece but that then updates the XPos and YPos of the segment
            mPPieceRefs(2) = Nothing
        End If
        aPPiece.CopyTo(mPPieceCopies(Move)) 'copy of piece being moved
        mPPieceRefs(Move) = aPPiece 'in case incMove Doesn't happen we still need to know this for undo
    End Sub

    Public Sub SetStatus()
        'Called from new, after preferences have been updated e.g. on new game
        Dim i As Short

        PlayerCount = 0 'work out active players
        For i = 1 To cMAXPLAYER
            Select Case i
                Case 1
                    mPlayers(i).Status = My.Settings.Player1Hum1Cmp2
                Case 2
                    mPlayers(i).Status = My.Settings.Player2Hum1Cmp2
                Case 3
                    mPlayers(i).Status = My.Settings.Player3Hum1Cmp2
                Case 4
                    mPlayers(i).Status = My.Settings.Player4Hum1Cmp2
            End Select
            If mPlayers(i).Status > 0 Then
                PlayerCount += 1
            End If
        Next i
    End Sub

    Public Sub Undo(movesToUndo As Short)

        Dim oldValue As Short 'each move, find change in score and add it to player score
        Dim newValue As Short 'scoring

        iPlayer = mPPieceCopies(1).Owner 'ctrl-z can happen after incPlayer() (in incMove())

        'Undo Turn i.e. possibly 2 moves            
        If mPPieceCopies(2).XPos <> 0 And Not mPPieceRefs(2) Is Nothing Then 'there is a second move to undo
            oldValue = mPPieceRefs(2).Score 'remember the current score
            mPPieceCopies(2).CopyTo(mPPieceRefs(2)) 'copy the old information back to the piece that moved.
            'oPPieceTo(2).Draw() 'Opposite of player piece move method which includes draw so this should include draw since player piece object position has been updated
            newValue = mPPieceRefs(2).Score
            mPPieceRefs(2).UpdateTooltip() 'to display colour and height
            mPlayers(iPlayer).Score = mPlayers(iPlayer).Score - oldValue + newValue

            Move = 2
        End If

        If movesToUndo = 2 Then
            If mPPieceCopies(1).XPos <> 0 Then 'there is a first move to undo
                oldValue = mPPieceRefs(1).Score 'remember the current score
                mPPieceCopies(1).CopyTo(mPPieceRefs(1)) '
                'oPPieceTo(1).Draw() 'aPPieces.getPiece(oPPiece(1).pPID).draw
                newValue = mPPieceRefs(1).Score
                mPPieceRefs(1).UpdateTooltip() 'to display colour and height
                mPlayers(iPlayer).Score = mPlayers(iPlayer).Score - oldValue + newValue 'aPlayer.GetScore could just sum all piece scores
            End If
            Move = 1
        End If
    End Sub

End Class