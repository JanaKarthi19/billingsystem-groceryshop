<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bill_page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(bill_page))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        GroupBox1 = New GroupBox()
        Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        ClNameTb = New TextBox()
        Label2 = New Label()
        PriceTb = New TextBox()
        Label6 = New Label()
        QtyTb = New TextBox()
        Label5 = New Label()
        ItNameTb = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        BillDGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        TotalLbl = New Label()
        ItemDGV = New DataGridView()
        PictureBox1 = New PictureBox()
        Label9 = New Label()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        SearchTb = New TextBox()
        Label7 = New Label()
        GroupBox1.SuspendLayout()
        CType(BillDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(ItemDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Guna2GradientButton3)
        GroupBox1.Controls.Add(Guna2GradientButton2)
        GroupBox1.Controls.Add(ClNameTb)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(PriceTb)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(QtyTb)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(ItNameTb)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(52, 83)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(464, 249)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "SELLS DETAILS"' 
        ' Guna2GradientButton3
        ' 
        Guna2GradientButton3.AutoRoundedCorners = True
        Guna2GradientButton3.BorderRadius = 15
        Guna2GradientButton3.CustomizableEdges = CustomizableEdges1
        Guna2GradientButton3.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton3.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton3.FillColor = Color.OrangeRed
        Guna2GradientButton3.FillColor2 = Color.Red
        Guna2GradientButton3.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton3.ForeColor = Color.Black
        Guna2GradientButton3.Location = New Point(273, 184)
        Guna2GradientButton3.Name = "Guna2GradientButton3"
        Guna2GradientButton3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientButton3.Size = New Size(139, 32)
        Guna2GradientButton3.TabIndex = 62
        Guna2GradientButton3.Text = "Reset"' 
        ' Guna2GradientButton2
        ' 
        Guna2GradientButton2.AutoRoundedCorners = True
        Guna2GradientButton2.BorderRadius = 20
        Guna2GradientButton2.CustomizableEdges = CustomizableEdges3
        Guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton2.FillColor = Color.OrangeRed
        Guna2GradientButton2.FillColor2 = Color.Ivory
        Guna2GradientButton2.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton2.ForeColor = Color.Black
        Guna2GradientButton2.Location = New Point(20, 184)
        Guna2GradientButton2.Name = "Guna2GradientButton2"
        Guna2GradientButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientButton2.Size = New Size(151, 32)
        Guna2GradientButton2.TabIndex = 61
        Guna2GradientButton2.Text = "Add to Bill"' 
        ' ClNameTb
        ' 
        ClNameTb.Location = New Point(4, 142)
        ClNameTb.Margin = New Padding(3, 2, 3, 2)
        ClNameTb.Multiline = True
        ClNameTb.Name = "ClNameTb"
        ClNameTb.Size = New Size(196, 30)
        ClNameTb.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.OrangeRed
        Label2.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(13, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 26)
        Label2.TabIndex = 13
        Label2.Text = "CLIENT NAME:"' 
        ' PriceTb
        ' 
        PriceTb.Location = New Point(256, 142)
        PriceTb.Margin = New Padding(3, 2, 3, 2)
        PriceTb.Multiline = True
        PriceTb.Name = "PriceTb"
        PriceTb.Size = New Size(192, 30)
        PriceTb.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.OrangeRed
        Label6.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(256, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 26)
        Label6.TabIndex = 11
        Label6.Text = "PRICE:"' 
        ' QtyTb
        ' 
        QtyTb.Location = New Point(256, 58)
        QtyTb.Margin = New Padding(3, 2, 3, 2)
        QtyTb.Multiline = True
        QtyTb.Name = "QtyTb"
        QtyTb.Size = New Size(192, 30)
        QtyTb.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.OrangeRed
        Label5.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(256, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 26)
        Label5.TabIndex = 9
        Label5.Text = "QUANTITY:"' 
        ' ItNameTb
        ' 
        ItNameTb.Location = New Point(4, 58)
        ItNameTb.Margin = New Padding(3, 2, 3, 2)
        ItNameTb.Multiline = True
        ItNameTb.Name = "ItNameTb"
        ItNameTb.Size = New Size(196, 30)
        ItNameTb.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.OrangeRed
        Label3.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(13, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 26)
        Label3.TabIndex = 5
        Label3.Text = "PRODUCT ID:"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.OrangeRed
        Label1.Font = New Font("Agency FB", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(485, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 59)
        Label1.TabIndex = 1
        Label1.Text = "SELLS PRODUCT"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.OrangeRed
        Label4.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(281, 378)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 26)
        Label4.TabIndex = 17
        Label4.Text = "ITEMS DETAILS"' 
        ' BillDGV
        ' 
        BillDGV.BackgroundColor = SystemColors.ActiveCaption
        BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BillDGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        BillDGV.Location = New Point(727, 109)
        BillDGV.Margin = New Padding(3, 2, 3, 2)
        BillDGV.Name = "BillDGV"
        BillDGV.RowHeadersWidth = 51
        BillDGV.RowTemplate.Height = 29
        BillDGV.Size = New Size(664, 277)
        BillDGV.TabIndex = 19
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "ITEMS"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "PRICE"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "QUANTITY"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "TOTAL"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' TotalLbl
        ' 
        TotalLbl.AutoSize = True
        TotalLbl.BackColor = Color.OrangeRed
        TotalLbl.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        TotalLbl.Location = New Point(1000, 475)
        TotalLbl.Name = "TotalLbl"
        TotalLbl.Size = New Size(59, 26)
        TotalLbl.TabIndex = 20
        TotalLbl.Text = "TOTAL"' 
        ' ItemDGV
        ' 
        ItemDGV.BackgroundColor = SystemColors.ActiveCaption
        ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemDGV.Location = New Point(24, 493)
        ItemDGV.Margin = New Padding(3, 2, 3, 2)
        ItemDGV.Name = "ItemDGV"
        ItemDGV.RowHeadersWidth = 51
        ItemDGV.RowTemplate.Height = 29
        ItemDGV.Size = New Size(664, 252)
        ItemDGV.TabIndex = 22
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 7)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(41, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 59
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Agency FB", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(69, 10)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 24)
        Label9.TabIndex = 58
        Label9.Text = "HOME"' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges5
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.MediumSpringGreen
        Guna2GradientButton1.FillColor2 = Color.Violet
        Guna2GradientButton1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton1.ForeColor = Color.Black
        Guna2GradientButton1.Location = New Point(941, 516)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientButton1.Size = New Size(180, 45)
        Guna2GradientButton1.TabIndex = 60
        Guna2GradientButton1.Text = "Save"' 
        ' SearchTb
        ' 
        SearchTb.Location = New Point(123, 453)
        SearchTb.Multiline = True
        SearchTb.Name = "SearchTb"
        SearchTb.Size = New Size(558, 35)
        SearchTb.TabIndex = 61
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.OrangeRed
        Label7.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(44, 458)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 26)
        Label7.TabIndex = 62
        Label7.Text = "SEARCH"' 
        ' bill_page
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1529, 770)
        Controls.Add(Label7)
        Controls.Add(SearchTb)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(PictureBox1)
        Controls.Add(Label9)
        Controls.Add(ItemDGV)
        Controls.Add(TotalLbl)
        Controls.Add(BillDGV)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "bill_page"
        Text = "bill_page"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(BillDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(ItemDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ItNameTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents QtyTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PriceTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ClNameTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BillDGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents TotalLbl As Label
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents SearchTb As TextBox
    Friend WithEvents Label7 As Label
End Class
