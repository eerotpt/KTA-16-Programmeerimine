using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Excuses
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] excuses = new[] { "Koer sõi ära", "Ema ei luba" };
           // int i = 1;
            foreach (var excuse in excuses)
            {
                Console.WriteLine($"{i + 1}. {excuses[i]}");

            } 
            Console.ReadLine();

        }
    }
}
