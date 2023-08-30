<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Player
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbxPlayerAvatar = New System.Windows.Forms.PictureBox()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.pnlPlayerColour = New System.Windows.Forms.Panel()
        Me.lblGames_Won = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxPlayerAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pbxPlayerAvatar)
        Me.Panel1.Controls.Add(Me.lblPlayerName)
        Me.Panel1.Controls.Add(Me.lblPlayerScore)
        Me.Panel1.Controls.Add(Me.lblGames_Won)
        Me.Panel1.Controls.Add(Me.pnlPlayerColour)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 241)
        Me.Panel1.TabIndex = 3
        '
        'pbxPlayerAvatar
        '
        Me.pbxPlayerAvatar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxPlayerAvatar.Location = New System.Drawing.Point(0, 0)
        Me.pbxPlayerAvatar.Name = "pbxPlayerAvatar"
        Me.pbxPlayerAvatar.Size = New System.Drawing.Size(177, 146)
        Me.pbxPlayerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxPlayerAvatar.TabIndex = 5
        Me.pbxPlayerAvatar.TabStop = False
        '
        'lblPlayerName
        '
        Me.lblPlayerName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(0, 146)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(177, 23)
        Me.lblPlayerName.TabIndex = 2
        Me.lblPlayerName.Text = "Player Name"
        Me.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPlayerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.Location = New System.Drawing.Point(0, 169)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(177, 23)
        Me.lblPlayerScore.TabIndex = 3
        Me.lblPlayerScore.Text = "Score: 0"
        Me.lblPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPlayerColour
        '
        Me.pnlPlayerColour.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlPlayerColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPlayerColour.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPlayerColour.Location = New System.Drawing.Point(0, 215)
        Me.pnlPlayerColour.Name = "pnlPlayerColour"
        Me.pnlPlayerColour.Size = New System.Drawing.Size(177, 24)
        Me.pnlPlayerColour.TabIndex = 4
        '
        'lblGames_Won
        '
        Me.lblGames_Won.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblGames_Won.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lblGames_Won.Location = New System.Drawing.Point(0, 192)
        Me.lblGames_Won.Name = "lblGames_Won"
        Me.lblGames_Won.Size = New System.Drawing.Size(177, 23)
        Me.lblGames_Won.TabIndex = 6
        Me.lblGames_Won.Text = "Games Won: 0"
        Me.lblGames_Won.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGames_Won.Visible = False
        '
        'Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Player"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.Size = New System.Drawing.Size(197, 259)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbxPlayerAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbxPlayerAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents lblPlayerScore As System.Windows.Forms.Label
    Friend WithEvents pnlPlayerColour As System.Windows.Forms.Panel
    Friend WithEvents lblGames_Won As System.Windows.Forms.Label

End Class
