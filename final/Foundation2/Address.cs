using System.Security.Cryptography;

class Address
{
private string _streetAddress;
private string _city;
private string _state;
private string _country;

public Address()
    {
        _streetAddress = "1034 Rockridge Plaza"; _city = "Rocky Road"; _state = "MO"; _country = "USA";
    }

public Address(string streetadd, string city, string state, string country)
    {
        _streetAddress = streetadd; _city = city; _state = state; _country = country;
    }

public string GetAddress2()
    {
        return $"{_streetAddress}\n{_city}, {_state}, {_country}";
    }

public string GetCountry()
    {
        return _country;
    }
public bool inUSA()
    {
        if (GetCountry() == "USA")
        {
            return true;
        }

        else
        {
            return false;
        }
    }


}