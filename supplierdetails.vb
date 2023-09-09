Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class supplierdetails
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\OneDrive\Documents\departmentalstore.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub clear()
        CoNameTb.Text = ""
        MobTb.Text = ""
        AddTb.Text = ""
        ProNameTb.Text = ""
        SearchTb.Text = ""
    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "Select * from StockTb1"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        StockDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Dim key = 0

    Private Sub StockDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles StockDGV.CellMouseClick
        Dim row As DataGridViewRow = StockDGV.Rows(e.RowIndex)
        CoNameTb.Text = row.Cells(1).Value.ToString
        MobTb.Text = row.Cells(2).Value.ToString
        AddTb.Text = row.Cells(3).Value.ToString
        ProNameTb.Text = row.Cells(4).Value.ToString
        If CoNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub

    Private Sub search()
        Con.Open()
        Dim query = "Select * from StockTb1 where ComName like '%" & SearchTb.Text & "%'"
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
            StockDGV.DataSource = dt
        Else
            MsgBox("No Record Found!")
        End If
        Con.Close()
    End Sub


    Private Sub SearchTb_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchTb.KeyUp
        search()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj = New home
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Obj = New home
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If CoNameTb.Text = "" Or MobTb.Text = "" Or AddTb.Text = "" Or ProNameTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "insert into StockTb1 values('" & CoNameTb.Text & "'," & MobTb.Text & ",'" & AddTb.Text & "','" & ProNameTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Details Saved Successfully")
                Con.Close()
                DisplayItem()
                clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        If CoNameTb.Text = "" Or MobTb.Text = "" Or AddTb.Text = "" Or ProNameTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "Update StockTb1 set ComName='" & CoNameTb.Text & "',Mob=" & MobTb.Text & ",Address='" & AddTb.Text & "',ProName='" & ProNameTb.Text & "' where StId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Updated Successfully")
                Con.Close()
                DisplayItem()
                clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        If key = 0 Then
            MsgBox("Select Details to Delete")
        Else
            Try
                Con.Open()
                Dim query = "delete from StockTb1 where StId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Details Deleted Successfully")
                Con.Close()
                DisplayItem()
                clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        clear()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class