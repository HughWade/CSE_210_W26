using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        
        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1,101);

        int guess;

        guess = -1;

        

        while (magicNumber != guess)
        {

        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
    
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
    
        else
            {
                Console.WriteLine("You guessed it!");
            }

        }

        

    
    }
}