Imports System.Data.DataTable
Public Class ucHome
    Dim table As New DataTable

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If tbOldMileage.Text = "" OrElse tbNewMileage.Text = "" OrElse tbFuelQuantity.Text = "" OrElse tbCost.Text = "" Then
            MessageBox.Show("please fill all the fields", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CDbl(tbOldMileage.Text) > CDbl(tbNewMileage.Text) Then
            MessageBox.Show("New Milage reading Entered should be Greater than Old milage", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lbDistance.Text = Distance()
            lbAvgConPKm.Text = AvgConPerKm()
            lbCurrCost.Text = CostOfCurrentDist()
            Add_To_DataGridView()
            lbTotCost.Text = TotalFuelCost()
            lbAvgConOTotDist.Text = AvgConsOVerTotDist()
            lbAvConUnits.Text = "Liters/" + CStr(Units_AvgConsOVerTotDist()) + " Km"
            clearTextBoxes()
        End If
    End Sub

    '' allow only double values to the text box
    Private Sub tbOldMilage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbOldMileage.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," Then e.KeyChar = ""
    End Sub
    Private Sub tbNewMilage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbNewMileage.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," Then e.KeyChar = ""
    End Sub
    Private Sub tbFuelQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbFuelQuantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," Then e.KeyChar = ""
    End Sub
    Private Sub tbCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbCost.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," Then e.KeyChar = ""
    End Sub


    'functtions
    Private Function Distance() As Double
        Dim dis As Double
        dis = tbNewMileage.Text - tbOldMileage.Text
        Return dis
    End Function
    Private Function AvgConPerKm() As Double
        Dim lit As Double
        lit = tbFuelQuantity.Text / (tbNewMileage.Text - tbOldMileage.Text)
        Return lit
    End Function
    Private Function CostOfCurrentDist() As Double
        Dim cost As Double
        cost = tbCost.Text * tbFuelQuantity.Text
        Return cost
    End Function
    Private Function TotalFuelCost() As Double
        Dim cost As Double = 0
        Dim tempCost As Double
        Dim noRows As Integer = dgvInput.Rows.Count
        For i As Integer = 0 To noRows - 2
            tempCost = dgvInput.Rows(i).Cells(2).Value * dgvInput.Rows(i).Cells(3).Value
            cost = cost + tempCost
        Next
        Return cost
    End Function
    Private Function AvgConsOVerTotDist() As Double
        Dim lit As Double
        Dim temLit As Double
        Dim dis As Double
        Dim temDis As Double
        Dim noRows As Integer = dgvInput.Rows.Count
        For i As Integer = 0 To noRows - 2
            temLit = dgvInput.Rows(i).Cells(2).Value
            lit = lit + temLit
        Next
        For i As Integer = 0 To noRows - 2
            temDis = dgvInput.Rows(i).Cells(1).Value - dgvInput.Rows(i).Cells(0).Value
            dis = dis + temDis
        Next
        Return lit
    End Function
    Private Function Units_AvgConsOVerTotDist() As Double
        Dim dis As Double
        Dim temDis As Double
        Dim noRows As Integer = dgvInput.Rows.Count
        For i As Integer = 0 To noRows - 2
            temDis = dgvInput.Rows(i).Cells(1).Value - dgvInput.Rows(i).Cells(0).Value
            dis = dis + temDis
        Next
        Return dis
    End Function
    Private Sub ucHome_load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("Old Milage (Km/L)")
        table.Columns.Add("New Milage (Km/L)")
        table.Columns.Add("Fueled Quantity (Liter)")
        table.Columns.Add("Cost (€)")
        dgvInput.DataSource = table
    End Sub
    Private Sub Add_To_DataGridView()
        table.Rows.Add(tbOldMileage.Text, tbNewMileage.Text, tbFuelQuantity.Text, tbCost.Text)
        dgvInput.DataSource = table
    End Sub
    Private Sub clearTextBoxes()
        tbFuelQuantity.Text = ""
        tbOldMileage.Text = ""
        tbNewMileage.Text = ""
    End Sub
End Class
