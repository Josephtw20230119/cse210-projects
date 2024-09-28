using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string Name;
        int Number;
        Double Square_Number;
        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName() {
            string Name = "";
            Console.Write("Please enter your name : ");
            Name = Console.ReadLine();
            return Name;
        }

        static int PromptUserNumber() {
            int Number =0;
            Console.Write("Please enter your favorite number : ");
            Number = int.Parse(Console.ReadLine());
            return Number;
        }

        static Double SquareNumber(Double Number) {
            Double Square_Number = Math.Pow(Number,2);
            return Square_Number;

        }
        static void DisplayResult(string Name,Double Square_Number) {

            Console.WriteLine($"{Name}, the square of your number is {Square_Number}");

        }

        DisplayWelcome();
        Name = PromptUserName();
        Number = PromptUserNumber();
        Square_Number = SquareNumber(Number);
        DisplayResult(Name,Square_Number);

    }
}

/*
 - Displays the message, 
 - Asks for and returns the user's name (as a string)
 - Asks for and returns the user's favorite number (as an integer)
 - Accepts an integer as a parameter and returns that number squared (as an integer)
 

Welcome to the program!
 Brother Burton
 42
Brother Burton, the square of your number is 1764
*/