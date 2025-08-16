Public Class ActionMenu
    Public MaxHP As Integer = 20
    Public XP As Integer = 0
    Public Level As Integer = 1
    Public Stamina As Integer = 20
    Public Strength As Integer = 20
    Public Stage = 1
    Public CD As Integer = 5
    Private Sub ActionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Check.Start()
        PictureBox2.Visible = False
        PictureBox2.Location = New Point(-9, 134)
        Form1.Hide()
    End Sub

    Private Sub ActionMenu_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Form1.Hide()
    End Sub

    Public Sub VarexonPic()
        Select Case Level
            Case 1 To 5
                PictureBox1.Image = My.Resources.V00
                PictureBox1.Image = My.Resources.V00
            Case 6 To 10
                PictureBox1.Image = My.Resources.V01
            Case 11 To 15
                PictureBox1.Image = My.Resources.V02
            Case 16 To 20
                PictureBox1.Image = My.Resources.V03
            Case 21 To 25
                PictureBox1.Image = My.Resources.V04
            Case 26 To 30
                PictureBox1.Image = My.Resources.V05
            Case 31 To 35
                PictureBox1.Image = My.Resources.V06
            Case 36 To 40
                PictureBox1.Image = My.Resources.V07
            Case 41 To 45
                PictureBox1.Image = My.Resources.V08
            Case 46 To 50
                PictureBox1.Image = My.Resources.V10
            Case 51 To 55
                PictureBox1.Image = My.Resources.V11
            Case 56 To 60
                PictureBox1.Image = My.Resources.V09
            Case 61 To 65
                PictureBox1.Image = My.Resources.V12
            Case 66 To 70
                PictureBox1.Image = My.Resources.V13
            Case 71 To 80
                PictureBox1.Image = My.Resources.V14
            Case 81 To 99
                PictureBox1.Image = My.Resources.V15
            Case 100 To 120
                PictureBox1.Image = My.Resources.V16

        End Select
    End Sub

    Private Sub VarexonLevel()
        Select Case Level
            Case 6
                Strength = CInt(Strength * 1.5)
                MaxHP = CInt(MaxHP * 1.5)
            Case 11
                Strength = CInt(Strength * 1.4)
                MaxHP = CInt(MaxHP * 1.4)
            Case 11
                Strength = CInt(Strength * 1.3)
                MaxHP = CInt(MaxHP * 1.3)
            Case 21
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 26
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 31
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 36
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 41
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 46
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 51
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 56
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 61
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 66
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 71
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 81
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 91
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
            Case 100
                Strength = CInt(Strength * 2.0)
                MaxHP = CInt(MaxHP * 2.0)
            Case 105, 110, 115, 120, 125, 130, 135, 140, 145, 150
                Strength = CInt(Strength * 1.2)
                MaxHP = CInt(MaxHP * 1.2)
        End Select
    End Sub

    Private Sub Check_Tick(sender As Object, e As EventArgs) Handles Check.Tick
        If XP > 200 Then
            XP -= 200
            Level += 1
            VarexonLevel()
            VarexonPic()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Stage
            Case 1
                Dim newStage1 As New Stage001()
                Me.Hide()
                Select Case Level
                    Case 1 To 5
                        newStage1.PictureBox1.Image = My.Resources.VB00
                        newStage1.PictureBox1.Image = My.Resources.VB00
                    Case 6 To 10
                        newStage1.PictureBox1.Image = My.Resources.VB01
                    Case 11 To 15
                        newStage1.PictureBox1.Image = My.Resources.VB02
                    Case 16 To 20
                        newStage1.PictureBox1.Image = My.Resources.VB03
                    Case 21 To 25
                        newStage1.PictureBox1.Image = My.Resources.VB04
                    Case 26 To 30
                        newStage1.PictureBox1.Image = My.Resources.VB05
                    Case 31 To 35
                        newStage1.PictureBox1.Image = My.Resources.VB06
                    Case 36 To 40
                        newStage1.PictureBox1.Image = My.Resources.VB07
                    Case 41 To 45
                        newStage1.PictureBox1.Image = My.Resources.VB08
                    Case 46 To 50
                        newStage1.PictureBox1.Image = My.Resources.VB10
                    Case 54 To 55
                        newStage1.PictureBox1.Image = My.Resources.VB11
                    Case 56 To 60
                        newStage1.PictureBox1.Image = My.Resources.VB09
                    Case 61 To 65
                        newStage1.PictureBox1.Image = My.Resources.VB12
                    Case 66 To 70
                        newStage1.PictureBox1.Image = My.Resources.VB13
                    Case 71 To 80
                        newStage1.PictureBox1.Image = My.Resources.VB14
                    Case 81 To 99
                        newStage1.PictureBox1.Image = My.Resources.VB15
                    Case 100
                        newStage1.PictureBox1.Image = My.Resources.VB16

                End Select
                newStage1.Show()
            Case 2
                Dim newStage2 As New Stage01()
                Me.Hide()
                newStage2.Show()
            Case 3
                Dim newStage3 As New Stage3()
                Me.Hide()
                newStage3.Show()
            Case 4
                Dim newStage4 As New Stage4()
                Me.Hide()
                newStage4.Show()
            Case 5
                Dim newStage5 As New Stage5()
                Me.Hide()
                newStage5.Show()
            Case 6
                Dim newStage6 As New Stage6()
                Me.Hide()
                newStage6.Show()
            Case 7
                Dim newStage7 As New Stage7()
                Me.Hide()
                newStage7.Show()
            Case 8
                Dim newStage1 As New Stage01()
                Me.Hide()
                newStage1.Show()

        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CD > 0 Then
            PictureBox2.Image = My.Resources.StrengthUp
            PictureBox2.Visible = True
            Strength += 10 * Stage
        Else
            PictureBox2.Image = My.Resources.CD
            PictureBox2.Visible = True
        End If

        CD -= 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CD > 0 Then
            PictureBox2.Image = My.Resources.XPUp
            PictureBox2.Visible = True
            XP += 40
        Else
            PictureBox2.Image = My.Resources.CD
            PictureBox2.Visible = True
        End If
        CD -= 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CD > 0 Then
            PictureBox2.Image = My.Resources.EnergyRest
            PictureBox2.Visible = True
            MaxHP += 20 * Stage
        Else
            PictureBox2.Image = My.Resources.CD
            PictureBox2.Visible = True
        End If

        CD -= 1
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
    End Sub
End Class