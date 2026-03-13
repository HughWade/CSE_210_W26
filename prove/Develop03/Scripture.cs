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


public void DisplayScripture(List<string> listScripture, List<int> numberList, int wordsToHide)
    {
        Random newRandom = new Random();
        
        string myInput = "";

        while (myInput == "" && myInput != "quit")

        {

            if (numberList.Count > wordsToHide)
            {
                for (int i = 0; i<wordsToHide; i++)
                {
                    int rando = newRandom.Next(numberList.Count);
                    int wordIndex = numberList[rando];
                    string word = listScripture[wordIndex];
                    Word wordInstance = new Word(word);

                    listScripture[wordIndex] = wordInstance.returnUnderscores();

                    numberList.Remove(rando);
                    
                }


                foreach (string item in listScripture)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }

                Console.WriteLine("");
                myInput = Console.ReadLine();

            }

            else
            {
                for (int i = 0; i<numberList.Count; i++)
                {
                    int wordIndex = numberList[i];
                    string word = listScripture[wordIndex];
                    Word wordInstance = new Word(word);

                    listScripture[wordIndex] = wordInstance.returnUnderscores();

                }


                foreach (string item in listScripture)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }

                Console.WriteLine("");
                myInput = "quit";
            }
        
        }

    }

}