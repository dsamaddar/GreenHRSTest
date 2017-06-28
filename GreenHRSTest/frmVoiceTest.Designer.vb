<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoiceTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoiceTest))
        Me.grpCaptureVoice = New System.Windows.Forms.GroupBox
        Me.lblTimer = New System.Windows.Forms.Label
        Me.btnPlay = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnRecord = New System.Windows.Forms.Button
        Me.grpCapturedVoice = New System.Windows.Forms.GroupBox
        Me.grdVoiceList = New System.Windows.Forms.DataGridView
        Me.timerVoice = New System.Windows.Forms.Timer(Me.components)
        Me.txtStory = New System.Windows.Forms.TextBox
        Me.grpStorySelection = New System.Windows.Forms.GroupBox
        Me.btnStartTest = New System.Windows.Forms.Button
        Me.txtRollNo = New System.Windows.Forms.TextBox
        Me.comboStory = New System.Windows.Forms.ComboBox
        Me.lblSelectStory = New System.Windows.Forms.Label
        Me.grpCaptureVoice.SuspendLayout()
        Me.grpCapturedVoice.SuspendLayout()
        CType(Me.grdVoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStorySelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCaptureVoice
        '
        Me.grpCaptureVoice.Controls.Add(Me.lblTimer)
        Me.grpCaptureVoice.Controls.Add(Me.btnPlay)
        Me.grpCaptureVoice.Controls.Add(Me.btnSave)
        Me.grpCaptureVoice.Controls.Add(Me.btnRecord)
        Me.grpCaptureVoice.Location = New System.Drawing.Point(2, 323)
        Me.grpCaptureVoice.Name = "grpCaptureVoice"
        Me.grpCaptureVoice.Size = New System.Drawing.Size(1044, 142)
        Me.grpCaptureVoice.TabIndex = 0
        Me.grpCaptureVoice.TabStop = False
        Me.grpCaptureVoice.Text = "Capture Voice"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Verdana", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Green
        Me.lblTimer.Location = New System.Drawing.Point(305, 16)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(198, 20)
        Me.lblTimer.TabIndex = 3
        Me.lblTimer.Text = "Recorded Time : 0 s"
        '
        'btnPlay
        '
        Me.btnPlay.BackgroundImage = Global.GreenHRSTest.My.Resources.Resources.imgSaveAudio
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlay.Location = New System.Drawing.Point(605, 48)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(80, 80)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Location = New System.Drawing.Point(458, 48)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 80)
        Me.btnSave.TabIndex = 1
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRecord
        '
        Me.btnRecord.AutoSize = True
        Me.btnRecord.BackgroundImage = Global.GreenHRSTest.My.Resources.Resources.imgStartRecording
        Me.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRecord.Location = New System.Drawing.Point(308, 51)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(80, 80)
        Me.btnRecord.TabIndex = 0
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'grpCapturedVoice
        '
        Me.grpCapturedVoice.Controls.Add(Me.grdVoiceList)
        Me.grpCapturedVoice.Location = New System.Drawing.Point(2, 465)
        Me.grpCapturedVoice.Name = "grpCapturedVoice"
        Me.grpCapturedVoice.Size = New System.Drawing.Size(1044, 175)
        Me.grpCapturedVoice.TabIndex = 1
        Me.grpCapturedVoice.TabStop = False
        Me.grpCapturedVoice.Text = "Captured Voice"
        '
        'grdVoiceList
        '
        Me.grdVoiceList.AllowUserToAddRows = False
        Me.grdVoiceList.AllowUserToDeleteRows = False
        Me.grdVoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdVoiceList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdVoiceList.Location = New System.Drawing.Point(3, 16)
        Me.grdVoiceList.Name = "grdVoiceList"
        Me.grdVoiceList.ReadOnly = True
        Me.grdVoiceList.Size = New System.Drawing.Size(1038, 156)
        Me.grdVoiceList.TabIndex = 0
        '
        'timerVoice
        '
        Me.timerVoice.Interval = 1000
        '
        'txtStory
        '
        Me.txtStory.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtStory.Enabled = False
        Me.txtStory.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStory.Location = New System.Drawing.Point(2, 60)
        Me.txtStory.Multiline = True
        Me.txtStory.Name = "txtStory"
        Me.txtStory.Size = New System.Drawing.Size(1044, 257)
        Me.txtStory.TabIndex = 2
        '
        'grpStorySelection
        '
        Me.grpStorySelection.Controls.Add(Me.btnStartTest)
        Me.grpStorySelection.Controls.Add(Me.txtRollNo)
        Me.grpStorySelection.Controls.Add(Me.comboStory)
        Me.grpStorySelection.Controls.Add(Me.lblSelectStory)
        Me.grpStorySelection.Location = New System.Drawing.Point(2, 3)
        Me.grpStorySelection.Name = "grpStorySelection"
        Me.grpStorySelection.Size = New System.Drawing.Size(1044, 53)
        Me.grpStorySelection.TabIndex = 3
        Me.grpStorySelection.TabStop = False
        Me.grpStorySelection.Text = "Story Selection"
        '
        'btnStartTest
        '
        Me.btnStartTest.Location = New System.Drawing.Point(732, 19)
        Me.btnStartTest.Name = "btnStartTest"
        Me.btnStartTest.Size = New System.Drawing.Size(168, 23)
        Me.btnStartTest.TabIndex = 4
        Me.btnStartTest.Text = "Start Test"
        Me.btnStartTest.UseVisualStyleBackColor = True
        '
        'txtRollNo
        '
        Me.txtRollNo.Location = New System.Drawing.Point(569, 22)
        Me.txtRollNo.Name = "txtRollNo"
        Me.txtRollNo.Size = New System.Drawing.Size(129, 20)
        Me.txtRollNo.TabIndex = 3
        '
        'comboStory
        '
        Me.comboStory.FormattingEnabled = True
        Me.comboStory.Location = New System.Drawing.Point(139, 22)
        Me.comboStory.Name = "comboStory"
        Me.comboStory.Size = New System.Drawing.Size(350, 21)
        Me.comboStory.TabIndex = 2
        '
        'lblSelectStory
        '
        Me.lblSelectStory.AutoSize = True
        Me.lblSelectStory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectStory.Location = New System.Drawing.Point(44, 25)
        Me.lblSelectStory.Name = "lblSelectStory"
        Me.lblSelectStory.Size = New System.Drawing.Size(77, 13)
        Me.lblSelectStory.TabIndex = 1
        Me.lblSelectStory.Text = "Select Story"
        '
        'frmVoiceTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 642)
        Me.Controls.Add(Me.grpStorySelection)
        Me.Controls.Add(Me.txtStory)
        Me.Controls.Add(Me.grpCapturedVoice)
        Me.Controls.Add(Me.grpCaptureVoice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVoiceTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voice Test"
        Me.grpCaptureVoice.ResumeLayout(False)
        Me.grpCaptureVoice.PerformLayout()
        Me.grpCapturedVoice.ResumeLayout(False)
        CType(Me.grdVoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStorySelection.ResumeLayout(False)
        Me.grpStorySelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCaptureVoice As System.Windows.Forms.GroupBox
    Friend WithEvents grpCapturedVoice As System.Windows.Forms.GroupBox
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents grdVoiceList As System.Windows.Forms.DataGridView
    Friend WithEvents timerVoice As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents txtStory As System.Windows.Forms.TextBox
    Friend WithEvents grpStorySelection As System.Windows.Forms.GroupBox
    Friend WithEvents lblSelectStory As System.Windows.Forms.Label
    Friend WithEvents comboStory As System.Windows.Forms.ComboBox
    Friend WithEvents txtRollNo As System.Windows.Forms.TextBox
    Friend WithEvents btnStartTest As System.Windows.Forms.Button
End Class
