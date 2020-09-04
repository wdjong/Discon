Option Strict Off
Option Explicit On
Friend Class Player
	
	Dim iStatus As Short '0 inactive, 1 human, 2 computer
    Dim iPID As Short 'player ID
    Dim iScore As Short

    Public Property Name() As String

    Public Property ID() As Short
        Get
            ID = iPID
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

    Public Sub New()
        MyBase.New()
        iPID = 0
        iScore = 0
        Name = ""
        iStatus = 0
    End Sub
End Class