<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeForm))
        BtnLoginSignup = New Button()
        SuspendLayout()
        ' 
        ' BtnLoginSignup
        ' 
        BtnLoginSignup.BackColor = SystemColors.ControlLightLight
        BtnLoginSignup.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnLoginSignup.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(106))
        BtnLoginSignup.Location = New Point(1094, 12)
        BtnLoginSignup.Name = "BtnLoginSignup"
        BtnLoginSignup.Size = New Size(165, 35)
        BtnLoginSignup.TabIndex = 0
        BtnLoginSignup.Text = "Log in / Sign up"
        BtnLoginSignup.UseVisualStyleBackColor = False
        ' 
        ' WelcomeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1280, 720)
        Controls.Add(BtnLoginSignup)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "WelcomeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnLoginSignup As Button
End Class
