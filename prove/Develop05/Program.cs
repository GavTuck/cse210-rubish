using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        int score = 0;
        List<Goal> _newGoals = new List<Goal>();
        string choice = "0";
        
        while (choice != "6")
        {
            Console.WriteLine($"\n You have {score} points \n");
            Console.WriteLine("Please select one of the following choices: \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1"){
               int number = 0;
               Console.WriteLine("\n");
               Console.WriteLine("What type of goal do you want to create? \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
               number = Convert.ToInt32(Console.ReadLine());

               string name;
               string description;
               int points;
        
               switch  (number)
               {
                case 1:
                    Console.WriteLine("What is the name of your goal?");
                     name = Console.ReadLine();
                    Console.WriteLine("What is the description of your goal?");
                     description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                     points = Convert.ToInt32(Console.ReadLine());
                    Simple simple = new Simple(name,description,points);
                    _newGoals.Add(simple);
                    break;
                case 2:
                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the description of your goal?");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    points = Convert.ToInt32(Console.ReadLine());
                    Eternal eternal = new Eternal(name,description,points);
                    _newGoals.Add(eternal);
                    break;
                case 3:
                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the description of your goal?");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    points = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                    int counter = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times?");
                    int bonusPoints = Convert.ToInt32(Console.ReadLine());
                    Checklist checklist = new Checklist(name,description,points,bonusPoints, counter,0);
                    _newGoals.Add(checklist);
                    break;
                default:
                    break;
               }
            }
            else if (choice == "2"){
                foreach(Goal goal in _newGoals){
                    goal.DisplayGoal();
                }
                
            }
            else if(choice == "3"){
                 using (StreamWriter outputFile = new StreamWriter("filename.txt"))
                    {
                        outputFile.WriteLine( $"TotalPoints,{score}");
                        foreach (Goal goal in _newGoals)
                        {
                        goal.Save();
                        outputFile.WriteLine(goal.Save());
                    // outputFile.WriteLine(newEntry.Save(newEntry));
                    // Console.WriteLine("nice job");
                        }
                    }
            
                    
                
            }
            else if(choice == "4"){
                
        string[] lines = System.IO.File.ReadAllLines("filename.txt");

        
               

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            string type = parts[0];
            
            if (type == "Simple")
            {
            string name = parts[1];
            string description = parts[2];
            int points = Convert.ToInt32(parts[3]);

                Simple simple = new Simple(name, description, points);
                _newGoals.Add(simple);
            }
            else if (type == "Eternal")
            {
                // $"Checklist,{_goalName},{_description},{_points}"
                string name = parts[1];
                string description = parts[2];
                int points = Convert.ToInt32(parts[3]);
                Eternal eternal = new Eternal(name, description, points);
                _newGoals.Add(eternal);
            }
            else if (type == "Checklist")
            {
                // $"Checklist,{_goalName},{_description},{_points},{_counter},{_bonus},{_finish}"
                // string goalName, string description, int points, int bonus, int counter
                string name = parts[1];
                string description = parts[2];
                int points = Convert.ToInt32(parts[3]);
                int counter = Convert.ToInt32(parts[4]);
                int bonusPoints = Convert.ToInt32(parts[5]);
                int finish = Convert.ToInt32(parts[6]);

                Checklist checklist = new Checklist(name, description, points, bonusPoints, counter, finish);
                _newGoals.Add(checklist);
            }
            else if(type == "TotalPoints")
            {
                int totalpoints = Convert.ToInt32(parts[1]);
                score = score + totalpoints;
            }
            else 
            {
                // type = totalpoints;
            }
        }
            }
            else if(choice == "5"){
                int index = 0;
                foreach(Goal goal in _newGoals){
                    Console.Write($"{index + 1}. ");
                    index += 1;
                    goal.DisplayGoal();
                }
                Console.WriteLine("Which goal would you like to record an event for?");
                index = Convert.ToInt32(Console.ReadLine());
                int points = _newGoals[index - 1].RecordEvent();
                score = score + points;

                // int score = score + _newGoals[index - 1].Goal points;
                Console.WriteLine($"Your total score is {score}");

            }
            else if(choice == "6"){
                Console.WriteLine("Goodbye");
            }
            else{
                Console.WriteLine("Ops, try again");
            }
        }

    }
}