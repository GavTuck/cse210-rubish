using System;

class Scripture{
    // Atributes

    private Reference _refAtribute;
    private List<Word> words = new List<Word>();

    
    
   
 //"invite others to come unto Christ by helping them receive the restored gospel through faith in Jesus Christ and His Atonement, repentance, baptism, receiving the gift of the Holy Ghost, and enduring to the end"

    // Constructors
    public Scripture( Reference paramReference, string text){
        _refAtribute = paramReference;

        string[ ] splitWords = text.Split();
        foreach(string temporalString in splitWords){
            Word word = new Word(temporalString);
            words.Add(word);
        }
    }
    
    public void Display(){
        _refAtribute.Display();
        foreach(Word temporalWord in words){
           temporalWord.Display();
        }
    }


    public void RandomlyHide(){
        Random random = new Random();
        int index = random.Next(words.Count);
        words[index].HideWord();}
       
    public void RevertBack(){
        foreach(Word usedword in words){
            usedword.Unhide();
        }

    
        

    }
    // Methods
    
    
    
    
}