<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        DataGridView1 = New DataGridView()
        RBtnOneway = New RadioButton()
        RBtnRountrip = New RadioButton()
        TXTChildren = New TextBox()
        TXTFrom = New TextBox()
        TXTAdults = New TextBox()
        TXTTo = New TextBox()
        TXTDepart = New TextBox()
        TxtReturn = New TextBox()
        TXTInfant = New TextBox()
        Button1 = New Button()
        BtnAdd = New Button()
        BtnEdit = New Button()
        BtnSave = New Button()
        PBNexttoGuest = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBNexttoGuest, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Black
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(210, 476)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1033, 117)
        DataGridView1.TabIndex = 0
        ' 
        ' RBtnOneway
        ' 
        RBtnOneway.AutoSize = True
        RBtnOneway.Location = New Point(428, 163)
        RBtnOneway.Name = "RBtnOneway"
        RBtnOneway.Size = New Size(17, 16)
        RBtnOneway.TabIndex = 1
        RBtnOneway.TabStop = True
        RBtnOneway.UseVisualStyleBackColor = True
        ' 
        ' RBtnRountrip
        ' 
        RBtnRountrip.AutoSize = True
        RBtnRountrip.Location = New Point(602, 163)
        RBtnRountrip.Name = "RBtnRountrip"
        RBtnRountrip.Size = New Size(17, 16)
        RBtnRountrip.TabIndex = 2
        RBtnRountrip.TabStop = True
        RBtnRountrip.UseVisualStyleBackColor = True
        ' 
        ' TXTChildren
        ' 
        TXTChildren.Location = New Point(621, 335)
        TXTChildren.Name = "TXTChildren"
        TXTChildren.Size = New Size(191, 27)
        TXTChildren.TabIndex = 3
        ' 
        ' TXTFrom
        ' 
        TXTFrom.Location = New Point(415, 242)
        TXTFrom.Name = "TXTFrom"
        TXTFrom.Size = New Size(182, 27)
        TXTFrom.TabIndex = 4
        ' 
        ' TXTAdults
        ' 
        TXTAdults.Location = New Point(415, 335)
        TXTAdults.Name = "TXTAdults"
        TXTAdults.Size = New Size(182, 27)
        TXTAdults.TabIndex = 5
        ' 
        ' TXTTo
        ' 
        TXTTo.Location = New Point(621, 242)
        TXTTo.Name = "TXTTo"
        TXTTo.Size = New Size(210, 27)
        TXTTo.TabIndex = 6
        ' 
        ' TXTDepart
        ' 
        TXTDepart.Location = New Point(829, 335)
        TXTDepart.Name = "TXTDepart"
        TXTDepart.Size = New Size(193, 27)
        TXTDepart.TabIndex = 7
        ' 
        ' TxtReturn
        ' 
        TxtReturn.Location = New Point(1062, 242)
        TxtReturn.Name = "TxtReturn"
        TxtReturn.Size = New Size(137, 27)
        TxtReturn.TabIndex = 8
        ' 
        ' TXTInfant
        ' 
        TXTInfant.Location = New Point(847, 242)
        TXTInfant.Name = "TXTInfant"
        TXTInfant.Size = New Size(193, 27)
        TXTInfant.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(1131, 441)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 10
        Button1.Text = "LOAD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BtnAdd.FlatAppearance.BorderColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BtnAdd.FlatStyle = FlatStyle.Flat
        BtnAdd.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAdd.ForeColor = SystemColors.Control
        BtnAdd.Location = New Point(245, 631)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(94, 29)
        BtnAdd.TabIndex = 11
        BtnAdd.Text = "ADD"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' BtnEdit
        ' 
        BtnEdit.BackColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BtnEdit.FlatAppearance.BorderColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BtnEdit.FlatStyle = FlatStyle.Flat
        BtnEdit.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEdit.ForeColor = SystemColors.Control
        BtnEdit.Location = New Point(465, 631)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(94, 29)
        BtnEdit.TabIndex = 12
        BtnEdit.Text = "EDIT"
        BtnEdit.UseVisualStyleBackColor = False
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BtnSave.FlatAppearance.BorderColor = Color.FromArgb(CByte(81), CByte(121), CByte(153))
        BtnSave.FlatStyle = FlatStyle.Flat
        BtnSave.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSave.ForeColor = SystemColors.Control
        BtnSave.Location = New Point(692, 631)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(94, 29)
        BtnSave.TabIndex = 13
        BtnSave.Text = "SAVE"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' PBNexttoGuest
        ' 
        PBNexttoGuest.BackColor = Color.Transparent
        PBNexttoGuest.Image = CType(resources.GetObject("PBNexttoGuest.Image"), Image)
        PBNexttoGuest.Location = New Point(1105, 648)
        PBNexttoGuest.Name = "PBNexttoGuest"
        PBNexttoGuest.Size = New Size(82, 49)
        PBNexttoGuest.SizeMode = PictureBoxSizeMode.StretchImage
        PBNexttoGuest.TabIndex = 14
        PBNexttoGuest.TabStop = False
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1280, 720)
        Controls.Add(PBNexttoGuest)
        Controls.Add(BtnSave)
        Controls.Add(BtnEdit)
        Controls.Add(BtnAdd)
        Controls.Add(Button1)
        Controls.Add(TXTInfant)
        Controls.Add(TxtReturn)
        Controls.Add(TXTDepart)
        Controls.Add(TXTTo)
        Controls.Add(TXTAdults)
        Controls.Add(TXTFrom)
        Controls.Add(TXTChildren)
        Controls.Add(RBtnRountrip)
        Controls.Add(RBtnOneway)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegistrationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PBNexttoGuest, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RBtnOneway As RadioButton
    Friend WithEvents RBtnRountrip As RadioButton
    Friend WithEvents TXTChildren As TextBox
    Friend WithEvents TXTFrom As TextBox
    Friend WithEvents TXTAdults As TextBox
    Friend WithEvents TXTTo As TextBox
    Friend WithEvents TXTDepart As TextBox
    Friend WithEvents TxtReturn As TextBox
    Friend WithEvents TXTInfant As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents PBNexttoGuest As PictureBox
End Class
