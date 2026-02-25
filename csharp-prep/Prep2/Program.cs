using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        
        string letter;

        Console.Write("What is your grade %? ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            letter = "Your grade is an A";
        }

        else if (grade >= 80)
        {
            letter = "Your grade is a B";
        }

        else if (grade >= 70)
        {
            letter = "Your grade is a C";
        }

        else if (grade >= 60)
        {
            letter = "Your grade is a D";
        }

        else
        {
            letter = "Your grade is an F";
        }



        Console.WriteLine(letter);


        if (grade >= 70)
        {
            Console.WriteLine("Great Job! You Passed The Class!");
        }

        else
        {
            Console.WriteLine("You did not pass the class. I'm sure you'll pass it next time!");
        }

    }

}