<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingScreen
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingScreen))
        ALProgBar = New ProgressBar()
        LBLLoading = New Label()
        Label2 = New Label()
        ALTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' ALProgBar
        ' 
        ALProgBar.BackColor = Color.White
        ALProgBar.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(106))
        ALProgBar.Location = New Point(173, 517)
        ALProgBar.Name = "ALProgBar"
        ALProgBar.Size = New Size(953, 49)
        ALProgBar.Style = ProgressBarStyle.Continuous
        ALProgBar.TabIndex = 0
        ' 
        ' LBLLoading
        ' 
        LBLLoading.AutoSize = True
        LBLLoading.BackColor = Color.FromArgb(CByte(179), CByte(199), CByte(209))
        LBLLoading.Font = New Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLLoading.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(106))
        LBLLoading.Location = New Point(559, 580)
        LBLLoading.Name = "LBLLoading"
        LBLLoading.RightToLeft = RightToLeft.No
        LBLLoading.Size = New Size(138, 32)
        LBLLoading.TabIndex = 1
        LBLLoading.Text = "Loading..."
        LBLLoading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(179), CByte(199), CByte(209))
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(106))
        Label2.Location = New Point(600, 612)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 25)
        Label2.TabIndex = 2
        Label2.Text = "0%"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ALTimer
        ' 
        ' 
        ' LoadingScreen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1280, 720)
        Controls.Add(Label2)
        Controls.Add(LBLLoading)
        Controls.Add(ALProgBar)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "LoadingScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoadingScreen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ALProgBar As ProgressBar
    Friend WithEvents LBLLoading As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ALTimer As Timer
End Class
