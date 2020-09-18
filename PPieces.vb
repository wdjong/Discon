'Option Strict Off
'Option Explicit On
Imports System.Xml.Serialization 'http://www.vb-helper.com/howto_net_serialize.html

<Serializable()> _ '// https: //msdn.microsoft.com/en-us/library/et91as27(v=vs.110).aspx
Public Class PPieces
	'The collection of all player pieces
	Private Const cMAXPPIECES As Short = 24 '6 player pieces per player
	Private ReadOnly mPieces(cMAXPPIECES) As PPiece 'New PPiece

	'Constructor
	Public Sub New(maxTowerHeight As Short)
		MyBase.New()
		Dim p As Short

		For p = 1 To cMAXPPIECES
			mPieces(p) = New PPiece(p, maxTowerHeight) 'sets owner and initial position
			mPieces(p).GetTowerRef.Owner = mPieces(p).Owner
		Next p
	End Sub

	'Properties
	Public Property MaxHeight() As Short
		Get
			MaxHeight = mPieces(1).GetTowerRef.MaxHeight
		End Get
		Set(value As Short)
			Dim p As Short
			For p = 1 To cMAXPPIECES
				mPieces(1).GetTowerRef.MaxHeight = value
			Next p
		End Set
	End Property

	Public Property Message() As String

	Public ReadOnly Property MaxPPieces() As Short
		'This is the number of player pieces each player has
		Get
			MaxPPieces = cMAXPPIECES
		End Get
	End Property

	'Methods
	Friend Sub CopyTo(DestPPieces As PPieces)
		'Copy piece objects to Destination PPiece collection
		Dim p As Short

		For p = 1 To cMAXPPIECES
			GetPieceRef(p).CopyTo(DestPPieces.GetPieceRef(p))
		Next p
	End Sub

	Public Sub UpdateControlPositions()
		Dim p As Short

		For p = 1 To cMAXPPIECES
			mPieces(p).UpdateControlPosition()
		Next p
	End Sub

	Public Function GetPieceRef(ByRef p As Short) As PPiece
		GetPieceRef = mPieces(p)
	End Function

	Friend Function IsOccupied(pPiece As PPiece) As Boolean
		'Check that other player pieces are not there 
		Dim p As Short

		IsOccupied = False
		For p = 1 To cMAXPPIECES
			If mPieces(p).PPID <> pPiece.PPID Then 'obviously not including self
				If mPieces(p).XPos = pPiece.XPos And mPieces(p).YPos = pPiece.YPos Then
					IsOccupied = True
					'Debug.Print("Occupied. ")
					Exit Function
				End If
			End If
		Next p
	End Function
	Friend Function IsOccupiedXY(pPiece As PPiece, XPos As Short, YPos As Short) As Boolean
		'Use this prior to moving
		Dim p As Short

		IsOccupiedXY = False
		For p = 1 To cMAXPPIECES
			If mPieces(p).PPID <> pPiece.PPID Then 'obviously not including self
				If mPieces(p).XPos = XPos And mPieces(p).YPos = YPos Then
					IsOccupiedXY = True
					'Debug.Print("Occupied. ")
					Exit Function
				End If
			End If
		Next p
	End Function


	Public Sub ReSize()
		'This assumes the player piece as it's ID setup
		Dim p As Short

		For p = 1 To cMAXPPIECES
			mPieces(p).Resize()
		Next p
	End Sub

	Sub SetBoardRef(ByRef aBoard As Board)
		Dim p As Short

		For p = 1 To cMAXPPIECES
			mPieces(p).SetBoardRef(aBoard)
		Next p
	End Sub

	Friend Sub Setup(maxTowerHeight As Short)
		Dim p As Short

		For p = 1 To cMAXPPIECES
			mPieces(p).Init(p, maxTowerHeight) 'sets owner and initial position
		Next p
	End Sub

	Friend Function GetBoardRef() As Board
		GetBoardRef = mPieces(1).GetBoardRef()
	End Function

	Friend Function InForeignHome(pPiece As PPiece) As Boolean
		'Check other pieces belonging to this player are not in a foreign home
		Dim p As Short

		InForeignHome = False
		For p = 1 To cMAXPPIECES
			If mPieces(p).Owner = pPiece.Owner And mPieces(p).PPID <> pPiece.PPID Then
				If mPieces(p).InForeignHome Then
					InForeignHome = True
				End If
			End If
        Next
	End Function

	'Sub SetPieces(ByRef p As Short, ByRef aPiece As PPiece)
	'	mPieces(p) = aPiece
	'End Sub

	'Public Sub Setup(ByRef aBoard As Board)
	'	'
	'	Dim p As Short

	'	For p = 1 To cMAXPPIECES
	'		'mPieces(p).SetBoardRef(aBoard)
	'		'mPieces(p).RemoveAll() 'empty Tower, update Colour and Description
	'		'mPieces(p).UpdateTooltip() 'Can't be part of RemoveAll because that's called by a New routine ultimately called by New of frmDiscon (Causes Recursion - Stack Overflow)
	'		'mPieces(p).PPID = p 'assign index from control to object
	'		'mPieces(p).Owner = Int((p - 1) / 6) + 1
	'		'mPieces(p).GetTower.Owner = mPieces(p).Owner
	'		'Select Case mPieces(p).Owner 'In New
	'		'	Case 1
	'		'		mPieces(p).XPos = 1
	'		'		mPieces(p).YPos = 1
	'		'	Case 2
	'		'		mPieces(p).XPos = 1
	'		'		mPieces(p).YPos = 10
	'		'	Case 3
	'		'		mPieces(p).XPos = 10
	'		'		mPieces(p).YPos = 10
	'		'	Case 4
	'		'		mPieces(p).XPos = 10
	'		'		mPieces(p).YPos = 1
	'		'	Case Else 'Something went wrong
	'		'		MsgBox("aPieces(" & p & ").Owner = " & mPieces(p).Owner)
	'		'		mPieces(p).XPos = 5
	'		'		mPieces(p).YPos = 5
	'		'End Select
	'		'mPieces(p).Draw() 'In Draw
	'	Next p
	'End Sub

End Class