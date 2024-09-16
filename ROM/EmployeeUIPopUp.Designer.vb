<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeUIPopUp
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
        DisplayLabel = New Label()
        ButtonOrder = New Button()
        Cancel = New Label()
        Label2 = New Label()
        Label3 = New Label()
        OrderNumberLabel = New Label()
        TotalLabel = New Label()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(234), CByte(159), CByte(142))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(-11, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(599, 30)
        Panel1.TabIndex = 0
        ' 
        ' DisplayLabel
        ' 
        DisplayLabel.AutoSize = True
        DisplayLabel.Font = New Font("Candara", 24.0F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayLabel.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        DisplayLabel.Location = New Point(189, 44)
        DisplayLabel.Name = "DisplayLabel"
        DisplayLabel.Size = New Size(227, 39)
        DisplayLabel.TabIndex = 1
        DisplayLabel.Text = "Confirm Order?"
        DisplayLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ButtonOrder
        ' 
        ButtonOrder.Cursor = Cursors.Hand
        ButtonOrder.FlatAppearance.BorderColor = Color.White
        ButtonOrder.FlatAppearance.MouseDownBackColor = Color.White
        ButtonOrder.FlatAppearance.MouseOverBackColor = Color.White
        ButtonOrder.FlatStyle = FlatStyle.Flat
        ButtonOrder.Font = New Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonOrder.ForeColor = Color.FromArgb(CByte(201), CByte(165), CByte(74))
        ButtonOrder.Image = My.Resources.Resources.PlaceButton
        ButtonOrder.Location = New Point(339, 296)
        ButtonOrder.Name = "ButtonOrder"
        ButtonOrder.Size = New Size(235, 60)
        ButtonOrder.TabIndex = 2
        ButtonOrder.Text = "Place Order"
        ButtonOrder.UseVisualStyleBackColor = True
        ' 
        ' Cancel
        ' 
        Cancel.AutoSize = True
        Cancel.Cursor = Cursors.Hand
        Cancel.Font = New Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Cancel.ForeColor = Color.Gray
        Cancel.Location = New Point(34, 310)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(99, 32)
        Cancel.TabIndex = 3
        Cancel.Text = "Cancel"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Candara", 19.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label2.Location = New Point(34, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 32)
        Label2.TabIndex = 4
        Label2.Text = "Order No. :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Candara", 19.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        Label3.Location = New Point(34, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 32)
        Label3.TabIndex = 5
        Label3.Text = "Total :"
        ' 
        ' OrderNumberLabel
        ' 
        OrderNumberLabel.AutoSize = True
        OrderNumberLabel.Font = New Font("Arial", 45.0F, FontStyle.Bold, GraphicsUnit.Point)
        OrderNumberLabel.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        OrderNumberLabel.Location = New Point(375, 109)
        OrderNumberLabel.Name = "OrderNumberLabel"
        OrderNumberLabel.Size = New Size(162, 70)
        OrderNumberLabel.TabIndex = 6
        OrderNumberLabel.Text = "#000"
        ' 
        ' TotalLabel
        ' 
        TotalLabel.AutoSize = True
        TotalLabel.Font = New Font("Arial", 45.0F, FontStyle.Bold, GraphicsUnit.Point)
        TotalLabel.ForeColor = Color.FromArgb(CByte(89), CByte(89), CByte(89))
        TotalLabel.Location = New Point(150, 201)
        TotalLabel.MinimumSize = New Size(400, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New Size(400, 70)
        TotalLabel.TabIndex = 7
        TotalLabel.Text = "₱0.00"
        TotalLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' EmployeeUIPopUp
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(586, 368)
        Controls.Add(TotalLabel)
        Controls.Add(OrderNumberLabel)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Cancel)
        Controls.Add(ButtonOrder)
        Controls.Add(DisplayLabel)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "EmployeeUIPopUp"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "EmployeeUIPopUp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ButtonOrder As Button
    Friend WithEvents Cancel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OrderNumberLabel As Label
    Friend WithEvents TotalLabel As Label
End Class
