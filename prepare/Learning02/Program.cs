using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Raising Cane's";
        job1._jobTitle = "Crew Member";
        job1._startYear = 2021;
        job1._endYear = 2022;
        // job1.DisplayJob();

        Job mySecondJob = new Job();
        mySecondJob._companyName = "DRC Foodworks";
        mySecondJob._jobTitle = "Dishwasher & Delivery Driver";
        mySecondJob._startYear = 2024;
        mySecondJob._endYear = 2026;
        // mySecondJob.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Hugh Wade";
        myResume._jobs = new List<Job>();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(mySecondJob);
        myResume.DisplayResume();

    }
}