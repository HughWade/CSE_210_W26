class Listing : Activity
{
     public Listing()
    {
        SetActivityName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");   
    }

    private List<string> PromptList1 = new List<string>
    {
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?",  
    };

    public void Go()
    {
        DisplayWelcome();
        ListingGuts();
    }


    public void ListingGuts()
    {
        Random promptSelection1 = new Random();
        int promptNum = promptSelection1.Next(PromptList1.Count);
        string toDisplay = PromptList1[promptNum];
        Console.WriteLine("PROMPT:");
        SleepSeconds(1.5);
        Console.WriteLine($"{toDisplay}");
        SleepSeconds(3);
        DisplayCountdown("Please write down responses to the prompt. Press [Enter] after each entry....", 8);

    
        DateTime CurrentTime = DateTime.Now;
        DateTime endTime = CurrentTime.AddSeconds(GetSeconds());

        int count = 0;
        while (CurrentTime < endTime)
        {
        Console.Write($"Entry {count+1}: ");
        string newInput = Console.ReadLine();
        if (newInput != "")
            {
                CurrentTime = DateTime.Now;
                count += 1;
                continue;
            }
        
        else
            {
                CurrentTime = DateTime.Now;
                continue;
            }
        }

        Console.WriteLine($"You entered {count} entries.");
        DisplayEnding();
    }
}