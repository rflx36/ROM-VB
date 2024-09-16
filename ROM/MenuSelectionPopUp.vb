'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Imports MySql.Data.MySqlClient

Public Class MenuSelectionPopUp
    Dim CurrentItemPrice As Integer = 0

    Dim CurrentItemAmount As Integer = 1
    Dim CurrentItemType As Integer = 0


    Dim CurrentIceCreamFlavor As Integer = 1

    Dim OrderStatus As New List(Of String)()
    Dim OrderStocks As New List(Of Integer)()
    Dim NotAvailable As Boolean = False
    Private Sub RequestStock()
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(2)
        End If

        Try
            Dim cmd As New MySqlCommand("SELECT `Stocks`,`Status` FROM `inventory` WHERE 1", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            While reader.Read()
                OrderStatus.Add(reader.GetString("Status"))
                OrderStocks.Add(reader.GetInt32("Stocks"))
                '  MessageBox.Show("Status:" + reader.GetString("Status") + "Stocks:" + reader.GetInt32("Stocks").ToString)
            End While
            reader.Close()
        Catch ex As Exception

        End Try


        If (OrderStatus(CurrentItemType) = "Out of Stock" Or OrderStatus(CurrentItemType) = "Out Of Stock") Then
            NotAvailable = True
            AddOrder.Image = My.Resources.OutOfOrder
            AddOrder.Text = ""
            AddOrder.Cursor = Cursors.Default
        ElseIf (OrderStatus(CurrentItemType) = "Unavailable") Then
            NotAvailable = True

            AddOrder.Image = My.Resources.Unavailable
            AddOrder.Text = ""
            AddOrder.Cursor = Cursors.Default
        End If
    End Sub



    Private Sub ModifyItemDisplay(w As Integer, h As Integer, r As Bitmap, x As Integer, y As Integer)
        ItemImage.Size = New Size(w, h)
        ItemImage.Image = r
        ItemImage.Location = New Point(x, y)
    End Sub
    Public Sub ModifyItemsSelection(Selection As String)
        CurrentIceCreamFlavor = 1
        Dim ItemName As String
        Dim ItemPrice As Integer
        ItemName = ""
        ItemPrice = 0

        If (Selection = "D3") Then
            IceCreamPanel.Enabled = True
            IceCreamPanel.Visible = True
        Else
            IceCreamPanel.Enabled = False
            IceCreamPanel.Visible = False
        End If


        If (Selection = "A1") Then
            ItemName = "Sisig Rice"
            ItemPrice = 89

            ModifyItemDisplay(200, 114, My.Resources.A1, 158, 72)

            CurrentItemType = 0


        ElseIf (Selection = "A2") Then
            ItemName = "Pork Steak"
            ItemPrice = 89


            ModifyItemDisplay(200, 114, My.Resources.A2, 158, 72)

            CurrentItemType = 1
        ElseIf (Selection = "A3") Then
            ItemName = "Beef Tapa"
            ItemPrice = 85

            ModifyItemDisplay(200, 114, My.Resources.A3, 158, 72)

            CurrentItemType = 2
        ElseIf (Selection = "A4") Then
            ItemName = "Chicken Curry"
            ItemPrice = 89

            ModifyItemDisplay(200, 114, My.Resources.A4, 158, 72)

            CurrentItemType = 3
        ElseIf (Selection = "A5") Then
            ItemName = "Roasted Beef"
            ItemPrice = 89

            ModifyItemDisplay(200, 114, My.Resources.A5, 158, 72)

            CurrentItemType = 4
        ElseIf (Selection = "S1") Then
            ItemName = "French Fries"
            ItemPrice = 50


            ModifyItemDisplay(180, 106, My.Resources.S1, 168, 72)

            CurrentItemType = 5
        ElseIf (Selection = "S2") Then
            ItemName = "Nachos"
            ItemPrice = 99

            ModifyItemDisplay(180, 114, My.Resources.S2, 168, 72)

            CurrentItemType = 6
        ElseIf (Selection = "D1") Then
            ItemName = "Apple Pie"
            ItemPrice = 160

            ModifyItemDisplay(150, 115, My.Resources.D1, 182, 73)

            CurrentItemType = 7
        ElseIf (Selection = "D2") Then
            ItemName = "Halo-Halo"
            ItemPrice = 48

            ModifyItemDisplay(85, 105, My.Resources.D2, 215, 75)

            CurrentItemType = 8

        ElseIf (Selection = "D3") Then
            ItemName = "Ice Cream"
            ItemPrice = 48

            CurrentItemType = 9
            ModifyItemDisplay(70, 110, My.Resources.D3_A, 172, 68)

        ElseIf (Selection = "B1") Then
            ItemName = "Coca-Cola"
            ItemPrice = 35


            ModifyItemDisplay(95, 100, My.Resources.B1, 207, 80)

            CurrentItemType = 12
        ElseIf (Selection = "B2") Then
            ItemName = "Pineapple Juice"
            ItemPrice = 30

            ModifyItemDisplay(50, 110, My.Resources.B2, 235, 80)

            CurrentItemType = 13
        ElseIf (Selection = "B3") Then
            ItemName = "Nestea"
            ItemPrice = 30


            ModifyItemDisplay(55, 120, My.Resources.B3, 232, 80)

            CurrentItemType = 14
        End If

        CurrentItemPrice = ItemPrice
        SelectionLabel.Text = ItemName
        PriceLabel.Text = "₱" + (ItemPrice.ToString)
    End Sub

    Private Sub AmountDeduct_Click(sender As Object, e As EventArgs) Handles AmountDeduct.Click

        If (CurrentItemAmount = 1) Then
            Return
        End If

        CurrentItemAmount -= 1

        AmountLabel.Text = CurrentItemAmount.ToString

        PriceLabel.Text = "₱" + (CurrentItemPrice * CurrentItemAmount).ToString

    End Sub

    Private Sub AmountDeductEnter(sender As Object, e As EventArgs) Handles AmountDeduct.MouseEnter
        AmountDeduct.BackgroundImage = My.Resources.Amount_DeductHover
    End Sub
    Private Sub AmountDeductLeave(sender As Object, e As EventArgs) Handles AmountDeduct.MouseLeave
        AmountDeduct.BackgroundImage = My.Resources.Amount_deduct
    End Sub


    Private Sub AmountAddEnter(sender As Object, ea As EventArgs) Handles AmountAdd.MouseEnter
        AmountAdd.BackgroundImage = My.Resources.Amount_AddHover
    End Sub


    Private Sub AmountAddLeave(sender As Object, ea As EventArgs) Handles AmountAdd.MouseLeave
        AmountAdd.BackgroundImage = My.Resources.Amount_Add
    End Sub


    Private Sub AmountAdd_Click(sender As Object, e As EventArgs) Handles AmountAdd.Click
        If (OrderStocks(CurrentItemType) <= CurrentItemAmount) Then
            Return
        End If

        CurrentItemAmount += 1

        AmountLabel.Text = CurrentItemAmount.ToString

        PriceLabel.Text = "₱" + (CurrentItemPrice * CurrentItemAmount).ToString
    End Sub

    Private Sub B3_Selection_A_Click(sender As Object, e As EventArgs) Handles B3_Selection_A.Click
        If (CurrentIceCreamFlavor = 1) Then
            Return
        End If
        CurrentItemType = 9
        CurrentIceCreamFlavor = 1
        B3_Selection_B.Image = Nothing
        B3_Selection_C.Image = Nothing
        B3_Selection_A.Image = My.Resources.Ice_Cream_Selection

        B3_Selection_B.ForeColor = Color.FromArgb(89, 89, 89)
        B3_Selection_C.ForeColor = Color.FromArgb(89, 89, 89)
        B3_Selection_A.ForeColor = Color.FromArgb(228, 162, 114)


        ModifyItemDisplay(70, 110, My.Resources.D3_A, 172, 68)

    End Sub

    Private Sub B3_Selection_B_Click(sender As Object, e As EventArgs) Handles B3_Selection_B.Click
        If (CurrentIceCreamFlavor = 2) Then
            Return
        End If

        CurrentItemType = 10
        CurrentIceCreamFlavor = 2

        B3_Selection_A.Image = Nothing
        B3_Selection_C.Image = Nothing
        B3_Selection_B.Image = My.Resources.Ice_Cream_Selection

        B3_Selection_A.ForeColor = Color.FromArgb(89, 89, 89)
        B3_Selection_C.ForeColor = Color.FromArgb(89, 89, 89)
        B3_Selection_B.ForeColor = Color.FromArgb(228, 162, 114)


        ModifyItemDisplay(120, 110, My.Resources.D3_B, 145, 68)

    End Sub

    Private Sub B3_Selection_C_Click(sender As Object, e As EventArgs) Handles B3_Selection_C.Click
        If (CurrentIceCreamFlavor = 3) Then
            Return
        End If

        CurrentItemType = 11
        CurrentIceCreamFlavor = 3

        B3_Selection_A.Image = Nothing
        B3_Selection_B.Image = Nothing
        B3_Selection_C.Image = My.Resources.Ice_Cream_Selection

        B3_Selection_A.ForeColor = Color.FromArgb(89, 89, 89)
        B3_Selection_B.ForeColor = Color.FromArgb(89, 89, 89)
        B3_Selection_C.ForeColor = Color.FromArgb(228, 162, 114)

        ModifyItemDisplay(70, 105, My.Resources.D3_C, 172, 68)

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        BGOverlay.Close()
        Me.Close()
    End Sub

    Private Sub AddOrder_Click(sender As Object, e As EventArgs) Handles AddOrder.Click
        If (NotAvailable) Then
            Return
        End If
        OrderListModule.OrderUpdate(CurrentItemType, CurrentItemAmount)
        BGOverlay.Close()
        Me.Close()

        CustomerUI.OrderDetails.BackgroundImage = My.Resources.IconOrderNotif
    End Sub

    Private Sub MenuSelectionPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RequestStock()
    End Sub
End Class