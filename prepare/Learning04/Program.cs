using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Max", "Sports");
        Console.WriteLine(assignment1.GetSummary());
        
        MathAssignment ma1 = new MathAssignment("Hugh", "Math", "3.1", "12-15");
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeworkList());

        WritingAssignement wa1 = new WritingAssignement("Hugh Wade", "LDS History", "I Stand With Brother Brigham");
        Console.WriteLine(wa1.GetSummary());
        Console.WriteLine(wa1.GetWritingInformation());
    }
}