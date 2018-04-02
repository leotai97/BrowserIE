Public Class ShowPicsWnd

  Private m_strPath As String

  Public Sub New(ByVal list As List(Of Picture))
    Dim item As LVItem
    Dim p As Picture

    InitializeComponent()

    For Each p In list
      ImageIcons.Images.Add("p" & p.ID, p.Thumbnail)
      item = New LVItem(p)
      listPics.Items.Add(item)
    Next

  End Sub

  Private Sub listPics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listPics.SelectedIndexChanged
    Dim item As LVItem
    Dim pic As Image

    If listPics.SelectedItems.Count = 0 Then Return

    item = CType(listPics.SelectedItems(0), LVItem)

    pic = FreeImage(item.Picture.FullPath)
    If picSelected.Image IsNot Nothing Then picSelected.Image.Dispose()
    picSelected.Image = pic

  End Sub

  Public Shared Function FreeImage(ByVal strFile As String) As Image
    Dim fs As System.IO.FileStream
    Dim img As Image
    Dim timg As Image

    fs = New System.IO.FileStream(strFile, IO.FileMode.Open, IO.FileAccess.Read)
    timg = System.Drawing.Image.FromStream(fs)
    fs.Close()
    fs.Dispose()

    img = CType(timg.Clone, Image)
    timg.Dispose()
    Return img

  End Function

End Class
