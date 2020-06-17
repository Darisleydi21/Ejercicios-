using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = 0;
            int cont = 0;
            int num = 7;

            while(cont<=15)
            {
                res = cont * num;


                Console.WriteLine(num + "x" + cont + "=" + res);
                cont = cont + 1;
            }

            Console.ReadKey();
        }
    }
}
