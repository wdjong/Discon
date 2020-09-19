'Option Strict Off
Imports System.Xml.Serialization 'http://www.vb-helper.com/howto_net_serialize.html

<Serializable()> _ '// https: //msdn.microsoft.com/en-us/library/et91as27(v=vs.110).aspx
Public Class Segments

    Const cMAXSEGM As Short = 96 '16 Ivory, 24 Blue, 24 Pink and 32 Purple
    Private ReadOnly mSegments(cMAXSEGM) As Segment 'New Segment
    'Private mBoard As Board 'for storing segment information

    'Constructor

    Public Sub New()
        'Initialize array of segments
        Dim i As Short

        For i = 1 To cMAXSEGM
            mSegments(i) = New Segment
        Next i
    End Sub

    'Properties
    Public ReadOnly Property MaxSegments() As Short
        'Supports knowing when the game is over
        Get
            MaxSegments = cMAXSEGM
        End Get
    End Property

    Public Property Message() As String

    'Methods
    Friend Function AddAny(aPiece As PPiece) As Boolean
        'Add any pieces that aren't already in the tower to the bottom of the tower (in the right order)
        Dim s1 As Short 'segment index
        Dim s2 As Short 'segment index
        Dim sToAdd(12) As Segment 'Found segments
        Dim sToAddCount As Short = 0 'Track how many to be added
        Dim existingCount As Short = 0 'handle the case where teh segments have already been moved there.
        'Prevent exceeding maximum

        Try
            AddAny = True
            For s1 = 1 To cMAXSEGM 'check all segment locations for a match with the location of the passed piece
                If mSegments(s1).XPos = aPiece.XPos And mSegments(s1).YPos = aPiece.YPos Then
                    If aPiece.GetTowerRef.IDExists(mSegments(s1).SID) Then 'check if id is already in player piece's tower.
                        existingCount += 1
                    Else
                        sToAdd(mSegments(s1).VerticalPos) = mSegments(s1) 'put the segment in order in the pile of segments to add
                        sToAddCount += 1
                    End If
                End If
            Next s1

            If sToAddCount > 0 Then
                If aPiece.GetTowerRef.Height + sToAddCount <= aPiece.GetTowerRef.MaxHeight Then
                    For s2 = sToAddCount To 1 Step -1
                        If Not aPiece.Add(sToAdd(s2)) Then 'Calls tower Add which should update Vertical position
                            MsgBox(aPiece.Message) 'Please explain.
                        End If
                    Next
                Else
                    Message = "Adding " & sToAddCount & " to existing tower (" & aPiece.GetTowerRef.Height & ") exceeds the height restriction: " & aPiece.GetTowerRef.MaxHeight
                    Debug.Print(Message)
                    AddAny = False
                End If
            End If
        Catch ex As Exception
            Message = ex.Message
            Debug.Print(Message)
            'Stop
        End Try

    End Function

    Friend Sub CopyTo(DestSegments As Segments)
        Dim s As Short

        For s = 1 To MaxSegments
            GetSegmentRef(s).CopyTo(DestSegments.GetSegmentRef(s))
        Next
    End Sub

    Friend Function AddN(aPiece As PPiece, n As Short) As Boolean
        'Add n segments pieces that aren't already in the tower to the bottom of the tower (in the right order)
        Dim s1 As Short 'segment index
        Dim s2 As Short 'segment index
        Dim sToAdd(12) As Segment 'Found segments
        Dim sToAddCount As Short = 0 'Track how many to be added
        Dim existingCount As Short = 0 'handle the case where teh segments have already been moved there.
        'Prevent exceeding maximum

        AddN = True
        For s1 = 1 To cMAXSEGM 'check all segment locations for a match with the location of the passed piece
            If mSegments(s1).XPos = aPiece.XPos And mSegments(s1).YPos = aPiece.YPos Then
                If aPiece.GetTowerRef.IDExists(mSegments(s1).SID) Then 'check if id is already in player piece's tower.
                    existingCount += 1
                Else
                    sToAdd(mSegments(s1).VerticalPos) = mSegments(s1) 'put the segment in order in the pile of segments to add
                    sToAddCount += 1
                End If
            End If
        Next s1

        If n <> sToAddCount Then
            MsgBox("AddN: There are not " & n & " to add.")
        End If

        If sToAddCount > 0 Then
            If aPiece.GetTowerRef.Height + sToAddCount <= aPiece.GetTowerRef.MaxHeight Then
                For s2 = sToAddCount To 1 Step -1
                    If Not aPiece.Add(sToAdd(s2)) Then 'Calls tower Add which should update Vertical position
                        MsgBox(aPiece.Message) 'Please explain.
                    End If
                Next
            Else
                Message = "Adding " & sToAddCount & " to existing tower (" & aPiece.GetTowerRef.Height & ") exceeds the height restriction: " & aPiece.GetTowerRef.MaxHeight
                Debug.Print(Message)
                AddN = False
            End If
        End If

    End Function

    Function CountSegmentXY(aPPiece As PPiece) As Short
        Dim s As Short

        CountSegmentXY = 0
        For s = 1 To cMAXSEGM 'check all segment locations for a match with the location of the passed piece
            If s = 28 And mSegments(s).XPos = 1 And mSegments(s).YPos = 10 Then Debug.Print(mSegments(s).XPos & ":" & mSegments(s).YPos)
            If mSegments(s).XPos = aPPiece.XPos And mSegments(s).YPos = aPPiece.YPos Then
                If Not aPPiece.GetTowerRef.IDExists(mSegments(s).SID) Then 'check if id is already in player piece's tower.
                    CountSegmentXY += 1
                End If
            End If
        Next s
    End Function

    Sub UpdateControlPositions()
        Dim s As Short

        For s = 1 To cMAXSEGM
            mSegments(s).UpdateControlPosition()
        Next s
    End Sub

    Function GetSegmentRef(ByRef s As Short) As Segment
        GetSegmentRef = mSegments(s)
    End Function

    Function GetSegmentXY(ByVal x As Short, ByVal y As Short) As Segment
        'Return a reference to a segment at given co-ordinates: Note there maybe more than one this is basically a test that it's not empty...
        Dim s As Short

        GetSegmentXY = Nothing
        For s = 1 To cMAXSEGM
            If mSegments(s).XPos = x And mSegments(s).YPos = y Then
                GetSegmentXY = mSegments(s)
            End If
        Next s
    End Function

    Friend Function GetSegmentXY(aPPiece2 As PPiece) As Segment
        Throw New NotImplementedException()
    End Function

    Friend Sub RemoveN(aPPiece As PPiece, n As Short)
        aPPiece.Remove(n) 'Calls tower Remove which updates Vertical position for tower
    End Sub

    Sub Resize()
        Dim s As Short

        For s = 1 To cMAXSEGM
            mSegments(s).Resize()
        Next s
    End Sub

    Sub Setup(ByRef aBoard As Board)
        'layout segments on board then randomize them
        Dim s As Short
        'Dim d As Short
        'Const DEGREESOFCHAOS As Short = 150

        'mBoard = aBoard
        For s = 1 To cMAXSEGM
            mSegments(s).SetBoardRef(aBoard)
            mSegments(s).SID = s 'unique identifier
            Select Case s 'Allocate colours
                Case 1 To 16 'MAXSEGM * 2 / 12 '
                    mSegments(s).Colour = 1 '16 Ivory
                Case 17 To 40 'MAXSEGM * 2 / 12 + 1 To MAXSEGM * 5 / 12
                    mSegments(s).Colour = 2 '24 Pink  
                Case 40 To 64 'MAXSEGM * 5 / 12 + 1 To MAXSEGM * 8 / 12
                    mSegments(s).Colour = 3 '24 Blue
                Case 65 To 96 'MAXSEGM * 8 / 12 + 1 To MAXSEGM
                    mSegments(s).Colour = 4 '32 Purple
            End Select
            'mSegments(s).Value = 0
            mSegments(s).VerticalPos = 1
            mSegments(s).Move(Int(s / aBoard.MaxY) + 1, (s Mod aBoard.MaxY) + 1) 'lay them out based on id to start
        Next s
        mSegments(9).Move(10, 8) 'the Move method above does most of the job
        mSegments(90).Move(10, 9) 'this just finishes it
        'For debugging computer move rem this.
        'For d = 1 To DEGREESOFCHAOS 'mix them 
        '    Randomize()
        '    Swap(Int(Rnd() * cMAXSEGM) + 1, Int(Rnd() * cMAXSEGM) + 1)
        'Next d
    End Sub

    Sub Swap(ByRef i As Short, ByRef j As Short)
        'swap two segement positions during initialization
        Dim x As Short
        Dim y As Short

        x = mSegments(i).XPos
        y = mSegments(i).YPos
        mSegments(i).Move((mSegments(j).XPos), (mSegments(j).YPos))
        mSegments(j).Move(x, y)
    End Sub


    'Sub SegmentsFromBoard()
    '    'e.g. Having restored the board
    '    'update each piece based on it's position on the board
    '    Dim x As Short
    '    Dim y As Short
    '    Dim i As Short

    '    For x = 1 To mBoard.maxX 'each board position
    '        For y = 1 To mBoard.maxY
    '            i = mBoard.getGBoardID(x, y) 'NB IDs are 1 to 32
    '            If i > 0 Then 'if a piece is on it
    '                mSegments(i).Move(x, y)
    '            End If
    '        Next y
    '    Next x
    'End Sub

    'Sub SetBoardRef(ByRef aBoard As Board)
    '    Dim s As Short

    '    For s = 1 To cMAXSEGM
    '        mSegments(s).SetBoardRef(aBoard)
    '    Next s
    'End Sub

End Class