using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flyweight.Clases;


namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable de apoyo
            int i = 0;

            //La listas nos van a servir para tener a los diferentes Flyweight 
            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapida = new List<int>();

            //Creamos una instancia
            Factory flywf = new Factory();

            //Adicionamos las recetas a las diferentes listas
            i = flywf.Adiciona("Hamburguesa");
            Americana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Cheese");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Menestron");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Antipasto");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Tacos al pastor");
            Italiana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Coditos");
            Mexicana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Nopales");
            Mexicana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);

            //Mostramos y llevamos a cabo el proceso en la comida rapida
            foreach (int n in Rapida)
            {
                Recetas recetas = (Recetas)flywf[n];
                recetas.CalculaCosto();
                recetas.Mostrar();
            }
            Console.WriteLine("-----------");

            //Mostramos la Americana
            foreach (int n in Americana)
            {
                Recetas recetas = (Recetas)flywf[n];

                recetas.CalculaCosto();
                recetas.Mostrar();
            }
            Console.WriteLine("-------");

            //Mostramos y llevamos a cabo proceso de las ensaladas
            foreach (int n in Ensaladas)
            {
                Recetas recetas = (Recetas)flywf[n];
                recetas.CalculaCosto();
                recetas.Mostrar();
            }
            Console.WriteLine("-------");
                
   
            Console.ReadKey();



        }

    }
}
