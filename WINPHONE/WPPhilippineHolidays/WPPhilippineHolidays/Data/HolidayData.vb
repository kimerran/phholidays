Imports System.Collections.ObjectModel

Public Class HolidayData

    Public Property Holidays As ObservableCollection(Of Holiday)

    
    Public Sub New()

        Holidays = New ObservableCollection(Of Holiday)

        Load_Holidays()

    End Sub

    ''' <summary>
    ''' Credits to http://en.wikipedia.org/wiki/Public_holidays_in_the_Philippines
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Load_Holidays()

        'January
        Holidays.Add(New Holiday(#1/1/2013#,
                                 "New Year's Day",
                                 "New Year's Day is observed on January 1st, the first day of the year on the modern Gregorian calendar as well as the Julian calendar used in the Roman Empire.",
                                 HolidayType.RegularHoliday,
                                 ""))
        'February
        Holidays.Add(New Holiday(#2/25/2013#,
                                 "EDSA Revolution Anniversary",
                                 "A special non-working holiday in recent years to celebrate the People Power Revolution, it hasn't been made a regular yearly holiday. It is a special holiday only for schools, either private or public schools since 2010.",
                                 HolidayType.HolidayForAllSchools,
                                 ""))
        'March
        Holidays.Add(New Holiday(#3/28/2013#,
                                 "Maundy Thursday",
                                 "Maundy Thursday is a day of the Holy Week (Tagalog: Mahal na Araw; Spanish: Semana Santa). This holy day commemorates the Last Supper of Jesus Christ with the Apostles.",
                                 HolidayType.RegularHoliday,
                                 ""))

        Holidays.Add(New Holiday(#3/29/2013#,
                                 "Good Friday",
                                 "Good Friday is a day of the Holy Week or Mahal na Araw. This holiday commemorates the crucifixion of Jesus Christ.",
                                 HolidayType.RegularHoliday,
                                 ""))

        Holidays.Add(New Holiday(#3/30/2013#,
                                 "Black Saturday",
                                 "Black Saturday is a day of the Holy Week or Mahal na Araw. It commemorates the laying of Jesus Christ's body in the tomb.",
                                 HolidayType.NonWorkingHoliday,
                                 ""))
        'April
        Holidays.Add(New Holiday(#4/9/2013#,
                                 "Araw ng Kagitingan",
                                 "Commemorates Fall of Bataan during Japanese invasion of the Philippines during World War II and by extension Fall of Corregidor, the Bataan Death March and the courage of the Filipino and American soldiers during World War II. In 2009, Araw ng Kagitingan fell on Maundy Thursday so it was moved to April 6.",
                                 HolidayType.RegularHoliday,
                                 ""))
        'May
        Holidays.Add(New Holiday(#5/1/2013#,
                                 "Labor Day",
                                 "Celebrates workers. The first Labour Day celebrations were held in the Philippines on May 1, 1903 in a mammoth rally in front of Malacañan Palace staged by the Union Obrera Democratica (Democratic Laborer's Union), while pressing for workers’ economic rights.",
                                 HolidayType.RegularHoliday,
                                 ""))

        Holidays.Add(New Holiday(#5/13/2013#,
                                 "Election Day",
                                 "Election Day of the 2013 Philippine general election.",
                                 HolidayType.NonWorkingHoliday,
                                 ""))
        'June
        Holidays.Add(New Holiday(#6/12/2013#,
                                 "Independence Day",
                                 "Celebrates the Philippine Declaration of Independence by Emilio Aguinaldo on June 12, 1898.",
                                 HolidayType.RegularHoliday,
                                 ""))
        'July

        'August
        Holidays.Add(New Holiday(#8/9/2013#,
                                 "Eid'l Fitr",
                                 "In the Philippines, Eid al-Fitr, known to the Christian majority and other non-Muslims as 'Wakás ng Ramadán' ('End of Ramadan') or incorrectly as 'Ramadan', has been recognised by the Philippine Government as a regular holiday.",
                                 HolidayType.RegularHoliday,
                                 ""))

        Holidays.Add(New Holiday(#8/21/2013#,
                                 "Ninoy Aquino Day",
                                 "Commemorates the assassination of former Sen. Ninoy Aquino in 1983.",
                                 HolidayType.NonWorkingHoliday,
                                 ""))

        Holidays.Add(New Holiday(#8/26/2013#,
                                 "National Heroes Day",
                                 "Commemorates all the nation's heroes throughout history. It is a regular holiday marking the 1896 Cry of Pugad Lawin by the Katipunan, led by its Supremo Andrés Bonifacio, which began the Philippine Revolution.",
                                 HolidayType.RegularHoliday,
                                 ""))

        'September

        'October

        'November
        Holidays.Add(New Holiday(#11/1/2013#,
                                 "All Saints Day",
                                 "Filipinos observed this day by visiting the graves of deceased relatives. It is also known as Undas, Todos los Santos and sometimes Araw ng mga Patay which is actually the next day.",
                                 HolidayType.NonWorkingHoliday,
                                 ""))

        Holidays.Add(New Holiday(#11/2/2013#,
                                 "Additional Special Non-working Day",
                                 "All Souls Day. People who didn't get to visit the tombs of their dead relatives go on this day.",
                                 HolidayType.NonWorkingHoliday,
                                 ""))

        Holidays.Add(New Holiday(#11/30/2013#,
                                 "Bonifacio Day",
                                 "Commemorates the birth of national hero Andrés Bonifacio on November 30, 1863. ",
                                 HolidayType.RegularHoliday,
                                 ""))

        'December
        Holidays.Add(New Holiday(#12/24/2013#,
                                 "Additional Special Non-working Day",
                                 "Christmas Eve. It is the day before Christmas.",
                                 HolidayType.NonWorkingHoliday,
                                 ""))

        Holidays.Add(New Holiday(#12/25/2013#,
                                 "Christmas Day",
                                 "Celebrates the birth of Jesus Christ. As the majority of Filipinos are Christians, Christmas in the Philippines is one of the longest in the world, stretching from as early as September until the last week of January.",
                                 HolidayType.RegularHoliday,
                                 "xmas"))

        Holidays.Add(New Holiday(#12/30/2013#,
                                 "Rizal Day",
                                 "Commemorates the execution of national hero José Rizal by Spanish colonial authorities on December 30, 1896.",
                                 HolidayType.RegularHoliday,
                                 ""))

        Holidays.Add(New Holiday(#12/31/2013#,
                                 "Last Day of the Year",
                                 "Legally known as the Last Day of the Year or Huling Araw ng Taon. It is also the day before New Year.",
                                 HolidayType.NonWorkingHoliday,
                                 ""))

    End Sub




End Class

