<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerUIOrder
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
        Label1 = New Label()
        OrderListPanel = New Panel()
        Back1 = New Button()
        Back2 = New Label()
        TotalPriceLabel = New Label()
        TotalAmountLabel = New Label()
        CheckOutButton = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 35F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 55)
        Label1.TabIndex = 0
        Label1.Text = "My Order List"
        ' 
        ' OrderListPanel
        ' 
        OrderListPanel.Location = New Point(28, 84)
        OrderListPanel.Name = "OrderListPanel"
        OrderListPanel.Size = New Size(900, 640)
        OrderListPanel.TabIndex = 1
        ' 
        ' Back1
        ' 
        Back1.BackgroundImage = My.Resources.Resources.IconBack
        Back1.BackgroundImageLayout = ImageLayout.Center
        Back1.Cursor = Cursors.Hand
        Back1.FlatAppearance.BorderColor = Color.White
        Back1.FlatAppearance.BorderSize = 0
        Back1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(193), CByte(158))
        Back1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(193), CByte(158))
        Back1.FlatStyle = FlatStyle.Flat
        Back1.Location = New Point(923, 18)
        Back1.MinimumSize = New Size(50, 30)
        Back1.Name = "Back1"
        Back1.Size = New Size(144, 30)
        Back1.TabIndex = 119
        Back1.UseVisualStyleBackColor = True
        ' 
        ' Back2
        ' 
        Back2.AutoSize = True
        Back2.Cursor = Cursors.Hand
        Back2.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Back2.ForeColor = Color.White
        Back2.Location = New Point(1064, 18)
        Back2.Name = "Back2"
        Back2.Size = New Size(191, 32)
        Back2.TabIndex = 120
        Back2.Text = "Back to Menu"
        ' 
        ' TotalPriceLabel
        ' 
        TotalPriceLabel.AutoSize = True
        TotalPriceLabel.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point)
        TotalPriceLabel.ForeColor = Color.White
        TotalPriceLabel.Location = New Point(54, 451)
        TotalPriceLabel.MinimumSize = New Size(300, 0)
        TotalPriceLabel.Name = "TotalPriceLabel"
        TotalPriceLabel.Size = New Size(300, 56)
        TotalPriceLabel.TabIndex = 121
        TotalPriceLabel.Text = "₱000.00"
        TotalPriceLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TotalAmountLabel
        ' 
        TotalAmountLabel.AutoSize = True
        TotalAmountLabel.Font = New Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point)
        TotalAmountLabel.ForeColor = Color.White
        TotalAmountLabel.Location = New Point(130, 427)
        TotalAmountLabel.Name = "TotalAmountLabel"
        TotalAmountLabel.Size = New Size(148, 24)
        TotalAmountLabel.TabIndex = 122
        TotalAmountLabel.Text = " Total Amount:"
        ' 
        ' CheckOutButton
        ' 
        CheckOutButton.Cursor = Cursors.Hand
        CheckOutButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(193), CByte(158))
        CheckOutButton.FlatAppearance.BorderSize = 0
        CheckOutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(193), CByte(158))
        CheckOutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(193), CByte(158))
        CheckOutButton.FlatStyle = FlatStyle.Flat
        CheckOutButton.Font = New Font("Candara", 24F, FontStyle.Bold, GraphicsUnit.Point)
        CheckOutButton.ForeColor = Color.FromArgb(CByte(255), CByte(193), CByte(158))
        CheckOutButton.Image = My.Resources.Resources.ButtonCheckOut
        CheckOutButton.Location = New Point(54, 532)
        CheckOutButton.Name = "CheckOutButton"
        CheckOutButton.Size = New Size(300, 90)
        CheckOutButton.TabIndex = 123
        CheckOutButton.Text = "Checkout"
        CheckOutButton.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TotalPriceLabel)
        Panel1.Controls.Add(CheckOutButton)
        Panel1.Controls.Add(TotalAmountLabel)
        Panel1.Location = New Point(907, 84)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(372, 646)
        Panel1.TabIndex = 124
        ' 
        ' CustomerUIOrder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(158))
        ClientSize = New Size(1280, 720)
        Controls.Add(Panel1)
        Controls.Add(Back2)
        Controls.Add(Back1)
        Controls.Add(OrderListPanel)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1280, 720)
        Name = "CustomerUIOrder"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "CustomerUIOrder"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents OrderListPanel As Panel
    Friend WithEvents Back1 As Button
    Friend WithEvents Back2 As Label
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents TotalAmountLabel As Label
    Friend WithEvents CheckOutButton As Button
    Friend WithEvents Panel1 As Panel
End Class
