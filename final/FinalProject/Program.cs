using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        string choice = "0";
         List<Question> _newQuestions = new List<Question>();
        while (choice != "6")
        {
            Console.WriteLine("Please select one of the following choices: \n 1. Create New Question \n 2. Display Questions \n 3. Save Goals \n 4. Load Goals \n 5. Test Your Knowledge \n 6. Quit");
            choice = Console.ReadLine();

            if (choice == "1"){
                int number = 0;
                Console.WriteLine("\n");
                Console.WriteLine("What type of question do you want to create? \n 1. Multiple Choice \n 2. True or False \n 3. Fill Blank \n 4. Math \n 5. Decimal \n 6. Match \n 7. Prompt");
                number = Convert.ToInt32(Console.ReadLine());
                 
                string name;
                string question;
               
            switch  (number)
            {
                case 1:
                    Console.Write("\b");
                    Console.WriteLine("What is the subject of your question?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the question?");
                    question = Console.ReadLine();
                    Console.WriteLine("What is the choice 1?");
                    string choiceA = Console.ReadLine();
                    Console.WriteLine("What is the choice 2?");
                    string choiceB = Console.ReadLine();
                    Console.WriteLine("What is the choice 3?");
                    string choiceC = Console.ReadLine();
                    Console.WriteLine("What is the choice 4?");
                    string choiceD = Console.ReadLine();
                    Console.WriteLine("What is the answer? Choose 1, 2, 3, or 4");
                    string answer = Console.ReadLine();
                    MultipleChoice multiple = new MultipleChoice(name,question,answer,choiceA,choiceB,choiceC,choiceD);
                    _newQuestions.Add(multiple);
                    break;
                case 2:
                    Console.Write("\b");
                    Console.WriteLine("What is the subject of your question?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the question?");
                    question = Console.ReadLine();
                    Console.WriteLine("True or False?");
                    answer = Console.ReadLine();
                    TrueFalse trueFalse = new TrueFalse(name,question,answer);
                    _newQuestions.Add(trueFalse);
                    break;
                case 3:
                    Console.Write("\b");
                    Console.WriteLine("What is the subject of your question?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the question?");
                    question = Console.ReadLine();
                    Console.WriteLine("What is the answer?");
                    answer = Console.ReadLine();
                    FillBlank fillBlank = new FillBlank(name,question,answer);
                    _newQuestions.Add(fillBlank);
                    break;
                case 4:
                    Console.Write("\b");
                    Console.WriteLine("What is the subject of your question?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the question?");
                    question = Console.ReadLine();
                    Console.WriteLine("What is the answer?");
                    answer = Console.ReadLine();
                    int Answer = Convert.ToInt32(answer);
                    Math math = new Math(name,question,Answer);
                    _newQuestions.Add(math);
                    break;
                case 5:
                    Console.Write("\b");
                    Console.WriteLine("What is the subject of your question?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the question?");
                    question = Console.ReadLine();
                    Console.WriteLine("What is the answer?");
                    answer = Console.ReadLine();
                    float aNswer = float.Parse(answer);
                    Decimal decimal1 = new Decimal(name,question,aNswer);
                    _newQuestions.Add(decimal1);
                    break;
                case 6:
                    Console.Write("\b");
                    Console.WriteLine("What is the subject of your question?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the question?");
                    question = Console.ReadLine();
                    Console.WriteLine("What is Option 1?");
                    string answerA = Console.ReadLine();
                    Console.WriteLine("What is its answer?");
                    string choiceA1 = Console.ReadLine();

                    Console.WriteLine("What is Option 2?");
                    string answerB = Console.ReadLine();
                    Console.WriteLine("What is its answer?");
                    string choiceB1 = Console.ReadLine();

                    Console.WriteLine("What is Option 3?");
                    string answerC = Console.ReadLine();
                    Console.WriteLine("What is its answer?");
                    string choiceC1 = Console.ReadLine();

                    Match match = new Match(name,question,answerA,answerB,answerC,choiceA1,choiceB1,choiceC1);
                    _newQuestions.Add(match);
                    break;
                case 7:
                    Console.Write("\b");
                    Console.WriteLine("What is the subject of your question?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the question?");
                    question = Console.ReadLine();
                    Prompt prompt = new Prompt(name,question);
                    _newQuestions.Add(prompt);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
            }
             else if (choice == "2"){
                foreach(Question question in _newQuestions){
                    question.Display();
                }
                
            }
            else if(choice == "3"){
                 using (StreamWriter outputFile = new StreamWriter("test.txt"))
                    {
                       
                        foreach (Question question in _newQuestions)
                        {
                        question.Save();
                        outputFile.WriteLine(question.Save());
                        }
                    }
            }
            else if(choice == "4"){
                
                string[] lines = System.IO.File.ReadAllLines("test.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];
                    
                    if (type == "MultipleChoice")
                    {
                    string name = parts[1];
                    string question = parts[2];
                    string answer = parts[3];
                    string choiceA = parts[4];
                    string choiceB = parts[5];
                    string choiceC = parts[6];
                    string choiceD = parts[7];
                    MultipleChoice multiple = new MultipleChoice(name,question,answer,choiceA,choiceB,choiceC,choiceD);
                    _newQuestions.Add(multiple);
                    }
                    
                    if (type == "True_False")
                    {
                    string name = parts[1];
                    string question = parts[2];
                    string answer = parts[3];
                    TrueFalse trueFalse = new TrueFalse(name,question,answer);
                    _newQuestions.Add(trueFalse);
                    }

                    if (type == "FillBlank")
                    {
                    string name = parts[1];
                    string question = parts[2];
                    string answer = parts[3];
                    FillBlank fillBlank = new FillBlank(name,question,answer);
                    _newQuestions.Add(fillBlank);
                    }

                    if (type == "Math")
                    {
                    string name = parts[1];
                    string question = parts[2];
                    int answer = Convert.ToInt32(parts[3]);
                    Math math = new Math(name,question,answer);
                    _newQuestions.Add(math);
                    }

                    if (type == "Decimal")
                    {
                    string name = parts[1];
                    string question = parts[2];
                    float answer = float.Parse(parts[3]);
                    Decimal decimal1 = new Decimal(name,question,answer);
                    _newQuestions.Add(decimal1);
                    }

                    if (type == "Match")
                    {
                    string name = parts[1];
                    string question = parts[2];
                    string answerA = parts[3];
                    string answerB = parts[4];
                    string answerC = parts[5];
                    string choiceA1 = parts[6];
                    string choiceB1 = parts[7];
                    string choiceC1 = parts[8];
                    Match match = new Match(name,question,answerA,answerB,answerC,choiceA1,choiceB1,choiceC1);
                    _newQuestions.Add(match);
                    }

                    if (type == "Prompt")
                    {
                    string name = parts[1];
                    string question = parts[2];
                    Prompt prompt = new Prompt(name,question);
                    _newQuestions.Add(prompt);
                    }
                }
            }
            else if (choice == "5"){
                int index = 0;
                int score = 0;
                int total = 0;
                foreach(Question question in _newQuestions){
                    Console.Write($"{index + 1}. ");
                    index += 1;
                    string solution = question.GetAnswer();
                    if (solution == "True"){
                        score += 1;
                        total += 1;
                    }
                    else if (solution == "False"){
                        total += 1;
                    }
                }
                Console.WriteLine($"Your total score is {score}/{total}");
             
            }




          
        }
    }
}