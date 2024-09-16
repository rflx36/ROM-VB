<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeUILogin
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
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        Username = New TextBox()
        Password = New TextBox()
        LogIn = New Button()
        ErrorDisplay = New Label()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(220))
        UsernameLabel.Font = New Font("Candara", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        UsernameLabel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        UsernameLabel.Location = New Point(513, 247)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(55, 13)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Username"
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(220))
        PasswordLabel.Font = New Font("Candara", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        PasswordLabel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        PasswordLabel.Location = New Point(513, 322)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(53, 13)
        PasswordLabel.TabIndex = 1
        PasswordLabel.Text = "Password"
        ' 
        ' Username
        ' 
        Username.BackColor = Color.White
        Username.BorderStyle = BorderStyle.None
        Username.Cursor = Cursors.IBeam
        Username.Font = New Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Username.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        Username.Location = New Point(522, 275)
        Username.Name = "Username"
        Username.Size = New Size(260, 20)
        Username.TabIndex = 2
        ' 
        ' Password
        ' 
        Password.BackColor = Color.White
        Password.BorderStyle = BorderStyle.None
        Password.Cursor = Cursors.IBeam
        Password.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Password.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        Password.Location = New Point(522, 350)
        Password.Name = "Password"
        Password.PasswordChar = "●"c
        Password.Size = New Size(260, 19)
        Password.TabIndex = 3
        ' 
        ' LogIn
        ' 
        LogIn.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(220))
        LogIn.Cursor = Cursors.Hand
        LogIn.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(236), CByte(220))
        LogIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(236), CByte(220))
        LogIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(236), CByte(220))
        LogIn.FlatStyle = FlatStyle.Flat
        LogIn.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LogIn.ForeColor = Color.White
        LogIn.Image = My.Resources.Resources.LoginButton
        LogIn.Location = New Point(475, 453)
        LogIn.Name = "LogIn"
        LogIn.Size = New Size(330, 80)
        LogIn.TabIndex = 4
        LogIn.UseVisualStyleBackColor = False
        ' 
        ' ErrorDisplay
        ' 
        ErrorDisplay.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(220))
        ErrorDisplay.Font = New Font("Candara", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        ErrorDisplay.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        ErrorDisplay.Location = New Point(359, 384)
        ErrorDisplay.MinimumSize = New Size(400, 0)
        ErrorDisplay.Name = "ErrorDisplay"
        ErrorDisplay.Size = New Size(555, 13)
        ErrorDisplay.TabIndex = 5
        ErrorDisplay.Text = "Display Error Text Here"
        ErrorDisplay.TextAlign = ContentAlignment.TopCenter
        ' 
        ' EmployeeUILogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.EmployeeUILogin
        ClientSize = New Size(1280, 720)
        Controls.Add(ErrorDisplay)
        Controls.Add(LogIn)
        Controls.Add(Password)
        Controls.Add(Username)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1280, 720)
        Name = "EmployeeUILogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EmployeeUILogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents LogIn As Button
    Friend WithEvents ErrorDisplay As Label
End Class
