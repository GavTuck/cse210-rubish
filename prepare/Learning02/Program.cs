using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Resume resume1 = new Resume();
        resume1._jobs = new List<Job>();
       

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
       
        resume1.Display();

    }
    
}

        class Job
        {
           public string _company;

           public string _jobTitle;

           public int _startYear;

           public int _endYear;

           public void Display(){
            Console.WriteLine($"{_jobTitle}({_company}) {_startYear}-{_endYear}");


           }



        }

         class Resume
        {
            public string _name;

            public List<Job> _jobs;

            public void Display(){
                Console.WriteLine($"Name: {_name}");

                foreach (Job j in _jobs){

                    j.Display();
                }
            }


        }

        