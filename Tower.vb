Option Strict Off
Option Explicit On
Friend Class Tower
	
	Const MAXHEIGHT As Short = 12
	
	Dim sTower(MAXHEIGHT) As Segment 'Pointers to Segments
	Dim iXPos As Short 'horizontal position from 1 to Max position
	Dim iYPos As Short 'vertical position from 1 to Max position
	Dim iValue As Short 'score for this tower
	Dim iOwner As Short 'player number 1 to 4
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
        iXPos = 0
        iYPos = 0
        iValue = 0
        iOwner = 0
        height = 0
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

    Function Add(ByRef nSegment As Segment) As Boolean
        'Add the passed segment to the tower
        If height < MAXHEIGHT Then
            height = height + 1
            sTower(height) = nSegment 'set pointer to Segment
            Recalculate((sTower(height).colour))
            iColour = tcolours(nSegment.colour)
            Add = True
        Else
            MsgBox("You can't add that segment due to height restrictions.")
            Add = False
        End If
    End Function

    Sub CopyTo(ByRef aTower As Tower)
        'copy from this tower to the passed tower
        Dim i As Short

        'remove any existing segments
        Do While aTower.height > 0
            aTower.Remove()
        Loop
        For i = 1 To height
            If sTower(i).xPos = 0 Then
                MsgBox("sTower(" & i & ") = Nothing")
            End If
            aTower.SetSegment(i, sTower(i))
        Next i
        aTower.owner = iOwner
        aTower.Value = iValue
        aTower.height = height
        aTower.xPos = iXPos
        aTower.yPos = iYPos
    End Sub

    Sub Display()
        'draw all the segments with an offset
        'segment one is up the top
        Dim i As Short

        For i = 1 To height
            sTower(i).drawOffset(height - i)
        Next i
    End Sub

    Sub Draw()
        'draw all the tiles in their normal (hidden) position
        Dim i As Short

        For i = 1 To height
            sTower(i).draw()
        Next i
    End Sub

    Function GetSegment(ByRef i As Short) As Segment
        GetSegment = sTower(i)
    End Function

    Sub Move(ByRef xDest As Short, ByRef yDest As Short)
        'move the tower (each segment is drawn in it's new position)
        Dim i As Short

        For i = 1 To height
            sTower(i).move(xDest, yDest) 'each segment
        Next i
    End Sub

    Sub Recalculate(ByRef iColour As Short)
        Select Case iColour
            Case tColour.bluepurple, tColour.pinkpurple '    	2	3	4	5	6	8	10	12	14	16	20
                Select Case height
                    Case 0
                        iValue = 0
                    Case 1
                        iValue = 0
                    Case 2
                        iValue = 2
                    Case 3
                        iValue = 3
                    Case 4
                        iValue = 4
                    Case 5
                        iValue = 5
                    Case 6
                        iValue = 6
                    Case 7
                        iValue = 8
                    Case 8
                        iValue = 10
                    Case 9
                        iValue = 12
                    Case 10
                        iValue = 14
                    Case 11
                        iValue = 16
                    Case 12
                        iValue = 20
                End Select
            Case tColour.bluepurple '                        	2	3	4	5	6	8	10	12	14	16	20
                Select Case height
                    Case 0
                        iValue = 0
                    Case 1
                        iValue = 0
                    Case 2
                        iValue = 2
                    Case 3
                        iValue = 3
                    Case 4
                        iValue = 4
                    Case 5
                        iValue = 5
                    Case 6
                        iValue = 6
                    Case 7
                        iValue = 8
                    Case 8
                        iValue = 10
                    Case 9
                        iValue = 12
                    Case 10
                        iValue = 14
                    Case 11
                        iValue = 16
                    Case 12
                        iValue = 20
                End Select
            Case tColour.pinkblue '                           	2	4	6	8	10	12	16	20	24	28	32
                Select Case height
                    Case 0
                        iValue = 0
                    Case 1
                        iValue = 0
                    Case 2
                        iValue = 2
                    Case 3
                        iValue = 4
                    Case 4
                        iValue = 6
                    Case 5
                        iValue = 8
                    Case 6
                        iValue = 10
                    Case 7
                        iValue = 12
                    Case 8
                        iValue = 16
                    Case 9
                        iValue = 20
                    Case 10
                        iValue = 24
                    Case 11
                        iValue = 28
                    Case 12
                        iValue = 32
                End Select
            Case tColour.ivorypurple '                       	4	6	8	10	12	16	18	22	26	30	34
                Select Case height
                    Case 0
                        iValue = 0
                    Case 1
                        iValue = 0
                    Case 2
                        iValue = 4
                    Case 3
                        iValue = 6
                    Case 4
                        iValue = 8
                    Case 5
                        iValue = 10
                    Case 6
                        iValue = 12
                    Case 7
                        iValue = 16
                    Case 8
                        iValue = 18
                    Case 9
                        iValue = 22
                    Case 10
                        iValue = 26
                    Case 11
                        iValue = 30
                    Case 12
                        iValue = 34
                End Select
            Case tColour.ivorypink, tColour.ivoryblue '      	4	6	8	11	14	18	22	28	34	40	48
                Select Case height
                    Case 0
                        iValue = 0
                    Case 1
                        iValue = 0
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
                        iValue = 22
                    Case 9
                        iValue = 28
                    Case 10
                        iValue = 34
                    Case 11
                        iValue = 40
                    Case 12
                        iValue = 48
                End Select
            Case tColour.purple '                           2	4	6	8	11	14	18	24	34	40	50	60
                Select Case height
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
            Case tColour.pink, tColour.blue '               4	8	12	18	24	32	42	54	68	84	100	120
                Select Case height
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
            Case tColour.ivory '                            8	16	24	36	52	72	96	120	148	176	208	240
                Select Case height
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
            Case Else
                iValue = 0
        End Select
    End Sub

    Sub Remove()
        'remove the last segment from the tower
        If height > 0 Then
            sTower(height) = Nothing 'set pointer to nothing
            height = height - 1
        End If
        If height > 0 Then
            Recalculate((sTower(height).colour))
        Else
            iValue = 0
        End If
    End Sub

    Sub SetSegment(ByRef i As Short, ByRef aSegment As Segment)
        sTower(i) = aSegment
    End Sub
End Class