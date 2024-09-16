'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient

Public Class EmployeeUILogin
    Public IsLoggedIn As Boolean = False
    Public Sub ErrorTextDisplay(e As String)
        ErrorDisplay.Text = e
    End Sub


    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        Dim User As String
        Dim Pass As String
        User = Username.Text
        Pass = Password.Text

        If (User = "" And Pass = "") Then
            ErrorTextDisplay("Username and password cannot be empty.")
            Return
        End If

        If (User = "") Then
            ErrorTextDisplay("Username cannot be empty.")
            Return
        End If

        If (Pass = "") Then
            ErrorTextDisplay("Password cannot be empty.")
            Return
        End If
        If (DBConn.Connection.State <> ConnectionState.Open) Then
            DBConn.Connect(2)
        End If
        Try
            If (DBConn.Connection.State = ConnectionState.Open) Then
                Dim cmd As New MySqlCommand("SELECT * FROM employee WHERE username=@username AND password=@password", DBConn.Connection)
                cmd.Parameters.AddWithValue("username", User.Trim)
                cmd.Parameters.AddWithValue("password", Pass.Trim)
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                If reader.Read Then
                    Dim id As Integer = reader.GetInt32("Employee_ID")
                    reader.Close()
                    IsLoggedIn = True
                    EmployeeUI.LoggedIn(id)
                    ' EmployeeUI.Show()
                    Me.Close()
                Else

                    ErrorTextDisplay("Invalid Username or Password")
                    reader.Close()
                End If
            End If

        Catch ex As MySqlException
            ErrorTextDisplay(ex.Message)

        End Try
    End Sub

    Private Sub EmployeeUILogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorDisplay.Text = ""
        Me.Invalidate()
        Me.Update()
    End Sub

    Private Sub EmployeeUILogin_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        If IsLoggedIn Then
            Return
        End If

        EmployeeUI.Close()

    End Sub
End Class