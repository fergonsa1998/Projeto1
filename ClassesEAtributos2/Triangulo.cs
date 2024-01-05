using System;

namespace ClassesEAtributos2
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;

            // você pode declarar o resultando da raiz utilizando 'returun Math.Sqrt(p * (p - A) * (p - B) * (p - C));'  
        }
    }
}
