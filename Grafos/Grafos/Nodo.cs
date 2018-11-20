using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Nodo //Clase nodo
    {
        public int info; //Guarda el valor que toma el nodo
        public string letra;
        public Nodo izq, der; //Dos punteros
    }
}