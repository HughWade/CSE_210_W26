class Program
{
    public static void Main(string[] args)
    {
        Person myMan = new Person("Bob", "Ross", 55, 170);
        Console.WriteLine(myMan.GetPersonInformation());

        Doctor theGoat = new Doctor("Heart Monitor", "Hank", "Smith", 45, 200);
        Console.WriteLine(theGoat.GetDoctorInformation());
    }

}
