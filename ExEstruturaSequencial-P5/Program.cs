using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEstruturaSequencial_P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p1 = 1, p2 = 2;
            int q1 = 1, q2 = 1;
            double v1 = 15.10, v2 = 15.10;

            double produto1 = q1 * v1;
            double produto2 = q2 * v2;
            double total = produto1 + produto2;

            Console.WriteLine("O Produto " + p1 + " custará R$ " + produto1.ToString("F2",CultureInfo.InvariantCulture) +  " e o Produto " + p2 + " custará R$ " + 
                produto2.ToString("F2", CultureInfo.InvariantCulture) + " totalizando R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();


        }
    }
}
