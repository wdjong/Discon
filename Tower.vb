Option Strict Off
Option Explicit On
Friend Class Tower
	
	Const MAXHEIGHT As Short = 12
	
	Dim sTower(MAXHEIGHT) As Segment 'Pointers to Segments
	Dim iXPos As Short 'horizontal position from 1 to Max position
	Dim iYPos As Short 'vertical position from 1 to Max position
	Dim iValue As Short 'score for this tower
	Dim iOwner As Short 'player number 1 to 4
	Dim iHeight As Short '1 to MAXTOWER
    Dim iColour As String '"", "ivory", "pink", "blue", "purple"
    Dim tcolours() As String = {"none", "ivory", "pink", "blue", "purple", "ivory-pink", "ivory-blue", "ivory-purple", "pink-blue", "pink-purple", "blue-purple", "mixed"}

    Enum tColour
        none = 0
        ivory = 1
        pink = 2
        blue = 3
        purple = 4
        ivorypink = 5
        ivoryblue = 6
        ivorypurple = 7
        pinkblue = 8
        pinkpurple = 9
        bluepurple = 10
        mixed = 11
    End Enum

    Public Sub New()
        'MyBase.New()
        'Dim i As Short

        'For i = 1 To iHeight
        'sTower(i) = New Segment
        'Next i
        iXPos = 0
        iYPos = 0
        iValue = 0
        iOwner = 0
        iHeight = 0
    End Sub

    Public Property owner() As Short
        Get
            owner = iOwner
        End Get
        Set(ByVal Value As Short)
            iOwner = Value
        End Set
    End Property

    Public Property height() As Short
        Get
            Return iHeight
        End Get
        Set(ByVal Value As Short)
            iHeight = Value
        End Set
    End Property

    Public Property Value() As Short
        Get
            Value = iValue
        End Get
        Set(ByVal Value As Short)
            iValue = Value
        End Set
    End Property

    Public Property xPos() As Short
        Get
            xPos = iXPos
        End Get
        Set(ByVal Value As Short)
            iXPos = Value
        End Set
    End Property

    Public Property yPos() As Short
        Get
            yPos = iYPos
        End Get
        Set(ByVal Value As Short)
            iYPos = Value
        End Set
    End Property

    Public Property colour() As String
        Get
            colour = iColour
        End Get
        Set(ByVal value As String)
            iColour = colour
        End Set
    End Property

    Function add(ByRef nSegment As Segment) As Boolean
        'Add the passed segment to the tower
        If iHeight < MAXHEIGHT Then
            iHeight = iHeight + 1
            sTower(iHeight) = nSegment 'set pointer to Segment
            recalculate((sTower(iHeight).colour))
            iColour = tcolours(nSegment.colour)
            add = True
        Else
            MsgBox("You can't add that segment due to height restrictions.")
            add = False
        End If
    End Function

    Sub copyTo(ByRef aTower As Tower)
        'copy from this tower to the passed tower
        Dim i As Short

        'remove any existing segments
        Do While aTower.height > 0
            aTower.remove()
        Loop
        For i = 1 To iHeight
            If sTower(i).xPos = 0 Then
                MsgBox("sTower(" & i & ") = Nothing")
            End If
            'aTower.add sTower(i)
            aTower.setSegment(i, sTower(i))
            'MsgBox aTower.getSegment(i).xPos '= sTower(i).xPos
            'aTower.getSegment(i).yPos = sTower(i).yPos
        Next i
        aTower.owner = iOwner
        aTower.Value = iValue
        aTower.height = iHeight
        aTower.xPos = iXPos
        aTower.yPos = iYPos
    End Sub

    Sub display()
        'draw all the segments with an offset
        'segment one is up the top
        Dim i As Short

        For i = 1 To iHeight
            sTower(i).drawOffset(height - i)
        Next i
    End Sub

    Sub draw()
        'draw all the tiles in their normal (hidden) position
        Dim i As Short

        For i = 1 To iHeight
            sTower(i).draw()
        Next i
    End Sub

    Function getSegment(ByRef i As Short) As Segment
        getSegment = sTower(i)
    End Function

    Sub move(ByRef xDest As Short, ByRef yDest As Short)
        'move the tower (each segment is drawn in it's new position)
        Dim i As Short

        For i = 1 To iHeight
            sTower(i).move(xDest, yDest) 'each segment
        Next i
    End Sub

    Sub recalculate(ByRef iColour As Short)
        Select Case iColour
            Case tColour.ivory 'ivory
                Select Case iHeight
                    Case 0
                        iValue = 0
                    Case 1
                        iValue = 8
                    Case 2
                        iValue = 16
                    Case 3
                        iValue = 24
                    Case 4
                        iValue = 36
                    Case 5
                        iValue = 52
                    Case 6
                        iValue = 72
                    Case 7
                        iValue = 96
                    Case 8
                        iValue = 120
                    Case 9
                        iValue = 148
                    Case 10
                        iValue = 176
                    Case 11
                        iValue = 208
                    Case 12
                        iValue = 240
                End Select
            Case tColour.pink, tColour.blue
                Select Case iHeight
                    '4  8  12 18 24 32 42 54 68 84 100   120
                    Case 0
                        iValue = 0
                    Case 1
                        iValue = 4
                    Case 2
                        iValue = 8
                    Case 3
                        iValue = 12
                    Case 4
                        iValue = 18
                    Case 5
                        iValue = 24
                    Case 6
                        iValue = 32
                    Case 7
                        iValue = 42
                    Case 8
                        iValue = 54
                    Case 9
                        iValue = 68
                    Case 10
                        iValue = 84
                    Case 11
                        iValue = 100
                    Case 12
                        iValue = 120
                End Select
            Case tColour.purple
                Select Case iHeight
                    '2  4  6  8  11 14 18 24 34 40 50 60
                    Case 0
                        iValue = 0
                    Case 1
                        iValue = 2
                    Case 2
                        iValue = 4
                    Case 3
                        iValue = 6
                    Case 4
                        iValue = 8
                    Case 5
                        iValue = 11
                    Case 6
                        iValue = 14
                    Case 7
                        iValue = 18
                    Case 8
                        iValue = 24
                    Case 9
                        iValue = 34
                    Case 10
                        iValue = 40
                    Case 11
                        iValue = 50
                    Case 12
                        iValue = 60
                End Select
            Case Else
                iValue = 0
        End Select
    End Sub

    Sub remove()
        'remove the last segment from the tower
        If iHeight > 0 Then
            sTower(iHeight) = Nothing 'set pointer to nothing
            iHeight = iHeight - 1
        End If
        If iHeight > 0 Then
            recalculate((sTower(iHeight).colour))
        Else
            iValue = 0
        End If
    End Sub

    Sub setSegment(ByRef i As Short, ByRef aSegment As Segment)
        sTower(i) = aSegment
    End Sub
End Class