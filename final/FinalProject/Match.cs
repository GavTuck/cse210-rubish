public class Match : Question
{
    string _answer;
    string _answerA;
    string _answerB;
    string _answerC;
    string _choiceA;
    string _choiceB;
    string _choiceC;
    bool _correct;
    
   

    public Match(string questionName, string question, string answerA, string answerB, string answerC, string choiceA, string choiceB, string choiceC): base(questionName,question)
    {
      _answerA = answerA;
      _answerB = answerB;
      _answerC = answerC;
      _choiceA = choiceA;
      _choiceB = choiceB;
      _choiceC = choiceC;
    
      
    }
    public override string Save(){
        return ($"Match,{_questionName},{_question},{_answerA},{_answerB},{_answerC},{_choiceA},{_choiceB},{_choiceC}");
    
    }

    public override void Display(){
        Console.WriteLine($"\n");
        Console.WriteLine($"Match {_questionName}:{_question}.");
        Console.WriteLine($"{_choiceA}\n{_choiceB}\n{_choiceC}");
        Console.WriteLine($"{_answerA}\n{_answerB}\n{_answerC}");
    }

    public override string GetAnswer(){
    Console.Write("\b");
    Console.WriteLine($"{_questionName}:");
    Console.WriteLine($"Match:{_question}.");

    Console.WriteLine($"What choice works best with {_choiceA}.Please enter 1,2 or 3");
    string _responseA = Console.ReadLine();
    Console.WriteLine($"What choice works best with {_choiceB}.Please enter 1,2 or 3");
    string _responseB = Console.ReadLine();
    Console.WriteLine($"What choice works best with {_choiceC}.Please enter 1,2 or 3");
    string _responseC = Console.ReadLine();
    
    if (_responseA == "2")
    {
       if (_responseB == "1")
       {
        if (_responseC == "3")
        {   
            _correct = true;
            Console.WriteLine("Correct!");
        }
        else
        {
            _correct = false;
            Console.WriteLine("Incorrect :(");
        }
       }
       else
       {
        _correct = false;
        Console.WriteLine("Incorrect :(");
       }
    }
    else{
        _correct = false;
        Console.WriteLine("Incorrect :(");
    }

    
    
    return (_answer);
    }

}