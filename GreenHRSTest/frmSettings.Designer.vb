<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.comboDrives = New System.Windows.Forms.ComboBox
        Me.btnSetDefault = New System.Windows.Forms.Button
        Me.lblLocalPath = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comboDrives)
        Me.GroupBox1.Controls.Add(Me.btnSetDefault)
        Me.GroupBox1.Controls.Add(Me.lblLocalPath)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set Path"
        '
        'comboDrives
        '
        Me.comboDrives.FormattingEnabled = True
        Me.comboDrives.Location = New System.Drawing.Point(165, 40)
        Me.comboDrives.Name = "comboDrives"
        Me.comboDrives.Size = New System.Drawing.Size(121, 21)
        Me.comboDrives.TabIndex = 2
        '
        'btnSetDefault
        '
        Me.btnSetDefault.Location = New System.Drawing.Point(307, 38)
        Me.btnSetDefault.Name = "btnSetDefault"
        Me.btnSetDefault.Size = New System.Drawing.Size(103, 23)
        Me.btnSetDefault.TabIndex = 1
        Me.btnSetDefault.Text = "Set As Default"
        Me.btnSetDefault.UseVisualStyleBackColor = True
        '
        'lblLocalPath
        '
        Me.lblLocalPath.AutoSize = True
        Me.lblLocalPath.Location = New System.Drawing.Point(42, 40)
        Me.lblLocalPath.Name = "lblLocalPath"
        Me.lblLocalPath.Size = New System.Drawing.Size(107, 13)
        Me.lblLocalPath.TabIndex = 0
        Me.lblLocalPath.Text = "Local Voice File Path"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 140)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSettings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLocalPath As System.Windows.Forms.Label
    Friend WithEvents comboDrives As System.Windows.Forms.ComboBox
    Friend WithEvents btnSetDefault As System.Windows.Forms.Button
End Class
