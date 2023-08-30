Class Grouping
    Structure Group
        Dim Squares() As Integer
        Dim Squ_Cnt As Integer
    End Structure
    Structure Intersection
        Dim Connected() As Integer
    End Structure

    Public Groups() As Group
    Public Inters() As Intersection
    Dim Group_Cnt As Integer
    Dim Gr_Squares() As Integer

    Public Function Group_Squares(ByVal Num_Squares As Integer) As Integer
        Dim Gr_Index As Integer
        ReDim Gr_Squares(Num_Squares)
        For x = 0 To Num_Squares - 1
            Gr_Squares(x) = -1
        Next
        Group_Cnt = 0
        For x = 0 To Num_Squares - 1
            If (Gr_Squares(x) = -1) Then
                If (Form1.Board1.TheBoard.Squares(x).Tag = -1) Then
                    If ((Form1.Board1.Check_Single_Square(x)) >= 2) Then
                        Gr_Index = New_Group()
                        Fill_Group(Gr_Index, x)
                    End If
                End If
            End If
        Next
        Deal_Intr()
        Return 1
    End Function

    Public Sub Show_Groups()
        Dim Colour As Color
        For x = 0 To Groups.Length - 1
            Colour = Color.FromArgb(255 * Rnd(), 255 * Rnd(), 255 * Rnd())
            For y = 0 To Groups(x).Squares.Length - 1
                Form1.Board1.TheBoard.Squares(Groups(x).Squares(y)).FillColor = Colour
            Next
        Next
    End Sub

    Public Sub Recalculate()
        Dim Num_Squares As Integer = Form1.Board1.TheBoard.Square_Cnt
        Dim Gr_Index As Integer
        Array.Clear(Groups, 0, Groups.Length)
        For x = 0 To Num_Squares - 1
            Gr_Squares(x) = -1
        Next
        Group_Cnt = 0
        For x = 0 To Num_Squares - 1
            If (Gr_Squares(x) = -1) Then
                If (Form1.Board1.TheBoard.Squares(x).Tag = -1) Then
                    If ((Form1.Board1.Check_Single_Square(x)) >= 2) Then
                        Gr_Index = New_Group()
                        Fill_Group(Gr_Index, x)
                    End If
                End If
            End If
        Next
        Deal_Intr()
    End Sub

    Public Function Get_Smallest_Group()
        Dim Lowest As Integer = 0
        For x = 0 To Group_Cnt - 1
            If (Groups(x).Squ_Cnt < Groups(Lowest).Squ_Cnt) Then
                Lowest = x
            End If
        Next
        Return Lowest
    End Function

    Public Function Get_Line_In_Group(ByVal Gr_Index As Integer)
        Dim Random As Integer
        Dim Sq_Index As Integer
        Dim Line_Num As Integer = -1
        Dim Good As Boolean

        For z = 0 To Groups(Gr_Index).Squ_Cnt - 1
            Sq_Index = Groups(Gr_Index).Squares(z)
            Good = True 'assume the square is okay
            For x = 0 To Group_Cnt - 1
                If (x <> Gr_Index) Then
                    For y = 0 To Groups(x).Squ_Cnt - 1
                        If (Groups(x).Squares(y) = Sq_Index) Then
                            Good = False
                            Exit For
                        End If
                    Next
                End If
                If (Good = False) Then
                    Exit For
                End If
            Next
            If (Good) Then
                If (Form1.Board1.Check_Single_Square(Sq_Index) <= 1) Then
                    Good = False
                End If
            End If
        Next
        
        'The square in question is good, pick a line
        If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Top).Tag = 0) Then
            Return Form1.Board1.Square_Lines(Sq_Index).Top
        End If
        If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Left).Tag = 0) Then
            Return Form1.Board1.Square_Lines(Sq_Index).Left
        End If
        If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Right).Tag = 0) Then
            Return Form1.Board1.Square_Lines(Sq_Index).Right
        End If
        If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Bottom).Tag = 0) Then
            Return Form1.Board1.Square_Lines(Sq_Index).Bottom
        End If
        Return -1
    End Function

    Private Function New_Group()
        ReDim Preserve Groups(Group_Cnt)
        Dim Group_Index As Integer = Groups.Length - 1
        Group_Cnt += 1
        Return Group_Index
    End Function

    Private Function Add_Square(ByVal Gr_Index As Integer)
        ReDim Preserve Groups(Gr_Index).Squares(Groups(Gr_Index).Squ_Cnt)
        Dim Sq_Index As Integer = Groups(Gr_Index).Squares.Length - 1
        Groups(Gr_Index).Squ_Cnt += 1
        Return Sq_Index
    End Function

    Private Function Is_Square_In_Group(ByVal Sq_Index As Integer, ByVal Gr_Index As Integer) As Boolean
        If (Gr_Squares(Sq_Index) = Gr_Index) Then
            Return True
        End If
        Return False
    End Function

    Private Sub Add_Group_To_Group(ByVal Gr1 As Integer, ByVal Gr2 As Integer)
        For x = 0 To Groups(Gr2).Squ_Cnt - 1
            Dim New_Square = Add_Square(Gr1)
            Groups(Gr1).Squares(New_Square) = Groups(Gr2).Squares(x)
        Next
    End Sub

    Private Sub Deal_Intr()
        Dim Done As Boolean
        For x = 0 To Form1.Board1.TheBoard.Square_Cnt - 1
            If (Gr_Squares(x) = -1) And (Form1.Board1.TheBoard.Squares(x).Tag = -1) Then
                'Then this is an intersection
                Dim Num_Lines = 4 - Form1.Board1.Check_Single_Square(x)
                Done = False
                For y = 0 To Group_Cnt - 1
                    If (Check_Inter(y, x) >= (Num_Lines - 1)) Then
                        'If this group is taken then so is the intersection
                        Dim New_Square = Add_Square(y)
                        Groups(y).Squares(New_Square) = x
                        Gr_Squares(x) = y
                        For z = 0 To Group_Cnt - 1
                            If ((Check_Inter(z, x) <> 0) And (z <> y)) Then
                                'Found the other group
                                Add_Group_To_Group(y, z)
                                Done = True
                                Exit For
                            End If
                        Next
                        If (Done) Then
                            Exit For
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Function Check_Inter(ByVal Gr_Index As Integer, ByVal Sq_Index As Integer)
        Dim Num_Connection As Integer = 0
        Dim Next_Square As Integer
        If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Top).Tag = 0) Then
            Next_Square = Form1.Board1.Get_Above_Square(Sq_Index)
            If (Next_Square <> -1) Then
                If (Gr_Squares(Next_Square) = Gr_Index) Then
                    Num_Connection += 1
                End If
            End If
        End If
        If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Left).Tag = 0) Then
            Next_Square = Form1.Board1.Get_Left_Square(Sq_Index)
            If (Next_Square <> -1) Then
                If (Gr_Squares(Next_Square) = Gr_Index) Then
                    Num_Connection += 1
                End If
            End If
        End If
        If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Right).Tag = 0) Then
            Next_Square = Form1.Board1.Get_Right_Square(Sq_Index)
            If (Next_Square <> -1) Then
                If (Gr_Squares(Next_Square) = Gr_Index) Then
                    Num_Connection += 1
                End If
            End If
        End If
        If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Bottom).Tag = 0) Then
            Next_Square = Form1.Board1.Get_Bottom_Square(Sq_Index)
            If (Next_Square <> -1) Then
                If (Gr_Squares(Next_Square) = Gr_Index) Then
                    Num_Connection += 1
                End If
            End If
        End If
        Return Num_Connection
    End Function

    Private Sub Fill_Group(ByVal Gr_Index As Integer, ByVal Sq_Index As Integer)
        If (Form1.Board1.TheBoard.Squares(Sq_Index).Tag = -1) Then
            If (Gr_Squares(Sq_Index) <> Gr_Index) Then
                Dim Num_Lines = Form1.Board1.Check_Single_Square(Sq_Index)
                If (Num_Lines >= 2) Then
                    'If the group connects to the majority of lines in the intersection then ass it to the group
                    'If (Check_Inter(Gr_Index, Sq_Index) < (Num_Lines - 1)) Then
                    'Return
                    'End If

                    'Add it to the group
                    Dim New_Square As Integer
                    Dim Next_Square As Integer
                    New_Square = Add_Square(Gr_Index)
                    Groups(Gr_Index).Squares(New_Square) = Sq_Index
                    Gr_Squares(Sq_Index) = Gr_Index
                    'Check top line
                    If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Top).Tag = 0) Then
                        'Top line isn't taken
                        Next_Square = Form1.Board1.Get_Above_Square(Sq_Index)
                        If (Next_Square <> -1) Then
                            Fill_Group(Gr_Index, Next_Square)
                        End If
                    End If
                    'Check Left Line
                    If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Left).Tag = 0) Then
                        'Left line isn't taken
                        Next_Square = Form1.Board1.Get_Left_Square(Sq_Index)
                        If (Next_Square <> -1) Then
                            Fill_Group(Gr_Index, Next_Square)
                        End If
                    End If
                    'Check Right Line
                    If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Right).Tag = 0) Then
                        'Right line isn't taken
                        Next_Square = Form1.Board1.Get_Right_Square(Sq_Index)
                        If (Next_Square <> -1) Then
                            Fill_Group(Gr_Index, Next_Square)
                        End If
                    End If
                    'Check Bottom Line
                    If (Form1.Board1.TheBoard.Lines(Form1.Board1.Square_Lines(Sq_Index).Bottom).Tag = 0) Then
                        'Bottom line isn't taken
                        Next_Square = Form1.Board1.Get_Bottom_Square(Sq_Index)
                        If (Next_Square <> -1) Then
                            Fill_Group(Gr_Index, Next_Square)
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class
