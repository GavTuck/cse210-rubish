class Journal{

List<string>  = new List<string>()




    public void LoadJournal{
        
        
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string prompt = parts[0];
            string response = parts[1];
        }  





    } 
}


}