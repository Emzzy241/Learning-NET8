using System;
using System.Collections.Generic; // For importing the List<T> object
namespace Learning;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey there, lets learn about Lists ;)");

        Console.WriteLine();
        Console.WriteLine("---------------  LEARNING SOMETHING NEW  -------------------");
        Console.WriteLine();
        // Console.WriteLine("Enter 2 lists and I will merge them together");
        // Console.WriteLine();

        // Console.WriteLine("Enter the first list");
        // string 

        // Defining the 2 inputs for my algorithm
        List<int> firstList = new List<int>(){ 1, 2, 3};
        var secondList = new List<int>{4, 5, 6};

        // Linking the 2 lists

        List<int> mergedList = new List<int>(){}; // instantiating an empty list
        foreach (var item in firstList)
        {
            mergedList.Add(item);
        }

        foreach (var item in secondList)
        {
            mergedList.Add(item);
        }
        
        Console.WriteLine();
        Console.WriteLine();

        foreach (var item in mergedList)
        {
            Console.WriteLine(item);
        }





     

        



    }    
}