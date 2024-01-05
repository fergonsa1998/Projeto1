using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //o comando console.readline converte somente em string, então para numeros inteiros ele nao funciona, é necssario inserir o comando int.parse
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            string[] vs = Console.ReadLine().Split(' ');
            string nome = vs[0];
            char sexo = char.Parse(vs[1]);
            int idade = int.Parse(vs[2]);
            double altura = double.Parse(vs[3],CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
