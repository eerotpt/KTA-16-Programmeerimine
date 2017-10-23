using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sisestus;
            Console.WriteLine("Mina olen papagoi programm.Ütle mulle midagi ja ma kordan selle sulle tagasi...");
            Console.Write(Environment.NewLine);
            Console.Write("Sina ütled: ");
            sisestus = Console.ReadLine();
            Console.Write("Mina ütlen: ");
            Console.WriteLine(sisestus);
            Console.ReadLine();

        }
    }
}
