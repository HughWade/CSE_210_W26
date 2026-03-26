public abstract class Goal
{
private string _name;
private string _description;
protected int _points;
private bool _status;    

public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _status = false;
    }

public void SetGoalName()
    {
        Console.WriteLine("Name of Goal: ");
        _name = Console.ReadLine();
    }

public string GetGoalName()
    {
        return _name;
    }

public void SetDescription()
    {
        Console.WriteLine("Description of Goal: ");
        _description = Console.ReadLine();
    }

public string GetDescription()
    {
        return _description;
    }

public abstract void SetPoints();
public abstract void DisplayGoal();

public int GetPoints()
    {
        return _points;
    }
}