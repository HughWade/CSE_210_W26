using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{


    public static void firstFunction()
        {
        Console.WriteLine("Bob");
        }

    public static int addNumbers(int n1, int n2)
    {
        return n1+n2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // firstFunction();

        // Console.WriteLine(addNumbers(1,2));
        // for (int i=100000; i>=-100000; i-=10000)
        // {
        //     Console.WriteLine(i);
        // }

        bool done = false;

        while (!done)
        {
            Console.Write("Please input your age: ");
            int age1 = int.Parse(Console.ReadLine());

            if (age1<0)
            {
                Console.WriteLine("Please input valid age.");
            }

            if (age1>0)
            {
                Console.Write("Thanks!");
                done = true;
            }
        }


        // List<int> myData = new List<int>();

        // myData.Add(11);
        // myData.Add(12);

        // foreach(int i in myData)
        // {
        //     Console.WriteLine(i);
        // }

        

    

    }
    
}