using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Data Analyst";
        job2._startYear = 2020;
        job2._endYear = 2023;

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);

        //job1.Display();
        //job2.Display();

        // I have to create a Resume Object
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // I add jobs to myResume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // I verify the  access to the first job
        //Console.WriteLine(myResume._jobs[0]._jobTitle);

        // I display my full Resume
        myResume.Display();
    }
}
