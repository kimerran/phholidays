Public Class HolidaysViewModel

    Public Property HolidayList As New List(Of Holiday)

    Public Sub New()

        Dim listOfHoliday As New List(Of Holiday) From {
            New Holiday With
            {
                .Name = "National Heroes Day",
                .DateDate = #8/26/2013#,
                .DayOfWeek = "Monday"
            },
            New Holiday With
            {
                .Name = "Christmas Day",
                .DateDate = #12/25/2013#,
                .DayOfWeek = "Saturday"
            },
             New Holiday With
            {
                .Name = "National Heroes Day 2",
                .DateDate = #8/26/2013#,
                .DayOfWeek = "Monday"
            },
             New Holiday With
            {
                .Name = "National Heroes Day 3",
                .DateDate = #8/26/2013#,
                .DayOfWeek = "Saturday"
            }
        }

        HolidayList = listOfHoliday

    End Sub

End Class
