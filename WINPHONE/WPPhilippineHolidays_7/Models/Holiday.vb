Imports System.ComponentModel
Imports System.Text

''' <summary>
''' Represents a holiday and properties
''' </summary>
Public Class Holiday

    Public Property Name As String
    Public Property DateInfo As Date
    Public Property HolidayType As HolidayType
    Public Property DateMonth As Integer
    Public Property DateDay As Integer
    Public Property DateYear As Integer
    Public Property Id As Integer
    Public Property Description As String
    Public Property Img As String

    ' This is used for auto-generation of Id property
    Private Shared MyId As Integer = 0

	' Just added a comment here to test on github
    Public Sub New(ByVal holidayDate As Date,
                     ByVal holidayName As String,
                     ByVal holidayDescription As String,
                     ByVal holidayType As HolidayType,
                     ByVal holidayImg As String)

        'Increment auto-Id
        Holiday.MyId += 1

        Me.Id = Holiday.MyId
        Me.Name = holidayName
        Me.Description = holidayDescription
        Me.DateInfo = holidayDate
        Me.DateMonth = holidayDate.Month
        Me.DateDay = holidayDate.Day
        Me.DateYear = holidayDate.Year


        Dim imgSrc As New StringBuilder
        imgSrc.Append("/WPPhilippineHolidays_7;component/Assets/HolidayImg/")
        imgSrc.Append(holidayImg)
        imgSrc.Append(".JPG")

        Me.Img = imgSrc.ToString

    End Sub


End Class
