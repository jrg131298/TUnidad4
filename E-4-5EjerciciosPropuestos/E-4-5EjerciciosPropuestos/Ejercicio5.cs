using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_5EjerciciosPropuestos
{
    class Ejercicio5
    {
        NodoLetra Raiz; //Se crea un objeto raiz;
        List<Dato> Weita = new List<Dato>(); //Lista que guarda objetos de la clase Dato

        public Ejercicio5() //Constructor de la clase Arbol
        {
            Raiz = null;
        }
        public void Captura()
        {
            Insertar(4, "enologia");
            Insertar(3, "campanologia");
            Insertar(1, "alquimia");
            Insertar(2, "astrologia");
            Insertar(5, "frenologia");
            Insertar(8, "ornitologia");
            Insertar(6, "ictiologia");
            Insertar(7, "limnologia");
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
        public void Busqueda(string Palabra) //Nos permite buscar la palabra en el arbol
        {
            bool Encontrado = false;
            foreach (var Item in Weita)
            {
                if (Item.Letra == Palabra)
                {
                    Console.WriteLine("\nDato encontrado.");
                    Console.WriteLine("Palabra: {0}", Item.Letra);
                    Console.WriteLine("Ruta: {0}", Item.Lugar);
                    Encontrado = true;
                }
            }

            if (Encontrado == false)
            {
                Console.WriteLine("Dato no encontrado.");
            }
        }
        public void Consulta()
        {
            bool Salir = false;
            string Palabra;
            do
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Ejercicio 5");
                    ImprimirEntre();
                    Console.WriteLine("\nIngresa la palabra que se desea buscar:");
                    Console.WriteLine("(Preciona 0 para salir)");
                    Console.Write("R: ");
                    Palabra = Console.ReadLine();

                    if (Palabra == "0") //Nos permite salir del ejercicio
                    {
                        Salir = true;
                    }
                    else if (Palabra == "") //Significa que no se escribio nada
                    {
                        Console.WriteLine("A ocurrido un error.\nPrecione una tecla para continuar.");
                        Console.ReadKey();
                    }
                    else //Significa que se buscara la palabra en el arbol
                    {
                        Busqueda(Palabra);
                        Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                    }
                }
                catch
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
