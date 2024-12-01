Imports Mysqlx.Session

Public Class AdminMain
    Inherits UserControl

    Private activeButton As Button = Nothing

    Private Sub AdminMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize buttons using the reusable function
        InitializeButton(DashboardBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.dashboard, My.Resources.dashbo, activeButton)
        InitializeButton(MemManBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.tdesign_member_1, My.Resources.tdesign_member, activeButton)
        InitializeButton(AttendanceBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.blkatt, My.Resources.Vector1, activeButton)
        InitializeButton(MemProgBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.blkmemprog, My.Resources.Group_241, activeButton)
        InitializeButton(MemStatBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.blkmemstat, My.Resources.Vector4, activeButton)
        InitializeButton(PaymentsBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.blkpa, My.Resources.Vector_4, activeButton)
        InitializeButton(AnnouncementBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.blkan, My.Resources.Vector_5, activeButton)
        InitializeButton(StaffMngmtBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.blkstaffman, My.Resources.Group_26, activeButton)
        InitializeButton(GymEquipmentBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.blkgymeqp, My.Resources.Vector2, activeButton)
        InitializeButton(ReportsBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.blkreps, My.Resources.Vector3, activeButton)
        InitializeButton(othersBtn, Color.Yellow, Color.Yellow, Color.White, Color.Black, My.Resources.Cog, My.Resources.Cog1, activeButton)

        ' Initialize submenu buttons
        InitializeSubMenuButton(ListAllMembersBtn, Color.Yellow, Color.White, activeSubMenuButton)
        InitializeSubMenuButton(MemEntryFormBtn, Color.Yellow, Color.White, activeSubMenuButton)
        InitializeSubMenuButton(AttenChckNBtn, Color.Yellow, Color.White, activeSubMenuButton)

        'autoscroll
        AddHandler Me.Resize, AddressOf Form1_Resize

        'submen
        ' Initializing visibility
        MemManSubMenu.Visible = False
        AttendanceSubMenu.Visible = False
        GymEqpSubMenu.Visible = False
        ReportsSubMenu.Visible = False

        ' Attach click event handlers for main buttons
        AddHandler MemManBtn.Click, AddressOf MemManBtn_Click
        AddHandler AttendanceBtn.Click, AddressOf AttendanceBtn_Click
        AddHandler GymEquipmentBtn.Click, AddressOf GymEquipmentBtn_Click
        AddHandler ReportsBtn.Click, AddressOf ReportsBtn_Click
        AddHandler DashboardBtn.Click, AddressOf DashboardBtn_Click
        AddHandler MemProgBtn.Click, AddressOf MemProgBtn_Click
        AddHandler MemStatBtn.Click, AddressOf MemStatBtn_Click
        AddHandler PaymentsBtn.Click, AddressOf PaymentsBtn_Click
        AddHandler AnnouncementBtn.Click, AddressOf AnnouncementBtn_Click
        AddHandler StaffMngmtBtn.Click, AddressOf StaffMngmtBtn_Click
        AddHandler othersBtn.Click, AddressOf othersBtn_Click

        ' Attach click event handlers for submenu buttons
        AddHandler ListAllMembersBtn.Click, AddressOf SubMenu_Click
        AddHandler MemEntryFormBtn.Click, AddressOf SubMenu_Click
        AddHandler AttenChckNBtn.Click, AddressOf SubMenu_Click

        ' Reports
        AddHandler ChartsBtn.Click, AddressOf SubMenu_Click
        AddHandler MemRepBtn.Click, AddressOf SubMenu_Click
        AddHandler MemProgRepBtn.Click, AddressOf SubMenu_Click
    End Sub

    Public Sub ConfigureMenu(role As String)
        If role = "Normal Admin" Then
            ' Hide the last menu button for normal admins
            othersBtn.Visible = False
        ElseIf role = "Super Admin" Then
            MemManBtn.Visible = True
            AttendanceBtn.Visible = True
            GymEquipmentBtn.Visible = True
            ReportsBtn.Visible = True
            DashboardBtn.Visible = True
            MemProgBtn.Visible = True
            MemStatBtn.Visible = True
            AnnouncementBtn.Visible = True
            StaffMngmtBtn.Visible = True
        End If
    End Sub

    Private Sub InitializeButton(button As Button, activeBackColor As Color, hoverBackColor As Color, initialForeColor As Color, hoverForeColor As Color, activeImage As Image, normalImage As Image, ByRef activeButton As Button)
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.BackColor = If(button.Equals(activeButton), activeBackColor, Color.Black)
        button.ForeColor = If(button.Equals(activeButton), hoverForeColor, initialForeColor)
        button.Image = If(button.Equals(activeButton), activeImage, normalImage)
        button.ImageAlign = ContentAlignment.MiddleLeft
        button.TextAlign = ContentAlignment.MiddleRight
        button.Padding = New Padding(10, 0, 0, 0)

        ' Store images in tag to identify each button
        button.Tag = New ButtonImages() With {
        .ActiveImage = activeImage,
        .NormalImage = normalImage
    }

        ' Add hover event handlers
        AddHandler button.MouseEnter, AddressOf Button_MouseEnter
        AddHandler button.MouseLeave, AddressOf Button_MouseLeave
        AddHandler button.Click, AddressOf Button_Click
    End Sub

    Private Sub InitializeSubMenuButton(button As Button, activeForeColor As Color, initialForeColor As Color, ByRef activeSubMenuButton As Button)
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.ForeColor = If(button.Equals(activeSubMenuButton), activeForeColor, initialForeColor)
        button.TextAlign = ContentAlignment.MiddleCenter
        button.Padding = New Padding(60, 0, 0, 0)
    End Sub


    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim images = CType(btn.Tag, ButtonImages)
        btn.BackColor = Color.Yellow
        btn.ForeColor = Color.Black
        btn.Image = images.ActiveImage
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim images = CType(btn.Tag, ButtonImages)
        If Not btn.Equals(activeButton) Then
            btn.BackColor = Color.Black
            btn.ForeColor = Color.White
            btn.Image = images.NormalImage
        Else
            btn.BackColor = Color.Yellow
            btn.ForeColor = Color.Black
            btn.Image = images.ActiveImage
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim images = CType(btn.Tag, ButtonImages)
        If Not btn.Equals(activeButton) Then
            ' Reset previous active button
            If activeButton IsNot Nothing Then
                Dim activeImages = CType(activeButton.Tag, ButtonImages)
                activeButton.BackColor = Color.Black
                activeButton.ForeColor = Color.White
                activeButton.Image = activeImages.NormalImage
            End If
            ' Set the new active button
            activeButton = btn
            btn.BackColor = Color.Yellow
            btn.ForeColor = Color.Black
            btn.Image = images.ActiveImage
        End If
    End Sub

    Private Sub SubMenu_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        SetActiveSubMenuButton(btn)
        ' Show the corresponding user control based on the button clicked
        Select Case btn.Name
            Case "ListAllMembersBtn"
                ShowUserControl(New ContentMemberManagement1(ContentPnl)) ' Replace with the user control you want to show
            Case "MemEntryFormBtn"
                ShowUserControl(New ContentMemEntryForm()) ' Replace with the user control you want to show
            Case "ChartsBtn"
                ShowUserControl(New ContentReports()) ' Replace with the user control you want to show
            Case "AttenChckNBtn"
                ShowUserControl(New ContentAttendance())
        End Select
    End Sub


    Private activeSubMenuButton As Button = Nothing

    Private Sub SetActiveSubMenuButton(button As Button)
        If activeSubMenuButton IsNot Nothing Then
            activeSubMenuButton.ForeColor = Color.White ' Reset previous active button color
        End If
        activeSubMenuButton = button
        button.ForeColor = Color.Yellow ' Set new active button color
    End Sub

    Public Sub ShowUserControl(control As UserControl)
        control.Dock = DockStyle.Fill
        ContentPnl.Controls.Clear()
        ContentPnl.Controls.Add(control)
        control.BringToFront()
    End Sub

    ' Helper class to store images
    Private Class ButtonImages
        Public Property ActiveImage As Image
        Public Property NormalImage As Image
    End Class

    Public Sub News()
        InitializeComponent()
        ' Add the Resize event handler
        AddHandler Me.Resize, AddressOf Me.Member_Resize
    End Sub

    Private Sub Member_Resize(sender As Object, e As EventArgs)
        UserPnl.Invalidate() ' Force the panel to redraw
    End Sub



    Private Sub MenuPnl_Paint(sender As Object, e As PaintEventArgs)
        Dim color1 = Color.FromArgb(26, 26, 26, 1)
        ' Additional painting logic for MenuPnl
    End Sub

    'autoscroll

    Private Sub ToggleAutoScrollBasedOnHeight(panel As Panel, minHeight As Integer)
        If Me.Height <= minHeight Then
            panel.AutoScroll = True
        Else
            panel.AutoScroll = False
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs)
        ' Adjust the height as needed
        ToggleAutoScrollBasedOnHeight(Menu2Pnl, 700)
    End Sub

    'sub menu
    Private Sub ToggleSubMenu(mainButton As Button, subMenuPanel As Panel)
        ' Hide all submenus
        MemManSubMenu.Visible = False
        AttendanceSubMenu.Visible = False
        GymEqpSubMenu.Visible = False
        ReportsSubMenu.Visible = False
        ' Show the clicked submenu if it has one
        If subMenuPanel IsNot Nothing Then
            subMenuPanel.Visible = True
        End If
    End Sub

    Private Sub ShowMemberProfile(memberData As MemberData)
        Dim memberProfileControl As New memberProfileControl()
        memberProfileControl.LoadMemberData(memberData)
        ShowUserControl(memberProfileControl)
    End Sub


    Private Sub MemManBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(MemManBtn, MemManSubMenu)
        SetActiveSubMenuButton(ListAllMembersBtn)
        Dim membersTableControl As New ContentMemberManagement1(ContentPnl)
        AddHandler membersTableControl.ViewMemberProfile, AddressOf ShowMemberProfile
        ShowUserControl(membersTableControl)
    End Sub

    Private Sub AttendanceBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(AttendanceBtn, AttendanceSubMenu)
    End Sub

    Private Sub GymEquipmentBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(GymEquipmentBtn, GymEqpSubMenu)
    End Sub

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(ReportsBtn, ReportsSubMenu)
        SetActiveSubMenuButton(ChartsBtn)
        ShowUserControl(New ContentReports())
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(DashboardBtn, Nothing)
        ' Clear existing controls in ContentPnl
        ContentPnl.Controls.Clear()

        ' Create an instance of ContentDashboard UserControl
        Dim dashboard As New ContentDashboard()

        ' Set the UserControl to fill the ContentPnl
        dashboard.Dock = DockStyle.Fill

        ' Add the UserControl to ContentPnl
        ContentPnl.Controls.Add(dashboard)
    End Sub

    Private Sub MemProgBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(DashboardBtn, Nothing)
    End Sub

    Private Sub MemStatBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(DashboardBtn, Nothing)
    End Sub

    Private Sub PaymentsBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(DashboardBtn, Nothing)
    End Sub

    Private Sub AnnouncementBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(DashboardBtn, Nothing)
    End Sub

    Private Sub StaffMngmtBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(DashboardBtn, Nothing)
    End Sub

    Private Sub othersBtn_Click(sender As Object, e As EventArgs)
        ToggleSubMenu(DashboardBtn, Nothing)
        ShowUserControl(New Contentothers)
    End Sub


    Private Sub AddEqpBtn_Click(sender As Object, e As EventArgs)
        ShowUserControl(New Gym_Equipment)
    End Sub


    'logout


    Private Sub UserPnl_Paint_1(sender As Object, e As PaintEventArgs) Handles UserPnl.Paint
        Dim color1 = Color.FromArgb(26, 26, 26, 1)
        Dim color2 = Color.LightGray
        ' Define the rectangle for the gradient
        Dim rect As New Rectangle(0, 0, UserPnl.Width * 5, UserPnl.Height)

        ' Create the linear gradient brush
        Using gradientBrush As New Drawing2D.LinearGradientBrush(rect, color1, color2, 10.0F)
            ' Fill the panel background with the gradient
            e.Graphics.FillRectangle(gradientBrush, rect)
        End Using
    End Sub

    'logout
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        ' Display confirmation dialog
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close the parent form to ensure AdminMain UserControl is closed
            Dim parentForm = FindForm()

            If parentForm IsNot Nothing Then
                parentForm.Close()
            End If

            ' Navigate back to Admin login form
            Dim backtoAdminLogin As New Admin
            backtoAdminLogin.Show()
        End If
    End Sub

    Private Sub MemEntryFormBtn_Click(sender As Object, e As EventArgs) Handles MemEntryFormBtn.Click
    End Sub


    Private Sub ReportsBtn_Click_1(sender As Object, e As EventArgs)
        ShowUserControl(New ContentReports)
    End Sub

    Private Sub MemRepBtn_Click(sender As Object, e As EventArgs)
        ShowUserControl(New ContentRepMemRep)
    End Sub

    Private Sub StaffMngmtBtn_Click_1(sender As Object, e As EventArgs)
        ShowUserControl(New ContentStaffManage)
    End Sub

    Public Sub AttenChckNBtn_Click(sender As Object, e As EventArgs) Handles AttenChckNBtn.Click
        SetActiveSubMenuButton(AttenChckNBtn)
        ShowUserControl(New ContentAttendance())
    End Sub

    Private Sub AttendanceBtn_Click_1(sender As Object, e As EventArgs) Handles AttendanceBtn.Click
        SetActiveSubMenuButton(AttenChckNBtn)
        ShowUserControl(New ContentAttendance())
    End Sub

    Private Sub PaymentsBtn_Click_1(sender As Object, e As EventArgs) Handles PaymentsBtn.Click
        ShowUserControl(New ContentPayment)
    End Sub

    Private Sub MemProgRepBtn_Click(sender As Object, e As EventArgs) Handles MemProgRepBtn.Click
        ShowUserControl(New ContentRepMemRep())
    End Sub
End Class
