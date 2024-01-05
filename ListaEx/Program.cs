using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos funcionários vão ser registrados?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Empregado #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               list.Add(new Funcionario(id, name, salario));
            }

            Console.WriteLine();
            Console.Write("Entre com o Id do funcionário que vai ter aumento:");
            int idfuncionario = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == idfuncionario);
            if(emp != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este Id não existe.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos funcionários");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
