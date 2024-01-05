using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEAtributosExe2
{
    internal class Pessoa
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void CalculoSalario(double porcentagem = 10.00)

        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
               + ", R$ "
               + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
