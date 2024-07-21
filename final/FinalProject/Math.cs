public class Math : Question
{
    int _answer;
    bool _correct;

    public Math(string questionName, string question, int answer): base(questionName,question)
    {
      _answer = answer;
      
    }
    public override string Save(){
        return ($"Math,{_questionName},{_question},{_answer}");
    
    }

    public override void Display(){
        Console.WriteLine($"\n");
        Console.WriteLine($"Math Question {_questionName}:{_question}.");
       
    }

    public override string GetAnswer(){
    Console.Write("\b");
    Console.WriteLine($"Please answer the following math question: \n {_question}:");
    string yourAnswer = Console.ReadLine();
    int Answer = Convert.ToInt32(yourAnswer);
    
    if (Answer == _answer)
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