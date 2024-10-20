using System;
using System.Collections.Generic; // For importing the List<T> object
namespace Learning;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey there, lets learn about Lists ;)");
        Console.WriteLine();
        Console.WriteLine("We will be writing a program that takes in multiple lists, sorts and merge those lists");

        Console.WriteLine();
        Console.WriteLine("---------------  LEARNING SOMETHING NEW  -------------------");
        Console.WriteLine();
        // Console.WriteLine("Enter 2 lists and I will merge them together");
        // Console.WriteLine();

        // Console.WriteLine("Enter the first list");
        // string 

        // Defining the 2 inputs for my algorithm
        List<int> firstList = new List<int>(){ 3, 2, 1};
        var secondList = new List<int>{5, 6, 4};

        // Sorting the input lists
        firstList.Sort();
        secondList.Sort();

        // Linking the 2 lists

        List<int> mergedList = new List<int>(){}; // instantiating an empty list for merging input lists.
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