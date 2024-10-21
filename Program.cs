using System;
using System.Collections; // For importing the ArrayList object
using System.Collections.Generic; // For importing the List<T> object
using System.Diagnostics;
namespace Learning;
public class Program
{
    public static void Main(string[] args)
    {
        // Page 835 on the Microsoft dotnet documentation, topic: Generic types overview
        Console.WriteLine("Hey there, lets learn Generics ;)");
        Console.WriteLine();
        Console.WriteLine("We will be writing a program that shows the differences between a generic and a non-generic list");

        Console.WriteLine();
        Console.WriteLine("---------------  LEARNING SOMETHING NEW  -------------------");
        Console.WriteLine();
       

        // generic list
       List<int> ListGeneric = new List<int> {5, 9, 1, 4};
       
       // non-generic list
       ArrayList ListNonGeneric = new ArrayList {5, 9, 1, 4};

        // calculating the time it takes to sort both a generic and a non-generic list
        // timer for Generic Sort
        Stopwatch s = Stopwatch.StartNew();
        ListGeneric.Sort();
        s.Stop();

        Console.WriteLine($"Generic  Sort: {ListGeneric} \n Time taken {s.Elapsed.TotalMilliseconds}ms");

        // timer for non-generic Sort
        Stopwatch s2 = Stopwatch.StartNew();
        ListNonGeneric.Sort();
        s2.Stop();
        Console.WriteLine($"Non-Generic Sort: {ListNonGeneric} \n Time taken {s2.Elapsed.TotalMilliseconds}ms");
        Console.WriteLine();



        




     

        



    }    
}