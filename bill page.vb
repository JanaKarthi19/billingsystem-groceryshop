
Imports System.Data.SqlClient

Public Class bill_page
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\OneDrive\Documents\departmentalstore.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub AddBill()
        Try
            Con.Open()
            Dim query = "Insert into BillTb1 values('" & ClNameTb.Text & "','" & GrdTotal & "','" & DateTime.Now.ToLongDateString & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Bill Saved Successfully")
            Con.Close()
            TotalLbl.Text = "Total"
            BillDGV.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemTB1"
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
    Dim key = 0, Stock = 0
    Private Sub UpdateItem()
        Dim newQty = Stock - Convert.ToInt32(QtyTb.Text)
        Try
            Con.Open()
            Dim query = "Update ItemTB1 set ItQty=" & newQty & " where Itid=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            DisplayItem()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Reset()
        ItNameTb.Text = ""
        PriceTb.Text = ""
        QtyTb.Text = ""
        'TotalLbl.Text = "Total"
        key = 0
        Stock = 0
    End Sub
    Dim i = 0, GrdTotal = 0



    Private Sub bill_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If ClNameTb.Text = "" Then
            MsgBox("Enter Client Name")
        Else
            AddBill()
        End If
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Reset()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        If ItNameTb.Text = "" Or PriceTb.Text = "" Then
            MsgBox("Select the Item")
        ElseIf QtyTb.Text = "" Then
            MsgBox("Enter the Qunatity")
        ElseIf QtyTb.Text > Stock Then
            MsgBox("No Enough Stock")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Dim total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = ItNameTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = PriceTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = QtyTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = total
            GrdTotal = GrdTotal + total
            Dim tot As String
            tot = "Rs" + Convert.ToString(GrdTotal)
            TotalLbl.Text = tot
            UpdateItem()
            DisplayItem()
            'Reset()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub search()
        Con.Open()
        Dim query = "Select * from ItemTb1 where ItId like'%" & SearchTb.Text & "%' or ItName like '%" & SearchTb.Text & "%' or ItCat like '%" & SearchTb.Text & "%' "
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

    Private Sub SearchTb_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchTb.KeyUp
        search()
    End Sub
End Class