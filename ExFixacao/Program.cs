using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ExFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura:");
            string[] pessoa = Console.ReadLine().Split(' ');
            string sobrenome = pessoa[0];
            int idade = int.Parse(pessoa[1]);
            double altura = double.Parse(pessoa[2], CultureInfo.InvariantCulture);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();


        }
    }
}
