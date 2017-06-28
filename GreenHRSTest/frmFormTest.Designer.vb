<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormTest))
        Me.grpFormSelection = New System.Windows.Forms.GroupBox
        Me.lblExamRollNo = New System.Windows.Forms.Label
        Me.lblSelectForm = New System.Windows.Forms.Label
        Me.txtExamRollNo = New System.Windows.Forms.TextBox
        Me.btnStartFormTest = New System.Windows.Forms.Button
        Me.comboFormList = New System.Windows.Forms.ComboBox
        Me.grpFormSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFormSelection
        '
        Me.grpFormSelection.Controls.Add(Me.lblExamRollNo)
        Me.grpFormSelection.Controls.Add(Me.lblSelectForm)
        Me.grpFormSelection.Controls.Add(Me.txtExamRollNo)
        Me.grpFormSelection.Controls.Add(Me.btnStartFormTest)
        Me.grpFormSelection.Controls.Add(Me.comboFormList)
        Me.grpFormSelection.Location = New System.Drawing.Point(7, 8)
        Me.grpFormSelection.Name = "grpFormSelection"
        Me.grpFormSelection.Size = New System.Drawing.Size(780, 160)
        Me.grpFormSelection.TabIndex = 0
        Me.grpFormSelection.TabStop = False
        Me.grpFormSelection.Text = "Form Selection"
        '
        'lblExamRollNo
        '
        Me.lblExamRollNo.AutoSize = True
        Me.lblExamRollNo.Location = New System.Drawing.Point(385, 65)
        Me.lblExamRollNo.Name = "lblExamRollNo"
        Me.lblExamRollNo.Size = New System.Drawing.Size(96, 13)
        Me.lblExamRollNo.TabIndex = 4
        Me.lblExamRollNo.Text = "Exam Roll No : "
        '
        'lblSelectForm
        '
        Me.lblSelectForm.AutoSize = True
        Me.lblSelectForm.Location = New System.Drawing.Point(32, 65)
        Me.lblSelectForm.Name = "lblSelectForm"
        Me.lblSelectForm.Size = New System.Drawing.Size(88, 13)
        Me.lblSelectForm.TabIndex = 3
        Me.lblSelectForm.Text = "Select Form : "
        '
        'txtExamRollNo
        '
        Me.txtExamRollNo.Location = New System.Drawing.Point(513, 60)
        Me.txtExamRollNo.Name = "txtExamRollNo"
        Me.txtExamRollNo.Size = New System.Drawing.Size(116, 21)
        Me.txtExamRollNo.TabIndex = 2
        '
        'btnStartFormTest
        '
        Me.btnStartFormTest.Location = New System.Drawing.Point(661, 60)
        Me.btnStartFormTest.Name = "btnStartFormTest"
        Me.btnStartFormTest.Size = New System.Drawing.Size(87, 23)
        Me.btnStartFormTest.TabIndex = 1
        Me.btnStartFormTest.Text = "Start Test"
        Me.btnStartFormTest.UseVisualStyleBackColor = True
        '
        'comboFormList
        '
        Me.comboFormList.FormattingEnabled = True
        Me.comboFormList.Location = New System.Drawing.Point(152, 62)
        Me.comboFormList.Name = "comboFormList"
        Me.comboFormList.Size = New System.Drawing.Size(201, 21)
        Me.comboFormList.TabIndex = 0
        '
        'frmFormTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 172)
        Me.Controls.Add(Me.grpFormSelection)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFormTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM SELECTION"
        Me.grpFormSelection.ResumeLayout(False)
        Me.grpFormSelection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpFormSelection As System.Windows.Forms.GroupBox
    Friend WithEvents btnStartFormTest As System.Windows.Forms.Button
    Friend WithEvents comboFormList As System.Windows.Forms.ComboBox
    Friend WithEvents txtExamRollNo As System.Windows.Forms.TextBox
    Friend WithEvents lblSelectForm As System.Windows.Forms.Label
    Friend WithEvents lblExamRollNo As System.Windows.Forms.Label
End Class
