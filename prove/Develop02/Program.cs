using System;
using System.IO;
using System.Numerics;

class Program
{
    static public Journal _workPlz = new Journal();
    static void Main(string[] args)
    {
        List<Entry> _newEntries = new List<Entry>();
        string choice = "0";
        Console.WriteLine("Lets gooooooo!!!");
        while (choice != "6")
        {
            Console.WriteLine("Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Clear \n 6. Quit");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1"){
                Entry _newEntry = new Entry();
                _newEntry = _newEntry.CreateEntry();
                _newEntries.Add(_newEntry);
            }
            else if (choice == "2"){
                _workPlz.DisplayAllEntries(_newEntries);
            }
            else if(choice == "3"){
                _workPlz.LoadJournal();
            }
            else if(choice == "4"){
                _workPlz.SaveFile(_newEntries);
            }
            else if(choice == "5"){
                _workPlz.ClearFile();
            }
            else if(choice == "6"){
                Console.WriteLine("Goodbye");
            }
            else{
                Console.WriteLine("Ops, try again");
            }
        }

        
        

        
        // Console.WriteLine("Hello Develop02 World!");
    }
}