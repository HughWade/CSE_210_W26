using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        Journal journal1 = new Journal();
        
        bool done = false;

        int userResponse;

        int totaltimes = 1;

        do
        {
            userResponse = menu.DisplayMenu();
            
            switch (userResponse)

            {
                case 1:
                Console.WriteLine($"Journal Entry #{totaltimes}:");
                totaltimes += 1;
                journal1.Response();
                break;

                case 2:
                journal1.DisplayJournal();
                break;

                case 3:
                Console.Write("File Name: ");
                string file1 = Console.ReadLine();
                journal1.WriteToFile(file1);
                break;

                case 4:
                Console.Write("File Name: ");
                string file2 = Console.ReadLine();
                journal1.ReadFromFile(file2);
                break;

                case 5:
                    done = true;
                    break;
            }
            
            
        } while (!done);
    }
}


// "Welcome to the Journal Program",
//         "Create, Display, Save, and Load Journal Entries",
//         "1 - Create Journal Entry",
//         "2 - Display Journal",
//         "3 - Save Journal to file",
//         "4 - Read Journal from file",
//         "5 - Quit"