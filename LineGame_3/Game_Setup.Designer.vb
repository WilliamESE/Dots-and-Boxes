<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game_Setup
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game_Setup))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pnlEditing = New System.Windows.Forms.Panel()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.lbxPlayers = New System.Windows.Forms.ListBox()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave_edit = New System.Windows.Forms.Button()
        Me.btnCancel_Edit = New System.Windows.Forms.Button()
        Me.cbxLevel = New System.Windows.Forms.ComboBox()
        Me.cbxType = New System.Windows.Forms.ComboBox()
        Me.bntAdd = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pbxAvatar = New System.Windows.Forms.PictureBox()
        Me.btnAvatar = New System.Windows.Forms.Button()
        Me.btnColour = New System.Windows.Forms.Button()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Defults = New System.Windows.Forms.ImageList(Me.components)
        Me.cdgPick_Colour = New System.Windows.Forms.ColorDialog()
        Me.ofdAvatar = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.pnlEli = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlBest = New System.Windows.Forms.GroupBox()
        Me.nudBest_of = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbxGame_Type = New System.Windows.Forms.ComboBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnDefaults = New System.Windows.Forms.Button()
        Me.cbxAvatars = New System.Windows.Forms.CheckBox()
        Me.cbxFillStyle = New System.Windows.Forms.ComboBox()
        Me.btnDot_Colour = New System.Windows.Forms.Button()
        Me.nudLine_Width = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudDot_Size = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudSquare_Size = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nudSize_Y = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudSize_X = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnlEditing.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pbxAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.pnlEli.SuspendLayout()
        Me.pnlBest.SuspendLayout()
        CType(Me.nudBest_of, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.nudLine_Width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDot_Size, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSquare_Size, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nudSize_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSize_X, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Splitter1)
        Me.GroupBox1.Controls.Add(Me.lbxPlayers)
        Me.GroupBox1.Controls.Add(Me.Splitter2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(801, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Players"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pnlEditing)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(465, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(333, 214)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Player Options"
        '
        'pnlEditing
        '
        Me.pnlEditing.Controls.Add(Me.btnRemove)
        Me.pnlEditing.Controls.Add(Me.btnDown)
        Me.pnlEditing.Controls.Add(Me.btnUp)
        Me.pnlEditing.Controls.Add(Me.btnEdit)
        Me.pnlEditing.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEditing.Enabled = False
        Me.pnlEditing.Location = New System.Drawing.Point(3, 16)
        Me.pnlEditing.Name = "pnlEditing"
        Me.pnlEditing.Size = New System.Drawing.Size(327, 98)
        Me.pnlEditing.TabIndex = 5
        '
        'btnRemove
        '
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemove.Location = New System.Drawing.Point(0, 69)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(327, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDown.Location = New System.Drawing.Point(0, 46)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(327, 23)
        Me.btnDown.TabIndex = 6
        Me.btnDown.Text = "Move Down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUp.Location = New System.Drawing.Point(0, 23)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(327, 23)
        Me.btnUp.TabIndex = 5
        Me.btnUp.Text = "Move Up"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Location = New System.Drawing.Point(0, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(327, 23)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(3, 188)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(327, 23)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "Remove All Players"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(462, 22)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 214)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'lbxPlayers
        '
        Me.lbxPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbxPlayers.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbxPlayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxPlayers.FormattingEnabled = True
        Me.lbxPlayers.Location = New System.Drawing.Point(300, 22)
        Me.lbxPlayers.MinimumSize = New System.Drawing.Size(111, 2)
        Me.lbxPlayers.Name = "lbxPlayers"
        Me.lbxPlayers.Size = New System.Drawing.Size(162, 214)
        Me.lbxPlayers.TabIndex = 1
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(297, 22)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 214)
        Me.Splitter2.TabIndex = 4
        Me.Splitter2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSave_edit)
        Me.GroupBox2.Controls.Add(Me.btnCancel_Edit)
        Me.GroupBox2.Controls.Add(Me.cbxLevel)
        Me.GroupBox2.Controls.Add(Me.cbxType)
        Me.GroupBox2.Controls.Add(Me.bntAdd)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.btnColour)
        Me.GroupBox2.Controls.Add(Me.tbxName)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(236, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 214)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Player"
        '
        'btnSave_edit
        '
        Me.btnSave_edit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSave_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave_edit.Location = New System.Drawing.Point(119, 142)
        Me.btnSave_edit.Name = "btnSave_edit"
        Me.btnSave_edit.Size = New System.Drawing.Size(172, 23)
        Me.btnSave_edit.TabIndex = 7
        Me.btnSave_edit.Text = "Save Player"
        Me.btnSave_edit.UseVisualStyleBackColor = True
        Me.btnSave_edit.Visible = False
        '
        'btnCancel_Edit
        '
        Me.btnCancel_Edit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCancel_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel_Edit.Location = New System.Drawing.Point(119, 165)
        Me.btnCancel_Edit.Name = "btnCancel_Edit"
        Me.btnCancel_Edit.Size = New System.Drawing.Size(172, 23)
        Me.btnCancel_Edit.TabIndex = 6
        Me.btnCancel_Edit.Text = "Cancel"
        Me.btnCancel_Edit.UseVisualStyleBackColor = True
        Me.btnCancel_Edit.Visible = False
        '
        'cbxLevel
        '
        Me.cbxLevel.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLevel.FormattingEnabled = True
        Me.cbxLevel.Items.AddRange(New Object() {"Easy", "Medium", "Hard", "Special"})
        Me.cbxLevel.Location = New System.Drawing.Point(119, 80)
        Me.cbxLevel.Name = "cbxLevel"
        Me.cbxLevel.Size = New System.Drawing.Size(172, 21)
        Me.cbxLevel.TabIndex = 5
        Me.cbxLevel.Visible = False
        '
        'cbxType
        '
        Me.cbxType.DisplayMember = "0"
        Me.cbxType.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Items.AddRange(New Object() {"Human", "Computer"})
        Me.cbxType.Location = New System.Drawing.Point(119, 59)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(172, 21)
        Me.cbxType.TabIndex = 4
        '
        'bntAdd
        '
        Me.bntAdd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bntAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bntAdd.Location = New System.Drawing.Point(119, 188)
        Me.bntAdd.Name = "bntAdd"
        Me.bntAdd.Size = New System.Drawing.Size(172, 23)
        Me.bntAdd.TabIndex = 3
        Me.bntAdd.Text = "Add Player"
        Me.bntAdd.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pbxAvatar)
        Me.GroupBox4.Controls.Add(Me.btnAvatar)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(3, 59)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(116, 152)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Avatar"
        '
        'pbxAvatar
        '
        Me.pbxAvatar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxAvatar.Location = New System.Drawing.Point(3, 39)
        Me.pbxAvatar.Name = "pbxAvatar"
        Me.pbxAvatar.Size = New System.Drawing.Size(110, 110)
        Me.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxAvatar.TabIndex = 1
        Me.pbxAvatar.TabStop = False
        '
        'btnAvatar
        '
        Me.btnAvatar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAvatar.Location = New System.Drawing.Point(3, 16)
        Me.btnAvatar.Name = "btnAvatar"
        Me.btnAvatar.Size = New System.Drawing.Size(110, 23)
        Me.btnAvatar.TabIndex = 0
        Me.btnAvatar.Text = "Choose Avatar"
        Me.btnAvatar.UseVisualStyleBackColor = True
        '
        'btnColour
        '
        Me.btnColour.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnColour.Location = New System.Drawing.Point(3, 36)
        Me.btnColour.Name = "btnColour"
        Me.btnColour.Size = New System.Drawing.Size(288, 23)
        Me.btnColour.TabIndex = 1
        Me.btnColour.Text = "Player Colour"
        Me.btnColour.UseVisualStyleBackColor = True
        '
        'tbxName
        '
        Me.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxName.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbxName.Location = New System.Drawing.Point(3, 16)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(288, 20)
        Me.tbxName.TabIndex = 0
        Me.tbxName.Text = "Player Name"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(801, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Game Setup"
        '
        'Defults
        '
        Me.Defults.ImageStream = CType(resources.GetObject("Defults.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Defults.TransparentColor = System.Drawing.Color.Transparent
        Me.Defults.Images.SetKeyName(0, "Easy_New.png")
        Me.Defults.Images.SetKeyName(1, "Medium_New.png")
        Me.Defults.Images.SetKeyName(2, "Hard.png")
        Me.Defults.Images.SetKeyName(3, "Impossible.png")
        '
        'ofdAvatar
        '
        Me.ofdAvatar.FileName = "OpenFileDialog1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 274)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(801, 290)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Game Options"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.pnlEli)
        Me.GroupBox7.Controls.Add(Me.pnlBest)
        Me.GroupBox7.Controls.Add(Me.Panel2)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(294, 22)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(504, 265)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Game"
        '
        'pnlEli
        '
        Me.pnlEli.Controls.Add(Me.Label8)
        Me.pnlEli.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlEli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlEli.Location = New System.Drawing.Point(203, 51)
        Me.pnlEli.Name = "pnlEli"
        Me.pnlEli.Size = New System.Drawing.Size(200, 211)
        Me.pnlEli.TabIndex = 4
        Me.pnlEli.TabStop = False
        Me.pnlEli.Text = "Eliminations"
        Me.pnlEli.Visible = False
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 192)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tiebreakers are who ever got a square first"
        '
        'pnlBest
        '
        Me.pnlBest.Controls.Add(Me.nudBest_of)
        Me.pnlBest.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBest.Location = New System.Drawing.Point(3, 51)
        Me.pnlBest.Name = "pnlBest"
        Me.pnlBest.Size = New System.Drawing.Size(200, 211)
        Me.pnlBest.TabIndex = 2
        Me.pnlBest.TabStop = False
        Me.pnlBest.Text = "Best Of"
        Me.pnlBest.Visible = False
        '
        'nudBest_of
        '
        Me.nudBest_of.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudBest_of.Location = New System.Drawing.Point(3, 16)
        Me.nudBest_of.Name = "nudBest_of"
        Me.nudBest_of.Size = New System.Drawing.Size(194, 20)
        Me.nudBest_of.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbxGame_Type)
        Me.Panel2.Controls.Add(Me.lblInfo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(498, 35)
        Me.Panel2.TabIndex = 3
        '
        'cbxGame_Type
        '
        Me.cbxGame_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGame_Type.FormattingEnabled = True
        Me.cbxGame_Type.Items.AddRange(New Object() {"Single Game", "Best of", "Eliminations"})
        Me.cbxGame_Type.Location = New System.Drawing.Point(3, 3)
        Me.cbxGame_Type.Name = "cbxGame_Type"
        Me.cbxGame_Type.Size = New System.Drawing.Size(121, 21)
        Me.cbxGame_Type.TabIndex = 0
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(130, 3)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(365, 35)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Single game is just one game where the player face off against each other"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnDefaults)
        Me.GroupBox6.Controls.Add(Me.cbxAvatars)
        Me.GroupBox6.Controls.Add(Me.cbxFillStyle)
        Me.GroupBox6.Controls.Add(Me.btnDot_Colour)
        Me.GroupBox6.Controls.Add(Me.nudLine_Width)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.nudDot_Size)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.nudSquare_Size)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Panel1)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(291, 265)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Board"
        '
        'btnDefaults
        '
        Me.btnDefaults.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDefaults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefaults.Location = New System.Drawing.Point(3, 218)
        Me.btnDefaults.Name = "btnDefaults"
        Me.btnDefaults.Size = New System.Drawing.Size(75, 44)
        Me.btnDefaults.TabIndex = 9
        Me.btnDefaults.Text = "Default"
        Me.btnDefaults.UseVisualStyleBackColor = True
        '
        'cbxAvatars
        '
        Me.cbxAvatars.AutoSize = True
        Me.cbxAvatars.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbxAvatars.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAvatars.Location = New System.Drawing.Point(3, 201)
        Me.cbxAvatars.Name = "cbxAvatars"
        Me.cbxAvatars.Size = New System.Drawing.Size(285, 17)
        Me.cbxAvatars.TabIndex = 11
        Me.cbxAvatars.Text = "Display Avatars on squares"
        Me.cbxAvatars.UseVisualStyleBackColor = True
        '
        'cbxFillStyle
        '
        Me.cbxFillStyle.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbxFillStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFillStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFillStyle.FormattingEnabled = True
        Me.cbxFillStyle.Items.AddRange(New Object() {"Transparent", "Percent05", "Percent10", "Percent20", "Percent30", "Percent40", "Percent50", "Percent60", "Percent70", "Percent80", "Percent90", "Solid", "Horizontal", "Vertical", "ForwardDiagonal", "BackwardDiagonal", "Cross", "DiagonalCross", "LightDownwardDiagonal", "LightUpwardDiagonal", "DarkDownwardDiagonal", "DarkUpwardDiagonal", "WideDownwardDiagonal", "WideUpwardDiagonal", "DashedDownwardDiagonal", "DashedUpwardDiagonal", "LightHorizontal", "LightVertical", "NarrowHorizontal", "NarrowVertical", "DarkHorizontal", "DarkVertical", "DashedHorizontal", "DashedVertical", "SmallConfetti", "LargeConfetti", "ZigZag", "Wave", "DiagonalBrick", "HorizontalBrick", "Weave", "Plaid", "Divot", "DottedGrid", "DottedDiamond", "Shingle", "Trellis", "Sphere", "SmallGrid", "SmallCheckerBoard", "LargeCheckerBoard", "OutlineShapedDiamond", "SolidDiamond"})
        Me.cbxFillStyle.Location = New System.Drawing.Point(3, 180)
        Me.cbxFillStyle.Name = "cbxFillStyle"
        Me.cbxFillStyle.Size = New System.Drawing.Size(285, 21)
        Me.cbxFillStyle.TabIndex = 10
        '
        'btnDot_Colour
        '
        Me.btnDot_Colour.BackColor = System.Drawing.Color.Black
        Me.btnDot_Colour.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDot_Colour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDot_Colour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDot_Colour.ForeColor = System.Drawing.Color.White
        Me.btnDot_Colour.Location = New System.Drawing.Point(3, 157)
        Me.btnDot_Colour.Name = "btnDot_Colour"
        Me.btnDot_Colour.Size = New System.Drawing.Size(285, 23)
        Me.btnDot_Colour.TabIndex = 8
        Me.btnDot_Colour.Text = "Dot Colour"
        Me.btnDot_Colour.UseVisualStyleBackColor = False
        '
        'nudLine_Width
        '
        Me.nudLine_Width.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudLine_Width.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLine_Width.Location = New System.Drawing.Point(3, 137)
        Me.nudLine_Width.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudLine_Width.Name = "nudLine_Width"
        Me.nudLine_Width.Size = New System.Drawing.Size(285, 20)
        Me.nudLine_Width.TabIndex = 7
        Me.nudLine_Width.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(285, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Line Width"
        '
        'nudDot_Size
        '
        Me.nudDot_Size.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudDot_Size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDot_Size.Location = New System.Drawing.Point(3, 102)
        Me.nudDot_Size.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudDot_Size.Name = "nudDot_Size"
        Me.nudDot_Size.Size = New System.Drawing.Size(285, 20)
        Me.nudDot_Size.TabIndex = 5
        Me.nudDot_Size.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(285, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dot Raduis"
        '
        'nudSquare_Size
        '
        Me.nudSquare_Size.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudSquare_Size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSquare_Size.Location = New System.Drawing.Point(3, 67)
        Me.nudSquare_Size.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudSquare_Size.Name = "nudSquare_Size"
        Me.nudSquare_Size.Size = New System.Drawing.Size(285, 20)
        Me.nudSquare_Size.TabIndex = 2
        Me.nudSquare_Size.Value = New Decimal(New Integer() {79, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Square Size"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.nudSize_Y)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.nudSize_X)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 21)
        Me.Panel1.TabIndex = 0
        '
        'nudSize_Y
        '
        Me.nudSize_Y.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSize_Y.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSize_Y.Location = New System.Drawing.Point(148, 0)
        Me.nudSize_Y.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSize_Y.Name = "nudSize_Y"
        Me.nudSize_Y.Size = New System.Drawing.Size(137, 20)
        Me.nudSize_Y.TabIndex = 2
        Me.nudSize_Y.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(136, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "x"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudSize_X
        '
        Me.nudSize_X.Dock = System.Windows.Forms.DockStyle.Left
        Me.nudSize_X.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSize_X.Location = New System.Drawing.Point(0, 0)
        Me.nudSize_X.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSize_X.Name = "nudSize_X"
        Me.nudSize_X.Size = New System.Drawing.Size(136, 20)
        Me.nudSize_X.TabIndex = 0
        Me.nudSize_X.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Board Size"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnBegin)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 564)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(801, 38)
        Me.Panel3.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(541, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 38)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBegin
        '
        Me.btnBegin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBegin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.Location = New System.Drawing.Point(671, 0)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(130, 38)
        Me.btnBegin.TabIndex = 0
        Me.btnBegin.Text = "Begin"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'Game_Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Game_Setup"
        Me.Size = New System.Drawing.Size(801, 697)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.pnlEditing.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.pbxAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.pnlEli.ResumeLayout(False)
        Me.pnlBest.ResumeLayout(False)
        CType(Me.nudBest_of, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.nudLine_Width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDot_Size, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSquare_Size, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.nudSize_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSize_X, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbxPlayers As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cbxType As System.Windows.Forms.ComboBox
    Friend WithEvents bntAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents btnAvatar As System.Windows.Forms.Button
    Friend WithEvents btnColour As System.Windows.Forms.Button
    Friend WithEvents tbxName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents pnlEditing As System.Windows.Forms.Panel
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Defults As System.Windows.Forms.ImageList
    Friend WithEvents cdgPick_Colour As System.Windows.Forms.ColorDialog
    Friend WithEvents ofdAvatar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSave_edit As System.Windows.Forms.Button
    Friend WithEvents btnCancel_Edit As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDot_Colour As System.Windows.Forms.Button
    Friend WithEvents nudLine_Width As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudDot_Size As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudSquare_Size As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents nudSize_Y As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudSize_X As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxGame_Type As System.Windows.Forms.ComboBox
    Friend WithEvents btnDefaults As System.Windows.Forms.Button
    Friend WithEvents pnlEli As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlBest As System.Windows.Forms.GroupBox
    Friend WithEvents nudBest_of As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnBegin As System.Windows.Forms.Button
    Friend WithEvents cbxFillStyle As System.Windows.Forms.ComboBox
    Friend WithEvents cbxAvatars As System.Windows.Forms.CheckBox

End Class
