<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fmain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fmain))
        Me.txturl = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.btnBrowser = New System.Windows.Forms.Button()
        Me.LvDownloads = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CTX = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CTXInformacoes = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTX.SuspendLayout()
        Me.SuspendLayout()
        '
        'txturl
        '
        Me.txturl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txturl.Location = New System.Drawing.Point(12, 12)
        Me.txturl.Name = "txturl"
        Me.txturl.Size = New System.Drawing.Size(392, 23)
        Me.txturl.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(410, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Download"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtLocal
        '
        Me.txtLocal.Location = New System.Drawing.Point(81, 270)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(320, 23)
        Me.txtLocal.TabIndex = 7
        '
        'btnBrowser
        '
        Me.btnBrowser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowser.ForeColor = System.Drawing.Color.Black
        Me.btnBrowser.Location = New System.Drawing.Point(410, 270)
        Me.btnBrowser.Name = "btnBrowser"
        Me.btnBrowser.Size = New System.Drawing.Size(82, 23)
        Me.btnBrowser.TabIndex = 6
        Me.btnBrowser.Text = "Browser"
        Me.btnBrowser.UseVisualStyleBackColor = True
        '
        'LvDownloads
        '
        Me.LvDownloads.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LvDownloads.ContextMenuStrip = Me.CTX
        Me.LvDownloads.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvDownloads.ForeColor = System.Drawing.Color.Black
        Me.LvDownloads.FullRowSelect = True
        Me.LvDownloads.GridLines = True
        Me.LvDownloads.Location = New System.Drawing.Point(12, 41)
        Me.LvDownloads.Name = "LvDownloads"
        Me.LvDownloads.Size = New System.Drawing.Size(480, 224)
        Me.LvDownloads.TabIndex = 5
        Me.LvDownloads.UseCompatibleStateImageBehavior = False
        Me.LvDownloads.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Title"
        Me.ColumnHeader1.Width = 210
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Status"
        Me.ColumnHeader2.Width = 260
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Local :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 271)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "SUBSCRIBE >> YOUTUBE :"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(154, 302)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 15)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X-SLAYER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(375, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Copyright © X-SLAYER"
        '
        'CTX
        '
        Me.CTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTXInformacoes})
        Me.CTX.Name = "CTX"
        Me.CTX.Size = New System.Drawing.Size(153, 48)
        '
        'CTXInformacoes
        '
        Me.CTXInformacoes.Image = CType(resources.GetObject("CTXInformacoes.Image"), System.Drawing.Image)
        Me.CTXInformacoes.Name = "CTXInformacoes"
        Me.CTXInformacoes.Size = New System.Drawing.Size(152, 22)
        Me.CTXInformacoes.Text = "Information"
        '
        'Fmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 323)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.btnBrowser)
        Me.Controls.Add(Me.LvDownloads)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txturl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SoundCloud Downloader v0.1 | BY X-SLAYER"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTX.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txturl As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtLocal As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowser As System.Windows.Forms.Button
    Friend WithEvents LvDownloads As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CTX As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CTXInformacoes As System.Windows.Forms.ToolStripMenuItem

End Class
