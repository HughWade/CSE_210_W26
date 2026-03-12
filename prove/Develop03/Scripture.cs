using System.ComponentModel.DataAnnotations;

class Scripture

{
    
    private List<string> _listScripture;
    private string _scripture;
    private List<int> _numberList;
    private int _wordsToHide;
    private string _defaultScripture = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";


private void TurnStringToList(string scripture)
    {
        string[] tempWords = scripture.Split();
        foreach (string word in tempWords)
        {
            _listScripture.Add(word);
        }

    }

private void CreateNumberList(int integer)
    {
        for (int i = 0; i < integer; i++)
        {
            _numberList.Add(i);
        }
    }

public Scripture()
    {
        TurnStringToList(_defaultScripture);

        CreateNumberList(_listScripture.Count());
    }


public Scripture(string scripture)
    {
        TurnStringToList(scripture);

        CreateNumberList(_listScripture.Count());
    }


public string DisplayScripture(List<string> listScripture, List<int> numberList, int wordsToHide)
    {
        Random newRandom = new Random();

        
        
        return "";
    }

}