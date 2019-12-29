<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChess
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
        End Try
        Try
            MyBase.Dispose(disposing)
        Catch ex As Exception
            'MsgBox(ex.Message)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChess))
        Me.picKingB = New System.Windows.Forms.PictureBox()
        Me.dgvChess = New System.Windows.Forms.DataGridView()
        Me.picKingW = New System.Windows.Forms.PictureBox()
        Me.picPawnW1 = New System.Windows.Forms.PictureBox()
        Me.picPawnW2 = New System.Windows.Forms.PictureBox()
        Me.picPawnW6 = New System.Windows.Forms.PictureBox()
        Me.picPawnW5 = New System.Windows.Forms.PictureBox()
        Me.picPawnW4 = New System.Windows.Forms.PictureBox()
        Me.picPawnW3 = New System.Windows.Forms.PictureBox()
        Me.picPawnW8 = New System.Windows.Forms.PictureBox()
        Me.picPawnW7 = New System.Windows.Forms.PictureBox()
        Me.picPawnB1 = New System.Windows.Forms.PictureBox()
        Me.picPawnB8 = New System.Windows.Forms.PictureBox()
        Me.picPawnB4 = New System.Windows.Forms.PictureBox()
        Me.picPawnB7 = New System.Windows.Forms.PictureBox()
        Me.picPawnB3 = New System.Windows.Forms.PictureBox()
        Me.picPawnB6 = New System.Windows.Forms.PictureBox()
        Me.picPawnB2 = New System.Windows.Forms.PictureBox()
        Me.picPawnB5 = New System.Windows.Forms.PictureBox()
        Me.picQueenW = New System.Windows.Forms.PictureBox()
        Me.picQueenB = New System.Windows.Forms.PictureBox()
        Me.picKnightW1 = New System.Windows.Forms.PictureBox()
        Me.picKnightW2 = New System.Windows.Forms.PictureBox()
        Me.picKnightB1 = New System.Windows.Forms.PictureBox()
        Me.picKnightB2 = New System.Windows.Forms.PictureBox()
        Me.picBishopW1 = New System.Windows.Forms.PictureBox()
        Me.picBishopW2 = New System.Windows.Forms.PictureBox()
        Me.picBishopB1 = New System.Windows.Forms.PictureBox()
        Me.picBishopB2 = New System.Windows.Forms.PictureBox()
        Me.picRockW1 = New System.Windows.Forms.PictureBox()
        Me.picRockW2 = New System.Windows.Forms.PictureBox()
        Me.picRockB1 = New System.Windows.Forms.PictureBox()
        Me.picRockB2 = New System.Windows.Forms.PictureBox()
        Me.picQueenW1 = New System.Windows.Forms.PictureBox()
        Me.picQueenW4 = New System.Windows.Forms.PictureBox()
        Me.picQueenW5 = New System.Windows.Forms.PictureBox()
        Me.picQueenW2 = New System.Windows.Forms.PictureBox()
        Me.picQueenW3 = New System.Windows.Forms.PictureBox()
        Me.picQueenW7 = New System.Windows.Forms.PictureBox()
        Me.picQueenW8 = New System.Windows.Forms.PictureBox()
        Me.picQueenW6 = New System.Windows.Forms.PictureBox()
        Me.picQueenB8 = New System.Windows.Forms.PictureBox()
        Me.picQueenB7 = New System.Windows.Forms.PictureBox()
        Me.picQueenB6 = New System.Windows.Forms.PictureBox()
        Me.picQueenB5 = New System.Windows.Forms.PictureBox()
        Me.picQueenB4 = New System.Windows.Forms.PictureBox()
        Me.picQueenB3 = New System.Windows.Forms.PictureBox()
        Me.picQueenB2 = New System.Windows.Forms.PictureBox()
        Me.picQueenB1 = New System.Windows.Forms.PictureBox()
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.butStart = New System.Windows.Forms.Button()
        Me.mnuChess = New System.Windows.Forms.MenuStrip()
        Me.mnuGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMin1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMin5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMin10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorOrig = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuColorGrey = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuColorYel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuColorBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuColorCust = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFontOri = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFontCust = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrTime1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblColon2 = New System.Windows.Forms.Label()
        Me.lblTimeSec2 = New System.Windows.Forms.Label()
        Me.lblTimeMin2 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.tmrTime2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrResult = New System.Windows.Forms.Timer(Me.components)
        Me.butBack = New System.Windows.Forms.Button()
        Me.lblColon1 = New System.Windows.Forms.Label()
        Me.lblTimeSec1 = New System.Windows.Forms.Label()
        Me.lblTimeMin1 = New System.Windows.Forms.Label()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.lblMate = New System.Windows.Forms.Label()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.shpBorder5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shpBorder4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.picLogoQueenB = New System.Windows.Forms.PictureBox()
        Me.chkReport = New System.Windows.Forms.CheckBox()
        Me.lblScoreWhite = New System.Windows.Forms.Label()
        Me.lblScoreBlack = New System.Windows.Forms.Label()
        Me.picLogoQueenW = New System.Windows.Forms.PictureBox()
        Me.ttpMate = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpScoreW = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpScoreB = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picKingB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvChess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKingW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnW1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnW2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnW6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnW5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnW4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnW3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnW8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnW7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnB8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnB7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnB6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPawnB5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKnightW1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKnightW2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKnightB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKnightB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBishopW1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBishopW2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBishopB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBishopB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRockW1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRockW2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRockB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRockB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenW1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenW4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenW5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenW2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenW3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenW7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenW8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenW6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenB8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenB7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenB6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenB5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuChess.SuspendLayout()
        CType(Me.picLogoQueenB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogoQueenW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picKingB
        '
        Me.picKingB.BackColor = System.Drawing.Color.Transparent
        Me.picKingB.Image = CType(resources.GetObject("picKingB.Image"), System.Drawing.Image)
        Me.picKingB.Location = New System.Drawing.Point(0, 0)
        Me.picKingB.Name = "picKingB"
        Me.picKingB.Size = New System.Drawing.Size(80, 80)
        Me.picKingB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingB.TabIndex = 1
        Me.picKingB.TabStop = False
        '
        'dgvChess
        '
        Me.dgvChess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvChess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChess.Location = New System.Drawing.Point(0, 0)
        Me.dgvChess.Name = "dgvChess"
        Me.dgvChess.RowHeadersWidth = 82
        Me.dgvChess.Size = New System.Drawing.Size(643, 643)
        Me.dgvChess.TabIndex = 0
        '
        'picKingW
        '
        Me.picKingW.BackColor = System.Drawing.Color.Transparent
        Me.picKingW.Image = CType(resources.GetObject("picKingW.Image"), System.Drawing.Image)
        Me.picKingW.Location = New System.Drawing.Point(0, 86)
        Me.picKingW.Name = "picKingW"
        Me.picKingW.Size = New System.Drawing.Size(80, 80)
        Me.picKingW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingW.TabIndex = 2
        Me.picKingW.TabStop = False
        '
        'picPawnW1
        '
        Me.picPawnW1.BackColor = System.Drawing.Color.Transparent
        Me.picPawnW1.Image = CType(resources.GetObject("picPawnW1.Image"), System.Drawing.Image)
        Me.picPawnW1.Location = New System.Drawing.Point(86, 344)
        Me.picPawnW1.Name = "picPawnW1"
        Me.picPawnW1.Size = New System.Drawing.Size(80, 80)
        Me.picPawnW1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnW1.TabIndex = 3
        Me.picPawnW1.TabStop = False
        '
        'picPawnW2
        '
        Me.picPawnW2.BackColor = System.Drawing.Color.Transparent
        Me.picPawnW2.Image = CType(resources.GetObject("picPawnW2.Image"), System.Drawing.Image)
        Me.picPawnW2.Location = New System.Drawing.Point(0, 344)
        Me.picPawnW2.Name = "picPawnW2"
        Me.picPawnW2.Size = New System.Drawing.Size(80, 80)
        Me.picPawnW2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnW2.TabIndex = 4
        Me.picPawnW2.TabStop = False
        '
        'picPawnW6
        '
        Me.picPawnW6.BackColor = System.Drawing.Color.Transparent
        Me.picPawnW6.Image = CType(resources.GetObject("picPawnW6.Image"), System.Drawing.Image)
        Me.picPawnW6.Location = New System.Drawing.Point(86, 430)
        Me.picPawnW6.Name = "picPawnW6"
        Me.picPawnW6.Size = New System.Drawing.Size(80, 80)
        Me.picPawnW6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnW6.TabIndex = 5
        Me.picPawnW6.TabStop = False
        '
        'picPawnW5
        '
        Me.picPawnW5.BackColor = System.Drawing.Color.Transparent
        Me.picPawnW5.Image = CType(resources.GetObject("picPawnW5.Image"), System.Drawing.Image)
        Me.picPawnW5.Location = New System.Drawing.Point(0, 430)
        Me.picPawnW5.Name = "picPawnW5"
        Me.picPawnW5.Size = New System.Drawing.Size(80, 80)
        Me.picPawnW5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnW5.TabIndex = 6
        Me.picPawnW5.TabStop = False
        '
        'picPawnW4
        '
        Me.picPawnW4.BackColor = System.Drawing.Color.Transparent
        Me.picPawnW4.Image = CType(resources.GetObject("picPawnW4.Image"), System.Drawing.Image)
        Me.picPawnW4.Location = New System.Drawing.Point(258, 344)
        Me.picPawnW4.Name = "picPawnW4"
        Me.picPawnW4.Size = New System.Drawing.Size(80, 80)
        Me.picPawnW4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnW4.TabIndex = 7
        Me.picPawnW4.TabStop = False
        '
        'picPawnW3
        '
        Me.picPawnW3.BackColor = System.Drawing.Color.Transparent
        Me.picPawnW3.Image = CType(resources.GetObject("picPawnW3.Image"), System.Drawing.Image)
        Me.picPawnW3.Location = New System.Drawing.Point(172, 344)
        Me.picPawnW3.Name = "picPawnW3"
        Me.picPawnW3.Size = New System.Drawing.Size(80, 80)
        Me.picPawnW3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnW3.TabIndex = 8
        Me.picPawnW3.TabStop = False
        '
        'picPawnW8
        '
        Me.picPawnW8.BackColor = System.Drawing.Color.Transparent
        Me.picPawnW8.Image = CType(resources.GetObject("picPawnW8.Image"), System.Drawing.Image)
        Me.picPawnW8.Location = New System.Drawing.Point(258, 430)
        Me.picPawnW8.Name = "picPawnW8"
        Me.picPawnW8.Size = New System.Drawing.Size(80, 80)
        Me.picPawnW8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnW8.TabIndex = 9
        Me.picPawnW8.TabStop = False
        '
        'picPawnW7
        '
        Me.picPawnW7.BackColor = System.Drawing.Color.Transparent
        Me.picPawnW7.Image = CType(resources.GetObject("picPawnW7.Image"), System.Drawing.Image)
        Me.picPawnW7.Location = New System.Drawing.Point(172, 430)
        Me.picPawnW7.Name = "picPawnW7"
        Me.picPawnW7.Size = New System.Drawing.Size(80, 80)
        Me.picPawnW7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnW7.TabIndex = 10
        Me.picPawnW7.TabStop = False
        '
        'picPawnB1
        '
        Me.picPawnB1.BackColor = System.Drawing.Color.Transparent
        Me.picPawnB1.Image = CType(resources.GetObject("picPawnB1.Image"), System.Drawing.Image)
        Me.picPawnB1.Location = New System.Drawing.Point(0, 172)
        Me.picPawnB1.Name = "picPawnB1"
        Me.picPawnB1.Size = New System.Drawing.Size(80, 80)
        Me.picPawnB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnB1.TabIndex = 11
        Me.picPawnB1.TabStop = False
        '
        'picPawnB8
        '
        Me.picPawnB8.BackColor = System.Drawing.Color.Transparent
        Me.picPawnB8.Image = CType(resources.GetObject("picPawnB8.Image"), System.Drawing.Image)
        Me.picPawnB8.Location = New System.Drawing.Point(258, 258)
        Me.picPawnB8.Name = "picPawnB8"
        Me.picPawnB8.Size = New System.Drawing.Size(80, 80)
        Me.picPawnB8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnB8.TabIndex = 12
        Me.picPawnB8.TabStop = False
        '
        'picPawnB4
        '
        Me.picPawnB4.BackColor = System.Drawing.Color.Transparent
        Me.picPawnB4.Image = CType(resources.GetObject("picPawnB4.Image"), System.Drawing.Image)
        Me.picPawnB4.Location = New System.Drawing.Point(258, 172)
        Me.picPawnB4.Name = "picPawnB4"
        Me.picPawnB4.Size = New System.Drawing.Size(80, 80)
        Me.picPawnB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnB4.TabIndex = 13
        Me.picPawnB4.TabStop = False
        '
        'picPawnB7
        '
        Me.picPawnB7.BackColor = System.Drawing.Color.Transparent
        Me.picPawnB7.Image = CType(resources.GetObject("picPawnB7.Image"), System.Drawing.Image)
        Me.picPawnB7.Location = New System.Drawing.Point(172, 258)
        Me.picPawnB7.Name = "picPawnB7"
        Me.picPawnB7.Size = New System.Drawing.Size(80, 80)
        Me.picPawnB7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnB7.TabIndex = 14
        Me.picPawnB7.TabStop = False
        '
        'picPawnB3
        '
        Me.picPawnB3.BackColor = System.Drawing.Color.Transparent
        Me.picPawnB3.Image = CType(resources.GetObject("picPawnB3.Image"), System.Drawing.Image)
        Me.picPawnB3.Location = New System.Drawing.Point(172, 172)
        Me.picPawnB3.Name = "picPawnB3"
        Me.picPawnB3.Size = New System.Drawing.Size(80, 80)
        Me.picPawnB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnB3.TabIndex = 15
        Me.picPawnB3.TabStop = False
        '
        'picPawnB6
        '
        Me.picPawnB6.BackColor = System.Drawing.Color.Transparent
        Me.picPawnB6.Image = CType(resources.GetObject("picPawnB6.Image"), System.Drawing.Image)
        Me.picPawnB6.Location = New System.Drawing.Point(86, 258)
        Me.picPawnB6.Name = "picPawnB6"
        Me.picPawnB6.Size = New System.Drawing.Size(80, 80)
        Me.picPawnB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnB6.TabIndex = 16
        Me.picPawnB6.TabStop = False
        '
        'picPawnB2
        '
        Me.picPawnB2.BackColor = System.Drawing.Color.Transparent
        Me.picPawnB2.Image = CType(resources.GetObject("picPawnB2.Image"), System.Drawing.Image)
        Me.picPawnB2.Location = New System.Drawing.Point(86, 172)
        Me.picPawnB2.Name = "picPawnB2"
        Me.picPawnB2.Size = New System.Drawing.Size(80, 80)
        Me.picPawnB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnB2.TabIndex = 17
        Me.picPawnB2.TabStop = False
        '
        'picPawnB5
        '
        Me.picPawnB5.BackColor = System.Drawing.Color.Transparent
        Me.picPawnB5.Image = CType(resources.GetObject("picPawnB5.Image"), System.Drawing.Image)
        Me.picPawnB5.Location = New System.Drawing.Point(0, 258)
        Me.picPawnB5.Name = "picPawnB5"
        Me.picPawnB5.Size = New System.Drawing.Size(80, 80)
        Me.picPawnB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPawnB5.TabIndex = 18
        Me.picPawnB5.TabStop = False
        '
        'picQueenW
        '
        Me.picQueenW.BackColor = System.Drawing.Color.Transparent
        Me.picQueenW.Image = CType(resources.GetObject("picQueenW.Image"), System.Drawing.Image)
        Me.picQueenW.Location = New System.Drawing.Point(563, 0)
        Me.picQueenW.Name = "picQueenW"
        Me.picQueenW.Size = New System.Drawing.Size(80, 80)
        Me.picQueenW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenW.TabIndex = 19
        Me.picQueenW.TabStop = False
        '
        'picQueenB
        '
        Me.picQueenB.BackColor = System.Drawing.Color.Transparent
        Me.picQueenB.Image = CType(resources.GetObject("picQueenB.Image"), System.Drawing.Image)
        Me.picQueenB.Location = New System.Drawing.Point(477, 0)
        Me.picQueenB.Name = "picQueenB"
        Me.picQueenB.Size = New System.Drawing.Size(80, 80)
        Me.picQueenB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenB.TabIndex = 20
        Me.picQueenB.TabStop = False
        '
        'picKnightW1
        '
        Me.picKnightW1.BackColor = System.Drawing.Color.Transparent
        Me.picKnightW1.Image = CType(resources.GetObject("picKnightW1.Image"), System.Drawing.Image)
        Me.picKnightW1.Location = New System.Drawing.Point(563, 86)
        Me.picKnightW1.Name = "picKnightW1"
        Me.picKnightW1.Size = New System.Drawing.Size(80, 80)
        Me.picKnightW1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKnightW1.TabIndex = 21
        Me.picKnightW1.TabStop = False
        '
        'picKnightW2
        '
        Me.picKnightW2.BackColor = System.Drawing.Color.Transparent
        Me.picKnightW2.Image = CType(resources.GetObject("picKnightW2.Image"), System.Drawing.Image)
        Me.picKnightW2.Location = New System.Drawing.Point(477, 86)
        Me.picKnightW2.Name = "picKnightW2"
        Me.picKnightW2.Size = New System.Drawing.Size(80, 80)
        Me.picKnightW2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKnightW2.TabIndex = 22
        Me.picKnightW2.TabStop = False
        '
        'picKnightB1
        '
        Me.picKnightB1.BackColor = System.Drawing.Color.Transparent
        Me.picKnightB1.Image = CType(resources.GetObject("picKnightB1.Image"), System.Drawing.Image)
        Me.picKnightB1.Location = New System.Drawing.Point(563, 172)
        Me.picKnightB1.Name = "picKnightB1"
        Me.picKnightB1.Size = New System.Drawing.Size(80, 80)
        Me.picKnightB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKnightB1.TabIndex = 23
        Me.picKnightB1.TabStop = False
        '
        'picKnightB2
        '
        Me.picKnightB2.BackColor = System.Drawing.Color.Transparent
        Me.picKnightB2.Image = CType(resources.GetObject("picKnightB2.Image"), System.Drawing.Image)
        Me.picKnightB2.Location = New System.Drawing.Point(477, 172)
        Me.picKnightB2.Name = "picKnightB2"
        Me.picKnightB2.Size = New System.Drawing.Size(80, 80)
        Me.picKnightB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKnightB2.TabIndex = 24
        Me.picKnightB2.TabStop = False
        '
        'picBishopW1
        '
        Me.picBishopW1.BackColor = System.Drawing.Color.Transparent
        Me.picBishopW1.Image = CType(resources.GetObject("picBishopW1.Image"), System.Drawing.Image)
        Me.picBishopW1.Location = New System.Drawing.Point(563, 258)
        Me.picBishopW1.Name = "picBishopW1"
        Me.picBishopW1.Size = New System.Drawing.Size(80, 80)
        Me.picBishopW1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBishopW1.TabIndex = 25
        Me.picBishopW1.TabStop = False
        '
        'picBishopW2
        '
        Me.picBishopW2.BackColor = System.Drawing.Color.Transparent
        Me.picBishopW2.Image = CType(resources.GetObject("picBishopW2.Image"), System.Drawing.Image)
        Me.picBishopW2.Location = New System.Drawing.Point(477, 258)
        Me.picBishopW2.Name = "picBishopW2"
        Me.picBishopW2.Size = New System.Drawing.Size(80, 80)
        Me.picBishopW2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBishopW2.TabIndex = 26
        Me.picBishopW2.TabStop = False
        '
        'picBishopB1
        '
        Me.picBishopB1.BackColor = System.Drawing.Color.Transparent
        Me.picBishopB1.Image = CType(resources.GetObject("picBishopB1.Image"), System.Drawing.Image)
        Me.picBishopB1.Location = New System.Drawing.Point(563, 344)
        Me.picBishopB1.Name = "picBishopB1"
        Me.picBishopB1.Size = New System.Drawing.Size(80, 80)
        Me.picBishopB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBishopB1.TabIndex = 27
        Me.picBishopB1.TabStop = False
        '
        'picBishopB2
        '
        Me.picBishopB2.BackColor = System.Drawing.Color.Transparent
        Me.picBishopB2.Image = CType(resources.GetObject("picBishopB2.Image"), System.Drawing.Image)
        Me.picBishopB2.Location = New System.Drawing.Point(477, 344)
        Me.picBishopB2.Name = "picBishopB2"
        Me.picBishopB2.Size = New System.Drawing.Size(80, 80)
        Me.picBishopB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBishopB2.TabIndex = 28
        Me.picBishopB2.TabStop = False
        '
        'picRockW1
        '
        Me.picRockW1.BackColor = System.Drawing.Color.Transparent
        Me.picRockW1.Image = CType(resources.GetObject("picRockW1.Image"), System.Drawing.Image)
        Me.picRockW1.Location = New System.Drawing.Point(563, 430)
        Me.picRockW1.Name = "picRockW1"
        Me.picRockW1.Size = New System.Drawing.Size(80, 80)
        Me.picRockW1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRockW1.TabIndex = 29
        Me.picRockW1.TabStop = False
        '
        'picRockW2
        '
        Me.picRockW2.BackColor = System.Drawing.Color.Transparent
        Me.picRockW2.Image = CType(resources.GetObject("picRockW2.Image"), System.Drawing.Image)
        Me.picRockW2.Location = New System.Drawing.Point(477, 430)
        Me.picRockW2.Name = "picRockW2"
        Me.picRockW2.Size = New System.Drawing.Size(80, 80)
        Me.picRockW2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRockW2.TabIndex = 30
        Me.picRockW2.TabStop = False
        '
        'picRockB1
        '
        Me.picRockB1.BackColor = System.Drawing.Color.Transparent
        Me.picRockB1.Image = CType(resources.GetObject("picRockB1.Image"), System.Drawing.Image)
        Me.picRockB1.Location = New System.Drawing.Point(563, 516)
        Me.picRockB1.Name = "picRockB1"
        Me.picRockB1.Size = New System.Drawing.Size(80, 80)
        Me.picRockB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRockB1.TabIndex = 31
        Me.picRockB1.TabStop = False
        '
        'picRockB2
        '
        Me.picRockB2.BackColor = System.Drawing.Color.Transparent
        Me.picRockB2.Image = CType(resources.GetObject("picRockB2.Image"), System.Drawing.Image)
        Me.picRockB2.Location = New System.Drawing.Point(477, 516)
        Me.picRockB2.Name = "picRockB2"
        Me.picRockB2.Size = New System.Drawing.Size(80, 80)
        Me.picRockB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRockB2.TabIndex = 32
        Me.picRockB2.TabStop = False
        '
        'picQueenW1
        '
        Me.picQueenW1.BackColor = System.Drawing.Color.Transparent
        Me.picQueenW1.Image = CType(resources.GetObject("picQueenW1.Image"), System.Drawing.Image)
        Me.picQueenW1.Location = New System.Drawing.Point(376, 12)
        Me.picQueenW1.Name = "picQueenW1"
        Me.picQueenW1.Size = New System.Drawing.Size(80, 80)
        Me.picQueenW1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenW1.TabIndex = 35
        Me.picQueenW1.TabStop = False
        '
        'picQueenW4
        '
        Me.picQueenW4.BackColor = System.Drawing.Color.Transparent
        Me.picQueenW4.Image = CType(resources.GetObject("picQueenW4.Image"), System.Drawing.Image)
        Me.picQueenW4.Location = New System.Drawing.Point(376, 86)
        Me.picQueenW4.Name = "picQueenW4"
        Me.picQueenW4.Size = New System.Drawing.Size(80, 80)
        Me.picQueenW4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenW4.TabIndex = 36
        Me.picQueenW4.TabStop = False
        '
        'picQueenW5
        '
        Me.picQueenW5.BackColor = System.Drawing.Color.Transparent
        Me.picQueenW5.Image = CType(resources.GetObject("picQueenW5.Image"), System.Drawing.Image)
        Me.picQueenW5.Location = New System.Drawing.Point(344, 86)
        Me.picQueenW5.Name = "picQueenW5"
        Me.picQueenW5.Size = New System.Drawing.Size(80, 80)
        Me.picQueenW5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenW5.TabIndex = 37
        Me.picQueenW5.TabStop = False
        '
        'picQueenW2
        '
        Me.picQueenW2.BackColor = System.Drawing.Color.Transparent
        Me.picQueenW2.Image = CType(resources.GetObject("picQueenW2.Image"), System.Drawing.Image)
        Me.picQueenW2.Location = New System.Drawing.Point(344, 12)
        Me.picQueenW2.Name = "picQueenW2"
        Me.picQueenW2.Size = New System.Drawing.Size(80, 80)
        Me.picQueenW2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenW2.TabIndex = 38
        Me.picQueenW2.TabStop = False
        '
        'picQueenW3
        '
        Me.picQueenW3.BackColor = System.Drawing.Color.Transparent
        Me.picQueenW3.Image = CType(resources.GetObject("picQueenW3.Image"), System.Drawing.Image)
        Me.picQueenW3.Location = New System.Drawing.Point(311, 12)
        Me.picQueenW3.Name = "picQueenW3"
        Me.picQueenW3.Size = New System.Drawing.Size(80, 80)
        Me.picQueenW3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenW3.TabIndex = 39
        Me.picQueenW3.TabStop = False
        '
        'picQueenW7
        '
        Me.picQueenW7.BackColor = System.Drawing.Color.Transparent
        Me.picQueenW7.Image = CType(resources.GetObject("picQueenW7.Image"), System.Drawing.Image)
        Me.picQueenW7.Location = New System.Drawing.Point(376, 172)
        Me.picQueenW7.Name = "picQueenW7"
        Me.picQueenW7.Size = New System.Drawing.Size(80, 80)
        Me.picQueenW7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenW7.TabIndex = 39
        Me.picQueenW7.TabStop = False
        '
        'picQueenW8
        '
        Me.picQueenW8.BackColor = System.Drawing.Color.Transparent
        Me.picQueenW8.Image = CType(resources.GetObject("picQueenW8.Image"), System.Drawing.Image)
        Me.picQueenW8.Location = New System.Drawing.Point(357, 172)
        Me.picQueenW8.Name = "picQueenW8"
        Me.picQueenW8.Size = New System.Drawing.Size(80, 80)
        Me.picQueenW8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenW8.TabIndex = 40
        Me.picQueenW8.TabStop = False
        '
        'picQueenW6
        '
        Me.picQueenW6.BackColor = System.Drawing.Color.Transparent
        Me.picQueenW6.Image = CType(resources.GetObject("picQueenW6.Image"), System.Drawing.Image)
        Me.picQueenW6.Location = New System.Drawing.Point(311, 86)
        Me.picQueenW6.Name = "picQueenW6"
        Me.picQueenW6.Size = New System.Drawing.Size(80, 80)
        Me.picQueenW6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenW6.TabIndex = 41
        Me.picQueenW6.TabStop = False
        '
        'picQueenB8
        '
        Me.picQueenB8.BackColor = System.Drawing.Color.Transparent
        Me.picQueenB8.Image = CType(resources.GetObject("picQueenB8.Image"), System.Drawing.Image)
        Me.picQueenB8.Location = New System.Drawing.Point(357, 258)
        Me.picQueenB8.Name = "picQueenB8"
        Me.picQueenB8.Size = New System.Drawing.Size(80, 80)
        Me.picQueenB8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenB8.TabIndex = 42
        Me.picQueenB8.TabStop = False
        '
        'picQueenB7
        '
        Me.picQueenB7.BackColor = System.Drawing.Color.Transparent
        Me.picQueenB7.Image = CType(resources.GetObject("picQueenB7.Image"), System.Drawing.Image)
        Me.picQueenB7.Location = New System.Drawing.Point(376, 258)
        Me.picQueenB7.Name = "picQueenB7"
        Me.picQueenB7.Size = New System.Drawing.Size(80, 80)
        Me.picQueenB7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenB7.TabIndex = 43
        Me.picQueenB7.TabStop = False
        '
        'picQueenB6
        '
        Me.picQueenB6.BackColor = System.Drawing.Color.Transparent
        Me.picQueenB6.Image = CType(resources.GetObject("picQueenB6.Image"), System.Drawing.Image)
        Me.picQueenB6.Location = New System.Drawing.Point(110, 86)
        Me.picQueenB6.Name = "picQueenB6"
        Me.picQueenB6.Size = New System.Drawing.Size(80, 80)
        Me.picQueenB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenB6.TabIndex = 44
        Me.picQueenB6.TabStop = False
        '
        'picQueenB5
        '
        Me.picQueenB5.BackColor = System.Drawing.Color.Transparent
        Me.picQueenB5.Image = CType(resources.GetObject("picQueenB5.Image"), System.Drawing.Image)
        Me.picQueenB5.Location = New System.Drawing.Point(196, 86)
        Me.picQueenB5.Name = "picQueenB5"
        Me.picQueenB5.Size = New System.Drawing.Size(80, 80)
        Me.picQueenB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenB5.TabIndex = 45
        Me.picQueenB5.TabStop = False
        '
        'picQueenB4
        '
        Me.picQueenB4.BackColor = System.Drawing.Color.Transparent
        Me.picQueenB4.Image = CType(resources.GetObject("picQueenB4.Image"), System.Drawing.Image)
        Me.picQueenB4.Location = New System.Drawing.Point(225, 86)
        Me.picQueenB4.Name = "picQueenB4"
        Me.picQueenB4.Size = New System.Drawing.Size(80, 80)
        Me.picQueenB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenB4.TabIndex = 46
        Me.picQueenB4.TabStop = False
        '
        'picQueenB3
        '
        Me.picQueenB3.BackColor = System.Drawing.Color.Transparent
        Me.picQueenB3.Image = CType(resources.GetObject("picQueenB3.Image"), System.Drawing.Image)
        Me.picQueenB3.Location = New System.Drawing.Point(110, 12)
        Me.picQueenB3.Name = "picQueenB3"
        Me.picQueenB3.Size = New System.Drawing.Size(80, 80)
        Me.picQueenB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenB3.TabIndex = 47
        Me.picQueenB3.TabStop = False
        '
        'picQueenB2
        '
        Me.picQueenB2.BackColor = System.Drawing.Color.Transparent
        Me.picQueenB2.Image = CType(resources.GetObject("picQueenB2.Image"), System.Drawing.Image)
        Me.picQueenB2.Location = New System.Drawing.Point(196, 12)
        Me.picQueenB2.Name = "picQueenB2"
        Me.picQueenB2.Size = New System.Drawing.Size(80, 80)
        Me.picQueenB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenB2.TabIndex = 48
        Me.picQueenB2.TabStop = False
        '
        'picQueenB1
        '
        Me.picQueenB1.BackColor = System.Drawing.Color.Transparent
        Me.picQueenB1.Image = CType(resources.GetObject("picQueenB1.Image"), System.Drawing.Image)
        Me.picQueenB1.Location = New System.Drawing.Point(225, 12)
        Me.picQueenB1.Name = "picQueenB1"
        Me.picQueenB1.Size = New System.Drawing.Size(80, 80)
        Me.picQueenB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenB1.TabIndex = 49
        Me.picQueenB1.TabStop = False
        '
        'tmrCheck
        '
        '
        'butStart
        '
        Me.butStart.BackColor = System.Drawing.Color.White
        Me.butStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.butStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butStart.Location = New System.Drawing.Point(672, 268)
        Me.butStart.Name = "butStart"
        Me.butStart.Size = New System.Drawing.Size(138, 92)
        Me.butStart.TabIndex = 54
        Me.butStart.Text = "&Start"
        Me.butStart.UseVisualStyleBackColor = False
        '
        'mnuChess
        '
        Me.mnuChess.BackColor = System.Drawing.Color.White
        Me.mnuChess.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuChess.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuChess.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuChess.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGame, Me.mnuBackColor, Me.mnuFont})
        Me.mnuChess.Location = New System.Drawing.Point(646, 0)
        Me.mnuChess.Name = "mnuChess"
        Me.mnuChess.Size = New System.Drawing.Size(350, 40)
        Me.mnuChess.TabIndex = 55
        Me.mnuChess.Text = "MenuStrip1"
        '
        'mnuGame
        '
        Me.mnuGame.BackColor = System.Drawing.Color.White
        Me.mnuGame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTime, Me.mnuSeparator3, Me.mnuExit})
        Me.mnuGame.Name = "mnuGame"
        Me.mnuGame.Size = New System.Drawing.Size(104, 36)
        Me.mnuGame.Text = "&Game "
        '
        'mnuTime
        '
        Me.mnuTime.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMin1, Me.mnuSeparator1, Me.mnuMin5, Me.mnuSeparator2, Me.mnuMin10})
        Me.mnuTime.Name = "mnuTime"
        Me.mnuTime.Size = New System.Drawing.Size(202, 44)
        Me.mnuTime.Text = "&Time"
        '
        'mnuMin1
        '
        Me.mnuMin1.Name = "mnuMin1"
        Me.mnuMin1.Size = New System.Drawing.Size(223, 44)
        Me.mnuMin1.Text = "1 Min"
        '
        'mnuSeparator1
        '
        Me.mnuSeparator1.Name = "mnuSeparator1"
        Me.mnuSeparator1.Size = New System.Drawing.Size(220, 6)
        '
        'mnuMin5
        '
        Me.mnuMin5.Checked = True
        Me.mnuMin5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuMin5.Name = "mnuMin5"
        Me.mnuMin5.Size = New System.Drawing.Size(223, 44)
        Me.mnuMin5.Text = "5 min"
        '
        'mnuSeparator2
        '
        Me.mnuSeparator2.Name = "mnuSeparator2"
        Me.mnuSeparator2.Size = New System.Drawing.Size(220, 6)
        '
        'mnuMin10
        '
        Me.mnuMin10.Name = "mnuMin10"
        Me.mnuMin10.Size = New System.Drawing.Size(223, 44)
        Me.mnuMin10.Text = "10 min"
        '
        'mnuSeparator3
        '
        Me.mnuSeparator3.Name = "mnuSeparator3"
        Me.mnuSeparator3.Size = New System.Drawing.Size(199, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(202, 44)
        Me.mnuExit.Text = "&Exit"
        '
        'mnuBackColor
        '
        Me.mnuBackColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColorOrig, Me.mnuSeparator4, Me.mnuColorGrey, Me.mnuSeparator5, Me.mnuColorYel, Me.mnuSeparator6, Me.mnuColorBlue, Me.mnuSeparator7, Me.mnuColorCust})
        Me.mnuBackColor.Name = "mnuBackColor"
        Me.mnuBackColor.Size = New System.Drawing.Size(148, 36)
        Me.mnuBackColor.Text = "&BackColor "
        '
        'mnuColorOrig
        '
        Me.mnuColorOrig.Checked = True
        Me.mnuColorOrig.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuColorOrig.Name = "mnuColorOrig"
        Me.mnuColorOrig.Size = New System.Drawing.Size(246, 44)
        Me.mnuColorOrig.Text = "&Original"
        '
        'mnuSeparator4
        '
        Me.mnuSeparator4.Name = "mnuSeparator4"
        Me.mnuSeparator4.Size = New System.Drawing.Size(243, 6)
        '
        'mnuColorGrey
        '
        Me.mnuColorGrey.Name = "mnuColorGrey"
        Me.mnuColorGrey.Size = New System.Drawing.Size(246, 44)
        Me.mnuColorGrey.Text = "&Grey"
        '
        'mnuSeparator5
        '
        Me.mnuSeparator5.Name = "mnuSeparator5"
        Me.mnuSeparator5.Size = New System.Drawing.Size(243, 6)
        '
        'mnuColorYel
        '
        Me.mnuColorYel.Name = "mnuColorYel"
        Me.mnuColorYel.Size = New System.Drawing.Size(246, 44)
        Me.mnuColorYel.Text = "&Yellow"
        '
        'mnuSeparator6
        '
        Me.mnuSeparator6.Name = "mnuSeparator6"
        Me.mnuSeparator6.Size = New System.Drawing.Size(243, 6)
        '
        'mnuColorBlue
        '
        Me.mnuColorBlue.Name = "mnuColorBlue"
        Me.mnuColorBlue.Size = New System.Drawing.Size(246, 44)
        Me.mnuColorBlue.Text = "&Blue"
        '
        'mnuSeparator7
        '
        Me.mnuSeparator7.Name = "mnuSeparator7"
        Me.mnuSeparator7.Size = New System.Drawing.Size(243, 6)
        '
        'mnuColorCust
        '
        Me.mnuColorCust.Name = "mnuColorCust"
        Me.mnuColorCust.Size = New System.Drawing.Size(246, 44)
        Me.mnuColorCust.Text = "&Custom..."
        '
        'mnuFont
        '
        Me.mnuFont.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFontOri, Me.mnuSeparator8, Me.mnuFontCust})
        Me.mnuFont.Name = "mnuFont"
        Me.mnuFont.Size = New System.Drawing.Size(90, 36)
        Me.mnuFont.Text = "&Font "
        '
        'mnuFontOri
        '
        Me.mnuFontOri.Checked = True
        Me.mnuFontOri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuFontOri.Name = "mnuFontOri"
        Me.mnuFontOri.Size = New System.Drawing.Size(246, 44)
        Me.mnuFontOri.Text = "Original"
        '
        'mnuSeparator8
        '
        Me.mnuSeparator8.Name = "mnuSeparator8"
        Me.mnuSeparator8.Size = New System.Drawing.Size(243, 6)
        '
        'mnuFontCust
        '
        Me.mnuFontCust.Name = "mnuFontCust"
        Me.mnuFontCust.Size = New System.Drawing.Size(246, 44)
        Me.mnuFontCust.Text = "Custom..."
        '
        'tmrTime1
        '
        Me.tmrTime1.Interval = 1000
        '
        'lblPlayer1
        '
        Me.lblPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlayer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPlayer1.Location = New System.Drawing.Point(693, 596)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(135, 38)
        Me.lblPlayer1.TabIndex = 58
        Me.lblPlayer1.Text = "Player1"
        Me.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColon2
        '
        Me.lblColon2.BackColor = System.Drawing.Color.Transparent
        Me.lblColon2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblColon2.Location = New System.Drawing.Point(713, 86)
        Me.lblColon2.Name = "lblColon2"
        Me.lblColon2.Size = New System.Drawing.Size(18, 38)
        Me.lblColon2.TabIndex = 63
        Me.lblColon2.Text = ":"
        Me.lblColon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeSec2
        '
        Me.lblTimeSec2.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeSec2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSec2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTimeSec2.Location = New System.Drawing.Point(735, 86)
        Me.lblTimeSec2.Name = "lblTimeSec2"
        Me.lblTimeSec2.Size = New System.Drawing.Size(52, 38)
        Me.lblTimeSec2.TabIndex = 62
        Me.lblTimeSec2.Text = "0"
        Me.lblTimeSec2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeMin2
        '
        Me.lblTimeMin2.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeMin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeMin2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTimeMin2.Location = New System.Drawing.Point(669, 86)
        Me.lblTimeMin2.Name = "lblTimeMin2"
        Me.lblTimeMin2.Size = New System.Drawing.Size(40, 38)
        Me.lblTimeMin2.TabIndex = 61
        Me.lblTimeMin2.Text = "5"
        Me.lblTimeMin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer2
        '
        Me.lblPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlayer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPlayer2.Location = New System.Drawing.Point(693, 31)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(135, 38)
        Me.lblPlayer2.TabIndex = 64
        Me.lblPlayer2.Text = "Player2"
        Me.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTime2
        '
        Me.tmrTime2.Interval = 1000
        '
        'tmrResult
        '
        Me.tmrResult.Interval = 1
        '
        'butBack
        '
        Me.butBack.BackColor = System.Drawing.Color.White
        Me.butBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.butBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold)
        Me.butBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butBack.Location = New System.Drawing.Point(672, 380)
        Me.butBack.Name = "butBack"
        Me.butBack.Size = New System.Drawing.Size(138, 76)
        Me.butBack.TabIndex = 65
        Me.butBack.Text = "&Back to Lobby"
        Me.butBack.UseVisualStyleBackColor = False
        '
        'lblColon1
        '
        Me.lblColon1.BackColor = System.Drawing.Color.Transparent
        Me.lblColon1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblColon1.Location = New System.Drawing.Point(713, 531)
        Me.lblColon1.Name = "lblColon1"
        Me.lblColon1.Size = New System.Drawing.Size(18, 38)
        Me.lblColon1.TabIndex = 70
        Me.lblColon1.Text = ":"
        Me.lblColon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeSec1
        '
        Me.lblTimeSec1.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeSec1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSec1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTimeSec1.Location = New System.Drawing.Point(735, 531)
        Me.lblTimeSec1.Name = "lblTimeSec1"
        Me.lblTimeSec1.Size = New System.Drawing.Size(52, 38)
        Me.lblTimeSec1.TabIndex = 69
        Me.lblTimeSec1.Text = "0"
        Me.lblTimeSec1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeMin1
        '
        Me.lblTimeMin1.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeMin1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeMin1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTimeMin1.Location = New System.Drawing.Point(669, 531)
        Me.lblTimeMin1.Name = "lblTimeMin1"
        Me.lblTimeMin1.Size = New System.Drawing.Size(40, 38)
        Me.lblTimeMin1.TabIndex = 68
        Me.lblTimeMin1.Text = "5"
        Me.lblTimeMin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCheck
        '
        Me.lblCheck.BackColor = System.Drawing.Color.Transparent
        Me.lblCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheck.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCheck.Location = New System.Drawing.Point(649, 247)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(181, 130)
        Me.lblCheck.TabIndex = 52
        Me.lblCheck.Text = "Check"
        Me.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMate
        '
        Me.lblMate.BackColor = System.Drawing.Color.Transparent
        Me.lblMate.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMate.ForeColor = System.Drawing.Color.DarkRed
        Me.lblMate.Location = New System.Drawing.Point(649, 247)
        Me.lblMate.Name = "lblMate"
        Me.lblMate.Size = New System.Drawing.Size(181, 130)
        Me.lblMate.TabIndex = 53
        Me.lblMate.Text = "Mate"
        Me.lblMate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shpBorder5
        '
        Me.shpBorder5.BackColor = System.Drawing.Color.Transparent
        Me.shpBorder5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shpBorder5.BorderColor = System.Drawing.Color.Transparent
        Me.shpBorder5.BorderWidth = 6
        Me.shpBorder5.Location = New System.Drawing.Point(672, 380)
        Me.shpBorder5.Name = "shpBorder5"
        Me.shpBorder5.Size = New System.Drawing.Size(138, 76)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shpBorder4, Me.shpBorder5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(831, 643)
        Me.ShapeContainer1.TabIndex = 71
        Me.ShapeContainer1.TabStop = False
        '
        'shpBorder4
        '
        Me.shpBorder4.BackColor = System.Drawing.Color.Transparent
        Me.shpBorder4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shpBorder4.BorderColor = System.Drawing.Color.Transparent
        Me.shpBorder4.BorderWidth = 6
        Me.shpBorder4.Location = New System.Drawing.Point(672, 268)
        Me.shpBorder4.Name = "shpBorder4"
        Me.shpBorder4.Size = New System.Drawing.Size(138, 92)
        '
        'picLogoQueenB
        '
        Me.picLogoQueenB.BackColor = System.Drawing.Color.Transparent
        Me.picLogoQueenB.Image = CType(resources.GetObject("picLogoQueenB.Image"), System.Drawing.Image)
        Me.picLogoQueenB.Location = New System.Drawing.Point(649, 31)
        Me.picLogoQueenB.Name = "picLogoQueenB"
        Me.picLogoQueenB.Size = New System.Drawing.Size(38, 38)
        Me.picLogoQueenB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoQueenB.TabIndex = 77
        Me.picLogoQueenB.TabStop = False
        '
        'chkReport
        '
        Me.chkReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkReport.Location = New System.Drawing.Point(674, 195)
        Me.chkReport.Name = "chkReport"
        Me.chkReport.Size = New System.Drawing.Size(129, 49)
        Me.chkReport.TabIndex = 78
        Me.chkReport.Text = "Make Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " of the Game"
        Me.chkReport.UseVisualStyleBackColor = True
        '
        'lblScoreWhite
        '
        Me.lblScoreWhite.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreWhite.ForeColor = System.Drawing.Color.Navy
        Me.lblScoreWhite.Location = New System.Drawing.Point(713, 418)
        Me.lblScoreWhite.Name = "lblScoreWhite"
        Me.lblScoreWhite.Size = New System.Drawing.Size(52, 38)
        Me.lblScoreWhite.TabIndex = 79
        Me.lblScoreWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreBlack
        '
        Me.lblScoreBlack.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreBlack.ForeColor = System.Drawing.Color.Navy
        Me.lblScoreBlack.Location = New System.Drawing.Point(713, 199)
        Me.lblScoreBlack.Name = "lblScoreBlack"
        Me.lblScoreBlack.Size = New System.Drawing.Size(52, 38)
        Me.lblScoreBlack.TabIndex = 80
        Me.lblScoreBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogoQueenW
        '
        Me.picLogoQueenW.BackColor = System.Drawing.Color.Transparent
        Me.picLogoQueenW.Image = CType(resources.GetObject("picLogoQueenW.Image"), System.Drawing.Image)
        Me.picLogoQueenW.Location = New System.Drawing.Point(649, 596)
        Me.picLogoQueenW.Name = "picLogoQueenW"
        Me.picLogoQueenW.Size = New System.Drawing.Size(38, 38)
        Me.picLogoQueenW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoQueenW.TabIndex = 81
        Me.picLogoQueenW.TabStop = False
        '
        'ttpMate
        '
        Me.ttpMate.AutoPopDelay = 7000
        Me.ttpMate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ttpMate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ttpMate.InitialDelay = 500
        Me.ttpMate.IsBalloon = True
        Me.ttpMate.ReshowDelay = 100
        Me.ttpMate.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpMate.ToolTipTitle = "The End"
        '
        'ttpScoreW
        '
        Me.ttpScoreW.AutoPopDelay = 7000
        Me.ttpScoreW.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ttpScoreW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ttpScoreW.InitialDelay = 500
        Me.ttpScoreW.IsBalloon = True
        Me.ttpScoreW.ReshowDelay = 100
        Me.ttpScoreW.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpScoreW.ToolTipTitle = "Score"
        '
        'ttpScoreB
        '
        Me.ttpScoreB.AutoPopDelay = 7000
        Me.ttpScoreB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ttpScoreB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ttpScoreB.InitialDelay = 500
        Me.ttpScoreB.IsBalloon = True
        Me.ttpScoreB.ReshowDelay = 100
        Me.ttpScoreB.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpScoreB.ToolTipTitle = "Score"
        '
        'frmChess
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(831, 643)
        Me.Controls.Add(Me.picLogoQueenW)
        Me.Controls.Add(Me.lblScoreWhite)
        Me.Controls.Add(Me.chkReport)
        Me.Controls.Add(Me.picLogoQueenB)
        Me.Controls.Add(Me.lblColon1)
        Me.Controls.Add(Me.lblTimeSec1)
        Me.Controls.Add(Me.lblTimeMin1)
        Me.Controls.Add(Me.butBack)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblColon2)
        Me.Controls.Add(Me.lblTimeSec2)
        Me.Controls.Add(Me.lblTimeMin2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.butStart)
        Me.Controls.Add(Me.lblMate)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.picQueenB1)
        Me.Controls.Add(Me.picQueenB2)
        Me.Controls.Add(Me.picQueenB3)
        Me.Controls.Add(Me.picQueenB4)
        Me.Controls.Add(Me.picQueenB5)
        Me.Controls.Add(Me.picQueenB6)
        Me.Controls.Add(Me.picQueenB7)
        Me.Controls.Add(Me.picQueenB8)
        Me.Controls.Add(Me.picQueenW6)
        Me.Controls.Add(Me.picQueenW8)
        Me.Controls.Add(Me.picQueenW7)
        Me.Controls.Add(Me.picQueenW3)
        Me.Controls.Add(Me.picQueenW2)
        Me.Controls.Add(Me.picQueenW5)
        Me.Controls.Add(Me.picQueenW4)
        Me.Controls.Add(Me.picQueenW1)
        Me.Controls.Add(Me.picRockB2)
        Me.Controls.Add(Me.picRockB1)
        Me.Controls.Add(Me.picRockW2)
        Me.Controls.Add(Me.picRockW1)
        Me.Controls.Add(Me.picBishopB2)
        Me.Controls.Add(Me.picBishopB1)
        Me.Controls.Add(Me.picBishopW2)
        Me.Controls.Add(Me.picBishopW1)
        Me.Controls.Add(Me.picKnightB2)
        Me.Controls.Add(Me.picKnightB1)
        Me.Controls.Add(Me.picKnightW2)
        Me.Controls.Add(Me.picKnightW1)
        Me.Controls.Add(Me.picQueenB)
        Me.Controls.Add(Me.picQueenW)
        Me.Controls.Add(Me.picPawnB5)
        Me.Controls.Add(Me.picPawnB2)
        Me.Controls.Add(Me.picPawnB6)
        Me.Controls.Add(Me.picPawnB3)
        Me.Controls.Add(Me.picPawnB7)
        Me.Controls.Add(Me.picPawnB4)
        Me.Controls.Add(Me.picPawnB8)
        Me.Controls.Add(Me.picPawnB1)
        Me.Controls.Add(Me.picPawnW7)
        Me.Controls.Add(Me.picPawnW8)
        Me.Controls.Add(Me.picPawnW3)
        Me.Controls.Add(Me.picPawnW4)
        Me.Controls.Add(Me.picPawnW5)
        Me.Controls.Add(Me.picPawnW6)
        Me.Controls.Add(Me.picPawnW2)
        Me.Controls.Add(Me.picPawnW1)
        Me.Controls.Add(Me.picKingW)
        Me.Controls.Add(Me.picKingB)
        Me.Controls.Add(Me.dgvChess)
        Me.Controls.Add(Me.mnuChess)
        Me.Controls.Add(Me.lblScoreBlack)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuChess
        Me.Name = "frmChess"
        Me.Text = "Chess"
        CType(Me.picKingB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvChess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKingW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnW1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnW2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnW6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnW5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnW4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnW3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnW8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnW7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnB8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnB7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnB6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPawnB5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKnightW1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKnightW2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKnightB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKnightB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBishopW1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBishopW2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBishopB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBishopB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRockW1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRockW2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRockB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRockB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenW1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenW4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenW5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenW2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenW3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenW7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenW8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenW6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenB8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenB7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenB6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenB5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuChess.ResumeLayout(False)
        Me.mnuChess.PerformLayout()
        CType(Me.picLogoQueenB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogoQueenW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picKingB As System.Windows.Forms.PictureBox
    Friend WithEvents dgvChess As System.Windows.Forms.DataGridView
    Friend WithEvents picKingW As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnW1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnW2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnW6 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnW5 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnW4 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnW3 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnW8 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnW7 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnB1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnB8 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnB4 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnB7 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnB3 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnB6 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnB2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPawnB5 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenW As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenB As System.Windows.Forms.PictureBox
    Friend WithEvents picKnightW1 As System.Windows.Forms.PictureBox
    Friend WithEvents picKnightW2 As System.Windows.Forms.PictureBox
    Friend WithEvents picKnightB1 As System.Windows.Forms.PictureBox
    Friend WithEvents picKnightB2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBishopW1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBishopW2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBishopB1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBishopB2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRockW1 As System.Windows.Forms.PictureBox
    Friend WithEvents picRockW2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRockB1 As System.Windows.Forms.PictureBox
    Friend WithEvents picRockB2 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenW1 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenW4 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenW5 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenW2 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenW3 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenW7 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenW8 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenW6 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenB8 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenB7 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenB6 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenB5 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenB4 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenB3 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenB2 As System.Windows.Forms.PictureBox
    Friend WithEvents picQueenB1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCheck As System.Windows.Forms.Timer
    Friend WithEvents butStart As System.Windows.Forms.Button
    Friend WithEvents mnuChess As System.Windows.Forms.MenuStrip
    Friend WithEvents tmrTime1 As System.Windows.Forms.Timer
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblColon2 As System.Windows.Forms.Label
    Friend WithEvents lblTimeSec2 As System.Windows.Forms.Label
    Friend WithEvents lblTimeMin2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents tmrTime2 As System.Windows.Forms.Timer
    Friend WithEvents mnuGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMin1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMin5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMin10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrResult As System.Windows.Forms.Timer
    Friend WithEvents butBack As System.Windows.Forms.Button
    Friend WithEvents lblColon1 As System.Windows.Forms.Label
    Friend WithEvents lblTimeSec1 As System.Windows.Forms.Label
    Friend WithEvents lblTimeMin1 As System.Windows.Forms.Label
    Friend WithEvents lblCheck As System.Windows.Forms.Label
    Friend WithEvents lblMate As System.Windows.Forms.Label
    Friend WithEvents mnuSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBackColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuColorOrig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuColorGrey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuColorYel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuColorBlue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuColorCust As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
    Friend WithEvents mnuFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFontOri As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFontCust As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents picLogoQueenB As System.Windows.Forms.PictureBox
    Friend WithEvents chkReport As System.Windows.Forms.CheckBox
    Friend WithEvents lblScoreWhite As System.Windows.Forms.Label
    Friend WithEvents lblScoreBlack As System.Windows.Forms.Label
    Friend WithEvents picLogoQueenW As System.Windows.Forms.PictureBox
    Friend WithEvents ttpMate As System.Windows.Forms.ToolTip
    Friend WithEvents ttpScoreW As System.Windows.Forms.ToolTip
    Friend WithEvents ttpScoreB As System.Windows.Forms.ToolTip
    Private WithEvents shpBorder5 As PowerPacks.RectangleShape
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents shpBorder4 As PowerPacks.RectangleShape
End Class
