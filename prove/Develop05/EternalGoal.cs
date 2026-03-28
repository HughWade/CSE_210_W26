class EternalGoal : Goal
{

private int _timesCompleted = 0;
public EternalGoal() : base()
{
      _timesCompleted = 0;  
}

private int GetTimesCompleted()
    {
        return _timesCompleted;
    }

public override void SetPoints()
{
    Console.Write("How many points will be given for each completion of this goal? ");
    _points = int.Parse(Console.ReadLine());
    
}

public override void DisplayGoal()
{
    Console.WriteLine($"{CheckBoxDisplay()} Eternal Goal - {GetGoalName()} - {GetDescription()} - Points: {GetPoints()} - Times Completed: {GetTimesCompleted()}");
}


}