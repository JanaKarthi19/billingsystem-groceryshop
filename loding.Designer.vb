<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loding
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(loding))
        Label1 = New Label()
        Label2 = New Label()
        PerLb = New Label()
        Timer1 = New Timer(components)
        MyProgress = New Guna.UI2.WinForms.Guna2ProgressBar()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bell MT", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.Aqua
        Label1.Location = New Point(58, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(933, 74)
        Label1.TabIndex = 1
        Label1.Text = "GROCERY SHOP SOFTWARE"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bell MT", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(45, 408)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 31)
        Label2.TabIndex = 3
        Label2.Text = "Loading....."' 
        ' PerLb
        ' 
        PerLb.AutoSize = True
        PerLb.BackColor = Color.Transparent
        PerLb.Font = New Font("Bell MT", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        PerLb.ForeColor = SystemColors.HotTrack
        PerLb.Location = New Point(214, 408)
        PerLb.Name = "PerLb"
        PerLb.Size = New Size(36, 31)
        PerLb.TabIndex = 4
        PerLb.Text = "%"' 
        ' Timer1
        ' 
        Timer1.Interval = 30
        ' 
        ' MyProgress
        ' 
        MyProgress.CustomizableEdges = CustomizableEdges1
        MyProgress.Location = New Point(45, 462)
        MyProgress.Name = "MyProgress"
        MyProgress.ProgressColor = Color.Cyan
        MyProgress.ProgressColor2 = SystemColors.HotTrack
        MyProgress.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        MyProgress.Size = New Size(1035, 21)
        MyProgress.TabIndex = 5
        MyProgress.Text = "Guna2ProgressBar1"
        MyProgress.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        ' 
        ' loding
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1121, 542)
        Controls.Add(MyProgress)
        Controls.Add(PerLb)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "loding"
        Text = "loding"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PerLb As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MyProgress As Guna.UI2.WinForms.Guna2ProgressBar
End Class
