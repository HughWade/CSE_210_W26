using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference();
        reference1.DisplayReference();

        Scripture scripture1 = new Scripture();
        scripture1.DisplayScripture(5);
    }
}