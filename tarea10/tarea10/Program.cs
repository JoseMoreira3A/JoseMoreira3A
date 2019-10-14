using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea10
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            do
            {

                Console.WriteLine("Escoja una opcion del menu: ");
                Console.WriteLine("*1* Suma: ");
                Console.WriteLine("*2* Factor: ");
                Console.WriteLine("*3* Salir: ");
                

                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Ingrese 2 valores para la suma: ");
                        int numero_1 = Convert.ToInt32(Console.ReadLine());
                        int numero_2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("La suma es {0}: ", numero_1 + numero_2);
                        Console.WriteLine("Enter para continuar: ");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Ingrese un valor para calcular el factorial: ");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        int factorial = valor;
                        for (int i = valor - 1; i >= 1; i--)
                        {
                            factorial = factorial * i;
                        }
                        Console.WriteLine("El factorial de {0} es {1}", valor, factorial);
                        Console.WriteLine("Enter para continuar: ");
                        Console.ReadKey();
                        break;

                    case 3:
                        break;
                }
            } while (menu != 1);
        }
    }
}
