<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTypingTest
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTypingTest))
        Me.grpStorySelection = New System.Windows.Forms.GroupBox
        Me.btnStartTest = New System.Windows.Forms.Button
        Me.txtRollNo = New System.Windows.Forms.TextBox
        Me.comboStory = New System.Windows.Forms.ComboBox
        Me.lblSelectStory = New System.Windows.Forms.Label
        Me.grpStoryArea = New System.Windows.Forms.GroupBox
        Me.txtStory = New System.Windows.Forms.TextBox
        Me.grpTypingArea = New System.Windows.Forms.GroupBox
        Me.txtResponse = New System.Windows.Forms.TextBox
        Me.grpTimer = New System.Windows.Forms.GroupBox
        Me.lblTimeRemaining = New System.Windows.Forms.Label
        Me.timerTyping = New System.Windows.Forms.Timer(Me.components)
        Me.grpStorySelection.SuspendLayout()
        Me.grpStoryArea.SuspendLayout()
        Me.grpTypingArea.SuspendLayout()
        Me.grpTimer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStorySelection
        '
        Me.grpStorySelection.Controls.Add(Me.btnStartTest)
        Me.grpStorySelection.Controls.Add(Me.txtRollNo)
        Me.grpStorySelection.Controls.Add(Me.comboStory)
        Me.grpStorySelection.Controls.Add(Me.lblSelectStory)
        Me.grpStorySelection.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStorySelection.Location = New System.Drawing.Point(9, 3)
        Me.grpStorySelection.Name = "grpStorySelection"
        Me.grpStorySelection.Size = New System.Drawing.Size(762, 81)
        Me.grpStorySelection.TabIndex = 0
        Me.grpStorySelection.TabStop = False
        Me.grpStorySelection.Text = "Story Selection"
        '
        'btnStartTest
        '
        Me.btnStartTest.Location = New System.Drawing.Point(640, 31)
        Me.btnStartTest.Name = "btnStartTest"
        Me.btnStartTest.Size = New System.Drawing.Size(87, 23)
        Me.btnStartTest.TabIndex = 3
        Me.btnStartTest.Text = "Start Test"
        Me.btnStartTest.UseVisualStyleBackColor = True
        '
        'txtRollNo
        '
        Me.txtRollNo.Location = New System.Drawing.Point(497, 33)
        Me.txtRollNo.Name = "txtRollNo"
        Me.txtRollNo.Size = New System.Drawing.Size(100, 21)
        Me.txtRollNo.TabIndex = 2
        '
        'comboStory
        '
        Me.comboStory.FormattingEnabled = True
        Me.comboStory.Location = New System.Drawing.Point(106, 30)
        Me.comboStory.Name = "comboStory"
        Me.comboStory.Size = New System.Drawing.Size(350, 21)
        Me.comboStory.TabIndex = 1
        '
        'lblSelectStory
        '
        Me.lblSelectStory.AutoSize = True
        Me.lblSelectStory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectStory.Location = New System.Drawing.Point(8, 33)
        Me.lblSelectStory.Name = "lblSelectStory"
        Me.lblSelectStory.Size = New System.Drawing.Size(77, 13)
        Me.lblSelectStory.TabIndex = 0
        Me.lblSelectStory.Text = "Select Story"
        '
        'grpStoryArea
        '
        Me.grpStoryArea.Controls.Add(Me.txtStory)
        Me.grpStoryArea.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStoryArea.Location = New System.Drawing.Point(9, 85)
        Me.grpStoryArea.Name = "grpStoryArea"
        Me.grpStoryArea.Size = New System.Drawing.Size(944, 220)
        Me.grpStoryArea.TabIndex = 1
        Me.grpStoryArea.TabStop = False
        Me.grpStoryArea.Text = "Story Area"
        '
        'txtStory
        '
        Me.txtStory.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtStory.Enabled = False
        Me.txtStory.Font = New System.Drawing.Font("Verdana", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStory.Location = New System.Drawing.Point(11, 20)
        Me.txtStory.Multiline = True
        Me.txtStory.Name = "txtStory"
        Me.txtStory.Size = New System.Drawing.Size(927, 194)
        Me.txtStory.TabIndex = 0
        '
        'grpTypingArea
        '
        Me.grpTypingArea.Controls.Add(Me.txtResponse)
        Me.grpTypingArea.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTypingArea.Location = New System.Drawing.Point(9, 306)
        Me.grpTypingArea.Name = "grpTypingArea"
        Me.grpTypingArea.Size = New System.Drawing.Size(944, 224)
        Me.grpTypingArea.TabIndex = 2
        Me.grpTypingArea.TabStop = False
        Me.grpTypingArea.Text = "Typing Area"
        '
        'txtResponse
        '
        Me.txtResponse.Font = New System.Drawing.Font("Verdana", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponse.Location = New System.Drawing.Point(9, 15)
        Me.txtResponse.Multiline = True
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.Size = New System.Drawing.Size(927, 202)
        Me.txtResponse.TabIndex = 1
        '
        'grpTimer
        '
        Me.grpTimer.Controls.Add(Me.lblTimeRemaining)
        Me.grpTimer.Location = New System.Drawing.Point(778, 3)
        Me.grpTimer.Name = "grpTimer"
        Me.grpTimer.Size = New System.Drawing.Size(175, 81)
        Me.grpTimer.TabIndex = 3
        Me.grpTimer.TabStop = False
        Me.grpTimer.Text = "Timer"
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.AutoSize = True
        Me.lblTimeRemaining.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemaining.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblTimeRemaining.Location = New System.Drawing.Point(34, 30)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(102, 32)
        Me.lblTimeRemaining.TabIndex = 0
        Me.lblTimeRemaining.Text = "Timer"
        Me.lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerTyping
        '
        Me.timerTyping.Interval = 1000
        '
        'frmTypingTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 535)
        Me.Controls.Add(Me.grpTimer)
        Me.Controls.Add(Me.grpTypingArea)
        Me.Controls.Add(Me.grpStoryArea)
        Me.Controls.Add(Me.grpStorySelection)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTypingTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Typing Test"
        Me.grpStorySelection.ResumeLayout(False)
        Me.grpStorySelection.PerformLayout()
        Me.grpStoryArea.ResumeLayout(False)
        Me.grpStoryArea.PerformLayout()
        Me.grpTypingArea.ResumeLayout(False)
        Me.grpTypingArea.PerformLayout()
        Me.grpTimer.ResumeLayout(False)
        Me.grpTimer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpStorySelection As System.Windows.Forms.GroupBox
    Friend WithEvents grpStoryArea As System.Windows.Forms.GroupBox
    Friend WithEvents grpTypingArea As System.Windows.Forms.GroupBox
    Friend WithEvents grpTimer As System.Windows.Forms.GroupBox
    Friend WithEvents btnStartTest As System.Windows.Forms.Button
    Friend WithEvents txtRollNo As System.Windows.Forms.TextBox
    Friend WithEvents comboStory As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectStory As System.Windows.Forms.Label
    Friend WithEvents lblTimeRemaining As System.Windows.Forms.Label
    Friend WithEvents timerTyping As System.Windows.Forms.Timer
    Friend WithEvents txtStory As System.Windows.Forms.TextBox
    Friend WithEvents txtResponse As System.Windows.Forms.TextBox
End Class
