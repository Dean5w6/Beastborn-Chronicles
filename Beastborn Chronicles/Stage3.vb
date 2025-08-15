Public Class Stage3
    Public MaxHP As Integer = ActionMenu.MaxHP
    Public XP As Integer = ActionMenu.XP
    Public Level As Integer = ActionMenu.Level
    Public Stamina As Integer = ActionMenu.Stamina
    Public Strength As Integer = ActionMenu.Strength
    Dim EnemyHP As Integer = 15000
    Dim Counter As Integer = 0
    Dim EnemyDamage = 1000

    Private Sub Stage1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActionMenu.CD = 5
        VBarexonPic()
        Label1.Text = MaxHP
        Label2.Text = EnemyHP
        PictureBox5.Parent = PictureBox1
        PictureBox6.Parent = PictureBox2
        PictureBox5.Visible = False
        PictureBox6.Visible = False
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
            ActionMenu.Stage = 4
            ActionMenu.Level += 3
        End If
    End Sub

    Sub UserCheck()
        If MaxHP <= 0 Then
            ActionMenu.PictureBox2.Image = My.Resources.Retry
            ActionMenu.PictureBox2.Visible = True
            Me.Hide()
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
                PictureBox6.Image = My.Resources.Claw00
                Counter += 1

            Case 1
                PictureBox6.Image = My.Resources.Claw01
                Counter += 1

            Case 2
                PictureBox6.Image = My.Resources.Claw02
                Counter += 1
            Case 3
                PictureBox6.Image = My.Resources.Claw03
                Counter += 1

            Case 4
                PictureBox6.Image = My.Resources.Claw04
                EnemyHP -= Strength
                Label2.Text = EnemyHP
                Counter += 1
                Label4.Visible = True
                Label4.Top -= 10
            Case 5
                PictureBox6.Image = My.Resources.Claw05
                Counter += 1
                Label4.Top -= 10
            Case 6
                PictureBox6.Image = My.Resources.Claw06
                Counter += 1
                Label4.Top -= 10

            Case 7
                Label4.Visible = False
                Label4.Top += 30
                PictureBox6.Visible = False
                If EnemyHP > 0 Then
                    Counter += 1
                Else
                    EnemyCheck()
                    Counter = 0
                    Attack.Stop()
                End If
            Case 8
                Counter += 1
            Case 9
                Counter += 1
            Case 10
                PictureBox5.Visible = True
                PictureBox5.Image = My.Resources.quickFX1
                Counter += 1
                Label3.Visible = True
                Label3.Top -= 10
            Case 11
                PictureBox5.Image = My.Resources.quickFX2
                Counter += 1
                Label3.Top -= 10
            Case 12
                PictureBox5.Image = My.Resources.quickFX3
                Counter += 1
                MaxHP -= EnemyDamage
                Label3.Top -= 10
                Label1.Text = MaxHP
            Case 13
                PictureBox5.Visible = False
                Counter = 0
                Attack.Stop()
                UserCheck()
                ActionMenu.XP += 20
                Label3.Top += 30
                Label3.Visible = False
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