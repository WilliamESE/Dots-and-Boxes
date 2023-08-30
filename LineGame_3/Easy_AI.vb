Public Class Easy_AI
    Sub Start_Turn()
        Form1.Board1.Computer_Move(Choose_Line())
    End Sub

    Function Choose_Line() As Integer
        Dim Line_Index As Integer = -1
        Dim Line_Good As Boolean = False
        Dim x As Integer = 0
        Randomize()
        While (x < 1000) And (Not Line_Good)
            Line_Index = (Form1.Board1.TheBoard.Line_Cnt - 1) * Rnd()
            Line_Good = Form1.Board1.Is_Line_Taken(Line_Index)
            x += 1
        End While
        x = 0
        If (Not Line_Good) Then
            While (x < Form1.Board1.TheBoard.Line_Cnt - 1) And (Not Line_Good)
                Line_Index = x
                Line_Good = Form1.Board1.Is_Line_Taken(Line_Index)
                x += 1
            End While
        End If
        If (Not Line_Good) Then
            Line_Index = -1
        End If
        Return Line_Index
    End Function
End Class
