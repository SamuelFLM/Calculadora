using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Multiplicacao
{
    internal class Multiplicacao : IMultiplicacao
    {
        public double multiplicacao(double valor1, double valor2)
        {
           return valor1 * valor2;
        }
    }
}
