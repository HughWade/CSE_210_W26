class GoalsTracker
{
    public List<Goal> GoalsList = new List<Goal>();
    private int _totalpoints = 0;

    public void AppendGoal(Goal goal)
    {
        GoalsList.Add(goal);
    }

    public void CalculateTotalPoints(int points)
    {
        _totalpoints += points;
    }

    public int GetTotalPoints()
    {
        return _totalpoints;
    }

    public void PrintGoals()
    {
        
        int numList = 1;
        Console.WriteLine("\nGoals List:");
        
        foreach (Goal goal in GoalsList)
        {
            Console.Write($"{numList}. ");
            goal.DisplayGoal();
            numList += 1;
        }

        Console.WriteLine($"\nTotal Points: {GetTotalPoints()}");
    }

public void WriteToFile()
    {
        Console.Write("File Name: ");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Goal goal in GoalsList)
            {
                outputFile.WriteLine(goal.CreateFileSystemString());
            }
        }
    }

}