Imports System.Globalization
Imports System.Collections.ObjectModel

''' <summary>
''' Represents a panorama item containing a long list selector
''' </summary>
Public Class HolidayMonth
    Inherits PanoramaItem

    Public Sub New(MonthNumber As Integer)

        'Set the header (Month Name)
        If MonthNumber <= 12 Then

            Me.Header = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(MonthNumber)

        Else

            Me.Header = MonthNumber

        End If

        'Creates the long list selector containing the Holiday items
        Dim newHolidayListPerMonth = New HolidayListPerMonth(MonthNumber)

        If CType(newHolidayListPerMonth.ItemsSource, ObservableCollection(Of Holiday)).Count = 0 Then

            Me.Content = New TextBlock With {.Text = "No holiday for this month "}

        Else

            Me.Content = newHolidayListPerMonth 'Long list selector
           

        End If

    End Sub

End Class
