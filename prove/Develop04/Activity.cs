class Activity{
    //Atributes
    protected int time;
    protected string discription;
    protected string _activityName;

    public Activity(string newName, string newDiscription, int newTime)
    {
        _activityName = newName;
        discription = newDiscription;
        time = newTime;
    }

    public void Display(){  
        Console.WriteLine($"Welcome to the {_activityName} activity\n ");
        Console.WriteLine($"{discription}");

    } 
    public void PauseAnimation(int duration){
        List<string> spinnerSymbols = new List<string> {"|","/","-","\\"};
        DateTime endTime = DateTime.Now.AddMilliseconds(duration);

        while(DateTime.Now < endTime){
            foreach(string symbol in spinnerSymbols)
            {
                Console.Write(symbol);
                Thread.Sleep(50);
                Console.Write("\b");
            }
        }

    }  
    public void GetDuration(){
        Console.WriteLine("How long, in seconds, would you like for your session?");
        time = int.Parse(Console.ReadLine());
    }

    
    public void ExitDisplay(){
        Console.WriteLine($"You just finised the {_activityName} activity");
        Console.WriteLine("Please choose another activity");}

}