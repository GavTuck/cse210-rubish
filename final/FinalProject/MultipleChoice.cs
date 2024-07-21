public class MultipleChoice : Question
{
    string _answer;
    string _choiceA;
    string _choiceB;
    string _choiceC;
    string _choiceD;
    bool _correct;

    public MultipleChoice(string questionName, string question, string answer, string choiceA, string choiceB, string choiceC, string choiceD) : base(questionName,question)
    {
      _answer = answer;
       _choiceA = choiceA;
       _choiceB = choiceB;
       _choiceC = choiceC;
       _choiceD = choiceD;
    }
    public override string Save(){
        return ($"MultipleChoice,{_questionName},{_question},{_answer},{_choiceA},{_choiceB},{_choiceC},{_choiceD}");
    
    }

    public override void Display(){
        Console.WriteLine($"\n");
        Console.WriteLine($"Multiple Choice {_questionName}:{_question}.\n{_choiceA}\n{_choiceB}\n{_choiceC}\n{_choiceD}");
        
    }

    public override string GetAnswer(){
    Console.Write("\b");
    Console.WriteLine($"Please answer the following multiple choice question: \n {_question}:");
    Console.WriteLine("Here are your following choices:");
    Console.WriteLine($"1. {_choiceA}\n2. {_choiceB}\n3. {_choiceC}\n4. {_choiceD}");
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