public class Prompt : Question
{
   bool _correct;
   
   

    public Prompt(string questionName, string question): base(questionName,question)
    {
      
      
    }
    public override string Save(){
        return ($"Prompt,{_questionName},{_question}");
    
    }

    public override void Display(){
        Console.WriteLine($"\n");
        Console.WriteLine($"Prompt {_questionName}:{_question}.");
       
    }
    public override string GetAnswer(){
    
    _correct = true;
    Console.Write("\b");
    Console.WriteLine($"Prompt:{_question}");
    Console.WriteLine($" Please answer this prompt:");
    Console.ReadLine();
    Console.WriteLine("Good work!");
    return (_correct.ToString());
    }
        
}