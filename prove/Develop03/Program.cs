using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference();
        Scripture scripture1 = new Scripture();
        scripture1.DisplayScripture(5, reference1);

        Reference reference2 = new Reference("Helaman", 6, 36);
        Scripture scripture2 = new Scripture("And thus we see that the Lord began to pour out his Spirit upon the Lamanites, because of their easiness and willingness to believe in his words.");
        scripture2.DisplayScripture(3, reference2);

        Reference reference3 = new Reference("1 Nephi", 2, 14, 15);
        Scripture scripture3 = new Scripture("And it came to pass that my father did speak unto them in the valley of Lemuel, with power, being filled with the Spirit, until their frames did shake before him. And he did confound them, that they durst not utter against him; wherefore, they did as he commanded them. And my father dwelt in a tent.");
        scripture3.DisplayScripture(5, reference3);
    
    }
}