<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Board
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
        Me.lbl_Game_Info = New System.Windows.Forms.Label()
        Me.pnl_board = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lbl_Game_Info
        '
        Me.lbl_Game_Info.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_Game_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Game_Info.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Game_Info.Name = "lbl_Game_Info"
        Me.lbl_Game_Info.Size = New System.Drawing.Size(764, 23)
        Me.lbl_Game_Info.TabIndex = 0
        Me.lbl_Game_Info.Text = "No Game Currently Happening"
        Me.lbl_Game_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_board
        '
        Me.pnl_board.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_board.Location = New System.Drawing.Point(177, 36)
        Me.pnl_board.Name = "pnl_board"
        Me.pnl_board.Size = New System.Drawing.Size(200, 100)
        Me.pnl_board.TabIndex = 1
        '
        'Board
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_board)
        Me.Controls.Add(Me.lbl_Game_Info)
        Me.Name = "Board"
        Me.Size = New System.Drawing.Size(764, 591)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Game_Info As System.Windows.Forms.Label
    Friend WithEvents pnl_board As System.Windows.Forms.Panel

End Class
