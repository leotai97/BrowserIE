Public Class Picture
  Implements IDisposable

  Private m_Id As Integer
  Private m_Dir As String
  Private m_FullPath As String
  Private m_File As String
  Private m_bReady As Boolean

  Private m_nWidth As Integer
  Private m_nHeight As Integer
  Private m_Size As String

  Private m_nSize As Long
  Private m_dtFile As DateTime

  Private m_thumb As Image

  Private m_blnMonoChrome As Boolean
  Private m_Colors As Dictionary(Of String, PicColor)
  Private m_Sorted() As PicColor

  Public Sub New(ByVal strDir As String, ByVal sFile As String, ByVal Id As Integer)

    m_Id = Id
    m_Dir = strDir
    m_File = sFile
    m_FullPath = strDir & "\" & sFile

    m_bReady = False

  End Sub

  Public Sub New()

    m_Id = 0
    m_Dir = ""
    m_File = ""
    m_FullPath = ""

    m_bReady = False

  End Sub


  Public Function Delete() As Boolean
    Try
      IO.File.Delete(Me.m_FullPath)
    Catch ex As IO.IOException
      Return False
    End Try
    Return True

  End Function

  Public Sub Dispose() Implements IDisposable.Dispose
    If Not m_thumb Is Nothing Then m_thumb.Dispose()
    m_thumb = Nothing
  End Sub

  Public Sub ProcessImage()
    Dim img As Image
    Dim info As New IO.FileInfo(m_FullPath)

    m_Size = FSizer(info.Length)
    m_nSize = info.Length
    m_dtFile = info.LastWriteTime

    If m_bReady = True Then Throw New Exception("shouldn't be")
    If Not m_thumb Is Nothing Then Throw New Exception("shouldn't be")

    img = Image.FromFile(m_FullPath, True)

    ProcessImageInternal(img)

    img.Dispose()
    img = Nothing
    m_bReady = True

  End Sub

  Public Sub ProcessForCompare(ByVal bmp As Image)  'special case used for picture comparison
    ProcessImageInternal(bmp)
  End Sub

  Private Sub ProcessImageInternal(ByVal img As Image)
    Dim sw, sh As Integer
    Dim imgThumb As Bitmap
    Dim gr As Graphics

    m_nWidth = img.Width
    m_nHeight = img.Height

    If m_nWidth > m_nHeight Then
      sw = 128
      sh = CInt(128 * m_nHeight / m_nWidth)
    Else
      sh = 128
      sw = CInt(128 * m_nWidth / m_nHeight)
    End If

    imgThumb = New Bitmap(img, sw, sh)  ' if w > h then w=128 and h = 128 * h/w else    ' imgThumb is a smaller version of the original pic

    ExtractColor(imgThumb)

    m_thumb = New Bitmap(128, 128, Imaging.PixelFormat.Format24bppRgb)  ' m_thumb is square with "window" border
    gr = Graphics.FromImage(m_thumb)
    gr.FillRectangle(SystemBrushes.Window, New Rectangle(0, 0, 128, 128))
    gr.DrawImage(imgThumb, New Point(0, 0))
    gr.Dispose()
    imgThumb.Dispose()

  End Sub

  Private Sub ExtractColor(ByVal img As Bitmap)
    Dim data As Imaging.BitmapData
    Dim prepSort As ColorPrepCompare
    Dim nBytes, lineBytes, numBytes As Integer
    Dim r, g, b, k As Integer
    Dim Color() As Byte
    Dim ratio As Double
    Dim rct As Rectangle
    Dim ptr As IntPtr
    Dim pc As PicColor

    rct = New Rectangle(0, 0, img.Width, img.Height)
    data = img.LockBits(rct, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
    nBytes = Math.Abs(data.Stride) * img.Height

    ptr = data.Scan0

    '   ReDim color(nBytes - 1)
    '  System.Runtime.InteropServices.Marshal.Copy(ptr, color, 0, nBytes)


    lineBytes = img.Width * 3
    numBytes = lineBytes * img.Height
    ReDim Color(lineBytes - 1)

    m_blnMonoChrome = True
    m_Colors = New Dictionary(Of String, PicColor)

    For y = 0 To img.Height - 1
      Runtime.InteropServices.Marshal.Copy(data.Scan0 + y * data.Stride, Color, 0, lineBytes)
      For i = 0 To lineBytes - 3 Step 3
        r = Color(i + 2)
        g = Color(i + 1)
        b = Color(i)

        k = ((r << 16) Or (g << 8) Or b)

        pc = New PicColor(k, r, g, b, 1)

        If m_Colors.ContainsKey(pc.Key) = False Then
          m_Colors.Add(pc.Key, pc)
        Else
          m_Colors.Item(pc.Key).Accumulate()
        End If
        ' m_bigArray(k) += 1

        If m_blnMonoChrome = True Then
          If r <> g Or r <> b Or g <> b Then
            m_blnMonoChrome = False  ' nope, it's just another color picture
          End If
        End If
      Next
    Next
    Erase Color

    img.UnlockBits(data)
    ' img.Dispose()
    ' img = Nothing

    ratio = m_nWidth * m_nHeight

    prepSort = New ColorPrepCompare
    ReDim m_Sorted(m_Colors.Values.Count - 1)
    k = 0
    For Each p As PicColor In m_Colors.Values
      m_Sorted(k) = p
      k += 1
    Next
    Array.Sort(m_Sorted, prepSort)

  End Sub


  Public Shared Function FSizer(ByVal size As Long) As String

    If size < 1024 Then Return size.ToString
    If size < 1024000 Then Return size \ 1024 & " KB"
    If size < 1024000000 Then Return size \ 1024000 & " MB"
    Return size \ 1024000000 & " GB"

  End Function

  Public ReadOnly Property Ready() As Boolean
    Get
      Return m_bReady
    End Get
  End Property

  Public ReadOnly Property FullPath() As String
    Get
      Return m_FullPath
    End Get
  End Property

  Public ReadOnly Property Width() As Integer
    Get
      Return m_nWidth
    End Get
  End Property

  Public ReadOnly Property Height() As Integer
    Get
      Return m_nHeight
    End Get
  End Property

  Public ReadOnly Property Thumbnail() As Image
    Get
      Return m_thumb
    End Get
  End Property

  Public ReadOnly Property FileName() As String
    Get
      Return m_File
    End Get
  End Property

  Public ReadOnly Property ID() As Integer
    Get
      Return m_Id
    End Get
  End Property

  Public ReadOnly Property FileSize() As String
    Get
      Return m_Size
    End Get
  End Property

  Public ReadOnly Property FileLength() As Long
    Get
      Return m_nSize
    End Get
  End Property

  Public ReadOnly Property FileDate() As DateTime
    Get
      Return m_dtFile
    End Get
  End Property

  Public ReadOnly Property Colors() As PicColor()
    Get
      Return m_Sorted
    End Get
  End Property

  Public Function Equal(ByVal p As Picture) As Boolean
    Dim px, py As Picture
    Dim i, c, k As Integer

    px = Me
    py = p

    If px.Colors.Length > py.Colors.Length Then c = px.Colors.Length Else c = py.Colors.Length
    For i = 0 To c - 1
      k = PicColor.Compare(px.Colors(i), py.Colors(i))
      If k <> 0 Then Return False
      If px.Colors(i).Amount > py.Colors(i).Amount Then Return False
      If px.Colors(i).Amount < py.Colors(i).Amount Then Return False
    Next
    Return True

  End Function


End Class

Public Class PicColor

  Private m_nColor As Integer
  Private m_nCount As Integer
  Private m_r As Double
  Private m_g As Double
  Private m_b As Double

  Private m_strKey As String

  Public Sub New(ByVal nColor As Integer, ByVal r As Integer, ByVal g As Integer, ByVal b As Integer, ByVal nCount As Integer)
    Dim gFloat As Double, bFloat As Double

    m_nColor = nColor

    m_r = r / 255
    gFloat = g / 255
    bFloat = b / 255

    If gFloat > 0.04045 Then
      m_g = ((gFloat + 0.055) / (1.055)) ^ 2.2
    Else
      m_g = gFloat / 12.92
    End If

    If bFloat > 0.04045 Then
      m_b = ((bFloat + 0.055) / (1.055)) ^ 2.2
    Else
      m_b = bFloat / 12.92
    End If

    m_strKey = "R" & m_r.ToString("0.0000") & "G" & m_g.ToString("0.0000") & "B" & m_b.ToString("0.0000")

    m_nCount = nCount
  End Sub

  Public Sub Accumulate()
    m_nCount += 1
  End Sub

  Public ReadOnly Property Amount() As Integer
    Get
      Return m_nCount
    End Get
  End Property

  Public ReadOnly Property Color() As Integer
    Get
      Return m_nColor
    End Get
  End Property

  Public ReadOnly Property Key() As String
    Get
      Return m_strKey
    End Get
  End Property

  Public ReadOnly Property SR() As Double
    Get
      Return m_r
    End Get
  End Property

  Public ReadOnly Property SG() As Double
    Get
      Return m_g
    End Get
  End Property

  Public ReadOnly Property SB() As Double
    Get
      Return m_b
    End Get
  End Property

  Public Shared Function Compare(ByVal p1 As PicColor, p2 As PicColor) As Integer

    If p1.m_r > p2.m_r Then Return 1
    If p1.m_r < p2.m_r Then Return -1

    If p1.m_g > p2.m_g Then Return 1
    If p1.m_g < p2.m_g Then Return -1

    If p1.m_b > p2.m_b Then Return 1
    If p1.m_b < p2.m_b Then Return -1

    Return 0

  End Function




End Class

Public Class ColorPrepCompare ' greater to less
  Implements IComparer

  Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
    Dim xc As PicColor, yc As PicColor

    If x Is Nothing Then Throw New Exception("x is nothing")
    If y Is Nothing Then Throw New Exception("y is nothing")

    xc = CType(x, PicColor)
    yc = CType(y, PicColor)

    If xc.Amount < yc.Amount Then Return 1
    If xc.Amount > yc.Amount Then Return -1
    Return 0

  End Function
End Class

Public Class LVItem
  Inherits ListViewItem

  Private m_Picture As Picture

  Public Sub New(ByVal p As Picture)

    m_Picture = p

    Me.Text = p.FileName
    Me.SubItems.Add(p.Width.ToString)
    Me.SubItems.Add(p.Height.ToString)
    Me.SubItems.Add(p.FileSize)
    Me.ImageKey = "p" & p.ID

  End Sub

  Public Property Picture() As Picture
    Get
      Return m_Picture
    End Get
    Set(p As Picture)

      m_Picture = p

      Me.Text = p.FileName
      Me.SubItems(1).Text = p.Width.ToString
      Me.SubItems(2).Text = p.Height.ToString
      Me.SubItems(3).Text = p.FileSize
      Me.ImageKey = "p" & p.ID

    End Set
  End Property

End Class