﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticosEx
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.00;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.00;
        }
    }
}