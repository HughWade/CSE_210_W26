using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("943 Slime Drive", "Montooza", "AL", "USA");
        Reception event1 = new Reception("hugh.jackman@gmail.com", "Ali Graduated!", "Come Celebrate Ali's Graduation with us!", "4/12/33", "5PM", address1);
        Console.WriteLine(event1.ReturnStandardDetails());
        Console.WriteLine(event1.ReturnFullDetails());
        Console.WriteLine(event1.ReturnShortDescription());

        Address address2 = new Address("894 Deez Rd.", "Klimpton", "NY", "USA");
        OutdoorGathering event2 = new OutdoorGathering("Partly Cloudy, No Rain", "Kahn's Rodeo", "Come enjoy beer, friends, and horses!", "6/5/33", "4PM", address2);
        Console.WriteLine(event2.ReturnStandardDetails());
        Console.WriteLine(event2.ReturnFullDetails());
        Console.WriteLine(event2.ReturnShortDescription());

        Address address3 = new Address("849 Cleever Way", "Duncher", "MS", "USA");
        Lecture event3 = new Lecture("Jordan B. Peterson", 1500, "We That Wrestle With God", "Enlightenment Awaits", "5/5/55", "3:30PM", address3);
        Console.WriteLine(event3.ReturnStandardDetails());
        Console.WriteLine(event3.ReturnFullDetails());
        Console.WriteLine(event3.ReturnShortDescription());

    }
}