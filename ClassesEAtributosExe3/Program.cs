using System;
using System.Globalization;

namespace ClassesEAtributosExe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Desempenho aluno = new Desempenho();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 03 notas do aluno: ");
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }

            Console.Write("Faltaram: " + aluno.NotaRestante() + " Pontos.");
            Console.WriteLine();

        }
    }
}
