Imports System.Collections.ObjectModel

''' <summary>
''' Creates a long list selector of holidays according to the month
''' </summary>
''' <remarks></remarks>
Public Class HolidayListPerMonth

    Inherits LongListSelector

    Public Sub New(MonthNumber As Integer)


        ' Sets the template for the list
        Me.ItemTemplate = App.Current.Resources("HolidayItemTemplate")
        Me.IsFlatList = True

        ' Gets list of holiday according the the month
        Me.ItemsSource = _GetDataByMonthNumber(MonthNumber)

		' Add handler to the SelectionChanged event
        AddHandler Me.SelectionChanged, AddressOf _actionNavigatetoDetails

    End Sub

	''' <summary>
	''' Queries the App.Db.Holidays for all holidays for the given monthNumber
	''' </summary>		
    Private Function _GetDataByMonthNumber(monthNumber As Integer) As ObservableCollection(Of Holiday)

        Dim ocHolidays As New ObservableCollection(Of Holiday)

        Dim lstHolidays = (From h In App.Db.Holidays Where h.DateMonth = monthNumber Select h).ToList

        For Each i In lstHolidays
            ocHolidays.Add(i)
        Next

        Return ocHolidays

    End Function

	''' <summary>
	''' Handles SelectionChanged event of this LongListSelector
	''' Note that SelectedItem is emptied so user can re-select the same item again
	''' after pressing back button
	''' </summary>	
    Private Sub _actionNavigatetoDetails(sender As Object, e As SelectionChangedEventArgs)

        Dim x As LongListSelector = sender

        Dim selectedItem As Holiday = x.SelectedItem

        If selectedItem IsNot Nothing Then

            Dim ns As NavigationService = Application.Current.Resources("NavigationService")

            ns.Navigate(New Uri("/Pages/Details.xaml?id=" & selectedItem.Id, UriKind.Relative))

            x.SelectedItem = Nothing

        End If

      

    End Sub
   

End Class
