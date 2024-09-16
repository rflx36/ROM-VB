<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuSelectionPopUp
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
        Panel1 = New Panel()
        CloseButton = New Label()
        SelectionLabel = New Label()
        Label2 = New Label()
        PriceLabel = New Label()
        Label4 = New Label()
        AmountLabel = New Label()
        AddOrder = New Label()
        ItemImage = New PictureBox()
        AmountDeduct = New Button()
        AmountAdd = New Button()
        IceCreamLabel = New Label()
        B3_Selection_A = New Label()
        B3_Selection_B = New Label()
        B3_Selection_C = New Label()
        IceCreamPanel = New Panel()
        Panel1.SuspendLayout()
        CType(ItemImage, ComponentModel.ISupportInitialize).BeginInit()
        IceCreamPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(158))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(CloseButton)
        Panel1.Location = New Point(-9, -7)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(542, 37)
        Panel1.TabIndex = 1
        ' 
        ' CloseButton
        ' 
        CloseButton.AutoSize = True
        CloseButton.Cursor = Cursors.Hand
        CloseButton.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CloseButton.ForeColor = Color.White
        CloseButton.Image = My.Resources.Resources.IconClose
        CloseButton.Location = New Point(502, 13)
        CloseButton.MinimumSize = New Size(14, 14)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(14, 17)
        CloseButton.TabIndex = 18
        ' 
        ' SelectionLabel
        ' 
        SelectionLabel.AutoSize = True
        SelectionLabel.Font = New Font("Candara", 30F, FontStyle.Regular, GraphicsUnit.Point)
        SelectionLabel.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        SelectionLabel.Location = New Point(12, 211)
        SelectionLabel.Name = "SelectionLabel"
        SelectionLabel.Size = New Size(211, 49)
        SelectionLabel.TabIndex = 2
        SelectionLabel.Text = "Item Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label2.Location = New Point(21, 274)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 26)
        Label2.TabIndex = 3
        Label2.Text = "Price :"
        ' 
        ' PriceLabel
        ' 
        PriceLabel.AutoSize = True
        PriceLabel.Font = New Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        PriceLabel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        PriceLabel.Location = New Point(21, 300)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New Size(77, 32)
        PriceLabel.TabIndex = 4
        PriceLabel.Text = "₱000"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Candara", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label4.Location = New Point(367, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 23)
        Label4.TabIndex = 5
        Label4.Text = "Amount"
        ' 
        ' AmountLabel
        ' 
        AmountLabel.AutoSize = True
        AmountLabel.Font = New Font("Candara", 20F, FontStyle.Regular, GraphicsUnit.Point)
        AmountLabel.ForeColor = Color.Black
        AmountLabel.Location = New Point(391, 231)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New Size(24, 33)
        AmountLabel.TabIndex = 8
        AmountLabel.Text = "1"
        ' 
        ' AddOrder
        ' 
        AddOrder.AutoSize = True
        AddOrder.Cursor = Cursors.Hand
        AddOrder.Font = New Font("Candara", 16F, FontStyle.Regular, GraphicsUnit.Point)
        AddOrder.ForeColor = Color.FromArgb(CByte(228), CByte(162), CByte(114))
        AddOrder.Image = My.Resources.Resources.Button_Orange
        AddOrder.Location = New Point(293, 282)
        AddOrder.MinimumSize = New Size(210, 50)
        AddOrder.Name = "AddOrder"
        AddOrder.Size = New Size(210, 50)
        AddOrder.TabIndex = 9
        AddOrder.Text = "Add to My Orders"
        AddOrder.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ItemImage
        ' 
        ItemImage.Image = My.Resources.Resources.B3
        ItemImage.Location = New Point(232, 80)
        ItemImage.Name = "ItemImage"
        ItemImage.Size = New Size(55, 120)
        ItemImage.TabIndex = 10
        ItemImage.TabStop = False
        ' 
        ' AmountDeduct
        ' 
        AmountDeduct.BackgroundImage = My.Resources.Resources.Amount_deduct
        AmountDeduct.Cursor = Cursors.Hand
        AmountDeduct.FlatAppearance.BorderColor = Color.White
        AmountDeduct.FlatAppearance.BorderSize = 0
        AmountDeduct.FlatAppearance.MouseDownBackColor = Color.White
        AmountDeduct.FlatAppearance.MouseOverBackColor = Color.White
        AmountDeduct.FlatStyle = FlatStyle.Flat
        AmountDeduct.Location = New Point(330, 231)
        AmountDeduct.Name = "AmountDeduct"
        AmountDeduct.Size = New Size(40, 40)
        AmountDeduct.TabIndex = 11
        AmountDeduct.UseVisualStyleBackColor = True
        ' 
        ' AmountAdd
        ' 
        AmountAdd.BackgroundImage = My.Resources.Resources.Amount_Add
        AmountAdd.Cursor = Cursors.Hand
        AmountAdd.FlatAppearance.BorderColor = Color.White
        AmountAdd.FlatAppearance.BorderSize = 0
        AmountAdd.FlatAppearance.MouseDownBackColor = Color.White
        AmountAdd.FlatAppearance.MouseOverBackColor = Color.White
        AmountAdd.FlatStyle = FlatStyle.Flat
        AmountAdd.Location = New Point(435, 231)
        AmountAdd.Name = "AmountAdd"
        AmountAdd.Size = New Size(40, 40)
        AmountAdd.TabIndex = 12
        AmountAdd.UseVisualStyleBackColor = True
        ' 
        ' IceCreamLabel
        ' 
        IceCreamLabel.AutoSize = True
        IceCreamLabel.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(158))
        IceCreamLabel.Font = New Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point)
        IceCreamLabel.ForeColor = Color.White
        IceCreamLabel.Location = New Point(-6, -1)
        IceCreamLabel.MinimumSize = New Size(150, 0)
        IceCreamLabel.Name = "IceCreamLabel"
        IceCreamLabel.Size = New Size(150, 24)
        IceCreamLabel.TabIndex = 13
        IceCreamLabel.Text = "Flavor"
        IceCreamLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' B3_Selection_A
        ' 
        B3_Selection_A.AutoSize = True
        B3_Selection_A.Cursor = Cursors.Hand
        B3_Selection_A.Font = New Font("Candara", 13F, FontStyle.Regular, GraphicsUnit.Point)
        B3_Selection_A.ForeColor = Color.FromArgb(CByte(228), CByte(162), CByte(114))
        B3_Selection_A.Image = My.Resources.Resources.Ice_Cream_Selection
        B3_Selection_A.Location = New Point(14, 41)
        B3_Selection_A.Margin = New Padding(0)
        B3_Selection_A.MinimumSize = New Size(110, 30)
        B3_Selection_A.Name = "B3_Selection_A"
        B3_Selection_A.Size = New Size(110, 30)
        B3_Selection_A.TabIndex = 14
        B3_Selection_A.Text = "Chocolate"
        B3_Selection_A.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' B3_Selection_B
        ' 
        B3_Selection_B.AutoSize = True
        B3_Selection_B.Cursor = Cursors.Hand
        B3_Selection_B.Font = New Font("Candara", 13F, FontStyle.Regular, GraphicsUnit.Point)
        B3_Selection_B.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        B3_Selection_B.Location = New Point(14, 74)
        B3_Selection_B.Margin = New Padding(0)
        B3_Selection_B.MinimumSize = New Size(110, 30)
        B3_Selection_B.Name = "B3_Selection_B"
        B3_Selection_B.Size = New Size(110, 30)
        B3_Selection_B.TabIndex = 15
        B3_Selection_B.Text = "Strawberry"
        B3_Selection_B.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' B3_Selection_C
        ' 
        B3_Selection_C.AutoSize = True
        B3_Selection_C.Cursor = Cursors.Hand
        B3_Selection_C.Font = New Font("Candara", 13F, FontStyle.Regular, GraphicsUnit.Point)
        B3_Selection_C.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        B3_Selection_C.Location = New Point(14, 107)
        B3_Selection_C.Margin = New Padding(0)
        B3_Selection_C.MinimumSize = New Size(110, 30)
        B3_Selection_C.Name = "B3_Selection_C"
        B3_Selection_C.Size = New Size(110, 30)
        B3_Selection_C.TabIndex = 16
        B3_Selection_C.Text = "Caramel"
        B3_Selection_C.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' IceCreamPanel
        ' 
        IceCreamPanel.BorderStyle = BorderStyle.FixedSingle
        IceCreamPanel.Controls.Add(IceCreamLabel)
        IceCreamPanel.Controls.Add(B3_Selection_C)
        IceCreamPanel.Controls.Add(B3_Selection_A)
        IceCreamPanel.Controls.Add(B3_Selection_B)
        IceCreamPanel.Location = New Point(330, 51)
        IceCreamPanel.Name = "IceCreamPanel"
        IceCreamPanel.Size = New Size(145, 151)
        IceCreamPanel.TabIndex = 17
        ' 
        ' MenuSelectionPopUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(515, 355)
        Controls.Add(IceCreamPanel)
        Controls.Add(AmountAdd)
        Controls.Add(AmountDeduct)
        Controls.Add(ItemImage)
        Controls.Add(AddOrder)
        Controls.Add(AmountLabel)
        Controls.Add(Label4)
        Controls.Add(PriceLabel)
        Controls.Add(Label2)
        Controls.Add(SelectionLabel)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(515, 355)
        MinimumSize = New Size(515, 355)
        Name = "MenuSelectionPopUp"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "MenuSelectionPopUp"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ItemImage, ComponentModel.ISupportInitialize).EndInit()
        IceCreamPanel.ResumeLayout(False)
        IceCreamPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SelectionLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents AddOrder As Label
    Friend WithEvents ItemImage As PictureBox
    Friend WithEvents AmountDeduct As Button
    Friend WithEvents AmountAdd As Button
    Friend WithEvents IceCreamLabel As Label
    Friend WithEvents B3_Selection_A As Label
    Friend WithEvents B3_Selection_B As Label
    Friend WithEvents B3_Selection_C As Label
    Friend WithEvents IceCreamPanel As Panel
    Friend WithEvents CloseButton As Label
End Class
