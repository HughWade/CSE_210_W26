using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);
    
        fraction3.GetTop();
        fraction3.GetBottom();

        fraction3.SetTop(7);
        fraction3.SetBottom(3);
        
    
    }
    
}