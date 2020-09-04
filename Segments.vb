Option Strict Off
Option Explicit On
Friend Class Segments

    Const MAXSEGM As Short = 96 '16 Ivory, 24 Blue, 24 Pink and 32 Purple
    Dim aSegments(MAXSEGM) As Segment 'New Segment
    Dim oBoard As Board 'for storing segment information

    Function AddAny(ByRef aPiece As PPiece, ByRef x As Short, ByRef y As Short) As Boolean
        'Add any pieces that aren't already in the tower to the bottom of the tower (in the right order)
        Dim s1 As Short 'segment index
        Dim s2 As Short 'segment index
        Dim sToAdd(12) As Segment 'Found segments
        Dim sToAddCount As Short = 0 'Track how many to be added
        Dim existingCount As Short = 0 'handle the case where teh segments have already been moved there.
        'Prevent exceeding maximum

        AddAny = True
        For s1 = 1 To MAXSEGM 'check all segment locations for a match with the location of the passed piece
            If aSegments(s1).XPos = x And aSegments(s1).YPos = y Then
                If aPiece.cTower.IDExists(aSegments(s1).ID) Then
                    existingCount += 1
                Else
                    sToAdd(aSegments(s1).VerticalPos) = aSegments(s1) 'put the segment in order in the pile of segments to add
                    sToAddCount += 1
                End If
            End If
        Next s1

        If sToAddCount > 0 Then
            If aPiece.cTower.Height + sToAddCount <= aPiece.cTower.MaxHeight Then
                For s2 = sToAddCount To 1 Step -1
                    If Not aPiece.Add(sToAdd(s2)) Then 'Calls tower Add which should update Vertical position
                        MsgBox(aPiece.Message) 'Please explain.
                        'Else
                        '    Debug.Print("Vertical Pos of top piece is" & aPiece.cTower.GetSegment(1).VerticalPos)
                    End If
                Next
            Else
                MsgBox("Adding " & sToAddCount & " to existing tower (" & aPiece.cTower.Height & ") exceeds the height restriction: " & aPiece.cTower.MaxHeight)
            End If
        End If


    End Function

    Sub Draw()
        Dim s As Short

        For s = 1 To MAXSEGM
            aSegments(s).Draw()
        Next s
    End Sub

    Function GetSegment(ByRef s As Short) As Segment
        GetSegment = aSegments(s)
    End Function

    Function GetSegmentXY(ByVal x As Short, ByVal y As Short) As Segment
        'Return a reference to a segment at given co-ordinates: Note there maybe more than one this is basically a test that it's not empty...
        Dim s As Short

        GetSegmentXY = Nothing
        For s = 1 To MAXSEGM
            If aSegments(s).XPos = x And aSegments(s).YPos = y Then
                GetSegmentXY = aSegments(s)
            End If
        Next s
    End Function

    Sub Resize()
        Dim s As Short

        For s = 1 To MAXSEGM
            aSegments(s).Resize()
        Next s
    End Sub

    Sub Setup(ByRef aBoard As Board)
        Dim s As Short
        Dim d As Short
        Const DEGREESOFCHAOS As Short = 150

        oBoard = aBoard
        For s = 1 To MAXSEGM
            aSegments(s).SetBoard(aBoard)
            aSegments(s).ID = s
            aSegments(s).Move(Int(s / aBoard.maxY) + 1, (s Mod aBoard.maxY) + 1)
            Select Case s
                Case 1 To MAXSEGM * 2 / 12
                    aSegments(s).Colour = 1 'ivory
                Case MAXSEGM * 2 / 12 + 1 To MAXSEGM * 5 / 12
                    aSegments(s).Colour = 2 'pink
                Case MAXSEGM * 5 / 12 + 1 To MAXSEGM * 8 / 12
                    aSegments(s).Colour = 3 'blue
                Case MAXSEGM * 8 / 12 + 1 To MAXSEGM
                    aSegments(s).Colour = 4 'purple
            End Select
            aSegments(s).Value = 0
        Next s
        aSegments(9).Move(10, 8)
        aSegments(90).Move(10, 9)
        For d = 1 To DEGREESOFCHAOS
            Randomize()
            Swap(Int(Rnd() * MAXSEGM) + 1, Int(Rnd() * MAXSEGM) + 1)
        Next d
    End Sub

    Sub SegmentsFromBoard()
        'e.g. Having restored the board
        'update each piece based on it's position on the board
        Dim x As Short
        Dim y As Short
        Dim i As Short

        For x = 1 To oBoard.maxX 'each board position
            For y = 1 To oBoard.maxY
                i = oBoard.getGBoardID(x, y) 'NB IDs are 1 to 32
                If i > 0 Then 'if a piece is on it
                    aSegments(i).Move(x, y)
                End If
            Next y
        Next x
    End Sub

    'Sub SetSegment(ByRef s As Short, ByRef aSegment As Segment)
    '    aSegments(s) = aSegment
    'End Sub

    'Sub SetBoard(ByRef aBoard As Board)
    '    Dim i As Short

    '    oBoard = aBoard
    '    For i = 1 To MAXSEGM
    '        aSegments(i).SetBoard(aBoard)
    '    Next i
    'End Sub

    Sub Swap(ByRef i As Short, ByRef j As Short)
        'swap two segement positions during initialization
        Dim x As Short
        Dim y As Short

        x = aSegments(i).XPos
        y = aSegments(i).YPos
        aSegments(i).Move((aSegments(j).XPos), (aSegments(j).YPos))
        aSegments(j).Move(x, y)
    End Sub

    Public Sub New()
        'Initialize array of segments
        Dim i As Short

        For i = 1 To MAXSEGM
            aSegments(i) = New Segment
        Next i
    End Sub
End Class