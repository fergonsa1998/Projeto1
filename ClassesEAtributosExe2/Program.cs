using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEAtributosExe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa x = new Pessoa();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto :");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + x);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.CalculoSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + x);
        }
    }
}
