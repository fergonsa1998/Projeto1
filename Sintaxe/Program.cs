using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 03 números");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
            Console.ReadLine();
        }


        static int Maior(int n1, int n2, int n3)
        {
            int m;
            if (n1 > n2 && n1 > n3)
            {
                m = n1;
            }

            else if (n2 > n3)
            {  
                m = n2;
            }
            else
            {
                m = n3;
            }

            return m;
        }

    }
}
