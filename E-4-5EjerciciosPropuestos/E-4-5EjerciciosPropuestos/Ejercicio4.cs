using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_5EjerciciosPropuestos
{
    class Ejercicio4
    {
        NodoLetra Raiz; //Se crea un objeto raiz;
        List<Dato> Weita = new List<Dato>(); //Lista que guarda objetos de la clase Dato

        public Ejercicio4() //Constructor de la clase Arbol
        {
            Raiz = null;
        }
        public void Captura()
        {
            Insertar(1, "banana");
            Insertar(6, "melocoton");
            Insertar(5, "Manzana");
            Insertar(3, "coco");
            Insertar(4, "mango");
            Insertar(8, "pera");
            Insertar(7, "papaya");
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
                Concatenador = Convert.ToString(Raiz.Letra);
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
                        Concatenador = Concatenador + Convert.ToString(Recorrido.Letra) + "<-"; ;//Guarda la direccion
                        Recorrido = Recorrido.Izq;
                    }
                    else
                    {
                        Concatenador = Concatenador + Convert.ToString(Recorrido.Letra) + "<-";//Guarda la direccion
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
        public void Busqueda(string Palabra) //Metodo que nos permite buscar un elemento en el arbol
        {
            bool Encontrado = false;
            foreach(var Item in Weita)
            {
                if(Item.Letra == Palabra)
                {
                    Console.WriteLine("\nDato encontrado.");
                    Console.WriteLine("Palabra: {0}", Item.Letra);
                    Console.WriteLine("Ruta: {0}", Item.Lugar);
                    Encontrado = true;
                }
            }

            if(Encontrado == false)
            {
                Console.WriteLine("Dato no encontrado.");
            }
        }
        public void Consulta()
        {
            bool Salir = false; //Nos permite permanecer en el ejercicio
            string Palabra; //Palabra a buscar
            do
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Ejercicio 4");
                    ImprimirEntre(); 
                    Console.WriteLine("\nIngresa la palabra que se desea buscar:");
                    Console.WriteLine("(Preciona 0 para salir)");
                    Console.Write("R: ");
                    Palabra = Console.ReadLine(); //Captura la palabra a buscar

                    if(Palabra == "0") //Significa que se quiere salir del ejercicio
                    {
                        Salir = true;
                    }
                    else if(Palabra == "") //Significa que no se escribio nada
                    {
                        Console.WriteLine("A ocurrido un error.\nPrecione una tecla para continuar.");
                        Console.ReadKey();
                    }
                    else //Significa que se va a buscar el dato ingresado
                    {
                        Busqueda(Palabra);
                        Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                    }
                }
                catch //Captura de excepciones
                {
                    Console.WriteLine("A ocurrido un error.\nPrecione una tecla para continuar.");
                    Console.ReadKey();
                }
            } while (Salir == false);
        }

        private void ImprimirEntre(NodoLetra Recorrido) //Metodo recursivo que imprime los datos en InOrden
        {
            if (Recorrido != null)
            {
                ImprimirEntre(Recorrido.Izq);
                Console.Write(Recorrido.Letra + " ");
                ImprimirEntre(Recorrido.Der);
            }
        }
        public void ImprimirEntre()//Metodo recursivo que imprime los datos en InOrden
        {
            Console.WriteLine("\nInOrden");
            ImprimirEntre(Raiz);
            Console.WriteLine();
        }
    }
}
