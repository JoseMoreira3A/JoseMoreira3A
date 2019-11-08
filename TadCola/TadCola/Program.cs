using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadCola
{
    class Program
    {
        static void Main(string[] args)
        {
            string Leer;

            Queue TadCola = new Queue();

            TadCola.Enqueue("Uno");
            TadCola.Enqueue("Dos");
            TadCola.Enqueue("Tres");
            TadCola.Enqueue("Cuatro");

            for (int i = 0; i < 4; i++)
            {
                Leer = (string)TadCola.Dequeue();
                Console.Write(Leer + " ");
            }
            Console.ReadKey();
        }
    }
}
