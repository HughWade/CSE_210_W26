class CheckListGoal : Goal
{

private int _bonusPoints = 0;
private int _timesCompleted = 0;
private int _completionsNeeded = 0;

private int GetBonusPoints()
    {
        return _bonusPoints;
    }

private int GetTimesCompleted()
    {
        return _timesCompleted;
    }

private int GetCompletionsNeeded()
    {
        return _completionsNeeded;
    }
public override void SetPoints()
{
    Console.Write("How many points will be given for each completion? ");
    _points = int.Parse(Console.ReadLine());

    Console.Write("How many bonus points will be awarded\nwhen the checklist has been completed? ");
    _bonusPoints = int.Parse(Console.ReadLine());

    Console.Write("How many times does the the goal need to be completed\nin order to complete the checklist? ");
    _completionsNeeded = int.Parse(Console.ReadLine());

}

public override void DisplayGoal()
{
    Console.WriteLine($"{CheckBoxDisplay()} CheckList Goal - {GetGoalName()} - {GetDescription()} - \nPoints each time: {GetPoints()} - Bonus Points for Full Completion: {GetBonusPoints()} - Times Completed: {GetTimesCompleted()} out of {GetCompletionsNeeded()} - Completed: {GetStatus()}");
}

public override void RecordEvent()
{
    _timesCompleted+=1;
    if (_timesCompleted == _completionsNeeded)
        {
            SetStatus(true);
            _points += _bonusPoints;
        }
}

public override string CreateFileSystemString()
    {
        string stringToSave = $"CheckList Goal#{CheckBoxDisplay()}#{GetGoalName()}#{GetDescription()}#{GetPoints()}#{GetBonusPoints()}#{GetTimesCompleted()}#{GetCompletionsNeeded()}#{GetStatus()}";
        return stringToSave;
    }

public override void CreateEntryWithData()
{
}

public void GetTimesCompletedFromFile(int integer1)
    {
        _timesCompleted = integer1;
    }

public void GetCompletionsNeededFromFile(int integer1)
    {
        _completionsNeeded = integer1;
    }

public void GetBonusPointsFromFile(int integer1)
    {
        _bonusPoints = integer1;
    }

}