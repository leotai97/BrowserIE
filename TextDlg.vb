Imports System.Windows.Forms

Public Class TextDlg


  Public Sub New(ByVal src As Dictionary(Of String, String))
    Dim s As String

    InitializeComponent()

    For Each s In src.Values
      listText.Items.Add(s)
    Next



  End Sub

  Private Sub listText_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listText.SelectedIndexChanged
    If listText.SelectedItems.Count = 0 Then Return

    txtResult.Text = listText.SelectedItems(0).Text
  End Sub

  Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    If txtResult.Text.Trim = "" Then
      MsgBox("Nothing selected", MsgBoxStyle.Information)
      Return
    End If
    Me.DialogResult = DialogResult.OK
    Me.Close()

  End Sub
  Public ReadOnly Property SelectedText() As String
    Get
      Return Me.txtResult.Text.Trim
    End Get
  End Property

End Class
