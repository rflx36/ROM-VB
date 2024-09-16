<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUILogin
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
        PictureBox1 = New PictureBox()
        ErrorDisplay = New Label()
        LogIn = New Button()
        PasswordLabel = New Label()
        UsernameLabel = New Label()
        Password = New TextBox()
        Username = New TextBox()
        ProjectTitle = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.AdminUILogin
        PictureBox1.Location = New Point(793, 89)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(437, 532)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ErrorDisplay
        ' 
        ErrorDisplay.BackColor = Color.FromArgb(CByte(255), CByte(227), CByte(211))
        ErrorDisplay.Font = New Font("Candara", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        ErrorDisplay.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        ErrorDisplay.Location = New Point(793, 404)
        ErrorDisplay.MinimumSize = New Size(400, 0)
        ErrorDisplay.Name = "ErrorDisplay"
        ErrorDisplay.Size = New Size(437, 13)
        ErrorDisplay.TabIndex = 9
        ErrorDisplay.Text = "Display Error Text Here"
        ErrorDisplay.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LogIn
        ' 
        LogIn.BackColor = Color.FromArgb(CByte(255), CByte(227), CByte(211))
        LogIn.Cursor = Cursors.Hand
        LogIn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(236), CByte(220))
        LogIn.FlatAppearance.BorderSize = 0
        LogIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(227), CByte(211))
        LogIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(227), CByte(211))
        LogIn.FlatStyle = FlatStyle.Flat
        LogIn.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LogIn.ForeColor = Color.White
        LogIn.Image = My.Resources.Resources.LoginButton
        LogIn.Location = New Point(841, 473)
        LogIn.Name = "LogIn"
        LogIn.Size = New Size(330, 80)
        LogIn.TabIndex = 8
        LogIn.UseVisualStyleBackColor = False
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = Color.FromArgb(CByte(255), CByte(227), CByte(211))
        PasswordLabel.Font = New Font("Candara", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        PasswordLabel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        PasswordLabel.Location = New Point(879, 338)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(53, 13)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "Password"
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = Color.FromArgb(CByte(255), CByte(227), CByte(211))
        UsernameLabel.Font = New Font("Candara", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        UsernameLabel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        UsernameLabel.Location = New Point(879, 263)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(55, 13)
        UsernameLabel.TabIndex = 6
        UsernameLabel.Text = "Username"
        ' 
        ' Password
        ' 
        Password.BackColor = Color.White
        Password.BorderStyle = BorderStyle.None
        Password.Cursor = Cursors.IBeam
        Password.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Password.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        Password.Location = New Point(890, 367)
        Password.Name = "Password"
        Password.PasswordChar = "●"c
        Password.Size = New Size(260, 19)
        Password.TabIndex = 11
        ' 
        ' Username
        ' 
        Username.BackColor = Color.White
        Username.BorderStyle = BorderStyle.None
        Username.Cursor = Cursors.IBeam
        Username.Font = New Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Username.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        Username.Location = New Point(890, 292)
        Username.Name = "Username"
        Username.Size = New Size(260, 20)
        Username.TabIndex = 10
        ' 
        ' ProjectTitle
        ' 
        ProjectTitle.AutoSize = True
        ProjectTitle.Font = New Font("Candara", 50F, FontStyle.Bold, GraphicsUnit.Point)
        ProjectTitle.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        ProjectTitle.Location = New Point(48, 171)
        ProjectTitle.Name = "ProjectTitle"
        ProjectTitle.Size = New Size(472, 246)
        ProjectTitle.TabIndex = 12
        ProjectTitle.Text = "RESTAURANT " & vbCrLf & "ORDERING" & vbCrLf & "MANAGEMENT" & vbCrLf
        ' 
        ' AdminUILogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 720)
        Controls.Add(ProjectTitle)
        Controls.Add(Password)
        Controls.Add(Username)
        Controls.Add(ErrorDisplay)
        Controls.Add(LogIn)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1280, 720)
        Name = "AdminUILogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminUILogin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorDisplay As Label
    Friend WithEvents LogIn As Button
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents ProjectTitle As Label
End Class
