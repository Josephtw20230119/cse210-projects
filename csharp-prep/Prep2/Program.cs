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
        if (grade_percent >= 90) {
           letter_grade = "A"; 
           message = pass_message;
        }
        else if (grade_percent <90 && grade_percent >= 80) {
            letter_grade = "B";
            message = pass_message;
        }
        else if (grade_percent <80 && grade_percent >= 70) {
            letter_grade = "C";
            message = pass_message;
        }
        else if (grade_percent <70 && grade_percent >= 60) {
            letter_grade = "D";
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