Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.FrameworkElement

Public Class MainViewModel

	''' <summary>
    ''' This list will serve as the ItemsSource for the Panorama Control
	''' Contains a list of panorama items
    ''' </summary>
    Public Property List As New ObservableCollection(Of PanoramaItem)
	
	''' <summary>
    ''' 
    ''' </summary>
    Public Sub New()

		Load_List()

    End Sub

	''' <summary>
	''' Populate List property with instances of HolidayMonth from Jan-Dec
	''' </summary>
	Private Sub Load_List()
	
        For i = 1 To 12
            List.Add(New HolidayMonth(i))
        Next	
	
	End Sub
   
End Class
