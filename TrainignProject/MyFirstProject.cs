using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainignProject
{
    internal class MyFirstProject
    {
       
        public static void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine($"Your full name is: {firstName} {lastName}");
        }
    
        public static void Main()
        {
            Console.WriteLine("Enter your firs name please");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your second name, please");
            string secondName = Console.ReadLine();
            PrintFullName(firstName, secondName);
        }
    }



}
