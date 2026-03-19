class Menu
{
public int ProcessMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness Activity Program!\nWhich program would you like to do today?\n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity");
        Console.WriteLine("Please input a valid activity number: ");
        string firstString = Console.ReadLine();
        
        while (firstString!="1" && firstString!="2" && firstString!="3")
        {Console.WriteLine("Please input a valid activity number: ");
        firstString = Console.ReadLine();}

        int number = int.Parse(firstString);
        return number;
    }
}