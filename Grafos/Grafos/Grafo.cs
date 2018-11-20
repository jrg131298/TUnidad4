using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Grafo
    {
        Nodo raiz; //Se crea un objeto raiz;
        class Dato //Clase dato
        {
            public string lugar; //Almacena el camino al dato ingresado
            public int posicionaltura; //Almacena el nivel de cada dato
        }
        List<Dato> weita = new List<Dato>(); //Lista que guarda objetos de la clase Dato

        public Grafo() //Constructor de la clase grafo
        {
            raiz = null;
        }

        public void Insertar(int info, string letra) //Metodo el cual inserta los datos en el grafo
        {
            string Concatenador = ""; //Nos permite guardar la ruta de cada nodo
            int contador = 1; //Contador
            Dato dato = new Dato(); //Se crea un nuevo nodo el cual va a guardar el dato ingresado
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.letra = letra;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null) //Significa que es el primer dato y lo almacena directamente
            {
                raiz = nuevo;
                Concatenador = Convert.ToString(raiz.letra) + "<-";
            }
            else //Significa que ya existe almenos un dato en el grafo
            {
                Nodo anterior = null, recorrido;
                recorrido = raiz;
                while (recorrido != null) //Nos permite localizar el ultimo nodo donde se va almacenar el dato ingresado
                {
                    anterior = recorrido;
                    if (info < recorrido.info)
                    {
                        Concatenador = Concatenador + Convert.ToString(recorrido.letra) + "<-"; //Guarda la direccion
                        recorrido = recorrido.izq;
                    }
                    else
                    {
                        Concatenador = Concatenador + Convert.ToString(recorrido.letra) + "<-"; //Guarda la direccion
                        recorrido = recorrido.der;
                    }
                    contador++;
                }
                //Se ingresa el dato dependiendo si es menor o mayor al ultimo dato
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
                dato.posicionaltura = contador; //Se guarda el nivel que se encuentra el dato
                Concatenador = Concatenador + Convert.ToString(letra); //Se guarda la direccion
                dato.lugar = Concatenador; //Se guarda la direccion
                weita.Add(dato); //Se guarda el objeto dato, en la lista weita
            }
        }

        public void ImpresionWeas()
        {
            foreach (Dato item in weita) //Busca la(s) direccion(es) de el(los) ultimo(s) dato(s) y la(los) imprime
            {
                if (item.posicionaltura == 7)
                {
                    Console.Write(item.lugar + "\n");
                }
            }
        }
    }
}
