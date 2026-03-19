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
            Activity activity1 = new Activity("Breathing", "");
            break;

            case 2:
            Activity activity2 = new Activity("Reflecting", "");
            break;

            case 3:
            Activity activity3 = new Activity("Listing", "");
            break;





        }
    }
}