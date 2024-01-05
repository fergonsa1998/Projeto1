using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEstruturaSequencial_P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 6;
            double hrs = 145;
            double dolar = 15.55;

            double salario = hrs * dolar;

            Console.WriteLine(" O salario do funcionário Nº: " + numero + " corresponde a U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine(); 
        }
    }
}
