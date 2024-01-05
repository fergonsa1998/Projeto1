using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;

            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            // Console.WriteLine(nome);
            // Console.WriteLine(saldo.ToString("f3");
            // para declarar cultureinfo é necessario declarar no começo do código o system.globalization
            Console.WriteLine(saldo.ToString("f4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
