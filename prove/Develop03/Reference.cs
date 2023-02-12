using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int start){
        _book = book;
        _chapter = chapter;
        _startVerse = start;
    }

    public Reference(string book, int chapter, int start, int end){
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }

    public string GetDisplay(){
        string reference = $"{_book} {_chapter}: {_startVerse}";
        Random rand = new Random();
        int endVerse = rand.Next(_startVerse, _chapter);
        if (endVerse != _startVerse)
        {
            reference += "-" + endVerse;
        }
        return reference;
    }
}