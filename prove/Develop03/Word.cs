using System;

class Word{
    private string _shownWord;
    private bool _itsHidden = false;

    private string _underscores = "";

    public void Unhide(){
        _itsHidden = false;
    }

// This is my Constructor
    public Word(string _whatWord){
        _shownWord = _whatWord;
        for(int i = 0; i < _shownWord.Length; i++){
            _underscores += "_";
        }
    }

// Setter to change to false

public void HideWord(){
    _itsHidden = true;
}

public void Display(){
    if(_itsHidden){
        
        Console.Write($"{_underscores} ");
    }
    else{
        Console.Write($"{_shownWord} ");
    }
    
   
}



}