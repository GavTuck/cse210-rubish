using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Preach my Gospel", 1, 1);
        Scripture scripture = new Scripture(reference,"invite others to come unto Christ by helping them receive the restored gospel through faith in Jesus Christ and His Atonement, repentance, baptism, receiving the gift of the Holy Ghost, and enduring to the end");
        scripture.Display();
        
        string input = "";

        while(input.ToLower() !="quit"){
            Console.Clear();
            scripture.Display();
            scripture.RandomlyHide();
            
            Console.WriteLine(" ");
            Console.WriteLine("Enter -quit- to exit or press enter to continue or if you want to restart enter -revert-");

            input = Console.ReadLine();
            if(input == "revert"){
                scripture.RevertBack();
            }
        }

    }
}