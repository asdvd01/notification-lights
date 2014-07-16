<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notifications
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notifications))
        Me.capsoff = New System.Windows.Forms.PictureBox()
        Me.numlockoff = New System.Windows.Forms.PictureBox()
        Me.numlockon = New System.Windows.Forms.PictureBox()
        Me.capson = New System.Windows.Forms.PictureBox()
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.scrolockon = New System.Windows.Forms.PictureBox()
        Me.scrolockoff = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitbtn = New System.Windows.Forms.Button()
        CType(Me.capsoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numlockoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numlockon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.capson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrolockon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrolockoff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'capsoff
        '
        Me.capsoff.Image = Global.keynotifications.My.Resources.Resources.off
        Me.capsoff.Location = New System.Drawing.Point(12, 12)
        Me.capsoff.Name = "capsoff"
        Me.capsoff.Size = New System.Drawing.Size(19, 18)
        Me.capsoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.capsoff.TabIndex = 7
        Me.capsoff.TabStop = False
        Me.capsoff.Visible = False
        '
        'numlockoff
        '
        Me.numlockoff.Image = Global.keynotifications.My.Resources.Resources.off
        Me.numlockoff.Location = New System.Drawing.Point(12, 56)
        Me.numlockoff.Name = "numlockoff"
        Me.numlockoff.Size = New System.Drawing.Size(19, 18)
        Me.numlockoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.numlockoff.TabIndex = 5
        Me.numlockoff.TabStop = False
        Me.numlockoff.Visible = False
        '
        'numlockon
        '
        Me.numlockon.Image = Global.keynotifications.My.Resources.Resources._on
        Me.numlockon.Location = New System.Drawing.Point(12, 56)
        Me.numlockon.Name = "numlockon"
        Me.numlockon.Size = New System.Drawing.Size(19, 18)
        Me.numlockon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.numlockon.TabIndex = 2
        Me.numlockon.TabStop = False
        Me.numlockon.Visible = False
        '
        'capson
        '
        Me.capson.Image = Global.keynotifications.My.Resources.Resources._on
        Me.capson.Location = New System.Drawing.Point(12, 12)
        Me.capson.Name = "capson"
        Me.capson.Size = New System.Drawing.Size(19, 18)
        Me.capson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.capson.TabIndex = 0
        Me.capson.TabStop = False
        Me.capson.Visible = False
        '
        'Time
        '
        Me.Time.Enabled = True
        Me.Time.Interval = 10
        '
        'scrolockon
        '
        Me.scrolockon.Image = Global.keynotifications.My.Resources.Resources._on
        Me.scrolockon.Location = New System.Drawing.Point(12, 98)
        Me.scrolockon.Name = "scrolockon"
        Me.scrolockon.Size = New System.Drawing.Size(19, 18)
        Me.scrolockon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.scrolockon.TabIndex = 8
        Me.scrolockon.TabStop = False
        Me.scrolockon.Visible = False
        '
        'scrolockoff
        '
        Me.scrolockoff.Image = Global.keynotifications.My.Resources.Resources.off
        Me.scrolockoff.Location = New System.Drawing.Point(12, 98)
        Me.scrolockoff.Name = "scrolockoff"
        Me.scrolockoff.Size = New System.Drawing.Size(19, 18)
        Me.scrolockoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.scrolockoff.TabIndex = 9
        Me.scrolockoff.TabStop = False
        Me.scrolockoff.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CAPS LOCK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "NUM LOCK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "SCROLL LOCK"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "key notifications"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'exitbtn
        '
        Me.exitbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbtn.Location = New System.Drawing.Point(52, 128)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(87, 23)
        Me.exitbtn.TabIndex = 14
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseVisualStyleBackColor = False
        '
        'notifications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(188, 163)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scrolockoff)
        Me.Controls.Add(Me.scrolockon)
        Me.Controls.Add(Me.capsoff)
        Me.Controls.Add(Me.numlockoff)
        Me.Controls.Add(Me.numlockon)
        Me.Controls.Add(Me.capson)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "notifications"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "notificatons"
        CType(Me.capsoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numlockoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numlockon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.capson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrolockon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrolockoff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents capson As System.Windows.Forms.PictureBox
    Friend WithEvents numlockon As System.Windows.Forms.PictureBox
    Friend WithEvents numlockoff As System.Windows.Forms.PictureBox
    Friend WithEvents capsoff As System.Windows.Forms.PictureBox
    Friend WithEvents Time As System.Windows.Forms.Timer
    Friend WithEvents scrolockon As System.Windows.Forms.PictureBox
    Friend WithEvents scrolockoff As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitbtn As System.Windows.Forms.Button

End Class
