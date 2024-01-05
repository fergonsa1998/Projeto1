using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEAtributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xa, xb, xc, ya, yb, yc;

            Console.WriteLine("Entre com as medidas do triângulo X");
            xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y");

            ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xa + xb + xc) / 2.00;
            double areax = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));

            p = (ya + yb + yc) / 2.0;
            double areay = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));

            Console.WriteLine("Area de X = " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

            if (areax > areay)
            {
                Console.WriteLine("Maior area X");
            }
            else
            {
                Console.WriteLine("Maior area y");
            }
        }
    }
}
