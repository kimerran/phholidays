Imports System.Runtime.CompilerServices

Public Enum HolidayType
    RegularHoliday
    NonWorkingHoliday
    HolidayForAllSchools
End Enum

Module HolidayTypeExtensions
    <Extension()> _
    Public Function ToString(holidayType As HolidayType) As String
        Select Case holidayType
            Case WPPhilippineHolidays.HolidayType.RegularHoliday
                Return "Regular Holiday"
            Case WPPhilippineHolidays.HolidayType.NonWorkingHoliday
                Return "Non-working Holiday"
            Case WPPhilippineHolidays.HolidayType.HolidayForAllSchools
                Return "Holiday for all schools"
            Case Else
                Return ""
        End Select
    End Function
End Module



