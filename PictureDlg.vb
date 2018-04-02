Imports System.Windows.Forms

Public Class PictureDlg

  Private m_strDir As String
  Private m_Pictures As List(Of Picture)
  Private m_sFile As String


  Public Sub New(ByVal img As Image, ByVal strDir As String, ByVal pics As List(Of Picture))
    Dim maybe As New List(Of Picture)
    Dim dir As IO.DirectoryInfo
    Dim wnd As ShowPicsWnd
    Dim p, pc As Picture
    Dim sFile, sExtract As String
    Dim oFile As IO.FileInfo
    Dim nFile As Integer

    InitializeComponent()

    If img Is Nothing Then Throw New Exception("img is nothing")

    picImage.Image = img
    m_strDir = strDir
    txtDir.Text = strDir
    m_Pictures = pics

    If IO.Directory.Exists(txtDir.Text) = False Then Throw New Exception(txtDir.Text & " does not exist")
    dir = New IO.DirectoryInfo(m_strDir)
    sFile = ""
    For Each oFile In dir.GetFiles("*.jpg")
      If oFile.Name > sFile Then sFile = oFile.Name
    Next
    If sFile = "" Then
      nFile = 1
    Else
      sExtract = sFile.Substring(0, sFile.IndexOf("."))
      If Integer.TryParse(sExtract, nFile) = False Then MsgBox("File format in " & m_strDir & " not integer based, e.g. 347.jpg") : nFile = 0
      nFile += 1
    End If
    m_sFile = nFile.ToString("0000") & ".jpg"
    txtDir.Text &= "\" & m_sFile

    p = New Picture()
    p.ProcessForCompare(img)

    For Each pc In m_Pictures
      If p.Equal(pc) Then maybe.Add(pc)
    Next
    If maybe.Count > 0 Then
      wnd = New ShowPicsWnd(maybe)
      wnd.Text = "Possible Duplicates"
      wnd.ShowDialog()
    End If

  End Sub

  Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    Dim strWhole As String
    Dim p As Picture

    strWhole = m_strDir & "\" & m_sFile

    If IO.File.Exists(strWhole) Then MsgBox(strWhole & " already exists", MsgBoxStyle.Information) : Return

    Try
      picImage.Image.Save(strWhole, Imaging.ImageFormat.Jpeg)
      p = New Picture(m_strDir, m_sFile, MainWndIE.NextID)
      p.ProcessImage()
      m_Pictures.Add(p)
    Catch
      MsgBox("Unable to save jpg as " & strWhole, MsgBoxStyle.Information) : Return
    End Try


    Me.DialogResult = DialogResult.OK
    Me.Close()



  End Sub

  Private Sub btnDir_Click(sender As Object, e As EventArgs)
    Dim dlg As New FolderBrowserDialog

    If dlg.ShowDialog() = DialogResult.OK Then
      txtDir.Text = dlg.SelectedPath

    End If
  End Sub

  Public ReadOnly Property Directory() As String
    Get
      Return m_strDir
    End Get
  End Property
End Class
