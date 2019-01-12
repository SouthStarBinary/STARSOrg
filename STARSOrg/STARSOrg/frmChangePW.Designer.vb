<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePW
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
        Me.mskUser = New System.Windows.Forms.MaskedTextBox()
        Me.mskPass = New System.Windows.Forms.MaskedTextBox()
        Me.mskNewPass = New System.Windows.Forms.MaskedTextBox()
        Me.mskConfirmPass = New System.Windows.Forms.MaskedTextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mskUser
        '
        Me.mskUser.Location = New System.Drawing.Point(134, 110)
        Me.mskUser.Name = "mskUser"
        Me.mskUser.Size = New System.Drawing.Size(173, 20)
        Me.mskUser.TabIndex = 0
        '
        'mskPass
        '
        Me.mskPass.Location = New System.Drawing.Point(134, 155)
        Me.mskPass.Name = "mskPass"
        Me.mskPass.Size = New System.Drawing.Size(173, 20)
        Me.mskPass.TabIndex = 1
        Me.mskPass.UseSystemPasswordChar = True
        '
        'mskNewPass
        '
        Me.mskNewPass.Enabled = False
        Me.mskNewPass.Location = New System.Drawing.Point(134, 259)
        Me.mskNewPass.Name = "mskNewPass"
        Me.mskNewPass.Size = New System.Drawing.Size(173, 20)
        Me.mskNewPass.TabIndex = 2
        Me.mskNewPass.UseSystemPasswordChar = True
        '
        'mskConfirmPass
        '
        Me.mskConfirmPass.Enabled = False
        Me.mskConfirmPass.Location = New System.Drawing.Point(134, 301)
        Me.mskConfirmPass.Name = "mskConfirmPass"
        Me.mskConfirmPass.Size = New System.Drawing.Size(173, 20)
        Me.mskConfirmPass.TabIndex = 3
        Me.mskConfirmPass.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(231, 182)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(350, 359)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 36)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Location = New System.Drawing.Point(232, 327)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Confirmed Password"
        '
        'frmChangePW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 407)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.mskConfirmPass)
        Me.Controls.Add(Me.mskNewPass)
        Me.Controls.Add(Me.mskPass)
        Me.Controls.Add(Me.mskUser)
        Me.Name = "frmChangePW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mskUser As MaskedTextBox
    Friend WithEvents mskPass As MaskedTextBox
    Friend WithEvents mskNewPass As MaskedTextBox
    Friend WithEvents mskConfirmPass As MaskedTextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
