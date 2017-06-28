<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomePage
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
        Me.grpMsgForCandidates = New System.Windows.Forms.GroupBox
        Me.grdCandidatesMsg = New System.Windows.Forms.DataGridView
        Me.grpQuery = New System.Windows.Forms.GroupBox
        Me.grdQueryFeedback = New System.Windows.Forms.DataGridView
        Me.grpMsgForCandidates.SuspendLayout()
        CType(Me.grdCandidatesMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQuery.SuspendLayout()
        CType(Me.grdQueryFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMsgForCandidates
        '
        Me.grpMsgForCandidates.Controls.Add(Me.grdCandidatesMsg)
        Me.grpMsgForCandidates.Location = New System.Drawing.Point(12, 12)
        Me.grpMsgForCandidates.Name = "grpMsgForCandidates"
        Me.grpMsgForCandidates.Size = New System.Drawing.Size(788, 302)
        Me.grpMsgForCandidates.TabIndex = 0
        Me.grpMsgForCandidates.TabStop = False
        Me.grpMsgForCandidates.Text = "Message For Candidates"
        '
        'grdCandidatesMsg
        '
        Me.grdCandidatesMsg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCandidatesMsg.Location = New System.Drawing.Point(7, 20)
        Me.grdCandidatesMsg.Name = "grdCandidatesMsg"
        Me.grdCandidatesMsg.Size = New System.Drawing.Size(775, 276)
        Me.grdCandidatesMsg.TabIndex = 0
        '
        'grpQuery
        '
        Me.grpQuery.Controls.Add(Me.grdQueryFeedback)
        Me.grpQuery.Location = New System.Drawing.Point(13, 322)
        Me.grpQuery.Name = "grpQuery"
        Me.grpQuery.Size = New System.Drawing.Size(788, 283)
        Me.grpQuery.TabIndex = 1
        Me.grpQuery.TabStop = False
        Me.grpQuery.Text = "Your query : Our feedback"
        '
        'grdQueryFeedback
        '
        Me.grdQueryFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdQueryFeedback.Location = New System.Drawing.Point(7, 20)
        Me.grdQueryFeedback.Name = "grdQueryFeedback"
        Me.grdQueryFeedback.Size = New System.Drawing.Size(775, 256)
        Me.grdQueryFeedback.TabIndex = 0
        '
        'frmHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 610)
        Me.Controls.Add(Me.grpQuery)
        Me.Controls.Add(Me.grpMsgForCandidates)
        Me.Name = "frmHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.grpMsgForCandidates.ResumeLayout(False)
        CType(Me.grdCandidatesMsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQuery.ResumeLayout(False)
        CType(Me.grdQueryFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMsgForCandidates As System.Windows.Forms.GroupBox
    Friend WithEvents grpQuery As System.Windows.Forms.GroupBox
    Friend WithEvents grdQueryFeedback As System.Windows.Forms.DataGridView
    Friend WithEvents grdCandidatesMsg As System.Windows.Forms.DataGridView
End Class
