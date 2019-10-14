using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero, para el tamaño de la piramide: ");
            int valor;

            valor = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i <= valor; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
