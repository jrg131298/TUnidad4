using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol abo = new Arbol(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            abo.Insertar(100);
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
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
            Console.WriteLine("\nPreciona una tecla para salir del programa.");
            Console.ReadKey();
        }
    }

}
