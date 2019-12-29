Public Class frmLobby

    REM *********************************************************************
    REM Title of Program: Chess
    REM Purpose:  The game is designed to play chess(Person vs Person version),
    REM           and to delevop chess skills.
    REM Programmer: Eugene Fedoriv
    REM Last Edited: January 23, 2018
    REM *********************************************************************

    REM *********************************************************************
    REM Variable Dictionary:
    REM fullPath (String) = A string which contains the path to file "Previous Games"(File IO is used)
    REM path (String) = A string which gets the path to the file "Previous Games"
    REM Player1 (String) = The name of a person who is going to play with White pieces
    REM Player2 (String) = The name of a person who is going to play with Black pieces
    REM Report (String) = A String which gets the results of the games from 
    REM                   the File "Previous Games.txt"
    REM *********************************************************************

    Dim path As String
    Dim fullPath As String
    Dim Report As String
    Dim Player1, Player2 As String

    Private Sub butPlay_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles butPlay.MouseLeave
        Cursor = Cursors.Default
        shpBorder1.BorderColor = Color.Transparent

    End Sub


    Private Sub butStart_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles butPlay.MouseMove
        Cursor = Cursors.Hand
        shpBorder1.BorderColor = Color.FromArgb(64, 0, 0)

    End Sub

    Private Sub butPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butPlay.Click

        REM *****************************************************************
        REM 	Getting the names of the two players; redirecting to the game form.
        REM *****************************************************************

        Player1 = InputBox("Player1's name(Who Plays White):", "Chess(First Player)", "TheName")
        If Player1 = "TheName" Then
            Player1 = "Anonymous"
        ElseIf Player1 = "" Then
            Player1 = "Anonymous"
        End If
        frmChess.lblPlayer1.Text = Player1

        Player2 = InputBox("Player2's name(Who Plays Black):", "Chess(Second Player)", "TheName")
        If Player2 = "TheName" Then
            Player2 = "Anonymous"
        ElseIf Player2 = "" Then
            Player2 = "Anonymous"
        End If
        frmChess.lblPlayer2.Text = Player2

        frmChess.Show()
        Me.Hide()

    End Sub

    Private Sub butGames_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles butGames.MouseMove
        Cursor = Cursors.Hand
        shpBorder2.BorderColor = Color.FromArgb(64, 0, 0)
    End Sub

    Private Sub butGames_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butGames.MouseLeave
        Cursor = Cursors.Default
        shpBorder2.BorderColor = Color.Transparent
    End Sub

    Private Sub butExit_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles butExit.MouseMove
        Cursor = Cursors.Hand
        shpBorder3.BorderColor = Color.FromArgb(64, 0, 0)
    End Sub

    Private Sub butExit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.MouseLeave
        Cursor = Cursors.Default
        shpBorder3.BorderColor = Color.Transparent
    End Sub

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click

        REM *****************************************************************
        REM 	Closing the game
        REM *****************************************************************

        Me.Close()
        frmChess.Close()

    End Sub

    Private Sub butGames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butGames.Click

        REM *********************************************************************
        REM Variable Dictionary:
        REM Counter (Integer) = A refreshable counter from 0 to 4(to get the whole
        REM                     string of the previous game
        REM FirstLine (String) = A String ("Player1 / vs / Player2 / Date") 
        REM                      which is used at the beginning of the Games Report List
        REM Line (String) = A string which stores the output from the
        REM                 File "Previous Games.txt"
        REM number (Integer) = A counter for the amount of the games played before
        REM *********************************************************************

        Dim FirstLine As String
        Dim Line As String
        Dim Counter As Integer
        Dim number As Integer

        REM *****************************************************************
        REM 	Getting the results of the previous games; displaying them in the listbox
        REM     + Hiding all of the object exept for the listbox and button "Back to Lobby"
        REM *****************************************************************

        number = 1
        butExit.Hide()
        butPlay.Hide()
        butGames.Hide()
        picKingLobbyB.Hide()
        picKingLobbyW.Hide()
        shpBorder2.Hide()


        mnuLobby.Hide()
        shpBorder4.Location = New Point(76, 25)
        shpBorder4.Width = 540
        shpBorder4.Height = 324
        shpBorder4.BorderColor = Color.FromArgb(64, 0, 0)
        lstReport.Items.Clear()
        FirstLine = "     Player1        vs      Player2        Date"
        Line = ""
        lstReport.Location = New Point(76, 25)
        lstReport.Width = 540
        lstReport.Height = 324
        lstReport.Items.Add(FirstLine)


        lstReport.Show()
        shpBorder4.Show()
        butBack.Show()

        FileOpen(2, fullPath, OpenMode.Input)
        Report = number & ")  "
        Counter = 0
        Do Until EOF(2)
            Counter = Counter + 1
            Input(2, Line)
            Report = Report & Line & "     "

            If Counter = 4 Then
                lstReport.Items.Add(Report)
                number = number + 1
                Report = number & ")  "
                Counter = 0
            End If

        Loop
        FileClose(2)

    End Sub


    Private Sub frmLobby_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        REM *****************************************************************
        REM 	Setting on the Lobby's objects
        REM *****************************************************************

        shpBorder4.Hide()
        lstReport.Hide()
        butBack.Hide()

        Me.BackColor = Color.FromArgb(255, 224, 192)
        lstReport.BackColor = Color.FromArgb(255, 224, 192)
        lblGameChess.Font = New Font("Jokerman", 77, FontStyle.Bold)
        butPlay.Font = New Font("Jokerman", 29.25, FontStyle.Bold)
        butGames.Font = New Font("Jokerman", 18, FontStyle.Bold)
        butBack.Font = New Font("Jokerman", 18, FontStyle.Bold)
        butExit.Font = New Font("Jokerman", 29.25, FontStyle.Bold)

        path = "Previous Games.txt"
        fullPath = IO.Path.GetFullPath(path)
        Console.WriteLine("GetFullPath('{0}') returns '{1}'", path, fullPath) ' fullPath = Privious Games

    End Sub

    Private Sub butBack_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles butBack.MouseMove
        Cursor = Cursors.Hand
        shpBorder3.BorderColor = Color.FromArgb(64, 0, 0)
    End Sub

    Private Sub butBack_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butBack.MouseLeave
        Cursor = Cursors.Default
        shpBorder3.BorderColor = Color.Transparent
    End Sub

    Private Sub butBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butBack.Click

        REM *****************************************************************
        REM 	Going back to the Lobby
        REM *****************************************************************
        picKingLobbyB.Show()
        picKingLobbyW.Show()
        butExit.Show()
        butPlay.Show()
        butGames.Show()
        butBack.Hide()
        lstReport.Hide()
        shpBorder4.Hide()
        mnuLobby.Show()
        shpBorder2.Show()

    End Sub

    Private Sub frmLobby_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        lstReport.ClearSelected()
    End Sub
End Class