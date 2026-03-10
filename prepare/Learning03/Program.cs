using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction myFraction = new Fraction();
        
        Random myRandom = new Random();
        

        for (int i = 0; i < 100; i++)
        {
            
            int randomTop = myRandom.Next(1,9);
            int randomBottom = myRandom.Next(1,9);

            
            myFraction.SetTop(randomTop);
            myFraction.SetBottom(randomBottom);

            Console.WriteLine($"Fraction {i+1}: String: {myFraction.GetFractionString()} Number: {myFraction.GetDecimalValue()}");
        }
        
        
        // Fraction fraction1 = new Fraction();
        // Fraction fraction2 = new Fraction(5);
        // Fraction fraction3 = new Fraction(3,4);
        // Fraction fraction4 = new Fraction(1,3);

        // Console.WriteLine(fraction1.GetFractionString());
        // Console.WriteLine(fraction1.GetDecimalValue());

        // Console.WriteLine(fraction2.GetFractionString());
        // Console.WriteLine(fraction2.GetDecimalValue());

        // Console.WriteLine(fraction3.GetFractionString());
        // Console.WriteLine(fraction3.GetDecimalValue());

        // Console.WriteLine(fraction4.GetFractionString());
        // Console.WriteLine(fraction4.GetDecimalValue());
        
        
    
    }
    
}