using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadPila
{
    class Program
    {
        static void Main(string[] args)
        {
            string Leer;

            Stack TadPila = new Stack();

            TadPila.Push("Uno");
            TadPila.Push("Dos");
            TadPila.Push("Tres");
            TadPila.Push("Cuatro");

            for (int i = 0; i < 4; i++)
            {
                Leer = (string)TadPila.Pop();
                Console.WriteLine(Leer + " ");
            }
            Console.ReadKey();
        }
    }
}
