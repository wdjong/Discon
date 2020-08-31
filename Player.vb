Option Strict Off
Option Explicit On
Friend Class Player
	
	Dim iStatus As Short '0 inactive, 1 human, 2 computer
	Dim sName As String
	Dim iPID As Short 'player ID
	Dim iScore As Short
	
    Public Property name() As String
        Get
            Return sName
        End Get
        Set(ByVal Value As String)
            sName = Value
        End Set
    End Property

    Public Property ID() As Short
        Get
            ID = iPID
        End Get
        Set(ByVal Value As Short)
            iPID = Value
        End Set
    End Property

    Public Property score() As Short
        Get
            score = iScore
        End Get
        Set(ByVal Value As Short)
            iScore = Value
        End Set
    End Property

    Public Property status() As Short
        Get
            status = iStatus
        End Get
        Set(ByVal Value As Short)
            iStatus = Value
        End Set
    End Property

    Private Sub Class_Initialize_Renamed()
        iPID = 0
        iScore = 0
        sName = ""
        iStatus = 0
    End Sub

    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub
End Class