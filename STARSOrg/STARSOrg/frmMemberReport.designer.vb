<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberReport
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
        Me.rpvMemReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rpvMemReport
        '
        Me.rpvMemReport.LocalReport.ReportEmbeddedResource = "STARSOrg.rptMembers.rdlc"
        Me.rpvMemReport.Location = New System.Drawing.Point(28, 22)
        Me.rpvMemReport.Name = "rpvMemReport"
        Me.rpvMemReport.ServerReport.BearerToken = Nothing
        Me.rpvMemReport.Size = New System.Drawing.Size(724, 444)
        Me.rpvMemReport.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(629, 472)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(123, 35)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMemberReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 519)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rpvMemReport)
        Me.Name = "frmMemberReport"
        Me.Text = "frmMemberReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpvMemReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnClose As Button
End Class
