<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.startgame = New System.Windows.Forms.Button()
        Me.quitgame = New System.Windows.Forms.Button()
        Me.movecomp = New System.Windows.Forms.Timer(Me.components)
        Me.formloder1 = New System.Windows.Forms.Panel()
        Me.dead = New System.Windows.Forms.Label()
        Me.shot5 = New System.Windows.Forms.Label()
        Me.shot4 = New System.Windows.Forms.Label()
        Me.shot3 = New System.Windows.Forms.Label()
        Me.shot2 = New System.Windows.Forms.Label()
        Me.shot1 = New System.Windows.Forms.Label()
        Me.restartshot = New System.Windows.Forms.Label()
        Me.alien2 = New System.Windows.Forms.PictureBox()
        Me.spaceship = New System.Windows.Forms.PictureBox()
        Me.alien11 = New System.Windows.Forms.PictureBox()
        Me.alien3 = New System.Windows.Forms.PictureBox()
        Me.alien9 = New System.Windows.Forms.PictureBox()
        Me.alien1 = New System.Windows.Forms.PictureBox()
        Me.alien10 = New System.Windows.Forms.PictureBox()
        Me.alien8 = New System.Windows.Forms.PictureBox()
        Me.alien4 = New System.Windows.Forms.PictureBox()
        Me.alien12 = New System.Windows.Forms.PictureBox()
        Me.alien6 = New System.Windows.Forms.PictureBox()
        Me.alien5 = New System.Windows.Forms.PictureBox()
        Me.alien7 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Win = New System.Windows.Forms.Label()
        Me.formloder1.SuspendLayout()
        CType(Me.alien2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spaceship, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-31, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(868, 99)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Space Invaders"
        '
        'startgame
        '
        Me.startgame.Font = New System.Drawing.Font("OCR A Extended", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startgame.Location = New System.Drawing.Point(403, 212)
        Me.startgame.Name = "startgame"
        Me.startgame.Size = New System.Drawing.Size(107, 45)
        Me.startgame.TabIndex = 1
        Me.startgame.Text = "Start Game "
        Me.startgame.UseVisualStyleBackColor = True
        '
        'quitgame
        '
        Me.quitgame.Font = New System.Drawing.Font("OCR A Extended", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitgame.Location = New System.Drawing.Point(417, 285)
        Me.quitgame.Name = "quitgame"
        Me.quitgame.Size = New System.Drawing.Size(74, 43)
        Me.quitgame.TabIndex = 2
        Me.quitgame.Text = "Quit Game "
        Me.quitgame.UseVisualStyleBackColor = True
        '
        'movecomp
        '
        Me.movecomp.Interval = 10
        '
        'formloder1
        '
        Me.formloder1.Controls.Add(Me.Win)
        Me.formloder1.Controls.Add(Me.dead)
        Me.formloder1.Controls.Add(Me.shot5)
        Me.formloder1.Controls.Add(Me.shot4)
        Me.formloder1.Controls.Add(Me.shot3)
        Me.formloder1.Controls.Add(Me.shot2)
        Me.formloder1.Controls.Add(Me.shot1)
        Me.formloder1.Controls.Add(Me.restartshot)
        Me.formloder1.Controls.Add(Me.alien2)
        Me.formloder1.Controls.Add(Me.spaceship)
        Me.formloder1.Controls.Add(Me.alien11)
        Me.formloder1.Controls.Add(Me.alien3)
        Me.formloder1.Controls.Add(Me.alien9)
        Me.formloder1.Controls.Add(Me.alien1)
        Me.formloder1.Controls.Add(Me.alien10)
        Me.formloder1.Controls.Add(Me.alien8)
        Me.formloder1.Controls.Add(Me.alien4)
        Me.formloder1.Controls.Add(Me.alien12)
        Me.formloder1.Controls.Add(Me.alien6)
        Me.formloder1.Controls.Add(Me.alien5)
        Me.formloder1.Controls.Add(Me.alien7)
        Me.formloder1.Location = New System.Drawing.Point(2, 23)
        Me.formloder1.Name = "formloder1"
        Me.formloder1.Size = New System.Drawing.Size(954, 542)
        Me.formloder1.TabIndex = 5
        Me.formloder1.Visible = False
        '
        'dead
        '
        Me.dead.AutoSize = True
        Me.dead.BackColor = System.Drawing.Color.Black
        Me.dead.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dead.ForeColor = System.Drawing.Color.White
        Me.dead.Location = New System.Drawing.Point(299, 237)
        Me.dead.Name = "dead"
        Me.dead.Size = New System.Drawing.Size(343, 77)
        Me.dead.TabIndex = 8
        Me.dead.Text = "You Died!"
        Me.dead.Visible = False
        '
        'shot5
        '
        Me.shot5.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.shot5.BackColor = System.Drawing.Color.White
        Me.shot5.ForeColor = System.Drawing.Color.White
        Me.shot5.Location = New System.Drawing.Point(437, 482)
        Me.shot5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shot5.Name = "shot5"
        Me.shot5.Size = New System.Drawing.Size(3, 20)
        Me.shot5.TabIndex = 7
        Me.shot5.Text = "Label2"
        Me.shot5.Visible = False
        '
        'shot4
        '
        Me.shot4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.shot4.BackColor = System.Drawing.Color.White
        Me.shot4.ForeColor = System.Drawing.Color.White
        Me.shot4.Location = New System.Drawing.Point(437, 482)
        Me.shot4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shot4.Name = "shot4"
        Me.shot4.Size = New System.Drawing.Size(3, 20)
        Me.shot4.TabIndex = 6
        Me.shot4.Text = "Label2"
        Me.shot4.Visible = False
        '
        'shot3
        '
        Me.shot3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.shot3.BackColor = System.Drawing.Color.White
        Me.shot3.ForeColor = System.Drawing.Color.White
        Me.shot3.Location = New System.Drawing.Point(437, 482)
        Me.shot3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shot3.Name = "shot3"
        Me.shot3.Size = New System.Drawing.Size(3, 20)
        Me.shot3.TabIndex = 5
        Me.shot3.Text = "Label2"
        Me.shot3.Visible = False
        '
        'shot2
        '
        Me.shot2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.shot2.BackColor = System.Drawing.Color.White
        Me.shot2.ForeColor = System.Drawing.Color.White
        Me.shot2.Location = New System.Drawing.Point(437, 482)
        Me.shot2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shot2.Name = "shot2"
        Me.shot2.Size = New System.Drawing.Size(3, 20)
        Me.shot2.TabIndex = 4
        Me.shot2.Text = "Label2"
        Me.shot2.Visible = False
        '
        'shot1
        '
        Me.shot1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.shot1.BackColor = System.Drawing.Color.White
        Me.shot1.ForeColor = System.Drawing.Color.White
        Me.shot1.Location = New System.Drawing.Point(437, 482)
        Me.shot1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shot1.Name = "shot1"
        Me.shot1.Size = New System.Drawing.Size(3, 20)
        Me.shot1.TabIndex = 3
        Me.shot1.Text = "Label2"
        Me.shot1.Visible = False
        '
        'restartshot
        '
        Me.restartshot.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.restartshot.BackColor = System.Drawing.Color.White
        Me.restartshot.ForeColor = System.Drawing.Color.White
        Me.restartshot.Location = New System.Drawing.Point(437, 482)
        Me.restartshot.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.restartshot.Name = "restartshot"
        Me.restartshot.Size = New System.Drawing.Size(3, 20)
        Me.restartshot.TabIndex = 2
        Me.restartshot.Text = "restartshot"
        Me.restartshot.Visible = False
        '
        'alien2
        '
        Me.alien2.Image = CType(resources.GetObject("alien2.Image"), System.Drawing.Image)
        Me.alien2.Location = New System.Drawing.Point(664, 105)
        Me.alien2.Name = "alien2"
        Me.alien2.Size = New System.Drawing.Size(65, 68)
        Me.alien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien2.TabIndex = 1
        Me.alien2.TabStop = False
        '
        'spaceship
        '
        Me.spaceship.Image = CType(resources.GetObject("spaceship.Image"), System.Drawing.Image)
        Me.spaceship.Location = New System.Drawing.Point(392, 455)
        Me.spaceship.Name = "spaceship"
        Me.spaceship.Size = New System.Drawing.Size(81, 84)
        Me.spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spaceship.TabIndex = 0
        Me.spaceship.TabStop = False
        '
        'alien11
        '
        Me.alien11.Image = CType(resources.GetObject("alien11.Image"), System.Drawing.Image)
        Me.alien11.Location = New System.Drawing.Point(273, 18)
        Me.alien11.Name = "alien11"
        Me.alien11.Size = New System.Drawing.Size(65, 68)
        Me.alien11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien11.TabIndex = 1
        Me.alien11.TabStop = False
        '
        'alien3
        '
        Me.alien3.Image = CType(resources.GetObject("alien3.Image"), System.Drawing.Image)
        Me.alien3.Location = New System.Drawing.Point(139, 20)
        Me.alien3.Name = "alien3"
        Me.alien3.Size = New System.Drawing.Size(65, 68)
        Me.alien3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien3.TabIndex = 1
        Me.alien3.TabStop = False
        '
        'alien9
        '
        Me.alien9.Image = CType(resources.GetObject("alien9.Image"), System.Drawing.Image)
        Me.alien9.Location = New System.Drawing.Point(344, 92)
        Me.alien9.Name = "alien9"
        Me.alien9.Size = New System.Drawing.Size(65, 68)
        Me.alien9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien9.TabIndex = 1
        Me.alien9.TabStop = False
        '
        'alien1
        '
        Me.alien1.Image = CType(resources.GetObject("alien1.Image"), System.Drawing.Image)
        Me.alien1.Location = New System.Drawing.Point(209, 92)
        Me.alien1.Name = "alien1"
        Me.alien1.Size = New System.Drawing.Size(65, 68)
        Me.alien1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien1.TabIndex = 1
        Me.alien1.TabStop = False
        '
        'alien10
        '
        Me.alien10.Image = CType(resources.GetObject("alien10.Image"), System.Drawing.Image)
        Me.alien10.Location = New System.Drawing.Point(486, 102)
        Me.alien10.Name = "alien10"
        Me.alien10.Size = New System.Drawing.Size(65, 68)
        Me.alien10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien10.TabIndex = 1
        Me.alien10.TabStop = False
        '
        'alien8
        '
        Me.alien8.Image = CType(resources.GetObject("alien8.Image"), System.Drawing.Image)
        Me.alien8.Location = New System.Drawing.Point(3, 20)
        Me.alien8.Name = "alien8"
        Me.alien8.Size = New System.Drawing.Size(65, 68)
        Me.alien8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien8.TabIndex = 1
        Me.alien8.TabStop = False
        '
        'alien4
        '
        Me.alien4.Image = CType(resources.GetObject("alien4.Image"), System.Drawing.Image)
        Me.alien4.Location = New System.Drawing.Point(73, 92)
        Me.alien4.Name = "alien4"
        Me.alien4.Size = New System.Drawing.Size(65, 68)
        Me.alien4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien4.TabIndex = 1
        Me.alien4.TabStop = False
        '
        'alien12
        '
        Me.alien12.Image = CType(resources.GetObject("alien12.Image"), System.Drawing.Image)
        Me.alien12.Location = New System.Drawing.Point(415, 18)
        Me.alien12.Name = "alien12"
        Me.alien12.Size = New System.Drawing.Size(65, 68)
        Me.alien12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien12.TabIndex = 1
        Me.alien12.TabStop = False
        '
        'alien6
        '
        Me.alien6.Image = CType(resources.GetObject("alien6.Image"), System.Drawing.Image)
        Me.alien6.Location = New System.Drawing.Point(729, 20)
        Me.alien6.Name = "alien6"
        Me.alien6.Size = New System.Drawing.Size(65, 68)
        Me.alien6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien6.TabIndex = 1
        Me.alien6.TabStop = False
        '
        'alien5
        '
        Me.alien5.Image = CType(resources.GetObject("alien5.Image"), System.Drawing.Image)
        Me.alien5.Location = New System.Drawing.Point(838, 105)
        Me.alien5.Name = "alien5"
        Me.alien5.Size = New System.Drawing.Size(81, 79)
        Me.alien5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien5.TabIndex = 1
        Me.alien5.TabStop = False
        '
        'alien7
        '
        Me.alien7.Image = CType(resources.GetObject("alien7.Image"), System.Drawing.Image)
        Me.alien7.Location = New System.Drawing.Point(562, 20)
        Me.alien7.Name = "alien7"
        Me.alien7.Size = New System.Drawing.Size(65, 68)
        Me.alien7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien7.TabIndex = 1
        Me.alien7.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(956, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(650, 323)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 141)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 309)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Win
        '
        Me.Win.AutoSize = True
        Me.Win.BackColor = System.Drawing.Color.Black
        Me.Win.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Win.ForeColor = System.Drawing.Color.White
        Me.Win.Location = New System.Drawing.Point(288, 246)
        Me.Win.Name = "Win"
        Me.Win.Size = New System.Drawing.Size(373, 77)
        Me.Win.TabIndex = 9
        Me.Win.Text = "You Win :)"
        Me.Win.Visible = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(956, 557)
        Me.Controls.Add(Me.formloder1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.quitgame)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.startgame)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "form1"
        Me.Text = "Space Invaders"
        Me.formloder1.ResumeLayout(false)
        Me.formloder1.PerformLayout
        CType(Me.alien2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spaceship,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien11,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien12,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.alien7,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents startgame As System.Windows.Forms.Button
    Friend WithEvents quitgame As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents spaceship As System.Windows.Forms.PictureBox
    Friend WithEvents movecomp As System.Windows.Forms.Timer
    Friend WithEvents alien1 As System.Windows.Forms.PictureBox
    Friend WithEvents alien2 As System.Windows.Forms.PictureBox
    Friend WithEvents alien8 As System.Windows.Forms.PictureBox
    Friend WithEvents alien7 As System.Windows.Forms.PictureBox
    Friend WithEvents alien6 As System.Windows.Forms.PictureBox
    Friend WithEvents alien5 As System.Windows.Forms.PictureBox
    Friend WithEvents alien4 As System.Windows.Forms.PictureBox
    Friend WithEvents alien3 As System.Windows.Forms.PictureBox
    Friend WithEvents alien12 As System.Windows.Forms.PictureBox
    Friend WithEvents alien11 As System.Windows.Forms.PictureBox
    Friend WithEvents alien10 As System.Windows.Forms.PictureBox
    Friend WithEvents alien9 As System.Windows.Forms.PictureBox
    Friend WithEvents formloder1 As System.Windows.Forms.Panel
    Friend WithEvents restartshot As System.Windows.Forms.Label
    Friend WithEvents shot2 As System.Windows.Forms.Label
    Friend WithEvents shot1 As System.Windows.Forms.Label
    Friend WithEvents shot5 As System.Windows.Forms.Label
    Friend WithEvents shot4 As System.Windows.Forms.Label
    Friend WithEvents shot3 As System.Windows.Forms.Label
    Friend WithEvents dead As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Win As System.Windows.Forms.Label

End Class
