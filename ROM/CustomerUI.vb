'======================================
' @Author : Roland Fonz E. Lamoste
'
' @Designs : Roland Fonz E. Lamoste
'======================================
' Project Started :  6 - 12 - 2023
' Project Finished : 6 - 23 - 2023
'======================================
Imports System.Runtime.Serialization.Formatters
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports Org.BouncyCastle.Bcpg.OpenPgp

Public Class CustomerUI


    Public Sub SetDefaults()
        RemoveSelection()
        AllSelection.BackgroundImage = My.Resources.Main_Button
        AllSelection.Location = New Point(442, 30)



        SelectionMealsPanel.Enabled = False
        SelectionMealsPanel.Visible = False
        SelectionSnacksPanel.Enabled = False
        SelectionSnacksPanel.Visible = False
        SelectionDessertsPanel.Enabled = False
        SelectionDessertsPanel.Visible = False
        SelectionDrinksPanel.Enabled = False
        SelectionDrinksPanel.Visible = False

        SelectionAllPanel.Enabled = True
        SelectionAllPanel.Visible = True
        OrderDetails.BackgroundImage = My.Resources.IconOrder
    End Sub
    Private Sub AllSelection_Click(sender As Object, e As EventArgs) Handles AllSelection.Click
        RemoveSelection()
        AllSelection.BackgroundImage = My.Resources.Main_Button
        AllSelection.Location = New Point(442, 30)



        SelectionMealsPanel.Enabled = False
        SelectionMealsPanel.Visible = False
        SelectionSnacksPanel.Enabled = False
        SelectionSnacksPanel.Visible = False
        SelectionDessertsPanel.Enabled = False
        SelectionDessertsPanel.Visible = False
        SelectionDrinksPanel.Enabled = False
        SelectionDrinksPanel.Visible = False

        SelectionAllPanel.Enabled = True
        SelectionAllPanel.Visible = True


    End Sub

    Private Sub SnacksSelection_Click(sender As Object, e As EventArgs) Handles SnacksSelection.Click
        RemoveSelection()
        SnacksSelection.BackgroundImage = My.Resources.Main_Button
        SnacksSelection.Location = New Point(706, 30)


        SelectionMealsPanel.Enabled = False
        SelectionMealsPanel.Visible = False
        SelectionAllPanel.Enabled = False
        SelectionAllPanel.Visible = False
        SelectionDessertsPanel.Enabled = False
        SelectionDessertsPanel.Visible = False
        SelectionDrinksPanel.Enabled = False
        SelectionDrinksPanel.Visible = False


        SelectionSnacksPanel.Enabled = True
        SelectionSnacksPanel.Visible = True
    End Sub

    Private Sub DrinksSelection_Click(sender As Object, e As EventArgs) Handles DrinksSelection.Click
        RemoveSelection()
        DrinksSelection.BackgroundImage = My.Resources.Main_Button
        DrinksSelection.Location = New Point(920, 30)


        SelectionAllPanel.Enabled = False
        SelectionAllPanel.Visible = False
        SelectionMealsPanel.Enabled = False
        SelectionMealsPanel.Visible = False
        SelectionSnacksPanel.Enabled = False
        SelectionSnacksPanel.Visible = False
        SelectionDessertsPanel.Enabled = False
        SelectionDessertsPanel.Visible = False


        SelectionDrinksPanel.Enabled = True
        SelectionDrinksPanel.Visible = True

    End Sub

    Private Sub MealsSelection_Click(sender As Object, e As EventArgs) Handles MealsSelection.Click
        RemoveSelection()
        MealsSelection.BackgroundImage = My.Resources.Main_Button
        MealsSelection.Location = New Point(228, 30)


        SelectionAllPanel.Enabled = False
        SelectionAllPanel.Visible = False
        SelectionSnacksPanel.Enabled = False
        SelectionSnacksPanel.Visible = False
        SelectionDessertsPanel.Enabled = False
        SelectionDessertsPanel.Visible = False
        SelectionDrinksPanel.Enabled = False
        SelectionDrinksPanel.Visible = False

        SelectionMealsPanel.Enabled = True
        SelectionMealsPanel.Visible = True
    End Sub

    Private Sub DessertsSelection_Click(sender As Object, e As EventArgs) Handles DessertsSelection.Click
        RemoveSelection()
        DessertsSelection.BackgroundImage = My.Resources.Main_Button
        DessertsSelection.Location = New Point(14, 30)



        SelectionAllPanel.Enabled = False
        SelectionAllPanel.Visible = False
        SelectionSnacksPanel.Enabled = False
        SelectionSnacksPanel.Visible = False
        SelectionMealsPanel.Enabled = False
        SelectionMealsPanel.Visible = False
        SelectionDrinksPanel.Enabled = False
        SelectionDrinksPanel.Visible = False


        SelectionDessertsPanel.Enabled = True
        SelectionDessertsPanel.Visible = True

    End Sub


    Private Sub RemoveSelection()
        MenuPanel.VerticalScroll.Value = 0
        AllSelection.Location = New Point(442, 38)
        SnacksSelection.Location = New Point(706, 38)
        DrinksSelection.Location = New Point(920, 38)
        MealsSelection.Location = New Point(228, 38)
        DessertsSelection.Location = New Point(14, 38)

        AllSelection.BackgroundImage = Nothing
        SnacksSelection.BackgroundImage = Nothing
        DrinksSelection.BackgroundImage = Nothing
        MealsSelection.BackgroundImage = Nothing
        DessertsSelection.BackgroundImage = Nothing






    End Sub


    Private Sub MenuItemSelect(Selection As String)

        If BGOverlay.Visible Then
            BGOverlay.Close()
        End If

        If MenuSelectionPopUp.Visible Then
            MenuSelectionPopUp.Close()
        End If

        MenuSelectionPopUp.ModifyItemsSelection(Selection)

        BGOverlay.Show()

        MenuSelectionPopUp.Show()
    End Sub

    Private Sub AllA1_Click(sender As Object, e As EventArgs) Handles AllA1.Click
        MenuItemSelect("A1")
    End Sub

    Private Sub AllA2_Click(sender As Object, e As EventArgs) Handles AllA2.Click
        MenuItemSelect("A2")
    End Sub

    Private Sub AllA3_Click(sender As Object, e As EventArgs) Handles AllA3.Click
        MenuItemSelect("A3")
    End Sub

    Private Sub AllA4_Click(sender As Object, e As EventArgs) Handles AllA4.Click
        MenuItemSelect("A4")
    End Sub

    Private Sub AllA5_Click(sender As Object, e As EventArgs) Handles AllA5.Click
        MenuItemSelect("A5")
    End Sub

    Private Sub AllS1_Click(sender As Object, e As EventArgs) Handles AllS1.Click
        MenuItemSelect("S1")
    End Sub

    Private Sub AllS2_Click(sender As Object, e As EventArgs) Handles AllS2.Click
        MenuItemSelect("S2")
    End Sub

    Private Sub AllD1_Click(sender As Object, e As EventArgs) Handles AllD1.Click
        MenuItemSelect("D1")
    End Sub

    Private Sub AllD2_Click(sender As Object, e As EventArgs) Handles AllD2.Click
        MenuItemSelect("D2")
    End Sub

    Private Sub AllD3_Click(sender As Object, e As EventArgs) Handles AllD3.Click
        MenuItemSelect("D3")
    End Sub

    Private Sub AllB1_Click(sender As Object, e As EventArgs) Handles AllB1.Click
        MenuItemSelect("B1")
    End Sub

    Private Sub AllB2_Click(sender As Object, e As EventArgs) Handles AllB2.Click
        MenuItemSelect("B2")
    End Sub

    Private Sub AllB3_Click(sender As Object, e As EventArgs) Handles AllB3.Click
        MenuItemSelect("B3")
    End Sub

    Private Sub MealsA1_Click(sender As Object, e As EventArgs) Handles MealsA1.Click
        MenuItemSelect("A1")
    End Sub

    Private Sub MealsA2_Click(sender As Object, e As EventArgs) Handles MealsA2.Click
        MenuItemSelect("A2")
    End Sub

    Private Sub MealsA3_Click(sender As Object, e As EventArgs) Handles MealsA3.Click
        MenuItemSelect("A3")
    End Sub

    Private Sub MealsA4_Click(sender As Object, e As EventArgs) Handles MealsA4.Click
        MenuItemSelect("A4")
    End Sub

    Private Sub MealsA5_Click(sender As Object, e As EventArgs) Handles MealsA5.Click
        MenuItemSelect("A5")
    End Sub

    Private Sub SnacksS1_Click(sender As Object, e As EventArgs) Handles SnacksS1.Click
        MenuItemSelect("S1")
    End Sub

    Private Sub SnacksS2_Click(sender As Object, e As EventArgs) Handles SnacksS2.Click
        MenuItemSelect("S2")
    End Sub

    Private Sub DessertsD1_Click(sender As Object, e As EventArgs) Handles DessertsD1.Click
        MenuItemSelect("D1")
    End Sub

    Private Sub DessertsD2_Click(sender As Object, e As EventArgs) Handles DessertsD2.Click
        MenuItemSelect("D2")
    End Sub

    Private Sub DessertsD3_Click(sender As Object, e As EventArgs) Handles DessertsD3.Click
        MenuItemSelect("D3")
    End Sub

    Private Sub DrinksB1_Click(sender As Object, e As EventArgs) Handles DrinksB1.Click
        MenuItemSelect("B1")
    End Sub

    Private Sub DrinksB2_Click(sender As Object, e As EventArgs) Handles DrinksB2.Click
        MenuItemSelect("B2")
    End Sub

    Private Sub DrinksB3_Click(sender As Object, e As EventArgs) Handles DrinksB3.Click
        MenuItemSelect("B3")
    End Sub

    Private Sub OrderDetails_Click(sender As Object, e As EventArgs) Handles OrderDetails.Click
        CustomerUIOrder.Show()

    End Sub

    Private Sub CustomerUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConn.Connect(1)


    End Sub



    Public SuccessDisplay As Boolean = False

    Public Sub Order_Success()
        CustomerUIOrderSuccess.Show()

    End Sub


End Class
