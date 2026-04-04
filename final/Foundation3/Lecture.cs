class Lecture : Event
{
    
private string _speaker;
private int _limitedCapacity;

public Lecture(string speaker, int limitedcap, string title,string description,string date,string time,Address address) : base(title, description, date, time, address)
    {
       _speaker = speaker; _limitedCapacity = limitedcap;
    }
public override string ReturnFullDetails()
{
    return $"\nFULL DETAILS\nEvent Type: Lecture{ReturnStandardDetailsNOTITLE()}\nSpeaker: {_speaker}\nCapacity: {_limitedCapacity} People";
}
public override string ReturnShortDescription()
    {
        return $"\nSHORT DESCRIPTION\nEvent Type: Lecture\nEvent Title: {GetEventTitle()}\nEvent Date: {GetEventDate()}";
    }
}