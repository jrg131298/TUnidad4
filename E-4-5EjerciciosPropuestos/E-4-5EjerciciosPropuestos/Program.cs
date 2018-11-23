using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_5EjerciciosPropuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Salir = false; //Nos permite permanecer en le programa
            int Opcion = 0; //Captura la opcion
            do //Ciclo repetitivo
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("***********************Ejercicios Propuestos***********************"); //Menu
                    Console.WriteLine("Ingrese el numero de la opcion que desees:");
                    Console.WriteLine("1.- Ejercicio 1");
                    Console.WriteLine("2.- Ejercicio 2");
                    Console.WriteLine("3.- Ejercicio 3");
                    Console.WriteLine("4.- Ejercicio 4");
                    Console.WriteLine("5.- Ejercicio 5");
                    Console.WriteLine("6.- Ejercicio 6");
                    Console.WriteLine("7.- Ejercicio 7");
                    Console.WriteLine("8.- Ejercicio 8");
                    Console.WriteLine("9.- Ejercicio 9");
                    Console.WriteLine("10.- Ejercicio 10");
                    Console.WriteLine("0.- Salir");
                    Console.Write("R: ");
                    Opcion = Convert.ToInt32(Console.ReadLine());

                    switch (Opcion) //Nos permite ejecutar un programa dependiendo de la respuesta del usuario
                    {
                        case 1:
                            Ejericio1 E1 = new Ejericio1();
                            E1.Captura();
                            E1.Impresion();
                            break;
                        case 2:
                            Ejercicio2 E2 = new Ejercicio2();
                            E2.Captura();
                            E2.Impresion();
                            break;
                        case 3:
                            Ejercicio3 E3 = new Ejercicio3();
                            E3.Captura();
                            Console.Clear();
                            Console.WriteLine("Impresion en Posterior");
                            E3.ImprimirPost();
                            break;
                        case 4:
                            Ejercicio4 E4 = new Ejercicio4();
                            E4.Captura();
                            E4.Consulta();
                            break;
                        case 5:
                            Ejercicio5 E5 = new Ejercicio5();
                            E5.Captura();
                            E5.Consulta();
                            break;
                        case 6:
                            Ejercicio6 E6 = new Ejercicio6();
                            E6.Captura();
                            E6.Consulta();
                            break;
                        case 7:
                            Ejercicio7 E7 = new Ejercicio7();
                            E7.Captura();
                            break;
                        case 8:
                            Ejercicio8 E8 = new Ejercicio8();
                            E8.Captura();
                            break;
                        case 9:
                            //Jiji
                            break;
                        case 10:
                            //Jiji
                            break;
                        case 0:
                            Salir = true;
                            break;
                        default:
                            Console.WriteLine("A ocurrido un error.");
                            break;
                    }
                    Console.WriteLine("Precione una tecla para continuar.");
                }
                catch //Captura de errores
                {
                    Console.WriteLine("A ocurrido un error.\nPrecione una tecla para continuar.");
                }
                Console.ReadKey();
            } while (Salir == false);
        }
    }
}
