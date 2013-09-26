Imports Microsoft.Phone.Tasks

''' <summary>
''' Details Page.
''' Opens when a holiday item is clicked
''' </summary>
Partial Public Class Details
    Inherits PhoneApplicationPage

    Public Sub New()
	
        InitializeComponent()

    End Sub

	''' <summary>
	''' Loads up specific data for the holiday item
	''' </summary>
    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
	
        Dim holidayId = NavigationContext.QueryString("id")

        Me.DataContext = (From h In App.Db.Holidays
                         Where h.Id = holidayId
                         Select h).Single

    End Sub

	''' <summary>
	''' Creates a new Calendar appointment for the holiday
	''' </summary>
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        Dim newAppointment As New SaveAppointmentTask

        Dim h As Holiday = Me.DataContext

        With newAppointment		
            .Subject = h.Name
            .StartTime = New DateTime(h.DateYear, h.DateMonth, h.DateDay, 0, 0, 0)
            .IsAllDayEvent = True
            .Details = h.Description
        End With

        newAppointment.Show()

    End Sub
	
End Class
