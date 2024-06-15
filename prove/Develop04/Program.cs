using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int time = 0;
        Console.WriteLine("Hello Develop04 World!");
        // Activity activity = new Activity("Welcome", "Welcome", 5);
        // activity.PauseAnimation(10000);
        Console.WriteLine("Which activity would you like to do?");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Quit");
        choice =Console.ReadLine();
        if(choice == "1"){
            Breath breath = new Breath("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", time);

            breath.GetDuration();
            breath.Display();
            breath.PauseAnimation(5000);
            breath.BreathingDisplay();
            breath.ExitDisplay();
        }
        else if(choice == "2"){
            
            Reflection reflection = new Reflection("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",time);
            reflection.GetDuration();
            reflection.PauseAnimation(5000);
            reflection.Display();
            reflection.ReflectionDisplay();
            reflection.ExitDisplay();
        }
        else if(choice == "3"){
            List list = new List("List", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", time);
            list.GetDuration();
            list.PauseAnimation(5000);
            list.Display();
            list.ListDisplay();
            list.ExitDisplay();
        }
        else if(choice == "4"){
            Console.WriteLine("Goodbye");
            Environment.Exit(0);
        }
    }

    
}