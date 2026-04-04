class Reception : Event
{

private string _rsvpEmail;

public Reception(string rsvp, string title,string description,string date,string time,Address address) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvp;
    }
public override string ReturnFullDetails()
{
    return $"\nFULL DETAILS\nEvent Type: Reception{ReturnStandardDetailsNOTITLE()}\nRSVP Email: {_rsvpEmail}";
}
public override string ReturnShortDescription()
    {
        return $"\nSHORT DESCRIPTION\nEvent Type: Reception\nEvent Title: {GetEventTitle()}\nEvent Date: {GetEventDate()}";
    }
}