using System;

class Program
{
    static void Main(string[] args)
    {
        //declare variable
        float score = 0;
        float grade_percent = 0;
        string letter_grade = "";
        const int ttl_marks = 100;
        const string pass_message = "Congration! Your have passed.";
        const string unpass_message = "Nice try! Keep pushing forward; you’ll do better next time!";
        string message = "";
        
        // ask student's score
        Console.Write("Please enter your score : ");
        score = int.Parse(Console.ReadLine());
        
        // caculate the grade percent
        grade_percent = (score / ttl_marks) * 100;
        //Console.WriteLine(score);
        //Console.WriteLine(ttl_marks);
        //Console.WriteLine(grade_percent);
        
        // get an appropriate letter grade and message
        // A,A-,B+,B,B-,C+C,C-,D+D,D-,F
        if (grade_percent >= 90 ) {
           //letter_grade = "A"; 
           //message = pass_message;
           if (grade_percent >= 93) {
                letter_grade = "A";
           }
           else
           {
             letter_grade = "A-";
           }
           message = pass_message;
           
        }
        else if (grade_percent <90 && grade_percent >= 80) {
            if (grade_percent >= 87) {
                letter_grade = "B+";
           }
           else if (grade_percent <= 82) {
                letter_grade = "B-";
           }
           else 
           {
             letter_grade = "B";
           }
            message = pass_message;
        }
        else if (grade_percent <80 && grade_percent >= 70) {
            if (grade_percent >= 77) {
                letter_grade = "C+";
           }
           else if (grade_percent <= 72) {
                letter_grade = "C-";
           }
           else 
           {
             letter_grade = "C";
           }
            message = pass_message;
        }
        else if (grade_percent <70 && grade_percent >= 60) {
            if (grade_percent >= 67) {
                letter_grade = "D+";
           }
           else if (grade_percent <= 62) {
                letter_grade = "D-";
           }
           else 
           {
             letter_grade = "D";
           }
            message = unpass_message;
        } 
        else if (grade_percent <60 ) {
            letter_grade = "F";
            message = unpass_message;
        }
        else {
            message = unpass_message; 
        };

        // Display the letter grade with an appropriate message
        Console.WriteLine("Your letter grade is " + letter_grade);
        Console.WriteLine(message);
    }
}


/*
switch (score)
        {
            // Handle multiple values in a single case block (ranges using multiple cases)
            case int n when (n >= 90 && n <= 100):
                Console.WriteLine("Grade: A");
                break;
            case int n when (n >= 80 && n < 90):
                Console.WriteLine("Grade: B");
                break;
            case int n when (n >= 70 && n < 80):
                Console.WriteLine("Grade: C");
                break;
            case int n when (n >= 60 && n < 70):
                Console.WriteLine("Grade: D");
                break;
            case int n when (n >= 0 && n < 60):
                Console.WriteLine("Grade: F");
                break;
            default:
                Console.WriteLine("Invalid score");
                break;switch (score)
        {
            // Handle multiple values in a single case block (ranges using multiple cases)
            case int n when (n >= 90 && n <= 100):
                Console.WriteLine("Grade: A");
                break;
            case int n when (n >= 80 && n < 90):
                Console.WriteLine("Grade: B");
                break;
            case int n when (n >= 70 && n < 80):
                Console.WriteLine("Grade: C");
                break;
            case int n when (n >= 60 && n < 70):
                Console.WriteLine("Grade: D");
                break;
            case int n when (n >= 0 && n < 60):
                Console.WriteLine("Grade: F");
                break;
            default:
                Console.WriteLine("Invalid score");
                break;

*/