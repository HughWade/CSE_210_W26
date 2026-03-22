class Reflection : Activity
{
    
    private List<string> PromptList = new List<string>
    {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> ReflectQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    
    public Reflection()
    {
        SetActivityName("Reflection");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");   
    }


    public void Go()
    {
        DisplayWelcome();
        ReflectionGuts();

    }


    private void ReflectionGuts()
    {
        Random promptSelection = new Random();
        int promptNum = promptSelection.Next(PromptList.Count);
        string toDisplay = PromptList[promptNum];
        Console.WriteLine($"PROMPT:");
        SleepSeconds(1.5);
        Console.WriteLine($"{toDisplay}");
        SleepSeconds(1.5);

    
        DateTime CurrentTime = DateTime.Now;
        DateTime endTime = CurrentTime.AddSeconds(GetSeconds());
    
        while (CurrentTime < endTime)
        {
        Random displaySelection = new Random();
        int displayNum = displaySelection.Next(ReflectQuestions.Count);
        string toDisplay2 = ReflectQuestions[displayNum];

        DisplayLoading(toDisplay2, 6);
        
        CurrentTime = DateTime.Now;

        }

        DisplayEnding();
    }



}
