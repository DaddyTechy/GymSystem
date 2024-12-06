<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentRepMemRep
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContentRepMemRep))
        Panel1 = New Panel()
        Panel2 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        btnRevenue = New Button()
        btnMembership = New Button()
        btnEquipment = New Button()
        Button1 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(15, 15)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1211, 466)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.FromArgb(40, 40, 40)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(btnRevenue)
        Panel2.Controls.Add(btnMembership)
        Panel2.Controls.Add(btnEquipment)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(17, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1191, 380)
        Panel2.TabIndex = 2
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DateTimePicker1.CustomFormat = ""
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(883, 21)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(89, 23)
        DateTimePicker1.TabIndex = 3
        DateTimePicker1.Value = New Date(2024, 12, 4, 0, 0, 0, 0)
        DateTimePicker1.Visible = False
        ' 
        ' btnRevenue
        ' 
        btnRevenue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRevenue.BackColor = Color.Gold
        btnRevenue.FlatStyle = FlatStyle.Popup
        btnRevenue.Location = New Point(999, 252)
        btnRevenue.Name = "btnRevenue"
        btnRevenue.Size = New Size(163, 23)
        btnRevenue.TabIndex = 7
        btnRevenue.Text = "Revenue Report"
        btnRevenue.UseVisualStyleBackColor = False
        ' 
        ' btnMembership
        ' 
        btnMembership.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMembership.BackColor = Color.Gold
        btnMembership.FlatStyle = FlatStyle.Popup
        btnMembership.Location = New Point(999, 214)
        btnMembership.Name = "btnMembership"
        btnMembership.Size = New Size(163, 23)
        btnMembership.TabIndex = 6
        btnMembership.Text = "Membership Report"
        btnMembership.UseVisualStyleBackColor = False
        ' 
        ' btnEquipment
        ' 
        btnEquipment.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEquipment.BackColor = Color.Gold
        btnEquipment.FlatStyle = FlatStyle.Popup
        btnEquipment.Location = New Point(999, 174)
        btnEquipment.Name = "btnEquipment"
        btnEquipment.Size = New Size(163, 23)
        btnEquipment.TabIndex = 5
        btnEquipment.Text = "Equipment Report"
        btnEquipment.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Gold
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(999, 134)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 23)
        Button1.TabIndex = 4
        Button1.Text = "Print Attendance Report"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.Gold
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(999, 95)
        Button2.Name = "Button2"
        Button2.Size = New Size(163, 23)
        Button2.TabIndex = 3
        Button2.Text = "Print Member Reports"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(8, 50)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridView1.Size = New Size(964, 302)
        DataGridView1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label3.ForeColor = SystemColors.ControlLight
        Label3.Location = New Point(8, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 20)
        Label3.TabIndex = 0
        Label3.Text = "Report Sections"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(17, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 32)
        Label2.TabIndex = 1
        Label2.Text = "View Reports"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(17, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 20)
        Label1.TabIndex = 0
        Label1.Text = "Member Reports"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' ContentRepMemRep
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(29, 29, 29)
        BackgroundImageLayout = ImageLayout.None
        Controls.Add(Panel1)
        MinimumSize = New Size(675, 496)
        Name = "ContentRepMemRep"
        Padding = New Padding(15)
        Size = New Size(1270, 496)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRevenue As Button
    Friend WithEvents btnMembership As Button
    Friend WithEvents btnEquipment As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker

End Class
