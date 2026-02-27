using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name1 = Console.ReadLine();

        return name1;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favnum = int.Parse(Console.ReadLine());
        return favnum;
    }

    static void PromptUserBirthYear(out int birthyear1)
    {
        Console.Write("What is your birthyear? ");
        birthyear1 = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string name, int num, int by)
    {
        Console.WriteLine($"{name}, the square of your number is {num}");
        Console.WriteLine($"{name}, you will turn {2026-by} this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        
        
        PromptUserBirthYear(out int birthyearr);
        int favNumberSquared = SquareNumber(favNumber);

        DisplayResult(userName,favNumberSquared,birthyearr);
    }
}