Imports System.Data.SqlClient

Public Class searchdeatils
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\OneDrive\Documents\departmentalstore.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from BillTb1"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CusDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub DisplayItem1()
        Con.Open()
        Dim query = "select * from ItemTb1"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub UpdateItem()
        Dim newQty = Stock + Convert.ToInt32(QtyTb.Text)
        Try
            Con.Open()
            Dim query = "Update ItemTB1 set ItQty=" & newQty & " where Itid=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Updated Successfully")
            Con.Close()
            DisplayItem1()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Reset()
        ItNameTb.Text = ""
        PriceTb.Text = ""
        QtyTb.Text = ""
        ClNameTb1.Text = ""
        AmountTb.Text = ""
        key = 0
        Stock = 0
    End Sub
    Private Sub searchdeatils_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub
    Dim key = 0, Stock = 0
    Private Sub CusDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CusDGV.CellMouseClick
        Dim row As DataGridViewRow = CusDGV.Rows(e.RowIndex)
        ClNameTb1.Text = row.Cells(1).Value.ToString
        AmountTb.Text = row.Cells(2).Value.ToString
        If ClNameTb1.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            Stock = Convert.ToInt32(row.Cells(2).Value.ToString)
        End If
    End Sub
    Dim i = 0, gdtotal = 0, gdtotal2 = 0
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        If ClNameTb1.Text = "" Or AmountTb.Text = "" Then
            MsgBox("Select the Item")
        ElseIf QtyTb.Text = "" Then
            MsgBox("Enter the Qunatity")
        Else
            Dim rnum As Integer = NewDGV.Rows.Add()
            i = i + 1
            Dim tot1 = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text)
            NewDGV.Rows.Item(rnum).Cells("C1").Value = i
            NewDGV.Rows.Item(rnum).Cells("C2").Value = ItNameTb.Text
            NewDGV.Rows.Item(rnum).Cells("C3").Value = PriceTb.Text
            NewDGV.Rows.Item(rnum).Cells("C4").Value = QtyTb.Text
            NewDGV.Rows.Item(rnum).Cells("C5").Value = tot1
            gdtotal = gdtotal + tot1
            gdtotal2 = gdtotal - AmountTb.Text
            Dim tot2 As String
            tot2 = "Rs" + Convert.ToString(gdtotal)
            TotalLbl.Text = tot2
            UpdateItem()
            DisplayItem1()
            'Reset()
        End If
    End Sub
    Private Sub search()
        Con.Open()
        Dim query = "Select * from ItemTb1 where ItId like'%" & ItNameTb.Text & "%' or ItName like '%" & ItNameTb.Text & "%' or ItCat like '%" & ItNameTb.Text & "%' "
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        Dim dt As DataTable
        dt = New DataTable
        adapter.Fill(dt)
        If dt.Rows.Count > 0 Then
            ItemDGV.DataSource = dt
        Else
            MsgBox("No Record Found!")
        End If
        Con.Close()
    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Try
            Con.Open()
            Dim query = "insert into ReturnTb1 values('" & ClNameTb1.Text & "','" & gdtotal2 & "','" & DateTime.Today.ToLongDateString & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Bill Saved Successfully")
            Con.Close()
            TotalLbl.Text = "Total"
            NewDGV.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ItNameTb_KeyUp(sender As Object, e As KeyEventArgs) Handles ItNameTb.KeyUp
        search()
    End Sub

    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItNameTb.Text = row.Cells(1).Value.ToString
        PriceTb.Text = row.Cells(4).Value.ToString
        If ItNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            Stock = Convert.ToInt32(row.Cells(2).Value.ToString)
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim obj = New home
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim obj = New home
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Reset()
    End Sub
End Class