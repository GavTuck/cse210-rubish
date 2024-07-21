public class FillBlank : Question
{
    string _answer;
    bool _correct;

    public FillBlank(string questionName, string question, string answer): base(questionName,question)
    {
      _answer = answer;
      
    }
    public override string Save(){
        return ($"FillBlank,{_questionName},{_question},{_answer}");
    
    }

    public override void Display(){
        Console.WriteLine($"\n");
        Console.WriteLine($"Fill Blank {_questionName}:{_question}.");
        
    }

    public override string GetAnswer(){
    Console.Write("\b");
    Console.WriteLine($"Please and answer the following fill in the blank question: \n {_question}:");
    string yourAnswer = Console.ReadLine();
    
    if (yourAnswer == _answer)
    {
        _correct = true;
        Console.WriteLine("Correct!");
    }
    else
    {
        _correct = false;
        Console.WriteLine("Incorrect :(");
    }
    return _correct.ToString();
    
    }
    
}