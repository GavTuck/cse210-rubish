

using System;
using System.IO;

class Entry
{
    string new_time;
    string new_response;
    string new_prompt;

    public Entry CreateEntry()
    {
        Entry newEntry = new Entry();
        // outputFile.WriteLine("What is the date today? ");
        // string date = Console.ReadLine();

        // outputFile.WriteLine("Title: ");
        // string title = Console.ReadLine();
        DateTime time = DateTime.Now;
        Prompt prompt = new Prompt();
        string promptText = prompt.RandomPrompt();
        Console.WriteLine(promptText);

        Console.Write("Your entry: ");
        string response = Console.ReadLine();

        // string dateText = theCurrentTime.ToShortDateString();

        newEntry.new_time = time.ToString();
        newEntry.new_response = response;
        newEntry.new_prompt = promptText;
        Console.WriteLine("\nHere's your new journal entry:  \n");
        string result = newEntry.Display(newEntry);

        return newEntry;
    }

    public string Display(Entry newEntry)
    {
        // string new_time = newEntry.new_time;
        // string new_response;
        // string new_prompt;
        string text = $"Date: {new_time} - Prompt: {new_prompt} \n Response: {new_response}";
        return text;
    }
}
