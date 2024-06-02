using System;

class Reference{
    // Atributes
    private string _bookName;
    private int _chapterNum;
    private int _verseNum;

    //Constructors
    public Reference(string _bookChoice,int _chapterChoice,int _verseChoise){
        _bookName = _bookChoice;
        _chapterNum = _chapterChoice;
        _verseNum = _verseChoise;
    }

    //Methods
    public void Display(){
        Console.WriteLine($"{_bookName} {_chapterNum}:{_verseNum}");
    }


}