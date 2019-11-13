using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaEjercicio.Clases;

namespace TareaEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura();

            Cliente cliente = new Cliente();
            Console.WriteLine("Ingresar nombres y apellidos :");
            cliente.ApellidoNombre = Console.ReadLine();
            Console.WriteLine("Ingresar numero de cedula o pasaporte :");
            cliente.Cedula = Console.ReadLine();
            Console.WriteLine("Ingrese su Direccion :");
            cliente.Direccion = Console.ReadLine();
            Gasolina gasolina = new Gasolina();
            Program.Gasolina();

            int menu = Convert.ToInt16(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    gasolina.Tipo = "Extra";
                    gasolina.Precio = 1.50;
                    break;

                case 2:
                    gasolina.Tipo = "Super";
                    gasolina.Precio = 2.00;
                    break;

                default:
                    Console.WriteLine("Ingrese un valor correcto");
                    break;
            }

            Console.WriteLine("Ingresar cantidad a comprar de galones de gasolina :");
            gasolina.CantidadGalones = Convert.ToInt16(Console.ReadLine());
            factura.Subtotal = gasolina.Precio * gasolina.CantidadGalones;

            Console.Write("Nombre: {0}", cliente.ApellidoNombre);
            Console.WriteLine("\t\t\t Cedula: {0}", cliente.Cedula);
            Console.WriteLine("Direccion: {0}", cliente.Direccion);
            Console.WriteLine("Tipo \t\t\t Cantidad De Galones \t\t\t Precio De Venta");
            Console.Write(gasolina.Tipo + "\t\t\t\t");
            Console.Write(gasolina.CantidadGalones + "\t\t\t\t\t");
            Console.WriteLine(gasolina.Precio);
            Console.WriteLine("\t\t\t\t\t\t\t Subtotal: {0}", gasolina.CantidadGalones * gasolina.Precio);
            Console.WriteLine("\t\t\t\t\t\t\t IVA: {0}", factura.IVA);
            Console.WriteLine("\t\t\t\t\t\t\t Total: {0}", factura.Total);

            Console.ReadKey();
        }

        static void Gasolina()
        {
            Console.WriteLine("¿Que gasolina desea comprar?");
            Console.WriteLine("1.- Extra : $1.50");
            Console.WriteLine("2.- Super :$2.00");
        }
    }
    
}
