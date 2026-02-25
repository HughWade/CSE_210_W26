using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep1 World!");
        string firstName;
        string lastName;

        Console.Write("\nWhat is your first name: ");
        firstName = Console.ReadLine();

        Console.Write("What is your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.\n");
    }
}