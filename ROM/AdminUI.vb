'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class AdminUI




    Dim SelectedTab As Integer = 1
    Dim PreviousTab As Label = ButtonDashboard

    Dim SalesSelected As Integer = 1
    Dim TotalSalesValue As Integer
    Dim TotalOrdersValue As Integer


    Private Sub AdminUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminUILogin.ShowDialog()

        PreviousTab = New Label()
        PreviousTab = ButtonDashboard


        DashboardSelection.Location = New Point(0, 63)


        DashboardPanel.Invalidate()
        DashboardPanel.Update()
        TimeDelay.Start()

    End Sub
    Dim Delay_ms As Integer = 0
    Private Sub TimeDelay_Tick(sender As Object, e As EventArgs) Handles TimeDelay.Tick

        If Delay_ms < 100 Then
            Delay_ms += 50
        Else
            TimeDelay.Stop()
            GetRecentSales()
            DisplayRecentSession()

            DisplayStockAlert()
            ChartWeek2()
        End If


    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        If (SelectedTab = 1) Then
            Return
        End If


        SelectedTab = 1

        PreviousTab.ForeColor = Color.White
        PreviousTab.BackColor = Color.FromArgb(228, 135, 114)
        PreviousTab.Cursor = Cursors.Hand

        ButtonDashboard.ForeColor = Color.FromArgb(228, 135, 114)
        ButtonDashboard.BackColor = Color.White
        ButtonDashboard.Cursor = Cursors.Default
        PreviousTab = New Label()
        PreviousTab = ButtonDashboard



        IconInventory.BackgroundImage = My.Resources.IconInventory
        IconSales.BackgroundImage = My.Resources.IconSales
        IconEmployee.BackgroundImage = My.Resources.IconEmployee
        IconDashboard.BackgroundImage = My.Resources.IconDashboardSelected

        IconInventory.BackColor = Color.FromArgb(228, 135, 114)
        IconSales.BackColor = Color.FromArgb(228, 135, 114)
        IconEmployee.BackColor = Color.FromArgb(228, 135, 114)
        IconDashboard.BackColor = Color.White


        DashboardSelection.Location = New Point(0, 63)

        SideBar.Invalidate()
        SideBar.Update()

        SalesPanel.Enabled = False
        SalesPanel.Visible = False

        EmployeePanel.Enabled = False
        EmployeePanel.Visible = False

        InventoryPanel.Enabled = False
        InventoryPanel.Visible = False

        DashboardPanel.Enabled = True
        DashboardPanel.Visible = True
        DashboardPanel.Invalidate()
        DashboardPanel.Update()
        GetRecentSales()
        DisplayRecentSession()

        DisplayStockAlert()
        ChartWeek2()

    End Sub


    Private Sub ButtonInventory_Click(sender As Object, e As EventArgs) Handles ButtonInventory.Click
        If (SelectedTab = 2) Then
            Return
        End If

        SelectedTab = 2

        PreviousTab.ForeColor = Color.White
        PreviousTab.BackColor = Color.FromArgb(228, 135, 114)
        PreviousTab.Cursor = Cursors.Hand

        ButtonInventory.ForeColor = Color.FromArgb(228, 135, 114)
        ButtonInventory.BackColor = Color.White
        ButtonInventory.Cursor = Cursors.Default
        PreviousTab = New Label()
        PreviousTab = ButtonInventory


        IconDashboard.BackgroundImage = My.Resources.IconDashboard
        IconSales.BackgroundImage = My.Resources.IconSales
        IconEmployee.BackgroundImage = My.Resources.IconEmployee
        IconInventory.BackgroundImage = My.Resources.IconInventorySelected

        IconSales.BackColor = Color.FromArgb(228, 135, 114)
        IconEmployee.BackColor = Color.FromArgb(228, 135, 114)
        IconDashboard.BackColor = Color.FromArgb(228, 135, 114)
        IconInventory.BackColor = Color.White

        DashboardSelection.Location = New Point(0, 103)


        SideBar.Invalidate()
        SideBar.Update()
        DashboardPanel.Enabled = False
        DashboardPanel.Visible = False
        SalesPanel.Enabled = False
        SalesPanel.Visible = False

        EmployeePanel.Enabled = False
        EmployeePanel.Visible = False

        InventoryPanel.Enabled = True
        InventoryPanel.Visible = True
        InventoryPanel.Invalidate()
        InventoryPanel.Update()
        DisplayStock()
    End Sub


    Private Sub ButtonSales_Click(sender As Object, e As EventArgs) Handles ButtonSales.Click
        If (SelectedTab = 3) Then
            Return
        End If


        SelectedTab = 3

        PreviousTab.ForeColor = Color.White
        PreviousTab.BackColor = Color.FromArgb(228, 135, 114)
        PreviousTab.Cursor = Cursors.Hand

        ButtonSales.ForeColor = Color.FromArgb(228, 135, 114)
        ButtonSales.BackColor = Color.White
        ButtonSales.Cursor = Cursors.Default


        PreviousTab = New Label()
        PreviousTab = ButtonSales

        IconDashboard.BackgroundImage = My.Resources.IconDashboard
        IconInventory.BackgroundImage = My.Resources.IconInventory
        IconEmployee.BackgroundImage = My.Resources.IconEmployee
        IconSales.BackgroundImage = My.Resources.IconSalesSelected


        IconInventory.BackColor = Color.FromArgb(228, 135, 114)
        IconEmployee.BackColor = Color.FromArgb(228, 135, 114)
        IconDashboard.BackColor = Color.FromArgb(228, 135, 114)
        IconSales.BackColor = Color.White

        DashboardSelection.Location = New Point(0, 143)

        SideBar.Invalidate()
        SideBar.Update()

        DashboardPanel.Enabled = False
        DashboardPanel.Visible = False
        EmployeePanel.Enabled = False
        EmployeePanel.Visible = False
        InventoryPanel.Enabled = False
        InventoryPanel.Visible = False


        SalesPanel.Enabled = True
        SalesPanel.Visible = True
        SalesPanel.Invalidate()
        SalesPanel.Update()
        SalesPanelLoad()
    End Sub

    Private Sub SalesPanelLoad()


        '  SalesPanel.Enabled = True
        '   SalesPanel.Visible = True

        LoadSalesHistory()

        ChartWeek()

    End Sub
    Private Sub ButtonEmployee_Click(sender As Object, e As EventArgs) Handles ButtonEmployee.Click
        If (SelectedTab = 4) Then
            Return

        End If



        SelectedTab = 4

        PreviousTab.ForeColor = Color.White
        PreviousTab.BackColor = Color.FromArgb(228, 135, 114)
        PreviousTab.Cursor = Cursors.Hand

        ButtonEmployee.ForeColor = Color.FromArgb(228, 135, 114)
        ButtonEmployee.BackColor = Color.White
        ButtonEmployee.Cursor = Cursors.Default
        PreviousTab = New Label()
        PreviousTab = ButtonEmployee

        IconDashboard.BackgroundImage = My.Resources.IconDashboard
        IconInventory.BackgroundImage = My.Resources.IconInventory
        IconSales.BackgroundImage = My.Resources.IconSales
        IconEmployee.BackgroundImage = My.Resources.IconEmployeeSelected


        IconInventory.BackColor = Color.FromArgb(228, 135, 114)
        IconSales.BackColor = Color.FromArgb(228, 135, 114)
        IconDashboard.BackColor = Color.FromArgb(228, 135, 114)
        IconEmployee.BackColor = Color.White

        DashboardSelection.Location = New Point(0, 183)


        SideBar.Invalidate()
        SideBar.Update()
        DashboardPanel.Enabled = False
        DashboardPanel.Visible = False

        InventoryPanel.Enabled = False
        InventoryPanel.Visible = False

        SalesPanel.Enabled = False
        SalesPanel.Visible = False

        EmployeePanel.Enabled = True
        EmployeePanel.Visible = True
        EmployeePanel.Invalidate()
        EmployeePanel.Update()
        LoadSessions()
    End Sub
    Dim Chart As Graphics

    Private Sub DisplayChart(Values() As Integer)

        TotalSalesValue = 0
        Chart = ChartPanel.CreateGraphics()
        Chart.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Chart.Clear(Me.BackColor)

        Dim PanelWidth As Integer = 600
        Dim PanelHeight As Integer = 180

        Dim X_Length = Values.Length
        Dim X_Point As Double = Math.Round(PanelWidth / (X_Length - 1), 2)
        Dim HighestValue As Integer = Values.Max


        Dim Y_Point As Integer
        Dim Points(X_Length + 1) As Point

        Points(0) = New Point(0, PanelHeight + (PanelHeight / 2))


        For i As Integer = 0 To Values.Length - 1
            Dim y = Math.Round(Values(i) / HighestValue, 2)

            Y_Point = PanelHeight - (PanelHeight * y) + 50
            Points(i + 1) = New Point(X_Point * i, Y_Point)
            TotalSalesValue += Values(i)

        Next

        Points(X_Length + 1) = New Point(X_Point * (Values.Length - 1), PanelHeight + (PanelHeight / 2))

        Dim FillBrush As LinearGradientBrush
        Dim OutlineBrush As Pen

        Dim Color1 As Color = Color.FromArgb(227, 135, 114)
        Dim Color2 As Color = Color.White

        FillBrush = New LinearGradientBrush(New Point(0, PanelHeight + (PanelHeight / 2.5)), New Point(0, 0), Color2, Color1)
        OutlineBrush = New Pen(Color1, 2)

        Dim HvalDisplay = 0
        While HvalDisplay < HighestValue
            If (HvalDisplay < 100) Then
                HvalDisplay += 10
            Else

                HvalDisplay += 100
            End If
        End While
        LabelValue1.Text = HvalDisplay
        LabelValue2.Text = HvalDisplay * 0.75
        LabelValue3.Text = HvalDisplay * 0.5
        LabelValue4.Text = HvalDisplay * 0.25

        TotalSalesLabel.Text = "₱" + TotalSalesValue.ToString("#,##0")
        TotalOrdersLabel.Text = TotalOrdersValue.ToString
        Chart.FillClosedCurve(FillBrush, Points)
        Chart.DrawClosedCurve(OutlineBrush, Points)

    End Sub






    Private Sub ChartButtonMonth_Click(sender As Object, e As EventArgs) Handles ChartButtonMonth.Click
        If SalesSelected = 1 Then
            Return
        End If

        SalesSelected = 1

        ChartButtonDay.ForeColor = Color.Gray
        ChartButtonWeek.ForeColor = Color.Gray
        ChartButtonMonth.ForeColor = Color.FromArgb(228, 135, 114)

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If
        Dim Sales As New List(Of Integer)()
        TotalOrdersValue = 0
        Try
            Dim cmd As New MySqlCommand("SELECT `Order_Number`, `Date_Purchased` FROM transactions WHERE YEAR(Date_Purchased) = YEAR(CURDATE()) AND MONTH(Date_Purchased) = MONTH(CURDATE()) ORDER BY Date_Purchased ASC;", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            Dim OrderIDs As New List(Of Integer)()
            Dim OrdersPurchased As New List(Of String)()
            While reader.Read

                OrderIDs.Add(reader.GetInt32("Order_Number"))
                Dim Purchase_date = reader.GetDateTime("Date_Purchased")
                OrdersPurchased.Add(Purchase_date.ToString("dd"))
                TotalOrdersValue += 1
            End While

            reader.Close()
            Dim total = 0
            Dim OrderPK() = OrderIDs.ToArray
            Dim PrevDay As String = ""
            '  Dim Average = 0
            '  '    Dim Changed = False
            For d As Integer = 0 To Val(OrdersPurchased(0)) - 1
                Sales.Add(0)
            Next
            For i As Integer = 0 To OrderPK.Length - 1

                cmd.CommandText = "SELECT `TotalOrder_Cost` FROM `order` WHERE `Order_Number` ='" & OrderPK(i) & "'"

                Dim reader2 As MySqlDataReader = cmd.ExecuteReader
                If reader2.Read Then

                    total = reader2.GetInt32("TotalOrder_Cost")

                End If
                If (PrevDay <> (OrdersPurchased(i).ToString)) Then
                    PrevDay = OrdersPurchased(i).ToString
                    Sales.Add(0)
                End If
                Sales(Val(OrdersPurchased(i))) += total
                'MessageBox.Show("date:" + (Val(OrdersPurchased(i))).ToString + "Total:" + total.ToString + "Avg:" + avg.ToString)


                ' If (PrevDay = OrdersPurchased(i)) Then
                '   Average += total
                '   Changed = True
                '   Else
                '   PrevDay = OrdersPurchased(i)
                '   If (Changed) Then
                '     Average += total
                '     Changed = False
                ' Else

                '      Average = total
                '  End If

                '   MessageBox.Show(Average)
                ' Sales.Add(Average)
                '   End If
                reader2.Close()
            Next



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Dim SalesArray() As Integer = Sales.ToArray()

        DisplayChart(SalesArray)

    End Sub

    Private Sub ChartWeek()
        SalesSelected = 2
        ChartButtonDay.ForeColor = Color.Gray
        ChartButtonMonth.ForeColor = Color.Gray
        ChartButtonWeek.ForeColor = Color.FromArgb(228, 135, 114)

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If

        Dim Sales As New List(Of Integer)()
        TotalOrdersValue = 0
        Try
            Dim cmd As New MySqlCommand("SELECT `Order_Number`, `Date_Purchased` FROM transactions WHERE YEARWEEK(Date_Purchased) = YEARWEEK(CURDATE()) ORDER BY Date_Purchased  ASC;", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            Dim OrderIDs As New List(Of Integer)()
            Dim OrdersPurchased As New List(Of String)()
            While reader.Read

                OrderIDs.Add(reader.GetInt32("Order_Number"))
                '  OrdersPurchased.Add(((reader.GetDateTime("Date_Purchased")).Date).ToString)
                Dim Purchase_date = reader.GetDateTime("Date_Purchased")
                OrdersPurchased.Add(Purchase_date.ToString("dd"))
                TotalOrdersValue += 1
            End While

            reader.Close()
            Dim total = 0
            Dim OrderPK() = OrderIDs.ToArray
            Dim PrevDay As String = ""
            '  Dim Average = 0

            Dim Day As Integer = 0
            Sales.Add(0)
            Dim MultipleLimiter = 0
            Dim Multiple = 0
            For i As Integer = 0 To OrderPK.Length - 1
                cmd.CommandText = "SELECT `TotalOrder_Cost` FROM `order` WHERE `Order_Number` ='" & OrderPK(i) & "'"

                Dim reader2 As MySqlDataReader = cmd.ExecuteReader
                If reader2.Read Then

                    total = reader2.GetInt32("TotalOrder_Cost")

                End If
                If (MultipleLimiter = 4) Then
                    MultipleLimiter = 0
                    Multiple += 1
                    Sales.Add(0)
                ElseIf (PrevDay <> (OrdersPurchased(i).ToString)) Then


                    PrevDay = OrdersPurchased(i).ToString
                    Sales.Add(0)
                    Day += 1
                Else
                    MultipleLimiter += 1
                End If


                Sales(Day + Multiple) += total
                '    MessageBox.Show("Sales index:" + (Day + Multiple).ToString + "Value:" + Sales(Day + Multiple).ToString)
                ' MessageBox.Show("Day:" + Day.ToString + "Limiter:" + Multiple.ToString + " Total:" + Sales(Day).ToString)
                '  If (PrevDay = OrdersPurchased(i)) Then
                '       Average += total
                '   Else
                '        PrevDay = OrdersPurchased(i)
                '        Average = total
                '        Sales.Add(Average)
                '    End If
                'Sales.Add(total)
                If (Sales.Count = 0) Then
                    MessageBox.Show("Empty")
                End If
                reader2.Close()
            Next



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Dim SalesArray() As Integer = Sales.ToArray()

        DisplayChart(SalesArray)
    End Sub
    Private Sub ChartButtonWeek_Click(sender As Object, e As EventArgs) Handles ChartButtonWeek.Click
        If SalesSelected = 2 Then
            Return
        End If
        ChartWeek()

    End Sub

    Private Sub ChartButtonDay_Click(sender As Object, e As EventArgs) Handles ChartButtonDay.Click
        If SalesSelected = 3 Then
            Return
        End If

        SalesSelected = 3

        ChartButtonMonth.ForeColor = Color.Gray
        ChartButtonWeek.ForeColor = Color.Gray
        ChartButtonDay.ForeColor = Color.FromArgb(228, 135, 114)

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If
        TotalOrdersValue = 0
        Dim Sales As New List(Of Integer)()

        Try
            Dim cmd As New MySqlCommand("SELECT `Order_Number` FROM transactions WHERE DATE(Date_Purchased) = CURDATE() ORDER BY Date_Purchased  ASC;", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            Dim OrderIDs As New List(Of Integer)()

            While reader.Read

                OrderIDs.Add(reader.GetInt32("Order_Number"))
                TotalOrdersValue += 1
            End While

            reader.Close()
            Dim total = 0
            Dim OrderPK() = OrderIDs.ToArray

            For i As Integer = 0 To OrderPK.Length - 1
                cmd.CommandText = "SELECT `TotalOrder_Cost` FROM `order` WHERE `Order_Number` ='" & OrderPK(i) & "'"

                Dim reader2 As MySqlDataReader = cmd.ExecuteReader
                If reader2.Read Then

                    total = reader2.GetInt32("TotalOrder_Cost")


                End If
                Sales.Add(total)
                reader2.Close()
            Next
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try




        If (Sales.Count = 0) Then


            Dim HvalDisplay = 1000
            LabelValue1.Text = HvalDisplay

            LabelValue2.Text = HvalDisplay * 0.75

            LabelValue3.Text = HvalDisplay * 0.5

            LabelValue4.Text = HvalDisplay * 0.25

            Chart = ChartPanel.CreateGraphics()
            Chart.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            Chart.Clear(Me.BackColor)

        ElseIf (Sales.Count = 1) Then
            Sales.Add(0)
            Dim SalesArray() As Integer = Sales.ToArray()
            DisplayChart(SalesArray)
        Else



            Dim SalesArray() As Integer = Sales.ToArray()
            DisplayChart(SalesArray)
        End If


    End Sub
    Dim SalesHistoryPage As Integer = 1
    Dim SearchValue As String = ""
    Dim Searched As Boolean = False

    Private Sub PageNext_Click(sender As Object, e As EventArgs) Handles PageNext.Click
        If (SalesHistoryPage > 19) Then
            Return
        End If

        If (SalesHistoryPage = 19) Then
            NextPage.ForeColor = Color.FromArgb(228, 135, 114)
        End If



        PrevPage.ForeColor = Color.White
        SalesHistoryPage += 1
        LoadSalesHistory()
    End Sub

    Private Sub PagePrev_Click(sender As Object, e As EventArgs) Handles PagePrev.Click
        If (SalesHistoryPage < 2) Then
            Return
        End If

        If (SalesHistoryPage = 2) Then
            PrevPage.ForeColor = Color.FromArgb(228, 135, 114)
        End If


        NextPage.ForeColor = Color.White
        SalesHistoryPage -= 1
        LoadSalesHistory()
    End Sub
    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles NextPage.Click
        If (SalesHistoryPage > 19) Then
            Return
        End If

        If (SalesHistoryPage = 19) Then
            NextPage.ForeColor = Color.FromArgb(228, 135, 114)
        End If



        PrevPage.ForeColor = Color.White
        SalesHistoryPage += 1
        LoadSalesHistory()
    End Sub

    Private Sub PrevPage_Click(sender As Object, e As EventArgs) Handles PrevPage.Click
        If (SalesHistoryPage < 2) Then
            Return
        End If

        If (SalesHistoryPage = 2) Then
            PrevPage.ForeColor = Color.FromArgb(228, 135, 114)
        End If


        NextPage.ForeColor = Color.White
        SalesHistoryPage -= 1
        LoadSalesHistory()
    End Sub



    Private Sub LoadSalesHistory()

        CurrentPage.Text = SalesHistoryPage
        NextPage.Text = SalesHistoryPage + 1
        PrevPage.Text = SalesHistoryPage - 1
        Dim TransactID As New List(Of Integer)()
        Dim OrderListID As New List(Of Integer)()
        Dim OrderNumber As New List(Of Integer)()
        Dim TotalCost As New List(Of Integer)()

        Dim DatePurchased As New List(Of String)()
        Dim TimePurchased As New List(Of String)()
        Dim PaymentMethod As New List(Of String)()
        Dim CustomerName As New List(Of String)()
        Dim EmployeeName As New List(Of String)()

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If
        Try
            Dim PageSkip = 6 * (SalesHistoryPage - 1)
            Dim cmd As New MySqlCommand("", DBConn.Connection)
            If (Searched) Then
                cmd.CommandText =
               "SELECT t.Transaction_ID, t.Order_Number, o.TotalOrder_Cost, t.Date_Purchased, t.ModeOfPayment ,o.Customer_Name, o.Employee_Name, o.OrderList_ID
                FROM transactions t
                JOIN `order` o ON t.Order_Number = o.Order_Number
               WHERE t.ModeOfPayment LIKE '%" & SearchValue & "%' or o.Customer_Name LIKE '%" & SearchValue & "%' or o.Employee_Name LIKE '%" & SearchValue & "%'
                ORDER BY t.Date_Purchased DESC
                LIMIT   " & PageSkip & " ,6;"

            Else

                cmd.CommandText =
                    "SELECT t.Transaction_ID, t.Order_Number, o.TotalOrder_Cost, t.Date_Purchased, t.ModeOfPayment ,o.Customer_Name, o.Employee_Name, o.OrderList_ID
                FROM transactions t
                JOIN `order` o ON t.Order_Number = o.Order_Number
                ORDER BY t.Date_Purchased DESC
                LIMIT " & PageSkip & " ,6;"
            End If
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read
                TransactID.Add(reader.GetInt32("Transaction_ID"))
                OrderListID.Add(reader.GetInt32("OrderList_ID"))
                OrderNumber.Add(reader.GetInt32("Order_Number"))
                TotalCost.Add(reader.GetInt32("TotalOrder_Cost"))

                Dim DateValue As DateTime = reader.GetDateTime("Date_Purchased")
                DatePurchased.Add(DateValue.ToString("yyyy-MM-dd"))
                TimePurchased.Add(DateValue.ToString("hh:mm:tt"))

                PaymentMethod.Add(reader.GetString("ModeOfPayment"))
                CustomerName.Add(reader.GetString("Customer_Name"))
                EmployeeName.Add(reader.GetString("Employee_Name"))
            End While
            reader.Close()
        Catch ex As Exception

        End Try
        SalesHistoryContainer.Controls.Clear()

        For i As Integer = 0 To TransactID.Count - 1

            Dim DataPanel As New Panel()
            DataPanel.BackColor = If((i Mod 2), Color.White, Color.FromArgb(252, 242, 240))

            DataPanel.Location = New Point(1, i * 40)
            DataPanel.Size = New Size(1038, 40)

            Dim lcenter = ContentAlignment.MiddleCenter
            Dim lfont = New Font("Arial", 10)
            Dim lfore = Color.FromArgb(89, 89, 89)
            Dim lback = DataPanel.BackColor



            Dim LabelTransact As New Label()
            LabelTransact.Size = New Size(120, 20)
            LabelTransact.TextAlign = lcenter
            LabelTransact.Font = lfont
            LabelTransact.ForeColor = lfore
            LabelTransact.BackColor = lback
            LabelTransact.Location = New Point(8, 10)
            LabelTransact.Text = TransactID(i)


            Dim LabelOrder As New Label()
            LabelOrder.Size = New Size(120, 20)
            LabelOrder.TextAlign = lcenter
            LabelOrder.Font = lfont
            LabelOrder.ForeColor = lfore
            LabelOrder.BackColor = lback
            LabelOrder.Location = New Point(128, 10)
            LabelOrder.Text = OrderNumber(i)

            Dim LabelTotal As New Label()
            LabelTotal.Location = New Point(248, 10)
            LabelTotal.TextAlign = lcenter
            LabelTotal.Font = lfont
            LabelTotal.ForeColor = lfore
            LabelTotal.BackColor = lback
            LabelTotal.Text = TotalCost(i)

            Dim LabelDate As New Label()
            LabelDate.Location = New Point(368, 10)
            LabelDate.TextAlign = lcenter
            LabelDate.Font = lfont
            LabelDate.ForeColor = lfore
            LabelDate.BackColor = lback
            LabelDate.Size = New Size(125, 20)
            LabelDate.Text = DatePurchased(i)

            Dim LabelTime As New Label()
            LabelTime.Location = New Point(500, 10)
            LabelTime.TextAlign = lcenter
            LabelTime.Font = lfont
            LabelTime.ForeColor = lfore
            LabelTime.BackColor = lback
            LabelTime.Size = New Size(130, 20)
            LabelTime.Text = TimePurchased(i)

            Dim LabelPayment As New Label()
            LabelPayment.Location = New Point(637, 10)
            LabelPayment.TextAlign = lcenter
            LabelPayment.Font = lfont
            LabelPayment.ForeColor = lfore
            LabelPayment.BackColor = lback
            LabelPayment.Size = New Size(151, 20)
            LabelPayment.Text = PaymentMethod(i)

            Dim LabelCustomer As New Label()
            LabelCustomer.Location = New Point(788, 10)
            LabelCustomer.TextAlign = lcenter
            LabelCustomer.Font = lfont
            LabelCustomer.ForeColor = lfore
            LabelCustomer.BackColor = lback
            LabelCustomer.Size = New Size(126, 20)
            LabelCustomer.Text = CustomerName(i)

            Dim LabelEmployee As New Label()
            LabelEmployee.Location = New Point(913, 10)
            LabelEmployee.TextAlign = lcenter
            LabelEmployee.Font = lfont
            LabelEmployee.ForeColor = lfore
            LabelEmployee.BackColor = lback
            LabelEmployee.Size = New Size(114, 20)
            LabelEmployee.Text = EmployeeName(i)

            SalesHistoryContainer.Controls.Add(DataPanel)
            DataPanel.Controls.Add(LabelTransact)
            DataPanel.Controls.Add(LabelOrder)
            DataPanel.Controls.Add(LabelTotal)
            DataPanel.Controls.Add(LabelDate)
            DataPanel.Controls.Add(LabelTime)
            DataPanel.Controls.Add(LabelPayment)
            DataPanel.Controls.Add(LabelCustomer)
            DataPanel.Controls.Add(LabelEmployee)


        Next
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchValue = SearchTextBox.Text
        SalesHistoryPage = 1
        PrevPage.ForeColor = Color.FromArgb(228, 135, 114)
        LoadSalesHistory()
    End Sub
    Private Sub SearchButton_Enter(sender As Object, e As EventArgs) Handles SearchButton.MouseEnter
        SearchButton.Image = My.Resources.IconSearchHovered
    End Sub
    Private Sub SearchButton_Leave(sender As Object, e As EventArgs) Handles SearchButton.MouseLeave
        SearchButton.Image = My.Resources.IconSearch
    End Sub
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If (SearchTextBox.Text = "") Then
            Searched = False
        Else
            Searched = True
        End If

    End Sub
































    Dim MultipleSelection As New List(Of Boolean)()
    Dim IsMultiple As Boolean = False
    Dim IsSet As Boolean = True
    Dim PreviousCheck As Button
    Dim PreviousCheckValidated = False
    Dim ToggleMultipleAll = True
    Dim StockValues As New List(Of Integer)()
    Dim SingleSelection As Integer
    Dim TextBoxValue As String

    Dim Status As Integer = 1
    Dim ProductID As New List(Of String)()
    Dim CurrentStockValueUpdate As Integer
    Dim CheckBoxes As New List(Of Button)()

    Private Sub StatusOptionA_Click(sender As Object, e As EventArgs) Handles StatusOptionA.Click
        If Status = 1 Then
            Return
        End If
        Status = 1


        StatusOptionB.ForeColor = Color.FromArgb(242, 179, 161)
        StatusOptionB.Font = New Font("Candara", 10, FontStyle.Regular)
        StatusOptionC.ForeColor = Color.FromArgb(242, 179, 161)
        StatusOptionC.Font = New Font("Candara", 10, FontStyle.Regular)

        StatusOptionA.ForeColor = Color.FromArgb(228, 135, 114)
        StatusOptionA.Font = New Font("Candara", 10, FontStyle.Bold)
    End Sub
    Private Sub StatusOptionB_Click(sender As Object, e As EventArgs) Handles StatusOptionB.Click
        If Status = 2 Then
            Return
        End If
        Status = 2

        StatusOptionA.ForeColor = Color.FromArgb(242, 179, 161)
        StatusOptionA.Font = New Font("Candara", 10, FontStyle.Regular)
        StatusOptionC.ForeColor = Color.FromArgb(242, 179, 161)
        StatusOptionC.Font = New Font("Candara", 10, FontStyle.Regular)

        StatusOptionB.ForeColor = Color.FromArgb(228, 135, 114)
        StatusOptionB.Font = New Font("Candara", 10, FontStyle.Bold)
    End Sub


    Private Sub StatusOptionC_Click(sender As Object, e As EventArgs) Handles StatusOptionC.Click
        If Status = 3 Then
            Return
        End If
        Status = 3

        StatusOptionA.ForeColor = Color.FromArgb(242, 179, 161)
        StatusOptionA.Font = New Font("Candara", 10, FontStyle.Regular)
        StatusOptionB.ForeColor = Color.FromArgb(242, 179, 161)
        StatusOptionB.Font = New Font("Candara", 10, FontStyle.Regular)

        StatusOptionC.ForeColor = Color.FromArgb(228, 135, 114)
        StatusOptionC.Font = New Font("Candara", 10, FontStyle.Bold)
    End Sub


    Private Sub LabelUpdateInfo()

        If (TextBoxValue = "") Then
            Return
        End If
        If (IsSet) Then
            If (IsMultiple) Then
                OldAmountValue.Text = "N:"
                NewAmountValue.Text = "A:" + TextBoxValue.ToString

            Else
                OldAmountValue.Text = (StockValues(SingleSelection)).ToString
                NewAmountValue.Text = TextBoxValue.ToString

                CurrentStockValueUpdate = Val(TextBoxValue)
            End If

        Else
            If (IsMultiple) Then
                OldAmountValue.Text = "N"
                NewAmountValue.Text = "A+" + TextBoxValue.ToString

            Else
                OldAmountValue.Text = (StockValues(SingleSelection)).ToString
                NewAmountValue.Text = ((StockValues(SingleSelection)) + TextBoxValue).ToString
                CurrentStockValueUpdate = Val((StockValues(SingleSelection)) + TextBoxValue)
            End If

        End If
    End Sub
    Private Sub SetStockTextbox_TextChanged(sender As Object, e As EventArgs) Handles SetStockTextbox.TextChanged

        TextBoxValue = Val(SetStockTextbox.Text)
        LabelUpdateInfo()

    End Sub


    Private Sub AddStockTextbox_TextChanged(sender As Object, e As EventArgs) Handles AddStockTextbox.TextChanged

        TextBoxValue = Val(AddStockTextbox.Text)
        LabelUpdateInfo()
    End Sub

    Private Sub SetStockTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SetStockTextbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    Private Sub AddStockTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AddStockTextbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub



    Private Sub ToggleItemCheck(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        If (IsMultiple) Then
            If MultipleSelection(button.Name) = True Then

                MultipleSelection(button.Name) = False
                button.BackgroundImage = My.Resources.CheckUnselected
            Else

                MultipleSelection(button.Name) = True
                button.BackgroundImage = My.Resources.CheckSelected
            End If

        Else
            SetMultipleSelectionDefaults()
            MultipleSelection(button.Name) = True
            SingleSelection = button.Name
            button.BackgroundImage = My.Resources.CheckSelected

        End If

        LabelUpdateInfo()
    End Sub
    Private Sub SetMultipleSelectionDefaults()
        For i As Integer = 0 To MultipleSelection.Count - 1
            MultipleSelection(i) = False
            CheckBoxes(i).BackgroundImage = My.Resources.CheckUnselected

        Next
    End Sub




    Private Sub CheckBoxAll_Click(sender As Object, e As EventArgs) Handles CheckBoxAll.Click
        If ToggleMultipleAll Then
            ToggleMultipleAll = False
            For i As Integer = 0 To MultipleSelection.Count - 1
                MultipleSelection(i) = True
                CheckBoxes(i).BackgroundImage = My.Resources.CheckSelected

            Next
        Else
            ToggleMultipleAll = True
            SetMultipleSelectionDefaults()
        End If
    End Sub

    Private Sub MultipleButton_Click(sender As Object, e As EventArgs) Handles MultipleButton.Click
        If (IsMultiple) Then
            IsMultiple = False

            MultipleButton.Image = My.Resources.Radio
        Else
            IsMultiple = True
            MultipleButton.Image = My.Resources.RadioSelected
        End If
    End Sub

    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        If (IsSet) Then
            Return
        End If
        IsSet = True
        ChangeOption()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If (IsSet = False) Then
            Return
        End If
        IsSet = False

        ChangeOption()
    End Sub

    Private Sub ChangeOption()
        If (IsSet) Then
            LabelAddValue.ForeColor = Color.FromArgb(172, 172, 172)
            LabelAddStock.ForeColor = Color.FromArgb(172, 172, 172)
            AddStockPanel.Enabled = False
            AddButton.Image = My.Resources.RadioUnselected


            LabelSetValue.ForeColor = Color.FromArgb(89, 89, 89)
            LabelSetStock.ForeColor = Color.FromArgb(89, 89, 89)
            SetStockPanel.Enabled = True
            SetButton.Image = My.Resources.RadioSelected
            AddStockTextbox.Text = ""

        Else
            LabelSetValue.ForeColor = Color.FromArgb(172, 172, 172)
            LabelSetStock.ForeColor = Color.FromArgb(172, 172, 172)
            SetStockPanel.Enabled = False
            SetButton.Image = My.Resources.RadioUnselected
            SetStockTextbox.Text = ""

            LabelAddValue.ForeColor = Color.FromArgb(89, 89, 89)
            LabelAddStock.ForeColor = Color.FromArgb(89, 89, 89)
            AddStockPanel.Enabled = True
            AddButton.Image = My.Resources.RadioSelected




        End If
    End Sub


    Private Sub DisplayStock()
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If


        Dim I_ID As New List(Of String)()
        Dim I_Stock As New List(Of Integer)()
        Dim I_Price As New List(Of Integer)()
        Dim I_Name As New List(Of String)()
        Dim I_Status As New List(Of String)()
        Dim I_Type = New String() {"Meals", "Meals", "Meals", "Meals", "Meals", "Snacks", "Snacks", "Desserts", "Desserts", "Desserts", "Desserts", "Desserts", "Drinks", "Drinks", "Drinks"}


        Try
            Dim cmd As New MySqlCommand("SELECT `ID`, `Product_Name`, `Stocks`, `Status`, `Price` FROM inventory  ", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            Dim i As Integer = 0
            While reader.Read
                I_ID.Add(reader.GetString("ID"))
                I_Stock.Add(reader.GetInt32("Stocks"))
                I_Price.Add(reader.GetInt32("Price"))
                I_Name.Add(reader.GetString("Product_Name"))
                I_Status.Add(reader.GetString("Status"))

            End While
            reader.Close()
        Catch ex As Exception

        End Try
        ProductID = I_ID
        StockValues = I_Stock

        StockInfoContainer.Controls.Clear()
        SetMultipleSelectionDefaults()
        For i As Integer = 0 To 14
            MultipleSelection.Add(False)
            Dim DisplayPanel As New Panel()
            DisplayPanel.Size = New Size(718, 40)
            DisplayPanel.BackColor = If((i Mod 2), Color.White, Color.FromArgb(252, 242, 240))
            DisplayPanel.Location = New Point(0, i * 40)
            DisplayPanel.Name = "panel" + i.ToString

            StockInfoContainer.Controls.Add(DisplayPanel)

            Dim CheckBox As New Button()
            CheckBox.Size = New Size(16, 16)
            CheckBox.BackgroundImage = My.Resources.CheckUnselected
            CheckBox.BackgroundImageLayout = ImageLayout.Center
            CheckBox.FlatStyle = FlatStyle.Flat
            CheckBox.FlatAppearance.BorderSize = 0
            CheckBox.FlatAppearance.MouseDownBackColor = DisplayPanel.BackColor
            CheckBox.FlatAppearance.MouseOverBackColor = DisplayPanel.BackColor
            CheckBox.Cursor = Cursors.Hand
            If SingleSelection = i.ToString Then
                CheckBox.BackgroundImage = My.Resources.CheckSelected
            End If
            CheckBox.Location = New Point(10, 12)
            CheckBox.Name = i.ToString


            CheckBoxes.Add(CheckBox)
            AddHandler CheckBox.Click, AddressOf ToggleItemCheck

            Dim l_font = New Font("Arial", 10, FontStyle.Bold)
            Dim l_size = New Size(120, 40)
            Dim l_align = ContentAlignment.MiddleCenter
            Dim l_fore = Color.FromArgb(89, 89, 89)
            Dim l_back = DisplayPanel.BackColor

            Dim LabelID As New Label
            LabelID.Text = I_ID(i)
            LabelID.Font = l_font
            LabelID.MinimumSize = l_size
            LabelID.TextAlign = l_align
            LabelID.BackColor = l_back
            LabelID.ForeColor = l_fore
            LabelID.Location = New Point(0, 0)


            Dim LabelType As New Label
            LabelType.Text = I_Type(i)
            LabelType.Font = l_font
            LabelType.MinimumSize = l_size
            LabelType.TextAlign = l_align
            LabelType.BackColor = l_back
            LabelType.ForeColor = l_fore
            LabelType.Location = New Point(120, 0)


            Dim LabelName As New Label With {
               .Text = I_Name(i),
               .Font = l_font,
               .MinimumSize = l_size,
               .TextAlign = l_align,
               .BackColor = l_back,
               .ForeColor = l_fore,
                    .Location = New Point(240, 0)
           }

            Dim LabelStock As New Label With {
               .Text = I_Stock(i),
               .Font = l_font,
               .MinimumSize = l_size,
               .TextAlign = l_align,
               .BackColor = l_back,
               .ForeColor = l_fore,
                   .Location = New Point(360, 0)
           }


            Dim LabelStatus As New Label
            LabelStatus.Text = I_Status(i)
            LabelStatus.Font = New Font("Candara", 10)
            LabelStatus.MinimumSize = l_size
            LabelStatus.TextAlign = l_align
            LabelStatus.BackColor = l_back
            If (I_Status(i) = "Available") Then
                LabelStatus.Image = My.Resources.StatusAvailable
                LabelStatus.ForeColor = Color.FromArgb(101, 137, 98)
            ElseIf (I_Status(i) = "Out Of Stock" Or I_Status(i) = "Out of Stock") Then
                LabelStatus.Text = "Out of Stock"
                LabelStatus.Image = My.Resources.StatusOutOfStock
                LabelStatus.Font = New Font("Candara", 9)
                LabelStatus.ForeColor = Color.FromArgb(174, 86, 86)
            ElseIf (I_Status(i) = "Unavailable") Then

                LabelStatus.Image = My.Resources.StatusUnavailable
                LabelStatus.ForeColor = Color.FromArgb(89, 89, 89)
            End If
            LabelStatus.Location = New Point(480, 0)


            Dim LabelPrice As New Label With {
               .Text = I_Price(i),
               .Font = l_font,
               .MinimumSize = l_size,
               .TextAlign = l_align,
               .BackColor = l_back,
               .ForeColor = l_fore,
                .Location = New Point(600, 0)
           }


            DisplayPanel.Controls.Add(CheckBox)
            DisplayPanel.Controls.Add(LabelID)

            DisplayPanel.Controls.Add(LabelType)

            DisplayPanel.Controls.Add(LabelName)

            DisplayPanel.Controls.Add(LabelStock)

            DisplayPanel.Controls.Add(LabelStatus)

            DisplayPanel.Controls.Add(LabelPrice)
        Next
    End Sub


    Private Sub UpdateInventoryButton_Click(sender As Object, e As EventArgs) Handles UpdateInventoryButton.Click
        If (SetStockTextbox.Text = "" And AddStockTextbox.Text = "") Then
            Return

        End If
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If
        Dim StatusMessage As String = ""
        If (Status = 1) Then
            StatusMessage = "Available"
        ElseIf (Status = 2) Then
            StatusMessage = "Unavailable"
        ElseIf (Status = 3) Then
            StatusMessage = "Out of Stock"
        End If


        Try
            If (IsMultiple) Then
                For i As Integer = 0 To 14
                    If (MultipleSelection(i) = True) Then
                        If (IsSet) Then
                            CurrentStockValueUpdate = TextBoxValue
                        Else
                            CurrentStockValueUpdate = Val((StockValues(i)) + TextBoxValue)

                        End If
                        Dim cmd As New MySqlCommand("UPDATE `inventory` SET`Stocks`='" & CurrentStockValueUpdate & "',`Status`='" & StatusMessage & "'WHERE  `ID` = '" & ProductID(i) & "'", DBConn.Connection)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader

                        reader.Close()
                    End If
                Next
            Else
                Dim cmd As New MySqlCommand("UPDATE `inventory` SET`Stocks`='" & CurrentStockValueUpdate & "',`Status`='" & StatusMessage & "'WHERE  `ID` = '" & ProductID(SingleSelection) & "'", DBConn.Connection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                reader.Close()
            End If
            SetStockTextbox.Text = ""
            AddStockTextbox.Text = ""
        Catch ex As Exception

        End Try
        DisplayStock()
    End Sub

















    Dim SessionsPage As Integer = 1


    Dim ESearchValue As String = ""
    Dim ESearched As Boolean = False


    Private Sub ESearchButton_Click(sender As Object, e As EventArgs) Handles ESearchButton.Click
        ESearchValue = ESearchTextBox.Text
        SessionsPage = 1

        LoadSessions()
    End Sub
    Private Sub ESearchButton_Enter(sender As Object, e As EventArgs) Handles ESearchButton.MouseEnter
        ESearchButton.Image = My.Resources.IconSearchHovered
    End Sub
    Private Sub ESearchButton_Leave(sender As Object, e As EventArgs) Handles ESearchButton.MouseLeave
        ESearchButton.Image = My.Resources.IconSearch
    End Sub
    Private Sub ESearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles ESearchTextBox.TextChanged
        If (ESearchTextBox.Text = "") Then
            ESearched = False
        Else
            ESearched = True
        End If

    End Sub


    Private Sub EPageNext_Click(sender As Object, e As EventArgs) Handles EPageNext.Click
        If (SessionsPage > 19) Then
            Return
        End If


        SessionsPage += 1
        LoadSessions()
    End Sub

    Private Sub EPagePrev_Click(sender As Object, e As EventArgs) Handles EPagePrev.Click
        If (SessionsPage < 2) Then
            Return
        End If


        SessionsPage -= 1
        LoadSessions()
    End Sub

    Private Sub LoadSessions()
        ECurrentPage.Text = SessionsPage
        Dim E_Date As New List(Of String)()
        Dim E_TimeIn As New List(Of String)()
        Dim E_TimeOut As New List(Of String)()
        Dim E_Username As New List(Of String)()

        Dim PageSkip = 6 * (SessionsPage - 1)
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If
        Dim RecievedRows As Integer = 0
        Try
            Dim cmd As New MySqlCommand("", DBConn.Connection)
            If (ESearched) Then
                cmd.CommandText = "SELECT ea.Date, ea.TimeIn,ea.TimeOut, e.Username
                FROM employeeattendance ea
                JOIN `employee` e ON ea.Employee_ID = e.Employee_ID 
                
                WHERE ea.Date LIKE '%" & ESearchValue & "%' or e.Username LIKE '%" & ESearchValue & "%' or ea.TimeIn LIKE '%" & ESearchValue & "' or ea.TimeOut LIKE '%" & ESearchValue & "'
              
                ORDER BY ea.Date DESC
               
                LIMIT " & PageSkip & ",14"
            Else
                cmd.CommandText = "SELECT ea.Date, ea.TimeIn,ea.TimeOut, e.Username
                FROM employeeattendance ea
                JOIN `employee` e ON ea.Employee_ID = e.Employee_ID
                ORDER BY ea.Date DESC
                LIMIT " & PageSkip & ",14"

            End If

            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read
                RecievedRows += 1
                Dim DateValue As DateTime = reader.GetDateTime("Date")
                E_Date.Add(DateValue.ToString("yyyy-MM-dd"))


                E_TimeIn.Add(reader.GetString("TimeIn"))
                E_TimeOut.Add(reader.GetString("TimeOut"))
                E_Username.Add(reader.GetString("Username"))
            End While
            reader.Close()
        Catch ex As Exception

        End Try
        SessionsContainer.Controls.Clear()
        For i As Integer = 0 To RecievedRows - 1


            Dim DataPanel As New Panel()
            DataPanel.BackColor = If((i Mod 2), Color.White, Color.FromArgb(252, 242, 240))

            DataPanel.Location = New Point(0, i * 40)
            DataPanel.Size = New Size(470, 40)

            SessionsContainer.Controls.Add(DataPanel)

            Dim lcenter = ContentAlignment.MiddleCenter
            Dim lfont = New Font("Arial", 11)
            Dim lfore = Color.FromArgb(89, 89, 89)
            Dim lback = DataPanel.BackColor


            Dim LabelName As New Label()
            LabelName.Size = New Size(110, 20)
            LabelName.TextAlign = lcenter
            LabelName.Font = lfont
            LabelName.ForeColor = lfore
            LabelName.BackColor = lback
            LabelName.Location = New Point(0, 10)
            LabelName.Text = E_Username(i)


            Dim LabelDate As New Label()
            LabelDate.Location = New Point(120, 10)
            LabelDate.TextAlign = lcenter
            LabelDate.Font = lfont
            LabelDate.ForeColor = lfore
            LabelDate.BackColor = lback
            LabelDate.Size = New Size(110, 20)
            LabelDate.Text = E_Date(i)

            Dim LabelTimeIn As New Label()
            LabelTimeIn.Size = New Size(110, 20)
            LabelTimeIn.TextAlign = lcenter
            LabelTimeIn.Font = lfont
            LabelTimeIn.ForeColor = lfore
            LabelTimeIn.BackColor = lback
            LabelTimeIn.Location = New Point(240, 10)
            LabelTimeIn.Text = E_TimeIn(i)

            Dim LabelTimeOut As New Label()

            LabelTimeOut.Size = New Size(110, 20)
            LabelTimeOut.Location = New Point(360, 10)
            LabelTimeOut.TextAlign = lcenter
            LabelTimeOut.Font = lfont
            LabelTimeOut.ForeColor = lfore
            LabelTimeOut.BackColor = lback
            LabelTimeOut.Text = E_TimeOut(i)

            DataPanel.Controls.Add(LabelName)
            DataPanel.Controls.Add(LabelDate)

            DataPanel.Controls.Add(LabelTimeIn)

            DataPanel.Controls.Add(LabelTimeOut)

        Next














    End Sub


    Private Sub ShowEye1_Click(sender As Object, e As EventArgs) Handles ShowEye1.Click
        If (AccCreatePass.PasswordChar = "•") Then
            AccCreatePass.PasswordChar = ""
            ShowEye1.Image = My.Resources.IconEyeOpen
        Else
            AccCreatePass.PasswordChar = "•"
            ShowEye1.Image = My.Resources.IconEyeClosed
        End If
    End Sub

    Private Sub ShowEye2_Click(sender As Object, e As EventArgs) Handles ShowEye2.Click
        If (AccCreatePassConfirm.PasswordChar = "•") Then
            AccCreatePassConfirm.PasswordChar = ""
            ShowEye2.Image = My.Resources.IconEyeOpen
        Else
            AccCreatePassConfirm.PasswordChar = "•"
            ShowEye2.Image = My.Resources.IconEyeClosed
        End If
    End Sub

    Private Sub ShowEye3_Click(sender As Object, e As EventArgs) Handles ShowEye3.Click
        If (AccModifyOldPass.PasswordChar = "•") Then
            AccModifyOldPass.PasswordChar = ""
            ShowEye3.Image = My.Resources.IconEyeOpen
        Else
            AccModifyOldPass.PasswordChar = "•"
            ShowEye3.Image = My.Resources.IconEyeClosed
        End If
    End Sub

    Private Sub ShowEye4_Click(sender As Object, e As EventArgs) Handles ShowEye4.Click
        If (AccModifyNewPass.PasswordChar = "•") Then
            AccModifyNewPass.PasswordChar = ""
            ShowEye4.Image = My.Resources.IconEyeOpen
        Else
            AccModifyNewPass.PasswordChar = "•"
            ShowEye4.Image = My.Resources.IconEyeClosed
        End If
    End Sub

    Private Sub ShowEye5_Click(sender As Object, e As EventArgs) Handles ShowEye5.Click
        If (AccModifyPassConfirm.PasswordChar = "•") Then
            AccModifyPassConfirm.PasswordChar = ""
            ShowEye5.Image = My.Resources.IconEyeOpen
        Else
            AccModifyPassConfirm.PasswordChar = "•"
            ShowEye5.Image = My.Resources.IconEyeClosed
        End If
    End Sub

    Private Sub AccountErrorTextDisplay(e As String, i As Integer)
        If (i = 1) Then
            ErrorTextCreate.Text = e
        Else
            ErrorTextModify.Text = e
        End If
    End Sub

    Private Sub AccCreateConfirm_Click(sender As Object, e As EventArgs) Handles AccCreateConfirm.Click

        If (AccCreateUsername.Text = "") Then
            AccountErrorTextDisplay("Username cannot be empty.", 1)
            Return

        End If

        If (AccCreatePass.Text = "") Then
            AccountErrorTextDisplay("Password cannot be empty", 1)
            Return

        End If


        If (AccCreatePass.Text <> AccCreatePassConfirm.Text) Then
            AccountErrorTextDisplay("Password does not match", 1)
            Return
        End If

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If

        Try
            Dim cmd As New MySqlCommand("SELECT `Username` FROM `employee` WHERE `Username` ='" & AccCreateUsername.Text & "'", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            If reader.Read Then
                AccountErrorTextDisplay("Username already taken", 1)

                reader.Close()
                Return
            End If

            reader.Close()
            cmd.CommandText = "INSERT INTO `employee`(`Username`, `Password`) VALUES ('" & AccCreateUsername.Text & "','" & AccCreatePass.Text & "')"
            reader = cmd.ExecuteReader


            AccCreateUsername.Text = ""
            AccCreatePass.Text = ""
            AccCreatePassConfirm.Text = ""
            AccountErrorTextDisplay("Account Creation Success", 1)


            reader.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AccModifyConfirm_Click(sender As Object, e As EventArgs) Handles AccModifyConfirm.Click
        If (AccModifyUsername.Text = "") Then
            AccountErrorTextDisplay("Username cannot be empty.", 2)
            Return

        End If

        If (AccModifyNewPass.Text = "" Or AccModifyOldPass.Text = "") Then
            AccountErrorTextDisplay("Password cannot be empty", 2)
            Return

        End If

        If (AccModifyNewPass.Text <> AccModifyPassConfirm.Text) Then
            AccountErrorTextDisplay("Password does not match", 2)
            Return
        End If


        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If

        Dim IsEqual = False
        Try
            Dim cmd As New MySqlCommand("SELECT `Username` FROM `employee` WHERE `Username` ='" & AccModifyUsername.Text & "' AND `Password` ='" & AccModifyOldPass.Text & "'   ", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            If reader.Read Then
                IsEqual = True
            End If

            reader.Close()
            If (IsEqual) Then
                cmd.CommandText = "UPDATE `employee` SET `Password`='" & AccModifyPassConfirm.Text & "' WHERE `Username`='" & AccModifyUsername.Text & "'"
                reader = cmd.ExecuteReader

                AccModifyNewPass.Text = ""
                AccModifyOldPass.Text = ""
                AccModifyPassConfirm.Text = ""
                AccModifyUsername.Text = ""
                AccountErrorTextDisplay("Account Modification Success", 2)

                reader.Close()

            Else

                AccountErrorTextDisplay("Invalid Username or Old Password", 2)
                Return
            End If



        Catch ex As Exception

        End Try
    End Sub










    Private Sub GetRecentSales()
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If
        Dim Sales As New List(Of Integer)
        Try
            Dim cmd As New MySqlCommand(
            "SELECT  o.TotalOrder_Cost FROM `order` o
            JOIN transactions t on t.Order_Number = o.Order_Number
            ORDER BY t.Date_Purchased DESC
            LIMIT 10", DBConn.Connection)


            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read
                Sales.Add(reader.GetInt32("TotalOrder_Cost"))
            End While
            reader.Close()
        Catch ex As Exception

        End Try

        Dim SalesArr() As Integer = Sales.ToArray()
        DisplayChartRecent(SalesArr)
    End Sub

    Private Sub DisplayChartRecent(Values() As Integer)

        Dim Chart As Graphics
        Chart = RecentSalesPanel.CreateGraphics()
        Chart.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Chart.Clear(Me.BackColor)

        Dim PanelWidth As Integer = 600
        Dim PanelHeight As Integer = 100

        Dim X_Length = Values.Length
        Dim X_Point As Double = Math.Round(PanelWidth / (X_Length - 1), 2)
        Dim HighestValue As Integer = Values.Max


        Dim Y_Point As Integer
        Dim Points(X_Length + 1) As Point

        Points(0) = New Point(0, PanelHeight + (PanelHeight / 2))


        For i As Integer = 0 To Values.Length - 1
            Dim y = Math.Round(Values(i) / HighestValue, 2)

            Y_Point = PanelHeight - (PanelHeight * y) + 10
            Points(i + 1) = New Point(X_Point * i, Y_Point)


        Next

        Points(X_Length + 1) = New Point(X_Point * (Values.Length - 1), PanelHeight + (PanelHeight / 2))

        Dim FillBrush As LinearGradientBrush
        Dim OutlineBrush As Pen

        ' Dim Color1 As Color = Color.FromArgb(227, 135, 114)
        ' Dim Color2 As Color = Color.White
        Dim Color1 As Color = Color.White
        Dim Color2 As Color = Color.FromArgb(255, 231, 180)
        Dim color3 As Color = Color.FromArgb(248, 202, 106)

        FillBrush = New LinearGradientBrush(New Point(0, PanelHeight + (PanelHeight / 2.5)), New Point(0, 0), Color1, Color2)
        OutlineBrush = New Pen(color3, 2)

        Dim HvalDisplay = 0
        While HvalDisplay < HighestValue
            If (HvalDisplay < 100) Then
                HvalDisplay += 10
            Else

                HvalDisplay += 100
            End If
        End While

        SalesLabel1.Text = Math.Round(HvalDisplay)
        SalesLabel2.Text = Math.Round(HvalDisplay * 0.67)
        SalesLabel3.Text = Math.Round(HvalDisplay * 0.34)
        ' LabelValue4.Text = HvalDisplay * 0.25

        ' ' TotalSalesLabel.Text = "₱" + TotalSalesValue.ToString("#,##0")
        '  TotalOrdersLabel.Text = TotalOrdersValue.ToString
        Chart.FillClosedCurve(FillBrush, Points)
        Chart.DrawClosedCurve(OutlineBrush, Points)
        '  Chart.FillPolygon(FillBrush, Points)
        '  Chart.DrawPolygon(OutlineBrush, Points)

    End Sub



    Private Sub DisplayStockAlert()
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If
        Dim StockItemName As New List(Of String)()
        Dim StockItemValue As New List(Of Integer)()

        Try
            Dim cmd = New MySqlCommand("SELECT `Product_Name`, `Stocks` FROM `inventory` ORDER BY`Stocks` ASC LIMIT 4", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read
                StockItemName.Add(reader.GetString("Product_Name"))
                StockItemValue.Add(reader.GetInt32("Stocks"))
            End While
            reader.Close()
        Catch ex As Exception

        End Try

        StockItem1Label.Text = StockItemName(0)
        StockItem1.Text = StockItemValue(0).ToString
        If (StockItemValue(0) < 100) Then
            StockItem1.BackgroundImage = My.Resources.StatusOutOfStock
            StockItem1.ForeColor = Color.FromArgb(174, 86, 86)
        ElseIf (StockItemValue(0) < 500) Then


            StockItem1.BackgroundImage = My.Resources.StatusLow
            StockItem1.ForeColor = Color.FromArgb(137, 124, 98)
        End If


        StockItem2Label.Text = StockItemName(1)
        StockItem2.Text = StockItemValue(1).ToString
        If (StockItemValue(1) < 100) Then

            StockItem2.BackgroundImage = My.Resources.StatusOutOfStock
            StockItem2.ForeColor = Color.FromArgb(174, 86, 86)
        ElseIf (StockItemValue(1) < 500) Then
            StockItem2.BackgroundImage = My.Resources.StatusLow
            StockItem2.ForeColor = Color.FromArgb(137, 124, 98)



        End If



        StockItem3Label.Text = StockItemName(2)
        StockItem3.Text = StockItemValue(2).ToString
        If (StockItemValue(2) < 100) Then
            StockItem3.BackgroundImage = My.Resources.StatusOutOfStock
            StockItem3.ForeColor = Color.FromArgb(174, 86, 86)
        ElseIf (StockItemValue(2) < 500) Then

            StockItem3.BackgroundImage = My.Resources.StatusLow
            StockItem3.ForeColor = Color.FromArgb(137, 124, 98)
        End If


        StockItem4Label.Text = StockItemName(3)
        StockItem4.Text = StockItemValue(3).ToString
        If (StockItemValue(3) < 100) Then
            StockItem4.BackgroundImage = My.Resources.StatusOutOfStock
            StockItem4.ForeColor = Color.FromArgb(174, 86, 86)
        ElseIf (StockItemValue(3) < 500) Then

            StockItem4.BackgroundImage = My.Resources.StatusLow
            StockItem4.ForeColor = Color.FromArgb(137, 124, 98)
        End If
    End Sub


    Private Sub DisplayRecentSession()
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If
        Dim E_Date As New List(Of String)()
        Dim E_TimeIn As New List(Of String)()
        Dim E_TimeOut As New List(Of String)()
        Dim E_Username As New List(Of String)()
        Try
            Dim cmd As New MySqlCommand(
           "SELECT  e.Username, ea.Date, ea.TimeIn, ea.TimeOut
            FROM employeeattendance ea
            JOIN employee e on e.Employee_ID = ea.Employee_ID

            ORDER BY ea.Date DESC, ea.TimeIn DESC, ea.TimeOut DESC 
            LIMIT 7", DBConn.Connection)


            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read

                Dim DateValue As DateTime = reader.GetDateTime("Date")
                E_Date.Add(DateValue.ToString("yyyy-MM-dd"))

                E_TimeIn.Add(reader.GetString("TimeIn"))
                E_TimeOut.Add(reader.GetString("TimeOut"))
                E_Username.Add(reader.GetString("Username"))
            End While
            reader.Close()



        Catch ex As Exception

        End Try

        RSName1.Text = E_Username(0)
        RSName2.Text = E_Username(1)
        RSName3.Text = E_Username(2)
        RSName4.Text = E_Username(3)
        RSName5.Text = E_Username(4)
        RSName6.Text = E_Username(5)
        RSName7.Text = E_Username(6)

        RSDate1.Text = E_Date(0)
        RSDate2.Text = E_Date(1)
        RSDate3.Text = E_Date(2)
        RSDate4.Text = E_Date(3)
        RSDate5.Text = E_Date(4)
        RSDate6.Text = E_Date(5)
        RSDate7.Text = E_Date(6)

        RSTimeIn1.Text = E_TimeIn(0)
        RSTimeIn2.Text = E_TimeIn(1)
        RSTimeIn3.Text = E_TimeIn(2)
        RSTimeIn4.Text = E_TimeIn(3)
        RSTimeIn5.Text = E_TimeIn(4)
        RSTimeIn6.Text = E_TimeIn(5)
        RSTimeIn7.Text = E_TimeIn(6)

        RSTimeOut1.Text = E_TimeOut(0)
        RSTimeOut2.Text = E_TimeOut(1)
        RSTimeOut3.Text = E_TimeOut(2)
        RSTimeOut4.Text = E_TimeOut(3)
        RSTimeOut5.Text = E_TimeOut(4)
        RSTimeOut6.Text = E_TimeOut(5)
        RSTimeOut7.Text = E_TimeOut(6)
    End Sub












    Dim Chart2 As Graphics

    Dim SalesSelected2 As Integer = 1
    Dim TotalSalesValue2 As Integer
    Dim TotalOrdersValue2 As Integer
    Private Sub ChartButtonMonth2_Click(sender As Object, e As EventArgs) Handles ChartButtonMonth2.Click
        If SalesSelected2 = 1 Then
            Return
        End If

        SalesSelected2 = 1

        ChartButtonDay2.ForeColor = Color.Gray
        ChartButtonWeek2.ForeColor = Color.Gray
        ChartButtonMonth2.ForeColor = Color.FromArgb(228, 135, 114)

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If
        Dim Sales As New List(Of Integer)()
        TotalOrdersValue2 = 0
        Try
            Dim cmd As New MySqlCommand("SELECT `Order_Number`, `Date_Purchased` FROM transactions WHERE YEAR(Date_Purchased) = YEAR(CURDATE()) AND MONTH(Date_Purchased) = MONTH(CURDATE()) ORDER BY Date_Purchased ASC;", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            Dim OrderIDs As New List(Of Integer)()
            Dim OrdersPurchased As New List(Of String)()
            While reader.Read

                OrderIDs.Add(reader.GetInt32("Order_Number"))
                Dim Purchase_date = reader.GetDateTime("Date_Purchased")
                OrdersPurchased.Add(Purchase_date.ToString("dd"))
                TotalOrdersValue2 += 1
            End While

            reader.Close()
            Dim total = 0
            Dim OrderPK() = OrderIDs.ToArray
            Dim PrevDay As String = ""
            '  Dim Average = 0
            '  '    Dim Changed = False
            For d As Integer = 0 To Conversion.Val(OrdersPurchased(0)) - 1
                Sales.Add(0)
            Next
            For i As Integer = 0 To OrderPK.Length - 1

                cmd.CommandText = "SELECT `TotalOrder_Cost` FROM `order` WHERE `Order_Number` ='" & OrderPK(i) & "'"

                Dim reader2 As MySqlDataReader = cmd.ExecuteReader
                If reader2.Read Then

                    total = reader2.GetInt32("TotalOrder_Cost")

                End If
                If (PrevDay <> (OrdersPurchased(i).ToString)) Then
                    PrevDay = OrdersPurchased(i).ToString
                    Sales.Add(0)
                End If
                Sales(Conversion.Val(OrdersPurchased(i))) += total
                'MessageBox.Show("date:" + (Val(OrdersPurchased(i))).ToString + "Total:" + total.ToString + "Avg:" + avg.ToString)


                ' If (PrevDay = OrdersPurchased(i)) Then
                '   Average += total
                '   Changed = True
                '   Else
                '   PrevDay = OrdersPurchased(i)
                '   If (Changed) Then
                '     Average += total
                '     Changed = False
                ' Else

                '      Average = total
                '  End If

                '   MessageBox.Show(Average)
                ' Sales.Add(Average)
                '   End If
                reader2.Close()
            Next



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Dim SalesArray() As Integer = Sales.ToArray()

        DisplayChart2(SalesArray)

    End Sub
    Private Sub ChartWeek2()
        SalesSelected2 = 2
        ChartButtonDay2.ForeColor = Color.Gray
        ChartButtonMonth2.ForeColor = Color.Gray
        ChartButtonWeek2.ForeColor = Color.FromArgb(228, 135, 114)

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If

        Dim Sales As New List(Of Integer)()
        TotalOrdersValue2 = 0
        Try
            Dim cmd As New MySqlCommand("SELECT `Order_Number`, `Date_Purchased` FROM transactions WHERE YEARWEEK(Date_Purchased) = YEARWEEK(CURDATE()) ORDER BY Date_Purchased  ASC;", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            Dim OrderIDs As New List(Of Integer)()
            Dim OrdersPurchased As New List(Of String)()
            While reader.Read

                OrderIDs.Add(reader.GetInt32("Order_Number"))
                '  OrdersPurchased.Add(((reader.GetDateTime("Date_Purchased")).Date).ToString)
                Dim Purchase_date = reader.GetDateTime("Date_Purchased")
                OrdersPurchased.Add(Purchase_date.ToString("dd"))
                TotalOrdersValue2 += 1
            End While

            reader.Close()
            Dim total = 0
            Dim OrderPK() = OrderIDs.ToArray
            Dim PrevDay As String = ""
            '  Dim Average = 0

            Dim Day As Integer = 0
            Sales.Add(0)
            Dim MultipleLimiter = 0
            Dim Multiple = 0
            For i As Integer = 0 To OrderPK.Length - 1
                cmd.CommandText = "SELECT `TotalOrder_Cost` FROM `order` WHERE `Order_Number` ='" & OrderPK(i) & "'"

                Dim reader2 As MySqlDataReader = cmd.ExecuteReader
                If reader2.Read Then

                    total = reader2.GetInt32("TotalOrder_Cost")

                End If
                If (MultipleLimiter = 4) Then
                    MultipleLimiter = 0
                    Multiple += 1
                    Sales.Add(0)
                ElseIf (PrevDay <> (OrdersPurchased(i).ToString)) Then


                    PrevDay = OrdersPurchased(i).ToString
                    Sales.Add(0)
                    Day += 1
                Else
                    MultipleLimiter += 1
                End If


                Sales(Day + Multiple) += total
                '    MessageBox.Show("Sales index:" + (Day + Multiple).ToString + "Value:" + Sales(Day + Multiple).ToString)
                ' MessageBox.Show("Day:" + Day.ToString + "Limiter:" + Multiple.ToString + " Total:" + Sales(Day).ToString)
                '  If (PrevDay = OrdersPurchased(i)) Then
                '       Average += total
                '   Else
                '        PrevDay = OrdersPurchased(i)
                '        Average = total
                '        Sales.Add(Average)
                '    End If
                'Sales.Add(total)
                If (Sales.Count = 0) Then
                    MessageBox.Show("Empty")
                End If
                reader2.Close()
            Next



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Dim SalesArray() As Integer = Sales.ToArray()

        DisplayChart2(SalesArray)
    End Sub
    Private Sub ChartButtonWeek2_Click(sender As Object, e As EventArgs) Handles ChartButtonWeek2.Click
        If SalesSelected2 = 2 Then
            Return
        End If
        ChartWeek2()

    End Sub

    Private Sub ChartButtonDay2_Click(sender As Object, e As EventArgs) Handles ChartButtonDay2.Click
        If SalesSelected2 = 3 Then
            Return
        End If

        SalesSelected2 = 3

        ChartButtonMonth2.ForeColor = Color.Gray
        ChartButtonWeek2.ForeColor = Color.Gray
        ChartButtonDay2.ForeColor = Color.FromArgb(228, 135, 114)

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(3)
        End If
        TotalOrdersValue2 = 0
        Dim Sales As New List(Of Integer)()

        Try
            Dim cmd As New MySqlCommand("SELECT `Order_Number` FROM transactions WHERE DATE(Date_Purchased) = CURDATE() ORDER BY Date_Purchased  ASC;", DBConn.Connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            Dim OrderIDs As New List(Of Integer)()

            While reader.Read

                OrderIDs.Add(reader.GetInt32("Order_Number"))
                TotalOrdersValue2 += 1
            End While

            reader.Close()
            Dim total = 0
            Dim OrderPK() = OrderIDs.ToArray

            For i As Integer = 0 To OrderPK.Length - 1
                cmd.CommandText = "SELECT `TotalOrder_Cost` FROM `order` WHERE `Order_Number` ='" & OrderPK(i) & "'"

                Dim reader2 As MySqlDataReader = cmd.ExecuteReader
                If reader2.Read Then

                    total = reader2.GetInt32("TotalOrder_Cost")


                End If
                Sales.Add(total)
                reader2.Close()
            Next
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try




        If (Sales.Count = 0) Then


            Dim HvalDisplay = 1000
            GPval1.Text = HvalDisplay

            GPval2.Text = HvalDisplay * 0.75

            GPval3.Text = HvalDisplay * 0.5

            GPval4.Text = HvalDisplay * 0.25

            Chart2 = ChartPanel2.CreateGraphics()
            Chart2.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            Chart2.Clear(Me.BackColor)

        ElseIf (Sales.Count = 1) Then
            Sales.Add(0)
            Dim SalesArray() As Integer = Sales.ToArray()
            DisplayChart2(SalesArray)
        Else



            Dim SalesArray() As Integer = Sales.ToArray()
            DisplayChart2(SalesArray)
        End If


    End Sub


    Private Sub DisplayChart2(Values() As Integer)

        Dim TotalSalesValue = 0
        Chart2 = ChartPanel2.CreateGraphics()
        Chart2.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Chart2.Clear(Me.BackColor)

        Dim PanelWidth As Integer = 600
        Dim PanelHeight As Integer = 180

        Dim X_Length = Values.Length
        Dim X_Point As Double = Math.Round(PanelWidth / (X_Length - 1), 2)
        Dim HighestValue As Integer = Values.Max


        Dim Y_Point As Integer
        Dim Points(X_Length + 1) As Point

        Points(0) = New Point(0, PanelHeight + (PanelHeight / 2))


        For i As Integer = 0 To Values.Length - 1
            Dim y = Math.Round(Values(i) / HighestValue, 2)

            Y_Point = PanelHeight - (PanelHeight * y) + 50
            Points(i + 1) = New Point(X_Point * i, Y_Point)
            TotalSalesValue += Values(i)

        Next

        Points(X_Length + 1) = New Point(X_Point * (Values.Length - 1), PanelHeight + (PanelHeight / 2))

        Dim FillBrush As LinearGradientBrush
        Dim OutlineBrush As Pen

        Dim Color1 As Color = Color.FromArgb(227, 135, 114)
        Dim Color2 As Color = Color.White

        FillBrush = New LinearGradientBrush(New Point(0, PanelHeight + (PanelHeight / 2.5)), New Point(0, 0), Color2, Color1)
        OutlineBrush = New Pen(Color1, 2)

        Dim HvalDisplay = 0
        While HvalDisplay < HighestValue
            If (HvalDisplay < 100) Then
                HvalDisplay += 10
            Else

                HvalDisplay += 100
            End If
        End While
        GPval1.Text = HvalDisplay
        GPval2.Text = HvalDisplay * 0.75
        GPval3.Text = HvalDisplay * 0.5
        GPval4.Text = HvalDisplay * 0.25

        TotalSalesLabel2.Text = "₱" + TotalSalesValue.ToString("#,##0")
        TotalOrdersLabel2.Text = TotalOrdersValue2.ToString
        Chart2.FillClosedCurve(FillBrush, Points)
        Chart2.DrawClosedCurve(OutlineBrush, Points)

    End Sub

End Class