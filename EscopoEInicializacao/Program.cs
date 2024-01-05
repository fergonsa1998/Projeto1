using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscopoEInicializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco > 100.00)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
            Console.ReadLine();

        }
    }
}
