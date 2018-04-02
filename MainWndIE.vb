Public Class MainWndIE

  Private m_strDir As String
  Private m_listFavorites As List(Of String)

  Private m_Pictures As List(Of Picture)
  Private m_nNextID As Integer

  Private WithEvents web As WebBrowser

  Public Sub New()
    Dim s As String
    Dim i, c As Integer

    InitializeComponent()

    m_strDir = GetSetting("ImageExtractor", "Setting", "Directory", "")
    txtSearch.Text = GetSetting("ImageExtractor", "Setting", "Search", "")
    '  txtURL.Text = GetSetting("ImageExtractor", "Setting", "URL", "")


    m_listFavorites = New List(Of String)
    s = GetSetting("ImageExtractor", "Setting", "FavoriteCount", "0")
    If Integer.TryParse(s, c) = False Then Throw New Exception("should be ok")
    For i = 1 To c
      s = GetSetting("ImageExtractor", "Setting", "Favorite_" & i, "")
      If s <> "" Then
        m_listFavorites.Add(s)
      End If
    Next

    For Each s In m_listFavorites
      btnFavorites.DropDown.Items.Add(s, Nothing, AddressOf mnuFavorites_ItemClick)
    Next

    web = New WebBrowser
    Me.Controls.Add(web)
    web.Dock = DockStyle.Fill
    web.BringToFront()

    web.ScriptErrorsSuppressed = True

    Me.WindowState = FormWindowState.Maximized

    If m_strDir <> "" Then
      m_Pictures = ProcessDirectory(m_strDir)
    End If

  End Sub

  Private Sub MainWnd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    Dim i As Integer
    Dim s As String

    SaveSetting("ImageExtractor", "Setting", "Directory", m_strDir)
    SaveSetting("ImageExtractor", "Setting", "Search", txtSearch.Text.Trim)

    SaveSetting("ImageExtractor", "Setting", "FavoriteCount", m_listFavorites.Count.ToString)

    i = 1
    For Each s In m_listFavorites
      SaveSetting("ImageExtractor", "Setting", "Favorite_" & i, s)
      i += 1
    Next

  End Sub


  Private Sub btnPic_Click(sender As Object, e As EventArgs) Handles btnPic.Click
    Dim dlg As PictureDlg
    Dim list As List(Of String) ' HtmlElementCollection = web.Document.GetElementsByTagName("img")
    Dim response As Net.WebResponse, request As Net.WebRequest
    Dim stream As IO.Stream
    Dim s As String, bmp As Image
    Dim blnFound As Boolean

    If m_strDir = "" Then
      MsgBox("Working directory is not set", MsgBoxStyle.Information)
      Return
    End If

    If txtSearch.Text = "" Then
      ShowSrc()
      Return
    End If

    list = GetImgSrc()
    blnFound = False
    For Each s In list
      ' s = element.GetAttribute("src").ToString
      If s.IndexOf(txtSearch.Text) >= 0 Then
        request = System.Net.WebRequest.Create(New Uri(s))
        response = request.GetResponse()
        stream = response.GetResponseStream
        bmp = Bitmap.FromStream(stream)
        stream.Close()
        response.Close()
        response.Dispose()
        dlg = New PictureDlg(bmp, m_strDir, m_Pictures)
        dlg.ShowDialog()
        dlg.Dispose()
        blnFound = True
      End If
    Next
    If blnFound = False Then
      MsgBox("IMG SRC search string """ & txtSearch.Text & """ not found in any IMG HTML Element.", MsgBoxStyle.Information) : Return
    End If
  End Sub

  Private Function GetImgSrc() As List(Of String)
    Dim ele As HtmlElement, s As String
    Dim res As String = "Nil"
    Dim list As New Dictionary(Of String, String)
    Dim final As New List(Of String)

    For Each ele In web.Document.GetElementsByTagName("IMG")
      s = ele.GetAttribute("SRC")
      If list.ContainsKey(s) = False Then list.Add(s, s)
    Next

    For Each s In list.Values
      final.Add(s)
    Next

    Return final

  End Function

  Private Sub btnURL_Click(sender As Object, e As EventArgs) Handles btnURL.Click
    Navigate(txtURL.Text)
  End Sub

  Private Sub ShowSrc()
    Dim listImg As List(Of String) ' HtmlElementCollection = web.Document.GetElementsByTagName("img")
    ' Dim element As String ' HtmlElement
    Dim dlg As TextDlg
    Dim src As New Dictionary(Of String, String)
    Dim s As String

    listImg = GetImgSrc()

    For Each s In listImg
      If Not src.ContainsKey(s) Then src.Add(s, s)
    Next
    dlg = New TextDlg(src)
    If dlg.ShowDialog = vbOK Then
      txtSearch.Text = dlg.SelectedText
    End If
    dlg.Dispose()

  End Sub

  Private Sub Navigate(ByVal strURL As String)

    If strURL.Trim = "" Then
      MsgBox("URL is empty", MsgBoxStyle.Information)
      Return
    End If
    web.Navigate(New Uri(strURL))

  End Sub

  Private Sub GoBack()
    If web.CanGoBack Then web.GoBack()  '  .GoBack() : txtURL.Text = web.Url.ToString
  End Sub

  Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    GoBack()
  End Sub

  Private Sub web_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles web.DocumentCompleted
    txtURL.Text = e.Url.ToString
  End Sub

  Private Sub btnShowPics_Click(sender As Object, e As EventArgs) Handles btnShowPics.Click
    Dim pics As ShowPicsWnd

    If m_strDir = "" Then Return

    pics = New ShowPicsWnd(m_Pictures)
    pics.ShowDialog()
    pics.Dispose()

  End Sub

  Private Sub mnuFavorites_ItemClick(ByVal sender As Object, ByVal e As EventArgs) ' handled in code
    Dim menu As ToolStripMenuItem

    menu = CType(sender, ToolStripMenuItem)
    Navigate(menu.Text)
  End Sub

  Private Sub btnFavorite_Click(sender As Object, e As EventArgs) Handles mnuFavoriteAdd.Click
    Dim s As String

    If txtURL.Text = "" Then Return

    For Each s In m_listFavorites
      If s.ToLower = txtURL.Text.ToLower Then MsgBox("URL " & txtURL.Text & " is already a favorite", MsgBoxStyle.Information) : Return
    Next

    m_listFavorites.Add(txtURL.Text)
    btnFavorites.DropDown.Items.Add(txtURL.Text, Nothing, AddressOf mnuFavorites_ItemClick)

  End Sub

  Private Sub btnDir_Click(sender As Object, e As EventArgs) Handles btnDir.Click
    Dim dlg As New DirDlg(m_strDir)
    Dim p As Picture

    If dlg.ShowDialog() = DialogResult.OK Then
      m_strDir = dlg.Directory
      For Each p In m_Pictures
        p.Dispose()
      Next
      m_Pictures.Clear()
      m_Pictures = ProcessDirectory(m_strDir)
    End If

    dlg.Dispose()

  End Sub

  Private Sub mnuFavoritesMaintain_Click(sender As Object, e As EventArgs) Handles mnuFavoritesMaintain.Click
    Dim dlg As New FavoritesDlg(m_listFavorites)
    Dim menu As ToolStripItem
    Dim bFound As Boolean

    If dlg.ShowDialog() = DialogResult.OK Then
      m_listFavorites = dlg.Favorites
    End If
    dlg.Dispose()

    For Each menu In btnFavorites.DropDown.Items
      If menu.Tag.ToString <> "A" Then  '  all gui menu items are pre-set with A, favorites added later are not
        bFound = False
        For Each s In m_listFavorites
          If s.ToLower = menu.Text.ToLower Then bFound = True
        Next
        If bFound = False Then menu.Visible = False ' just wait for reload of exe
      End If
    Next

  End Sub

  Public Function NextID() As Integer
    m_nNextID += 1
    Return m_nNextID
  End Function

  Private Function ProcessDirectory(ByVal strPath As String) As List(Of Picture)
    Dim d As IO.DirectoryInfo
    Dim p As Picture
    Dim i As Integer
    Dim blnDone As Boolean
    Dim nItems As Integer
    Dim listTemp As New List(Of Picture)
    Dim listPictures As New List(Of Picture)
    Dim info() As IO.FileInfo
    Dim f As IO.FileInfo

    If IO.Directory.Exists(strPath) = False Then
      MsgBox(strPath & "does not exist", MsgBoxStyle.Information)
      Return Nothing
    End If

    d = New IO.DirectoryInfo(strPath)
    info = d.GetFiles("*.jpg")
    If info.Length = 0 Then
      MsgBox("There are no jpg pictures in " & strPath, MsgBoxStyle.Information)
      Return Nothing
    End If

    nItems = 0
    For i = 0 To info.Count - 1
      f = info(i)
      p = New Picture(strPath, f.Name, NextID)
      listTemp.Add(p)
      nItems += 1
    Next

    Threading.ThreadPool.SetMaxThreads(4, 4)
    For Each p In listTemp
      If p.Ready = False Then Threading.ThreadPool.QueueUserWorkItem(AddressOf p.ProcessImage)
    Next

    Do
      i = 0
      blnDone = True
      For Each p In listTemp
        If p.Ready = False Then
          blnDone = False
        Else
          i += 1
        End If
      Next
      '   pgb.Value = i
      If blnDone = False Then Threading.Thread.Sleep(500)
    Loop Until blnDone = True

    For Each p In listTemp
      listPictures.Add(p)

    Next

    listTemp.Clear()

    Return listPictures

  End Function

  Private Sub txtURL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtURL.KeyDown
    If e.KeyCode = Keys.Return Then Me.Navigate(txtURL.Text) : e.Handled = True
  End Sub

End Class
