<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PictureDlg
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.picImage = New System.Windows.Forms.PictureBox()
    Me.btnSave = New System.Windows.Forms.Button()
    Me.txtDir = New System.Windows.Forms.TextBox()
    CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'picImage
    '
    Me.picImage.Location = New System.Drawing.Point(12, 48)
    Me.picImage.Name = "picImage"
    Me.picImage.Size = New System.Drawing.Size(571, 491)
    Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.picImage.TabIndex = 0
    Me.picImage.TabStop = False
    '
    'btnSave
    '
    Me.btnSave.Location = New System.Drawing.Point(537, 12)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(50, 23)
    Me.btnSave.TabIndex = 1
    Me.btnSave.Text = "Save"
    Me.btnSave.UseVisualStyleBackColor = True
    '
    'txtDir
    '
    Me.txtDir.Location = New System.Drawing.Point(12, 14)
    Me.txtDir.Name = "txtDir"
    Me.txtDir.Size = New System.Drawing.Size(487, 20)
    Me.txtDir.TabIndex = 2
    '
    'PictureDlg
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(595, 551)
    Me.Controls.Add(Me.txtDir)
    Me.Controls.Add(Me.btnSave)
    Me.Controls.Add(Me.picImage)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "PictureDlg"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Picture"
    CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents picImage As PictureBox
  Friend WithEvents btnSave As Button
  Friend WithEvents txtDir As TextBox
End Class
