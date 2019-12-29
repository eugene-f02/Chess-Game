<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLobby
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Catch ex As Exception

        Finally
        End Try
        Try
            MyBase.Dispose(disposing)
        Catch ex As Exception

        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLobby))
        Me.lblGameChess = New System.Windows.Forms.Label()
        Me.mnuLobby = New System.Windows.Forms.MenuStrip()
        Me.butPlay = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shpBorder4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpBorder3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpBorder2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpBorder1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.butGames = New System.Windows.Forms.Button()
        Me.butExit = New System.Windows.Forms.Button()
        Me.lstReport = New System.Windows.Forms.ListBox()
        Me.butBack = New System.Windows.Forms.Button()
        Me.picKingLobbyB = New System.Windows.Forms.PictureBox()
        Me.picKingLobbyW = New System.Windows.Forms.PictureBox()
        CType(Me.picKingLobbyB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKingLobbyW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGameChess
        '
        Me.lblGameChess.BackColor = System.Drawing.Color.Transparent
        Me.lblGameChess.Font = New System.Drawing.Font("Microsoft Sans Serif", 77.25!, System.Drawing.FontStyle.Bold)
        Me.lblGameChess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGameChess.Location = New System.Drawing.Point(324, 67)
        Me.lblGameChess.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblGameChess.Name = "lblGameChess"
        Me.lblGameChess.Size = New System.Drawing.Size(736, 267)
        Me.lblGameChess.TabIndex = 65
        Me.lblGameChess.Text = "Chess"
        Me.lblGameChess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuLobby
        '
        Me.mnuLobby.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuLobby.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuLobby.Location = New System.Drawing.Point(0, 0)
        Me.mnuLobby.Name = "mnuLobby"
        Me.mnuLobby.Size = New System.Drawing.Size(1384, 48)
        Me.mnuLobby.TabIndex = 66
        Me.mnuLobby.Text = "MenuStrip1"
        '
        'butPlay
        '
        Me.butPlay.BackColor = System.Drawing.Color.White
        Me.butPlay.Cursor = System.Windows.Forms.Cursors.Default
        Me.butPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.25!, System.Drawing.FontStyle.Bold)
        Me.butPlay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butPlay.Location = New System.Drawing.Point(510, 387)
        Me.butPlay.Margin = New System.Windows.Forms.Padding(6)
        Me.butPlay.Name = "butPlay"
        Me.butPlay.Size = New System.Drawing.Size(364, 154)
        Me.butPlay.TabIndex = 69
        Me.butPlay.Text = "&Play"
        Me.butPlay.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shpBorder4, Me.shpBorder3, Me.shpBorder2, Me.shpBorder1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1384, 935)
        Me.ShapeContainer1.TabIndex = 70
        Me.ShapeContainer1.TabStop = False
        '
        'shpBorder4
        '
        Me.shpBorder4.BorderColor = System.Drawing.Color.Transparent
        Me.shpBorder4.BorderWidth = 6
        Me.shpBorder4.Location = New System.Drawing.Point(483, 283)
        Me.shpBorder4.Name = "shpBorder4"
        Me.shpBorder4.Size = New System.Drawing.Size(182, 80)
        '
        'shpBorder3
        '
        Me.shpBorder3.BorderColor = System.Drawing.Color.Transparent
        Me.shpBorder3.BorderWidth = 6
        Me.shpBorder3.Location = New System.Drawing.Point(255, 394)
        Me.shpBorder3.Name = "shpBorder3"
        Me.shpBorder3.Size = New System.Drawing.Size(182, 80)
        '
        'shpBorder2
        '
        Me.shpBorder2.BorderColor = System.Drawing.Color.Transparent
        Me.shpBorder2.BorderWidth = 6
        Me.shpBorder2.Location = New System.Drawing.Point(255, 298)
        Me.shpBorder2.Name = "shpBorder2"
        Me.shpBorder2.Size = New System.Drawing.Size(182, 80)
        '
        'shpBorder1
        '
        Me.shpBorder1.BorderColor = System.Drawing.Color.Transparent
        Me.shpBorder1.BorderWidth = 6
        Me.shpBorder1.Location = New System.Drawing.Point(255, 201)
        Me.shpBorder1.Name = "shpBorder1"
        Me.shpBorder1.Size = New System.Drawing.Size(182, 80)
        '
        'butGames
        '
        Me.butGames.BackColor = System.Drawing.Color.White
        Me.butGames.Cursor = System.Windows.Forms.Cursors.Default
        Me.butGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.butGames.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butGames.Location = New System.Drawing.Point(510, 573)
        Me.butGames.Margin = New System.Windows.Forms.Padding(6)
        Me.butGames.Name = "butGames"
        Me.butGames.Size = New System.Drawing.Size(364, 154)
        Me.butGames.TabIndex = 71
        Me.butGames.Text = "Previous Games"
        Me.butGames.UseVisualStyleBackColor = False
        '
        'butExit
        '
        Me.butExit.BackColor = System.Drawing.Color.White
        Me.butExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.butExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.25!, System.Drawing.FontStyle.Bold)
        Me.butExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butExit.Location = New System.Drawing.Point(510, 758)
        Me.butExit.Margin = New System.Windows.Forms.Padding(6)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(364, 154)
        Me.butExit.TabIndex = 72
        Me.butExit.Text = "&Exit"
        Me.butExit.UseVisualStyleBackColor = False
        '
        'lstReport
        '
        Me.lstReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lstReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lstReport.FormattingEnabled = True
        Me.lstReport.HorizontalScrollbar = True
        Me.lstReport.ItemHeight = 37
        Me.lstReport.Location = New System.Drawing.Point(980, 387)
        Me.lstReport.Margin = New System.Windows.Forms.Padding(6)
        Me.lstReport.Name = "lstReport"
        Me.lstReport.Size = New System.Drawing.Size(312, 448)
        Me.lstReport.TabIndex = 73
        '
        'butBack
        '
        Me.butBack.BackColor = System.Drawing.Color.White
        Me.butBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.butBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.butBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butBack.Location = New System.Drawing.Point(510, 756)
        Me.butBack.Margin = New System.Windows.Forms.Padding(6)
        Me.butBack.Name = "butBack"
        Me.butBack.Size = New System.Drawing.Size(364, 154)
        Me.butBack.TabIndex = 74
        Me.butBack.Text = "&Back to Lobby"
        Me.butBack.UseVisualStyleBackColor = False
        '
        'picKingLobbyB
        '
        Me.picKingLobbyB.BackColor = System.Drawing.Color.Transparent
        Me.picKingLobbyB.Image = CType(resources.GetObject("picKingLobbyB.Image"), System.Drawing.Image)
        Me.picKingLobbyB.Location = New System.Drawing.Point(152, 180)
        Me.picKingLobbyB.Margin = New System.Windows.Forms.Padding(6)
        Me.picKingLobbyB.Name = "picKingLobbyB"
        Me.picKingLobbyB.Size = New System.Drawing.Size(160, 154)
        Me.picKingLobbyB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingLobbyB.TabIndex = 82
        Me.picKingLobbyB.TabStop = False
        '
        'picKingLobbyW
        '
        Me.picKingLobbyW.BackColor = System.Drawing.Color.Transparent
        Me.picKingLobbyW.Image = CType(resources.GetObject("picKingLobbyW.Image"), System.Drawing.Image)
        Me.picKingLobbyW.Location = New System.Drawing.Point(1072, 180)
        Me.picKingLobbyW.Margin = New System.Windows.Forms.Padding(6)
        Me.picKingLobbyW.Name = "picKingLobbyW"
        Me.picKingLobbyW.Size = New System.Drawing.Size(160, 154)
        Me.picKingLobbyW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingLobbyW.TabIndex = 85
        Me.picKingLobbyW.TabStop = False
        '
        'frmLobby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1384, 935)
        Me.Controls.Add(Me.picKingLobbyW)
        Me.Controls.Add(Me.picKingLobbyB)
        Me.Controls.Add(Me.butBack)
        Me.Controls.Add(Me.lstReport)
        Me.Controls.Add(Me.butPlay)
        Me.Controls.Add(Me.butExit)
        Me.Controls.Add(Me.butGames)
        Me.Controls.Add(Me.mnuLobby)
        Me.Controls.Add(Me.lblGameChess)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuLobby
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmLobby"
        Me.ShowIcon = False
        Me.Text = "Chess"
        CType(Me.picKingLobbyB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKingLobbyW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGameChess As System.Windows.Forms.Label
    Friend WithEvents mnuLobby As System.Windows.Forms.MenuStrip
    Friend WithEvents butPlay As System.Windows.Forms.Button
    Friend WithEvents butGames As System.Windows.Forms.Button
    Friend WithEvents butExit As System.Windows.Forms.Button
    Friend WithEvents lstReport As System.Windows.Forms.ListBox
    Friend WithEvents butBack As System.Windows.Forms.Button
    Friend WithEvents picKingLobbyB As System.Windows.Forms.PictureBox
    Friend WithEvents picKingLobbyW As System.Windows.Forms.PictureBox
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents shpBorder1 As PowerPacks.RectangleShape
    Private WithEvents shpBorder3 As PowerPacks.RectangleShape
    Private WithEvents shpBorder2 As PowerPacks.RectangleShape
    Private WithEvents shpBorder4 As PowerPacks.RectangleShape
End Class
