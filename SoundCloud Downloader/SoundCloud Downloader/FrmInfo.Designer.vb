<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfo))
        Me.Avatar = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.title = New System.Windows.Forms.Label()
        Me.size = New System.Windows.Forms.Label()
        Me.created = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.Label()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Avatar
        '
        Me.Avatar.Image = CType(resources.GetObject("Avatar.Image"), System.Drawing.Image)
        Me.Avatar.Location = New System.Drawing.Point(2, 4)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(158, 99)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar.TabIndex = 0
        Me.Avatar.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(166, 4)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 15)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Information :"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(166, 24)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(42, 14)
        Me.title.TabIndex = 2
        Me.title.Text = "-Title : "
        '
        'size
        '
        Me.size.AutoSize = True
        Me.size.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.size.Location = New System.Drawing.Point(166, 43)
        Me.size.Name = "size"
        Me.size.Size = New System.Drawing.Size(40, 14)
        Me.size.TabIndex = 3
        Me.size.Text = "-Size : "
        '
        'created
        '
        Me.created.AutoSize = True
        Me.created.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.created.Location = New System.Drawing.Point(166, 62)
        Me.created.Name = "created"
        Me.created.Size = New System.Drawing.Size(73, 14)
        Me.created.TabIndex = 4
        Me.created.Text = "-Created AT : "
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(167, 81)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(76, 14)
        Me.user.TabIndex = 5
        Me.user.Text = "-User Name : "
        '
        'FrmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 104)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.created)
        Me.Controls.Add(Me.size)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Avatar)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Information"
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Avatar As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents size As System.Windows.Forms.Label
    Friend WithEvents created As System.Windows.Forms.Label
    Friend WithEvents user As System.Windows.Forms.Label
End Class
