using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para comvertir Metros a Yardas y viceversa");

            polimorfismo Prueba1 = new polimorfismo();

            Console.WriteLine("Yardas a Metros: 4yd = " + Prueba1.Convertir(4));
            Console.WriteLine("Yardas a Centimetros: 4yd = " + Prueba1.Convertir(4, 100));
            Console.WriteLine("Yardas a Milimetros: 4yd = " + Prueba1.Convertir(4, 100, 10));
            Console.WriteLine("Yardas a Micrometros: 4yd = " + Prueba1.Convertir(4, 100, 10, 1000));
            Console.ReadLine();
        }
    }
}
