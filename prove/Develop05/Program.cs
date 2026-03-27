using System;

class Program
{
    static void Main(string[] args)
    {
    bool run = false;

    Menu menu = new Menu();
    while (!run)
        {
        menu.ProcessMenu();
        
        if (menu.GetUserChoice() != 7)
            {
            menu.RunProgram();
            }
        
        else
            {
                break;
            }
        
        }

    }


}