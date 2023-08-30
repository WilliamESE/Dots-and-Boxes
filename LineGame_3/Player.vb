Public Class Player
    Dim Player_Score As Integer
    Dim Games_Won As Integer
    Public Human As Boolean
    Public Level As Integer
    Dim L_Easy As New Easy_AI
    Dim L_Medium As New Medium_AI
    Dim L_Hard As New Hard_AI
    Property Turn As Boolean
        Get
            If (Me.BackColor = Color.Green) Then
                Return True
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)
            If (value = True) Then
                Me.BackColor = Color.Green
            Else
                Me.BackColor = Color.Transparent
            End If
            Panel1.BackColor = SystemColors.Control
            If (value) Then
                If (Not Me.Human) Then
                    'This is a computer and needs to move
                    If (Me.Level = 0) Then
                        L_Easy.Start_Turn()
                    ElseIf (Me.Level = 1) Then
                        For x = 0 To 10
                            If (L_Medium.Start_Turn()) Then
                                Exit For
                            End If
                        Next
                    ElseIf (Me.Level = 2) Then
                        L_Hard.Start_Turn()
                    End If
                End If
            End If
        End Set
    End Property
    Property Avatar As Image
        Get
            Return pbxPlayerAvatar.Image
        End Get
        Set(ByVal value As Image)
            pbxPlayerAvatar.Image = value
        End Set
    End Property
    Property Player_Name As String
        Get
            Return lblPlayerName.Text
        End Get
        Set(ByVal value As String)
            lblPlayerName.Text = value
        End Set
    End Property
    Property Score As Integer
        Get
            Return Player_Score
        End Get
        Set(ByVal value As Integer)
            Player_Score = value
            lblPlayerScore.Text = "Score: " & value
        End Set
    End Property
    Property Games As Integer
        Get
            Return Games_Won
        End Get
        Set(ByVal value As Integer)
            Games_Won = value
            lblGames_Won.Text = "Games Won: " & value
        End Set
    End Property
    Property View_Games_Won As Boolean
        Get
            Return lblGames_Won.Visible
        End Get
        Set(ByVal value As Boolean)
            lblGames_Won.Visible = value
        End Set
    End Property
    Property Player_Colour As Color
        Get
            Return pnlPlayerColour.BackColor
        End Get
        Set(ByVal value As Color)
            pnlPlayerColour.BackColor = value
        End Set
    End Property

    Sub FirstPlace()
        Me.BackColor = Color.Gold
    End Sub
    Sub SecondPlace()
        Me.BackColor = Color.Silver
    End Sub
    Sub ThirdPlace()
        Me.BackColor = Color.RosyBrown
    End Sub
    Sub Eliminated()
        Me.BackColor = Color.Red
    End Sub
End Class
