Imports System.Data.SqlClient

Public Class reports
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\OneDrive\Documents\departmentalstore.mdf;Integrated Security=True;Connect Timeout=30")
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
    Private Sub Item()
        Con.Open()
        Dim query = "select * from ItemTB1"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        itemdgv.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub supply()
        Con.Open()
        Dim query = "select * from StockTb1"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        supplydgv.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub sell()
        Con.Open()
        Dim query = "select * from BillTb1 "
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        selldgv.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Home()
        Con.Open()
        Dim query = "select * from HomeTb1"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        homedgv.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub return1()
        Con.Open()
        Dim query = "select * from ReturnTb1"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        returndgv.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        PrintPreviewDialog2.ShowDialog()
        PrintDocument2.Print()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        PrintPreviewDialog3.ShowDialog()
        PrintDocument3.Print()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        PrintPreviewDialog4.ShowDialog()
        PrintDocument4.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.itemdgv.Width, Me.itemdgv.Height)
        itemdgv.DrawToBitmap(bm, New Rectangle(30, 40, Me.itemdgv.Width, Me.itemdgv.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        PrintPreviewDialog5.ShowDialog()
        PrintDocument5.Print()
    End Sub

    Private Sub reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Item()
        sell()
        supply()
        return1()
        Home()
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim bm As New Bitmap(Me.selldgv.Width, Me.selldgv.Height)
        selldgv.DrawToBitmap(bm, New Rectangle(30, 40, Me.selldgv.Width, Me.selldgv.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        Dim bm As New Bitmap(Me.returndgv.Width, Me.returndgv.Height)
        returndgv.DrawToBitmap(bm, New Rectangle(30, 40, Me.returndgv.Width, Me.returndgv.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub PrintDocument4_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument4.PrintPage
        Dim bm As New Bitmap(Me.homedgv.Width, Me.homedgv.Height)
        homedgv.DrawToBitmap(bm, New Rectangle(30, 40, Me.homedgv.Width, Me.homedgv.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub PrintDocument5_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument5.PrintPage
        Dim bm As New Bitmap(Me.supplydgv.Width, Me.supplydgv.Height)
        supplydgv.DrawToBitmap(bm, New Rectangle(30, 40, Me.supplydgv.Width, Me.supplydgv.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class