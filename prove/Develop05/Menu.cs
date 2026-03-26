class Menu
{
    
    private int _userChoice;
    
    public void ProcessMenu()
    {
        Console.WriteLine("Please Select an option:");
        Console.WriteLine("1. Start a Simple Goal");
        Console.WriteLine("2. Start an Eternal Goal");
        Console.WriteLine("3. Start a CheckList Goal");
        Console.WriteLine("4. Record an event");
        Console.WriteLine("5. Save Goals to File");
        Console.WriteLine("6. Pull Goals from File");
        Console.Write("Select Option: ");
        _userChoice = int.Parse(Console.ReadLine());
    }

    public void RunProgram()
    {
        GoalsTracker goalsTracker = new GoalsTracker();
        switch(_userChoice)
        {
            case 1:
            SimpleGoal simplegoal1 = new SimpleGoal();
            simplegoal1.GetGoalName();
            simplegoal1.GetDescription();
            simplegoal1.GetPoints();
            goalsTracker.AppendGoal(simplegoal1);
            break;
        }
    }
}