using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEjercicio.Clases
{
    public class Gasolina
    {
        public Gasolina(string tipo, int cantidadGalones, double precio)
        {
            Tipo = tipo;
            CantidadGalones = cantidadGalones;
            Precio = precio;
        }

        public Gasolina()
        {
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private double precio;

        public double Precio
        {
            get
            {
                return precio;
            }
            set { precio = value; }
        }

        private double cantidadGalones;

        public double CantidadGalones
        {
            get { return cantidadGalones; }
            set { cantidadGalones = value; }
        }

        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }


    }
}
