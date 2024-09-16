'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Imports System.Drawing.Text
Imports MySql.Data.MySqlClient
Public Class CustomerUIOrderPopUp
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        BGOverlay.Close()
        Me.Close()
    End Sub
    Private Sub ButtonPlace_Click(sender As Object, e As EventArgs) Handles ButtonPlace.Click
        Dim CustomerName As String = ""
        CustomerName = NameTextbox.Text
        Dim Order(15) As Integer


        Dim CurrentStocks(15) As Integer
        Dim ProductIDs(15) As String
        Dim TotalOrderCost As Integer

        Order = OrderListModule.OrderList
        TotalOrderCost = CustomerUIOrder.TotalPrice

        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connection.Open()

        End If


        Try
            If (DBConn.Connection.State = ConnectionState.Open) Then


                Dim cmd As New MySqlCommand("", DBConn.Connection)
                Dim rows As Integer
                Dim CustomerPK As Integer
                Dim OrderListPK As Integer

                cmd.CommandText = "INSERT INTO `customer`(`Name`) VALUES ('" & CustomerName & "')"
                rows = cmd.ExecuteNonQuery()
                CustomerPK = Convert.ToInt32(cmd.LastInsertedId)


                If (rows >= 1) Then
                    '   MessageBox.Show("success name")
                Else
                    MessageBox.Show("failed name")
                End If

                cmd.CommandText = "INSERT INTO `orderlist`( `A1`, `A2`, `A3`, `A4`, `A5`, `S1`, `S2`, `D1`, `D2`, `D3_A`, `D3_B`, `D3_C`, `B1`, `B2`, `B3`)
                VALUES ('" & Order(0) & "',    
                '" & Order(1) & "',
                '" & Order(2) & "',
                '" & Order(3) & "',
                '" & Order(4) & "',
                '" & Order(5) & "',
                '" & Order(6) & "',
                '" & Order(7) & "',
                '" & Order(8) & "',
                '" & Order(9) & "',
                '" & Order(10) & "',
                '" & Order(11) & "',
                '" & Order(12) & "',
                '" & Order(13) & "',
                '" & Order(14) & "')"
                rows = cmd.ExecuteNonQuery()
                OrderListPK = Convert.ToInt32(cmd.LastInsertedId)


                If (rows >= 1) Then
                    '   MessageBox.Show("success orderlist")
                Else
                    MessageBox.Show("failed orderlist")
                End If


                cmd.CommandText = "INSERT INTO `order`( `Customer_ID`, `Customer_Name`, `TotalOrder_Cost`, `OrderList_ID`)
                VALUES ('" & CustomerPK & "',
                '" & CustomerName & "',
                '" & TotalOrderCost & "',
                '" & OrderListPK & "')"
                rows = cmd.ExecuteNonQuery()


                If (rows >= 1) Then
                    'MessageBox.Show("success Order")
                Else
                    MessageBox.Show("failed Order")
                End If

                cmd.CommandText = "SELECT `ID`,  `Stocks` FROM `inventory` WHERE 1"
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                Dim n As Integer = 0
                While reader.Read
                    CurrentStocks(n) = reader.GetInt32("Stocks")
                    ProductIDs(n) = reader.GetString("ID")
                    n += 1

                End While
                reader.Close()


                For i As Integer = 0 To CurrentStocks.Length - 1
                    Dim NewStockValue = CurrentStocks(i) - Order(i)

                    cmd.CommandText = "UPDATE `inventory` SET `Stocks`='" & NewStockValue & "' WHERE  ID = '" & ProductIDs(i) & "'"
                    reader = cmd.ExecuteReader
                    reader.Close()
                    If (NewStockValue = 0) Then
                        cmd.CommandText = "UPDATE `inventory` SET `Status`='Out of Stock' WHERE ID = '" & ProductIDs(i) & "'"
                        reader = cmd.ExecuteReader
                        reader.Close()
                    End If
                Next

                CustomerUI.Show()

                CustomerUI.Order_Success()
            End If
        Catch ex As MySqlException

            MessageBox.Show(ex.Message)
        End Try


    End Sub

End Class