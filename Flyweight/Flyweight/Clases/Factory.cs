using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flyweight.Iinterfaces;

namespace Flyweight.Clases
{
    //Clase Fabrica
    class Factory
    {
        //Se utilizo una lista para guardar los objetos
        private List<Iflyweight> Flyweights = new List<Iflyweight>();
        //La variable de apoyo
        private int conteo = 0;

        //Propiedad
        public int Conteo { get => Conteo; set => Conteo = value; }

        //Metodo adiciona, nos ayudara para adicionar nuevas recetas 
        public int Adiciona (string pNombre)
        {
            //verificamos si ya existe

            bool existe = false;
            foreach (Iflyweight f in Flyweights)
            {
                if (f.ObtenNombre() == pNombre)
                    existe = true;
            }
            if (existe)
            {
                Console.WriteLine("El objeto ya existe, no se ha adicionado");
                return -1;
            }
            //Si, si existe creamos una nueva receta
            else
            {
                Recetas miReceta = new Recetas();
                miReceta.Nombre(pNombre);
                Flyweights.Add(miReceta);
                conteo = Flyweights.Count;
                return conteo - 1;
            }
        }
        //Se hace un Indexer para facilitar la sintesis del cliente
        public Iflyweight this[int index]
        {
            get { return Flyweights[index]; }
        }
    }
}
