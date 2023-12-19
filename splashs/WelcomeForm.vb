Public Class WelcomeForm
    Private Sub BtnLoginSignup_Click(sender As Object, e As EventArgs) Handles BtnLoginSignup.Click
        OpenForm3()
    End Sub
    Private Sub OpenForm3()
        ' Create an instance of Form3 and show it
        Dim LoginScreenForm As New LoginScreenForm()
        LoginScreenForm.Show()

        ' Optionally, you can hide the current form if needed
        Me.Hide()
    End Sub
End Class