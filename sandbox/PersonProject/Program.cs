class Program
{
    public static void Main(string[] args)
    {
        Person myMan = new Person("Bob", "Ross", 55, 170);
        Console.WriteLine(myMan.GetPersonInformation());
        Console.WriteLine();

        Doctor theGoat = new Doctor("Heart Monitor", "Hank", "Smith", 45, 200);
        Console.WriteLine(theGoat.GetDoctorInformation());
        Console.WriteLine();

        Police myPolice = new Police("Baseball Bat", "John", "Lasseter", 34, 199);
        Console.WriteLine(myPolice.GetPoliceInformation());
        Console.WriteLine();
    }

}
