Option Strict Off
Option Explicit On
Friend Class PPieces
	'The collection of all player pieces
	Private Const cMAXPPIECES As Short = 24 '6 player pieces per player
	Private ReadOnly mPieces(cMAXPPIECES) As PPiece 'New PPiece

	'Constructor
	Public Sub New(maxTowerHeight As Short)
		MyBase.New()
		Dim p As Short

		For p = 1 To cMAXPPIECES
			mPieces(p) = New PPiece(maxTowerHeight)
		Next p
	End Sub

	Public Sub Draw()
		Dim p As Short

		For p = 1 To cMAXPPIECES
			mPieces(p).Draw()
		Next p
	End Sub

	Public Property MaxHeight() As Short
		Get
			MaxHeight = mPieces(1).GetTower.MaxHeight
		End Get
		Set(value As Short)
			Dim p As Short
			For p = 1 To cMAXPPIECES
				mPieces(1).GetTower.MaxHeight = value
			Next p
		End Set
	End Property

	Public ReadOnly Property MaxPPieces() As Short
		'This is the number of player pieces each player has
		Get
			MaxPPieces = cMAXPPIECES
		End Get
	End Property

	Public Sub ReSize()
		Dim p As Short

		For p = 1 To cMAXPPIECES
			mPieces(p).Resize()
		Next p
	End Sub

	Public Function GetPiece(ByRef p As Short) As PPiece
		GetPiece = mPieces(p)
	End Function

	Public Sub Setup(ByRef aBoard As Board)
		'
		Dim p As Short

		For p = 1 To cMAXPPIECES
			mPieces(p).SetBoard(aBoard)
			mPieces(p).RemoveAll() 'empty Tower, update Colour and Description
			mPieces(p).UpdateTooltip() 'Can't be part of RemoveAll because that's called by a New routine ultimately called by New of frmDiscon (Causes Recursion - Stack Overflow)
			mPieces(p).PPID = p 'assign index from control to object
			mPieces(p).Owner = Int((p - 1) / 6) + 1
			mPieces(p).GetTower.Owner = mPieces(p).Owner
			Select Case mPieces(p).Owner
				Case 1
					mPieces(p).XPos = 1
					mPieces(p).YPos = 1
				Case 2
					mPieces(p).XPos = 1
					mPieces(p).YPos = 10
				Case 3
					mPieces(p).XPos = 10
					mPieces(p).YPos = 10
				Case 4
					mPieces(p).XPos = 10
					mPieces(p).YPos = 1
				Case Else 'Something went wrong
					MsgBox("aPieces(" & p & ").Owner = " & mPieces(p).Owner)
					mPieces(p).XPos = 5
					mPieces(p).YPos = 5
			End Select
			mPieces(p).Draw()
		Next p
	End Sub

	Sub SetBoard(ByRef aBoard As Board)
		Dim p As Short

		aBoard = aBoard
		For p = 1 To cMAXPPIECES
			mPieces(p).SetBoard(aBoard)
		Next p
	End Sub

	Sub SetPieces(ByRef p As Short, ByRef aPiece As PPiece)
		mPieces(p) = aPiece
	End Sub

	Friend Function IsOccupied(pPiece As PPiece) As Boolean
		'Check that other player pieces are not there 
		Dim p As Short

		IsOccupied = False
		For p = 1 To cMAXPPIECES
			If mPieces(p).PPID <> pPiece.PPID Then 'obviously not including self
				If mPieces(p).XPos = pPiece.XPos And mPieces(p).YPos = pPiece.YPos Then
					IsOccupied = True
					Debug.Print("Occupied. ")
					Exit Function
				End If
			End If
		Next p
	End Function
End Class