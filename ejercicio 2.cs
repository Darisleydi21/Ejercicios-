using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, i, x = 0;
            string p;

            Console.Write("Introduce un numero: ");
            int.TryParse(Console.ReadLine(), out num);

            if (num <= 1)
            {
                Console.WriteLine("Este numero no esta permitido");
                Console.ReadLine();
            }

            else
            {
                for (i = 2; i < num; i++)
                {

                    if (num % i == 0)
                        x = 0 + 1;
                }

                if (x >= 1)
                    p = "No es primo";
                else
                    p = "Es primo";
                Console.WriteLine("{0}", p);
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
