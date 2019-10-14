using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero 100 (para mostrar dos columnas del 100 a 1 & 1 a 100: ");
            int numero = 100;
            numero = Convert.ToInt32(Console.ReadLine());
            //numero = Convert.ToInt64(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.Write(i);
                Console.Write("  ");
                Console.WriteLine((numero + 1) - i);
            }
            Console.ReadKey();
        }
    }
}
