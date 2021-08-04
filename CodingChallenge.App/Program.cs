using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija una opción por favor:");
            Console.WriteLine("A - una opcion");
            Console.WriteLine("B - una opcion");
            Console.WriteLine("C - una opcion");
            Console.WriteLine("D - una opcion");
            Console.WriteLine("E - Salir");


            Console.WriteLine("Elija una opción por favor:");
            Console.WriteLine("Elija una opción por favor:");
            Console.WriteLine("Elija una opción por favor:");
            FormaGeometrica formas = new FormaGeometrica(1, 2);
            var mostrarArea = formas.CalcularArea();
            Console.WriteLine(mostrarArea.ToString());
        }
    }
}
