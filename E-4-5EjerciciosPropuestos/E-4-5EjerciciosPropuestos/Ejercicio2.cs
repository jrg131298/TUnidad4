using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_5EjerciciosPropuestos
{
    class Ejercicio2
    {
        Nodo Raiz; //Creacion del arbol
        double Suma1 = 0, Suma2 = 0; //Resultados de las 2 sumas del programa
        public void Captura()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 1");
            for (int Contador = 1; Contador <= 7; Contador++) //Crea el arbol
            {
                Nodo Nuevo;
                Nuevo = new Nodo();
                Nuevo.CantidadCartas = (Math.Pow(5, Contador) * 2); //Calcula la cantidad de cartas por semana
                Console.WriteLine("Cartas enviada en la semana {0}", Contador);
                Console.WriteLine((Math.Pow(5, Contador) * 2));
                Nuevo.Hijo = null;
                if (Raiz == null) //Significa que es el primer dato y lo almacena directamente
                {
                    Raiz = Nuevo;
                }
                else //Significa que ya existe almenos un dato en el arbol
                {
                    Nodo Anterior = null, Recorrido;
                    Recorrido = Raiz;
                    while (Recorrido != null) //Nos permite localizar el ultimo nodo donde se va almacenar el dato ingresado
                    {
                        Anterior = Recorrido;
                        Recorrido = Recorrido.Hijo;
                    }
                    Anterior.Hijo = Nuevo; //Guarda el nuevo nodo
                }

                Suma1 = Suma1 + (Math.Pow(5, Contador) * 2); //Nos permite sacar la suma total
                if (Contador >= 5) //Suma desde la semana 5 en adelante
                {
                    Suma2 = Suma2 + (Math.Pow(5, Contador) * 2);
                }
            }
        }

        public void Impresion() //Impresion de los resultados
        {
            Console.WriteLine("Cantidad de cartas: {0}", Suma1);
            Console.WriteLine("Cantidad de cartas de las 3 ultimas semanas: {0}", Suma2);
        }
    }
}
