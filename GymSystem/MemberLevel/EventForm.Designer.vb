<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventForm
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
        BtnSave = New Button()
        BtnClose = New Button()
        lblFormAddEvent = New Label()
        txtEventTitle = New Label()
        txtInstructor = New Label()
        SuspendLayout()
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(94, 222)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(82, 30)
        BtnSave.TabIndex = 0
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' BtnClose
        ' 
        BtnClose.Location = New Point(212, 222)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(82, 30)
        BtnClose.TabIndex = 0
        BtnClose.Text = "Close"
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' lblFormAddEvent
        ' 
        lblFormAddEvent.AutoSize = True
        lblFormAddEvent.Location = New Point(162, 26)
        lblFormAddEvent.Name = "lblFormAddEvent"
        lblFormAddEvent.Size = New Size(53, 20)
        lblFormAddEvent.TabIndex = 1
        lblFormAddEvent.Text = "Label1"
        ' 
        ' txtEventTitle
        ' 
        txtEventTitle.AutoSize = True
        txtEventTitle.Location = New Point(241, 26)
        txtEventTitle.Name = "txtEventTitle"
        txtEventTitle.Size = New Size(53, 20)
        txtEventTitle.TabIndex = 1
        txtEventTitle.Text = "Label1"
        ' 
        ' txtInstructor
        ' 
        txtInstructor.AutoSize = True
        txtInstructor.Location = New Point(78, 26)
        txtInstructor.Name = "txtInstructor"
        txtInstructor.Size = New Size(53, 20)
        txtInstructor.TabIndex = 1
        txtInstructor.Text = "Label1"
        ' 
        ' EventForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(txtEventTitle)
        Controls.Add(txtInstructor)
        Controls.Add(lblFormAddEvent)
        Controls.Add(BtnClose)
        Controls.Add(BtnSave)
        Name = "EventForm"
        Size = New Size(409, 327)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents lblFormAddEvent As Label
    Friend WithEvents txtEventTitle As Label
    Friend WithEvents txtInstructor As Label

End Class
