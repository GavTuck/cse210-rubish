using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Course course1 = new();
        course1._classCode = "CSE 210";
        course1._calssName = "Programing with Classes";
        course1._credits = 2;
        course1._color = "green";

        //methods

        course1.Display();




    }
}