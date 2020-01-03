using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Iinterfaces
{
    interface Iflyweight
    {
        //Colocar nombre
        void Nombre(string pNombre);
        //Calcular costo
        void CalculaCosto();
        //Mostrar
        void Mostrar();
        //Obtener Nombre
        string ObtenNombre(); 
    }
}
