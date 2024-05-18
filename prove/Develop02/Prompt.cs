using System;
// using System.Collections.randomGenerator

class Prompt
{
    
    
    List<string> prompts = new List<string>(){
        "How did you see the hand of the Lord",
        "Anything eventful happen",
        "What are you greateful for",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };
    


    public string RandomPrompt(){

        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        Console.WriteLine("The prompt of the day is: " + prompts[index] );

        return prompts[index];

    }

    
    
    
    
}