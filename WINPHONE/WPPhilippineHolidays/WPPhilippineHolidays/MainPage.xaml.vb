Imports System
Imports System.Threading
Imports System.Windows.Controls
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell

Partial Public Class MainPage
    Inherits PhoneApplicationPage

    Dim mainVM As New MainViewModel()

    ' Constructor
    Public Sub New()
	
        InitializeComponent()
		
		' Store NavigationService to be used inside app
		If Application.Current.Resources("NavigationService") Is Nothing Then
            Application.Current.Resources.Add("NavigationService", Me.NavigationService)
        End If
		
        ' Set the data context
        DataContext = mainVM

    End Sub

    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)

		' Load the List of Holiday to the main Panorama control
        panoMain.ItemsSource = mainVM.List

		' Go to current month, unless user just pressed Back button
        If Not e.NavigationMode = NavigationMode.Back Then

            panoMain.DefaultItem = panoMain.Items(DateTime.Now.Month - 1)

        End If

    End Sub



End Class