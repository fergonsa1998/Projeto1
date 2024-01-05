using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComparativo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] horas = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O jogo durou " + duracao + " horas");
            Console.ReadLine();
        }
    }
}
