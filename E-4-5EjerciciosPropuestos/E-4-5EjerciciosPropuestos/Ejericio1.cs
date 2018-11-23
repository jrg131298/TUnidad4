using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_5EjerciciosPropuestos
{
    class Ejericio1
    {
        NodoLetra Raiz; //Se crea un objeto raiz;
        List<Dato> Weita = new List<Dato>(); //Lista que guarda objetos de la clase Dato
        public int Altura; //Variable que guardara el valor de la altura del arbol
        public Ejericio1() //Constructor de la clase Arbol
        {
            Raiz = null;
        }
        public void Captura() //Ingresar valores en el arbol
        {
            Insertar(18, "Partido 24");
            Insertar(2, "Partido 22");
            Insertar(1, "Jugador 1");
            Insertar(10, "Partido 19");
            Insertar(6, "Partido 13");
            Insertar(4, "Partido 1");
            Insertar(3, "Jugador 2");
            Insertar(5, "Jugador 3");
            Insertar(8, "Partido 2");
            Insertar(7, "Jugador 4");
            Insertar(9, "Jugador 5");
            Insertar(14, "Partido 14");
            Insertar(12, "Partido 3");
            Insertar(11, "Jugador 6");
            Insertar(13, "Jugador 7");
            Insertar(16, "Partido 4");
            Insertar(15, "Jugador 8");
            Insertar(17, "Jugador 9");
            Insertar(34, "Partido 23");
            Insertar(26, "Partido 20");
            Insertar(22, "Partido 15");
            Insertar(20, "Partido 5");
            Insertar(19, "Jugador 10");
            Insertar(21, "Jugador 11");
            Insertar(24, "Partido 6");
            Insertar(23, "Jugador 12");
            Insertar(25, "Jugador 13");
            Insertar(30, "Partido 16");
            Insertar(28, "Partido 7");
            Insertar(27, "Jugador 14");
            Insertar(29, "Jugador 15");
            Insertar(32, "Partido 8");
            Insertar(31, "Jugador 16");
            Insertar(33, "Jugador 17");
            Insertar(42, "Partido 21");
            Insertar(38, "Partido 17");
            Insertar(36, "Partido 9");
            Insertar(35, "Jugador 18");
            Insertar(37, "Jugador 19");
            Insertar(40, "Partido 10");
            Insertar(39, "Jugador 20");
            Insertar(41, "Jugador 21");
            Insertar(46, "Partido 18");
            Insertar(44, "Partido 11");
            Insertar(43, "Jugador 22");
            Insertar(45, "Jugador 23");
            Insertar(48, "Partido 12");
            Insertar(47, "Jugador 24");
            Insertar(49, "Jugador 25");
        }
        public void Insertar(int Info, string Letra) //Metodo el cual inserta los datos en el arbol
        {
            int Contador = 1; //Contador
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
                    Contador++;
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
            if (Altura == 0)
            {
                Altura = Contador;
            }
            else if (Contador > Altura)
            {
                Altura = Contador;
            }
            else { }
        }

        public void Impresion() //Impresion de los resultados
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("El ultimo partido es {0}, el cual es la misma cantidad de latas abiertas.", Raiz.Letra);
            Console.WriteLine("Cantidad de partidos que jugo el campeon: {0}", (Altura - 1));
            Console.WriteLine("Cantidad de partidos con 3 sets: {0}", (24 * 5));
        }
    }
}
