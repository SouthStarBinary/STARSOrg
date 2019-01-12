<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterReport
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
        Me.dgrSemesters = New System.Windows.Forms.DataGridView()
        Me.btnSemClose = New System.Windows.Forms.Button()
        CType(Me.dgrSemesters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgrSemesters
        '
        Me.dgrSemesters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrSemesters.Location = New System.Drawing.Point(42, 19)
        Me.dgrSemesters.Name = "dgrSemesters"
        Me.dgrSemesters.Size = New System.Drawing.Size(500, 275)
        Me.dgrSemesters.TabIndex = 3
        '
        'btnSemClose
        '
        Me.btnSemClose.Location = New System.Drawing.Point(242, 316)
        Me.btnSemClose.Name = "btnSemClose"
        Me.btnSemClose.Size = New System.Drawing.Size(100, 25)
        Me.btnSemClose.TabIndex = 2
        Me.btnSemClose.Text = "Close"
        Me.btnSemClose.UseVisualStyleBackColor = True
        '
        'frmSemesterReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgrSemesters)
        Me.Controls.Add(Me.btnSemClose)
        Me.Name = "frmSemesterReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Semester Report"
        CType(Me.dgrSemesters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgrSemesters As DataGridView
    Friend WithEvents btnSemClose As Button
End Class
