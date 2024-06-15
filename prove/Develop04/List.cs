





class List : Activity
{
    string response;
    List<string> responses = new List<string>();

    public List(string newName, string newDescription, int newTime) : base(newName, newDescription, newTime)
    {
        // newName = "List";
        // newDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    List<string> prompts = new List<string>()
    {
        "How did you see the hand of the Lord?",
        "Anything eventful happen?",
        "What are you grateful for?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void ListDisplay()
    {
        int interactions = time/4;
        for (int i = 0; i < interactions; i++)
        {
            // foreach (string temporalString in prompts)
            // {
            //     Console.WriteLine(temporalString);
            //     Thread.Sleep(3000);
            // }

            string response = string.Empty;
            
           
            
                Random rand = new Random();
                int index = rand.Next(prompts.Count);
                Console.WriteLine("The prompt of the day is: " + prompts[index]);
                PauseAnimation(3000);
                Console.Write("Please enter your response: ");
                response = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Response cannot be empty. Please try again.");
                }
                else
                {
                    responses.Add(response);
                    
                }
            
        }

        Console.WriteLine("\nYou entered the following responses:");
        for (int i = 0; i < responses.Count; i++)
        {
            Console.WriteLine("Prompt " + (i + 1) + ": " + prompts[i]);
            Console.WriteLine("Response " + (i + 1) + ": " + responses[i]);
        }
    }
}
            
       