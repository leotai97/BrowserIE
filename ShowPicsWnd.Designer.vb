<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowPicsWnd
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
    Me.components = New System.ComponentModel.Container()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.listPics = New System.Windows.Forms.ListView()
    Me.ImageIcons = New System.Windows.Forms.ImageList(Me.components)
    Me.picSelected = New System.Windows.Forms.PictureBox()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.picSelected, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.listPics)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.picSelected)
    Me.SplitContainer1.Size = New System.Drawing.Size(642, 608)
    Me.SplitContainer1.SplitterDistance = 375
    Me.SplitContainer1.TabIndex = 2
    '
    'listPics
    '
    Me.listPics.Dock = System.Windows.Forms.DockStyle.Fill
    Me.listPics.LargeImageList = Me.ImageIcons
    Me.listPics.Location = New System.Drawing.Point(0, 0)
    Me.listPics.Name = "listPics"
    Me.listPics.Size = New System.Drawing.Size(375, 608)
    Me.listPics.TabIndex = 1
    Me.listPics.UseCompatibleStateImageBehavior = False
    '
    'ImageIcons
    '
    Me.ImageIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
    Me.ImageIcons.ImageSize = New System.Drawing.Size(128, 128)
    Me.ImageIcons.TransparentColor = System.Drawing.Color.Transparent
    '
    'picSelected
    '
    Me.picSelected.Dock = System.Windows.Forms.DockStyle.Fill
    Me.picSelected.Location = New System.Drawing.Point(0, 0)
    Me.picSelected.Name = "picSelected"
    Me.picSelected.Size = New System.Drawing.Size(263, 608)
    Me.picSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.picSelected.TabIndex = 2
    Me.picSelected.TabStop = False
    '
    'ShowPicsWnd
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(642, 608)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Name = "ShowPicsWnd"
    Me.Text = "Show Pictures"
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    CType(Me.picSelected, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents SplitContainer1 As SplitContainer
  Friend WithEvents listPics As ListView
  Friend WithEvents picSelected As PictureBox
  Friend WithEvents ImageIcons As ImageList
End Class
