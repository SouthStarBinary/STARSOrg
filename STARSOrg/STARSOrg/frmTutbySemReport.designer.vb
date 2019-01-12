<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutbySemReport
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
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.dgvTutReport = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvTutReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCourse
        '
        Me.lblCourse.BackColor = System.Drawing.Color.White
        Me.lblCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(254, 26)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(210, 62)
        Me.lblCourse.TabIndex = 15
        Me.lblCourse.Text = "Course:"
        Me.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSemester
        '
        Me.lblSemester.BackColor = System.Drawing.Color.White
        Me.lblSemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(38, 26)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(210, 62)
        Me.lblSemester.TabIndex = 14
        Me.lblSemester.Text = "Semester:"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvTutReport
        '
        Me.dgvTutReport.AllowUserToResizeColumns = False
        Me.dgvTutReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTutReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTutReport.Location = New System.Drawing.Point(38, 104)
        Me.dgvTutReport.Name = "dgvTutReport"
        Me.dgvTutReport.RowTemplate.Height = 24
        Me.dgvTutReport.Size = New System.Drawing.Size(426, 371)
        Me.dgvTutReport.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(201, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 42)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTutbySemReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(502, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.dgvTutReport)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmTutbySemReport"
        Me.Text = "Tutor Report"
        CType(Me.dgvTutReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCourse As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents dgvTutReport As DataGridView
    Friend WithEvents Button1 As Button
End Class
