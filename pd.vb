Imports System.Data.SqlClient
Public Class pd
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\OneDrive\Documents\departmentalstore.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub clear()
        ItNameTb.Text = ""
        QtyTb.Text = ""
        MesuCb.SelectedIndex = 0
        PriceTb.Text = ""
        CatCb.SelectedIndex = 0
    End Sub

    Private Sub DisplayItem()
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
    Dim key = 0

    Private Sub pd_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub

    Private Sub ItemDGV_CellMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItNameTb.Text = row.Cells(1).Value.ToString
        QtyTb.Text = row.Cells(2).Value.ToString
        MesuCb.SelectedItem = row.Cells(3).Value.ToString
        PriceTb.Text = row.Cells(4).Value.ToString
        CatCb.SelectedItem = row.Cells(5).Value.ToString
        If ItNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim Obj = New home
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Obj = New home
        Obj.Show()
        Me.Hide()
    End Sub


    Private Sub search()
        Con.Open()
        Dim query = "Select * from ItemTb1 where ItId like'%" & SearchTb.Text & "%' or ItName like '%" & SearchTb.Text & "%' or ItCat like'%" & SearchTb.Text & "%'"
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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If ItNameTb.Text = "" Or QtyTb.Text = "" Or MesuCb.SelectedIndex = -1 Or PriceTb.Text = "" Or CatCb.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "insert into ItemTb1 values('" & ItNameTb.Text & "'," & QtyTb.Text & ",'" & MesuCb.SelectedItem.ToString() & "'," & PriceTb.Text & ",'" & CatCb.SelectedItem.ToString() & "') "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Saved Successfully")
                Con.Close()
                DisplayItem()
                clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        If ItNameTb.Text = "" Or QtyTb.Text = "" Or MesuCb.SelectedIndex = -1 Or CatCb.SelectedIndex = -1 Or PriceTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "Update ItemTB1 set ItName='" & ItNameTb.Text & "',ItQty=" & QtyTb.Text & ",ItPrice= " & PriceTb.Text & ",ItCat= '" & CatCb.SelectedItem.ToString() & "' where Itid=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Updated Successfully")
                Con.Close()
                DisplayItem()
                clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        If key = 0 Then
            MsgBox("Select Item to Delete")
        Else
            Try
                Con.Open()
                Dim query = "delete from ItemTb1 where ItId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Deleted Successfully")
                Con.Close()
                DisplayItem()
                clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        clear()
    End Sub
End Class