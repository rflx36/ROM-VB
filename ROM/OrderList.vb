'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Module OrderListModule


    Public OrderList(15) As Integer

    Public Sub Main()
        OrderList(0) = 0    'A1
        OrderList(1) = 0    'A2
        OrderList(2) = 0    'A3
        OrderList(3) = 0    'A4
        OrderList(4) = 0    'A5
        OrderList(5) = 0    'S1
        OrderList(6) = 0    'S2
        OrderList(7) = 0    'D1
        OrderList(8) = 0    'D2
        OrderList(9) = 0    'D3_A
        OrderList(10) = 0    'D3_B
        OrderList(11) = 0    'D3_C
        OrderList(12) = 0    'B1
        OrderList(13) = 0    'B2
        OrderList(14) = 0    'B3
        OrderList(15) = 0    'B4


    End Sub
    Public Sub OrderUpdate(OrderType As Integer, OrderAmount As Integer)

        OrderList(OrderType) += OrderAmount


        'For i As Integer = 0 To OrderList.Length - 1
        '  OrderList(i)
        ' Next
    End Sub
    Public Sub SetDefaults()

        For i As Integer = 0 To OrderList.Length - 1
            OrderList(i) = 0
        Next

    End Sub

End Module
