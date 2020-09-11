Option Strict Off
Option Explicit On
Friend Class Tower

    Private sTower(12) As Segment 'Pointers to Segments
    Private iXPos As Short 'horizontal position from 1 to Max position
    Private iYPos As Short 'vertical position from 1 to Max position
    Private iValue As Short 'score for this tower
    Private iOwner As Short 'player number 1 to 4
    Private iColour As Short '
    Private tColours() As String = {"none", "ivory", "pink", "blue", "violet", "ivory-pink", "ivory-blue", "ivory-violet", "pink-blue", "pink-violet", "blue-violet", "mixed"}

    Enum TColour
        none = 0
        ivory = 1
        pink = 2
        blue = 3
        violet = 4
        ivorypink = 5
        ivoryblue = 6
        ivoryViolet = 7
        pinkblue = 8
        pinkViolet = 9
        blueViolet = 10
        mixed = 11
    End Enum

    'Constructor
    Public Sub New()
        iXPos = 0
        iYPos = 0
        iValue = 0
        iOwner = 0
        Height = 0
    End Sub

    'Properties
    Public Property Description() As String 'description is a series of letters denoting colours
    Public Property MaxHeight() As String
    Public Property Message() As String 'e.g. pass back error message

    Public ReadOnly Property Colour() As String
        Get
            Colour = tColours(iColour)
        End Get
    End Property

    Public Property Height() As Short 'Number of discs in tower

    Public Property Owner() As Short
        Get
            Owner = iOwner
        End Get
        Set(ByVal Value As Short)
            iOwner = Value
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

    Public Property XPos() As Short
        Get
            XPos = iXPos
        End Get
        Set(ByVal Value As Short)
            iXPos = Value
        End Set
    End Property

    Public Property YPos() As Short
        Get
            YPos = iYPos
        End Get
        Set(ByVal Value As Short)
            iYPos = Value
        End Set
    End Property

    'Methods (alphabetical)
    Public Function Add(ByRef nSegment As Segment) As Boolean
        'Add the passed disc to the end of the tower array
        If Height < MaxHeight Then
            Height += 1
            sTower(Height) = nSegment 'set pointer to Segment
            SetVerticalHeights()
            iColour = CheckColours()
            UpdateScore()
            Add = True
        Else
            Message = "You can't add that disc due to height restrictions."
            Add = False
        End If
    End Function

    Public Sub SetVerticalHeights()
        Dim i As Integer = Nothing
        For i = 1 To Height
            sTower(i).VerticalPos = Height - (i - 1) 'sTower(1) was the first added. It is at VerticalPos = Height, 
        Next
    End Sub

    Public Function CheckColours() As Short
        'Determine iColour (and build description)
        Dim i As Short
        Dim colour1 As Short = 0
        Dim colour2 As Short = 0
        Dim oneTwoMany As Short = 0 '1 Single, 2 Mixed, > 2 Multicolour without value
        'none = 0, ivory = 1, pink = 2, blue = 3, violet = 4, ivorypink = 5, ivoryblue = 6, ivoryViolet = 7, pinkblue = 8, pinkViolet = 9, blueViolet = 10, multi = 11
        Description = "" 'description is a series of letters denoting colours
        If Height > 0 Then
            oneTwoMany = 1
            colour1 = sTower(1).Colour
            Description += Left(tColours(sTower(1).Colour), 1)
            If Height > 1 Then
                If sTower(2).Colour <> colour1 Then 'Tower is mixed 
                    oneTwoMany = 2
                    colour2 = sTower(2).Colour 'remember 2nd colour
                End If
                Description += Left(tColours(sTower(2).Colour), 1)
                If Height > 2 Then
                    For i = 3 To Height
                        Description += Left(tColours(sTower(i).Colour), 1)
                        If sTower(i).Colour <> colour1 And sTower(i).Colour <> colour2 Then
                            oneTwoMany = 3 'Tower is multicoloured and of no value
                        End If
                    Next
                End If
            End If
        End If
        Select Case oneTwoMany
            Case 0 'no tower
                CheckColours = 0
            Case 1 'single
                CheckColours = colour1
            Case 2 'two colours
                Select Case colour1 '1 White, 2 Pink, 3 Blue, 4 Violet
                    Case 1 'White
                        Select Case colour2
                            Case 2 'Pink
                                CheckColours = 5
                            Case 3 'Blue
                                CheckColours = 6
                            Case 4 'Violet
                                CheckColours = 7
                        End Select
                    Case 2 'Pink
                        Select Case colour2
                            Case 1 'White
                                CheckColours = 5
                            Case 3 'Blue
                                CheckColours = 8
                            Case 4 'Violet
                                CheckColours = 9
                        End Select
                    Case 3 'Blue
                        Select Case colour2
                            Case 1 'White
                                CheckColours = 6
                            Case 2 'Pink
                                CheckColours = 8
                            Case 4 'Violet
                                CheckColours = 10
                        End Select
                    Case 4 'Violet
                        Select Case colour2
                            Case 1 'W
                                CheckColours = 7
                            Case 2 'P
                                CheckColours = 9
                            Case 3 'B
                                CheckColours = 10
                        End Select
                End Select
            Case 3 'Multi
                CheckColours = 11
        End Select
    End Function

    Public Sub CopyTo(ByRef aTower As Tower)
        'copy from this tower to the passed (destination) tower
        Dim i As Short

        'remove existing discs from passed tower
        Do While aTower.Height > 0
            aTower.Remove()
        Loop
        For i = 1 To Height 'of source tower
            If sTower(i).XPos = 0 Then 'Just in case there's a problem with segments in this tower...
                MsgBox("sTower(" & i & ") = Nothing")
            End If
            aTower.SetSegment(i, sTower(i)) 'point to segments
        Next i
        aTower.Owner = iOwner
        aTower.Value = iValue
        aTower.Height = Height
        aTower.XPos = iXPos
        aTower.YPos = iYPos
        aTower.CheckColours() 'The colour and description may have changed
        aTower.SetVerticalHeights() 'The vertical height may have changed (i.e. if tower shrunk)
        aTower.UpdateScore() 'The score of the tower should have changed.
    End Sub

    Public Sub Display()
        'draw all the discs with an offset
        'disc one is up the top
        Dim i As Short

        For i = 1 To Height
            sTower(i).DrawOffset(Height - i)
        Next i
    End Sub

    Public Sub Draw()
        'draw all the tiles in their normal (hidden) position
        Dim i As Short

        For i = 1 To Height
            sTower(i).Draw()
        Next i
    End Sub

    Public Function GetSegment(ByRef i As Short) As Segment
        GetSegment = sTower(i)
    End Function

    Public Sub Move(ByRef xDest As Short, ByRef yDest As Short)
        'move the tower (each disc is drawn in it's new position)
        Dim i As Short

        For i = 1 To Height
            sTower(i).Move(xDest, yDest)
        Next i
    End Sub

    Public Function IDExists(ByRef id As Short)
        Dim s As Short

        IDExists = False

        For s = 1 To Height
            If sTower(s).ID = id Then
                IDExists = True
            End If
        Next
    End Function

    Public Sub UpdateScore() 'Look up value based on iColour and height
        Select Case iColour
            Case TColour.blueViolet, TColour.pinkViolet '    	2	3	4	5	6	8	10	12	14	16	20
                Select Case Height
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
            Case TColour.blueViolet '                        	2	3	4	5	6	8	10	12	14	16	20
                Select Case Height
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
            Case TColour.pinkblue '                           	2	4	6	8	10	12	16	20	24	28	32
                Select Case Height
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
            Case TColour.ivoryViolet '                       	4	6	8	10	12	16	18	22	26	30	34
                Select Case Height
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
            Case TColour.ivorypink, TColour.ivoryblue '      	4	6	8	11	14	18	22	28	34	40	48
                Select Case Height
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
            Case TColour.violet '                           2	4	6	8	11	14	18	24	34	40	50	60
                Select Case Height
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
            Case TColour.pink, TColour.blue '               4	8	12	18	24	32	42	54	68	84	100	120
                Select Case Height
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
            Case TColour.ivory '                            8	16	24	36	52	72	96	120	148	176	208	240
                Select Case Height
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

    Public Sub Remove()
        'remove the last/bottom disc from the tower 'Note: top segment in tower has index 1, bottom segment in index = height
        If Height > 0 Then
            sTower(Height) = Nothing 'set pointer to nothing
            Height -= 1
        End If
        UpdateScore()
        'SetVerticalHeights() 'Don't adjust Vertical Height here. Just remove from piece. Since you can't undo the building the vertical height should remain unchanged.
    End Sub

    Public Sub SetSegment(ByRef i As Short, ByRef aSegment As Segment)
        sTower(i) = aSegment
    End Sub
End Class