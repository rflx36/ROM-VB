'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Public Class BGOverlay
    Private Sub BGOverlay_Load(sender As Object, e As EventArgs) Handles MyBase.Click

        If MenuSelectionPopUp.Visible Then
            MenuSelectionPopUp.Close()
        ElseIf CustomerUIOrderPopUp.Visible Then
            CustomerUIOrderPopUp.Close()
        ElseIf EmployeeUIPopUp.Visible Then
            EmployeeUIPopUp.Close()
        End If

        Me.Close()
    End Sub

End Class