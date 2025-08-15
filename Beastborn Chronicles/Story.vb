Public Class Story
    Dim Counter As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = True
        Timer1.Stop()
    End Sub

    Sub Counter1()
        Select Case Counter
            Case 1
                Me.BackgroundImage = My.Resources.Story01
                PictureBox1.Image = My.Resources.Script01
            Case 2
                PictureBox1.Image = My.Resources.Script02
                Me.BackgroundImage = My.Resources.Story02
            Case 3
                PictureBox1.Image = My.Resources.Script03
                Me.BackgroundImage = My.Resources.Story03
            Case 4
                PictureBox1.Image = My.Resources.Script04
                Me.BackgroundImage = My.Resources.Story04
            Case 5
                PictureBox1.Image = My.Resources.Script05
            Case 6
                Me.Hide()
                ActionMenu.Show()
        End Select
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Visible = False
        Counter += 1
        Counter1()
        Timer1.Start()
    End Sub

    Private Sub Story_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class