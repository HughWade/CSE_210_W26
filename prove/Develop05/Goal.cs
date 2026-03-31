using System.IO.Enumeration;

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

public void SetStatus(bool boolean)
    {
        _status = boolean;
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
public abstract void RecordEvent();
public abstract string CreateFileSystemString();
public abstract void CreateEntryWithData();
public void SetGoalNameFromFile(string string1)
{
    _name = string1;
}

public void SetDescriptionFromFile(string string1)
    {
        _description = string1;
    }

public void SetPointsFromFile(int integer1)
    {
        _points = integer1;
    }



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