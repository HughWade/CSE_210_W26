using System;

class Program
{
    static void Main(string[] args)
    {
        Job myFirstJob = new Job();
        myFirstJob._companyName = "Raising Cane's";
        myFirstJob._jobTitle = "Crew Member";
        myFirstJob._startYear = 2021;
        myFirstJob._endYear = 2022;
        myFirstJob.DisplayJob();

        Job mySecondJob = new Job();
        mySecondJob._companyName = "DRC Foodworks";
        mySecondJob._jobTitle = "Dishwasher & Delivery Driver";
        mySecondJob._startYear = 2024;
        mySecondJob._endYear = 2026;
        mySecondJob.DisplayJob();
    }
}