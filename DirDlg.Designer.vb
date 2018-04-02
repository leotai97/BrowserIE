<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirDlg
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
    Me.btnDir = New System.Windows.Forms.Button()
    Me.txtDir = New System.Windows.Forms.TextBox()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'btnDir
    '
    Me.btnDir.Location = New System.Drawing.Point(499, 22)
    Me.btnDir.Name = "btnDir"
    Me.btnDir.Size = New System.Drawing.Size(21, 17)
    Me.btnDir.TabIndex = 4
    Me.btnDir.UseVisualStyleBackColor = True
    '
    'txtDir
    '
    Me.txtDir.Location = New System.Drawing.Point(6, 21)
    Me.txtDir.Name = "txtDir"
    Me.txtDir.Size = New System.Drawing.Size(487, 20)
    Me.txtDir.TabIndex = 5
    '
    'btnOK
    '
    Me.btnOK.Location = New System.Drawing.Point(544, 12)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(75, 23)
    Me.btnOK.TabIndex = 6
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = True
    '
    'btnCancel
    '
    Me.btnCancel.Location = New System.Drawing.Point(544, 41)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
    Me.btnCancel.TabIndex = 7
    Me.btnCancel.Text = "Cancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'DirDlg
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(631, 92)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.txtDir)
    Me.Controls.Add(Me.btnDir)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "DirDlg"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Set Working Directory Path"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents btnDir As Button
  Friend WithEvents txtDir As TextBox
  Friend WithEvents btnOK As Button
  Friend WithEvents btnCancel As Button
End Class
