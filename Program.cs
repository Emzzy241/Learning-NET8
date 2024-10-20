using System;
using System.Globalization; // For importing the CultureInfo object type which returns type System.Globalization.Calendar

namespace Learning;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey there, lets learn about date's ;)");

        /*
        var hebrewCalendar = new System.Globalization.HebrewCalendar();

        var theDate = new DateOnly(5785, 3, 3, hebrewCalendar); // first value must be between 5343-5999.. 5785 is equivalent to year 2024

        // The System.Globalization.HebrewCalendar.ToDateTime(Int32 year, Int32 month, Int32 day, Int32 hour, Int32 minute, Int 32 seconds) takes in 

        Console.WriteLine(theDate); // MM/DD/YY
        */

        // Learning about the DateOnly type
        var today = DateOnly.FromDateTime(DateTime.Now);


        Console.WriteLine($"Today is {today}"); // using the DateOnly.FromDateTime() to Print out today's date

        Console.WriteLine();
        Console.WriteLine("---------------  LEARNING SOMETHING NEW  -------------------");
        Console.WriteLine();

        // Methods to adjust a DateOnly structure
        /*
            There are three methods used to adjust a DateOnly structure: AddDays(), AddMonths(), AddYears()
            Each method takes an integer parameter, and increases the date by that measurement.
            If a negative number is provided, the date is decreased by that measurement. 
            The methods return a new instance of DateOnly, as the structure is immutable
        */

        var theDate = new DateOnly(2024, 10, 18); //Yy/Mm/Dd --- HOW TO CREATE A new DateOnly object
        // or call on DateOnly.FromDateTime(DateTime.Now) to generate the actual date

        var todaysDate = DateOnly.FromDateTime(DateTime.Now);
        var theNextDay = todaysDate.AddDays(1);
        var previousDayDate = todaysDate.AddDays(-1);
        var decadeLater = todaysDate.AddYears(10);
        var lastMonth = todaysDate.AddMonths(-1);

        var dateInWords = todaysDate.ToLongDateString(); 

        



        // Printing them out 
        Console.WriteLine($"Today's date is: {todaysDate}");
        Console.WriteLine();
        Console.WriteLine($"Today's date in full: {dateInWords}");
        Console.WriteLine();
        Console.WriteLine($"Previous day date is: {previousDayDate}");
        Console.WriteLine();
        Console.WriteLine($"A decade later from today is: {decadeLater}");
        Console.WriteLine();
        Console.WriteLine($"Last month from today was: {lastMonth}");
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("---------------  LEARNING SOMETHING NEW  -------------------");
        Console.WriteLine();

        var newDate = DateOnly.ParseExact("21 Oct 2015", "dd MMM yyyy", CultureInfo.InvariantCulture);
            // Custom format
        var newDate2 = DateOnly.Parse("October 21, 2015", CultureInfo.InvariantCulture);
        // DateOnly
        // can be compared with other instances. For example, you can check if a date isbefore or after another, or if a date today matches a specific date.
        Console.WriteLine(newDate.ToString("m", CultureInfo.InvariantCulture));
        // Month day pattern
        Console.WriteLine(newDate2.ToString("o", CultureInfo.InvariantCulture));
        // ISO 8601 format
        Console.WriteLine(newDate2.ToLongDateString());

        // All calendars in .NET derive from the System.Globalization.Calendar class, which provides 
        // the base calendar implementation. One of the classes that inherits from the Calendar class is the EastAsianLunisolarCalendar class, which is the base class for all lunisolarcalendars.

        Console.WriteLine();
        Console.WriteLine("---------------  LEARNING SOMETHING NEW  -------------------");
        Console.WriteLine();

        var comDate = DateOnly.ParseExact("21 Oct 2015", "dd MMM yyyy", CultureInfo.InvariantCulture); // Custom format
        var comDate2 = DateOnly.Parse("October 21, 2015", CultureInfo.InvariantCulture);

        var dateLater = comDate.AddMonths(6); // add 6 months to date

        var dateBefore = comDate.AddDays(-10); // remove 10 days from date

        Console.WriteLine($"Consider {comDate} ..."); // considering the custom date

        Console.WriteLine($" Is ' {nameof(comDate2)}' equal? {comDate == comDate2}"); // using either Parse() or ParseExact() should yield the same RESULT
        Console.WriteLine($" Is {dateLater} after? {dateLater > comDate}");
        Console.WriteLine($" Is {dateLater} before? {dateLater < comDate}");

        Console.WriteLine($" Is {dateBefore } after? {dateBefore > comDate} ");
        Console.WriteLine($" Is {dateBefore } before? {dateBefore < comDate} ");

    }    
}