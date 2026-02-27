using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int toAdd = -1;

        List<int> allNumbers = new List<int>();

        while (toAdd!=0)
        {
            Console.Write("Enter a number: ");
            toAdd = int.Parse(Console.ReadLine());
            if (toAdd!=0)
            {
            allNumbers.Add(toAdd);
            }

            else
            break;
        }

        float length = allNumbers.Count;

        int sum = 0;
        for (int i=0; i<length; i++)
        {
            sum+=allNumbers[i];
        }
        Console.WriteLine($"The sum is: {sum}");

        float average; 
        average = sum / length;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = 0;
        for (int i=0; i<allNumbers.Count; i++)
        {
            if (allNumbers[i] > largestNumber)
            {
                largestNumber = allNumbers[i];
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}