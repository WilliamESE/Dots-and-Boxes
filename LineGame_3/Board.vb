Public Class Board
    Structure Board_Components
        Dim Squares() As PowerPacks.RectangleShape
        Dim Square_Cnt As Integer
        Dim Lines() As PowerPacks.LineShape
        Dim Line_Cnt As Integer
        Dim Dots() As PowerPacks.OvalShape
        Dim Dot_Cnt As Integer
        Dim Cont As PowerPacks.ShapeContainer
    End Structure
    Structure Line_Squares
        Dim Top As Integer
        Dim Bottom As Integer
        Dim Left As Integer
        Dim Right As Integer
    End Structure
    Structure SquareLines
        Dim Sq1 As Integer
        Dim Sq2 As Integer
    End Structure
    Structure Player_B
        Dim Id As Integer
        Dim Colour As Color
        Dim Light_Colour As Color
        Dim Score As Integer
        Dim Human As Boolean
    End Structure
    Structure Info
        Dim Width As Integer
        Dim Height As Integer
    End Structure
    Public TheBoard As Board_Components
    Public BoardInfo As Info
    Public Square_Lines() As Line_Squares
    Public Specials As New PowerPacks.RectangleShape
    Public LineLookUp() As SquareLines
    Dim Prev As Integer
    Dim Players_B(6) As Player_B
    Dim Cnt_Players_B As Integer
    Dim Num_Squares As Integer
    Dim Borad_Built As Boolean = False

    Public Player_Turn As Integer
    Public Game_Running As Boolean
    Public Show_Avatar As Boolean = False

    Private Sub Make_Circle(ByVal Location As Point, ByVal Radius As Integer, ByVal Colour As Color)
        TheBoard.Dots(TheBoard.Dot_Cnt) = New PowerPacks.OvalShape
        TheBoard.Dots(TheBoard.Dot_Cnt).Location = Location
        TheBoard.Dots(TheBoard.Dot_Cnt).Height = Radius * 2
        TheBoard.Dots(TheBoard.Dot_Cnt).Width = Radius * 2
        TheBoard.Dots(TheBoard.Dot_Cnt).BorderWidth = 1
        TheBoard.Dots(TheBoard.Dot_Cnt).FillStyle = PowerPacks.FillStyle.Solid
        TheBoard.Dots(TheBoard.Dot_Cnt).FillColor = Colour
        TheBoard.Dots(TheBoard.Dot_Cnt).BorderColor = Colour
        TheBoard.Dots(TheBoard.Dot_Cnt).Visible = True
        TheBoard.Dots(TheBoard.Dot_Cnt).Enabled = False
        'sets a parent so you can see it
        TheBoard.Dots(TheBoard.Dot_Cnt).Parent = TheBoard.Cont
        TheBoard.Dot_Cnt += 1
    End Sub

    Private Sub Make_Line(ByVal Location1 As Point, ByVal Location2 As Point, ByVal Width As Integer)
        TheBoard.Lines(TheBoard.Line_Cnt) = New PowerPacks.LineShape
        With TheBoard.Lines(TheBoard.Line_Cnt)
            .Name = "Line_" & TheBoard.Line_Cnt
            .StartPoint = Location1
            .EndPoint = Location2
            .BorderWidth = Width
            .BorderColor = Color.Transparent
            .Enabled = True
            .Tag = 0
            .Visible = True
            .Parent = TheBoard.Cont
            AddHandler .MouseEnter, AddressOf Over_Line
            AddHandler .Click, AddressOf Line_Clicked
        End With
        TheBoard.Line_Cnt += 1

    End Sub

    Private Sub Make_Square(ByVal Location As Point, ByVal Width As Integer)
        TheBoard.Squares(TheBoard.Square_Cnt) = New PowerPacks.RectangleShape
        With TheBoard.Squares(TheBoard.Square_Cnt)
            .Location = Location
            .Height = Width
            .Width = Width
            .BorderWidth = 0
            .Tag = -1
            .FillStyle = Specials.FillStyle
            '.BackgroundImage = Image.FromFile("C:\\Users\\William\\Documents\\Visual Studio 2010\\Projects\\Hobbies\\Border_Title_Test\\Border_Title_Test\\bin\\Debug\\Pics\\mg_1304v1_uhq_by_nullbymouth-d8jzgea.jpg")
            .BackgroundImageLayout = ImageLayout.Zoom
            .BorderColor = Color.Transparent
            .FillColor = Color.Transparent
            .Enabled = False
            .Visible = False
            .Parent = TheBoard.Cont
        End With
        TheBoard.Square_Cnt += 1
    End Sub

    Sub Clean_Players()
        Array.Clear(Players_B, 0, Players_B.Length)
        Cnt_Players_B = 0
    End Sub

    Sub Add_Player_B(ByVal Id As Integer, ByVal Colour As Color, ByVal Human As Boolean)
        If (Cnt_Players_B < 6) Then
            Players_B(Cnt_Players_B).Id = Id
            Players_B(Cnt_Players_B).Colour = Colour
            Players_B(Cnt_Players_B).Human = Human
            Cnt_Players_B += 1
        End If
    End Sub

    Function Create_Board(ByVal Width As Integer, ByVal Height As Integer, ByVal Square_Size As Integer, ByVal Dot_Size As Integer, ByVal Line_Width As Integer, ByVal Dot_Colour As Color)
        Dim Point1 As Point
        Dim Point2 As Point
        Dim Index1 As Integer = 0
        Dim Index2 As Integer = 0
        Dim Loop1 As Integer
        Dim Incrment1 As Integer
        Dim WhatsNeeded As Integer
        Dim Num_Lines As Integer
        Dim Top As Integer
        Dim Left As Integer
        Dim Right As Integer
        Dim Bottom As Integer
        Dim count As Integer = 0

        ReDim TheBoard.Dots((Width + 1) * (Height + 1))
        ReDim TheBoard.Squares(Width * Height)
        Num_Squares = Width * Height
        ReDim Square_Lines(Width * Height)
        Num_Lines = (Width * Height) * 2 + (Width + Height)
        ReDim TheBoard.Lines(Num_Lines)
        ReDim LineLookUp(Num_Lines)
        For x = 0 To Num_Lines - 1
            LineLookUp(x).Sq1 = -1
            LineLookUp(x).Sq2 = -1
        Next

        pnl_board.Width = Width * Square_Size + ((Dot_Size + 1) * 3)
        pnl_board.Height = Height * Square_Size + ((Dot_Size + 1) * 3)

        Point1.X = (Me.Width / 2) - (pnl_board.Width / 2)
        Point1.Y = 25

        pnl_board.Location = Point1

        BoardInfo.Width = Width
        BoardInfo.Height = Height

        TheBoard.Dot_Cnt = 0
        TheBoard.Line_Cnt = 0
        TheBoard.Square_Cnt = 0

        TheBoard.Cont = New PowerPacks.ShapeContainer
        TheBoard.Cont.Parent = pnl_board

        'Find starting point
        Point1.X = Dot_Size
        Point1.Y = Dot_Size
        'Create Circles
        For y = 0 To Height
            For x = 0 To Width
                Make_Circle(Point1, Dot_Size, Dot_Colour)
                Point1.X += Square_Size
            Next
            Point1.X = Dot_Size
            Point1.Y += Square_Size
        Next
        'Create Lines
        Index2 = Index1
        Loop1 = 0
        Incrment1 = 1
        WhatsNeeded = Width
        For y = 0 To Num_Lines - 1
            Point1 = TheBoard.Dots(Index1 * (Width + 1) + count).Location
            Point1.X += Dot_Size
            Point1.Y += Dot_Size
            Point2 = TheBoard.Dots(Index2 * (Width + 1) + (count + Incrment1)).Location
            Point2.X += Dot_Size
            Point2.Y += Dot_Size
            count += 1
            If (count = WhatsNeeded) Then
                count = 0
                Loop1 += 1
                If ((Loop1 Mod 2) = 0) Then
                    Index1 += 1
                    Incrment1 = 1
                    WhatsNeeded = Width
                Else
                    Index2 += 1
                    Incrment1 = 0
                    WhatsNeeded = Width + 1
                End If
            End If

            Make_Line(Point1, Point2, Line_Width)
        Next
        'Create Squares
        Point1.X = Dot_Size * 2
        Point1.Y = Dot_Size * 2
        For y = 0 To Height - 1
            For x = 0 To Width - 1
                Top = TheBoard.Square_Cnt + ((Width + 1) * y)
                Left = Top + Width
                Right = Left + 1
                Bottom = Right + Width

                'Create the look up tables
                Square_Lines(TheBoard.Square_Cnt).Top = Top
                Square_Lines(TheBoard.Square_Cnt).Left = Left
                Square_Lines(TheBoard.Square_Cnt).Right = Right
                Square_Lines(TheBoard.Square_Cnt).Bottom = Bottom

                LineLookUp(Right).Sq2 = TheBoard.Square_Cnt
                LineLookUp(Left).Sq1 = TheBoard.Square_Cnt

                LineLookUp(Top).Sq1 = TheBoard.Square_Cnt
                LineLookUp(Bottom).Sq2 = TheBoard.Square_Cnt

                Make_Square(Point1, Square_Size)
                Point1.X += Square_Size
            Next
            Point1.X = Dot_Size * 2
            Point1.Y += Square_Size
        Next
        Borad_Built = True
        Return 1
    End Function

    Function Check_Square()
        Dim Good As Integer = 0
        Dim Square_Cnt As Integer = 0
        Dim Taken As Boolean
        For Idx = 0 To TheBoard.Square_Cnt - 1
            Good = 0
            If (TheBoard.Squares(Idx).Tag = -1) Then
                If (TheBoard.Lines(Square_Lines(Idx).Top).Tag = 1) Then
                    Good += 1
                End If
                If (TheBoard.Lines(Square_Lines(Idx).Left).Tag = 1) Then
                    Good += 1
                End If
                If (TheBoard.Lines(Square_Lines(Idx).Right).Tag = 1) Then
                    Good += 1
                End If
                If (TheBoard.Lines(Square_Lines(Idx).Bottom).Tag = 1) Then
                    Good += 1
                End If
                If (Good = 4) Then
                    TheBoard.Squares(Idx).Tag = Players_B(Player_Turn).Id
                    Players_B(Player_Turn).Score += 1
                    TheBoard.Squares(Idx).FillColor = Players_B(Player_Turn).Colour
                    TheBoard.Squares(Idx).FillStyle = Specials.FillStyle
                    If (Show_Avatar) Then
                        TheBoard.Squares(Idx).BackgroundImage = Form1.Players(Player_Turn).Avatar
                    End If
                    TheBoard.Squares(Idx).Visible = True
                    Square_Cnt += 1
                    Taken = True
                End If
            Else
                Square_Cnt += 1
            End If
        Next
        If (Square_Cnt = Num_Squares) Then
            'Game Over
            lbl_Game_Info.Text = "Game Over"
            lbl_Game_Info.BackColor = Color.Yellow
            RaiseEvent Game_Over()
            Game_Running = False
        End If
        Return Taken
    End Function

    Function Check_Single_Square(ByVal Index As Integer) As Integer
        Dim Good As Integer = 0
        If (Index <> -1) Then
            If (TheBoard.Lines(Square_Lines(Index).Top).Tag = 1) Then
                Good += 1
            End If
            If (TheBoard.Lines(Square_Lines(Index).Left).Tag = 1) Then
                Good += 1
            End If
            If (TheBoard.Lines(Square_Lines(Index).Right).Tag = 1) Then
                Good += 1
            End If
            If (TheBoard.Lines(Square_Lines(Index).Bottom).Tag = 1) Then
                Good += 1
            End If
        Else
            Good = -1
        End If
        Return Good
    End Function

    Function Find_Line_Index(ByVal Line As PowerPacks.LineShape)
        Dim idx As Integer
        Dim strs() As String = Split(Line.Name, "_")
        idx = CInt(strs(1))
        Return idx
    End Function

    Sub Start_Game()
        If (Borad_Built) Then
            Clean_Board()
            Prev = -1
            Player_Turn = 0
            Game_Running = True
            lbl_Game_Info.Text = "Game Running"
            lbl_Game_Info.BackColor = Color.Green
        End If
    End Sub

    Sub Clean_Board()
        For x = 0 To TheBoard.Line_Cnt - 1
            TheBoard.Lines(x).Tag = 0
            TheBoard.Lines(x).BorderColor = Color.Transparent
            TheBoard.Lines(x).BorderStyle = Drawing2D.DashStyle.Solid
        Next
        For x = 0 To TheBoard.Square_Cnt - 1
            TheBoard.Squares(x).Tag = -1
            TheBoard.Squares(x).BackgroundImage = Nothing
            TheBoard.Squares(x).Visible = False
            TheBoard.Squares(x).FillColor = Color.Transparent
        Next
        For x = 0 To Cnt_Players_B - 1
            Players_B(x).Score = 0
        Next
        Game_Running = False
        lbl_Game_Info.Text = "No Game"
        lbl_Game_Info.BackColor = Color.Yellow
    End Sub

    Sub Remove_Board()
        If Borad_Built Then
            For x = 0 To TheBoard.Line_Cnt - 1
                TheBoard.Lines(x).Tag = 0
                TheBoard.Lines(x).Visible = False
                TheBoard.Lines(x).Enabled = False
                RemoveHandler TheBoard.Lines(x).MouseEnter, AddressOf Over_Line
                RemoveHandler TheBoard.Lines(x).Click, AddressOf Line_Clicked
            Next
            For x = 0 To TheBoard.Square_Cnt - 1
                TheBoard.Squares(x).Tag = -1
                TheBoard.Squares(x).Visible = False
            Next
            For x = 0 To TheBoard.Dot_Cnt - 1
                TheBoard.Dots(x).Visible = False
                TheBoard.Dots(x).Refresh()
            Next
            For x = 0 To Cnt_Players_B - 1
                Players_B(x).Score = 0
            Next
            Array.Clear(TheBoard.Lines, 0, TheBoard.Lines.Length)
            Array.Clear(TheBoard.Squares, 0, TheBoard.Squares.Length)
            Array.Clear(TheBoard.Dots, 0, TheBoard.Dots.Length)
            Game_Running = False
            Borad_Built = False
            lbl_Game_Info.Text = "Game Non-Existent"
            lbl_Game_Info.BackColor = Color.Red
            Me.Refresh()
        End If
    End Sub

    Function Get_Player_Score(ByVal Id As Integer)
        Return Players_B(Id).Score
    End Function

    Function Is_Line_Taken(ByVal Index As Integer) As Boolean
        If (TheBoard.Lines(Index).Tag = 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function Computer_Move(ByVal Line_Index As Integer, Optional ByVal End_Turn As Boolean = True) As Boolean
        If Game_Running Then
            If (Line_Index <> -1) Then
                TheBoard.Lines(Line_Index).BorderColor = Players_B(Player_Turn).Colour
                TheBoard.Lines(Line_Index).Tag = 1
                TheBoard.Lines(Line_Index).BorderStyle = Drawing2D.DashStyle.Solid
                TheBoard.Lines(Line_Index).Refresh()
                Dim Taken As Boolean = Check_Square()
                If (End_Turn) Then
                    RaiseEvent Turn_Over(Player_Turn, Players_B(Player_Turn).Score, Taken)
                End If
                'Me.Refresh()

                Return True
            End If
        Else
            Return True
        End If
        Return False
    End Function

    Sub Computer_Finish_Square(ByVal Index As Integer)
        'If (Check_Single_Square(Index) = 3) Then
        If (TheBoard.Lines(Square_Lines(Index).Top).Tag = 0) Then
            Computer_Move(Square_Lines(Index).Top, False)
        End If
        If (TheBoard.Lines(Square_Lines(Index).Left).Tag = 0) Then
            Computer_Move(Square_Lines(Index).Left, False)
        End If
        If (TheBoard.Lines(Square_Lines(Index).Right).Tag = 0) Then
            Computer_Move(Square_Lines(Index).Right, False)
        End If
        If (TheBoard.Lines(Square_Lines(Index).Bottom).Tag = 0) Then
            Computer_Move(Square_Lines(Index).Bottom, False)
        End If
        'End If
    End Sub

    Function Check_Line(ByVal index As Integer)
        Dim Answer As Boolean = False
        Dim Cnt As Integer = 0
        Cnt = Check_Single_Square(LineLookUp(index).Sq1)
        If (Cnt = 2) Then
            Answer = True
        End If
        Cnt = Check_Single_Square(LineLookUp(index).Sq2)
        If (Cnt = 2) Then
            Answer = True
        End If
        Return Answer
    End Function

    Function Get_Above_Square(ByVal Index As Integer) As Integer
        Dim idx As Integer
        idx = Index - BoardInfo.Width
        If (idx < 0) Then
            idx = -1
        End If
        Return idx
    End Function

    Function Get_Left_Square(ByVal Index As Integer) As Integer
        Dim idx As Integer
        idx = Index - 1
        If ((Index Mod BoardInfo.Width) = 0) Then
            idx = -1
        End If
        Return idx
    End Function

    Function Get_Right_Square(ByVal Index As Integer) As Integer
        Dim idx As Integer
        idx = Index + 1
        If ((idx Mod BoardInfo.Width) = 0) Then
            idx = -1
        End If
        Return idx
    End Function

    Function Get_Bottom_Square(ByVal Index As Integer) As Integer
        Dim idx As Integer
        idx = Index + BoardInfo.Width
        If (idx >= TheBoard.Square_Cnt) Then
            idx = -1
        End If
        Return idx
    End Function

    Event Turn_Over(ByVal Player_Id As Integer, ByVal Score As Integer, ByVal Gotten As Boolean)
    Event Game_Over()

    Private Sub Over_Line(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Game_Running) Then
            Dim indx As Integer = Find_Line_Index(sender)
            If (TheBoard.Lines(indx).Tag <> 1) And (Players_B(Player_Turn).Human) Then
                If (Prev <> -1) Then
                    If (TheBoard.Lines(Prev).Name <> sender.Name) Then
                        TheBoard.Lines(Prev).BorderColor = Color.Transparent
                        TheBoard.Lines(Prev).BorderStyle = Drawing2D.DashStyle.Solid
                        TheBoard.Lines(Prev).Refresh()
                    End If
                End If
                TheBoard.Lines(indx).BorderColor = Players_B(Player_Turn).Colour
                TheBoard.Lines(indx).BorderStyle = Drawing2D.DashStyle.Dot
                TheBoard.Lines(indx).Refresh()
                Prev = indx
            End If
        End If
    End Sub

    Private Sub Line_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Game_Running) Then
            Dim indx As Integer = Find_Line_Index(sender)
            If (TheBoard.Lines(indx).Tag <> 1) And (Players_B(Player_Turn).Human) Then
                TheBoard.Lines(indx).BorderColor = Players_B(Player_Turn).Colour
                TheBoard.Lines(indx).Tag = 1
                TheBoard.Lines(indx).BorderStyle = Drawing2D.DashStyle.Solid
                TheBoard.Lines(indx).Refresh()

                Prev = -1

                Dim Taken As Boolean = Check_Square()
                RaiseEvent Turn_Over(Player_Turn, Players_B(Player_Turn).Score, Taken)
            End If
        End If
    End Sub
End Class
