class OutdoorGathering : Event
{

private string _weatherForcast;

public OutdoorGathering(string weatherforcast, string title,string description,string date,string time,Address address) : base(title, description, date, time, address)
    {
        _weatherForcast = weatherforcast;
    }



public override string ReturnFullDetails()
{
    return $"\nFULL DETAILS\nEvent Type: Outdoor Gathering{ReturnStandardDetailsNOTITLE()}\nExpected Weather: {_weatherForcast}";
}
public override string ReturnShortDescription()
    {
        return $"\nSHORT DESCRIPTION\nEvent Type: Outdoor Gathering\nEvent Title: {GetEventTitle()}\nEvent Date: {GetEventDate()}";
    }
}