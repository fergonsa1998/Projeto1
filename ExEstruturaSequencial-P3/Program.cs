using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExEstruturaSequencial_P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pa = 5;
            int pb = 6;
            int pc = -7;
            int pd = 8;

            int p1 = pa * pb;
            int p2 = pc * pd;

            Console.WriteLine("A diferença entre os Produtos A e B para os Produtos C e D é de " + (p2 - p1));
            Console.ReadLine();
        }
    }
}
