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
          "Hello", "Goodbye", // create list!!! 
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
    
    public Entry CreateEntryWithData(string date1, string question1, string entryText1)
    {
        Entry entry1 = new Entry();
        entry1._dateTime = date1;
        entry1._prompt = question1;
        entry1._response = entryText1;
        return entry1;
    }
}