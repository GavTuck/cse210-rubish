public abstract class Question{
    protected string _questionName;
    protected string _question;
   
    

    public Question(string questionName, string question){
        _questionName = questionName;
        _question = question;
       
    }

    // public abstract int RecordEvent();

    public abstract void Display();

    public abstract string Save();

    public abstract string GetAnswer();
}