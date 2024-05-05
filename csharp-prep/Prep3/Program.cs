using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random()
        int number = randomGenerator.Next(1,100)
        
        
       
        
        while (response != number)
        {
            Console.WriteLine("What is your guess");
            response = int.Parse(Consule.ReadLine())
        }
        if (response >= number)
        {
            Consule.WriteLine("Higher")
        }
        else if (number >= response)
        {
            Consule.WriteLine("Lower")
        }

    
    
    }
}