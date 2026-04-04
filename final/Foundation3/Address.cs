class Address
{
private string _streetAddress;
private string _city;
private string _state;
private string _country;

public Address(string streetadd, string city, string state, string country)
    {
        _streetAddress = streetadd; _city = city; _state = state; _country = country;
    }

public string GetAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }



}