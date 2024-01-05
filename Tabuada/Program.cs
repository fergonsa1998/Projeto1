using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador, numero;

            Console.WriteLine("Digite um número.");

            numero = int.Parse(Console.ReadLine()); 

            for (contador = 1; contador <= 10; contador++)
            {
                for (numero = 1; numero <= 10; numero++)
                {
                    Console.WriteLine(numero + " x " + contador + " = " + numero * contador);
                }
            }


            Console.ReadLine();
        }
    }
}

