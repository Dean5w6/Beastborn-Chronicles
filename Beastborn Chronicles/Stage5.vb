Public Class Stage5
    Public MaxHP As Integer = ActionMenu.MaxHP
    Public XP As Integer = ActionMenu.XP
    Public Level As Integer = ActionMenu.Level
    Public Stamina As Integer = ActionMenu.Stamina
    Public Strength As Integer = ActionMenu.Strength
    Dim EnemyHP As Integer = 70000
    Dim Counter As Integer = 0
    Dim EnemyDamage = 7500

    Private Sub Stage1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActionMenu.CD = 5
        VBarexonPic()
        Label1.Text = MaxHP
        Label2.Text = EnemyHP
        PictureBox5.Parent = PictureBox1
        PictureBox6.Parent = PictureBox2
        'PictureBox5.Visible = False
        'PictureBox6.Visible = False
        Label5.Visible = False
        Label4.Visible = False
        Label5.Text = $"-{EnemyDamage}"
        Label4.Text = $"-{Strength}"
    End Sub

    Private Sub Stage1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        VBarexonPic()
        Label5.Visible = False
    End Sub

    Sub EnemyCheck()
        If EnemyHP <= 0 Then
            ActionMenu.PictureBox2.Image = My.Resources.StageClear
            ActionMenu.PictureBox2.Visible = True
            Me.Close()
            ActionMenu.Show()
            ActionMenu.Stage = 6
            ActionMenu.Level += 1
        End If
    End Sub

    Sub UserCheck()
        If MaxHP <= 0 Then
            ActionMenu.PictureBox2.Image = My.Resources.Retry
            ActionMenu.PictureBox2.Visible = True
            Me.Close()
            ActionMenu.Show()
        End If
    End Sub
    Private Sub VBarexonPic()
        Select Case Level
            Case 1 To 5
                PictureBox1.Image = My.Resources.VB00
            Case 6 To 10
                PictureBox1.Image = My.Resources.VB01
            Case 11 To 15
                PictureBox1.Image = My.Resources.VB02
            Case 16 To 20
                PictureBox1.Image = My.Resources.VB03
            Case 21 To 25
                PictureBox1.Image = My.Resources.VB04
            Case 26 To 30
                PictureBox1.Image = My.Resources.VB05
            Case 31 To 35
                PictureBox1.Image = My.Resources.VB06
            Case 36 To 40
                PictureBox1.Image = My.Resources.VB07
            Case 41 To 45
                PictureBox1.Image = My.Resources.VB08
            Case 46 To 50
                PictureBox1.Image = My.Resources.VB09
            Case 51 To 55
                PictureBox1.Image = My.Resources.VB10
            Case 56 To 60
                PictureBox1.Image = My.Resources.VB11
            Case 61 To 65
                PictureBox1.Image = My.Resources.VB12
            Case 66 To 70
                PictureBox1.Image = My.Resources.VB13
            Case 71 To 80
                PictureBox1.Image = My.Resources.VB14
            Case 81 To 99
                PictureBox1.Image = My.Resources.VB15
            Case 100
                PictureBox1.Image = My.Resources.VB16

        End Select
        If Level >= 100 Then
            PictureBox1.Image = My.Resources.VB16
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Attack.Start()
        Button.Start()
        Button1.Visible = False
    End Sub

    Private Sub Attack_Tick(sender As Object, e As EventArgs) Handles Attack.Tick
        Select Case Counter
            Case 0
                PictureBox6.Visible = True
                PictureBox6.Image = My.Resources.Pulse00
                Counter += 2
            Case 2
                PictureBox6.Image = My.Resources.Pulse01
                Counter += 1
                Label4.Visible = True
                Label4.Top -= 10
            Case 3
                PictureBox6.Image = My.Resources.Pulse02
                Counter += 1
                Label4.Top -= 10
            Case 4
                PictureBox6.Image = My.Resources.Pulse03
                Counter += 1
                Label4.Top -= 10
            Case 5
                PictureBox6.Image = My.Resources.Pulse04
                Counter += 1
                EnemyHP -= Strength
                Label2.Text = EnemyHP
                Label4.Visible = False
                Label4.Top += 30
            Case 6
                PictureBox6.Image = My.Resources.Pulse05
                Counter += 1
            Case 7
                PictureBox6.Image = My.Resources.Pulse06
                Counter += 1
            Case 8
                PictureBox6.Image = My.Resources.Pulse07
                Counter += 1
            Case 9
                PictureBox6.Image = My.Resources.Pulse08
                Counter += 1

            Case 10
                PictureBox6.Visible = False
                If EnemyHP > 0 Then
                    Counter += 1
                Else
                    EnemyCheck()
                    Counter = 0
                    Attack.Stop()
                End If
            Case 11
                Counter += 1
            Case 12
                Counter += 1
            Case 13
                PictureBox5.Visible = True
                PictureBox5.Image = My.Resources.CBomb00
                Counter += 1

            Case 14
                PictureBox5.Image = My.Resources.CBomb01
                Counter += 1

            Case 15
                PictureBox5.Image = My.Resources.CBomb02
                Counter += 1

            Case 16
                PictureBox5.Image = My.Resources.CBomb03
                Counter += 1

            Case 17
                PictureBox5.Image = My.Resources.CBomb04
                Counter += 1
                Label5.Visible = True
                Label5.Top -= 10
            Case 18
                PictureBox5.Image = My.Resources.CBomb05
                Counter += 1
                MaxHP -= EnemyDamage
                Label5.Top -= 10
                Label1.Text = MaxHP
            Case 19
                PictureBox5.Image = My.Resources.CBomb06
                Counter += 1
                Label5.Top -= 10
            Case 20
                PictureBox5.Image = My.Resources.CBomb07
                Counter += 1
            Case 21
                Label5.Top += 30
                Label5.Visible = False
                PictureBox5.Visible = False
                Counter = 0
                Attack.Stop()
                UserCheck()
                ActionMenu.XP += 60
        End Select
    End Sub

    Private Sub Button_Tick(sender As Object, e As EventArgs) Handles Button.Tick
        If Button1.Visible = True Then
            Button1.Visible = False
        ElseIf Button1.Visible = False Then
            Button1.Visible = True
            Button.Stop()
        End If
    End Sub
End Class