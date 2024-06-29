public abstract class Goal{
    protected string _goalName;
    protected string _description;
    protected int _points;
    

    public Goal(string goalName, string description, int points){
        _goalName = goalName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract void DisplayGoal();

    public abstract string Save();
    // {
    //     // Console.WriteLine("Enter a filename: ");
    //     // string filename = Console.ReadLine();
    //     // using (StreamWriter outputFile = new StreamWriter(filename, true))
    //     // {
    //     //     foreach (Goal newEntry in _newEntries)
    //     //     {
    //     //     // outputFile.WriteLine(newEntry.DisplayGoal(newEntry));
    //     //     Console.WriteLine("nice job");
    //     //     }
    //     // }
    //     // _newEntries.Clear();

    // }

    public void Load(){
        // Console.WriteLine("Please enter filename ");
        // string filename = Console.ReadLine();
        // string[] lines = System.IO.File.ReadAllLines(filename);

        
               

        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split(',');
        //     string type = parts[0];
        //     string name = parts[1];
        //     string description = parts[2];
        //     int points = Convert.ToInt32(parts[3]);
        //     if (type == "Simple")
        //     {
        //         Simple simple = new Simple(name, description, points);
        //         _newGoals.Add(simple);
        //     }
        //     else if (type == "Eternal")
        //     {
        //         Eternal eternal = new Eternal(name, description, points);
        //         _newGoals.Add(eternal);
        //     }
        //     else if (type == "Checklist")
        //     {
        //         Checklist checklist = new Checklist(name, description, points);
        //         _newGoals.Add(checklist);
        //     }
        //     else 
        //     {
        //         // type = totalpoints;
        //     }
        // }
            
    }
}