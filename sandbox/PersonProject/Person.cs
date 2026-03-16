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




}