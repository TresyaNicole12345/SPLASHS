<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenuForm))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PBLogout = New PictureBox()
        BTNBook = New Button()
        BTNView = New Button()
        BTNCancelbook = New Button()
        BTNLogout = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBLogout, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-5, -13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1314, 742)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-18, -13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(268, 140)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PBLogout
        ' 
        PBLogout.BackColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        PBLogout.Image = CType(resources.GetObject("PBLogout.Image"), Image)
        PBLogout.Location = New Point(746, 430)
        PBLogout.Name = "PBLogout"
        PBLogout.Size = New Size(39, 25)
        PBLogout.SizeMode = PictureBoxSizeMode.StretchImage
        PBLogout.TabIndex = 5
        PBLogout.TabStop = False
        ' 
        ' BTNBook
        ' 
        BTNBook.BackColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BTNBook.FlatAppearance.BorderColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BTNBook.FlatStyle = FlatStyle.Flat
        BTNBook.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNBook.ForeColor = SystemColors.Control
        BTNBook.Location = New Point(248, 0)
        BTNBook.Name = "BTNBook"
        BTNBook.Size = New Size(181, 91)
        BTNBook.TabIndex = 7
        BTNBook.Text = "BOOK"
        BTNBook.UseVisualStyleBackColor = False
        ' 
        ' BTNView
        ' 
        BTNView.BackColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BTNView.FlatAppearance.BorderColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BTNView.FlatStyle = FlatStyle.Flat
        BTNView.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNView.ForeColor = SystemColors.Control
        BTNView.Location = New Point(428, 0)
        BTNView.Name = "BTNView"
        BTNView.Size = New Size(159, 91)
        BTNView.TabIndex = 8
        BTNView.Text = "VIEW"
        BTNView.UseVisualStyleBackColor = False
        ' 
        ' BTNCancelbook
        ' 
        BTNCancelbook.BackColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BTNCancelbook.FlatAppearance.BorderColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BTNCancelbook.FlatStyle = FlatStyle.Flat
        BTNCancelbook.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNCancelbook.ForeColor = SystemColors.Control
        BTNCancelbook.Location = New Point(583, 0)
        BTNCancelbook.Name = "BTNCancelbook"
        BTNCancelbook.Size = New Size(301, 91)
        BTNCancelbook.TabIndex = 9
        BTNCancelbook.Text = "CANCEL BOOKING"
        BTNCancelbook.UseVisualStyleBackColor = False
        ' 
        ' BTNLogout
        ' 
        BTNLogout.BackColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BTNLogout.FlatAppearance.BorderColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BTNLogout.FlatStyle = FlatStyle.Flat
        BTNLogout.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNLogout.Location = New Point(1161, 655)
        BTNLogout.Name = "BTNLogout"
        BTNLogout.Size = New Size(86, 25)
        BTNLogout.TabIndex = 10
        BTNLogout.Text = "LOG OUT"
        BTNLogout.UseVisualStyleBackColor = False
        ' 
        ' MainMenuForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1280, 720)
        Controls.Add(PBLogout)
        Controls.Add(BTNLogout)
        Controls.Add(BTNCancelbook)
        Controls.Add(BTNView)
        Controls.Add(BTNBook)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "MainMenuForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PBLogout, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PBLogout As PictureBox
    Friend WithEvents BTNBook As Button
    Friend WithEvents BTNView As Button
    Friend WithEvents BTNCancelbook As Button
    Friend WithEvents BTNLogout As Button
End Class
