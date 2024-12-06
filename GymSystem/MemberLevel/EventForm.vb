Partial Class EventForm
    ' Event declaration for when an event is saved
    Public Event EventSaved(newEvent As Sched.CalendarEvent)

    ' Event date storage
    Private _eventDate As DateTime

    Public Property EventDate As DateTime
        Get
            Return _eventDate
        End Get
        Set(value As DateTime)
            _eventDate = value
        End Set
    End Property

    Public Sub New(selectedDate As DateTime)
        InitializeComponent()
        EventDate = selectedDate
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(200, 40, 40, 40)
        lblFormAddEvent.Text = $"Add Event for {selectedDate:d}"

        ' Add event handlers
        AddHandler btnSave.Click, AddressOf SaveEvent
        AddHandler btnClose.Click, AddressOf CloseForm
    End Sub

    Private Sub SaveEvent(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtEventTitle.Text) Then
            MessageBox.Show("Please enter an event title", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Create new event
        Dim newEvent As New Sched.CalendarEvent With {
            .EventDate = EventDate,
            .Title = txtEventTitle.Text,
            .Instructor = txtInstructor.Text
        }

        ' Raise the event
        RaiseEvent EventSaved(newEvent)

        ' Close the form
        Parent.Controls.Remove(Me)
    End Sub

    Private Sub CloseForm(sender As Object, e As EventArgs)
        Parent.Controls.Remove(Me)
    End Sub
End Class