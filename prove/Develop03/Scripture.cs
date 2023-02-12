using System;

public class Scripture 
{
    private Reference _ref {get; set; }
    public List<string> verses { get; set; }
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, List<string> verses)
    {
        this._ref = reference;
        this.verses = verses;
    }

    public void HideWords(int count){
        for (int i = 0; i < count; i++){
            if (i < _words.Count()){
                _words[i].Hide();
            }
            else{
                break;
            }
        }
    }

    public bool IsCompletelyHidden(){
        foreach (Word word in _words){
            if (!word.isHidden()){
                return false;
            }
        }
        return true;
    }
    

    public void Display(){
        Console.WriteLine( _ref.ToString());
        foreach (Word word in _words){
            Console.WriteLine("\t\t\t" + word.ToString());
        }
    }
}
