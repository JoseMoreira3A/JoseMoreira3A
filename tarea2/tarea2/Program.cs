using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero para formar el cuadrado: ");
            numero = Convert.ToInt32(Console.ReadLine());


            if (numero >= 0 && numero <= 100)
            {
                
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                
                for (int i = 0; i < numero - 2; i++)
                {
                    Console.Write("*");
                    for (int j = 0; j < numero - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }

                
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.WriteLine("Error... El dato ingresado debe "
                        + "estar entre 0 y 100");
            }


            Console.ReadKey();
            
        }
    }
}
