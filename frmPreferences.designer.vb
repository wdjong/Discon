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
        Me.rbP1Human = New System.Windows.Forms.RadioButton()
        Me.rbP1Comp = New System.Windows.Forms.RadioButton()
        Me.rbP1None = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbP4None = New System.Windows.Forms.RadioButton()
        Me.rbP4Comp = New System.Windows.Forms.RadioButton()
        Me.rbP4Human = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbP3None = New System.Windows.Forms.RadioButton()
        Me.rbP3Comp = New System.Windows.Forms.RadioButton()
        Me.rbP3Human = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbP2Human = New System.Windows.Forms.RadioButton()
        Me.rbP2Comp = New System.Windows.Forms.RadioButton()
        Me.rbP2None = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.AccessibleDescription = "Saves the preferences"
        Me.btnOK.Location = New System.Drawing.Point(59, 202)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(164, 202)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'rbP1Human
        '
        Me.rbP1Human.AutoSize = True
        Me.rbP1Human.Location = New System.Drawing.Point(17, 13)
        Me.rbP1Human.Name = "rbP1Human"
        Me.rbP1Human.Size = New System.Drawing.Size(14, 13)
        Me.rbP1Human.TabIndex = 7
        Me.rbP1Human.TabStop = True
        Me.rbP1Human.UseVisualStyleBackColor = True
        '
        'rbP1Comp
        '
        Me.rbP1Comp.AutoSize = True
        Me.rbP1Comp.Location = New System.Drawing.Point(73, 13)
        Me.rbP1Comp.Name = "rbP1Comp"
        Me.rbP1Comp.Size = New System.Drawing.Size(14, 13)
        Me.rbP1Comp.TabIndex = 8
        Me.rbP1Comp.TabStop = True
        Me.rbP1Comp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbP1Comp.UseVisualStyleBackColor = True
        '
        'rbP1None
        '
        Me.rbP1None.AutoSize = True
        Me.rbP1None.Location = New System.Drawing.Point(131, 13)
        Me.rbP1None.Name = "rbP1None"
        Me.rbP1None.Size = New System.Drawing.Size(14, 13)
        Me.rbP1None.TabIndex = 9
        Me.rbP1None.TabStop = True
        Me.rbP1None.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Human"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Computer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Not playing"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Player 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Player 4"
        '
        'rbP4None
        '
        Me.rbP4None.AutoSize = True
        Me.rbP4None.Location = New System.Drawing.Point(131, 16)
        Me.rbP4None.Name = "rbP4None"
        Me.rbP4None.Size = New System.Drawing.Size(14, 13)
        Me.rbP4None.TabIndex = 16
        Me.rbP4None.TabStop = True
        Me.rbP4None.UseVisualStyleBackColor = True
        '
        'rbP4Comp
        '
        Me.rbP4Comp.AutoSize = True
        Me.rbP4Comp.Location = New System.Drawing.Point(73, 16)
        Me.rbP4Comp.Name = "rbP4Comp"
        Me.rbP4Comp.Size = New System.Drawing.Size(14, 13)
        Me.rbP4Comp.TabIndex = 15
        Me.rbP4Comp.TabStop = True
        Me.rbP4Comp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbP4Comp.UseVisualStyleBackColor = True
        '
        'rbP4Human
        '
        Me.rbP4Human.AutoSize = True
        Me.rbP4Human.Location = New System.Drawing.Point(17, 16)
        Me.rbP4Human.Name = "rbP4Human"
        Me.rbP4Human.Size = New System.Drawing.Size(14, 13)
        Me.rbP4Human.TabIndex = 14
        Me.rbP4Human.TabStop = True
        Me.rbP4Human.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Player 3"
        '
        'rbP3None
        '
        Me.rbP3None.AutoSize = True
        Me.rbP3None.Location = New System.Drawing.Point(131, 14)
        Me.rbP3None.Name = "rbP3None"
        Me.rbP3None.Size = New System.Drawing.Size(14, 13)
        Me.rbP3None.TabIndex = 20
        Me.rbP3None.TabStop = True
        Me.rbP3None.UseVisualStyleBackColor = True
        '
        'rbP3Comp
        '
        Me.rbP3Comp.AutoSize = True
        Me.rbP3Comp.Location = New System.Drawing.Point(73, 14)
        Me.rbP3Comp.Name = "rbP3Comp"
        Me.rbP3Comp.Size = New System.Drawing.Size(14, 13)
        Me.rbP3Comp.TabIndex = 19
        Me.rbP3Comp.TabStop = True
        Me.rbP3Comp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbP3Comp.UseVisualStyleBackColor = True
        '
        'rbP3Human
        '
        Me.rbP3Human.AutoSize = True
        Me.rbP3Human.Location = New System.Drawing.Point(17, 14)
        Me.rbP3Human.Name = "rbP3Human"
        Me.rbP3Human.Size = New System.Drawing.Size(14, 13)
        Me.rbP3Human.TabIndex = 18
        Me.rbP3Human.TabStop = True
        Me.rbP3Human.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Player 2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbP1None)
        Me.GroupBox1.Controls.Add(Me.rbP1Comp)
        Me.GroupBox1.Controls.Add(Me.rbP1Human)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 39)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'rbP2Human
        '
        Me.rbP2Human.AutoSize = True
        Me.rbP2Human.Location = New System.Drawing.Point(16, 13)
        Me.rbP2Human.Name = "rbP2Human"
        Me.rbP2Human.Size = New System.Drawing.Size(14, 13)
        Me.rbP2Human.TabIndex = 22
        Me.rbP2Human.TabStop = True
        Me.rbP2Human.UseVisualStyleBackColor = True
        '
        'rbP2Comp
        '
        Me.rbP2Comp.AutoSize = True
        Me.rbP2Comp.Location = New System.Drawing.Point(72, 13)
        Me.rbP2Comp.Name = "rbP2Comp"
        Me.rbP2Comp.Size = New System.Drawing.Size(14, 13)
        Me.rbP2Comp.TabIndex = 23
        Me.rbP2Comp.TabStop = True
        Me.rbP2Comp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbP2Comp.UseVisualStyleBackColor = True
        '
        'rbP2None
        '
        Me.rbP2None.AutoSize = True
        Me.rbP2None.Location = New System.Drawing.Point(130, 13)
        Me.rbP2None.Name = "rbP2None"
        Me.rbP2None.Size = New System.Drawing.Size(14, 13)
        Me.rbP2None.TabIndex = 24
        Me.rbP2None.TabStop = True
        Me.rbP2None.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbP2None)
        Me.GroupBox2.Controls.Add(Me.rbP2Comp)
        Me.GroupBox2.Controls.Add(Me.rbP2Human)
        Me.GroupBox2.Location = New System.Drawing.Point(60, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 35)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbP3None)
        Me.GroupBox3.Controls.Add(Me.rbP3Comp)
        Me.GroupBox3.Controls.Add(Me.rbP3Human)
        Me.GroupBox3.Location = New System.Drawing.Point(59, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 36)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbP4None)
        Me.GroupBox4.Controls.Add(Me.rbP4Comp)
        Me.GroupBox4.Controls.Add(Me.rbP4Human)
        Me.GroupBox4.Location = New System.Drawing.Point(59, 134)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(189, 40)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 237)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreferences"
        Me.Text = "Preferences"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents rbP1Human As RadioButton
    Friend WithEvents rbP1Comp As RadioButton
    Friend WithEvents rbP1None As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbP4None As RadioButton
    Friend WithEvents rbP4Comp As RadioButton
    Friend WithEvents rbP4Human As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents rbP3None As RadioButton
    Friend WithEvents rbP3Comp As RadioButton
    Friend WithEvents rbP3Human As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbP2Human As RadioButton
    Friend WithEvents rbP2Comp As RadioButton
    Friend WithEvents rbP2None As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
