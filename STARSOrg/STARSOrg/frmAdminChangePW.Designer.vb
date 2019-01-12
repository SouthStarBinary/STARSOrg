<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminChangePW
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.mskConfirmPass = New System.Windows.Forms.MaskedTextBox()
        Me.mskNewPass = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Confirmed Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "New Password"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(164, 180)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'mskConfirmPass
        '
        Me.mskConfirmPass.Location = New System.Drawing.Point(66, 154)
        Me.mskConfirmPass.Name = "mskConfirmPass"
        Me.mskConfirmPass.Size = New System.Drawing.Size(173, 20)
        Me.mskConfirmPass.TabIndex = 12
        Me.mskConfirmPass.UseSystemPasswordChar = True
        '
        'mskNewPass
        '
        Me.mskNewPass.Location = New System.Drawing.Point(66, 112)
        Me.mskNewPass.Name = "mskNewPass"
        Me.mskNewPass.Size = New System.Drawing.Size(173, 20)
        Me.mskNewPass.TabIndex = 11
        Me.mskNewPass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Changing password for user:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.Control
        Me.lblUser.Location = New System.Drawing.Point(175, 42)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(28, 13)
        Me.lblUser.TabIndex = 17
        Me.lblUser.Text = "       "
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmAdminChangePW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 272)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.mskConfirmPass)
        Me.Controls.Add(Me.mskNewPass)
        Me.Name = "frmAdminChangePW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change password for user"
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents mskConfirmPass As MaskedTextBox
    Friend WithEvents mskNewPass As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents errP As ErrorProvider
End Class
