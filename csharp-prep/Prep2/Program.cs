using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?")
        
        string grade = Conole.ReadLine();
        int num = int.Parse(grade);
        if (grade >= 90)

        string letter ="";
        {
            string letter = "A";
        }
        else if (grade >= 80)
        {
            string letter = "B";
        }
        else if (grade >= 70)
        {
            string letter = "C";
        }
        else if (grade >= 60)
        {
            string letter = "D";
        }
        else
        {
            string letter = "F";
        }
        
        Consule.WriteLine($"Your grade in the class was a {letter}")
        
        if (grade >= 70)
        {
            Consule.WriteLine("You passed");
        }
        else
        {
            Consule.WriteLine("You failed, you suck");
        }
    }
}