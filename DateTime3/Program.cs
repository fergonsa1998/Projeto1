using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DateTime3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Propriedades e Operações com DATETIME


            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime ex1 = new DateTime(2000, 10, 15);
            DateTime ex2 = new DateTime(2000, 10, 18);
            TimeSpan t = ex1.Subtract(ex2);


            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(t);


        }
    }
}
