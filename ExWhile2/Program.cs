using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = -1;
            int y = -1;

            while (x != 0 && y != 0)
            {
                Console.WriteLine("Digite os valores: ");
                string[] valor = Console.ReadLine().Split(' ');
                x = int.Parse(valor[0]);
                y = int.Parse(valor[1]);


                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro!");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo!");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro!");
                }
                else if (x == 0 || y == 0)
                {
                    Console.WriteLine("Nulo!");
                }
                else
                {
                    Console.WriteLine("Quarto!");
                }
            }
        }
    }
}
