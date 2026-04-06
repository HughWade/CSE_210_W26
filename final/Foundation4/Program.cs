using System;

class Program
{
    static void Main(string[] args)
    {
    List<Activity> ListofActivities = new List<Activity>();

    Activity activity1 = new Cycling("05 Oct 2026", 70, 10);
    Activity activity2 = new Running("28 Feb 2002", 90, 10);    
    Activity activity3 = new Swimming("30 Nov 2023", 45, 20);

    ListofActivities.Add(activity1);
    ListofActivities.Add(activity2);    
    ListofActivities.Add(activity3);

    Console.WriteLine("- Activity Summary -");
    foreach (Activity activity in ListofActivities)
        {
            Console.WriteLine(activity.GetSummary());
        }    

    

    }
}