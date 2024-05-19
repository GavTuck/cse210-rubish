using System;
using System.IO;
class Journal{





    public void LoadJournal()
    {
        
        Console.WriteLine("Please enter filename ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }  





    } 

    public void SaveFile(List<Entry> NewEntries){
        Console.WriteLine("Enter a filename: ");
        string filename = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(filename, true)){
            foreach(Entry NewEntry in NewEntries)
                outputFile.WriteLine(NewEntry.Display(NewEntry));
        }
        NewEntries.Clear();


    }

    public void DisplayAllEntries(List<Entry> NewEntries){

        foreach(Entry NewEntry in NewEntries)
                Console.WriteLine(NewEntry.Display(NewEntry));
    }
}


