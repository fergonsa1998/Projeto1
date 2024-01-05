using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, raio = 150.00, pi = 3.14159;

            a = (raio * raio) * pi;

            Console.WriteLine(Math.Round(a, 4));
            Console.ReadLine();           
        }
    }
}

// using System;
// using System.Globalization;
// 
// namespace uri1002
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
// 
//             double r = 2, a, pi = 3.14159;
// 
//             a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// 
//             a = pi * (r * r);
// 
//             Console.WriteLine("A=" + a.ToString("F4", CultureInfo.InvariantCulture));
//         }
//     }
// }