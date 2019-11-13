using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEjercicio.Clases
{
    public class Cliente
    {
        public Cliente(string ApellidoNombres, string cedula, string direccion)
        {
            apellidoNombre = ApellidoNombres;
            Cedula = cedula;
            Direccion = direccion;
        }
        public Cliente()
        {

        }

        private string apellidoNombre;

        public string ApellidoNombre
        {
            get { return apellidoNombre; }
            set { apellidoNombre = value; }
        }

        private string cedula;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }


    }
}
    

