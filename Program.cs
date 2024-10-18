using System;

namespace Learning;
public class Progam
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey there ;)");

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

        



        // Printing them out 
        Console.WriteLine($"Today's date is: {todaysDate}");
        Console.WriteLine();
        Console.WriteLine($"Previous day date is: {previousDayDate}");
        Console.WriteLine();
        Console.WriteLine($"A decade later from today is: {decadeLater}");
        Console.WriteLine();
        Console.WriteLine($"Last moth from today was: {lastMonth}");

        


    }    
}