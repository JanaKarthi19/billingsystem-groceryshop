<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchdeatils
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(searchdeatils))
        CusDGV = New DataGridView()
        Label4 = New Label()
        Panel1 = New Panel()
        PriceTb = New TextBox()
        Label1 = New Label()
        Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        ClNameTb1 = New TextBox()
        Label2 = New Label()
        AmountTb = New TextBox()
        Label6 = New Label()
        QtyTb = New TextBox()
        Label5 = New Label()
        ItNameTb = New TextBox()
        Label3 = New Label()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        TotalLbl = New Label()
        NewDGV = New DataGridView()
        C1 = New DataGridViewTextBoxColumn()
        C2 = New DataGridViewTextBoxColumn()
        C3 = New DataGridViewTextBoxColumn()
        C4 = New DataGridViewTextBoxColumn()
        C5 = New DataGridViewTextBoxColumn()
        ItemDGV = New DataGridView()
        PictureBox1 = New PictureBox()
        Label9 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(CusDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(NewDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(ItemDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CusDGV
        ' 
        CusDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CusDGV.Location = New Point(12, 443)
        CusDGV.Name = "CusDGV"
        CusDGV.RowTemplate.Height = 25
        CusDGV.Size = New Size(678, 322)
        CusDGV.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(261, 390)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 26)
        Label4.TabIndex = 18
        Label4.Text = "CUSTOMER DETALIS"' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PriceTb)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Guna2GradientButton3)
        Panel1.Controls.Add(Guna2GradientButton2)
        Panel1.Controls.Add(ClNameTb1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(AmountTb)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(QtyTb)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(ItNameTb)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(30, 56)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(610, 315)
        Panel1.TabIndex = 19
        ' 
        ' PriceTb
        ' 
        PriceTb.Location = New Point(283, 133)
        PriceTb.Margin = New Padding(3, 2, 3, 2)
        PriceTb.Multiline = True
        PriceTb.Name = "PriceTb"
        PriceTb.Size = New Size(192, 30)
        PriceTb.TabIndex = 74
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(283, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 26)
        Label1.TabIndex = 73
        Label1.Text = "PRICE:"' 
        ' Guna2GradientButton3
        ' 
        Guna2GradientButton3.CustomizableEdges = CustomizableEdges7
        Guna2GradientButton3.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton3.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton3.FillColor = Color.MediumSpringGreen
        Guna2GradientButton3.FillColor2 = Color.Violet
        Guna2GradientButton3.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton3.ForeColor = Color.Black
        Guna2GradientButton3.Location = New Point(360, 264)
        Guna2GradientButton3.Name = "Guna2GradientButton3"
        Guna2GradientButton3.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2GradientButton3.Size = New Size(151, 32)
        Guna2GradientButton3.TabIndex = 72
        Guna2GradientButton3.Text = "Reset"' 
        ' Guna2GradientButton2
        ' 
        Guna2GradientButton2.CustomizableEdges = CustomizableEdges9
        Guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton2.FillColor = Color.MediumSpringGreen
        Guna2GradientButton2.FillColor2 = Color.Violet
        Guna2GradientButton2.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton2.ForeColor = Color.Black
        Guna2GradientButton2.Location = New Point(84, 264)
        Guna2GradientButton2.Name = "Guna2GradientButton2"
        Guna2GradientButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2GradientButton2.Size = New Size(151, 32)
        Guna2GradientButton2.TabIndex = 71
        Guna2GradientButton2.Text = "Add to Bill"' 
        ' ClNameTb1
        ' 
        ClNameTb1.Location = New Point(20, 134)
        ClNameTb1.Margin = New Padding(3, 2, 3, 2)
        ClNameTb1.Multiline = True
        ClNameTb1.Name = "ClNameTb1"
        ClNameTb1.Size = New Size(196, 30)
        ClNameTb1.TabIndex = 70
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(29, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 26)
        Label2.TabIndex = 69
        Label2.Text = "CLIENT NAME:"' 
        ' AmountTb
        ' 
        AmountTb.Location = New Point(29, 218)
        AmountTb.Margin = New Padding(3, 2, 3, 2)
        AmountTb.Multiline = True
        AmountTb.Name = "AmountTb"
        AmountTb.Size = New Size(192, 30)
        AmountTb.TabIndex = 68
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(29, 176)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 26)
        Label6.TabIndex = 67
        Label6.Text = "AMOUNT:"' 
        ' QtyTb
        ' 
        QtyTb.Location = New Point(272, 50)
        QtyTb.Margin = New Padding(3, 2, 3, 2)
        QtyTb.Multiline = True
        QtyTb.Name = "QtyTb"
        QtyTb.Size = New Size(192, 30)
        QtyTb.TabIndex = 66
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(272, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 26)
        Label5.TabIndex = 65
        Label5.Text = "QUANTITY:"' 
        ' ItNameTb
        ' 
        ItNameTb.Location = New Point(20, 50)
        ItNameTb.Margin = New Padding(3, 2, 3, 2)
        ItNameTb.Multiline = True
        ItNameTb.Name = "ItNameTb"
        ItNameTb.Size = New Size(196, 30)
        ItNameTb.TabIndex = 64
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(29, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 26)
        Label3.TabIndex = 63
        Label3.Text = "PRODUCT NAME:"' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges11
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.MediumSpringGreen
        Guna2GradientButton1.FillColor2 = Color.Violet
        Guna2GradientButton1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton1.ForeColor = Color.Black
        Guna2GradientButton1.Location = New Point(1159, 709)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2GradientButton1.Size = New Size(180, 45)
        Guna2GradientButton1.TabIndex = 62
        Guna2GradientButton1.Text = "Save"' 
        ' TotalLbl
        ' 
        TotalLbl.AutoSize = True
        TotalLbl.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        TotalLbl.Location = New Point(1218, 668)
        TotalLbl.Name = "TotalLbl"
        TotalLbl.Size = New Size(59, 26)
        TotalLbl.TabIndex = 61
        TotalLbl.Text = "TOTAL"' 
        ' NewDGV
        ' 
        NewDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        NewDGV.Columns.AddRange(New DataGridViewColumn() {C1, C2, C3, C4, C5})
        NewDGV.Location = New Point(891, 434)
        NewDGV.Name = "NewDGV"
        NewDGV.RowTemplate.Height = 25
        NewDGV.Size = New Size(573, 215)
        NewDGV.TabIndex = 63
        ' 
        ' C1
        ' 
        C1.HeaderText = "ID"
        C1.Name = "C1"' 
        ' C2
        ' 
        C2.HeaderText = "Items"
        C2.Name = "C2"' 
        ' C3
        ' 
        C3.HeaderText = "Price"
        C3.Name = "C3"' 
        ' C4
        ' 
        C4.HeaderText = "Quantity"
        C4.Name = "C4"' 
        ' C5
        ' 
        C5.HeaderText = "Total"
        C5.Name = "C5"' 
        ' ItemDGV
        ' 
        ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemDGV.Location = New Point(878, 100)
        ItemDGV.Margin = New Padding(3, 2, 3, 2)
        ItemDGV.Name = "ItemDGV"
        ItemDGV.RowHeadersWidth = 51
        ItemDGV.RowTemplate.Height = 29
        ItemDGV.Size = New Size(664, 252)
        ItemDGV.TabIndex = 64
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(14, 6)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(41, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 73
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Agency FB", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(59, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 24)
        Label9.TabIndex = 72
        Label9.Text = "HOME"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Agency FB", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(699, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(145, 59)
        Label7.TabIndex = 71
        Label7.Text = "RETURN"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(1068, 56)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 26)
        Label8.TabIndex = 74
        Label8.Text = "STOCK  DETALIS"' 
        ' searchdeatils
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1587, 794)
        Controls.Add(Label8)
        Controls.Add(PictureBox1)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(ItemDGV)
        Controls.Add(NewDGV)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(TotalLbl)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(CusDGV)
        Name = "searchdeatils"
        Text = "searchdeatils"
        CType(CusDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(NewDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(ItemDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CusDGV As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ClNameTb1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AmountTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents QtyTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ItNameTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TotalLbl As Label
    Friend WithEvents NewDGV As DataGridView
    Friend WithEvents PriceTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
