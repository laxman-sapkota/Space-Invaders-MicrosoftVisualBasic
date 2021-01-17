Public Class form1

#Region "variables"

    Dim aliens(12) As PictureBox

    Dim lef As Boolean
    Dim rig As Boolean
    Dim fire As Boolean
    Dim fire1 As Boolean
    Dim fire2 As Boolean
    Dim fire3 As Boolean
    Dim fire4 As Boolean
    Dim fire5 As Boolean

    Dim movealien As Integer = 2
    Dim whichalien As Integer
    Dim shoot As PictureBox
#End Region

#Region "button"
    Private Sub startgame_Click(sender As System.Object, e As System.EventArgs) Handles startgame.Click
        Label1.Hide()
        startgame.Show()
        quitgame.Show()
        PictureBox1.Hide()
        PictureBox2.Hide()
        formloder1.Show()
        movecomp.Enabled = True
        movecomp.Start()
    End Sub
    Private Sub quitgame_Click(sender As System.Object, e As System.EventArgs) Handles quitgame.Click
        Me.Close()
    End Sub

#End Region

#Region "timers"

    Private Sub movecomp_Tick(sender As System.Object, e As System.EventArgs) Handles movecomp.Tick
        If lef = True Then
            spaceship.Left = spaceship.Left - 5
            restartshot.Left = restartshot.Left - 5
            If fire1 = False Then
                shot1.Left = shot1.Left - 5
            End If
            If fire2 = False Then
                shot2.Left = shot2.Left - 5
            End If
            If fire3 = False Then
                shot3.Left = shot3.Left - 5
            End If
            If fire4 = False Then
                shot4.Left = shot4.Left - 5
            End If
            If fire5 = False Then
                shot5.Left = shot5.Left - 5
            End If
        End If
        If rig = True Then
            spaceship.Left = spaceship.Left + 5
            restartshot.Left = restartshot.Left + 5

            If fire1 = False Then
                shot1.Left = shot1.Left + 5
            End If
            If fire2 = False Then
                shot2.Left = shot2.Left + 5
            End If
            If fire3 = False Then
                shot3.Left = shot3.Left + 5
            End If
            If fire4 = False Then
                shot4.Left = shot4.Left + 5
            End If
            If fire5 = False Then
                shot5.Left = shot5.Left + 5
            End If
        End If
        movealiens()
        If fire = True Then
            checkshot()
        End If
        moveshot()
    End Sub

#End Region

#Region "keypressed"
    Private Sub movecompleft(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue - Keys.A Then
            rig = True
        End If
        If e.KeyValue - Keys.D Then
            lef = True
        End If
        If e.KeyValue = Keys.W Then
            fire = True
        End If
    End Sub

    Private Sub movecomptop(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue - Keys.A Then
            lef = False
        End If
        If e.KeyValue - Keys.D Then
            rig = False
        End If
        If e.KeyCode = Keys.W Then
            fire = False
        End If
    End Sub
#End Region

#Region "My Sub"
    Public Sub New()
        InitializeComponent()
        createarray()
    End Sub

    Private Sub createarray()
        aliens(0) = alien1
        aliens(1) = alien2
        aliens(2) = alien3
        aliens(3) = alien4
        aliens(4) = alien5
        aliens(5) = alien6
        aliens(6) = alien7
        aliens(7) = alien8
        aliens(8) = alien9
        aliens(9) = alien10
        aliens(10) = alien11
        aliens(11) = alien12
    End Sub

    Private Sub movealiens()
        For i = 0 To 11
            aliens(i).Left = aliens(i).Left + movealien
            If aliens(i).Bounds.IntersectsWith(spaceship.Bounds) Then
                playerdead()
            End If
            If aliens(i).Left > 956 Then
                movealien = movealien * -1
                For k = 0 To 11
                    aliens(k).Top += 10
                Next
            End If
            If aliens(i).Left < 0 Then
                movealien = movealien * -1
                For k = 0 To 11
                    aliens(k).Top += 10
                Next
            End If
        Next
    End Sub

    Private Sub checkshot()
        fire = False
        If fire1 = False Then
            fire1 = True
            shot1.Show()
            Exit Sub
        End If
        If fire2 = False Then
            fire2 = True
            shot2.Show()
            Exit Sub
        End If
        If fire3 = False Then
            fire3 = True
            shot3.Show()
        End If
        If fire4 = False Then
            fire4 = True
            shot4.Show()
        End If
        If fire5 = False Then
            fire5 = True
            shot5.Show()
            Exit Sub
        End If
    End Sub

    Private Sub moveshot()
        If fire1 = True Then
            shot1.Top = shot1.Top - 5
            For i = 0 To 11
                If shot1.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    whichalien = i
                    shot1hit()
                End If
            Next
            If shot1.Top < 0 Then
                shot1.Hide()
                fire1 = False
                shot1.Location = restartshot.Location
            End If
        End If
        If fire2 = True Then
            shot2.Top = shot2.Top - 5
            For i = 0 To 11
                If shot2.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    whichalien = i
                    shot2hit()
                End If
            Next
            If shot2.Top < 0 Then
                shot2.Hide()
                fire2 = False
                shot2.Location = restartshot.Location
            End If
        End If
        If fire3 = True Then
            shot3.Top = shot3.Top - 5
            For i = 0 To 11
                If shot3.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    whichalien = i
                    shot3hit()
                End If
            Next
            If shot3.Top < 0 Then
                shot3.Hide()
                fire3 = False
                shot3.Location = restartshot.Location
            End If
        End If
        If fire4 = True Then
            shot4.Top = shot4.Top - 5
            For i = 0 To 11
                If shot4.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    whichalien = i
                    shot4hit()
                End If
            Next
            If shot4.Top < 0 Then
                shot4.Hide()
                fire4 = False
                shot4.Location = restartshot.Location
            End If
        End If
        If fire5 = True Then
            shot5.Top = shot5.Top - 5
            For i = 0 To 11
                If shot5.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    whichalien = i
                    shot4hit()
                End If
            Next
            If fire5 < 0 Then
                fire5 = False
                shot5.Location = restartshot.Location
            End If
        End If
    End Sub
    Private Sub shot1hit()
        fire1 = False
        shot1.Hide()
        shot1.Location = restartshot.Location
        aliens(whichalien).Top = aliens(whichalien).Top + 10000
    End Sub
    Private Sub shot2hit()
        fire2 = False
        shot2.Hide()
        shot2.Location = restartshot.Location
        aliens(whichalien).Top = aliens(whichalien).Top + 10000
    End Sub
    Private Sub shot3hit()
        fire3 = False
        shot3.Hide()
        shot3.Location = restartshot.Location
        aliens(whichalien).Top = aliens(whichalien).Top + 10000
    End Sub
    Private Sub shot4hit()
        fire4 = False
        shot4.Hide()
        shot4.Location = restartshot.Location
        aliens(whichalien).Top = aliens(whichalien).Top + 10000
    End Sub
    Private Sub shot5hot()
        fire5 = False
        shot5.Hide()
        shot5.Location = restartshot.Location
        aliens(whichalien).Top = aliens(whichalien).Top + 10000
    End Sub
    Private Sub playerdead()
        movecomp.Stop()
        spaceship.Image = My.Resources.Explode
        dead.Show()
    End Sub
    Private Sub Playerwin()
        movecomp.Stop()
        Win.Show()
    End Sub
#End Region

    Private Sub HelpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub


End Class


