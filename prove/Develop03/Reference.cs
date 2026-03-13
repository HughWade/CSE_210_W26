class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;


public Reference() //default reference is for Ether 12:27
    {
        _book = "Ether";
        _chapter = 12;
        _startVerse = 27;

    }

public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;       
    }

public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;       
    }

public string DisplayReference()
    {
        if (_endVerse!=0)
        {
        return $"{_book} Chapter {_chapter}, Verses {_startVerse} - {_endVerse}";
        }

        else
        {
            return $"{_book} Chapter {_chapter}, Verse {_startVerse}";
        }
    }

}