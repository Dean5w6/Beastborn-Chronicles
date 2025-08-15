Public Class Stage4
    Public MaxHP As Integer = ActionMenu.MaxHP
    Public XP As Integer = ActionMenu.XP
    Public Level As Integer = ActionMenu.Level
    Public Stamina As Integer = ActionMenu.Stamina
    Public Strength As Integer = ActionMenu.Strength
    Dim EnemyHP As Integer = 40000
    Dim Counter As Integer = 0
    Dim EnemyDamage = 3200

    Private Sub Stage01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActionMenu.CD = 5
        VBarexonPic()
        Label1.Text = MaxHP
        Label2.Text = EnemyHP
        PictureBox7.Parent = PictureBox1
        PictureBox6.Parent = PictureBox2
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label3.Text = $"-{EnemyDamage}"
        Label4.Text = $"-{Strength}"
    End Sub


    Sub EnemyCheck()
        If EnemyHP <= 0 Then
            ActionMenu.PictureBox2.Image = My.Resources.StageClear
            ActionMenu.PictureBox2.Visible = True
            Me.Hide()
            ActionMenu.Show()
            ActionMenu.Stage = 5
            ActionMenu.Level += 2
        End If
    End Sub

    Sub UserCheck()
        If MaxHP <= 0 Then
            ActionMenu.PictureBox2.Image = My.Resources.Retry
            ActionMenu.PictureBox2.Visible = True
            Me.Hide()
            ActionMenu.Show()
        Else
            Counter += 1
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
            Case 7
                PictureBox6.Visible = True
                PictureBox6.Image = My.Resources.GPunch00
                Counter += 1

            Case 8
                PictureBox6.Image = My.Resources.GPunch01
                Counter += 1
            Case 9
                PictureBox6.Image = My.Resources.GPunch02
                Counter += 1

            Case 10
                PictureBox6.Image = My.Resources.GPunch03
                EnemyHP -= Strength
                Label2.Text = EnemyHP
                Counter += 1
                Label4.Visible = True
                Label4.Top -= 10

            Case 11
                PictureBox6.Image = My.Resources.GPunch04
                Counter += 1
                Label4.Top -= 10
            Case 12
                PictureBox6.Image = My.Resources.GPunch05
                Counter += 1
                Label4.Top -= 10

            Case 13
                Label4.Visible = False
                Label4.Top += 30
                PictureBox6.Visible = False
                PictureBox6.Visible = False
                If EnemyHP > 0 Then
                    Counter += 1
                Else
                    EnemyCheck()
                    Counter = 0
                    Attack.Stop()
                End If
                Attack.Stop()
                Counter = 0
            Case 5
                Counter += 1
            Case 6
                Counter += 1
            Case 0
                PictureBox5.Visible = True
                PictureBox5.Image = My.Resources.Projectile00
                PictureBox7.Visible = True
                PictureBox7.Image = My.Resources.Projectile00
                Counter += 1

            Case 1
                PictureBox5.Image = My.Resources.Projectile01
                PictureBox7.Image = My.Resources.Projectile01
                Counter += 1
                Label3.Visible = True
                Label3.Top -= 10
            Case 2
                PictureBox5.Image = My.Resources.Projectile02
                PictureBox7.Image = My.Resources.Projectile02
                Counter += 1
                MaxHP -= EnemyDamage
                Label3.Top -= 10
                Label1.Text = MaxHP
            Case 3
                PictureBox5.Image = My.Resources.Projectile03
                PictureBox7.Image = My.Resources.Projectile03
                Counter += 1
                Label3.Top -= 10
            Case 4
                UserCheck()
                ActionMenu.XP += 30
                Label3.Top += 30
                Label3.Visible = False
                PictureBox5.Visible = False
                PictureBox7.Visible = False
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