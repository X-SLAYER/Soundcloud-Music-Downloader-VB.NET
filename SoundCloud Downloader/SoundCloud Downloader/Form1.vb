Imports System.Net
Imports System.Text
Imports System.IO
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System
Imports System.Windows.Forms
Imports System.Text.RegularExpressions

'CODED BY : X-SLAYER | 01/02/2018 | TN
'FACEBOOK : https://www.facebook.com/ihebbriki1
'SUBSCRIBE >> YOUTUBE : https://www.youtube.com/channel/UC-lOXlEl67lxmYTH2PTFovA?sub_confirmation=1
'INSTAGRAM : https://www.instagram.com/brikiiheb/
'TWITTER : https://twitter.com/IHEB_X_SLAYER
'LINKEDIN :https://www.linkedin.com/in/x-slayer/
'Copyright © X-SLAYER



Public Class Fmain

    Public Sub New()
        InitializeComponent()
        txtLocal.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    End Sub

    Dim client_id As String = "client_id=a549b13e0494aaec74fed484d567153b"
    Dim LV As New Dictionary(Of WebClient, ListViewItem)

    Private Sub Start(ByVal URL As String)
        Try
            Dim itm As New ListViewItem
            itm.UseItemStyleForSubItems = False
            itm.Text = "Checking URL ..."
            itm.SubItems.Add("Getting Data...").ForeColor = Color.DarkBlue
            itm.ImageIndex = 0
            LvDownloads.Items.Add(itm)
            Using I As New WebClient
                AddHandler I.DownloadStringCompleted, AddressOf info
                I.DownloadStringAsync(New Uri("https://api.soundcloud.com/resolve.json?url=" & URL & "&" & client_id))
                LV.Add(I, itm)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub info(sender As Object, e As DownloadStringCompletedEventArgs)
        Try
            Dim Result As String = e.Result
            LvDownloads.Items(LV.Item(sender).Index).ToolTipText = Result
            LvDownloads.Items(LV.Item(sender).Index).SubItems(1).Text = "Downloading..."
            LvDownloads.Items(LV.Item(sender).Index).SubItems(1).ForeColor = Color.Green
            LvDownloads.Items(LV.Item(sender).Index).Text = Regex.Match(Result, ",""title"":""(.*?)"",").Groups.Item(1).Value
            Using X As New WebClient
                AddHandler X.DownloadFileCompleted, AddressOf Complete2
                AddHandler X.DownloadProgressChanged, AddressOf Progress
                X.DownloadFileTaskAsync(New Uri("https://api.soundcloud.com/tracks/" & Regex.Match(LvDownloads.Items(LV.Item(sender).Index).ToolTipText, ",""id"":(.*?),").Groups.Item(1).Value & "/stream?" & client_id), txtLocal.Text & "\" & ModifyName(LvDownloads.Items(LV.Item(sender).Index).Text) & "." & Regex.Match(LvDownloads.Items(LV.Item(sender).Index).ToolTipText, ",""original_format"":""(.*?)"",").Groups.Item(1).Value)
                LV.Add(X, LvDownloads.Items(LV.Item(sender).Index))
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Progress(sender As Object, e As DownloadProgressChangedEventArgs)
        On Error Resume Next
        LvDownloads.Items(LV.Item(sender).Index).SubItems(1).Text = "Downloading(" & F(e.BytesReceived) & "/" & F(e.TotalBytesToReceive) & ") - " & e.ProgressPercentage & "%"
    End Sub
    Private Sub Complete2(sender As Object, e As AsyncCompletedEventArgs)
        If e.Cancelled = True Then
            LvDownloads.Items(LV.Item(sender).Index).SubItems(1).Text = "Cancelled..."
        ElseIf Not e.Error Is Nothing Then
            LvDownloads.Items(LV.Item(sender).Index).SubItems(1).Text = e.Error.Message
        ElseIf Not e.UserState Is Nothing Then
            LvDownloads.Items(LV.Item(sender).Index).SubItems(1).Text = "Successfully..."
        End If
    End Sub
#Region "browse"

    Private Sub btnBrowser_Click(sender As Object, e As EventArgs) Handles btnBrowser.Click
        Dim I As New FolderBrowserDialog
        I.ShowNewFolderButton = True
        I.RootFolder = Environment.SpecialFolder.Desktop
        I.Description = "Save Audio File"
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLocal.Text = I.SelectedPath
        End If
    End Sub

    Private Function F(ByVal type As Double) As String
        Dim types As String() = {"B", "KB", "MB", "GB"}
        Dim typees As Double = type
        Dim CSA As Integer = 0
        While typees >= 1024 AndAlso CSA + 1 < types.Length
            CSA += 1
            typees = typees / 1024
        End While
        Return [String].Format("{0:0.##} {1}", typees, types(CSA))
    End Function

    Private Function ModifyName(ByVal URL As String) As String
        Return URL.Replace("\", Nothing).Replace("/", Nothing).Replace(":", Nothing).Replace("*", Nothing).Replace("?", Nothing).Replace("""", Nothing).Replace("<", Nothing).Replace(">", Nothing).Replace("|", Nothing)
    End Function
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not (txturl.Text.Contains("soundcloud") = False Or txturl.Text = String.Empty) Then
            Start(txturl.Text)
            txturl.Text = Nothing
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.youtube.com/channel/UC-lOXlEl67lxmYTH2PTFovA?sub_confirmation=1")
    End Sub

    Private Sub CTXInformacoes_Click(sender As Object, e As EventArgs) Handles CTXInformacoes.Click
        For Each MyItem As ListViewItem In LvDownloads.SelectedItems
            If Not (MyItem.Text = "Checking URL ...") Then
                Dim FRM As New FrmInfo
                FRM.title.Text += MyItem.Text
                FRM.size.Text += F(Regex.Match(MyItem.ToolTipText, ",""original_content_size"":(.*?),").Groups.Item(1).Value)
                FRM.Avatar.Image = Bitmap.FromStream(New WebClient() With {.Proxy = Nothing}.OpenRead(Regex.Match(MyItem.ToolTipText, ",""avatar_url"":""(.*?)""}").Groups.Item(1).Value))
                FRM.created.Text += Regex.Match(MyItem.ToolTipText, ",""created_at"":""(.*?)"",").Groups.Item(1).Value
                FRM.user.Text += Regex.Match(MyItem.ToolTipText, ",""username"":""(.*?)"",").Groups.Item(1).Value
                FRM.Show()
            End If
        Next
    End Sub
End Class
