<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Main Menu")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Side Bars")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Players")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Game")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Game Setup", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Game Board")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Layout", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Program", New System.Windows.Forms.TreeNode() {TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Create New Player")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edit Existing Player")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Delete Player")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Game Setup")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Game Types")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Starting A Game", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rules")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Playing The Game", New System.Windows.Forms.TreeNode() {TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Computer Players")
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "hlpPLMenu"
        TreeNode1.Text = "Main Menu"
        TreeNode2.Name = "hlpPLSides"
        TreeNode2.Text = "Side Bars"
        TreeNode3.Name = "hlpPLGPlayers"
        TreeNode3.Text = "Players"
        TreeNode4.Name = "hlpPLGGame"
        TreeNode4.Text = "Game"
        TreeNode5.Name = "hlpPLSetup"
        TreeNode5.Text = "Game Setup"
        TreeNode6.Name = "hlpPLGameBoard"
        TreeNode6.Text = "Game Board"
        TreeNode7.Name = "hlpPLayout"
        TreeNode7.Text = "Layout"
        TreeNode8.Name = "hlpProgram"
        TreeNode8.Text = "Program"
        TreeNode9.Name = "hlpPSPlayers"
        TreeNode9.Text = "Create New Player"
        TreeNode10.Name = "hlpPSPlayers2"
        TreeNode10.Text = "Edit Existing Player"
        TreeNode11.Name = "hlpPSPlayers3"
        TreeNode11.Text = "Delete Player"
        TreeNode12.Name = "hlpGame"
        TreeNode12.Text = "Game Setup"
        TreeNode13.Name = "hlpPSGame2"
        TreeNode13.Text = "Game Types"
        TreeNode14.Name = "hlpStartingGame"
        TreeNode14.Text = "Starting A Game"
        TreeNode15.Name = "hlpPPRules"
        TreeNode15.Text = "Rules"
        TreeNode16.Name = "hlpGame"
        TreeNode16.Text = "Playing The Game"
        TreeNode17.Name = "hlpAIs"
        TreeNode17.Text = "Computer Players"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode14, TreeNode16, TreeNode17})
        Me.TreeView1.Size = New System.Drawing.Size(264, 749)
        Me.TreeView1.TabIndex = 0
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Help"
        Me.Size = New System.Drawing.Size(704, 749)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
