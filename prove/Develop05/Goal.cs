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

public bool GetStatus()
    {
        return _status;
    }

public void SetGoalName()
    {
        Console.Write("Name of Goal: ");
        _name = Console.ReadLine();
    }

public string GetGoalName()
    {
        return _name;
    }

public void SetDescription()
    {
        Console.Write("Description of Goal: ");
        _description = Console.ReadLine();
    }

public string GetDescription()
    {
        return _description;
    }

public abstract void SetPoints();
public abstract void DisplayGoal();
public string CheckBoxDisplay()
    {
        {
    if (GetStatus() == false)
        {
            return "[ ]";
        }

    else
        {
            return "[X]";
        }
}
    }

public int GetPoints()
    {
        return _points;
    }
}