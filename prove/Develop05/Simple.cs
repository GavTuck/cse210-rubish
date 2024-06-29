public class Simple : Goal
{
    bool _complete;
    public Simple(string goalName, string description, int points) : base(goalName, description, points)
    {
        _complete = false;
    }
    public override string Save(){
        return ($"Simple,{_goalName},{_description},{_points}");
    }
    public override void DisplayGoal(){
        if (_complete == true){
            Console.WriteLine($"[X]{_goalName}({_description}) and it will give {_points} points");
        }
        else{
            Console.WriteLine($"[ ]{_goalName}({_description}) and it will give {_points} points");
        }
    }
    public override int RecordEvent(){
        _complete = true;
        return _points;
    }

}