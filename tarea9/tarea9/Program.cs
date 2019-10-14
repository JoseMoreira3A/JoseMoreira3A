using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero para realizar la tabla de multiplicar: ");
            int multiplicar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            for (int i = 1; i <= 15; i++)
            {
                Convert.ToInt32(multiplicar);
                Console.WriteLine("{0} x {1} = {2}", multiplicar, i, multiplicar * i);
            }
            Console.ReadKey();
        }
    }
}
