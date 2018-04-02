<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWndIE
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWndIE))
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.btnBack = New System.Windows.Forms.ToolStripButton()
    Me.txtURL = New System.Windows.Forms.ToolStripTextBox()
    Me.btnURL = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
    Me.btnPic = New System.Windows.Forms.ToolStripButton()
    Me.btnFavorites = New System.Windows.Forms.ToolStripDropDownButton()
    Me.btnShowPics = New System.Windows.Forms.ToolStripButton()
    Me.btnDir = New System.Windows.Forms.ToolStripButton()
    Me.mnuFavoriteAdd = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFavoritesMaintain = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFavoritesSeparator = New System.Windows.Forms.ToolStripSeparator()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ToolStrip1
    '
    Me.ToolStrip1.AutoSize = False
    Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.txtURL, Me.btnURL, Me.ToolStripSeparator1, Me.txtSearch, Me.btnPic, Me.btnFavorites})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(1300, 52)
    Me.ToolStrip1.TabIndex = 5
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnBack
    '
    Me.btnBack.AutoSize = False
    Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnBack.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBack.Image = Global.BrowserIE.My.Resources.Resources.ArrowLeft
    Me.btnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnBack.Name = "btnBack"
    Me.btnBack.Size = New System.Drawing.Size(48, 48)
    Me.btnBack.Text = "<<"
    Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
    Me.btnBack.ToolTipText = "Back"
    '
    'txtURL
    '
    Me.txtURL.Name = "txtURL"
    Me.txtURL.Size = New System.Drawing.Size(400, 52)
    '
    'btnURL
    '
    Me.btnURL.BackColor = System.Drawing.SystemColors.Control
    Me.btnURL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnURL.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnURL.Image = Global.BrowserIE.My.Resources.Resources.Go
    Me.btnURL.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnURL.Name = "btnURL"
    Me.btnURL.Size = New System.Drawing.Size(52, 49)
    Me.btnURL.Text = "Go"
    Me.btnURL.ToolTipText = "Go"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
    '
    'txtSearch
    '
    Me.txtSearch.Name = "txtSearch"
    Me.txtSearch.Size = New System.Drawing.Size(250, 52)
    '
    'btnPic
    '
    Me.btnPic.AutoSize = False
    Me.btnPic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnPic.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnPic.Image = Global.BrowserIE.My.Resources.Resources.Picture
    Me.btnPic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.btnPic.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnPic.Name = "btnPic"
    Me.btnPic.Size = New System.Drawing.Size(54, 50)
    Me.btnPic.Text = "Picture"
    Me.btnPic.ToolTipText = "Get Picture"
    '
    'btnFavorites
    '
    Me.btnFavorites.AutoSize = False
    Me.btnFavorites.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnFavorites.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnShowPics, Me.btnDir, Me.mnuFavoriteAdd, Me.mnuFavoritesMaintain, Me.mnuFavoritesSeparator})
    Me.btnFavorites.Image = Global.BrowserIE.My.Resources.Resources.Setting
    Me.btnFavorites.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.btnFavorites.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnFavorites.Name = "btnFavorites"
    Me.btnFavorites.Size = New System.Drawing.Size(64, 50)
    Me.btnFavorites.Tag = "A"
    Me.btnFavorites.Text = "ToolStripDropDownButton1"
    '
    'btnShowPics
    '
    Me.btnShowPics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.btnShowPics.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.btnShowPics.Image = CType(resources.GetObject("btnShowPics.Image"), System.Drawing.Image)
    Me.btnShowPics.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnShowPics.Name = "btnShowPics"
    Me.btnShowPics.Size = New System.Drawing.Size(155, 19)
    Me.btnShowPics.Tag = "A"
    Me.btnShowPics.Text = "Show Pics in Save Directory"
    '
    'btnDir
    '
    Me.btnDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.btnDir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.btnDir.Image = CType(resources.GetObject("btnDir.Image"), System.Drawing.Image)
    Me.btnDir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnDir.Name = "btnDir"
    Me.btnDir.Size = New System.Drawing.Size(105, 19)
    Me.btnDir.Tag = "A"
    Me.btnDir.Text = "Set Save Directory"
    Me.btnDir.ToolTipText = "Set Working Directory"
    '
    'mnuFavoriteAdd
    '
    Me.mnuFavoriteAdd.Image = Global.BrowserIE.My.Resources.Resources.Favorites16
    Me.mnuFavoriteAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.mnuFavoriteAdd.ImageTransparentColor = System.Drawing.Color.Fuchsia
    Me.mnuFavoriteAdd.Name = "mnuFavoriteAdd"
    Me.mnuFavoriteAdd.Size = New System.Drawing.Size(215, 22)
    Me.mnuFavoriteAdd.Tag = "A"
    Me.mnuFavoriteAdd.Text = "Add Favorite"
    '
    'mnuFavoritesMaintain
    '
    Me.mnuFavoritesMaintain.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.mnuFavoritesMaintain.Name = "mnuFavoritesMaintain"
    Me.mnuFavoritesMaintain.Size = New System.Drawing.Size(215, 22)
    Me.mnuFavoritesMaintain.Tag = "A"
    Me.mnuFavoritesMaintain.Text = "Maintain Favorites"
    '
    'mnuFavoritesSeparator
    '
    Me.mnuFavoritesSeparator.Name = "mnuFavoritesSeparator"
    Me.mnuFavoritesSeparator.Size = New System.Drawing.Size(212, 6)
    Me.mnuFavoritesSeparator.Tag = "A"
    '
    'MainWnd
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1300, 605)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "MainWnd"
    Me.Text = "Browser"
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ToolStrip1 As ToolStrip
  Friend WithEvents txtURL As ToolStripTextBox
  Friend WithEvents btnURL As ToolStripButton
  Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
  Friend WithEvents txtSearch As ToolStripTextBox
  Friend WithEvents btnPic As ToolStripButton
  Friend WithEvents btnBack As ToolStripButton
  Friend WithEvents btnFavorites As ToolStripDropDownButton
  Friend WithEvents btnShowPics As ToolStripButton
  Friend WithEvents btnDir As ToolStripButton
  Friend WithEvents mnuFavoriteAdd As ToolStripMenuItem
  Friend WithEvents mnuFavoritesMaintain As ToolStripMenuItem
  Friend WithEvents mnuFavoritesSeparator As ToolStripSeparator
End Class
