<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contentothers
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
        TableLayoutPanel1 = New TableLayoutPanel()
        addnewAdminBtn = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Controls.Add(addnewAdminBtn, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Left
        TableLayoutPanel1.Location = New Point(20, 20)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.32967F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 89.67033F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.Size = New Size(632, 456)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' addnewAdminBtn
        ' 
        addnewAdminBtn.AutoSize = True
        addnewAdminBtn.Cursor = Cursors.Hand
        addnewAdminBtn.Dock = DockStyle.Left
        addnewAdminBtn.FlatStyle = FlatStyle.Flat
        addnewAdminBtn.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addnewAdminBtn.ForeColor = SystemColors.ButtonHighlight
        addnewAdminBtn.Image = My.Resources.Resources.User_plus
        addnewAdminBtn.ImageAlign = ContentAlignment.MiddleLeft
        addnewAdminBtn.Location = New Point(4, 1)
        addnewAdminBtn.Name = "addnewAdminBtn"
        addnewAdminBtn.Padding = New Padding(12)
        addnewAdminBtn.Size = New Size(184, 46)
        addnewAdminBtn.TabIndex = 1
        addnewAdminBtn.Text = "                     Add New Admin"
        addnewAdminBtn.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Contentothers
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(TableLayoutPanel1)
        MinimumSize = New Size(675, 496)
        Name = "Contentothers"
        Padding = New Padding(20)
        Size = New Size(675, 496)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents addnewAdminBtn As Label

End Class
