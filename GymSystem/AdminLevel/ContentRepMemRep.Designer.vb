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
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        btnApplyBatchSize = New Button()
        Label4 = New Label()
        txtBatchSize = New TextBox()
        btnBack = New Button()
        btnNext = New Button()
        DateTimePicker1 = New DateTimePicker()
        Panel3 = New Panel()
        Label5 = New Label()
        Label3 = New Label()
        DateTimePicker3 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        btnRevenue = New Button()
        Button2 = New Button()
        btnMembership = New Button()
        btnEquipment = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(17, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 20)
        Label1.TabIndex = 0
        Label1.Text = "Member Reports"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(17, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 32)
        Label2.TabIndex = 1
        Label2.Text = "View Reports"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnApplyBatchSize)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtBatchSize)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnNext)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(15, 15)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1059, 97)
        Panel1.TabIndex = 0
        ' 
        ' btnApplyBatchSize
        ' 
        btnApplyBatchSize.BackColor = Color.Gray
        btnApplyBatchSize.FlatStyle = FlatStyle.Popup
        btnApplyBatchSize.ForeColor = SystemColors.ControlLightLight
        btnApplyBatchSize.Location = New Point(513, 71)
        btnApplyBatchSize.Name = "btnApplyBatchSize"
        btnApplyBatchSize.Size = New Size(48, 22)
        btnApplyBatchSize.TabIndex = 21
        btnApplyBatchSize.Text = "Apply"
        btnApplyBatchSize.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(360, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 15)
        Label4.TabIndex = 20
        Label4.Text = "Amount to Load:"
        ' 
        ' txtBatchSize
        ' 
        txtBatchSize.Location = New Point(460, 69)
        txtBatchSize.Name = "txtBatchSize"
        txtBatchSize.Size = New Size(47, 23)
        txtBatchSize.TabIndex = 19
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Gray
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.ForeColor = SystemColors.ControlLightLight
        btnBack.Location = New Point(882, 70)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(66, 22)
        btnBack.TabIndex = 18
        btnBack.Text = "Load Less"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.Gray
        btnNext.FlatStyle = FlatStyle.Popup
        btnNext.ForeColor = SystemColors.ControlLightLight
        btnNext.Location = New Point(954, 70)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(73, 22)
        btnNext.TabIndex = 17
        btnNext.Text = "Load More"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DateTimePicker1.CustomFormat = ""
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(1742, 21)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(89, 23)
        DateTimePicker1.TabIndex = 3
        DateTimePicker1.Value = New Date(2024, 12, 4, 0, 0, 0, 0)
        DateTimePicker1.Visible = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(DateTimePicker3)
        Panel3.Controls.Add(DateTimePicker2)
        Panel3.Controls.Add(btnRevenue)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(btnMembership)
        Panel3.Controls.Add(btnEquipment)
        Panel3.Controls.Add(Button1)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(859, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 369)
        Panel3.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(13, 305)
        Label5.Name = "Label5"
        Label5.Size = New Size(23, 15)
        Label5.TabIndex = 25
        Label5.Text = "To:"
        Label5.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(13, 256)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 24
        Label3.Text = "From:"
        Label3.Visible = False
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Location = New Point(13, 323)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(137, 23)
        DateTimePicker3.TabIndex = 23
        DateTimePicker3.Visible = False
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(13, 274)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(137, 23)
        DateTimePicker2.TabIndex = 22
        DateTimePicker2.Visible = False
        ' 
        ' btnRevenue
        ' 
        btnRevenue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRevenue.BackColor = Color.Gold
        btnRevenue.FlatStyle = FlatStyle.Popup
        btnRevenue.Location = New Point(19, 22)
        btnRevenue.Name = "btnRevenue"
        btnRevenue.Size = New Size(163, 23)
        btnRevenue.TabIndex = 7
        btnRevenue.Text = "Revenue Report"
        btnRevenue.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.Gold
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(19, 62)
        Button2.Name = "Button2"
        Button2.Size = New Size(163, 23)
        Button2.TabIndex = 3
        Button2.Text = "Print Member Reports"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnMembership
        ' 
        btnMembership.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMembership.BackColor = Color.Gold
        btnMembership.FlatStyle = FlatStyle.Popup
        btnMembership.Location = New Point(19, 183)
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
        btnEquipment.Location = New Point(19, 142)
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
        Button1.Location = New Point(19, 102)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 23)
        Button1.TabIndex = 4
        Button1.Text = "Print Attendance Report"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(15, 112)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1059, 369)
        Panel2.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridView1.Size = New Size(1059, 369)
        DataGridView1.TabIndex = 2
        ' 
        ' ContentRepMemRep
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        BackgroundImageLayout = ImageLayout.None
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MinimumSize = New Size(675, 496)
        Name = "ContentRepMemRep"
        Padding = New Padding(15)
        Size = New Size(1089, 496)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnApplyBatchSize As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBatchSize As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnRevenue As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnMembership As Button
    Friend WithEvents btnEquipment As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label

End Class
