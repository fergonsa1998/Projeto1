using System;
using System.Globalization;


namespace ClassesEAtributosExe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo forma = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            forma.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            forma.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = forma.Area();
            Console.WriteLine("Area = " + area);
            double areap = forma.Perimetro();
            Console.WriteLine("Perimetro = " + areap);
            double aread = forma.Diagonal();
            Console.WriteLine("Diagonal = " + aread);
        }
    }
}