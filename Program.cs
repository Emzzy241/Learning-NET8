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

        


    }    
}