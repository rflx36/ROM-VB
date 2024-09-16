'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Runtime.Intrinsics.X86
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto

Public Class EmployeeUI
    Private LoggedUserID As Integer = 0
    Private TimeIn As String = ""
    Private TimeOut As String = ""
    Private CurrentDay As String
    Private CurrentSelectedOrder As Button
    Private CurrentSelected As String
    Private IsSet = False
    Private CurrentOrderList(15) As Integer

    Dim OrderListID As New Integer
    Dim CustomerName As String
    Dim TotalCost As Integer
    Dim OrderNumbers As New List(Of Integer)()

    Dim OrderNames = New String() {"Sisig Rice", "Pork Steak", "Beef Tapa", "Chicken Curry", "Roasted Beef", "French Fries", "Nachos", "Apple Pie", "Halo-Halo", "Ice Cream", "Ice Cream", "Ice Cream", "Coca-Cola", "Pineapple Juice", "Nestea"}
    'Dim OrderPrices = New Integer() {89, 89, 85, 89, 89, 50, 99, 160, 48, 48, 48, 48, 35, 30, 30}
    '   Dim OrderStocks = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim OrderPrices(15) As Integer
    Dim OrderStocks(15) As Integer
    Dim OrderStatus(15) As String
    Private IsUpdating = False

    Dim ToggleDelete As Boolean = False
    Dim ToggleSelect As Boolean = False
    Dim ToggleAdd As Boolean = False

    Dim LoggedUserName As String = ""
    Dim SelectedItems As New List(Of Integer)()

    Private Sub GetInventory()

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(2)
        End If
        Dim TempPrices As New List(Of Integer)()
        Dim TempStocks As New List(Of Integer)()
        Dim TempStatus As New List(Of String)()
        Try
            Dim cmd As New MySqlCommand("SELECT `Stocks`,`Price`,`Status` FROM `inventory` WHERE 1", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            Dim i As Integer = 0
            While reader.Read()
                'OrderPrices(i) = reader.GetInt32("Price")
                '   OrderStocks(i) = reader.GetInt32("Stocks")
                '  
                TempPrices.Add(reader.GetInt32("Price"))
                TempStocks.Add(reader.GetInt32("Stocks"))
                TempStatus.Add(reader.GetString("Status"))
                '      MessageBox.Show(TempStocks(i).ToString)
                i += 1
            End While
            reader.Close()
        Catch ex As Exception

        End Try

        For i As Integer = 0 To TempPrices.Count - 1
            OrderPrices(i) = TempPrices(i)
            OrderStocks(i) = TempStocks(i)
            OrderStatus(i) = TempStatus(i)
        Next


    End Sub
    Public Sub LoggedIn(id As Integer)
        LoggedUserID = id
        TimeIn = TimeOfDay
        CurrentDay = Date.Today.ToString("yyyy-MM-dd")



        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(2)
        End If

        Try
            Dim cmd As New MySqlCommand("Select  `Username` FROM `employee` WHERE `Employee_ID` = '" & id & "'", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader


            While reader.Read
                LoggedUserName = reader.GetString("Username")
                EmployeeLabel.Text = "      " + reader.GetString("Username")
            End While
            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try
        DBUpdate.Start()
    End Sub

    Private Sub LoggedOut()
        TimeOut = TimeOfDay
        If LoggedUserID = 0 Then
            Return
        End If
        Try
            Dim cmd As New MySqlCommand("INSERT INTO `employeeattendance`(`Employee_ID`, `Date`, `TimeIn`, `TimeOut`) 
        VALUES ('" & LoggedUserID & "','" & CurrentDay & "','" & TimeIn & "','" & TimeOut & "')", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            reader.Close()
            DBConn.Connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try





    End Sub
    Private Sub EmployeeUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeUILogin.ShowDialog()

    End Sub



    Private Sub EmployeeUI_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            Return
        End If
        LoggedOut()
    End Sub

    Private Sub DisplayAddOrderList()
        Dim ItemsIteration As Integer = 0
        AddOrderPanel.SuspendLayout()
        AddOrderPanel.Controls.Clear()

        For i As Integer = 0 To CurrentOrderList.Length - 2
            If (CurrentOrderList(i) = 0) Then

                Dim ItemType As New Label()
                ItemType.Text = OrderNames(i)
                ItemType.MinimumSize = New Size(140, 0)
                ItemType.Font = New Font("Candara", 14)
                ItemType.Location = New Point(10, (50 * ItemsIteration))



                If (i = 9) Then
                    ItemType.ForeColor = Color.FromArgb(176, 133, 107)
                    ItemType.Font = New Font("Candara", 14, FontStyle.Bold)
                ElseIf (i = 10) Then
                    ItemType.ForeColor = Color.FromArgb(255, 171, 92)

                    ItemType.Font = New Font("Candara", 14, FontStyle.Bold)
                ElseIf (i = 11) Then
                    ItemType.ForeColor = Color.FromArgb(255, 141, 141)

                    ItemType.Font = New Font("Candara", 14, FontStyle.Bold)
                End If


                Dim ItemPrice As New Label()
                ItemPrice.Text = "₱" + OrderPrices(i).ToString
                ItemPrice.Font = New Font("Arial", 15)
                ItemPrice.ForeColor = Color.FromArgb(228, 135, 114)
                ItemPrice.Size = New Size(70, 30)
                ItemPrice.Location = New Point(180, (50 * ItemsIteration))



                Dim ItemAdd As New Button()

                ItemAdd.Size = New Size(30, 30)
                ItemAdd.FlatAppearance.BorderSize = 0
                ItemAdd.FlatAppearance.BorderColor = Color.White
                ItemAdd.FlatAppearance.MouseDownBackColor = Color.White
                ItemAdd.FlatAppearance.MouseOverBackColor = Color.White
                ItemAdd.FlatStyle = FlatStyle.Flat

                ItemAdd.Name = i.ToString
                ItemAdd.Location = New Point(270, (50 * ItemsIteration))

                If (OrderStatus(i) = "Unavailable") Then
                    ItemAdd.BackgroundImage = My.Resources.ItemUnavailable2
                ElseIf (OrderStocks(i) > 1) Then
                    ItemAdd.Cursor = Cursors.Hand

                    ItemAdd.BackgroundImage = My.Resources.ItemAdd
                    AddHandler ItemAdd.Click, AddressOf AddItem
                    AddHandler ItemAdd.MouseEnter, AddressOf AddItemEnter
                    AddHandler ItemAdd.MouseLeave, AddressOf AddItemLeave
                Else
                    ItemAdd.BackgroundImage = My.Resources.ItemUnavailable
                End If

                ItemsIteration += 1

                AddOrderPanel.Controls.Add(ItemAdd)
                AddOrderPanel.Controls.Add(ItemType)
                AddOrderPanel.Controls.Add(ItemPrice)
            End If
        Next
        AddOrderPanel.ResumeLayout()
        AddOrderPanel.Refresh()
    End Sub




    Private Sub DisplayOrderList()
        Dim PanelIteration As Integer = 0

        OrderListPanel.SuspendLayout()
        OrderListPanel.Controls.Clear()
        TotalCost = 0
        For i As Integer = 0 To CurrentOrderList.Length - 1

            If (CurrentOrderList(i) >= 1) Then

                Dim OrderPanel As New Panel()
                OrderPanel.Size = New Size(420, 60)
                OrderPanel.Location = New Point(0, 60 * PanelIteration)
                PanelIteration += 1

                OrderListPanel.Controls.Add(OrderPanel)
                Dim ToggleX As Integer = 0
                If (ToggleDelete) Then
                    Dim CheckBox As New Button()
                    CheckBox.FlatStyle = FlatStyle.Flat
                    CheckBox.FlatAppearance.BorderSize = 0
                    CheckBox.Cursor = Cursors.Hand
                    CheckBox.Image = My.Resources.CheckBoxUnchecked
                    CheckBox.ImageAlign = ContentAlignment.MiddleCenter
                    CheckBox.FlatAppearance.MouseDownBackColor = Color.White
                    CheckBox.FlatAppearance.MouseOverBackColor = Color.White
                    CheckBox.Size = New Size(22, 22)
                    CheckBox.Location = New Point(0, 17)
                    ToggleX = 25
                    CheckBox.Name = i.ToString


                    AddHandler CheckBox.Click, AddressOf CheckBoxSelect

                    OrderPanel.Controls.Add(CheckBox)
                End If

                Dim ItemName As New Label()
                ItemName.Font = New Font("Candara", 14)
                ItemName.Location = New Point(0 + ToggleX, 17)
                ItemName.Text = OrderNames(i)
                ItemName.MinimumSize = New Size(140, 0)
                If (i = 9) Then
                    ItemName.ForeColor = Color.FromArgb(176, 133, 107)
                    ItemName.Font = New Font("Candara", 14, FontStyle.Bold)
                ElseIf (i = 10) Then
                    ItemName.ForeColor = Color.FromArgb(255, 171, 92)

                    ItemName.Font = New Font("Candara", 14, FontStyle.Bold)
                ElseIf (i = 11) Then
                    ItemName.ForeColor = Color.FromArgb(255, 141, 141)

                    ItemName.Font = New Font("Candara", 14, FontStyle.Bold)
                End If
                Dim ItemPrice As New Label()
                ItemPrice.Font = New Font("Arial", 15)
                ItemPrice.Location = New Point(320 + ToggleX, 17)
                ItemPrice.ForeColor = Color.FromArgb(228, 135, 114)
                ItemPrice.MinimumSize = New Size(100, 0)
                ItemPrice.Text = "₱" + (OrderPrices(i) * CurrentOrderList(i)).ToString

                Dim ItemAmount As New Label()
                ItemAmount.Font = New Font("Candara", 16, FontStyle.Bold)
                ItemAmount.Location = New Point(180 + ToggleX, 17)
                ItemAmount.Text = CurrentOrderList(i).ToString
                ItemAmount.Size = New Size(50, 20)
                ItemAmount.TextAlign = ContentAlignment.MiddleCenter
                ItemAmount.ForeColor = Color.FromArgb(55, 55, 55)

                Dim AmountAdd As New Button()
                AmountAdd.BackgroundImage = My.Resources.Amount_Add
                AmountAdd.BackgroundImageLayout = ImageLayout.Stretch
                AmountAdd.Cursor = Cursors.Hand
                AmountAdd.FlatAppearance.BorderColor = Color.White
                AmountAdd.FlatAppearance.BorderSize = 0
                AmountAdd.FlatAppearance.MouseDownBackColor = Color.White
                AmountAdd.FlatAppearance.MouseOverBackColor = Color.White
                AmountAdd.FlatStyle = FlatStyle.Flat
                AmountAdd.Size = New Size(30, 30)
                AmountAdd.Location = New Point(230 + ToggleX, 13)
                AmountAdd.Name = i.ToString

                Dim AmountDeduct As New Button()
                AmountDeduct.BackgroundImage = My.Resources.Amount_deduct
                AmountDeduct.BackgroundImageLayout = ImageLayout.Stretch
                AmountDeduct.Cursor = Cursors.Hand
                AmountDeduct.FlatAppearance.BorderColor = Color.White
                AmountDeduct.FlatAppearance.BorderSize = 0
                AmountDeduct.FlatAppearance.MouseDownBackColor = Color.White
                AmountDeduct.FlatAppearance.MouseOverBackColor = Color.White
                AmountDeduct.FlatStyle = FlatStyle.Flat
                AmountDeduct.Size = New Size(30, 30)
                AmountDeduct.Location = New Point(150 + ToggleX, 13)
                AmountDeduct.Name = i.ToString


                AddHandler AmountAdd.Click, AddressOf ItemAmountAdd
                AddHandler AmountDeduct.Click, AddressOf ItemAmountDeduct

                AddHandler AmountAdd.MouseEnter, AddressOf AmountAddEnter
                AddHandler AmountAdd.MouseLeave, AddressOf AmountAddLeave

                AddHandler AmountDeduct.MouseEnter, AddressOf AmountDeductEnter
                AddHandler AmountDeduct.MouseLeave, AddressOf AmountDeductLeave



                OrderPanel.Controls.Add(ItemAmount)

                OrderPanel.Controls.Add(AmountDeduct)

                OrderPanel.Controls.Add(AmountAdd)

                OrderPanel.Controls.Add(ItemPrice)

                OrderPanel.Controls.Add(ItemName)
                TotalCost += CurrentOrderList(i) * OrderPrices(i)

                OrderListPanel.ResumeLayout()
                OrderPanel.Refresh()

            End If
        Next

        SubtotalValue.Text = "₱" + (Math.Round(TotalCost * 0.88, 2)).ToString("N2")
        VATVallue.Text = "₱" + (Math.Round(TotalCost * 0.12, 2)).ToString("N2")
        TotalValue.Text = "₱" + TotalCost.ToString + ".00"

        CashTextBox.Text = "0"
        ChangeValue.ForeColor = Color.Black
        ChangeValue.Text = "₱0.00"
        ChangeValue.Font = New Font("Arial", 15.75, FontStyle.Bold)
    End Sub


    Private Sub AddItem(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim ItemType = button.Name

        CurrentOrderList(ItemType) = 1
        OrderStocks(ItemType) -= 1
        DisplayOrderList()
        DisplayAddOrderList()
    End Sub

    Private Sub AddItemEnter(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        button.BackgroundImage = My.Resources.ItemAddHover
    End Sub

    Private Sub AddItemLeave(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        button.BackgroundImage = My.Resources.ItemAdd
    End Sub
    Private Sub CheckBoxSelect(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim ItemType As Integer = Val(button.Name)
        Dim State As Boolean = True
        For i As Integer = 0 To SelectedItems.Count - 1
            If (SelectedItems(i) = ItemType) Then
                SelectedItems.RemoveAt(i)
                State = False
                button.Image = My.Resources.CheckBoxUnchecked
                Exit For
            End If
        Next
        If State Then
            SelectedItems.Add(ItemType)

            button.Image = My.Resources.CheckBoxChecked
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



    Private Sub ItemAmountAdd(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim ItemType As Integer = Val(button.Name)
        '  MessageBox.Show("Orderstocks(Itemtype):" + OrderStocks(ItemType).ToString + ";CurrentOrderlist(Itemtype):" + CurrentOrderList(ItemType).ToString)
        If (OrderStocks(ItemType) > 0) Then
            OrderStocks(ItemType) -= 1
            CurrentOrderList(ItemType) += 1

            SelectedItems.Clear()
            DisplayOrderList()
        End If
    End Sub


    Private Sub ItemAmountDeduct(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim ItemType As Integer = Val(button.Name)
        If (CurrentOrderList(ItemType) > 1) Then
            CurrentOrderList(ItemType) -= 1


            OrderStocks(ItemType) += 1
        End If

        SelectedItems.Clear()
        DisplayOrderList()
    End Sub
    Private Sub GetOrderInfo(id As Integer)

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            Return
        End If

        Dim cmd As New MySqlCommand("SELECT `OrderList_ID`, `Customer_Name`, `TotalOrder_Cost`  FROM `order` WHERE `Order_Number` ='" & id & "'", DBConn.Connection)
        Try
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()

            While reader.Read()

                OrderListID = reader.GetInt32("OrderList_ID")
                TotalCost = reader.GetInt32("TotalOrder_Cost")
                CustomerName = reader.GetString("Customer_Name")
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cmd.CommandText = "SELECT `A1`, `A2`, `A3`, `A4`, `A5`, `S1`, `S2`, `D1`, `D2`, `D3_A`, `D3_B`, `D3_C`, `B1`, `B2`, `B3` FROM `orderlist` WHERE `OrderList_ID` ='" & OrderListID & "'"
        Try
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader

            For i As Integer = 0 To CurrentOrderList.Length - 1
                CurrentOrderList(i) = 0
            Next
            While reader.Read()
                For j As Integer = 0 To 14
                    CurrentOrderList(j) = reader.GetValue(j)

                Next


            End While

            reader.Close()
        Catch ex As Exception

        End Try
        ToggleDelete = False
        OrderDelete.BackgroundImage = My.Resources.ModifyDisabled
        OrderDelete.Image = My.Resources.LabelDeleteDisabled
        OrderDelete.Cursor = Cursors.Default

        SelectedItems.Clear()
        ToggleSelect = True
        ToggleAdd = True
        GetInventory()
        ToggleButtonSelect()

        ToggleButtonAdd()
        DisplayOrderList()
    End Sub


    Private Sub Select_OrderNumber(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim buttonName As String = button.Text

        If (IsSet = False) Then
            IsSet = True
            CurrentSelectedOrder = button
            CurrentSelectedOrder.BackgroundImage = My.Resources.PendingSelected
            CurrentSelectedOrder.ForeColor = Color.White
            CurrentSelected = button.Text
            GetOrderInfo(buttonName)
            Return
        End If

        If (CurrentSelectedOrder.Text <> buttonName) Then

            CurrentSelectedOrder.ForeColor = Color.FromArgb(228, 135, 114)
            CurrentSelectedOrder.BackgroundImage = My.Resources.PendingUnselected
            Dim SetButton = Me.Controls.Find("PendingButton" + CurrentSelectedOrder.Text, True).FirstOrDefault
            SetButton.BackgroundImage = My.Resources.PendingUnselected

            SetButton.ForeColor = Color.FromArgb(228, 135, 114)
            CurrentSelectedOrder = button
            GetOrderInfo(buttonName)
            button.BackgroundImage = My.Resources.PendingSelected
            button.ForeColor = Color.White
            CurrentSelected = button.Text
        End If


    End Sub
    Private Sub DisplayPendingOrders()
        PendingOrdersPanel.VerticalScroll.Value = 0

        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim z As Integer = -1

        Dim OrderDivision = 0

        PendingOrdersPanel.Controls.Clear()
        For i As Integer = 0 To OrderNumbers.Count - 1
            Dim Num As String = OrderNumbers(i).ToString

            If (Num.Length >= 3) Then
                Num = Num.Substring(Num.Length - 3)

            End If

            If (Val(Num) > OrderDivision) Then
                Num -= OrderDivision

            End If
            Dim PendingButton As New Button()
            PendingButton.Size = New Size(170, 120)

            If ((i Mod 2) = 0) Then
                x = 0

                z += 1
            Else
                x = 180
            End If

            y = z * 130
            PendingButton.Margin = New Padding(0)
            PendingButton.Location = New Point(x, y)
            PendingButton.BackgroundImage = My.Resources.PendingUnselected
            PendingButton.BackgroundImageLayout = ImageLayout.Center
            PendingButton.Font = New Font("Arial Rounded MT Bold", 28)
            PendingButton.TextAlign = ContentAlignment.MiddleCenter
            PendingButton.BackColor = Color.White
            PendingButton.ForeColor = Color.FromArgb(228, 135, 114)
            PendingButton.Text = Num
            If (Num = CurrentSelected And IsSet) Then
                PendingButton.BackgroundImage = My.Resources.PendingSelected
                PendingButton.ForeColor = Color.White
            End If
            PendingButton.FlatAppearance.BorderColor = Color.White
            PendingButton.FlatAppearance.BorderSize = 1
            PendingButton.FlatAppearance.MouseDownBackColor = Color.White
            PendingButton.FlatAppearance.MouseOverBackColor = Color.White
            PendingButton.FlatStyle = FlatStyle.Flat
            PendingButton.Name = "PendingButton" + Num.ToString
            AddHandler PendingButton.Click, AddressOf Select_OrderNumber

            PendingOrdersPanel.Controls.Add(PendingButton)
        Next
    End Sub



    Private Sub DBRefresh()
        OrderNumbers.Clear()
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(2)
            Return
        End If

        Dim cmd As New MySqlCommand("SELECT `Order_Number` FROM `order` WHERE `Employee_ID` IS NULL", DBConn.Connection)

        Try
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()

            While reader.Read()
                OrderNumbers.Add(reader.GetInt32("Order_Number"))

            End While
            reader.Close()
            DisplayPendingOrders()

        Catch ex As Exception
            If (DBConn.Connection.State <> ConnectionState.Open) Then

            End If
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub DBUpdate_Tick(sender As Object, e As EventArgs) Handles DBUpdate.Tick
        If (IsUpdating) Then
            Return
        End If

        IsUpdating = True
        DBRefresh()
        IsUpdating = False
    End Sub

    Private Sub RefreshManual_Click(sender As Object, e As EventArgs) Handles RefreshManual.Click
        DBRefresh()
    End Sub

    Private Sub RefreshManual_Hover(sender As Object, e As EventArgs) Handles RefreshManual.MouseEnter
        RefreshManual.Image = My.Resources.ManualRefreshHover
    End Sub

    Private Sub RefreshManual_Exit(sender As Object, e As EventArgs) Handles RefreshManual.MouseLeave
        RefreshManual.Image = My.Resources.ManualRefresh
    End Sub
    Private AutoRefresh As Boolean = True
    Private Sub RefreshAuto_Click(sender As Object, e As EventArgs) Handles RefreshAuto.Click
        ' AutoRefresh!= AutoRefresh

        If (AutoRefresh) Then
            AutoRefresh = False
            RefreshAuto.Image = My.Resources.AutoRefreshOff
        Else
            AutoRefresh = True
            RefreshAuto.Image = My.Resources.AutoRefreshOn
        End If

        DBUpdate.Enabled = AutoRefresh
    End Sub
    Dim ChangeVal As Integer = 0
    Private Sub CashTextBox_TextChanged(sender As Object, e As EventArgs) Handles CashTextBox.TextChanged

        ChangeVal = Val(CashTextBox.Text)
        '   CashTextBox.Text = "₱" + ChangeVal.ToString

        If (ChangeVal >= TotalCost) Then
            ChangeValue.Text = "₱" + (ChangeVal - TotalCost).ToString("N2")
            ChangeValue.ForeColor = Color.Black

            ChangeValue.Font = New Font("Arial", 15.75, FontStyle.Bold)
        Else
            ChangeValue.ForeColor = Color.FromArgb(206, 170, 111)
            ChangeValue.Text = "Need ₱" + (TotalCost - ChangeVal).ToString("N2") + " more"

            ChangeValue.Font = New Font("Arial", 13, FontStyle.Bold)
        End If
    End Sub

    Private Sub CashTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CashTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
        'CashTextBox.Text = "₱" + Val(Value).ToString("N2")
    End Sub

    Private Sub OrderDelete_Enter(sender As Object, e As EventArgs) Handles OrderDelete.MouseEnter
        If (ToggleDelete = False) Then
            Return
        End If
        OrderDelete.BackgroundImage = My.Resources.ModifyHovered
    End Sub
    Private Sub OrderDelete_Leave(sender As Object, e As EventArgs) Handles OrderDelete.MouseLeave
        If (ToggleDelete = False) Then
            Return
        End If
        OrderDelete.BackgroundImage = My.Resources.Modify
    End Sub

    Private Sub OrderSelect_Enter(sender As Object, e As EventArgs) Handles OrderSelect.MouseEnter
        If (ToggleSelect = False) Then
            Return
        End If
        OrderSelect.BackgroundImage = My.Resources.ModifyHovered
    End Sub

    Private Sub OrderSelect_Leave(sender As Object, e As EventArgs) Handles OrderSelect.MouseLeave
        If (ToggleSelect = False) Then
            Return
        End If
        OrderSelect.BackgroundImage = My.Resources.Modify
    End Sub

    Private Sub OrderAdd_Enter(sender As Object, e As EventArgs) Handles OrderAdd.MouseEnter
        If (ToggleAdd = False) Then
            Return
        End If
        OrderAdd.BackgroundImage = My.Resources.ModifyHovered
    End Sub
    Private Sub OrderAdd_Leave(sender As Object, e As EventArgs) Handles OrderAdd.MouseLeave
        If (ToggleAdd = False) Then
            Return
        End If
        OrderAdd.BackgroundImage = My.Resources.Modify
    End Sub

    Private Sub ToggleButtonSelect()
        OrderSelect.Text = ""
        If (ToggleSelect) Then
            OrderSelect.BackgroundImage = My.Resources.Modify
            OrderSelect.Image = My.Resources.LabelSelect
            OrderSelect.Cursor = Cursors.Hand
        Else
            OrderSelect.BackgroundImage = My.Resources.ModifyDisabled
            OrderSelect.Image = My.Resources.LabelSelectDisabled
            OrderSelect.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ToggleButtonAdd()

        If (ToggleAdd) Then
            OrderAdd.BackgroundImage = My.Resources.Modify
            OrderAdd.Image = My.Resources.LabelAdd
            OrderAdd.Cursor = Cursors.Hand
        Else
            OrderAdd.BackgroundImage = My.Resources.ModifyDisabled
            OrderAdd.Image = My.Resources.LabelAddDisabled
            OrderAdd.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderSelect_Click(sender As Object, e As EventArgs) Handles OrderSelect.Click
        If ToggleSelect = False Then
            Return
        End If
        ToggleDelete = Not ToggleDelete
        If (ToggleDelete) Then
            OrderDelete.BackgroundImage = My.Resources.Modify
            OrderDelete.Image = My.Resources.LabelDelete
            OrderDelete.Cursor = Cursors.Hand

            OrderSelect.Image = Nothing
            OrderSelect.Text = "Cancel"


        Else
            OrderDelete.BackgroundImage = My.Resources.ModifyDisabled
            OrderDelete.Image = My.Resources.LabelDeleteDisabled
            OrderDelete.Cursor = Cursors.Default

            OrderSelect.Text = ""
            OrderSelect.Image = My.Resources.LabelSelect

        End If
        DisplayOrderList()
    End Sub

    Private Sub OrderDelete_Click(sender As Object, e As EventArgs) Handles OrderDelete.Click
        If ToggleDelete = False Then
            Return
        End If


        For i As Integer = 0 To SelectedItems.Count - 1

            OrderStocks(SelectedItems(i)) += CurrentOrderList(SelectedItems(i))
            CurrentOrderList(SelectedItems(i)) = 0

        Next
        DisplayOrderList()
        If OrderPanel.Enabled Then
            DisplayAddOrderList()
        End If

    End Sub



    Private Sub OrderAdd_Click(sender As Object, e As EventArgs) Handles OrderAdd.Click
        If ToggleAdd = False Then
            Return
        End If

        If OrderPanel.Enabled Then
            OrderPanel.Visible = False
            OrderPanel.Enabled = False
            OrderAdd.Image = My.Resources.LabelAdd

            Label2.Visible = True
            OrderAdd.Text = ""
            PendingOrdersPanel.Visible = True
            PendingOrdersPanel.Enabled = True
        Else
            Label2.Visible = False
            PendingOrdersPanel.Visible = False
            PendingOrdersPanel.Enabled = False

            OrderPanel.Visible = True
            OrderPanel.Enabled = True
            OrderAdd.Image = Nothing
            OrderAdd.Text = "Cancel"

            DisplayAddOrderList()

        End If

    End Sub
    Dim SelectedMOP As String = "Cash"


    Private Sub PMCash_Click(sender As Object, e As EventArgs) Handles PMCash.Click
        If (SelectedMOP IsNot "Cash") Then
            SelectedMOP = "Cash"
            PMCash.BackgroundImage = My.Resources.PaymentSelected


            PMCard.BackgroundImage = My.Resources.PaymentBG
            PMEWallet.BackgroundImage = My.Resources.PaymentBG
        End If
    End Sub

    Private Sub PMCard_Click(sender As Object, e As EventArgs) Handles PMCard.Click
        If (SelectedMOP IsNot "Card") Then
            SelectedMOP = "Card"
            PMCard.BackgroundImage = My.Resources.PaymentSelected


            PMCash.BackgroundImage = My.Resources.PaymentBG
            PMEWallet.BackgroundImage = My.Resources.PaymentBG
        End If
    End Sub

    Private Sub PMEWallet_Click(sender As Object, e As EventArgs) Handles PMEWallet.Click
        If (SelectedMOP IsNot "E-Wallet") Then
            SelectedMOP = "E-Wallet"
            PMEWallet.BackgroundImage = My.Resources.PaymentSelected

            PMCash.BackgroundImage = My.Resources.PaymentBG
            PMCard.BackgroundImage = My.Resources.PaymentBG
        End If
    End Sub



    Private Sub PMCard_Enter(sender As Object, e As EventArgs) Handles PMCard.MouseEnter
        If (SelectedMOP = "Card") Then
            PMCard.BackgroundImage = My.Resources.PaymentSelectedHovered
        Else
            PMCard.BackgroundImage = My.Resources.PaymentBGHovered
        End If
    End Sub

    Private Sub PMCard_Leave(sender As Object, e As EventArgs) Handles PMCard.MouseLeave

        If (SelectedMOP = "Card") Then
            PMCard.BackgroundImage = My.Resources.PaymentSelected
        Else
            PMCard.BackgroundImage = My.Resources.PaymentBG
        End If
    End Sub


    Private Sub PMCash_Enter(sender As Object, e As EventArgs) Handles PMCash.MouseEnter
        If (SelectedMOP = "Cash") Then
            PMCash.BackgroundImage = My.Resources.PaymentSelectedHovered
        Else
            PMCash.BackgroundImage = My.Resources.PaymentBGHovered
        End If
    End Sub

    Private Sub PMCash_Leave(sender As Object, e As EventArgs) Handles PMCash.MouseLeave
        If (SelectedMOP = "Cash") Then
            PMCash.BackgroundImage = My.Resources.PaymentSelected
        Else
            PMCash.BackgroundImage = My.Resources.PaymentBG
        End If
    End Sub



    Private Sub PMEWallet_Enter(sender As Object, e As EventArgs) Handles PMEWallet.MouseEnter

        If (SelectedMOP = "E-Wallet") Then
            PMEWallet.BackgroundImage = My.Resources.PaymentSelectedHovered
        Else
            PMEWallet.BackgroundImage = My.Resources.PaymentBGHovered
        End If
    End Sub

    Private Sub PMEWallet_Leave(sender As Object, e As EventArgs) Handles PMEWallet.MouseLeave
        If (SelectedMOP = "E-Wallet") Then
            PMEWallet.BackgroundImage = My.Resources.PaymentSelected
        Else
            PMEWallet.BackgroundImage = My.Resources.PaymentBG
        End If
    End Sub
    Public Sub SessionDefaults()
        ToggleDelete = False
        ToggleSelect = False
        ToggleAdd = False
        IsUpdating = False
        TotalCost = 0
        CustomerName = ""
        OrderListID = 0

        CurrentSelectedOrder = Nothing
        CurrentSelected = ""
        IsSet = False
        CurrentDay = ""

        SelectedItems.Clear()
        For i As Integer = 0 To CurrentOrderList.Length - 1
            CurrentOrderList(i) = 0
        Next

        OrderNumbers.Clear()
        ChangeVal = 0

        OrderAdd.BackgroundImage = My.Resources.ModifyDisabled
        OrderAdd.Image = My.Resources.LabelAddDisabled
        OrderAdd.Cursor = Cursors.Default

        OrderSelect.BackgroundImage = My.Resources.ModifyDisabled
        OrderSelect.Image = My.Resources.LabelSelectDisabled
        OrderSelect.Cursor = Cursors.Default

        OrderDelete.BackgroundImage = My.Resources.ModifyDisabled
        OrderDelete.Image = My.Resources.LabelDeleteDisabled
        OrderDelete.Cursor = Cursors.Default

        SelectedMOP = "Cash"

        PMCash.BackgroundImage = My.Resources.PaymentSelected

        PMCard.BackgroundImage = My.Resources.PaymentBG

        PMEWallet.BackgroundImage = My.Resources.PaymentBG

        DisplayOrderList()
        DisplayPendingOrders()

        Label2.Visible = True
        OrderPanel.Visible = False
        OrderPanel.Enabled = False
        OrderSelect.Text = ""
        OrderAdd.Text = ""
        PendingOrdersPanel.Visible = True
        PendingOrdersPanel.Enabled = True
        AutoRefresh = True
        DBRefresh()
    End Sub
    Private Sub SignOut_Click(sender As Object, e As EventArgs) Handles SignOut.Click
        LoggedOut()
        SessionDefaults()


        TimeIn = ""
        TimeOut = ""
        EmployeeUILogin.IsLoggedIn = False
        EmployeeUILogin.Username.Text = ""
        EmployeeUILogin.Password.Text = ""
        LoggedUserID = 0
        LoggedUserName = ""
        '    Me.Hide()
        EmployeeUILogin.ShowDialog()

    End Sub

    Private Sub ButtonPlace_Click(sender As Object, e As EventArgs) Handles ButtonPlace.Click
        If (IsSet = False) Then
            Return
        End If
        EmployeeUIPopUp.SetOrderProperties(Val(CurrentSelected), TotalCost, True, SelectedMOP)
        EmployeeUIPopUp.EmployeeID = LoggedUserID
        EmployeeUIPopUp.EmployeeName = LoggedUserName
        EmployeeUIPopUp.OrderList = CurrentOrderList
        EmployeeUIPopUp.OrderListId = OrderListID
        EmployeeUIPopUp.TotalOrderCost = TotalCost
        BGOverlay.Show()
        EmployeeUIPopUp.Show()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        If (IsSet = False) Then
            Return
        End If
        EmployeeUIPopUp.SetOrderProperties(Val(CurrentSelected), TotalCost, False, "")
        BGOverlay.Show()
        EmployeeUIPopUp.Show()
    End Sub
End Class