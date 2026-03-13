class Word
{
    private string _hiddenWord;

    
    public Word (string hiddenWord)
    {
        _hiddenWord = hiddenWord;
    }

    public string returnUnderscores()
    {
        return StringToBlank(_hiddenWord);
    }

    private string StringToBlank(string myString)
    {
        string newString = "";

        for (int i = 0; i < myString.Length; i++)
        {
            newString = newString += "_";
        }

        return newString;
    }


}