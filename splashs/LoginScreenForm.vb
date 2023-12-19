Public Class LoginScreenForm

    Private Sub SetControlOpacity(control As Control, opacity As Single)

        If TypeOf control Is Button Then
            Dim button As Button = DirectCast(control, Button)
            button.ForeColor = Color.FromArgb(CInt(opacity * 255), button.ForeColor)
        ElseIf TypeOf control Is Label Then
            Dim label As Label = DirectCast(control, Label)
            label.ForeColor = Color.FromArgb(CInt(opacity * 255), label.ForeColor)
        ElseIf TypeOf control Is TextBox Then
            Dim textBox As TextBox = DirectCast(control, TextBox)
            textBox.ForeColor = Color.FromArgb(CInt(opacity * 255), textBox.ForeColor)
        End If

    End Sub

    Private Sub SetPanelOpacity(panel As Panel, opacity As Single)

        panel.BackColor = Color.FromArgb(opacity * 255, panel.BackColor)

        ' Set the opacity for each control inside the panel
        For Each control As Control In panel.Controls
            SetControlOpacity(control, opacity)
        Next

    End Sub

    Private Sub LoadingScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel_Login.Visible = True
        Panel_Register.Visible = False
        SetPanelOpacity(PNLloginSignup, 0.3F)

    End Sub

    Private Sub SetButtonStyle(button As Button)

        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0

    End Sub
    Private Sub BTNGoToLogin_Click(sender As Object, e As EventArgs) Handles BTNGoToLogin.Click

        Panel_Login.Visible = True
        Panel_Register.Visible = False


        SetButtonStyle(BTNGoToLogin)

        SetPanelOpacity(Panel_Login, 0.3)

        BTNGoToLogin.BackColor = Color.FromArgb(CInt(0.3 * 255), BTNGoToLogin.BackColor)

        BTNGoToRegister.BackColor = Color.FromArgb(CInt(1.0 * 255), BTNGoToRegister.BackColor)

    End Sub

    Private Sub BTNGoToRegister_Click(sender As Object, e As EventArgs) Handles BTNGoToRegister.Click

        Panel_Login.Visible = False
        Panel_Register.Visible = True

        SetButtonStyle(BTNGoToRegister)

        SetPanelOpacity(Panel_Register, 0.3)

        BTNGoToRegister.BackColor = Color.FromArgb(CInt(0.3 * 255), BTNGoToRegister.BackColor)

        BTNGoToLogin.BackColor = Color.FromArgb(CInt(1.0 * 255), BTNGoToLogin.BackColor)

    End Sub


    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BTNRegister.Click

        Dim registrationForm As New MainMenuForm()

        MainMenuForm.Show()
        Me.Hide()

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click

        Dim form4 As New MainMenuForm()

        form4.Show()
        Me.Hide()

    End Sub

End Class