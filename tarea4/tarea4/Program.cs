using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            int horas = 0;
            int total_pagar = 0;
            //int precio_extra = 22;

            //int horas, salario;

            do
            {
                Console.Write("Horas trabajadas: ");
                horas = Convert.ToInt32(Console.ReadLine());

                if (horas <= 35)
                {
                    total_pagar = horas * 15;
                    
                }
                else
                {
                    total_pagar = ((35 * 15) + (horas - 35) * 22);
                    
                }
                Console.WriteLine("Cantidad a pagar: " + total_pagar);
                Console.WriteLine("Desea calcular otro salario: (s/n)");
                respuesta = Convert.ToChar(Console.ReadLine());
            } while (respuesta != 's' && respuesta != 'S');
        }
    }
}
