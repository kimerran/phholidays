Imports System
Imports System.Threading
Imports System.Windows.Controls
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell
Imports System.Windows.Media
Partial Public Class MainPage
    Inherits PhoneApplicationPage

    Dim mainVM As New MainViewModel()

    ' Constructor
    Public Sub New()
	
        InitializeComponent()
				
        ' Set the data context
        DataContext = mainVM


     

    End Sub

    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)

        Dim v As Visibility = App.Current.Resources("PhoneLightThemeVisibility")

        If v = System.Windows.Visibility.Visible Then
            panoMain.Background = New SolidColorBrush(Media.Colors.White)
        Else
            panoMain.Background = New SolidColorBrush(Media.Colors.Black)
        End If

		' Load the List of Holiday to the main Panorama control
        panoMain.ItemsSource = mainVM.List

        ' Store NavigationService to be used inside app
        If Application.Current.Resources("NavigationService") Is Nothing Then
            Application.Current.Resources.Add("NavigationService", Me.NavigationService)
        End If


		' Go to current month, unless user just pressed Back button
        If Not e.NavigationMode = NavigationMode.Back Then

            panoMain.DefaultItem = panoMain.Items(DateTime.Now.Month - 1)

        End If

    End Sub



    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        Dim ns As NavigationService = Application.Current.Resources("NavigationService")

        ns.Navigate(New Uri("/Pages/About.xaml", UriKind.Relative))
    End Sub
End Class