public class Eternal : Goal
{
    int _counter;
    public Eternal(string goalName, string description, int points) : base(goalName, description, points)
    {
        _counter = 0;
    }
     public override string Save(){
  
    
   return( $"Checklist,{_goalName},{_description},{_points}");

    }
    public override int RecordEvent()
    {
        return _points;
    }

    public override void DisplayGoal(){
        Console.WriteLine($"[] {_goalName}({_description})");
    }
}