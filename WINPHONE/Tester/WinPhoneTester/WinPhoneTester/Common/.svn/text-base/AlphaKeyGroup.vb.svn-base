Imports Microsoft.Phone.Globalization
Imports System.Globalization

Public Class AlphaKeyGroup(Of T)
    Inherits List(Of T)
    ''' <summary>
    ''' The delegate that is used to get the key information.
    ''' </summary>
    ''' <param name="item">An object of type T</param>
    ''' <returns>The key value to use for this object</returns>
    Public Delegate Function GetKeyDelegate(item As T) As String

    ''' <summary>
    ''' The Key of this group.
    ''' </summary>
    Public Property Key() As String
        Get
            Return m_Key
        End Get
        Private Set(value As String)
            m_Key = value
        End Set
    End Property
    Private m_Key As String

    ''' <summary>
    ''' Public constructor.
    ''' </summary>
    ''' <param name="key">The key for this group.</param>
    Public Sub New(key__1 As String)
        Key = key__1
    End Sub

    ''' <summary>
    ''' Create a list of AlphaGroup<T> with keys set by a SortedLocaleGrouping.
    ''' </summary>
    ''' <param name="slg">The </param>
    ''' <returns>Theitems source for a LongListSelector</returns>
    Private Shared Function CreateGroups(slg As SortedLocaleGrouping) As List(Of AlphaKeyGroup(Of T))
        Dim list As New List(Of AlphaKeyGroup(Of T))()

        For Each key As String In slg.GroupDisplayNames
            list.Add(New AlphaKeyGroup(Of T)(key))
        Next

        Return list
    End Function

    ''' <summary>
    ''' Create a list of AlphaGroup<T> with keys set by a SortedLocaleGrouping.
    ''' </summary>
    ''' <param name="items">The items to place in the groups.</param>
    ''' <param name="ci">The CultureInfo to group and sort by.</param>
    ''' <param name="getKey">A delegate to get the key from an item.</param>
    ''' <param name="sort">Will sort the data if true.</param>
    ''' <returns>An items source for a LongListSelector</returns>
    Public Shared Function CreateGroups(items As IEnumerable(Of T), ci As CultureInfo, getKey As GetKeyDelegate, sort As Boolean) As List(Of AlphaKeyGroup(Of T))
        Dim slg As New SortedLocaleGrouping(ci)
        Dim list As List(Of AlphaKeyGroup(Of T)) = CreateGroups(slg)

        For Each item As T In items
            Dim index As Integer = 0
            'check if your database has yomi string for item
            'if it does not, then do you want to generate Yomi or ask the user for this item.
            'index = slg.GetGroupIndex(getKey(Yomiof(item)));
            If slg.SupportsPhonetics Then
            Else
                index = slg.GetGroupIndex(getKey(item))
            End If
            If index >= 0 AndAlso index < list.Count Then
                list(index).Add(item)
            End If
        Next

        If sort Then
            For Each group As AlphaKeyGroup(Of T) In list
                group.Sort((Function(c0, c1)
                                Return ci.CompareInfo.Compare(getKey(c0), getKey(c1))
                            End Function))
            Next
        End If

        Return list
    End Function

    '    Public Function(c0 As Object, c1 As Object) 


End Class
