Imports System.Windows.Forms

Public Class FavoritesDlg

  Public Sub New(ByVal favs As List(Of String))
    Dim s As String

    InitializeComponent()

    For Each s In favs
      listFavs.Items.Add(New ListViewItem(s))
    Next
    c1.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
  End Sub

  Private Sub btnDrop_Click(sender As Object, e As EventArgs) Handles btnDrop.Click

    If listFavs.SelectedItems.Count = 0 Then MsgBox("Favorite to drop is not selected.", MsgBoxStyle.Information) : Return
    listFavs.SelectedItems(0).Remove()

  End Sub

  Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    Me.DialogResult = DialogResult.OK
    Me.Close()
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Me.DialogResult = DialogResult.Cancel
    Me.Close()
  End Sub

  Public ReadOnly Property Favorites() As List(Of String)
    Get
      Dim item As ListViewItem
      Dim list As New List(Of String)

      For Each item In listFavs.Items
        list.Add(item.Text)
      Next
      Return list

    End Get
  End Property
End Class
