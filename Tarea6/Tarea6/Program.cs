using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entero, para el tamaño del rombo: ");
            int valor;

            valor = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= valor; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 0; k < i; k++)
                {
                    
                }
                Console.WriteLine();
            }

            for (int i = valor; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 0; k < i; k++)
                {
                    
                }
                Console.WriteLine();
            }
            

            Console.ReadKey();
        }
    }
}
