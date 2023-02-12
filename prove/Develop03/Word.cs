using System;

public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text){
        _text = text;
    }

    public void Hide(){
        _isHidden = true;
    }

    public bool isHidden(){
        return _isHidden;
    }

    public string GetDisplay(){
        if (_isHidden){
            string hiddenWord = "_";
            for(int i = 0; i < _text.Length; i++){
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        else{
            return _text;
        }
    }
}