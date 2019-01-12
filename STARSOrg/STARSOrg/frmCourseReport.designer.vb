<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourseReport
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
        Me.btnCourseClose = New System.Windows.Forms.Button()
        Me.dgrCourses = New System.Windows.Forms.DataGridView()
        CType(Me.dgrCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCourseClose
        '
        Me.btnCourseClose.Location = New System.Drawing.Point(242, 316)
        Me.btnCourseClose.Name = "btnCourseClose"
        Me.btnCourseClose.Size = New System.Drawing.Size(100, 25)
        Me.btnCourseClose.TabIndex = 0
        Me.btnCourseClose.Text = "Close"
        Me.btnCourseClose.UseVisualStyleBackColor = True
        '
        'dgrCourses
        '
        Me.dgrCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrCourses.Location = New System.Drawing.Point(42, 19)
        Me.dgrCourses.Name = "dgrCourses"
        Me.dgrCourses.Size = New System.Drawing.Size(500, 275)
        Me.dgrCourses.TabIndex = 1
        '
        'frmCourseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgrCourses)
        Me.Controls.Add(Me.btnCourseClose)
        Me.Name = "frmCourseReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Course Report"
        CType(Me.dgrCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCourseClose As Button
    Friend WithEvents dgrCourses As DataGridView
End Class
