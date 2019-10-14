using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double precio, total = 0;

            do
            {
                do
                {
                    Console.WriteLine("Cantidad vendida: ");
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n < 0)
                    {
                        Console.WriteLine("Cantidad no valida: ");
                    }
                } while (n < 0);
                if (n > 0)
                {
                    Console.WriteLine("Introdusca el precio: ");
                }
                do
                {
                    precio = Convert.ToDouble(Console.ReadLine());
                    if (precio > 0)
                    {
                        Console.WriteLine("Precio no valido: ");
                    }
                    else
                    {
                        total += n * precio;
                    }
                } while (precio < 0);
            } while (n != 0);

            Console.WriteLine("Total: ", +total);

            Console.ReadKey();
        }
    }
}
