Imports System.Xml.Serialization 'http://www.vb-helper.com/howto_net_serialize.html

<Serializable()> _ '// https: //msdn.microsoft.com/en-us/library/et91as27(v=vs.110).aspx
Public Class Game
    'Everything you need to save the state of the game
    Private ReadOnly mTurn As New Turn()
    Private ReadOnly mPPieces As New PPieces(12)
    Private ReadOnly mSegments As New Segments()
    Private ReadOnly mBoard As New Board()

    'Constructor
    Public Sub New()
        MyBase.New()
    End Sub

    Public Property History As String
    Public Property GameOver As Boolean 'Whether game is in progress or not

    Friend Sub GetBoard(aBoard As Board)
        mBoard.CopyTo(aBoard)
    End Sub

    Friend Sub GetPPieces(aPPieces As PPieces)
        mPPieces.CopyTo(aPPieces)
    End Sub

    Friend Sub GetSegments(aSegments As Segments)
        mSegments.CopyTo(aSegments)
    End Sub

    Friend Sub GetTurn(aTurn As Turn)
        mTurn.CopyTo(aTurn) 'Includes Player information
    End Sub

    Friend Sub SetBoard(aBoard As Board)
        aBoard.CopyTo(mBoard)
    End Sub

    Friend Sub SetPPieces(aPPieces As PPieces)
        aPPieces.CopyTo(mPPieces)
    End Sub

    Friend Sub SetSegments(aSegments As Segments)
        aSegments.CopyTo(mSegments)
    End Sub

    Friend Sub SetTurn(aTurn As Turn)
        aTurn.CopyTo(mTurn) 'Includes Player information
    End Sub

End Class
