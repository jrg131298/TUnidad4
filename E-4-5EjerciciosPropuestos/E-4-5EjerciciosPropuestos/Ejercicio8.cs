using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_5EjerciciosPropuestos
{
    class Ejercicio8
    {
        NodoNumero Raiz; //Se crea un objeto raiz;

        public Ejercicio8() //Constructor de la clase Arbol
        {
            Raiz = null;
        }

        public void Captura()
        {
            bool Salir = false; //Nos permite permanecer en el ejercicio
            int Opcion = 0; //Captura la opcion del usuario en el menu
            do
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Ejercicio 8"); //Menu
                    Console.WriteLine("Ingrese el numero de la opcion que desees:");
                    Console.WriteLine("1.- Arbol 1");
                    Console.WriteLine("2.- Arbol 2");
                    Console.WriteLine("0.- Salir");
                    Console.Write("R: ");
                    Opcion = Convert.ToInt32(Console.ReadLine()); //Captura
                    Raiz = null; 
                    if (Opcion == 1) //Permite ejecutar el proceso dependiendo el arbol escogido
                    {
                        Insertar(-1);
                        Insertar(0);
                        Insertar(2);
                        Insertar(-2);
                        Insertar(3);
                        Insertar(6);
                        Insertar(-3);
                        Insertar(5);
                        Insertar(1);
                        Insertar(4);
                        ImprimirEntre();
                        Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                    }
                    else if(Opcion == 2)
                    {
                        Insertar(-1);
                        Insertar(7);
                        Insertar(4);
                        Insertar(11);
                        Insertar(5);
                        Insertar(-8);
                        Insertar(15);
                        Insertar(-3);
                        Insertar(-2);
                        Insertar(6);
                        Insertar(10);
                        Insertar(3);
                        ImprimirEntre();
                        Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                    }
                    else if(Opcion == 0) //Salida del ejercicio
                    {
                        Salir = true;
                    }
                    else //Valor no deseado
                    {
                        Console.WriteLine("A ocurrido un error.\nPrecione una tecla para continuar.");
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
        public void Insertar(int Info) //Metodo el cual inserta los datos en el arbol
        {
            NodoNumero Nuevo;
            Nuevo = new NodoNumero();
            Nuevo.Info = Info;
            Nuevo.Izq = null;
            Nuevo.Der = null;
            if (Raiz == null) //Significa que es el primer dato y lo almacena directamente
            {
                Raiz = Nuevo;
            }
            else //Significa que ya existe almenos un dato en el arbol
            {
                NodoNumero Anterior = null, Recorrido;
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
        private void ImprimirEntre(NodoNumero Recorrido) //Metodo recursivo que imprime los datos en InOrden
        {
            if (Recorrido != null)
            {
                ImprimirEntre(Recorrido.Izq);
                Console.Write(Recorrido.Info + " ");
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
