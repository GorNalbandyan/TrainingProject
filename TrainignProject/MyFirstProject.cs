using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainignProject
{
    internal class MyFirstProject
    {
        
    
        public static void Main()
        {
            Console.WriteLine("Enter your age please");
            int myAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your spouse's age please");  
            int spouseAge = Convert.ToInt32(Console.ReadLine());
            int sum = myAge + spouseAge;

            Console.WriteLine($"The sum age of the couple is: {sum}");
        }
    }


}
