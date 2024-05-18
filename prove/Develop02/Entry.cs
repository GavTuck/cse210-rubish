using System;
using System.IO;



class Entry
{

    

  string date;
  string title;
  string response;

  string fileName ="testFile.txt";

    public void CreateEntry(){
        
        using(StreamWriter outputFile = new StreamWriter(fileName)){
            
            
            // outputFile.WriteLine("What is the date today? ");
            // string date = Console.ReadLine();

            // outputFile.WriteLine("Title: ");
            // string title = Console.ReadLine();

            Prompt prompt = new Prompt();
            
            outputFile.WriteLine(prompt.RandomPrompt());
           
            outputFile.Write("Your entry: ");
            string response = Console.ReadLine();
            DateTime rightNow = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            Entry newEntry = new Entry();
            newEntry._entrydateTime = new_time;
            newEntry._response = new_response;
            newEntry.prompt = new_prompt;
            WriteLine("\nHeres your new journal entry:  \n");
            newEntry.Display();

            return newEntry;
        }
        
      static void Disply(){
            Console.WriteLine($"Date{new_time}     -Prompt{new_prompt} \n Response: {new_response}");


      }
       



     }
    
    
    


}