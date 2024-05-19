using System;
using System.IO;
using System.Numerics;

class Program
{
    static public Journal work_plz = new Journal();
    static void Main(string[] args)
    {
        List<Entry> NewEntries = new List<Entry>();
        string choice = "0";
        Console.WriteLine("Lets gooooooo!!!");
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5.Quit");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1"){
                Entry NewEntry = new Entry();
                NewEntry = NewEntry.CreateEntry();
                NewEntries.Add(NewEntry);
            }
            else if (choice == "2"){
                work_plz.DisplayAllEntries(NewEntries);
            }
            else if(choice == "3"){
                work_plz.LoadJournal();
            }
            else if(choice == "4"){
                work_plz.SaveFile(NewEntries);
            }
            else if(choice == "5"){
                Console.WriteLine("Goodbye");
            }
            else{
                Console.WriteLine("Ops, try again");
            }
        }

        
        

        
        // Console.WriteLine("Hello Develop02 World!");
    }
}