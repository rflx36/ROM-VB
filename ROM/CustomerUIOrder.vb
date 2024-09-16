'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Imports System.CodeDom.Compiler
Imports System.Xml

Public Class CustomerUIOrder

    Dim OrderNames = New String() {"Sisig Rice", "Pork Steak", "Beef Tapa", "Chicken Curry", "Roasted Beef", "French Fries", "Nachos", "Apple Pie", "Halo-Halo", "Ice Cream", "Ice Cream", "Ice Cream", "Coca-Cola", "Pineapple Juice", "Nestea"}
    Dim OrderPrices = New Integer() {89, 89, 85, 89, 89, 50, 99, 160, 48, 48, 48, 48, 35, 30, 30}

    Dim A1Amount, A1Price As Label
    Dim A2Amount, A2Price As Label
    Dim A3Amount, A3Price As Label
    Dim A4Amount, A4Price As Label
    Dim A5Amount, A5Price As Label
    Dim S1Amount, S1Price As Label
    Dim S2Amount, S2Price As Label
    Dim D1Amount, D1Price As Label
    Dim D2Amount, D2Price As Label
    Dim D3_A_Amount, D3_A_Price As Label
    Dim D3_B_Amount, D3_B_Price As Label
    Dim D3_C_Amount, D3_C_Price As Label
    Dim B1Amount, B1Price As Label
    Dim B2Amount, B2Price As Label
    Dim B3Amount, B3Price As Label

    Public TotalPrice As Integer = 0


    Private Sub UpdateTotalPrice()
        TotalPrice = 0
        For i As Integer = 0 To OrderListModule.OrderList.Length - 1
            If (OrderListModule.OrderList(i) >= 1) Then
                TotalPrice += (OrderPrices(i) * OrderListModule.OrderList(i))
            End If
        Next
        If TotalPrice = 0 Then

            TotalPriceLabel.Text = "₱000.00"
        Else
            TotalPriceLabel.Text = "₱" + TotalPrice.ToString + ".00"
        End If
    End Sub
    Private Sub CustomerUIOrder_Update()

        OrderListPanel.Controls.Clear()
        Dim UniqueItems As Integer = 0
        Dim Empty As Boolean = True
        UpdateTotalPrice()
        For i As Integer = 0 To OrderListModule.OrderList.Length - 1
            '   OrderListmodule.OrderList(i)

            If (OrderListModule.OrderList(i) >= 1) Then
                Empty = False
                UniqueItems += 1
                Dim ItemContainer As New Panel()
                ItemContainer.Width = 825
                ItemContainer.Height = 90
                ItemContainer.Location = New Point(0, UniqueItems * 95)
                ItemContainer.BackgroundImage = My.Resources.OrderListItem

                OrderListPanel.Controls.Add(ItemContainer)

                Dim LabelsFont
                LabelsFont = New Font("Candara", 15)

                Dim ItemtypeLabel As New Label
                ItemtypeLabel.ForeColor = Color.FromArgb(192, 166, 97)
                ItemtypeLabel.Text = OrderNames(i)
                ItemtypeLabel.Location = New Point(20, 25)
                ItemtypeLabel.MinimumSize = New Size(160, 40)
                ItemtypeLabel.Size = ItemtypeLabel.MinimumSize
                ItemtypeLabel.Font = LabelsFont
                ItemtypeLabel.BackColor = Color.White
                ItemtypeLabel.Image = My.Resources.OrderListItemType
                ItemtypeLabel.TextAlign = ContentAlignment.MiddleCenter

                Dim ItemAmountLabel As New Label

                ItemAmountLabel.ForeColor = Color.FromArgb(128, 128, 128)
                ItemAmountLabel.Text = "Amount"
                ItemAmountLabel.Location = New Point(250, 25)
                ItemAmountLabel.Size = New Size(80, 40)
                ItemAmountLabel.Font = LabelsFont
                ItemAmountLabel.BackColor = Color.White
                ItemAmountLabel.TextAlign = ContentAlignment.MiddleCenter


                Dim ItemAmount As New Label
                ItemAmount.ForeColor = Color.Black
                ItemAmount.Text = OrderListModule.OrderList(i)
                ItemAmount.Location = New Point(410, 25)
                ItemAmount.Size = New Size(50, 40)
                ItemAmount.Font = LabelsFont
                ItemAmount.BackColor = Color.White
                ItemAmount.TextAlign = ContentAlignment.MiddleCenter

                Dim ItemPriceLabel As New Label
                ItemPriceLabel.ForeColor = Color.FromArgb(128, 128, 128)
                ItemPriceLabel.Text = "Price"
                ItemPriceLabel.Location = New Point(570, 25)
                ItemPriceLabel.Size = New Size(50, 40)
                ItemPriceLabel.Font = LabelsFont
                ItemPriceLabel.BackColor = Color.White
                ItemPriceLabel.TextAlign = ContentAlignment.MiddleCenter


                Dim ItemPrice As New Label
                ItemPrice.ForeColor = Color.FromArgb(228, 135, 114)
                ItemPrice.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
                ItemPrice.Location = New Point(620, 25)
                ItemPrice.Size = New Size(80, 40)
                ItemPrice.Font = New Font("Arial", 15)
                ItemPrice.BackColor = Color.White
                ItemPrice.TextAlign = ContentAlignment.MiddleCenter

                Dim AmountAdd As New Button
                AmountAdd.BackgroundImage = My.Resources.Amount_Add
                AmountAdd.BackColor = Color.White
                AmountAdd.Cursor = Cursors.Hand
                AmountAdd.FlatAppearance.BorderColor = Color.White
                AmountAdd.FlatAppearance.BorderSize = 0
                AmountAdd.FlatAppearance.MouseDownBackColor = Color.White
                AmountAdd.FlatAppearance.MouseOverBackColor = Color.White
                AmountAdd.FlatStyle = FlatStyle.Flat
                AmountAdd.Size = New Size(40, 40)
                AmountAdd.Location = New Point(470, 25)


                Dim AmountDeduct As New Button
                AmountDeduct.BackgroundImage = My.Resources.Amount_deduct
                AmountDeduct.BackColor = Color.White
                AmountDeduct.Cursor = Cursors.Hand
                AmountDeduct.FlatAppearance.BorderColor = Color.White
                AmountDeduct.FlatAppearance.BorderSize = 0
                AmountDeduct.FlatAppearance.MouseDownBackColor = Color.White
                AmountDeduct.FlatAppearance.MouseOverBackColor = Color.White
                AmountDeduct.FlatStyle = FlatStyle.Flat
                AmountDeduct.Size = New Size(40, 40)
                AmountDeduct.Location = New Point(360, 25)


                Dim DeleteItem As New Button
                DeleteItem.BackgroundImage = My.Resources.DeleteOrder
                DeleteItem.BackColor = Color.White
                DeleteItem.Cursor = Cursors.Hand
                DeleteItem.FlatAppearance.BorderColor = Color.White
                DeleteItem.FlatAppearance.BorderSize = 0
                DeleteItem.FlatAppearance.MouseDownBackColor = Color.White
                DeleteItem.FlatAppearance.MouseOverBackColor = Color.White
                DeleteItem.FlatStyle = FlatStyle.Flat
                DeleteItem.Size = New Size(40, 40)
                DeleteItem.Location = New Point(760, 25)


                If (i = 0) Then
                    AddHandler AmountAdd.Click, AddressOf A1_Add
                    AddHandler AmountDeduct.Click, AddressOf A1_Deduct


                    AddHandler DeleteItem.Click, AddressOf A1_Delete
                    A1_Set(ItemPrice, ItemAmount)
                ElseIf (i = 1) Then
                    AddHandler AmountAdd.Click, AddressOf A2_Add
                    AddHandler AmountDeduct.Click, AddressOf A2_Deduct


                    AddHandler DeleteItem.Click, AddressOf A2_Delete
                    A2_Set(ItemPrice, ItemAmount)
                ElseIf (i = 2) Then
                    AddHandler AmountAdd.Click, AddressOf A3_Add
                    AddHandler AmountDeduct.Click, AddressOf A3_Deduct


                    AddHandler DeleteItem.Click, AddressOf A3_Delete
                    A3_Set(ItemPrice, ItemAmount)
                ElseIf (i = 3) Then
                    AddHandler AmountAdd.Click, AddressOf A4_Add
                    AddHandler AmountDeduct.Click, AddressOf A4_Deduct


                    AddHandler DeleteItem.Click, AddressOf A4_Delete
                    A4_Set(ItemPrice, ItemAmount)
                ElseIf (i = 4) Then
                    AddHandler AmountAdd.Click, AddressOf A5_Add
                    AddHandler AmountDeduct.Click, AddressOf A5_Deduct


                    AddHandler DeleteItem.Click, AddressOf A5_Delete
                    A5_Set(ItemPrice, ItemAmount)
                ElseIf (i = 5) Then
                    AddHandler AmountAdd.Click, AddressOf S1_Add
                    AddHandler AmountDeduct.Click, AddressOf S1_Deduct


                    AddHandler DeleteItem.Click, AddressOf S1_Delete
                    S1_Set(ItemPrice, ItemAmount)
                ElseIf (i = 6) Then
                    AddHandler AmountAdd.Click, AddressOf S2_Add
                    AddHandler AmountDeduct.Click, AddressOf S2_Deduct


                    AddHandler DeleteItem.Click, AddressOf S2_Delete
                    S2_Set(ItemPrice, ItemAmount)
                ElseIf (i = 7) Then
                    AddHandler AmountAdd.Click, AddressOf D1_Add
                    AddHandler AmountDeduct.Click, AddressOf D1_Deduct


                    AddHandler DeleteItem.Click, AddressOf D1_Delete
                    D1_Set(ItemPrice, ItemAmount)
                ElseIf (i = 8) Then
                    AddHandler AmountAdd.Click, AddressOf D2_Add
                    AddHandler AmountDeduct.Click, AddressOf D2_Deduct


                    AddHandler DeleteItem.Click, AddressOf D2_Delete
                    D2_Set(ItemPrice, ItemAmount)
                ElseIf (i = 9) Then
                    AddHandler AmountAdd.Click, AddressOf D3_A_Add
                    AddHandler AmountDeduct.Click, AddressOf D3_A_Deduct


                    AddHandler DeleteItem.Click, AddressOf D3_A_Delete

                    ItemtypeLabel.ForeColor = Color.FromArgb(117, 71, 28)
                    ItemtypeLabel.Image = My.Resources.SelectionChocolate


                    D3_A_Set(ItemPrice, ItemAmount)
                ElseIf (i = 10) Then
                    AddHandler AmountAdd.Click, AddressOf D3_B_Add
                    AddHandler AmountDeduct.Click, AddressOf D3_B_Deduct


                    AddHandler DeleteItem.Click, AddressOf D3_B_Delete

                    ItemtypeLabel.ForeColor = Color.FromArgb(174, 86, 86)
                    ItemtypeLabel.Image = My.Resources.SelectionStrawberry

                    D3_B_Set(ItemPrice, ItemAmount)
                ElseIf (i = 11) Then
                    AddHandler AmountAdd.Click, AddressOf D3_C_Add
                    AddHandler AmountDeduct.Click, AddressOf D3_C_Deduct


                    AddHandler DeleteItem.Click, AddressOf D3_C_Delete

                    ItemtypeLabel.ForeColor = Color.FromArgb(77, 58, 97)
                    ItemtypeLabel.Image = My.Resources.SelectionCaramel


                    D3_C_Set(ItemPrice, ItemAmount)
                ElseIf (i = 12) Then
                    AddHandler AmountAdd.Click, AddressOf B1_Add
                    AddHandler AmountDeduct.Click, AddressOf B1_Deduct


                    AddHandler DeleteItem.Click, AddressOf B1_Delete
                    B1_Set(ItemPrice, ItemAmount)
                ElseIf (i = 13) Then
                    AddHandler AmountAdd.Click, AddressOf B2_Add
                    AddHandler AmountDeduct.Click, AddressOf B2_Deduct


                    AddHandler DeleteItem.Click, AddressOf B2_Delete
                    B2_Set(ItemPrice, ItemAmount)
                ElseIf (i = 14) Then
                    AddHandler AmountAdd.Click, AddressOf B3_Add
                    AddHandler AmountDeduct.Click, AddressOf B3_Deduct


                    AddHandler DeleteItem.Click, AddressOf B3_Delete
                    B3_Set(ItemPrice, ItemAmount)
                End If


                AddHandler AmountAdd.MouseEnter, AddressOf AmountAddEnter
                AddHandler AmountAdd.MouseLeave, AddressOf AmountAddLeave

                AddHandler AmountDeduct.MouseEnter, AddressOf AmountDeductEnter
                AddHandler AmountDeduct.MouseLeave, AddressOf AmountDeductLeave


                ItemContainer.Controls.Add(DeleteItem)
                ItemContainer.Controls.Add(ItemPrice)
                ItemContainer.Controls.Add(ItemAmount)

                ItemContainer.Controls.Add(ItemPriceLabel)
                ItemContainer.Controls.Add(ItemAmountLabel)
                ItemContainer.Controls.Add(ItemtypeLabel)

                ItemContainer.Controls.Add(AmountAdd)
                ItemContainer.Controls.Add(AmountDeduct)

            End If
        Next

        If Empty Then

            CustomerUI.OrderDetails.BackgroundImage = My.Resources.IconOrder
        End If
    End Sub



    Private Sub AmountAddEnter(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        button.BackgroundImage = My.Resources.Amount_AddHover
    End Sub

    Private Sub AmountAddLeave(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        button.BackgroundImage = My.Resources.Amount_Add
    End Sub

    Private Sub AmountDeductEnter(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        button.BackgroundImage = My.Resources.Amount_DeductHover
    End Sub

    Private Sub AmountDeductLeave(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        button.BackgroundImage = My.Resources.Amount_deduct
    End Sub


    Private Sub CustomerUIOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OrderListPanel.AutoScroll = True
        CustomerUIOrder_Update()
    End Sub

    'A1
    Private Sub A1_Set(price As Label, amount As Label)
        A1Amount = amount
        A1Price = price
    End Sub
    Private Sub A1_Update(i As Integer)
        A1Amount.Text = OrderListModule.OrderList(i)
        A1Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString

        UpdateTotalPrice()
    End Sub

    Private Sub A1_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(0, 1)
        A1_Update(0)
    End Sub
    Private Sub A1_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(0) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(0, -1)
        A1_Update(0)
    End Sub

    'A2
    Private Sub A2_Set(price As Label, amount As Label)
        A2Amount = amount
        A2Price = price
    End Sub
    Private Sub A2_Update(i As Integer)
        A2Amount.Text = OrderListModule.OrderList(i)
        A2Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub
    Private Sub A2_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(1, 1)
        A2_Update(1)
    End Sub
    Private Sub A2_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(1) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(1, -1)
        A2_Update(1)
    End Sub

    'A3
    Private Sub A3_Set(price As Label, amount As Label)
        A3Amount = amount
        A3Price = price
    End Sub
    Private Sub A3_Update(i As Integer)
        A3Amount.Text = OrderListModule.OrderList(i)
        A3Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub
    Private Sub A3_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(2, 1)
        A3_Update(2)
    End Sub
    Private Sub A3_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(2) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(2, -1)
        A3_Update(2)
    End Sub


    'A4
    Private Sub A4_Set(price As Label, amount As Label)
        A4Amount = amount
        A4Price = price
    End Sub
    Private Sub A4_Update(i As Integer)
        A4Amount.Text = OrderListModule.OrderList(i)
        A4Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub
    Private Sub A4_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(3, 1)
        A4_Update(3)
    End Sub
    Private Sub A4_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(3) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(3, -1)
        A4_Update(3)
    End Sub


    'A5

    Private Sub A5_Set(price As Label, amount As Label)
        A5Amount = amount
        A5Price = price
    End Sub
    Private Sub A5_Update(i As Integer)
        A5Amount.Text = OrderListModule.OrderList(i)
        A5Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub

    Private Sub A5_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(4, 1)
        A5_Update(4)
    End Sub
    Private Sub A5_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(4) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(4, -1)
        A5_Update(4)
    End Sub


    'S1

    Private Sub S1_Set(price As Label, amount As Label)
        S1Amount = amount
        S1Price = price
    End Sub
    Private Sub S1_Update(i As Integer)
        S1Amount.Text = OrderListModule.OrderList(i)
        S1Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub

    Private Sub S1_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(5, 1)
        S1_Update(5)
    End Sub
    Private Sub S1_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(5) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(5, -1)
        S1_Update(5)
    End Sub

    'S2

    Private Sub S2_Set(price As Label, amount As Label)
        S2Amount = amount
        S2Price = price
    End Sub
    Private Sub S2_Update(i As Integer)
        S2Amount.Text = OrderListModule.OrderList(i)
        S2Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub
    Private Sub S2_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(6, 1)
        S2_Update(6)
    End Sub
    Private Sub S2_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(6) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(6, -1)
        S2_Update(6)
    End Sub


    'D1

    Private Sub D1_Set(price As Label, amount As Label)
        D1Amount = amount
        D1Price = price
    End Sub
    Private Sub D1_Update(i As Integer)
        D1Amount.Text = OrderListModule.OrderList(i)
        D1Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub
    Private Sub D1_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(7, 1)
        D1_Update(7)
    End Sub
    Private Sub D1_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(7) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(7, -1)
        D1_Update(7)
    End Sub



    'D2

    Private Sub D2_Set(price As Label, amount As Label)
        D2Amount = amount
        D2Price = price
    End Sub
    Private Sub D2_Update(i As Integer)
        D2Amount.Text = OrderListModule.OrderList(i)
        D2Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub
    Private Sub D2_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(8, 1)
        D2_Update(8)
    End Sub
    Private Sub D2_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(8) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(8, -1)
        D2_Update(8)
    End Sub





    'D3_A
    Private Sub D3_A_Set(price As Label, amount As Label)
        D3_A_Amount = amount
        D3_A_Price = price
    End Sub
    Private Sub D3_A_Update(i As Integer)
        D3_A_Amount.Text = OrderListModule.OrderList(i)
        D3_A_Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub
    Private Sub D3_A_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(9, 1)
        D3_A_Update(9)
    End Sub
    Private Sub D3_A_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(9) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(9, -1)
        D3_A_Update(9)
    End Sub



    'D3_B

    Private Sub D3_B_Set(price As Label, amount As Label)
        D3_B_Amount = amount
        D3_B_Price = price
    End Sub
    Private Sub D3_B_Update(i As Integer)
        D3_B_Amount.Text = OrderListModule.OrderList(i)
        D3_B_Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub
    Private Sub D3_B_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(10, 1)
        D3_B_Update(10)
    End Sub
    Private Sub D3_B_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(10) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(10, -1)
        D3_B_Update(10)
    End Sub








    'D3_C

    Private Sub D3_C_Set(price As Label, amount As Label)
        D3_C_Amount = amount
        D3_C_Price = price
    End Sub
    Private Sub D3_C_Update(i As Integer)
        D3_C_Amount.Text = OrderListModule.OrderList(i)
        D3_C_Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub
    Private Sub D3_C_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(11, 1)
        D3_C_Update(11)
    End Sub
    Private Sub D3_C_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(11) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(11, -1)
        D3_C_Update(11)
    End Sub



    'B1

    Private Sub B1_Set(price As Label, amount As Label)
        B1Amount = amount
        B1Price = price
    End Sub
    Private Sub B1_Update(i As Integer)
        B1Amount.Text = OrderListModule.OrderList(i)
        B1Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub
    Private Sub B1_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(12, 1)
        B1_Update(12)
    End Sub
    Private Sub B1_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(12) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(12, -1)
        B1_Update(12)
    End Sub












    'B2


    Private Sub B2_Set(price As Label, amount As Label)
        B2Amount = amount
        B2Price = price
    End Sub
    Private Sub B2_Update(i As Integer)
        B2Amount.Text = OrderListModule.OrderList(i)
        B2Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub

    Private Sub B2_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(13, 1)
        B2_Update(13)
    End Sub
    Private Sub B2_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(13) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(13, -1)
        B2_Update(13)
    End Sub









    'B3

    Private Sub B3_Set(price As Label, amount As Label)
        B3Amount = amount
        B3Price = price
    End Sub
    Private Sub B3_Update(i As Integer)
        B3Amount.Text = OrderListModule.OrderList(i)
        B3Price.Text = "₱" + (OrderPrices(i) * OrderListModule.OrderList(i)).ToString
        UpdateTotalPrice()
    End Sub


    Private Sub B3_Add(sender As Object, e As EventArgs)
        OrderListModule.OrderUpdate(14, 1)
        B3_Update(14)
    End Sub
    Private Sub B3_Deduct(sender As Object, e As EventArgs)
        If (OrderListModule.OrderList(14) = 1) Then
            Return
        End If
        OrderListModule.OrderUpdate(14, -1)
        B3_Update(14)
    End Sub





    Private Sub A1_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(0) * -1
        OrderListModule.OrderUpdate(0, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()

    End Sub


    Private Sub A2_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(1) * -1
        OrderListModule.OrderUpdate(1, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub



    Private Sub A3_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(2) * -1
        OrderListModule.OrderUpdate(2, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub




    Private Sub A4_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(3) * -1
        OrderListModule.OrderUpdate(3, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub
    Private Sub A5_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(4) * -1
        OrderListModule.OrderUpdate(4, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub
    Private Sub S1_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(5) * -1
        OrderListModule.OrderUpdate(5, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub
    Private Sub S2_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(6) * -1
        OrderListModule.OrderUpdate(6, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub

    Private Sub D1_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(7) * -1
        OrderListModule.OrderUpdate(7, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub


    Private Sub D2_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(8) * -1
        OrderListModule.OrderUpdate(8, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub





    Private Sub D3_A_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(9) * -1
        OrderListModule.OrderUpdate(9, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub




    Private Sub D3_B_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(10) * -1
        OrderListModule.OrderUpdate(10, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub




    Private Sub D3_C_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(11) * -1
        OrderListModule.OrderUpdate(11, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub




    Private Sub B1_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(12) * -1
        OrderListModule.OrderUpdate(12, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub



    Private Sub B2_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(13) * -1
        OrderListModule.OrderUpdate(13, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub



    Private Sub B3_Delete(sender As Object, e As EventArgs)
        Dim AmountToReset = OrderListModule.OrderList(14) * -1
        OrderListModule.OrderUpdate(14, AmountToReset)
        OrderListPanel.Controls.Clear()
        CustomerUIOrder_Update()
    End Sub


    Private Sub Back1_Click(sender As Object, e As EventArgs) Handles Back1.Click
        Me.Close()
        CustomerUI.Show()
    End Sub

    Private Sub Back2_Click(sender As Object, e As EventArgs) Handles Back2.Click
        Me.Close()
        CustomerUI.Show()
    End Sub

    Private Sub CheckOutButton_Click(sender As Object, e As EventArgs) Handles CheckOutButton.Click
        BGOverlay.Show()
        CustomerUIOrderPopUp.TotalPriceLabel.Text = TotalPriceLabel.Text
        CustomerUIOrderPopUp.Show()
    End Sub


End Class