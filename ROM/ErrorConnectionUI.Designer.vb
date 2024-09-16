<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorConnectionUI
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
        ErrorText = New Label()
        Button1 = New Button()
        ErrorDisplay = New Label()
        SuspendLayout()
        ' 
        ' ErrorText
        ' 
        ErrorText.AutoSize = True
        ErrorText.Font = New Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.Point)
        ErrorText.ForeColor = Color.White
        ErrorText.Location = New Point(328, 279)
        ErrorText.Name = "ErrorText"
        ErrorText.Size = New Size(635, 89)
        ErrorText.TabIndex = 0
        ErrorText.Text = "Error Connecting :("
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(206), CByte(97), CByte(97))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(228), CByte(114), CByte(114))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(572, 384)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 55)
        Button1.TabIndex = 1
        Button1.Text = "Reconnect"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ErrorDisplay
        ' 
        ErrorDisplay.AutoSize = True
        ErrorDisplay.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ErrorDisplay.ForeColor = Color.White
        ErrorDisplay.Location = New Point(1, 451)
        ErrorDisplay.MinimumSize = New Size(1280, 10)
        ErrorDisplay.Name = "ErrorDisplay"
        ErrorDisplay.Size = New Size(1280, 19)
        ErrorDisplay.TabIndex = 2
        ErrorDisplay.Text = "Error Display Here"
        ErrorDisplay.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ErrorConnectionUI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(228), CByte(114), CByte(114))
        ClientSize = New Size(1280, 720)
        Controls.Add(ErrorDisplay)
        Controls.Add(Button1)
        Controls.Add(ErrorText)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1280, 720)
        Name = "ErrorConnectionUI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ErrorConnectionUI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ErrorText As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorDisplay As Label
End Class
