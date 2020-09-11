<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferences
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreferences))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkPlayer1 = New System.Windows.Forms.CheckBox()
        Me.chkPlayer2 = New System.Windows.Forms.CheckBox()
        Me.chkPlayer3 = New System.Windows.Forms.CheckBox()
        Me.chkPlayer4 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.AccessibleDescription = "Saves the preferences"
        Me.btnOK.Location = New System.Drawing.Point(47, 174)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(141, 174)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkPlayer1
        '
        Me.chkPlayer1.AutoSize = True
        Me.chkPlayer1.Location = New System.Drawing.Point(47, 60)
        Me.chkPlayer1.Name = "chkPlayer1"
        Me.chkPlayer1.Size = New System.Drawing.Size(99, 17)
        Me.chkPlayer1.TabIndex = 3
        Me.chkPlayer1.Text = "Player 1 human"
        Me.chkPlayer1.UseVisualStyleBackColor = True
        '
        'chkPlayer2
        '
        Me.chkPlayer2.AutoSize = True
        Me.chkPlayer2.Location = New System.Drawing.Point(47, 83)
        Me.chkPlayer2.Name = "chkPlayer2"
        Me.chkPlayer2.Size = New System.Drawing.Size(99, 17)
        Me.chkPlayer2.TabIndex = 4
        Me.chkPlayer2.Text = "Player 2 human"
        Me.chkPlayer2.UseVisualStyleBackColor = True
        '
        'chkPlayer3
        '
        Me.chkPlayer3.AutoSize = True
        Me.chkPlayer3.Location = New System.Drawing.Point(47, 106)
        Me.chkPlayer3.Name = "chkPlayer3"
        Me.chkPlayer3.Size = New System.Drawing.Size(99, 17)
        Me.chkPlayer3.TabIndex = 5
        Me.chkPlayer3.Text = "Player 3 human"
        Me.chkPlayer3.UseVisualStyleBackColor = True
        '
        'chkPlayer4
        '
        Me.chkPlayer4.AutoSize = True
        Me.chkPlayer4.Location = New System.Drawing.Point(47, 129)
        Me.chkPlayer4.Name = "chkPlayer4"
        Me.chkPlayer4.Size = New System.Drawing.Size(99, 17)
        Me.chkPlayer4.TabIndex = 6
        Me.chkPlayer4.Text = "Player 4 human"
        Me.chkPlayer4.UseVisualStyleBackColor = True
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 216)
        Me.Controls.Add(Me.chkPlayer4)
        Me.Controls.Add(Me.chkPlayer3)
        Me.Controls.Add(Me.chkPlayer2)
        Me.Controls.Add(Me.chkPlayer1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreferences"
        Me.Text = "Preferences"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkPlayer1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlayer2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlayer3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlayer4 As System.Windows.Forms.CheckBox
End Class
