using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Divisao
{
    internal class Divisao : IDivisao
    {
        public double divisao(double valor1, double valor2)
        {
            return (double)(valor1 / valor2);
        }
    }
}
