class Customer
{

private string _name;

private Address _address;

public Customer()
    {
    }

public Customer(string name, Address address)
    {
        _name = name; _address = address;
    }

public bool inUSA()
    {
        return _address.inUSA();
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