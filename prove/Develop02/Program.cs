using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        bool done = false;

        int userResponse;

        do
        {
            userResponse = menu.DisplayMenu();
            
            switch (userResponse)

            {
                case 1:
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
                case 5:
                    done = true;
                    break;
            }
            
            
        } while (!done);
    }
}