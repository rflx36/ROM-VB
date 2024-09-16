'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class EmployeeUIPopUp
    Dim IsPlace = True
    Dim OrderId As Integer
    Dim MOP As String
    Public EmployeeID As Integer
    Public EmployeeName As String
    Public OrderList(15) As Integer
    Public OrderListId As Integer
    Public TotalOrderCost As Integer
    Dim ProductType = New String() {"A1", "A2", "A3", "A4", "A5", "S1", "S2", "D1", "D2", "D3_A", "D3_B", "D3_C", "B1", "B2", "B3"}
    Public Sub SetOrderProperties(OrderNum As Integer, TotalNum As Integer, IsPlaceOrder As Boolean, PaymentMethod As String)

        OrderNumberLabel.Text = "#" + OrderNum.ToString
        TotalLabel.Text = "₱" + TotalNum.ToString("N2")
        OrderId = OrderNum
        IsPlace = IsPlaceOrder
        MOP = PaymentMethod
        If (IsPlaceOrder = False) Then
            ButtonOrder.Image = My.Resources.CancelButton
            ButtonOrder.ForeColor = Color.FromArgb(228, 135, 114)
            ButtonOrder.Text = "Delete Order"
            DisplayLabel.Text = "Delete Order?"
            DisplayLabel.ForeColor = Color.FromArgb(228, 135, 114)
        End If
        'MessageBox.Show(Date.Today)
    End Sub

    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(2)
        End If
        If (IsPlace) Then
            Try
                Dim CurrentDay = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                Dim cmd As New MySqlCommand("UPDATE `order` SET `Employee_ID` = '" & EmployeeID & "', `Employee_Name` = '" & EmployeeName & "' WHERE `Order_Number` = '" & OrderId & "'", DBConn.Connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader
                reader.Close()

                Dim Original_OrderList(14) As Integer
                cmd.CommandText = "SELECT * FROM `orderlist` WHERE `OrderList_ID`='" & OrderListId & "'"
                reader = cmd.ExecuteReader
                If reader.Read Then
                    Original_OrderList(0) = reader.GetInt32("A1")
                    Original_OrderList(1) = reader.GetInt32("A2")
                    Original_OrderList(2) = reader.GetInt32("A3")
                    Original_OrderList(3) = reader.GetInt32("A4")
                    Original_OrderList(4) = reader.GetInt32("A5")
                    Original_OrderList(5) = reader.GetInt32("S1")
                    Original_OrderList(6) = reader.GetInt32("S2")
                    Original_OrderList(7) = reader.GetInt32("D1")
                    Original_OrderList(8) = reader.GetInt32("D2")
                    Original_OrderList(9) = reader.GetInt32("D3_A")
                    Original_OrderList(10) = reader.GetInt32("D3_B")
                    Original_OrderList(11) = reader.GetInt32("D3_C")
                    Original_OrderList(12) = reader.GetInt32("B1")
                    Original_OrderList(13) = reader.GetInt32("B2")
                    Original_OrderList(14) = reader.GetInt32("B3")
                End If


                reader.Close()

                For i As Integer = 0 To Original_OrderList.Length - 1
                    Dim FinalOrderList = OrderList(i) - Original_OrderList(i)
                    cmd.CommandText = "UPDATE `inventory` SET `Stocks`= `Stocks`- " & FinalOrderList & " WHERE `ID`='" & ProductType(i) & "'"
                    reader = cmd.ExecuteReader
                    reader.Close()

                Next


                cmd.CommandText = "UPDATE `order` SET `TotalOrder_Cost`='" & TotalOrderCost & "' WHERE `Order_Number` = '" & OrderId & "'"
                reader = cmd.ExecuteReader
                reader.Close()
                cmd.CommandText = "INSERT INTO `transactions`(`Order_Number`, `Date_Purchased`, `ModeOfPayment`) VALUES ('" & OrderId & "','" & CurrentDay & "','" & MOP & "')"
                reader = cmd.ExecuteReader()
                reader.Close()

                cmd.CommandText = "UPDATE `orderlist` SET 
                `A1`='" & OrderList(0) & "',
                `A2`='" & OrderList(1) & "',
                `A3`='" & OrderList(2) & "',
                `A4`='" & OrderList(3) & "',
                `A5`='" & OrderList(4) & "',
                `S1`='" & OrderList(5) & "',
                `S2`='" & OrderList(6) & "',
                `D1`='" & OrderList(7) & "',
                `D2`='" & OrderList(8) & "',
                `D3_A`='" & OrderList(9) & "',
                `D3_B`='" & OrderList(10) & "',
                `D3_C`='" & OrderList(11) & "',
                `B1`='" & OrderList(12) & "',
                `B2`='" & OrderList(13) & "',
                `B3`='" & OrderList(14) & "'  WHERE `OrderList_ID` = '" & OrderListId & "'"

                reader = cmd.ExecuteReader()
                reader.Close()
            Catch ex As MySqlException

                MessageBox.Show(ex.Message)
            End Try
        Else
            Try

                Dim cmd As New MySqlCommand("SELECT `OrderList_ID`, `Customer_ID` FROM `order` WHERE `Order_Number`= '" & OrderId & "'", DBConn.Connection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                Dim CustomerPK As Integer
                Dim OrderListPK As Integer
                Dim FreeItemStocks As New List(Of Integer)()

                Dim ProductID As New List(Of String)()
                Dim Stocks As New List(Of Integer)()
                Dim Status As New List(Of String)()
                While reader.Read
                    CustomerPK = reader.GetInt32("Customer_ID")
                    OrderListPK = reader.GetInt32("OrderList_ID")
                End While
                reader.Close()
                cmd.CommandText = "DELETE FROM `order` WHERE `Order_Number` = '" & OrderId & "'"
                reader = cmd.ExecuteReader
                reader.Close()

                cmd.CommandText = "DELETE FROM `customer` WHERE `Customer_ID` = '" & CustomerPK & "'"
                reader = cmd.ExecuteReader
                reader.Close()

                cmd.CommandText = "SELECT  * FROM `orderlist` WHERE `OrderList_ID` = '" & OrderListPK & "'"
                reader = cmd.ExecuteReader
                If reader.Read Then

                    FreeItemStocks.Add(reader.GetInt32("A1"))
                    FreeItemStocks.Add(reader.GetInt32("A2"))
                    FreeItemStocks.Add(reader.GetInt32("A3"))
                    FreeItemStocks.Add(reader.GetInt32("A4"))
                    FreeItemStocks.Add(reader.GetInt32("A5"))

                    FreeItemStocks.Add(reader.GetInt32("S1"))
                    FreeItemStocks.Add(reader.GetInt32("S2"))

                    FreeItemStocks.Add(reader.GetInt32("D1"))
                    FreeItemStocks.Add(reader.GetInt32("D2"))
                    FreeItemStocks.Add(reader.GetInt32("D3_A"))
                    FreeItemStocks.Add(reader.GetInt32("D3_B"))
                    FreeItemStocks.Add(reader.GetInt32("D3_C"))


                    FreeItemStocks.Add(reader.GetInt32("B1"))
                    FreeItemStocks.Add(reader.GetInt32("B2"))
                    FreeItemStocks.Add(reader.GetInt32("B3"))
                End If
                reader.Close()

                cmd.CommandText = "DELETE FROM `orderlist` WHERE `OrderList_ID` = '" & OrderListPK & "'"
                reader = cmd.ExecuteReader
                reader.Close()
                cmd.CommandText = "SELECT `ID`, `Stocks`, `Status` FROM `inventory`"
                reader = cmd.ExecuteReader

                While reader.Read()
                    ProductID.Add(reader.GetString("ID"))
                    Stocks.Add(reader.GetInt32("Stocks"))
                    Status.Add(reader.GetString("Status"))


                End While
                reader.Close()
                For i As Integer = 0 To ProductID.Count - 1

                    Dim UpdatedStock = Stocks(i) + FreeItemStocks(i)
                    Dim NewStatus = Status(i)
                    '     MessageBox.Show("Status:" + Status(i).ToString + ";free:" + FreeItemStocks(i).ToString)
                    If (Status(i) = "Out of Stock" Or Status(i) = "Out Of Stock") Then
                        If (FreeItemStocks(i) > 0) Then
                            NewStatus = "Available"
                        End If
                    End If

                    cmd.CommandText = "UPDATE `inventory` SET `Stocks`= " & UpdatedStock & " , `status`='" & NewStatus & "' WHERE `ID`='" & ProductID(i) & "'"
                    reader = cmd.ExecuteReader
                    reader.Close()
                Next
                'cmd.CommandText = "UPDATE `inventory` SET `status`='[value-2]',`Price`='[value-5]' WHERE `ID`='[value-1]'"


            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
        End If
        EmployeeUI.SessionDefaults()
        Me.Close()
        BGOverlay.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
        BGOverlay.Close()
    End Sub


End Class