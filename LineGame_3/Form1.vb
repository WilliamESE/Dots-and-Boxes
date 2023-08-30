Public Class Form1
    Public Players(6) As Player
    Dim Player_Cnt As Integer
    Dim pnl_Play_cnt As Integer
    Dim TurnGotten As Boolean
    Dim Gr As New Grouping

    Dim Game As Integer
    Dim Game_Type As Integer


    Function Add_Player(ByVal Name As String, ByVal Colour As Color, ByVal Human As Boolean, Optional ByVal Avatar As Image = Nothing, Optional ByVal Level As Integer = 0)
        If Player_Cnt < 6 Then
            Players(Player_Cnt) = New Player

            Players(Player_Cnt).Visible = False

            Players(Player_Cnt).Player_Name = Name
            Players(Player_Cnt).Player_Colour = Colour
            If (Avatar Is Nothing) Then
                Avatar = Defualt_Image.Image
            End If
            Players(Player_Cnt).pbxPlayerAvatar.Image = Avatar
            Players(Player_Cnt).Human = Human
            Players(Player_Cnt).Level = Level
            Players(Player_Cnt).Turn = False

            Players(Player_Cnt).Dock = DockStyle.Top

            If ((Player_Cnt Mod 2) = 0) Then
                'Place player on pnlPlayers1
                pnlPlayers1.Controls.Add(Players(Player_Cnt))
                pnl_Play_cnt += 1
            Else
                'Place Player on pnlPlayers2
                pnlPlayers2.Controls.Add(Players(Player_Cnt))
            End If
            Players(Player_Cnt).Visible = True
            Players(Player_Cnt).BringToFront()
            Player_Cnt += 1
        Else
            Return 0
        End If
        Return 1
    End Function

    Sub Clean_Players()
        For x = 0 To Player_Cnt - 1
            Players(x).Visible = False
        Next
        Array.Clear(Players, 0, Players.Length)
        Player_Cnt = 0
        pnl_Play_cnt = 0
    End Sub

    Function Find_Highest()
        Dim Highest As Integer = 0
        For x = 0 To Player_Cnt - 1
            If (Players(x).BackColor = Color.Transparent) Then
                Highest = x
            End If
        Next
        For x = 0 To Player_Cnt - 1
            If (Players(x).BackColor = Color.Transparent) Then
                If (Players(Highest).Score < Players(x).Score) Then
                    Highest = x
                End If
            End If
        Next
        Return Highest
    End Function

    Private Sub Board1_Game_Over() Handles Board1.Game_Over
        For x = 0 To Player_Cnt - 1
            Players(x).Turn = False
            Players(x).Score = Board1.Get_Player_Score(x)
        Next
        Players(Board1.Player_Turn).Turn = False
        Players(Find_Highest()).FirstPlace()
        Players(Find_Highest()).SecondPlace()
        If (Player_Cnt > 2) Then
            Players(Find_Highest()).ThirdPlace()
        End If
        
    End Sub

    Private Sub Board1_Turn_Over(ByVal Player_Id As System.Int32, ByVal Score As System.Int32, ByVal Gotten As System.Boolean) Handles Board1.Turn_Over
        Players(Player_Id).Score = Score
        TurnGotten = Gotten
        Inbetween_Turns.Start()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Board1.Remove_Board()
    End Sub

    Private Sub Inbetween_Turns_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inbetween_Turns.Tick
        Inbetween_Turns.Stop()
        If (Board1.Game_Running) Then
            If (Not TurnGotten) Then
                Players(Board1.Player_Turn).Turn = False
                If (Board1.Player_Turn = Player_Cnt - 1) Then
                    Board1.Player_Turn = 0
                Else
                    Board1.Player_Turn += 1
                End If
                Players(Board1.Player_Turn).Turn = True
            Else
                If (Board1.Game_Running) Then
                    Players(Board1.Player_Turn).Turn = True
                End If
            End If
        End If
    End Sub

    Private Sub mitOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitOptions.Click
        Board1.Visible = False
        Game_Setup1.Visible = True
        Game_Setup1.Dock = DockStyle.Fill
        Game_Setup1.BackColor = SystemColors.Control
    End Sub

    Private Sub mitNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitNewGame.Click
        Board1.Visible = True
        Game_Setup1.Visible = False
        Board1.Start_Game()
        Players(Board1.Player_Turn).Turn = True
    End Sub

    Private Sub mitRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitRestart.Click
        Board1.Clean_Board()
        Board1.Start_Game()
        Players(Board1.Player_Turn).Turn = True
    End Sub

    Private Sub mitExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitExit.Click
        Me.Close()
    End Sub
End Class
