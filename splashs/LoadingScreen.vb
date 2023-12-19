
Public Class LoadingScreen
    Dim progressValue As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ALTimer.Tick

        progressValue += 5


        If progressValue > ALProgBar.Maximum Then
            progressValue = ALProgBar.Maximum
        End If


        ALProgBar.Value = progressValue


        Label2.Text = progressValue & " %"


        If progressValue = ALProgBar.Maximum Then

            ALTimer.Stop()


            LBLLoading.Text = "Loaded Successfully"


            LBLLoading.Refresh()


            MessageBox.Show("Loaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            LBLLoading.Visible = False


            Dim form2Instance As New LoginScreenForm()


            form2Instance.Show()


            Me.WindowState = FormWindowState.Minimized


        End If

    End Sub


    Private Sub LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial values in code
        progressValue = 0
        ALProgBar.Value = progressValue
        ALProgBar.Maximum = 100
        LBLLoading.Text = "Loading..."
        ALTimer.Interval = 100
        ALTimer.Start()
    End Sub


End Class