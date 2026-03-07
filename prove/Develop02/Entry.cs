using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;



class Entry
{
    
    public string _prompt;

    public string _dateTime;

    public string _response;


    public string GetDate()
    {
    DateTime theCurrentTime = DateTime.Now;
    return theCurrentTime.ToShortDateString();
    
    }

    public string SetPrompt()
    {
        
        List<string> promptList = new List<string>
        {
          "What is one profound lesson you learned today?", 
          "What is something you think you can improve about yourself?",
          "Who is someone you look up to and why?",
          "What gave you motivation to wake up today?",
          "What was the best part about your day?",
          "What is something you are looking forward to?"
        };



        Random randomNum = new Random();

        int randomNum2 = randomNum.Next(promptList.Count);

        return promptList[randomNum2];

    }

    public string CreateFileSystemString()
    {
        string outputString = $"{_dateTime}#{_prompt}#{_response}";
        return outputString;
    }
    
    public Entry CreateEntryWithData(string date, string question, string entryText)
    {
        Entry entry1 = new Entry();
        entry1._dateTime = date;
        entry1._prompt = question;
        entry1._response = entryText;
        return entry1;
    }
}