public class TrueFalse : Question
{
    string _answer;
    bool _correct;

       
    public TrueFalse(string questionName, string question, string answer) : base(questionName,question)
    {
       _correct = true;
       _answer = answer;
    }
    public override string Save(){
   
    
        return ($"True_False,{_questionName},{_question},{_answer}");

        
       
    //     // string filename = Console.ReadLine();
    }
   
 

    public override void Display(){
        Console.WriteLine($"\n");
        Console.WriteLine($"True(1) or False(2) {_questionName}:{_question}");
        
    }
    public override string GetAnswer(){
    Console.Write("\b");
    Console.WriteLine($"Is the following statement true(1) or false(2): \n {_question}:");
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