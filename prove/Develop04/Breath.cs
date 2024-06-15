class Breath : Activity
{
    public Breath(string newName, string newDiscription, int newTime): base(newName, newDiscription, newTime){
        // newName = "Breathing";
        // newDiscription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
       

    }
    public void BreathingDisplay(){
        int interactions = time / 4;
        for(int i = 0; i < interactions; i++){
        Console.WriteLine(" Breath in");
        BreathAnimation(2000);
        Console.WriteLine(" Breath out");
        BreathAnimation(2000);
        

       
        }
    }
     public void BreathAnimation(int duration){
        List<string> spinnerSymbols = new List<string> {"O","o"};
        DateTime endTime = DateTime.Now.AddMilliseconds(duration);

        while(DateTime.Now < endTime){
            foreach(string symbol in spinnerSymbols)
            {
                Console.Write(symbol);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
        }
    }
}