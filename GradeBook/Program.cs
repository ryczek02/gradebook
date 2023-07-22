using System;
using GradeBook.UserInterfaces;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            StartingUserInterface.CommandLoop();
            
            Console.WriteLine("Stop!");
            Console.Read();
        }
    }
}