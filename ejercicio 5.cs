using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            // Se recorre los números del 1 al 100.
            for (int i = 1; i <= 100; i++)
            {
                // Se convierte el número a string.
                string numero = i.ToString();

                // Se le suma la cantidad de ceros que tiene el número actual
                suma = suma + numero.Count(x => x == '0');
            }

            Console.WriteLine($"Del 1 al 100 hay {suma} ceros.");

            Console.ReadKey();
        }
    }
}
