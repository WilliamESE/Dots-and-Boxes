Public Class Medium_AI
    Dim Easy As New Easy_AI
    Dim LineScores() As Integer '0 = Taken   1 = Almost takes square   2 = doesn't fill a square   3 = Takes square
    Dim Count2s As Integer
    Function Start_Turn() As Boolean
        Dim Line_Idx As Integer
        Dim Good As Boolean = False
        Count2s = 0
        Take_all_available_squares()
        Generate_Scores()
        Line_Idx = Choose_Line()
        While ((Line_Idx = -1) And (Form1.Board1.Game_Running))
            Line_Idx = Easy.Choose_Line()
        End While
        Form1.Board1.Computer_Move(Line_Idx)
        Return True
    End Function

    Function Choose_Line() As Integer
        Dim Line_Idx As Integer = -1
        Dim Line_Location As Integer
        Dim Num_Lines As Integer
        Dim Good As Boolean = False

        If (Count2s > 0) Then
            Randomize()
            Line_Location = Count2s * Rnd()
            For x = 0 To LineScores.Length - 1
                If LineScores(x) = 2 Then
                    If (Num_Lines = Line_Location) Then
                        Line_Idx = x
                        Exit For
                    End If
                    Num_Lines += 1
                End If
            Next
            If (Line_Idx = -1) Then
                For x = 0 To LineScores.Length - 1
                    If LineScores(x) = 2 Then
                        Line_Idx = x
                        Exit For
                    End If
                Next
            End If
        End If
        
        Return Line_Idx
    End Function

    Sub Generate_Scores()
        Dim Good As Boolean
        Dim cnt As Integer
        ReDim LineScores(Form1.Board1.TheBoard.Line_Cnt)
        Count2s = 0
        For x = 0 To Form1.Board1.TheBoard.Line_Cnt - 1
            If (Form1.Board1.TheBoard.Lines(x).Tag = 0) Then
                Good = Form1.Board1.Check_Line(x)
                If (Good) Then
                    LineScores(x) = 1
                Else
                    Good = False
                    cnt = Form1.Board1.Check_Single_Square(Form1.Board1.LineLookUp(x).Sq1)
                    If (cnt <> -1) Then
                        If (cnt = 3) Then
                            LineScores(x) = 3
                            Good = False
                        Else
                            LineScores(x) = 2
                            Good = True
                        End If
                    End If
                    cnt = Form1.Board1.Check_Single_Square(Form1.Board1.LineLookUp(x).Sq2)
                    If (cnt <> -1) Then
                        If (cnt = 3) Then
                            LineScores(x) = 3
                            Good = False
                        Else
                            LineScores(x) = 2
                            Good = True
                        End If
                    End If
                    If (Good) Then
                        Count2s += 1
                    End If
                    End If
            Else
                    LineScores(x) = 0
            End If
        Next
    End Sub

    Sub Take_all_available_squares()
        Dim Num_Lines As Integer
        For x = 0 To Form1.Board1.TheBoard.Square_Cnt - 1
            If (Form1.Board1.TheBoard.Squares(x).Tag = -1) Then
                Num_Lines = Form1.Board1.Check_Single_Square(x)
                If (Num_Lines = 3) Then
                    'This square can be taken
                    Form1.Board1.Computer_Finish_Square(x)
                    x = 0
                End If
            End If
        Next
    End Sub
End Class
