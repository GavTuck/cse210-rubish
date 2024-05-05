using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");


        static void Main(){
             DisplayWelcome();
            
            string intro = PromptUserName();

            int user_number = PromptUserNumber();

            int sqr_user_number = SquareNumber(int user_number);

            DisplayResult(string intro ,int sqr_user_number);





        }
        
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the program!");
        }

        static void PromptUserName(){
            Consule.WriteLine("Please enter your name:");
            string name = Read.Consule();

            return name
        }

        static void PromptUserNumber(){
            Consule.WriteLine("Please enter your favorite number:");
            int number = Read.Consule();

            return number
        }

        static void SquareNumber(int number){
            int sqr = number * number;
            return sqr;
        }
        static void DisplayResult(string name, int sqr){
            Consule.WriteLine($"{name}, the square of your number is {sqr} ")

        }
        }

    }
}