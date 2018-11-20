using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo abo = new Grafo(); //Se crea un objeto de la clase grafo
            //Se insertan datos en nuestro grafo
            abo.Insertar(100, "a");
            abo.Insertar(500, "b");
            abo.Insertar(250, "c");
            abo.Insertar(200, "g");
            abo.Insertar(150, "f");
            abo.Insertar(125, "d");
            abo.Insertar(130, "e");
            abo.Insertar(175, "e");
            abo.Insertar(180, "d");
            abo.Insertar(280, "d");
            abo.Insertar(260, "f");
            abo.Insertar(270, "g");
            abo.Insertar(281, "e");
            abo.Insertar(282, "f");
            abo.Insertar(283, "g");
            abo.Insertar(1000, "g");
            abo.Insertar(900, "c");
            abo.Insertar(800, "d");
            abo.Insertar(700, "f");
            abo.Insertar(600, "e");
            abo.Insertar(850, "e");
            abo.Insertar(899, "f");
            abo.Insertar(2000, "f");
            abo.Insertar(1500, "d");
            abo.Insertar(1250, "c");
            abo.Insertar(1800, "e");
            abo.Insertar(3000, "e");
            abo.Insertar(4000, "d");
            abo.Insertar(5000, "c");

            Console.WriteLine("Rutas");
            abo.ImpresionWeas();
            Console.ReadKey();
        }
    }
}
