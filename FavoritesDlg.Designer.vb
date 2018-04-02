<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FavoritesDlg
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
    Me.listFavs = New System.Windows.Forms.ListView()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.btnDrop = New System.Windows.Forms.Button()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.c1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.SuspendLayout()
    '
    'listFavs
    '
    Me.listFavs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.c1})
    Me.listFavs.FullRowSelect = True
    Me.listFavs.GridLines = True
    Me.listFavs.Location = New System.Drawing.Point(12, 12)
    Me.listFavs.MultiSelect = False
    Me.listFavs.Name = "listFavs"
    Me.listFavs.Size = New System.Drawing.Size(555, 238)
    Me.listFavs.TabIndex = 0
    Me.listFavs.UseCompatibleStateImageBehavior = False
    Me.listFavs.View = System.Windows.Forms.View.Details
    '
    'btnCancel
    '
    Me.btnCancel.Location = New System.Drawing.Point(490, 268)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
    Me.btnCancel.TabIndex = 1
    Me.btnCancel.Text = "Cancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'btnDrop
    '
    Me.btnDrop.Location = New System.Drawing.Point(12, 268)
    Me.btnDrop.Name = "btnDrop"
    Me.btnDrop.Size = New System.Drawing.Size(106, 23)
    Me.btnDrop.TabIndex = 2
    Me.btnDrop.Text = "Remove Favorite"
    Me.btnDrop.UseVisualStyleBackColor = True
    '
    'btnOK
    '
    Me.btnOK.Location = New System.Drawing.Point(409, 268)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(75, 23)
    Me.btnOK.TabIndex = 3
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = True
    '
    'c1
    '
    Me.c1.Text = "URL"
    '
    'FavoritesDlg
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(579, 306)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.btnDrop)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.listFavs)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FavoritesDlg"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Maintain Favorites"
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents listFavs As ListView
  Friend WithEvents btnCancel As Button
  Friend WithEvents btnDrop As Button
  Friend WithEvents btnOK As Button
  Friend WithEvents c1 As ColumnHeader
End Class
