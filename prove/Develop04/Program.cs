using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        int number = menu.ProcessMenu();

        switch(number)
        {
            case 1:
            Breathing breathing1 = new Breathing();
            breathing1.Go();
            break;

            case 2:
            Reflection reflection1 = new Reflection();
            reflection1.Go();
            break;

            case 3:
            Listing listing1 = new Listing();
            listing1.Go();
            break;

        }
    }
}