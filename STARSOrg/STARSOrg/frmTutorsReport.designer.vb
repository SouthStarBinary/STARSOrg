<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutorsReport
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvTutReport = New System.Windows.Forms.DataGridView()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblTutor = New System.Windows.Forms.Label()
        CType(Me.dgvTutReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvTutReport
        '
        Me.dgvTutReport.AllowUserToResizeColumns = False
        Me.dgvTutReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTutReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTutReport.Location = New System.Drawing.Point(35, 113)
        Me.dgvTutReport.Name = "dgvTutReport"
        Me.dgvTutReport.RowTemplate.Height = 24
        Me.dgvTutReport.Size = New System.Drawing.Size(426, 371)
        Me.dgvTutReport.TabIndex = 1
        '
        'lblSemester
        '
        Me.lblSemester.BackColor = System.Drawing.Color.White
        Me.lblSemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(251, 35)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(210, 62)
        Me.lblSemester.TabIndex = 11
        Me.lblSemester.Text = "Semester:"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTutor
        '
        Me.lblTutor.BackColor = System.Drawing.Color.White
        Me.lblTutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTutor.Location = New System.Drawing.Point(35, 35)
        Me.lblTutor.Name = "lblTutor"
        Me.lblTutor.Size = New System.Drawing.Size(210, 62)
        Me.lblTutor.TabIndex = 10
        Me.lblTutor.Text = "Tutor:"
        Me.lblTutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTutorsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(502, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblTutor)
        Me.Controls.Add(Me.dgvTutReport)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmTutorsReport"
        Me.Text = "Tutors Report"
        CType(Me.dgvTutReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents dgvTutReport As DataGridView
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblTutor As Label
End Class
