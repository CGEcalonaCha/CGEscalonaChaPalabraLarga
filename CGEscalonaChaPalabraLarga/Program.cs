using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGEscalonaChaPalabraLarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palabra mas larga");

            Console.WriteLine("Ingrese la Cadena");
            string cadena = Console.ReadLine();
            string[] palabras = cadena.Split();

            string palabralarga = "";

            foreach (string palabra in palabras)
            {
                if (palabra.Length > palabralarga.Length)
                {
                    palabralarga = palabra;
                }
            }
            Console.WriteLine($" La palabra ams larga es {palabralarga}");
            Console.ReadKey();
        }
    }
}
