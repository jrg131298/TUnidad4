using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_5EjerciciosPropuestos
{
    class Ejercicio7
    {
        NodoLetra Raiz; //Se crea un objeto raiz;
        List<Dato> Weita = new List<Dato>(); //Lista que guarda objetos de la clase Dato

        public Ejercicio7() //Constructor de la clase Arbol
        {
            Raiz = null;
        }

        public void Captura() //Ingresar datos al arbol
        {
            Insertar(6, "Raiz");
            Insertar(4, "Lol");
            Insertar(5, "i");
            Insertar(2, "Lol");
            Insertar(1, "a");
            Insertar(3, "e");
            Insertar(7, "Lol");
            Insertar(11, "Lol");
            Insertar(9, "Lol");
            Insertar(8, "k");
            Insertar(10, "o");
            Insertar(12, "Lol");
            Insertar(14, "Lol");
            Insertar(13, "p");
            Insertar(15, "u");

            Impresion();
        }
        public void Insertar(int Info, string Letra) //Metodo el cual inserta los datos en el arbol
        {
            string Concatenador = ""; //Nos permite guardar la ruta de cada nodo
            Dato Dato = new Dato(); //Se crea un nuevo nodo el cual va a guardar el dato ingresado
            NodoLetra Nuevo;
            Nuevo = new NodoLetra();
            Nuevo.Info = Info;
            Nuevo.Letra = Letra;
            Nuevo.Izq = null;
            Nuevo.Der = null;
            if (Raiz == null) //Significa que es el primer dato y lo almacena directamente
            {
                Raiz = Nuevo;
                Concatenador =  "Raiz<-";
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
                        Concatenador = Concatenador + "0<-"; //Guarda la direccion
                        Recorrido = Recorrido.Izq;
                    }
                    else
                    {
                        Concatenador = Concatenador + "1<-"; //Guarda la direccion
                        Recorrido = Recorrido.Der;
                    }
                }
                //Se ingresa el dato dependiendo si es menor o mayor al ultimo dato
                if (Info < Anterior.Info)
                    Anterior.Izq = Nuevo;
                else
                    Anterior.Der = Nuevo;
                Concatenador = Concatenador + Convert.ToString(Letra); //Se guarda la direccion
            }
            Dato.Lugar = Concatenador; //Se guarda la direccion
            Dato.Letra = Letra; //Se guarda la letra ingresada
            Weita.Add(Dato); //Se guarda el objeto dato, en la lista weita
        }

        public void Impresion() //Imprime los resultados
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 7");
            foreach (Dato Item in Weita)
            {
                if(Item.Letra != "Lol" && Item.Letra != "Raiz")
                {
                    Console.WriteLine(Item.Lugar);
                }
            }
        }
    }
}
