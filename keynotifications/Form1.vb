Public Class notifications




    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        Me.Location = New Point((My.Computer.Screen.Bounds.Right - My.Computer.Screen.Bounds.Left - Me.Size.Width), (My.Computer.Screen.Bounds.Bottom - My.Computer.Screen.Bounds.Top - Me.Size.Height - 40))
        Dim caps As Boolean = My.Computer.Keyboard.CapsLock
        Dim num As Boolean = My.Computer.Keyboard.NumLock
        Dim scr As Boolean = My.Computer.Keyboard.ScrollLock
        capson.Visible = caps
        capsoff.Visible = Not caps
        numlockon.Visible = num
        numlockoff.Visible = Not num
        scrolockon.Visible = scr
        scrolockoff.Visible = Not scr

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        NotifyIcon1.Dispose()
        Me.Close()
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        NotifyIcon1.Dispose()
        Me.Close()
    End Sub
End Class
