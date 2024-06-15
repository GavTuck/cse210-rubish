class Reflection : Activity
{  
    string responses = "";
     public Reflection(string newName, string newDiscription, int newTime): base(newName, newDiscription, newTime){
        // newName = "Reflection";
        // newDiscription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        

    // ReflectionDisplay(){
    //     Console.WriteLine("Consider the following prompt:");
    //     Console.WriteLine(prompts[index]);

    }
    List<string> prompts = new List<string>(){
       "Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless.",
    };
    List<string> fallowup = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        
    };

   
    public void ReflectionDisplay(){
        int interactions = time;
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        Console.WriteLine("The prompt of the day is: " + prompts[index] );
        
        foreach(string temporalString in fallowup){
            Console.WriteLine(temporalString);
            PauseAnimation(4000);
        }

        


        }
        // foreach(string response in responses)
        // {
        //     Console.WriteLine(response);
        // }

    
}