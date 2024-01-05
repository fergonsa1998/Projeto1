using System;
using System.Runtime.Remoting.Messaging;


namespace ClassesEAtributosExe1
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Area()
        {
            double AreaTotal = Altura * Largura;
            return AreaTotal;
        }

        public double Perimetro()
        {
            double Perimetro = 2 * (Altura + Largura);
            return Perimetro;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }


}
