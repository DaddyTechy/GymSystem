<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentReports
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Chart1 = New DataVisualization.Charting.Chart()
        Label3 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        TermsChart = New DataVisualization.Charting.Chart()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(TermsChart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoScroll = True
        Panel1.AutoScrollMargin = New Size(0, 50)
        Panel1.AutoScrollMinSize = New Size(0, 50)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 3, 3, 50)
        Panel1.MinimumSize = New Size(675, 496)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(0, 0, 0, 50)
        Panel1.Size = New Size(675, 496)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Panel3.Controls.Add(Chart1)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(27, 341)
        Panel3.Margin = New Padding(3, 3, 3, 50)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 0, 0, 50)
        Panel3.Size = New Size(605, 228)
        Panel3.TabIndex = 3
        ' 
        ' Chart1
        ' 
        Chart1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Chart1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(87, 44)
        Chart1.Name = "Chart1"
        Chart1.Palette = DataVisualization.Charting.ChartColorPalette.Fire
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Color = Color.White
        Series1.LabelForeColor = Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "GenderOverview"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(414, 181)
        Chart1.TabIndex = 1
        Chart1.Text = "Chart1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLight
        Label3.Location = New Point(13, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(275, 15)
        Label3.TabIndex = 0
        Label3.Text = "Registered Gym Members by Gender: Overview"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(TermsChart)
        Panel2.Location = New Point(27, 93)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(605, 216)
        Panel2.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(13, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 15)
        Label4.TabIndex = 1
        Label4.Text = "Earning and Expenses Report"
        ' 
        ' TermsChart
        ' 
        TermsChart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TermsChart.BackColor = Color.Gray
        ChartArea2.Name = "ChartArea1"
        TermsChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        TermsChart.Legends.Add(Legend2)
        TermsChart.Location = New Point(13, 42)
        TermsChart.Name = "TermsChart"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Series2.Color = Color.Gold
        Series2.LabelBackColor = Color.Black
        Series2.LabelForeColor = Color.Snow
        Series2.Legend = "Legend1"
        Series2.Name = "Terms"
        TermsChart.Series.Add(Series2)
        TermsChart.Size = New Size(573, 149)
        TermsChart.TabIndex = 0
        TermsChart.Text = "Chart1"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(27, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(348, 32)
        Label2.TabIndex = 1
        Label2.Text = "Earning and Expenses Report"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(16, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 20)
        Label1.TabIndex = 0
        Label1.Text = "Chart Representation"
        ' 
        ' ContentReports
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        Controls.Add(Panel1)
        MinimumSize = New Size(675, 496)
        Name = "ContentReports"
        Size = New Size(675, 496)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(TermsChart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TermsChart As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label

End Class
