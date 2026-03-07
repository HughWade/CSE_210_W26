using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Journal

{
    List<Entry> _entries = new List<Entry>
    {};

    //public string _entry;
    
    public void Response()
    {
        Entry entry1 = new Entry();
        entry1._dateTime = entry1.GetDate();
        entry1._prompt = entry1.SetPrompt();
        Console.Write($"{entry1._dateTime} - {entry1._prompt}: ");
        entry1._response = Console.ReadLine();
        _entries.Add(entry1);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.Write(entry._dateTime); Console.Write(" - ");
            Console.Write(entry._prompt); Console.Write(": ");
            Console.WriteLine(entry._response);
        }
    }


    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry1 in _entries)
            {
                outputFile.WriteLine(entry1.CreateFileSystemString());
            }
        }
    }

    


    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            Entry entry2 = new Entry();
            entry2 = entry2.CreateEntryWithData(date, question, entryText);
            this.AddEntry(entry2);
        }
    }

    public void AddEntry(Entry entry3)
    {
        _entries.Add(entry3);
    }


}