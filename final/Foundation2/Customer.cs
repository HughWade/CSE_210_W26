class Customer
{

private string _name;

private Address _address;

public bool inUSA()
    {
        bool toreturn = _address.inUSA();
        return toreturn;
    }

public string GetName()
    {
        return _name;
    }

public Address GetAddress1()
    {
        return _address;
    }

}