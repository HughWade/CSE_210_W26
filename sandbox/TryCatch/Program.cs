using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{


    public static int GetAge()
        
        {
            bool done = false;
            int age1 = -1;

            while (!done)
        {
            try
            {
                Console.Write("Please Enter Your Age: ");
                age1 = int.Parse(Console.ReadLine());

                if (age1<0 || age1>125)
                {
                    done = true;
                }

                else
                {
                    Console.WriteLine("Please Enter a valid age (0-125) ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a valid age. ");
            }

            }

            return age1;
        }
        
public static void Main(string[] args)
    {
        

    }

}
        