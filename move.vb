Option Strict Off
Option Explicit On
Friend Class move
	
    Dim oPPiece As PPiece 'a player piece (incl. current position and tower)
    Dim oSourcePos As New Position 'from it's source
    Dim oSourceTower As Tower 'what the tower looked like before
	
	Public Sub move(ByRef aPiece As PPiece, ByRef aPosition As Position)
        oSourcePos.xPos = aPiece.xPos 'should modify aPiece to contain a position object
        oSourcePos.yPos = aPiece.yPos
        oSourceTower = aPiece.getTower
		MsgBox(oSourceTower.height)
	End Sub
End Class