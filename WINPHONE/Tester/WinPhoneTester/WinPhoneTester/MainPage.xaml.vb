Imports System
Imports System.Threading
Imports System.Windows.Controls
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell

Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()

        SupportedOrientations = SupportedPageOrientation.Portrait Or SupportedPageOrientation.Landscape

        ' Sample code to localize the ApplicationBar
        'BuildLocalizedApplicationBar()

        Dim holidayVM = New HolidaysViewModel

        'Dim DataSource As List(Of AlphaKeyGroup(Of Holiday)) = AlphaKeyGroup(Of Holiday).CreateGroups(holidayVM.HolidayList,
        '                                                                                              System.Threading.Thread.CurrentThread.CurrentUICulture,
        '                                                                                              Function(s As Holiday)
        '                                                                                                  Return s.DayOfWeek
        '                                                                                              End Function,
        '                                                                                              True)

        Dim DataSource As List(Of Holiday)
        DataSource = From h In holidayVM.HolidayList
                     Group h By h.DayOfWeek Into  Function(c) c.Title
                     

        llHolidays.ItemsSource = DataSource

    End Sub

    Public Shared Function GetItemGroups(Of T)(itemList As IEnumerable(Of T), getKeyFunc As Func(Of T, String)) As List(Of Group(Of T))

        Dim groupList As IEnumerable(Of Group(Of T)) = From g In From item In itemList
                                                                 Group item By getKeyFunc(item) Into g()
                                                                 Order By g.Key
                                                                 Select New Group(Of T)(g.Key, g)

        Return groupList.ToList()

    End Function

    ' Sample code for building a localized ApplicationBar
    'Private Sub BuildLocalizedApplicationBar()
    '    ' Set the page's ApplicationBar to a new instance of ApplicationBar.
    '    ApplicationBar = New ApplicationBar()

    '    ' Create a new button and set the text value to the localized string from AppResources.
    '    Dim appBarButton As New ApplicationBarIconButton(New Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative))
    '    appBarButton.Text = AppResources.AppBarButtonText
    '    ApplicationBar.Buttons.Add(appBarButton)

    '    ' Create a new menu item with the localized string from AppResources.
    '    Dim appBarMenuItem As New ApplicationBarMenuItem(AppResources.AppBarMenuItemText)
    '    ApplicationBar.MenuItems.Add(appBarMenuItem)
    'End Sub

End Class


Public Class Group(Of T)
    Inherits List(Of T)


    Public Sub New(name As String, items As IEnumerable(Of T))

        MyBase.New(items)



        Me.Title = name
    End Sub

    Public Property Title() As String


        Get
            Return m_Title
        End Get

        Set(value As String)
            m_Title = Value
        End Set
    End Property
    Private m_Title As String


End Class