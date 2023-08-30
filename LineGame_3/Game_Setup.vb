Public Class Game_Setup
    Structure Player
        Dim Name As String
        Dim Colour As Color
        Dim Avatar As Image
        Dim Human As Boolean
        Dim Level As Integer
    End Structure
    Dim Players(6) As Player
    Dim Player_Cnt As Integer
    Dim ImageLocation As String
    Dim Editing_enabled As Boolean
    Dim Edit_Index As Integer

    Function Get_Colour(ByVal Current_Colour As Color)
        cdgPick_Colour.Color = Current_Colour
        cdgPick_Colour.ShowDialog()
        Return cdgPick_Colour.Color
    End Function

    Function Get_File(ByVal Current_File As String)
        ofdAvatar.FileName = Current_File
        ofdAvatar.ShowDialog()
        Return ofdAvatar.FileName
    End Function

    Sub Update_List()
        lbxPlayers.Items.Clear()
        For x = 0 To 6
            If (Players(x).Name <> "") Then
                lbxPlayers.Items.Add(Players(x).Name)
            End If
        Next
    End Sub

    Sub Save_Information(ByVal index As Integer)
        Players(index).Name = tbxName.Text
        Players(index).Colour = btnColour.BackColor
        Players(index).Avatar = pbxAvatar.Image
        If (cbxType.SelectedIndex = 0) Then
            Players(index).Human = True
        Else
            Players(index).Human = False
            Players(index).Level = cbxLevel.SelectedIndex
        End If
    End Sub

    Sub Load_Edit(ByVal index As Integer)
        tbxName.Text = Players(index).Name
        btnColour.BackColor = Players(index).Colour
        pbxAvatar.Image = Players(index).Avatar
        If (Players(index).Human) Then
            cbxType.SelectedIndex = 0
        Else
            cbxType.SelectedIndex = 1
            cbxLevel.SelectedIndex = Players(index).Level
        End If
    End Sub

    'index1 goes into 2 and index2 goes into 1
    Sub Swap_Players(ByVal index1 As Integer, ByVal index2 As Integer)
        Dim Holder As Player
        Holder.Name = Players(index1).Name
        Holder.Colour = Players(index1).Colour
        Holder.Human = Players(index1).Human
        Holder.Level = Players(index1).Level
        Holder.Avatar = Players(index1).Avatar

        Players(index1).Name = Players(index2).Name
        Players(index1).Colour = Players(index2).Colour
        Players(index1).Human = Players(index2).Human
        Players(index1).Level = Players(index2).Level
        Players(index1).Avatar = Players(index2).Avatar

        Players(index2).Name = Holder.Name
        Players(index2).Colour = Holder.Colour
        Players(index2).Human = Holder.Human
        Players(index2).Level = Holder.Level
        Players(index2).Avatar = Holder.Avatar
    End Sub

    Private Sub Game_Setup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbxType.SelectedIndex = 0
        cbxLevel.SelectedIndex = 0
        cbxFillStyle.SelectedIndex = 6
        cbxGame_Type.SelectedIndex = 0
    End Sub

    Private Sub cbxType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxType.SelectedIndexChanged
        If (cbxType.SelectedIndex = 1) Then
            cbxLevel.Visible = True
            'btnAvatar.Enabled = False
        Else
            cbxLevel.Visible = False
            btnAvatar.Enabled = True
        End If
    End Sub

    Private Sub btnColour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColour.Click
        btnColour.BackColor = Get_Colour(btnColour.BackColor)
        btnColour.ForeColor = Color.FromArgb((btnColour.BackColor.R + 128) Mod 256, (btnColour.BackColor.G + 128) Mod 256, (btnColour.BackColor.B + 128) Mod 256)
    End Sub

    Private Sub btnAvatar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvatar.Click
        ImageLocation = Get_File(ImageLocation)
        If (ImageLocation <> "") Then
            pbxAvatar.Image = Image.FromFile(ImageLocation)
        End If
    End Sub

    Private Sub bntAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntAdd.Click
        If (Player_Cnt < 6) Then
            Save_Information(Player_Cnt)
            Player_Cnt += 1
            Update_List()
        Else
            MsgBox("You've reached the maximum allowed players!")
        End If
    End Sub

    Private Sub lbxPlayers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbxPlayers.SelectedIndexChanged
        pnlEditing.Enabled = True
        Dim idx As Integer = lbxPlayers.SelectedIndex
        If (idx <> -1) Then
            If (idx = 0) Then
                btnUp.Enabled = False
            Else
                btnUp.Enabled = True
            End If
            If (idx = lbxPlayers.Items.Count - 1) Then
                btnDown.Enabled = False
            Else
                btnDown.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Editing_enabled = True
        Edit_Index = lbxPlayers.SelectedIndex
        Load_Edit(Edit_Index)
        bntAdd.Visible = False
        btnSave_edit.Visible = True
        btnCancel_Edit.Visible = True
        pnlEditing.Enabled = False
    End Sub

    Private Sub btnSave_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_edit.Click
        If (Editing_enabled) Then
            Save_Information(Edit_Index)
            Editing_enabled = False
            bntAdd.Visible = True
            btnSave_edit.Visible = False
            btnCancel_Edit.Visible = False
            Update_List()
            pnlEditing.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel_Edit.Click
        Editing_enabled = False
        bntAdd.Visible = True
        btnSave_edit.Visible = False
        btnCancel_Edit.Visible = False
        pnlEditing.Enabled = True
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Swap_Players(lbxPlayers.SelectedIndex, lbxPlayers.SelectedIndex - 1)
        Update_List()
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Swap_Players(lbxPlayers.SelectedIndex, lbxPlayers.SelectedIndex + 1)
        Update_List()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        For x = lbxPlayers.SelectedIndex To Player_Cnt - 2
            Players(x) = Players(x + 1)
        Next
        Players(Player_Cnt - 1).Name = ""
        Player_Cnt -= 1
        Update_List()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        For x = 0 To Player_Cnt - 1
            Players(x).Name = ""
        Next
        Player_Cnt = 0
        Update_List()
    End Sub

    Private Sub cbxGame_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxGame_Type.SelectedIndexChanged
        pnlBest.Visible = False
        pnlEli.Visible = False
        If (cbxGame_Type.SelectedIndex = 0) Then
            lblInfo.Text = "Single game is just one game where the player face off against each other"
        ElseIf (cbxGame_Type.SelectedIndex = 1) Then
            lblInfo.Text = "You play a set of matches and who ever wins the most wins the game"
            pnlBest.Visible = True
        Else
            lblInfo.Text = "At the end of every match the player with the lowest score is eliminated, until only one player remains"
            pnlEli.Visible = True
        End If
    End Sub

    Private Sub btnDot_Colour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDot_Colour.Click
        sender.BackColor = Get_Colour(sender.BackColor)
        sender.ForeColor = Color.FromArgb((sender.BackColor.R + 128) Mod 256, (sender.BackColor.G + 128) Mod 256, (sender.BackColor.B + 128) Mod 256)
    End Sub

    Private Sub btnDefaults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefaults.Click
        nudSize_X.Value = 5
        nudSize_Y.Value = 5
        nudSquare_Size.Value = 79
        nudDot_Size.Value = 10
        nudLine_Width.Value = 10
        btnDot_Colour.BackColor = Color.Black
        btnDot_Colour.ForeColor = Color.White
    End Sub

    Private Sub btnBegin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBegin.Click
        'Setup Players
        Form1.Clean_Players()
        Form1.Board1.Clean_Players()
        Form1.Board1.Remove_Board()
        For x = 0 To Player_Cnt - 1
            Form1.Add_Player(Players(x).Name, Players(x).Colour, Players(x).Human, Players(x).Avatar, Players(x).Level)
            Form1.Board1.Add_Player_B(x, Players(x).Colour, Players(x).Human)

            Form1.Board1.Create_Board(nudSize_X.Value, nudSize_Y.Value, nudSquare_Size.Value, nudDot_Size.Value, nudLine_Width.Value, btnDot_Colour.BackColor)
        Next
        Form1.mitNewGame.Enabled = True
        Form1.mitRestart.Enabled = True
    End Sub

    Private Sub cbxLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLevel.SelectedIndexChanged
        If (sender.visible) Then
            'pbxAvatar.Image = Defults.Images.Item(sender.SelectedIndex)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFillStyle.SelectedIndexChanged
        If cbxFillStyle.Text = "Transparent" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Transparent
        ElseIf cbxFillStyle.Text = "Percent05" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Percent05
        ElseIf cbxFillStyle.Text = "Percent10" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Percent10
        ElseIf cbxFillStyle.Text = "Percent20" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Percent20
        ElseIf cbxFillStyle.Text = "Percent30" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Percent30
        ElseIf cbxFillStyle.Text = "Percent40" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Percent40
        ElseIf cbxFillStyle.Text = "Percent50" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Percent50
        ElseIf cbxFillStyle.Text = "Percent60" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Percent60
        ElseIf cbxFillStyle.Text = "Percent70" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Percent70
        ElseIf cbxFillStyle.Text = "Percent80" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Percent80
        ElseIf cbxFillStyle.Text = "Percent90" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Percent90
        ElseIf cbxFillStyle.Text = "Solid" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Solid
        ElseIf cbxFillStyle.Text = "Horizontal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Horizontal
        ElseIf cbxFillStyle.Text = "Vertical" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Vertical
        ElseIf cbxFillStyle.Text = "ForwardDiagonal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.ForwardDiagonal
        ElseIf cbxFillStyle.Text = "BackwardDiagonal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.BackwardDiagonal
        ElseIf cbxFillStyle.Text = "Cross" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Cross
        ElseIf cbxFillStyle.Text = "DiagonalCross" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DiagonalCross
        ElseIf cbxFillStyle.Text = "LightDownwardDiagonal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.LightDownwardDiagonal
        ElseIf cbxFillStyle.Text = "LightUpwardDiagonal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.LightUpwardDiagonal
        ElseIf cbxFillStyle.Text = "DarkDownwardDiagonal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DarkDownwardDiagonal
        ElseIf cbxFillStyle.Text = "DarkUpwardDiagonal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DarkUpwardDiagonal
        ElseIf cbxFillStyle.Text = "WideDownwardDiagonal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.WideDownwardDiagonal
        ElseIf cbxFillStyle.Text = "WideUpwardDiagonal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.WideUpwardDiagonal
        ElseIf cbxFillStyle.Text = "DashedDownwardDiagonal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DashedDownwardDiagonal
        ElseIf cbxFillStyle.Text = "DashedUpwardDiagonal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DashedUpwardDiagonal
        ElseIf cbxFillStyle.Text = "LightHorizontal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.LightHorizontal
        ElseIf cbxFillStyle.Text = "LightVertical" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.LightVertical
        ElseIf cbxFillStyle.Text = "NarrowHorizontal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.NarrowHorizontal
        ElseIf cbxFillStyle.Text = "NarrowVertical" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.NarrowVertical
        ElseIf cbxFillStyle.Text = "DarkHorizontal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DarkHorizontal
        ElseIf cbxFillStyle.Text = "DarkVertical" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DarkVertical
        ElseIf cbxFillStyle.Text = "DashedHorizontal" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DashedHorizontal
        ElseIf cbxFillStyle.Text = "DashedVertical" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DashedVertical
        ElseIf cbxFillStyle.Text = "SmallConfetti" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.SmallConfetti
        ElseIf cbxFillStyle.Text = "LargeConfetti" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.LargeConfetti
        ElseIf cbxFillStyle.Text = "ZigZag" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.ZigZag
        ElseIf cbxFillStyle.Text = "Wave" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Wave
        ElseIf cbxFillStyle.Text = "DiagonalBrick" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DiagonalBrick
        ElseIf cbxFillStyle.Text = "HorizontalBrick" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.HorizontalBrick
        ElseIf cbxFillStyle.Text = "Weave" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Weave
        ElseIf cbxFillStyle.Text = "Plaid" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Plaid
        ElseIf cbxFillStyle.Text = "Divot" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Divot
        ElseIf cbxFillStyle.Text = "DottedGrid" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DottedGrid
        ElseIf cbxFillStyle.Text = "DottedDiamond" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.DottedDiamond
        ElseIf cbxFillStyle.Text = "Shingle" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Shingle
        ElseIf cbxFillStyle.Text = "Trellis" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Trellis
        ElseIf cbxFillStyle.Text = "Sphere" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.Sphere
        ElseIf cbxFillStyle.Text = "SmallGrid" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.SmallGrid
        ElseIf cbxFillStyle.Text = "SmallCheckerBoard" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.SmallCheckerBoard
        ElseIf cbxFillStyle.Text = "LargeCheckerBoard" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.LargeCheckerBoard
        ElseIf cbxFillStyle.Text = "OutlineShapedDiamond" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.OutlineShapedDiamond
        ElseIf cbxFillStyle.Text = "SolidDiamond" Then
            Form1.Board1.Specials.FillStyle = PowerPacks.FillStyle.SolidDiamond
        End If
    End Sub

    Private Sub cbxAvatars_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxAvatars.CheckedChanged
        Form1.Board1.Show_Avatar = cbxAvatars.Checked
    End Sub
End Class
