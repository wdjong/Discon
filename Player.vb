'Option Strict Off
'Option Explicit On
Imports System.Xml.Serialization 'http://www.vb-helper.com/howto_net_serialize.html

<Serializable()> _ '// https: //msdn.microsoft.com/en-us/library/et91as27(v=vs.110).aspx
Public Class Player

    Private iStatus As Short '0 inactive, 1 human, 2 computer
    Private iPID As Short 'player ID
    Private iScore As Short

    'Constructor
    Public Sub New()
        MyBase.New()
        iPID = 0
        iScore = 0
        iStatus = 0
        Name = ""
    End Sub

    'Properties
    Public Property Message() As String

    Public Property Name() As String

    Public Property PID() As Short
        Get
            PID = iPID
        End Get
        Set(ByVal Value As Short)
            iPID = Value
        End Set
    End Property

    Public Property Score() As Short
        Get
            Score = iScore
        End Get
        Set(ByVal Value As Short)
            iScore = Value
        End Set
    End Property

    Public Property Status() As Short
        Get
            Status = iStatus
        End Get
        Set(ByVal Value As Short)
            iStatus = Value
        End Set
    End Property

    'Methods
    Public Sub CompMove(aPPieces As PPieces, aSegments As Segments, aTurn As Turn)
        Dim aPPiece(aTurn.MaxMove) As PPiece '
        Dim pp1 As Short 'player piece index
        Dim d1 As Short 'direction
        Dim s1 As Short 'segments at destination
        Dim oldValue1 As Short
        Dim newValue1 As Short 'Change in score after moves
        Dim pp2 As Short 'player piece index
        Dim d2 As Short 'direction
        Dim s2 As Short 'segments at destination
        Dim oldValue2 As Short
        Dim newValue2 As Short 'Change in score after moves
        Dim bestScore As Short = -1
        Dim bestPPID1 As Short 'PPID of for best move
        Dim bestD1 As Short
        Dim bestPPID2 As Short '
        Dim bestD2 As Short

        For pp1 = 1 To aPPieces.MaxPPieces 'Player piece (6)
            aPPiece(1) = aPPieces.GetPiece(pp1) 'get a reference to each piece
            If aPPiece(1).Owner = iPID Then 'the piece is owned by the player
                oldValue1 = aPPiece(1).Score
                aTurn.SaveSource(aPPiece(1)) 'copy the state of the piece prior to the move for undoing
                For d1 = 1 To 8
                    If aPPiece(1).Move(d1) Then 'position has changed (need to do MoveUndo at end
                        Debug.Print("1:" & pp1 & " to " & aPPiece(1).XPos & ", " & aPPiece(1).YPos & " (" & d1 & ")")
                        If Not aPPieces.IsOccupied(aPPiece(1)) Then
                            s1 = aSegments.CountSegmentXY(aPPiece(1))
                            If aSegments.AddN(aPPiece(1), s1) Then
                                newValue1 = aPPiece(1).Score
                                If aTurn.IncMove() Then 'to Move 2
                                    For pp2 = 1 To aPPieces.MaxPPieces 'Player piece (6)
                                        aPPiece(2) = aPPieces.GetPiece(pp2)
                                        If aPPiece(2).Owner = iPID Then 'if the piece is owned by the player
                                            oldValue2 = aPPiece(2).Score
                                            aTurn.SaveSource(aPPiece(2)) '
                                            For d2 = 1 To 8
                                                If aPPiece(2).Move(d2) Then 'Move player piece and tower
                                                    Debug.WriteLine(", 2:" & pp2 & " to " & aPPiece(1).XPos & ", " & aPPiece(1).YPos & " (" & d2 & ")")
                                                    If Not aPPieces.IsOccupied(aPPiece(2)) Then ' And Not (aPPiece(1).XPos = aPPiece(2).XPos And aPPiece(1).YPos = aPPiece(2).YPos) Then
                                                        s2 = aSegments.CountSegmentXY(aPPiece(2))
                                                        If aSegments.AddN(aPPiece(2), s2) Then 'Add any segments found that are not already in the tower if not > Tower MaxHeight 'Scoring in tower add
                                                            newValue2 = aPPiece(2).Score
                                                            If aTurn.IncMove() Then 'count move. If second, check you're not in foreign territory
                                                                If (newValue1 - oldValue1) + (newValue2 - oldValue2) > bestScore Then
                                                                    bestScore = (newValue1 - oldValue1) + (newValue2 - oldValue2) ' Update BestScore
                                                                    'aTurn.GetPPiece(1).CopyTo(bestPiece(1))
                                                                    bestPPID1 = aTurn.GetPPiece(1).PPID
                                                                    bestD1 = d1
                                                                    'aTurn.GetPPiece(2).CopyTo(bestPiece(2))
                                                                    bestD2 = d2
                                                                    bestPPID2 = aTurn.GetPPiece(2).PPID
                                                                End If 'new best value
                                                                aTurn.DecMove() 'only if IncMove succeeded
                                                            End If 'IncMove ok
                                                            aSegments.RemoveN(aPPiece(2), s2) 'only if AddN succeeded
                                                        End If 'AddN ok
                                                    End If 'unoccupied
                                                    aPPiece(2).MoveUndo(d2) 'Return player piece and tower (only if Move succeeded)
                                                End If '2nd Move ok
                                            Next d2 'direction 2
                                            aTurn.RestoreSource(aPPiece(2))
                                        End If 'piece owned by player
                                    Next pp2 'player piece 2
                                    aTurn.DecMove() 'only do this if IncMove was successful
                                End If 'IncMove ok
                                aSegments.RemoveN(aPPiece(1), s1) 'only do this if AddN was successful
                            End If 'AddN 1 ok
                            aPPiece(1).MoveUndo(d1) 'only do this if Move was successful
                        End If 'Unoccupied 1 ok
                    End If 'Move 1 ok
                Next d1 'direction 1
                aTurn.RestoreSource(aPPiece(1))
            End If 'piece owned by player
        Next pp1 'player piece 1

        'Play best move 1 -------------------------------------------------------
        aPPiece(1) = aPPieces.GetPiece(bestPPID1)
        oldValue1 = aPPiece(1).Score
        aTurn.SaveSource(aPPiece(1))
        If aPPiece(1).Move(bestD1) Then
            If aSegments.AddAny(aPPiece(1)) Then
                newValue1 = aPPiece(1).Score
                aPPiece(1).UpdateTooltip() 'to display colour and height
                aPPiece(1).Draw()
                aTurn.Message = aPPiece(1).Owner & ":" & aPPiece(1).PPID & " to " & aPPiece(1).XPos & ", " & aPPiece(1).YPos
                Score = Score - oldValue1 + newValue1
                If aTurn.IncMove() Then 'Play best move 2
                    aPPiece(2) = aPPieces.GetPiece(bestPPID2)
                    oldValue2 = aPPiece(2).Score
                    aTurn.SaveSource(aPPiece(2)) '
                    If aPPiece(2).Move(bestD2) Then
                        If aSegments.AddAny(aPPiece(2)) Then 'Add any segments found that are not already in the tower if not > Tower MaxHeight 'Scoring in tower add
                            newValue2 = aPPiece(2).Score
                            aPPiece(2).UpdateTooltip() 'to display colour and height
                            aPPiece(2).Draw()
                            aTurn.Message += " and " & aPPiece(2).PPID & " to " & aPPiece(2).XPos & ", " & aPPiece(2).YPos
                            Score = Score - oldValue2 + newValue2
                            If aTurn.IncMove() Then 'count move. If second, check you're not in foreign territory
                                Debug.Print("Move made")
                            Else
                                MsgBox("IncMove 2 problem " & aTurn.Message)
                            End If
                        Else
                            MsgBox("AddAny 2 problem " & aSegments.Message)
                        End If
                    Else
                        MsgBox("Move 2 problem " & aPPiece(1).Message)
                    End If
                Else
                    MsgBox("IncMove 1 problem " & aTurn.Message)
                End If
            Else
                MsgBox("AddAny 1 problem " & aSegments.Message)
            End If
        Else
            MsgBox("Move 1 problem " & aPPiece(2).Message)
        End If
    End Sub

    Public Sub CopyTo(ByRef DestPlayer As Player)
        'copy from this Player to the passed Player

        Try
            DestPlayer.Status = Status
            DestPlayer.PID = PID
            DestPlayer.Score = Score
        Catch ex As Exception
            Message = ex.Message
            Debug.Print(Message)
        End Try
    End Sub
End Class