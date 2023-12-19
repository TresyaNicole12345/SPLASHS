<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginScreenForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginScreenForm))
        PNLloginSignup = New Panel()
        Panel_Login = New Panel()
        BTNLogin = New Button()
        TXTPassword = New TextBox()
        TXTEmail = New TextBox()
        PBPassword = New PictureBox()
        PBEmail = New PictureBox()
        Label1 = New Label()
        BTNGoToRegister = New Button()
        BTNGoToLogin = New Button()
        Panel_Register = New Panel()
        LBLRetypeReg = New Label()
        LBLPassReg = New Label()
        TXTRetypeReg = New TextBox()
        TXTPassReg = New TextBox()
        LBLMailReg = New Label()
        BTNRegister = New Button()
        TXTMail = New TextBox()
        Label2 = New Label()
        PNLloginSignup.SuspendLayout()
        Panel_Login.SuspendLayout()
        CType(PBPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBEmail, ComponentModel.ISupportInitialize).BeginInit()
        Panel_Register.SuspendLayout()
        SuspendLayout()
        ' 
        ' PNLloginSignup
        ' 
        PNLloginSignup.BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(106))
        PNLloginSignup.Controls.Add(Panel_Login)
        PNLloginSignup.Controls.Add(Panel_Register)
        PNLloginSignup.Controls.Add(BTNGoToRegister)
        PNLloginSignup.Controls.Add(BTNGoToLogin)
        PNLloginSignup.Location = New Point(72, 59)
        PNLloginSignup.Name = "PNLloginSignup"
        PNLloginSignup.Size = New Size(540, 510)
        PNLloginSignup.TabIndex = 0
        ' 
        ' Panel_Login
        ' 
        Panel_Login.BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(106))
        Panel_Login.Controls.Add(BTNLogin)
        Panel_Login.Controls.Add(TXTPassword)
        Panel_Login.Controls.Add(TXTEmail)
        Panel_Login.Controls.Add(PBPassword)
        Panel_Login.Controls.Add(PBEmail)
        Panel_Login.Controls.Add(Label1)
        Panel_Login.Location = New Point(0, 129)
        Panel_Login.Name = "Panel_Login"
        Panel_Login.Size = New Size(534, 375)
        Panel_Login.TabIndex = 1
        ' 
        ' BTNLogin
        ' 
        BTNLogin.BackColor = Color.White
        BTNLogin.FlatStyle = FlatStyle.Popup
        BTNLogin.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNLogin.Location = New Point(141, 303)
        BTNLogin.Name = "BTNLogin"
        BTNLogin.Size = New Size(277, 41)
        BTNLogin.TabIndex = 4
        BTNLogin.Text = "Log In"
        BTNLogin.UseVisualStyleBackColor = False
        ' 
        ' TXTPassword
        ' 
        TXTPassword.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTPassword.Location = New Point(84, 124)
        TXTPassword.Name = "TXTPassword"
        TXTPassword.Size = New Size(401, 34)
        TXTPassword.TabIndex = 3
        ' 
        ' TXTEmail
        ' 
        TXTEmail.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTEmail.Location = New Point(84, 29)
        TXTEmail.Name = "TXTEmail"
        TXTEmail.Size = New Size(401, 34)
        TXTEmail.TabIndex = 1
        ' 
        ' PBPassword
        ' 
        PBPassword.BackColor = Color.Transparent
        PBPassword.Image = CType(resources.GetObject("PBPassword.Image"), Image)
        PBPassword.Location = New Point(22, 124)
        PBPassword.Name = "PBPassword"
        PBPassword.Size = New Size(49, 33)
        PBPassword.SizeMode = PictureBoxSizeMode.StretchImage
        PBPassword.TabIndex = 2
        PBPassword.TabStop = False
        ' 
        ' PBEmail
        ' 
        PBEmail.BackColor = Color.Transparent
        PBEmail.Image = CType(resources.GetObject("PBEmail.Image"), Image)
        PBEmail.Location = New Point(22, 23)
        PBEmail.Name = "PBEmail"
        PBEmail.Size = New Size(49, 40)
        PBEmail.SizeMode = PictureBoxSizeMode.StretchImage
        PBEmail.TabIndex = 1
        PBEmail.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 1
        ' 
        ' BTNGoToRegister
        ' 
        BTNGoToRegister.BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(106))
        BTNGoToRegister.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(56), CByte(76))
        BTNGoToRegister.FlatStyle = FlatStyle.Flat
        BTNGoToRegister.Font = New Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNGoToRegister.ForeColor = SystemColors.Control
        BTNGoToRegister.Location = New Point(255, 0)
        BTNGoToRegister.Name = "BTNGoToRegister"
        BTNGoToRegister.Size = New Size(282, 123)
        BTNGoToRegister.TabIndex = 2
        BTNGoToRegister.Text = "Sign Up"
        BTNGoToRegister.UseVisualStyleBackColor = False
        ' 
        ' BTNGoToLogin
        ' 
        BTNGoToLogin.BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(106))
        BTNGoToLogin.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(56), CByte(76))
        BTNGoToLogin.FlatStyle = FlatStyle.Flat
        BTNGoToLogin.Font = New Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNGoToLogin.ForeColor = SystemColors.Control
        BTNGoToLogin.Location = New Point(3, 3)
        BTNGoToLogin.Name = "BTNGoToLogin"
        BTNGoToLogin.Size = New Size(254, 123)
        BTNGoToLogin.TabIndex = 1
        BTNGoToLogin.Text = "Log in"
        BTNGoToLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel_Register
        ' 
        Panel_Register.BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(106))
        Panel_Register.Controls.Add(LBLRetypeReg)
        Panel_Register.Controls.Add(LBLPassReg)
        Panel_Register.Controls.Add(TXTRetypeReg)
        Panel_Register.Controls.Add(TXTPassReg)
        Panel_Register.Controls.Add(LBLMailReg)
        Panel_Register.Controls.Add(BTNRegister)
        Panel_Register.Controls.Add(TXTMail)
        Panel_Register.Controls.Add(Label2)
        Panel_Register.Location = New Point(0, 129)
        Panel_Register.Name = "Panel_Register"
        Panel_Register.Size = New Size(537, 378)
        Panel_Register.TabIndex = 2
        ' 
        ' LBLRetypeReg
        ' 
        LBLRetypeReg.AutoSize = True
        LBLRetypeReg.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLRetypeReg.ForeColor = SystemColors.ButtonHighlight
        LBLRetypeReg.Location = New Point(32, 142)
        LBLRetypeReg.Name = "LBLRetypeReg"
        LBLRetypeReg.Size = New Size(70, 19)
        LBLRetypeReg.TabIndex = 5
        LBLRetypeReg.Text = "Re-Type"
        ' 
        ' LBLPassReg
        ' 
        LBLPassReg.AutoSize = True
        LBLPassReg.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLPassReg.ForeColor = SystemColors.ButtonFace
        LBLPassReg.Location = New Point(22, 83)
        LBLPassReg.Name = "LBLPassReg"
        LBLPassReg.Size = New Size(80, 19)
        LBLPassReg.TabIndex = 4
        LBLPassReg.Text = "Password"
        ' 
        ' TXTRetypeReg
        ' 
        TXTRetypeReg.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTRetypeReg.Location = New Point(104, 136)
        TXTRetypeReg.Name = "TXTRetypeReg"
        TXTRetypeReg.Size = New Size(402, 25)
        TXTRetypeReg.TabIndex = 3
        ' 
        ' TXTPassReg
        ' 
        TXTPassReg.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTPassReg.Location = New Point(104, 80)
        TXTPassReg.Name = "TXTPassReg"
        TXTPassReg.Size = New Size(402, 25)
        TXTPassReg.TabIndex = 2
        ' 
        ' LBLMailReg
        ' 
        LBLMailReg.AutoSize = True
        LBLMailReg.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLMailReg.ForeColor = SystemColors.ButtonFace
        LBLMailReg.Location = New Point(49, 32)
        LBLMailReg.Name = "LBLMailReg"
        LBLMailReg.Size = New Size(49, 19)
        LBLMailReg.TabIndex = 0
        LBLMailReg.Text = "Email"
        ' 
        ' BTNRegister
        ' 
        BTNRegister.BackColor = Color.White
        BTNRegister.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        BTNRegister.FlatStyle = FlatStyle.Popup
        BTNRegister.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNRegister.ForeColor = SystemColors.ControlText
        BTNRegister.Location = New Point(138, 286)
        BTNRegister.Name = "BTNRegister"
        BTNRegister.Size = New Size(287, 41)
        BTNRegister.TabIndex = 1
        BTNRegister.Text = "Register"
        BTNRegister.UseVisualStyleBackColor = False
        ' 
        ' TXTMail
        ' 
        TXTMail.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTMail.Location = New Point(104, 29)
        TXTMail.Name = "TXTMail"
        TXTMail.Size = New Size(402, 25)
        TXTMail.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 1
        ' 
        ' LoginScreenForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(76))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1280, 720)
        Controls.Add(PNLloginSignup)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginScreenForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        PNLloginSignup.ResumeLayout(False)
        Panel_Login.ResumeLayout(False)
        Panel_Login.PerformLayout()
        CType(PBPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(PBEmail, ComponentModel.ISupportInitialize).EndInit()
        Panel_Register.ResumeLayout(False)
        Panel_Register.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PNLloginSignup As Panel
    Friend WithEvents Panel_Login As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNGoToRegister As Button
    Friend WithEvents BTNGoToLogin As Button
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents TXTEmail As TextBox
    Friend WithEvents PBPassword As PictureBox
    Friend WithEvents PBEmail As PictureBox
    Friend WithEvents Panel_Register As Panel
    Friend WithEvents BTNRegister As Button
    Friend WithEvents TXTMail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LBLRetypeReg As Label
    Friend WithEvents LBLPassReg As Label
    Friend WithEvents TXTRetypeReg As TextBox
    Friend WithEvents TXTPassReg As TextBox
    Friend WithEvents LBLMailReg As Label
    Friend WithEvents BTNLogin As Button
End Class
