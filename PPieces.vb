Option Strict Off
Option Explicit On
Friend Class PPieces
    'The collection of all player pieces
	Const MAXPPIECE As Short = 24 '4 Players each have 6 pieces
	Dim aPieces(MAXPPIECE) As PPiece 'New PPiece

	Public Sub New(maxTowerHeight As Short)
		MyBase.New()
		Dim p As Short

		For p = 1 To MAXPPIECE
			aPieces(p) = New PPiece(maxTowerHeight)
		Next p
	End Sub

	Sub draw()
		Dim p As Short

		For p = 1 To MAXPPIECE
			aPieces(p).Draw()
		Next p
	End Sub

	Public Property MaxHeight() As Short
		Get
			MaxHeight = aPieces(1).GetTower.MaxHeight
		End Get
		Set(value As Short)
			Dim p As Short
			For p = 1 To MAXPPIECE
				aPieces(1).GetTower.MaxHeight = value
			Next p
		End Set
	End Property

	Sub resize()
		Dim p As Short
		
		For p = 1 To MAXPPIECE
			aPieces(p).Resize()
		Next p
	End Sub
	
	Function getPiece(ByRef p As Short) As PPiece
		getPiece = aPieces(p)
	End Function

	Sub setup(ByRef aBoard As Board)
		'
		Dim p As Short

		For p = 1 To MAXPPIECE
			aPieces(p).SetBoard(aBoard)
			aPieces(p).RemoveAll() 'empty Tower, update Colour and Description
			aPieces(p).UpdateTooltip() 'Can't be part of RemoveAll because that's called by a New routine ultimately called by New of frmDiscon (Causes Recursion - Stack Overflow)
			aPieces(p).PPID = p 'assign index from control to object
			aPieces(p).Owner = Int((p - 1) / 6) + 1
			aPieces(p).GetTower.Owner = aPieces(p).Owner
			Select Case aPieces(p).Owner
				Case 1
					aPieces(p).XPos = 1
					aPieces(p).YPos = 1
				Case 2
					aPieces(p).XPos = 1
					aPieces(p).YPos = 10
				Case 3
					aPieces(p).XPos = 10
					aPieces(p).YPos = 10
				Case 4
					aPieces(p).XPos = 10
					aPieces(p).YPos = 1
				Case Else 'Something went wrong
					MsgBox("aPieces(" & p & ").Owner = " & aPieces(p).Owner)
					aPieces(p).XPos = 5
					aPieces(p).YPos = 5
			End Select
			aPieces(p).Draw()
		Next p
	End Sub

	Sub setBoard(ByRef aBoard As Board)
		Dim p As Short
		
		aBoard = aBoard
		For p = 1 To MAXPPIECE
			aPieces(p).SetBoard(aBoard)
		Next p
	End Sub
	
	Sub setPiece(ByRef p As Short, ByRef aPiece As PPiece)
		aPieces(p) = aPiece
	End Sub


End Class