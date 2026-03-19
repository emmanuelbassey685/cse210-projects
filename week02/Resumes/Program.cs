using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2026;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Apple";
        job2._startYear = 2026;
        job2._endYear = 2026;

        // Creating a new instance of the Resume class
        Resume resume1 = new Resume();
        resume1._name = "Bassey, Emmanuel";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}