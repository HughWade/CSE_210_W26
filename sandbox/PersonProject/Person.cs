using System.IO.Compression;

class Person

{
    private string _firstname;
    private string _lastname;
    private int _age;
    private int _weight;


    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstname = firstName;
        _lastname = lastName;
        _age = age;
        _weight = weight;
    }


    public string GetPersonInformation()
    {
        return $"Their name is {_firstname} {_lastname}. They are {_age} years old and weigh {_weight} pounds.";
    }

    public int GetAge()
    {
        return _age;
    }

    public int GetWeight()
    {
        return _weight;
    }

    public void SetWeight(int weight)
    {
        if (weight < 50 || weight>500)
        {
            Console.WriteLine("Invalid Weight, your person is either a child or should seek medical help.");
        }

        else
        _weight = weight;
    }

    public void SetAge(int age)
    {
        if (age<18 || age>100)
        {
            Console.WriteLine("Invalid Age, your person is either a child or too old to be working.");
        }

        else
        _age = age;
    }


}