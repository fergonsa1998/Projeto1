using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizesEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int[,] mat = new int[n,n];

            for(int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(valores[j]);
                } 
            }


            Console.WriteLine("Diagonal principal");
            for (int i = 0; i < n;i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            int contagem = 0;
            for (int i = 0;i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        contagem++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Numeros negativos: " + contagem);
        }
    }
}
