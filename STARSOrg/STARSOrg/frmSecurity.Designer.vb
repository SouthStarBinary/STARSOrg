<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSecurity
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mskUser = New System.Windows.Forms.MaskedTextBox()
        Me.mskPass = New System.Windows.Forms.MaskedTextBox()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblPassChange = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuestLogin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mskUser
        '
        Me.mskUser.Location = New System.Drawing.Point(310, 329)
        Me.mskUser.Name = "mskUser"
        Me.mskUser.Size = New System.Drawing.Size(180, 20)
        Me.mskUser.TabIndex = 0
        Me.mskUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mskPass
        '
        Me.mskPass.Location = New System.Drawing.Point(310, 385)
        Me.mskPass.Name = "mskPass"
        Me.mskPass.Size = New System.Drawing.Size(180, 20)
        Me.mskPass.TabIndex = 1
        Me.mskPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskPass.UseSystemPasswordChar = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(346, 422)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(108, 43)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblPassChange
        '
        Me.lblPassChange.AutoSize = True
        Me.lblPassChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPassChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassChange.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblPassChange.Location = New System.Drawing.Point(12, 452)
        Me.lblPassChange.Name = "lblPassChange"
        Me.lblPassChange.Size = New System.Drawing.Size(119, 13)
        Me.lblPassChange.TabIndex = 4
        Me.lblPassChange.Text = "Change Password Here"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STARSOrg.My.Resources.Resources.STARS_National_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(253, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 278)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "User"
        '
        'btnGuestLogin
        '
        Me.btnGuestLogin.Location = New System.Drawing.Point(713, 452)
        Me.btnGuestLogin.Name = "btnGuestLogin"
        Me.btnGuestLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnGuestLogin.TabIndex = 11
        Me.btnGuestLogin.Text = "Guest Login"
        Me.btnGuestLogin.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(585, 452)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnGuestLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPassChange)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mskPass)
        Me.Controls.Add(Me.mskUser)
        Me.DoubleBuffered = True
        Me.Name = "frmSecurity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents lblPassChange As Label
    Friend WithEvents mskUser As MaskedTextBox
    Friend WithEvents mskPass As MaskedTextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuestLogin As Button
    Friend WithEvents btnClose As Button
End Class
