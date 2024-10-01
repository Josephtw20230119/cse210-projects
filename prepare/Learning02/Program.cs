using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class Job
{
    // Characters/Attributes (fields)
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;
    // Constructor to initialize attributes
    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method to display job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        
    }
}



public class Resume
{
    // Characters/Attributes (fields)
    public string _name;
    public Job _job1;
    public Job _job2;

    // Constructor to initialize attributes
    public Resume(string name,Job job1,Job job2)
    {
        _name = name;
        _job1 = job1;
        _job2 = job2;
        
    }

    // Method to display job details
    public void Display()
    {

        Console.WriteLine($"Name : {_name}");
        Console.WriteLine("Jobs : ");
        _job1.Display();
        _job2.Display();
        
        
    }
}





class Program
{
    static void Main(string[] args)
    {
        // Create a new Job object for Microsoft Software Engineer position (2019 - 2022)
        Job job1 = new Job("Microsoft","Software Engineer",2019,2022);
        // Create a new object for Apple Manager position (2022 - 2023)
        Job job2 = new Job("Apple","Manager",2022,2023);
        // create a nuw object  of Resume object;
        Resume resume = new Resume("Allison Rose",job1,job2);
        resume.Display();

    }
}