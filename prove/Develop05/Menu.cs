class Menu
{
    
    private int _userChoice;

    private GoalsTracker goalsTracker = new GoalsTracker();
    
    public void ProcessMenu()
    {
        Console.WriteLine("\nPlease Select an option:");
        Console.WriteLine("1. Start a Simple Goal");
        Console.WriteLine("2. Start an Eternal Goal");
        Console.WriteLine("3. Start a CheckList Goal");
        Console.WriteLine("4. Record an event");
        Console.WriteLine("5. Save Goals to File");
        Console.WriteLine("6. Pull Goals from File");
        Console.WriteLine("7. Quit");
        Console.Write("Select Option: ");
        _userChoice = int.Parse(Console.ReadLine());
    }

    public int GetUserChoice()
    {
        return _userChoice;
    }
    
    public void RunProgram()
    {
        
        switch(GetUserChoice())
        {
            case 1:
            SimpleGoal simplegoal1 = new SimpleGoal();
            simplegoal1.SetGoalName();
            simplegoal1.SetDescription();
            simplegoal1.SetPoints();
            goalsTracker.AppendGoal(simplegoal1);
            break;

            case 2:
            EternalGoal eternalGoal1 = new EternalGoal();
            eternalGoal1.SetGoalName();
            eternalGoal1.SetDescription();
            eternalGoal1.SetPoints();
            goalsTracker.AppendGoal(eternalGoal1);
            break;

            case 3:
            CheckListGoal checkListGoal1 = new CheckListGoal();
            checkListGoal1.SetGoalName();
            checkListGoal1.SetDescription();
            checkListGoal1.SetPoints();
            goalsTracker.AppendGoal(checkListGoal1);
            break;

            case 4:
            Console.Write("What number goal would you like to record an event for? ");
            int goalEvent = int.Parse(Console.ReadLine());
            goalEvent -= 1;
            goalsTracker.GoalsList[goalEvent].RecordEvent();
            goalsTracker.CalculateTotalPoints(goalsTracker.GoalsList[goalEvent].GetPoints());
            break;

            
        }

        goalsTracker.PrintGoals();
    }
}