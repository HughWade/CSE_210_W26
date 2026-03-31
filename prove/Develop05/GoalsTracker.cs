class GoalsTracker
{
    public List<Goal> GoalsList = new List<Goal>();
    private int _totalpoints;

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
        int goalsCompleted = 0;
        Console.WriteLine("\nGoals List:");
        
        foreach (Goal goal in GoalsList)
        {
            Console.Write($"{numList}. ");
            goal.DisplayGoal();
            

            if (goal.GetStatus() == true)
            {
                goalsCompleted += 1;
            }

            numList += 1;
        }

        Console.WriteLine($"\nTotal Points: {GetTotalPoints()}");
        Console.WriteLine($"You have completed {goalsCompleted}/{numList-1} goals."); 
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

            outputFile.WriteLine($"totalpoints#{GetTotalPoints()}");
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

            if (parts[0] == "Simple Goal")
            {
                SimpleGoal simpleGoal = new SimpleGoal();
                simpleGoal.SetGoalNameFromFile(parts[2]);
                simpleGoal.SetDescriptionFromFile(parts[3]);
                simpleGoal.SetPointsFromFile(int.Parse(parts[4]));
                
                if (parts[5] == "False")
                {
                    simpleGoal.SetStatus(false);
                }
                else
                {
                    simpleGoal.SetStatus(true);
                }

                GoalsList.Add(simpleGoal);

            // string stringToSave = $"Simple Goal#{CheckBoxDisplay()}#{GetGoalName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}";

            }

            else if (parts[0] == "Eternal Goal")
            {
                EternalGoal eternalGoal = new EternalGoal();
                eternalGoal.SetGoalNameFromFile(parts[2]);
                eternalGoal.SetDescriptionFromFile(parts[3]);
                eternalGoal.SetPointsFromFile(int.Parse(parts[4]));
                eternalGoal.GetTimesCompletedFromFile(int.Parse(parts[5]));
                GoalsList.Add(eternalGoal);
                
            }

            // string stringToSave = $"Eternal Goal#{CheckBoxDisplay()}#{GetGoalName()}#{GetDescription()}#{GetPoints()}#{GetTimesCompleted()}#";


            else if (parts[0] == "CheckList Goal")
            {
                CheckListGoal checkListGoalGoal = new CheckListGoal();
                checkListGoalGoal.SetGoalNameFromFile(parts[2]);
                checkListGoalGoal.SetDescriptionFromFile(parts[3]);
                checkListGoalGoal.SetPointsFromFile(int.Parse(parts[4]));
                checkListGoalGoal.GetBonusPointsFromFile(int.Parse(parts[5]));
                checkListGoalGoal.GetTimesCompletedFromFile(int.Parse(parts[6]));
                checkListGoalGoal.GetCompletionsNeededFromFile(int.Parse(parts[7]));
            
                if (parts[8] == "False")
                {
                    checkListGoalGoal.SetStatus(false);
                }
                else
                {
                    checkListGoalGoal.SetStatus(true);
                }

                GoalsList.Add(checkListGoalGoal);
            
            }

            else if (parts[0] == "totalpoints")
                {
                    CalculateTotalPoints(int.Parse(parts[1]));
                }

            // string stringToSave = $"CheckList Goal#{CheckBoxDisplay()}#{GetGoalName()}#{GetDescription()}#{GetPoints()}#{GetBonusPoints()}#{GetTimesCompleted()}#{GetCompletionsNeeded()}#{GetStatus()}";





            // string date = parts[0];
            // string question = parts[1];
            // string entryText = parts[2];

            // Entry entry2 = new Entry();
            // entry2 = entry2.CreateEntryWithData(date, question, entryText);
            // this.AddEntry(entry2);
        }
    }

}