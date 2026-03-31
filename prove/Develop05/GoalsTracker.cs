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

public void ReadFromFile()
    {
        
        Console.Write("File Name: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            string[] parts = line.Split("#");

            if (parts[1] == "Simple Goal")
            {
                SimpleGoal simpleGoal = new SimpleGoal();
                simpleGoal.SetGoalNameFromFile(parts[1]);
                simpleGoal.SetDescriptionFromFile(parts[2]);
                simpleGoal.SetPointsFromFile(int.Parse(parts[3]));
                
                if (parts[4] == "false")
                {
                    simpleGoal.SetStatus(false);
                }
                else
                {
                    simpleGoal.SetStatus(true);
                }

                GoalsList.Add(simpleGoal);

            // string stringToSave = $"{CheckBoxDisplay()}#{GetGoalName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}";

            }

            if (parts[1] == "Eternal Goal")
            {
                EternalGoal eternalGoal = new EternalGoal();
                eternalGoal.SetGoalNameFromFile(parts[1]);
                eternalGoal.SetDescriptionFromFile(parts[2]);
                eternalGoal.SetPointsFromFile(int.Parse(parts[3]));
                eternalGoal.GetTimesCompletedFromFile(int.Parse(parts[4]));
                GoalsList.Add(eternalGoal);
                
            }

            // string stringToSave = $"{CheckBoxDisplay()}#{GetGoalName()}#{GetDescription()}#{GetPoints()}#{GetTimesCompleted()}";


            if (parts[1] == "CheckList Goal")
            {
                CheckListGoal checkListGoalGoal = new CheckListGoal();
                checkListGoalGoal.SetGoalNameFromFile(parts[1]);
                checkListGoalGoal.SetDescriptionFromFile(parts[2]);
                checkListGoalGoal.SetPointsFromFile(int.Parse(parts[3]));
                checkListGoalGoal.GetBonusPointsFromFile(int.Parse(parts[4]));
                checkListGoalGoal.GetTimesCompletedFromFile(int.Parse(parts[5]));
                checkListGoalGoal.GetCompletionsNeededFromFile(int.Parse(parts[6]));
            
                if (parts[7] == "false")
                {
                    checkListGoalGoal.SetStatus(false);
                }
                else
                {
                    checkListGoalGoal.SetStatus(true);
                }

                GoalsList.Add(checkListGoalGoal);
            
            }

            // string stringToSave = $"{CheckBoxDisplay()}#{GetGoalName()}#{GetDescription()}#{GetPoints()}#{GetBonusPoints()}#{GetTimesCompleted()}#{GetCompletionsNeeded()}#{GetStatus()}";





            // string date = parts[0];
            // string question = parts[1];
            // string entryText = parts[2];

            // Entry entry2 = new Entry();
            // entry2 = entry2.CreateEntryWithData(date, question, entryText);
            // this.AddEntry(entry2);
        }
    }

}