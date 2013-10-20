Imports Microsoft.Phone.Tasks
Partial Public Class About
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnVisitWebsite_Click(sender As Object, e As RoutedEventArgs) Handles btnVisitWebsite.Click
        Dim webBrowserTask As WebBrowserTask = New WebBrowserTask()

        webBrowserTask.Uri = New Uri("http://markhughneri.com", UriKind.Absolute)

        webBrowserTask.Show()
    End Sub
End Class
