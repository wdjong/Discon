<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistory))
        Me.txtHistory = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtHistory
        '
        Me.txtHistory.AcceptsReturn = True
        Me.txtHistory.BackColor = System.Drawing.SystemColors.Window
        Me.txtHistory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHistory.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistory.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHistory.Location = New System.Drawing.Point(0, 0)
        Me.txtHistory.MaxLength = 0
        Me.txtHistory.Multiline = True
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.ReadOnly = True
        Me.txtHistory.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtHistory.Size = New System.Drawing.Size(401, 461)
        Me.txtHistory.TabIndex = 1
        Me.txtHistory.WordWrap = False
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 461)
        Me.Controls.Add(Me.txtHistory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHistory"
        Me.Text = "History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents txtHistory As TextBox
End Class
