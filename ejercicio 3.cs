using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int dig;

            Console.Write("Inserte numero positivo para saber cantidad de digitos: ");
            int num = Convert.ToInt32(Console.ReadLine());

            dig = num.ToString().Length;

            Console.WriteLine("El numero insertado tiene {0} digitos", dig);

            Console.ReadKey();

        }
    }
}
