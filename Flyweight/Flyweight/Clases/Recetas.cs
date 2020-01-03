using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flyweight.Iinterfaces;


namespace Flyweight.Clases
{
    //Implementacion
    class Recetas : Iflyweight
    {
        //Mostrar estado Intrinsecas
        private string nombre;
        //Costo nos va ayudar a calcular nuestro valor en Ventas
        private double costo;
        private double venta;

        //Metodo para calcular costo
        public void CalculaCosto()
        {
            foreach (char letra in nombre)
                costo += (int)letra;

            venta = costo * 1.50;
        }

        //Metodo mostrar
        public void Mostrar()
        {
            Console.WriteLine("{0} cuesta {1}", nombre, venta);
        }

        //Metodo para colocar el Nombre
        public void Nombre(string pNombre)
        {
            nombre = pNombre;
        }

        //Metodo Obtener Nombre
        public string ObtenNombre()
        {
            return nombre;

        }
    }
}
