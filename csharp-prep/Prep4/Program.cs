using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Generic; 

class Program
{
    
    static void Main(string[] args)
    {
        
           
        // declare a list
        List<int> numbers = new List<int>(); 
        bool isStop = false;
        int number = 0;
        int sum, largest_number,smallest_number = 0;
        double avg = 0;
        // enter a list of numbers 
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (isStop == false) {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0) {
                isStop = true;
            }
            else {
                numbers.Add(number);
            }
        }
        sum = numbers.Sum();
        avg = numbers.Average();
        largest_number = numbers.Max();
        smallest_number = numbers.Min();
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {avg}");
        Console.WriteLine($"The largest number is {largest_number}");
        Console.WriteLine($"The smallest positive number is {smallest_number}");
        Console.WriteLine($"The sorted list is : ");
        
        numbers.Sort();
        foreach(var item in numbers){
            Console.WriteLine(item);
        }


    /*is: 131
    The average is: 18.714285714285715
  T he largest number is: 48*? The sum*/

    }
}

  