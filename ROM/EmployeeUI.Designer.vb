<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeUI
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
        components = New ComponentModel.Container()
        ButtonCancel = New Button()
        ButtonPlace = New Button()
        Panel1 = New Panel()
        Panel5 = New Panel()
        Panel3 = New Panel()
        Label3 = New Label()
        PMEWallet = New Button()
        PMCard = New Button()
        PMCash = New Button()
        OrderAdd = New Button()
        OrderSelect = New Button()
        OrderDelete = New Button()
        TotalValue = New Label()
        TotalLabel = New Label()
        ChangeValue = New Label()
        ChangeLabel = New Label()
        CashTextBox = New TextBox()
        Label1 = New Label()
        VATVallue = New Label()
        SubtotalValue = New Label()
        VATLabel = New Label()
        OrderListPanel = New Panel()
        SubtotalLabel = New Label()
        PriceLabel = New Label()
        AmountLabel = New Label()
        OrderTypeLabel = New Label()
        PendingOrdersPanel = New Panel()
        Label2 = New Label()
        DBUpdate = New Timer(components)
        RefreshManual = New Button()
        RefreshAuto = New Button()
        ToolTip1 = New ToolTip(components)
        PictureBox2 = New PictureBox()
        SignOut = New Label()
        EmployeeLabel = New Label()
        Panel2 = New Panel()
        OrderPanel = New Panel()
        AddOrderPanel = New Panel()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        OrderPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.Cursor = Cursors.Hand
        ButtonCancel.FlatAppearance.BorderColor = Color.White
        ButtonCancel.FlatAppearance.MouseDownBackColor = Color.White
        ButtonCancel.FlatAppearance.MouseOverBackColor = Color.White
        ButtonCancel.FlatStyle = FlatStyle.Flat
        ButtonCancel.Font = New Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonCancel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        ButtonCancel.Image = My.Resources.Resources.CancelButton
        ButtonCancel.Location = New Point(39, 639)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(235, 60)
        ButtonCancel.TabIndex = 0
        ButtonCancel.Text = "Delete Order"
        ButtonCancel.UseVisualStyleBackColor = True
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
        ButtonPlace.Location = New Point(1005, 644)
        ButtonPlace.Name = "ButtonPlace"
        ButtonPlace.Size = New Size(235, 60)
        ButtonPlace.TabIndex = 1
        ButtonPlace.Text = "Place Order"
        ButtonPlace.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.EmployeeUIPanel
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PMEWallet)
        Panel1.Controls.Add(PMCard)
        Panel1.Controls.Add(PMCash)
        Panel1.Controls.Add(OrderAdd)
        Panel1.Controls.Add(OrderSelect)
        Panel1.Controls.Add(OrderDelete)
        Panel1.Controls.Add(TotalValue)
        Panel1.Controls.Add(TotalLabel)
        Panel1.Controls.Add(ChangeValue)
        Panel1.Controls.Add(ChangeLabel)
        Panel1.Controls.Add(CashTextBox)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(VATVallue)
        Panel1.Controls.Add(SubtotalValue)
        Panel1.Controls.Add(VATLabel)
        Panel1.Controls.Add(OrderListPanel)
        Panel1.Controls.Add(SubtotalLabel)
        Panel1.Controls.Add(PriceLabel)
        Panel1.Controls.Add(AmountLabel)
        Panel1.Controls.Add(OrderTypeLabel)
        Panel1.Location = New Point(407, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(845, 610)
        Panel1.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(26, 510)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(427, 19)
        Panel5.TabIndex = 19
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(440, 80)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(13, 449)
        Panel3.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 17F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        Label3.Location = New Point(497, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(208, 27)
        Label3.TabIndex = 7
        Label3.Text = "Payment Method :"
        ' 
        ' PMEWallet
        ' 
        PMEWallet.BackgroundImage = My.Resources.Resources.PaymentBG
        PMEWallet.Cursor = Cursors.Hand
        PMEWallet.FlatAppearance.BorderColor = Color.White
        PMEWallet.FlatAppearance.BorderSize = 0
        PMEWallet.FlatAppearance.MouseDownBackColor = Color.White
        PMEWallet.FlatAppearance.MouseOverBackColor = Color.White
        PMEWallet.FlatStyle = FlatStyle.Flat
        PMEWallet.Image = My.Resources.Resources.PaymentEWallet
        PMEWallet.Location = New Point(719, 163)
        PMEWallet.Margin = New Padding(0)
        PMEWallet.Name = "PMEWallet"
        PMEWallet.Size = New Size(104, 100)
        PMEWallet.TabIndex = 17
        PMEWallet.UseVisualStyleBackColor = True
        ' 
        ' PMCard
        ' 
        PMCard.BackgroundImage = My.Resources.Resources.PaymentBG
        PMCard.Cursor = Cursors.Hand
        PMCard.FlatAppearance.BorderColor = Color.White
        PMCard.FlatAppearance.BorderSize = 0
        PMCard.FlatAppearance.MouseDownBackColor = Color.White
        PMCard.FlatAppearance.MouseOverBackColor = Color.White
        PMCard.FlatStyle = FlatStyle.Flat
        PMCard.Image = My.Resources.Resources.PaymentCard
        PMCard.Location = New Point(609, 163)
        PMCard.Margin = New Padding(0)
        PMCard.Name = "PMCard"
        PMCard.Size = New Size(104, 100)
        PMCard.TabIndex = 16
        PMCard.UseVisualStyleBackColor = True
        ' 
        ' PMCash
        ' 
        PMCash.BackgroundImage = My.Resources.Resources.PaymentSelected
        PMCash.Cursor = Cursors.Hand
        PMCash.FlatAppearance.BorderColor = Color.White
        PMCash.FlatAppearance.BorderSize = 0
        PMCash.FlatAppearance.MouseDownBackColor = Color.White
        PMCash.FlatAppearance.MouseOverBackColor = Color.White
        PMCash.FlatStyle = FlatStyle.Flat
        PMCash.Image = My.Resources.Resources.PaymentCash
        PMCash.Location = New Point(497, 163)
        PMCash.Margin = New Padding(0)
        PMCash.Name = "PMCash"
        PMCash.Size = New Size(104, 100)
        PMCash.TabIndex = 15
        PMCash.UseVisualStyleBackColor = True
        ' 
        ' OrderAdd
        ' 
        OrderAdd.BackgroundImage = My.Resources.Resources.ModifyDisabled
        OrderAdd.BackgroundImageLayout = ImageLayout.Stretch
        OrderAdd.FlatAppearance.BorderColor = Color.White
        OrderAdd.FlatAppearance.BorderSize = 0
        OrderAdd.FlatAppearance.MouseDownBackColor = Color.White
        OrderAdd.FlatAppearance.MouseOverBackColor = Color.White
        OrderAdd.FlatStyle = FlatStyle.Flat
        OrderAdd.Font = New Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        OrderAdd.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        OrderAdd.Image = My.Resources.Resources.LabelAddDisabled
        OrderAdd.Location = New Point(310, 535)
        OrderAdd.Name = "OrderAdd"
        OrderAdd.Size = New Size(135, 48)
        OrderAdd.TabIndex = 14
        OrderAdd.UseVisualStyleBackColor = True
        ' 
        ' OrderSelect
        ' 
        OrderSelect.BackgroundImage = My.Resources.Resources.ModifyDisabled
        OrderSelect.BackgroundImageLayout = ImageLayout.Stretch
        OrderSelect.FlatAppearance.BorderColor = Color.White
        OrderSelect.FlatAppearance.BorderSize = 0
        OrderSelect.FlatAppearance.MouseDownBackColor = Color.White
        OrderSelect.FlatAppearance.MouseOverBackColor = Color.White
        OrderSelect.FlatStyle = FlatStyle.Flat
        OrderSelect.Font = New Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        OrderSelect.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        OrderSelect.Image = My.Resources.Resources.LabelSelectDisabled
        OrderSelect.Location = New Point(169, 535)
        OrderSelect.Name = "OrderSelect"
        OrderSelect.Size = New Size(135, 48)
        OrderSelect.TabIndex = 13
        OrderSelect.UseVisualStyleBackColor = True
        ' 
        ' OrderDelete
        ' 
        OrderDelete.BackgroundImage = My.Resources.Resources.ModifyDisabled
        OrderDelete.BackgroundImageLayout = ImageLayout.Stretch
        OrderDelete.FlatAppearance.BorderColor = Color.White
        OrderDelete.FlatAppearance.BorderSize = 0
        OrderDelete.FlatAppearance.MouseDownBackColor = Color.White
        OrderDelete.FlatAppearance.MouseOverBackColor = Color.White
        OrderDelete.FlatStyle = FlatStyle.Flat
        OrderDelete.Image = My.Resources.Resources.LabelDeleteDisabled
        OrderDelete.Location = New Point(26, 535)
        OrderDelete.Name = "OrderDelete"
        OrderDelete.Size = New Size(135, 48)
        OrderDelete.TabIndex = 7
        OrderDelete.UseVisualStyleBackColor = True
        ' 
        ' TotalValue
        ' 
        TotalValue.AutoSize = True
        TotalValue.Font = New Font("Arial", 25F, FontStyle.Bold, GraphicsUnit.Point)
        TotalValue.ForeColor = Color.Black
        TotalValue.Location = New Point(622, 405)
        TotalValue.MinimumSize = New Size(200, 0)
        TotalValue.Name = "TotalValue"
        TotalValue.Size = New Size(200, 40)
        TotalValue.TabIndex = 12
        TotalValue.Text = "₱0.00"
        TotalValue.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TotalLabel
        ' 
        TotalLabel.AutoSize = True
        TotalLabel.Font = New Font("Arial", 25F, FontStyle.Bold, GraphicsUnit.Point)
        TotalLabel.ForeColor = Color.Black
        TotalLabel.Location = New Point(497, 405)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New Size(115, 40)
        TotalLabel.TabIndex = 11
        TotalLabel.Text = "Total :"
        ' 
        ' ChangeValue
        ' 
        ChangeValue.AutoSize = True
        ChangeValue.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        ChangeValue.ForeColor = Color.Black
        ChangeValue.Location = New Point(617, 557)
        ChangeValue.MinimumSize = New Size(200, 0)
        ChangeValue.Name = "ChangeValue"
        ChangeValue.Size = New Size(200, 24)
        ChangeValue.TabIndex = 10
        ChangeValue.Text = "₱0.00"
        ChangeValue.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ChangeLabel
        ' 
        ChangeLabel.AutoSize = True
        ChangeLabel.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        ChangeLabel.ForeColor = Color.Black
        ChangeLabel.Location = New Point(505, 557)
        ChangeLabel.Name = "ChangeLabel"
        ChangeLabel.Size = New Size(101, 24)
        ChangeLabel.TabIndex = 9
        ChangeLabel.Text = "Change :"
        ' 
        ' CashTextBox
        ' 
        CashTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CashTextBox.BackColor = Color.FromArgb(CByte(255), CByte(234), CByte(229))
        CashTextBox.BorderStyle = BorderStyle.None
        CashTextBox.Cursor = Cursors.IBeam
        CashTextBox.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        CashTextBox.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        CashTextBox.Location = New Point(667, 485)
        CashTextBox.Margin = New Padding(0)
        CashTextBox.MinimumSize = New Size(145, 0)
        CashTextBox.Name = "CashTextBox"
        CashTextBox.ShortcutsEnabled = False
        CashTextBox.Size = New Size(145, 25)
        CashTextBox.TabIndex = 8
        CashTextBox.Text = "0"
        CashTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(204), CByte(153), CByte(141))
        Label1.Location = New Point(505, 485)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 22)
        Label1.TabIndex = 7
        Label1.Text = "Cash Tendered :"
        ' 
        ' VATVallue
        ' 
        VATVallue.AutoSize = True
        VATVallue.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        VATVallue.ForeColor = Color.FromArgb(CByte(235), CByte(165), CByte(149))
        VATVallue.Location = New Point(617, 353)
        VATVallue.MinimumSize = New Size(200, 0)
        VATVallue.Name = "VATVallue"
        VATVallue.Size = New Size(200, 24)
        VATVallue.TabIndex = 6
        VATVallue.Text = "₱0.00"
        VATVallue.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' SubtotalValue
        ' 
        SubtotalValue.AutoSize = True
        SubtotalValue.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        SubtotalValue.ForeColor = Color.FromArgb(CByte(235), CByte(165), CByte(149))
        SubtotalValue.Location = New Point(617, 292)
        SubtotalValue.MinimumSize = New Size(200, 0)
        SubtotalValue.Name = "SubtotalValue"
        SubtotalValue.Size = New Size(200, 24)
        SubtotalValue.TabIndex = 5
        SubtotalValue.Text = "₱0.00"
        SubtotalValue.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' VATLabel
        ' 
        VATLabel.AutoSize = True
        VATLabel.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        VATLabel.ForeColor = Color.FromArgb(CByte(235), CByte(165), CByte(149))
        VATLabel.Location = New Point(505, 353)
        VATLabel.Name = "VATLabel"
        VATLabel.Size = New Size(60, 24)
        VATLabel.TabIndex = 4
        VATLabel.Text = "VAT :"
        ' 
        ' OrderListPanel
        ' 
        OrderListPanel.AutoScroll = True
        OrderListPanel.Location = New Point(26, 99)
        OrderListPanel.Name = "OrderListPanel"
        OrderListPanel.Size = New Size(427, 430)
        OrderListPanel.TabIndex = 3
        ' 
        ' SubtotalLabel
        ' 
        SubtotalLabel.AutoSize = True
        SubtotalLabel.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        SubtotalLabel.ForeColor = Color.FromArgb(CByte(235), CByte(165), CByte(149))
        SubtotalLabel.Location = New Point(505, 292)
        SubtotalLabel.Name = "SubtotalLabel"
        SubtotalLabel.Size = New Size(107, 24)
        SubtotalLabel.TabIndex = 2
        SubtotalLabel.Text = "Subtotal :"
        ' 
        ' PriceLabel
        ' 
        PriceLabel.AutoSize = True
        PriceLabel.Font = New Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        PriceLabel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        PriceLabel.Location = New Point(360, 64)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New Size(51, 23)
        PriceLabel.TabIndex = 1
        PriceLabel.Text = "Price"
        ' 
        ' AmountLabel
        ' 
        AmountLabel.AutoSize = True
        AmountLabel.Font = New Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        AmountLabel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        AmountLabel.Location = New Point(194, 64)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New Size(76, 23)
        AmountLabel.TabIndex = 0
        AmountLabel.Text = "Amount"
        ' 
        ' OrderTypeLabel
        ' 
        OrderTypeLabel.AutoSize = True
        OrderTypeLabel.Font = New Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        OrderTypeLabel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        OrderTypeLabel.Location = New Point(26, 64)
        OrderTypeLabel.Name = "OrderTypeLabel"
        OrderTypeLabel.Size = New Size(100, 23)
        OrderTypeLabel.TabIndex = 0
        OrderTypeLabel.Text = "Order Type"
        ' 
        ' PendingOrdersPanel
        ' 
        PendingOrdersPanel.AutoScroll = True
        PendingOrdersPanel.Location = New Point(28, 92)
        PendingOrdersPanel.Name = "PendingOrdersPanel"
        PendingOrdersPanel.Size = New Size(384, 546)
        PendingOrdersPanel.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        Label2.Location = New Point(39, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(239, 32)
        Label2.TabIndex = 4
        Label2.Text = "Pending Orders :"
        ' 
        ' DBUpdate
        ' 
        DBUpdate.Interval = 5000
        ' 
        ' RefreshManual
        ' 
        RefreshManual.BackgroundImageLayout = ImageLayout.Center
        RefreshManual.Cursor = Cursors.Hand
        RefreshManual.FlatAppearance.BorderColor = Color.White
        RefreshManual.FlatAppearance.MouseDownBackColor = Color.White
        RefreshManual.FlatAppearance.MouseOverBackColor = Color.White
        RefreshManual.FlatStyle = FlatStyle.Flat
        RefreshManual.Image = My.Resources.Resources.ManualRefresh
        RefreshManual.Location = New Point(301, 42)
        RefreshManual.Name = "RefreshManual"
        RefreshManual.Size = New Size(30, 30)
        RefreshManual.TabIndex = 5
        ToolTip1.SetToolTip(RefreshManual, "Manual Refresh" & vbCrLf)
        RefreshManual.UseVisualStyleBackColor = True
        ' 
        ' RefreshAuto
        ' 
        RefreshAuto.BackgroundImageLayout = ImageLayout.Center
        RefreshAuto.Cursor = Cursors.Hand
        RefreshAuto.FlatAppearance.BorderColor = Color.White
        RefreshAuto.FlatAppearance.MouseDownBackColor = Color.White
        RefreshAuto.FlatAppearance.MouseOverBackColor = Color.White
        RefreshAuto.FlatStyle = FlatStyle.Flat
        RefreshAuto.Image = My.Resources.Resources.AutoRefreshOn
        RefreshAuto.Location = New Point(341, 42)
        RefreshAuto.Name = "RefreshAuto"
        RefreshAuto.Size = New Size(30, 30)
        RefreshAuto.TabIndex = 6
        ToolTip1.SetToolTip(RefreshAuto, "Toggle Auto Refresh")
        RefreshAuto.UseVisualStyleBackColor = True
        ' 
        ' ToolTip1
        ' 
        ToolTip1.AutoPopDelay = 5000
        ToolTip1.BackColor = Color.White
        ToolTip1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        ToolTip1.InitialDelay = 1300
        ToolTip1.ReshowDelay = 100
        ToolTip1.ToolTipTitle = "Reload Orders"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.EmployeIconSignOut
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Location = New Point(1141, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 32)
        PictureBox2.TabIndex = 19
        PictureBox2.TabStop = False
        ' 
        ' SignOut
        ' 
        SignOut.AutoSize = True
        SignOut.Cursor = Cursors.Hand
        SignOut.Font = New Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        SignOut.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        SignOut.Location = New Point(1166, 12)
        SignOut.Name = "SignOut"
        SignOut.Size = New Size(79, 23)
        SignOut.TabIndex = 18
        SignOut.Text = "Sign Out"
        ' 
        ' EmployeeLabel
        ' 
        EmployeeLabel.AutoSize = True
        EmployeeLabel.Font = New Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        EmployeeLabel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(114))
        EmployeeLabel.Image = My.Resources.Resources.EmployeeIcon
        EmployeeLabel.ImageAlign = ContentAlignment.MiddleLeft
        EmployeeLabel.Location = New Point(1029, 12)
        EmployeeLabel.Name = "EmployeeLabel"
        EmployeeLabel.Size = New Size(104, 23)
        EmployeeLabel.TabIndex = 21
        EmployeeLabel.Text = "   Emplyoee"
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(393, 66)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(19, 572)
        Panel2.TabIndex = 22
        ' 
        ' OrderPanel
        ' 
        OrderPanel.BackgroundImage = My.Resources.Resources.EmployeeUIAddOrder
        OrderPanel.BackgroundImageLayout = ImageLayout.None
        OrderPanel.Controls.Add(AddOrderPanel)
        OrderPanel.Enabled = False
        OrderPanel.Location = New Point(28, 40)
        OrderPanel.Margin = New Padding(0)
        OrderPanel.Name = "OrderPanel"
        OrderPanel.Size = New Size(381, 598)
        OrderPanel.TabIndex = 23
        OrderPanel.Visible = False
        ' 
        ' AddOrderPanel
        ' 
        AddOrderPanel.AutoScroll = True
        AddOrderPanel.Location = New Point(11, 55)
        AddOrderPanel.Name = "AddOrderPanel"
        AddOrderPanel.Size = New Size(350, 516)
        AddOrderPanel.TabIndex = 25
        ' 
        ' Panel4
        ' 
        Panel4.Location = New Point(376, 95)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(15, 516)
        Panel4.TabIndex = 19
        ' 
        ' EmployeeUI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 720)
        Controls.Add(Panel4)
        Controls.Add(OrderPanel)
        Controls.Add(Panel2)
        Controls.Add(EmployeeLabel)
        Controls.Add(SignOut)
        Controls.Add(PictureBox2)
        Controls.Add(RefreshAuto)
        Controls.Add(RefreshManual)
        Controls.Add(Label2)
        Controls.Add(PendingOrdersPanel)
        Controls.Add(Panel1)
        Controls.Add(ButtonPlace)
        Controls.Add(ButtonCancel)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1280, 720)
        Name = "EmployeeUI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EmployeeUI"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        OrderPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonPlace As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PriceLabel As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents OrderTypeLabel As Label
    Friend WithEvents VATVallue As Label
    Friend WithEvents SubtotalValue As Label
    Friend WithEvents VATLabel As Label
    Friend WithEvents OrderListPanel As Panel
    Friend WithEvents SubtotalLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CashTextBox As TextBox
    Friend WithEvents TotalLabel As Label
    Friend WithEvents ChangeValue As Label
    Friend WithEvents ChangeLabel As Label
    Friend WithEvents TotalValue As Label
    Friend WithEvents PendingOrdersPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DBUpdate As Timer
    Friend WithEvents RefreshManual As Button
    Friend WithEvents RefreshAuto As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OrderDelete As Button
    Friend WithEvents OrderAdd As Button
    Friend WithEvents OrderSelect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PMEWallet As Button
    Friend WithEvents PMCard As Button
    Friend WithEvents PMCash As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SignOut As Label
    Friend WithEvents EmployeeLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OrderPanel As Panel
    Friend WithEvents AddOrderPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
