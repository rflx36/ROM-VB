<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerUIOrderPopUp
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
        ButtonPlace = New Button()
        ButtonCancel = New Button()
        TotalPriceLabel = New Label()
        TotalAmountLabel = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        NameTextbox = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonPlace
        ' 
        ButtonPlace.Cursor = Cursors.Hand
        ButtonPlace.FlatAppearance.BorderColor = Color.White
        ButtonPlace.FlatAppearance.MouseDownBackColor = Color.White
        ButtonPlace.FlatAppearance.MouseOverBackColor = Color.White
        ButtonPlace.FlatStyle = FlatStyle.Flat
        ButtonPlace.Font = New Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonPlace.ForeColor = Color.FromArgb(CByte(201), CByte(165), CByte(74))
        ButtonPlace.Image = My.Resources.Resources.PlaceButton
        ButtonPlace.Location = New Point(317, 286)
        ButtonPlace.Name = "ButtonPlace"
        ButtonPlace.Size = New Size(235, 60)
        ButtonPlace.TabIndex = 2
        ButtonPlace.Text = "Confirm Order"
        ButtonPlace.UseVisualStyleBackColor = True
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.Cursor = Cursors.Hand
        ButtonCancel.FlatAppearance.BorderColor = Color.White
        ButtonCancel.FlatAppearance.MouseDownBackColor = Color.White
        ButtonCancel.FlatAppearance.MouseOverBackColor = Color.White
        ButtonCancel.FlatStyle = FlatStyle.Flat
        ButtonCancel.Font = New Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonCancel.ForeColor = Color.Gray
        ButtonCancel.Location = New Point(27, 286)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(120, 60)
        ButtonCancel.TabIndex = 3
        ButtonCancel.Text = "Cancel"
        ButtonCancel.UseVisualStyleBackColor = True
        ' 
        ' TotalPriceLabel
        ' 
        TotalPriceLabel.AutoSize = True
        TotalPriceLabel.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point)
        TotalPriceLabel.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        TotalPriceLabel.Location = New Point(140, 193)
        TotalPriceLabel.MinimumSize = New Size(300, 0)
        TotalPriceLabel.Name = "TotalPriceLabel"
        TotalPriceLabel.Size = New Size(300, 56)
        TotalPriceLabel.TabIndex = 123
        TotalPriceLabel.Text = "₱000.00"
        TotalPriceLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TotalAmountLabel
        ' 
        TotalAmountLabel.AutoSize = True
        TotalAmountLabel.Font = New Font("Candara", 13F, FontStyle.Bold, GraphicsUnit.Point)
        TotalAmountLabel.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        TotalAmountLabel.Location = New Point(223, 171)
        TotalAmountLabel.Name = "TotalAmountLabel"
        TotalAmountLabel.Size = New Size(125, 22)
        TotalAmountLabel.TabIndex = 124
        TotalAmountLabel.Text = " Total Amount:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Candara", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        Label1.Location = New Point(241, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 22)
        Label1.TabIndex = 125
        Label1.Text = "Your name:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(158))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(-5, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(589, 36)
        Panel1.TabIndex = 127
        ' 
        ' NameTextbox
        ' 
        NameTextbox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NameTextbox.BackColor = Color.White
        NameTextbox.BorderStyle = BorderStyle.None
        NameTextbox.Cursor = Cursors.IBeam
        NameTextbox.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        NameTextbox.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        NameTextbox.Location = New Point(133, 90)
        NameTextbox.Margin = New Padding(0)
        NameTextbox.MinimumSize = New Size(145, 30)
        NameTextbox.Multiline = True
        NameTextbox.Name = "NameTextbox"
        NameTextbox.ShortcutsEnabled = False
        NameTextbox.Size = New Size(307, 30)
        NameTextbox.TabIndex = 128
        NameTextbox.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Line
        PictureBox1.Location = New Point(133, 123)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(307, 20)
        PictureBox1.TabIndex = 129
        PictureBox1.TabStop = False
        ' 
        ' CustomerUIOrderPopUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(580, 375)
        Controls.Add(PictureBox1)
        Controls.Add(NameTextbox)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(TotalPriceLabel)
        Controls.Add(TotalAmountLabel)
        Controls.Add(ButtonCancel)
        Controls.Add(ButtonPlace)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(580, 375)
        MinimumSize = New Size(580, 375)
        Name = "CustomerUIOrderPopUp"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "CustomerUIOrderPopUp"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonPlace As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents TotalAmountLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NameTextbox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
