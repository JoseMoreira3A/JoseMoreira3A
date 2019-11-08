using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integre
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("1.- Pila");
            Console.WriteLine("2.- Cola");
            Console.WriteLine("3.- Salir");
        }

        static void Main(string[] args)
        {
            Program.Menu();

            string menu = Console.ReadLine();

            Stack TadPila = new Stack();

            string[] integracion = new string[3];

            Queue TadCola = new Queue();

            switch (menu)
            {
                case "1":
                    Console.WriteLine("Ingresar Letra para TadPila");

                    for (int i = 0; i < 3; i++)
                    {
                        integracion[i] = Console.ReadLine();
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        TadPila.Push(integracion[i]);
                    }

                    Console.WriteLine("\n Resultado:");
                    for (int i = 0; i < 3; i++)
                    {
                        string mensaje = (string) TadPila.Pop();
                        Console.WriteLine(mensaje + " ");
                    }

                    Console.ReadKey();

                    break;

                case "2":
                    Console.WriteLine("Ingresar letra para TadCola");
                    for (int i = 0; i < 3; i++)
                    {
                        integracion[i] = Console.ReadLine();
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        TadCola.Enqueue(integracion[i]);
                    }

                    Console.WriteLine("\n Resultado:");
                    for (int i = 0; i < 3; i++)
                    {
                        string mensaje = (string) TadCola.Dequeue();
                        Console.WriteLine(mensaje + " ");
                    }

                    Console.ReadKey();

                    break;

                default:

                    break;
            }
        }  
    }
}

