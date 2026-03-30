class SimpleGoal : Goal
{

public SimpleGoal() : base()
    {
        
    }

public override void SetPoints()
    {
        Console.Write("How many points will be assigned to this goal? ");
        _points = int.Parse(Console.ReadLine());
    
    }

public override void DisplayGoal()
{
    Console.WriteLine($"{CheckBoxDisplay()} Simple Goal - {GetGoalName()} - {GetDescription()} - Points: {GetPoints()} - Completed: {GetStatus()}");
}

public override void RecordEvent()
{
    SetStatus(true);
}

public override string CreateFileSystemString()
    {
        string stringToSave = $"{CheckBoxDisplay()}#{GetGoalName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}";
        return stringToSave;
    }




}