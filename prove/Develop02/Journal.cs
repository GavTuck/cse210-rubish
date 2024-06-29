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

    public void SaveFile(List<Entry> _newEntries){
        Console.WriteLine("Enter a filename: ");
        string filename = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(filename, true))//True will append the new data
        {
            foreach(Entry _newEntry in _newEntries)
                outputFile.WriteLine(_newEntry.Display(_newEntry));
        }
        _newEntries.Clear();


    }
    public void ClearFile(){
        Console.WriteLine("Please enter filename ");
        string filename = Console.ReadLine();
        File.WriteAllText(filename, string.Empty);
    }

    public void DisplayAllEntries(List<Entry> NewEntries){

        foreach(Entry NewEntry in NewEntries)
                Console.WriteLine(NewEntry.Display(NewEntry));
    }
}


