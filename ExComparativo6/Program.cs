using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComparativo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (intervalo < 0.00 || intervalo > 100.00)
            {
                Console.WriteLine("Fora do intervalo");
            }

            else if (intervalo > 0.0 && intervalo < 25.00)
            {
                Console.WriteLine("Intervalo entre 0 e 25");
            }

            else if (intervalo <= 50.00)
            {
                Console.WriteLine("Intervalo entre 25 e 50");
            }

            else if (intervalo <= 75.00)
            {
                Console.WriteLine("Intervalo entre 50 e 75");
            }

            else
            {
                Console.WriteLine("Intervalo entre 75 e 100");
            }

            Console.ReadLine();
        }
    }
}
