using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Vetores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };            
            }

            decimal sum = 0;

            for(int i = 0; i < n;i++)
            {
                sum += vect[i].Price;
            }

            decimal avg = sum / n;
            Console.WriteLine("Preço médio = " + avg.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}