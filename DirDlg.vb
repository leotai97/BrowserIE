Imports System.Windows.Forms

Public Class DirDlg
  Private m_strDir As String

  Public Sub New(ByVal sDir As String)

    InitializeComponent()

    m_strDir = sDir
    txtDir.Text = sDir
  End Sub

  Private Sub btnDir_Click(sender As Object, e As EventArgs)
    Dim dlg As New FolderBrowserDialog

    dlg.SelectedPath = m_strDir

    If dlg.ShowDialog() = DialogResult.OK Then
      txtDir.Text = dlg.SelectedPath

    End If

  End Sub

  Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    If txtDir.Text.Trim = "" Then MsgBox("Directory cannot be blank", MsgBoxStyle.Information) : Return
    If IO.Directory.Exists(txtDir.Text) = False Then MsgBox("Directory " & txtDir.Text & " does not exist.", MsgBoxStyle.Information) : Return
    m_strDir = txtDir.Text.Trim
    Me.DialogResult = DialogResult.OK
    Me.Close()
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Me.DialogResult = DialogResult.Cancel
    Me.Close()
  End Sub

  Public ReadOnly Property Directory() As String
    Get
      Return m_strDir
    End Get
  End Property

End Class
