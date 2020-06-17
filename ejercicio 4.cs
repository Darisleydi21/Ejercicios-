using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random d = new Random();
            int num = 0;
            int num3 = 0;
            string num2;

            num = d.Next(50, 100);
            Console.WriteLine("El mumero es: "+ num);

            Console.WriteLine("Si desea otro numero coloque letra p, de no ser asi coloque la letra s: ");
            num2 = Console.ReadLine();

            switch (num2)
            {
                case "s":
                    Console.Write("El programa ha finalizado");
                    break;
                case "p":
                    num3 = d.Next(50, 100);
                    Console.WriteLine("El segundo numero es: " + num3);
                    break;
            }

            Console.ReadKey();
        }
    }
}
