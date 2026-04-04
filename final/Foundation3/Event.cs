abstract class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title,string description,string date,string time,Address address)
    {
        _eventTitle = title; _description = description; _date = date; _time = time; _address = address;
    }

    public string GetEventTitle()
    {
        return _eventTitle;
    }

    public string GetEventDate()
    {
        return _date;
    }
    
    public string ReturnStandardDetails()
    {
        return $"\n-------------------------------------\nSTANDARD DETAILS\nEvent Title: {_eventTitle}\nDescription: {_description}\nDate: {_date} at {_time}\nAddress: {_address.GetAddress()}";
    }

    public string ReturnStandardDetailsNOTITLE()
    {
        return $"\nEvent Title: {_eventTitle}\nDescription: {_description}\nDate: {_date} at {_time}\nAddress: {_address.GetAddress()}";
    }

    public abstract string ReturnFullDetails();
    public abstract string ReturnShortDescription();
}