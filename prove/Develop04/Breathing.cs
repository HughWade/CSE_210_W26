class Breathing : Activity
{
    

public Breathing()
    {
        SetActivityName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

public void Go()
    {
        DisplayWelcome();
        BreathingGuts();
    }

private void BreathingGuts()
    {
    DateTime CurrentTime = DateTime.Now;
    DateTime endTime = CurrentTime.AddSeconds(GetSeconds());

    while (CurrentTime < endTime)
        {
            DisplayLoading("Breathe in", 4);
            DisplayLoading("Breathe out", 4);
            CurrentTime = DateTime.Now;

        }
    
    DisplayEnding();
    }

}