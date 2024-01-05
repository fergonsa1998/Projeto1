using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234537;

            Console.WriteLine($" Produtos: {produto1}, cujo preço é $ {preco1:F2} \r\n {produto2} , cujo preço é $ {preco2:F2}\r\n \r\n Registro {idade} anos de idade, código {codigo} e genero: {genero} \r\n \r\n Medida com oito casas decimais: {medida:F8} \r\n Arredondando (três casas decimais {medida:F3} \r\n Separador decimal invariant culture:" + medida.ToString("F3",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
