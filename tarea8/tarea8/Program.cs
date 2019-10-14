using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            int segunda_c = 0;
            int tercera_c = 0;

            Console.WriteLine(" ");
            for (int i = 1; i <= valor; i++)
            {

                Console.Write(i);
                Console.Write(" ");
                segunda_c = segunda_c + 2;
                if (segunda_c > valor)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(segunda_c);
                }
                Console.Write("  ");
                tercera_c = tercera_c + 3;
                if (tercera_c > valor)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(tercera_c);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
