using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite cinco numeros enteros para saber cual es el mayor");
            int[] datos = new int[5];
            int i, mayor = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el valor:  ", (i + 1));
                datos[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (j < 5)
            {
                if (datos[j] > mayor)
                    mayor = datos[j];
                j++;
            }
            Console.WriteLine("El numero mayor es: {0}", mayor);
            Console.ReadKey();
        }
    }
}
