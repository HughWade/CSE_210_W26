using System.ComponentModel.DataAnnotations;

class Scripture

{
    
    private List<string> _listScripture;
    private List<int> _numberList;
    private int _wordsToHide;
    private string _defaultScripture = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";

    private string _scripture;

private void TurnStringToList(string scripture)
    {
        List<string> strings = new List<string>();
        string[] tempWords = scripture.Split();
        foreach (string word in tempWords)
        {
            strings.Add(word);
        }

        _listScripture = strings;

    }

private void CreateNumberList(int integer)
    {
        List<int> ints = new List<int>();
        for (int i = 0; i < integer; i++)
        {
            ints.Add(i);
        }

        _numberList = ints;
    }



public Scripture()
    {
        _scripture = _defaultScripture;

        TurnStringToList(_defaultScripture);

        CreateNumberList(_listScripture.Count());
    }


public Scripture(string scripture)
    {
        _scripture = scripture;

        TurnStringToList(scripture);

        CreateNumberList(_listScripture.Count());
    }


public void DisplayScripture(int wordsToHide)
    {
        _wordsToHide = wordsToHide;

        Random newRandom = new Random();
        
        string myInput = "";

        while (myInput == "" && myInput != "quit")

        {
            
            if (myInput == "quit")
            {
                break;
            }
            
            Console.Clear();
            Console.WriteLine(_scripture);
            Console.WriteLine("");
            myInput = Console.ReadLine();

            if (myInput == "quit")
            {
                break;
            }

            if (_numberList.Count > _wordsToHide && (myInput == "" || myInput != "quit"))
            {
                Console.Clear();
                for (int i = 0; i<_wordsToHide; i++)
                {
                    int rando = newRandom.Next(_numberList.Count);
                    int wordIndex = _numberList[rando];
                    string word = _listScripture[wordIndex];
                    Word wordInstance = new Word(word);

                    _listScripture[wordIndex] = wordInstance.returnUnderscores();

                    _numberList.Remove(wordIndex);
                    
                }


                foreach (string item in _listScripture)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }

                Console.WriteLine("");
                myInput = Console.ReadLine();

                if (myInput == "quit")
                {
                break;
                }


            }

            if (_numberList.Count <= _wordsToHide && (myInput == "" || myInput != "quit"))
            {
                Console.Clear();
                for (int i = 0; i<_numberList.Count; i++)
                {
                    int wordIndex = _numberList[i];
                    string word = _listScripture[wordIndex];
                    Word wordInstance = new Word(word);

                    _listScripture[wordIndex] = wordInstance.returnUnderscores();

                }


                foreach (string item in _listScripture)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }

                Console.WriteLine();
                myInput = Console.ReadLine();

                if (myInput == "quit")
                {
                break;
                }


                Console.WriteLine("");
                myInput = "quit";
            }
        
        }

    }

}