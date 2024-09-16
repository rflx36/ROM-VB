'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Public Class CustomerUIOrderSuccess

    Dim Delay As Integer

    Private x As Integer

    Private Sub CustomerUIOrderSuccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerUI.SetDefaults()
        OrderListModule.SetDefaults()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Delay < 500 Then
            If CustomerUIOrderPopUp.Visible Then
                CustomerUIOrderPopUp.Close()
                BGOverlay.Close()
                CustomerUIOrder.Close()
            End If
        End If

        If Delay < 1000 Then
            Delay += 20
            Return
        End If
        x += 1

        If Me.Visible Then
            Me.Opacity -= 0.01 * x


            If (Me.Opacity = 0) Then

                Me.Close()
            End If

        End If
    End Sub
End Class