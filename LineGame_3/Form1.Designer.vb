<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.mitNewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mitOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mitExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnView = New System.Windows.Forms.ToolStripButton()
        Me.btnHelp = New System.Windows.Forms.ToolStripButton()
        Me.pnlBoard = New System.Windows.Forms.Panel()
        Me.pnlPlayers2 = New System.Windows.Forms.Panel()
        Me.pnlPlayers1 = New System.Windows.Forms.Panel()
        Me.Defualt_Image = New System.Windows.Forms.PictureBox()
        Me.Inbetween_Turns = New System.Windows.Forms.Timer(Me.components)
        Me.Board1 = New LineGame_3.Board()
        Me.Game_Setup1 = New LineGame_3.Game_Setup()
        Me.View_Options1 = New LineGame_3.View_Options()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlBoard.SuspendLayout()
        CType(Me.Defualt_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.btnView, Me.btnHelp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(761, 30)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.AutoSize = False
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownButtonWidth = 20
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitNewGame, Me.mitRestart, Me.ToolStripSeparator1, Me.mitOptions, Me.ToolStripSeparator2, Me.mitExit})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(47, 27)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'mitNewGame
        '
        Me.mitNewGame.Enabled = False
        Me.mitNewGame.Image = CType(resources.GetObject("mitNewGame.Image"), System.Drawing.Image)
        Me.mitNewGame.Name = "mitNewGame"
        Me.mitNewGame.Size = New System.Drawing.Size(150, 22)
        Me.mitNewGame.Text = "New Game"
        '
        'mitRestart
        '
        Me.mitRestart.Enabled = False
        Me.mitRestart.Image = CType(resources.GetObject("mitRestart.Image"), System.Drawing.Image)
        Me.mitRestart.Name = "mitRestart"
        Me.mitRestart.Size = New System.Drawing.Size(150, 22)
        Me.mitRestart.Text = "Restart"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'mitOptions
        '
        Me.mitOptions.Image = CType(resources.GetObject("mitOptions.Image"), System.Drawing.Image)
        Me.mitOptions.Name = "mitOptions"
        Me.mitOptions.Size = New System.Drawing.Size(150, 22)
        Me.mitOptions.Text = "Game Options"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'mitExit
        '
        Me.mitExit.Image = CType(resources.GetObject("mitExit.Image"), System.Drawing.Image)
        Me.mitExit.Name = "mitExit"
        Me.mitExit.Size = New System.Drawing.Size(150, 22)
        Me.mitExit.Text = "Exit"
        '
        'btnView
        '
        Me.btnView.AutoSize = False
        Me.btnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(27, 27)
        Me.btnView.Text = "View"
        '
        'btnHelp
        '
        Me.btnHelp.AutoSize = False
        Me.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(27, 27)
        Me.btnHelp.Text = "Help"
        '
        'pnlBoard
        '
        Me.pnlBoard.Controls.Add(Me.Board1)
        Me.pnlBoard.Controls.Add(Me.View_Options1)
        Me.pnlBoard.Controls.Add(Me.Game_Setup1)
        Me.pnlBoard.Controls.Add(Me.pnlPlayers2)
        Me.pnlBoard.Controls.Add(Me.pnlPlayers1)
        Me.pnlBoard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBoard.Location = New System.Drawing.Point(0, 30)
        Me.pnlBoard.Name = "pnlBoard"
        Me.pnlBoard.Size = New System.Drawing.Size(761, 595)
        Me.pnlBoard.TabIndex = 1
        '
        'pnlPlayers2
        '
        Me.pnlPlayers2.BackColor = System.Drawing.SystemColors.Control
        Me.pnlPlayers2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlPlayers2.Location = New System.Drawing.Point(579, 0)
        Me.pnlPlayers2.Name = "pnlPlayers2"
        Me.pnlPlayers2.Size = New System.Drawing.Size(182, 595)
        Me.pnlPlayers2.TabIndex = 1
        '
        'pnlPlayers1
        '
        Me.pnlPlayers1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlPlayers1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlPlayers1.Location = New System.Drawing.Point(0, 0)
        Me.pnlPlayers1.Name = "pnlPlayers1"
        Me.pnlPlayers1.Size = New System.Drawing.Size(182, 595)
        Me.pnlPlayers1.TabIndex = 0
        '
        'Defualt_Image
        '
        Me.Defualt_Image.Image = CType(resources.GetObject("Defualt_Image.Image"), System.Drawing.Image)
        Me.Defualt_Image.Location = New System.Drawing.Point(751, 0)
        Me.Defualt_Image.Name = "Defualt_Image"
        Me.Defualt_Image.Size = New System.Drawing.Size(10, 14)
        Me.Defualt_Image.TabIndex = 2
        Me.Defualt_Image.TabStop = False
        Me.Defualt_Image.Visible = False
        '
        'Inbetween_Turns
        '
        Me.Inbetween_Turns.Interval = 200
        '
        'Board1
        '
        Me.Board1.BackColor = System.Drawing.SystemColors.Control
        Me.Board1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Board1.Location = New System.Drawing.Point(182, 0)
        Me.Board1.Name = "Board1"
        Me.Board1.Size = New System.Drawing.Size(397, 595)
        Me.Board1.TabIndex = 3
        '
        'Game_Setup1
        '
        Me.Game_Setup1.BackColor = System.Drawing.SystemColors.Control
        Me.Game_Setup1.Location = New System.Drawing.Point(182, 350)
        Me.Game_Setup1.Name = "Game_Setup1"
        Me.Game_Setup1.Size = New System.Drawing.Size(397, 250)
        Me.Game_Setup1.TabIndex = 2
        Me.Game_Setup1.Visible = False
        '
        'View_Options1
        '
        Me.View_Options1.Location = New System.Drawing.Point(188, 29)
        Me.View_Options1.Name = "View_Options1"
        Me.View_Options1.Size = New System.Drawing.Size(219, 262)
        Me.View_Options1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(761, 625)
        Me.Controls.Add(Me.Defualt_Image)
        Me.Controls.Add(Me.pnlBoard)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlBoard.ResumeLayout(False)
        CType(Me.Defualt_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents pnlBoard As System.Windows.Forms.Panel
    Friend WithEvents pnlPlayers2 As System.Windows.Forms.Panel
    Friend WithEvents pnlPlayers1 As System.Windows.Forms.Panel
    Friend WithEvents Defualt_Image As System.Windows.Forms.PictureBox
    Friend WithEvents Game_Setup1 As LineGame_3.Game_Setup
    Friend WithEvents Board1 As LineGame_3.Board
    Friend WithEvents Inbetween_Turns As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents mitNewGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitRestart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mitOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mitExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnView As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents View_Options1 As LineGame_3.View_Options

End Class
