using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEx
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; private set; }
        
        public Funcionario(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.00;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture); 
        }


    }
}
