using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainignProject
{
    internal class MyFirstProject
    {
        public static void PrintFullName()
        {
            Console.WriteLine("Enter your firs name please");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your second name, please");
            string secondName = Console.ReadLine();
            Console.WriteLine($"The sum age of the couple is: {firstName} {secondName}");
        }
    
        public static void Main()
        {
            PrintFullName();
        }
    }



}
