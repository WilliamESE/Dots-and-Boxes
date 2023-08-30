Public Class Hard_AI
    Dim Medium As New Medium_AI
    Dim Gr As New Grouping
    Dim Group_Run As Integer = 0
    Public Sub Start_Turn()
        Dim Line_Idx As Integer
        Medium.Take_all_available_squares()
        Medium.Generate_Scores()
        Line_Idx = Medium.Choose_Line()
        If (Line_Idx = -1) Then
            Line_Idx = Group_Stuff()
        End If
        Form1.Board1.Computer_Move(Line_Idx)
    End Sub

    Function Group_Stuff()
        Dim Line_Idx As Integer = -1
        If (Group_Run = 0) Then
            Gr.Group_Squares(Form1.Board1.TheBoard.Square_Cnt)
        Else
            Gr.Recalculate()
        End If
        Line_Idx = Gr.Get_Line_In_Group(Gr.Get_Smallest_Group())
        Group_Run = 1
        Return Line_Idx
    End Function
End Class
