using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_5EjerciciosPropuestos
{
    class Ejercicio3
    {
        NodoLetra Raiz; //Se crea un objeto raiz;

        public Ejercicio3() //Constructor de la clase Arbol
        {
            Raiz = null;
        }
        public void Captura() //Captura los nodos en el arbol
        {
            Insertar(8, "a");
            Insertar(4, "j");
            Insertar(2, "b");
            Insertar(1, "d");
            Insertar(3, "e");
            Insertar(6, "f");
            Insertar(5, "h");
            Insertar(7, "i");
            Insertar(10, "c");
            Insertar(9, "k");
            Insertar(11, "g");
        }
        public void Insertar(int Info, string Letra) //Metodo el cual inserta los datos en el arbol
        {
            NodoLetra Nuevo;
            Nuevo = new NodoLetra();
            Nuevo.Info = Info;
            Nuevo.Letra = Letra;
            Nuevo.Izq = null;
            Nuevo.Der = null;
            if (Raiz == null) //Significa que es el primer dato y lo almacena directamente
            {
                Raiz = Nuevo;
            }
            else //Significa que ya existe almenos un dato en el arbol
            {
                NodoLetra Anterior = null, Recorrido;
                Recorrido = Raiz;
                while (Recorrido != null) //Nos permite localizar el ultimo nodo donde se va almacenar el dato ingresado
                {
                    Anterior = Recorrido;
                    if (Info < Recorrido.Info)
                    {
                        Recorrido = Recorrido.Izq;
                    }
                    else
                    {
                        Recorrido = Recorrido.Der;
                    }
                }
                //Se ingresa el dato dependiendo si es menor o mayor al ultimo dato
                if (Info < Anterior.Info)
                    Anterior.Izq = Nuevo;
                else
                    Anterior.Der = Nuevo;
            }
        }

        private void ImprimirPost(NodoLetra Recorrido) //Metodo recursivo que imprime los datos en PostOrden
        {
            if (Recorrido != null)
            {
                ImprimirPost(Recorrido.Izq);
                ImprimirPost(Recorrido.Der);
                Console.Write(Recorrido.Letra + " ");
            }
        }

        public void ImprimirPost() //Metodo recursivo que imprime los datos en PostOrden
        {
            ImprimirPost(Raiz);
            Console.WriteLine();
        }
    }
}
