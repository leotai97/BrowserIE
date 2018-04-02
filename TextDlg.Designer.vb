<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextDlg
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
    Me.listText = New System.Windows.Forms.ListView()
    Me.txtResult = New System.Windows.Forms.TextBox()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'listText
    '
    Me.listText.Location = New System.Drawing.Point(12, 12)
    Me.listText.MultiSelect = False
    Me.listText.Name = "listText"
    Me.listText.Size = New System.Drawing.Size(770, 419)
    Me.listText.TabIndex = 0
    Me.listText.UseCompatibleStateImageBehavior = False
    Me.listText.View = System.Windows.Forms.View.List
    '
    'txtResult
    '
    Me.txtResult.Location = New System.Drawing.Point(12, 437)
    Me.txtResult.Name = "txtResult"
    Me.txtResult.Size = New System.Drawing.Size(724, 20)
    Me.txtResult.TabIndex = 1
    '
    'btnOK
    '
    Me.btnOK.Location = New System.Drawing.Point(742, 437)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(40, 20)
    Me.btnOK.TabIndex = 2
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = True
    '
    'TextDlg
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(793, 473)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.txtResult)
    Me.Controls.Add(Me.listText)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "TextDlg"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Get Search String"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents listText As ListView
  Friend WithEvents txtResult As TextBox
  Friend WithEvents btnOK As Button
End Class
