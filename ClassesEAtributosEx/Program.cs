﻿using System;
using Pessoas;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEAtributosEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();


            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }         
        }
    }
}
