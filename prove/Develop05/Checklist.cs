public class Checklist : Goal
{
    int _bonus;
    int _counter;
    int _finish;
    public Checklist(string goalName, string description, int points, int bonus, int counter, int finish) : base(goalName, description, points)
    {
        _counter = counter;
        _bonus = bonus;
        _finish = finish;
    }
    public override string Save(){
   
    
        return ($"Checklist,{_goalName},{_description},{_points},{_counter},{_bonus},{_finish}");

        
       
    //     // string filename = Console.ReadLine();
    }
   
    public override int RecordEvent(){
        _finish = _finish + 1;
        if (_finish == _counter){
            return _bonus;
        }
        return _points;
        }   

    public override void DisplayGoal(){
        Console.WriteLine($"[] {_goalName}({_description}) - Currently Completed {_finish}/{_counter}");
    }
}