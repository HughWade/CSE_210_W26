class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;


public Reference()
    {}

public Reference(string book, int chapter, int startVerse)
    {
        book = _book;
        chapter = _chapter;
        startVerse = _startVerse;       
    }

public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        book = _book;
        chapter = _chapter;
        startVerse = _startVerse;
        endVerse = _endVerse;       
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