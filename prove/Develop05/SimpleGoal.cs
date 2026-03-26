class SimpleGoal : Goal
{

public SimpleGoal() : base()
    {
        
    }

public override void SetPoints()
    {
        Console.WriteLine("How many points will be assigned to this goal? ");
        _points = int.Parse(Console.ReadLine());
    
    }

    public override void DisplayGoal()
    {}

}