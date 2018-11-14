using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArboles
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Salir = false;
            bool Proceso = true, ProcesoAux = false;
            do
            {
                int Opc = 0;
                Arbol abo = new Arbol(); //Se crea un objeto de la clase arbol
                try
                {
                    Console.Clear();
                    Console.WriteLine("Escoge una opcion");
                    Console.WriteLine("1.- Arbol 1");
                    Console.WriteLine("2.- Arbol 2");
                    Console.WriteLine("3.- Arbol 3");
                    Console.WriteLine("4.- Salir");
                    Console.Write("R: ");
                    Opc = Convert.ToInt32(Console.ReadLine());

                    switch (Opc) //Se insertan datos en nuestro arbol
                    {
                        case 1:
                            abo.Insertar(5, "E");
                            abo.Insertar(6, "F");
                            abo.Insertar(1, "A");
                            abo.Insertar(2, "B");
                            abo.Insertar(3, "C");
                            abo.Insertar(4, "D");
                            Proceso = true;
                            ProcesoAux = false;
                            break;
                        case 2:
                            abo.Insertar(3, "C");
                            abo.Insertar(1, "A");
                            abo.Insertar(2, "B");
                            abo.Insertar(5, "E");
                            abo.Insertar(4, "D");
                            abo.Insertar(6, "F");
                            abo.Insertar(7, "G");
                            Proceso = true;
                            ProcesoAux = false;
                            break;
                        case 3:
                            abo.Insertar(11, "K");
                            abo.Insertar(4, "D");
                            abo.Insertar(3, "C");
                            abo.Insertar(2, "B");
                            abo.Insertar(1, "A");
                            abo.Insertar(9, "I");
                            abo.Insertar(5, "E");
                            abo.Insertar(6, "F");
                            abo.Insertar(7, "G");
                            abo.Insertar(8, "H");
                            abo.Insertar(10, "J");
                            Proceso = true;
                            ProcesoAux = true;
                            break;
                        case 4:
                            Salir = true;
                            Proceso = false;
                            ProcesoAux = false;
                            break;
                        default:
                            Console.WriteLine("Ha ocurrido un error.");
                            Proceso = false;
                            ProcesoAux = false;
                            break;
                    }

                    if(Proceso == true)
                    {
                        //Impresion en preorden
                        Console.WriteLine("Impresion preorden: ");
                        abo.ImprimirPre();
                        //Impresion en entreorden
                        Console.WriteLine("Impresion inorden: ");
                        abo.ImprimirEntre();
                        //Impresion en postorden
                        Console.WriteLine("Impresion postorden: ");
                        abo.ImprimirPost();
                        //Impresion de los datos
                        abo.ImpresionDeLasWeas();

                        if(ProcesoAux == true)
                        {
                            Console.WriteLine("Ruta a C: K->D->C");
                            Console.WriteLine("Ruta a H: K->D->I->E->F->G->H");
                            Console.WriteLine("Ruta a J: K->D->I->J");
                        }
                    }
                }
                catch{ Console.WriteLine("Ha ocurrido un error."); Proceso = true; ProcesoAux = false; }
                Console.WriteLine("Preciona una tecla para continuar.");
                Console.ReadKey();
            } while (Salir == false);
        }
    }
}
