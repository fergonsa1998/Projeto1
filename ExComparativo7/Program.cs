using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComparativo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }

            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }

            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
                Console.WriteLine("Q4");

            Console.ReadLine();
        }
    }
}
