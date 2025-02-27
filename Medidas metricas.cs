using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class polimorfismo
    {

    
        public class Valores
        {
            public static double yardasm = 1.09361;
            public static double metrosy = 0.9144;

        }
        public double Convertir(double Yardas)
        {
            return Yardas * Valores.metrosy;

        }
        public double Convertir(double Yardas, double Centimetros)
        {

            return Yardas * Valores.metrosy * Centimetros;

        }
        public double Convertir(double Yardas, double Centimetros, double Milimetros)
        {

            return Yardas * Valores.metrosy * Centimetros * Milimetros;

        }
        public double Convertir(double Yardas, double Centimetros, double Milimetros, double Micrometro)
        {

            return Yardas * Valores.metrosy * Centimetros * Milimetros * Micrometro;

        }
    }
}

