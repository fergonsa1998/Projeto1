using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEAtributosExe3
{
    internal class Desempenho
    {
        public double nota1, nota2, nota3;
        public string Nome;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.00;
            }
            else
            {
                return 60.00 - NotaFinal();
            }
        }
    }
}
