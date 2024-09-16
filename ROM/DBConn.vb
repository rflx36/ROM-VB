'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Imports MySql.Data.MySqlClient

Module DBConn

    Public ConnectionString = "host=127.0.0.1;user=root;password=;database=rom_db"
    Public Connection As New MySqlConnection(ConnectionString)
    Public Sub Connect(i As Integer)


        '1 = ClientUI Request
        '2 = EmployeeUI Request
        '3 = Admin Request
        Try
            Connection.Open()
            If (i = 1) Then
                If (CustomerUI.Visible = False) Then
                    CustomerUI.Show()
                    ErrorConnectionUI.Close()
                End If
            ElseIf (i = 2) Then

            End If
        Catch ex As Exception
            If (i = 1) Then
                CustomerUI.Hide()
                ErrorConnectionUI.ErrorInfo = ex.Message
                If ErrorConnectionUI.Visible = False Then
                    ErrorConnectionUI.ShowDialog()
                End If

            ElseIf (i = 2) Then

                EmployeeUILogin.ErrorTextDisplay(ex.Message)

            End If
        End Try
    End Sub
End Module
