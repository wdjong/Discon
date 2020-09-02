Option Strict Off
Option Explicit On
Friend Class Segments
	
	Const MAXSEGM As Short = 96 '16 Ivory, 24 Blue, 24 Pink and 32 Purple
	Dim aSegments(MAXSEGM) As Segment 'New Segment
	Dim oBoard As Board 'for storing segment information
	
	Function addAny(ByRef aPiece As PPiece, ByRef x As Short, ByRef y As Short) As Boolean
        'add any segments that are on that location on the board to the piece
		Dim s As Short
		
		addAny = True
		aPiece.RemoveAll() 'you must be emptied in order to be filled
		For s = 1 To MAXSEGM
			If aSegments(s).xPos = x And aSegments(s).yPos = y Then
				If Not aPiece.Add(aSegments(s)) Then addAny = False
			End If
		Next s
	End Function
	
	Sub draw()
		Dim s As Short
		
        For s = 1 To MAXSEGM
            aSegments(s).draw()
        Next s
	End Sub
	
	Function getSegment(ByRef s As Short) As Segment
		getSegment = aSegments(s)
	End Function

    Function getSegmentXY(ByVal x As Short, ByVal y As Short) As Segment
        'Return a reference to the segment at given co-ordinates
        Dim s As Short

        getSegmentXY = Nothing
        For s = 1 To MAXSEGM
            If aSegments(s).xPos = x And aSegments(s).yPos = y Then
                getSegmentXY = aSegments(s)
            End If
        Next s
    End Function

    Sub resize()
        Dim s As Short

        For s = 1 To MAXSEGM
            aSegments(s).resize()
        Next s
    End Sub

    Sub setup(ByRef aBoard As Board)
        Dim s As Short
        Dim d As Short
        Const DEGREESOFCHAOS As Short = 150

        oBoard = aBoard
        For s = 1 To MAXSEGM
            aSegments(s).setBoard(aBoard)
            aSegments(s).ID = s
            aSegments(s).move(Int(s / aBoard.maxY) + 1, (s Mod aBoard.maxY) + 1)
            Select Case s
                Case 1 To MAXSEGM * 2 / 12
                    aSegments(s).colour = 1 'ivory
                Case MAXSEGM * 2 / 12 + 1 To MAXSEGM * 5 / 12
                    aSegments(s).colour = 2 'pink
                Case MAXSEGM * 5 / 12 + 1 To MAXSEGM * 8 / 12
                    aSegments(s).colour = 3 'blue
                Case MAXSEGM * 8 / 12 + 1 To MAXSEGM
                    aSegments(s).colour = 4 'purple
            End Select
            aSegments(s).Value = 0
        Next s
        aSegments(9).move(10, 8)
        aSegments(90).move(10, 9)
        For d = 1 To DEGREESOFCHAOS
            Randomize()
            Swap(Int(Rnd() * MAXSEGM) + 1, Int(Rnd() * MAXSEGM) + 1)
        Next d
    End Sub

    Sub segmentsFromBoard()
        'e.g. Having restored the board
        'update each piece based on it's position on the board
        Dim x As Short
        Dim y As Short
        Dim i As Short

        For x = 1 To oBoard.maxX 'each board position
            For y = 1 To oBoard.maxY
                i = oBoard.getGBoardID(x, y) 'NB IDs are 1 to 32
                If i > 0 Then 'if a piece is on it
                    aSegments(i).move(x, y)
                End If
            Next y
        Next x
    End Sub

    Sub setSegment(ByRef s As Short, ByRef aSegment As Segment)
        aSegments(s) = aSegment
    End Sub

    Sub setBoard(ByRef aBoard As Board)
        Dim i As Short

        oBoard = aBoard
        For i = 1 To MAXSEGM
            aSegments(i).setBoard(aBoard)
        Next i
    End Sub

    Sub Swap(ByRef i As Short, ByRef j As Short)
        'swap two segement positions during initialization
        Dim x As Short
        Dim y As Short

        x = aSegments(i).xPos
        y = aSegments(i).yPos
        aSegments(i).move((aSegments(j).xPos), (aSegments(j).yPos))
        aSegments(j).move(x, y)
    End Sub

    Public Sub New()
        'Initialize array of segments
        Dim i As Short

        For i = 1 To MAXSEGM
            aSegments(i) = New Segment
        Next i
    End Sub
End Class