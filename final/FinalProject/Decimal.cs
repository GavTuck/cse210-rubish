public class Decimal : Question
{
    float _answer;
    bool _correct;

    public Decimal(string questionName, string question, float answer): base(questionName,question)
    {
      _answer = answer;
      
    }
    public override string Save(){
        return ($"Decimal,{_questionName},{_question},{_answer}");
    
    }

    public override void Display(){
        Console.WriteLine($"\n");
        Console.WriteLine($"Math Decimal Question {_questionName}:{_question}. Round the answer to two decimal places: ex. 0.18");
        
    }

    public override string GetAnswer(){
    Console.Write("\b");
    Console.WriteLine($"Answer the following question, please remember to round the answer to two decimal places: \n {_question}:");
    string yourAnswer = Console.ReadLine();
    float Answer = float.Parse(yourAnswer);
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