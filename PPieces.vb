Option Strict Off
Option Explicit On
Friend Class PPieces
    'The collection of all player pieces
	Const MAXPPIECE As Short = 24 '4 Players each have 6 pieces
	Dim oBoard As Board
	Dim aPieces(MAXPPIECE) As PPiece 'New PPiece
	
	Sub draw()
		Dim p As Short
		
		For p = 1 To MAXPPIECE
			aPieces(p).draw()
		Next p
	End Sub
	
	Sub resize()
		Dim p As Short
		
		For p = 1 To MAXPPIECE
			aPieces(p).resize()
		Next p
	End Sub
	
	Function getPiece(ByRef p As Short) As PPiece
		getPiece = aPieces(p)
	End Function
	
	Sub setup(ByRef aBoard As Board)
		Dim p As Short
		
		oBoard = aBoard
		For p = 1 To MAXPPIECE
			aPieces(p).setBoard(aBoard)
			aPieces(p).removeAll()
			aPieces(p).pPID = p 'assign index from control to object
			aPieces(p).owner = Int((p - 1) / 6) + 1
			aPieces(p).getTower.owner = aPieces(p).owner
			Select Case aPieces(p).owner
				Case 1
					aPieces(p).xPos = 1
					aPieces(p).yPos = 1
				Case 2
					aPieces(p).xPos = 1
					aPieces(p).yPos = 10
				Case 3
					aPieces(p).xPos = 10
					aPieces(p).yPos = 10
				Case 4
					aPieces(p).xPos = 10
					aPieces(p).yPos = 1
			End Select
			aPieces(p).draw()
		Next p
	End Sub
	
	Sub setBoard(ByRef aBoard As Board)
		Dim p As Short
		
		aBoard = aBoard
		For p = 1 To MAXPPIECE
			aPieces(p).setBoard(aBoard)
		Next p
	End Sub
	
	Sub setPiece(ByRef p As Short, ByRef aPiece As PPiece)
		aPieces(p) = aPiece
	End Sub

    Public Sub New()
        Dim p As Short

        'oBoard = New Board
        For p = 1 To MAXPPIECE
            aPieces(p) = New PPiece
        Next p
    End Sub
End Class